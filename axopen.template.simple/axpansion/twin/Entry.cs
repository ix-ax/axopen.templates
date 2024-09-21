using AXSharp.Connector;
using AXSharp.Connector.S71500.WebApi;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using MongoDB.Driver.Core.Connections;

namespace axosimple
{
    public enum ConnectionType
    {
        Tia,
        Hwc,
        TiaNonSecure
    }

    public class ConnectionConfig
    {
        public string TargetIp { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public Func<HttpRequestMessage, X509Certificate2, X509Chain, SslPolicyErrors, bool>? CertificateValidationCallback { get; set; }
        public bool IgnoreSslErrors { get; set; } = true;
    }

    public class TwinConnectorSelector
    {
        
        public static string TargetIp { get; }
        private static axosimpleTwinController? _plcInstance;
        private static readonly object _lock = new();
        private static bool _isInitialized = false;

        // Dictionary to hold configurations for each connection type
        private static readonly Dictionary<ConnectionType, ConnectionConfig> _configurations = new();

        // Static constructor to initialize configurations
        static TwinConnectorSelector()
        {
            string assemblyDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? string.Empty;

            // Common settings
            TargetIp = Environment.GetEnvironmentVariable("AXTARGET") ?? "default_ip"; // Replace "default_ip" as needed
            string password = @"123ABCDabcd$#!"; // Replace with secure password handling
            string userName = "adm"; // Replace with secure username handling
            bool ignoreSslErrors = true; // Set to false in production

            // Certificate paths
            string tiaCertPath = Path.Combine(assemblyDir, ".certs", "TIA", "Communication.cer");
            string hwcCertPath = Path.Combine(assemblyDir, ".certs", "plc_line.cer");

            // Load certificates if they exist
            X509Certificate2? tiaCertificate = File.Exists(tiaCertPath) ? new X509Certificate2(tiaCertPath) : null;
            X509Certificate2? hwcCertificate = File.Exists(hwcCertPath) ? new X509Certificate2(hwcCertPath) : null;

            // Certificate validation callback
            Func<X509Certificate2, Func<HttpRequestMessage, X509Certificate2, X509Chain, SslPolicyErrors, bool>> createValidationCallback = expectedCert =>
            {
                return (requestMessage, certificate, chain, sslPolicyErrors) => certificate.Thumbprint == expectedCert.Thumbprint;
            };

            // Initialize configurations
            _configurations[ConnectionType.Tia] = new ConnectionConfig
            {
                TargetIp = TargetIp,
                UserName = userName,
                Password = password,
                CertificateValidationCallback = tiaCertificate != null ? createValidationCallback(tiaCertificate) : null,
                IgnoreSslErrors = ignoreSslErrors
            };

            _configurations[ConnectionType.Hwc] = new ConnectionConfig
            {
                TargetIp = TargetIp,
                UserName = userName,
                Password = password,
                CertificateValidationCallback = hwcCertificate != null ? createValidationCallback(hwcCertificate) : null,
                IgnoreSslErrors = ignoreSslErrors
            };

            _configurations[ConnectionType.TiaNonSecure] = new ConnectionConfig
            {
                TargetIp = TargetIp,
                UserName = "Everybody",
                Password = string.Empty,
                IgnoreSslErrors = ignoreSslErrors
                // No certificate validation callback needed for non-secure connection
            };
        }

        /// <summary>
        /// Initializes the TwinConnector with the specified connection type.
        /// </summary>
        public static void Initialize(ConnectionType connectionType)
        {
            if (_isInitialized)
                throw new InvalidOperationException("TwinConnectorSelector has already been initialized.");

            lock (_lock)
            {
                if (_isInitialized)
                    throw new InvalidOperationException("TwinConnectorSelector has already been initialized.");

                if (!_configurations.TryGetValue(connectionType, out var config))
                    throw new ArgumentException($"Configuration for connection type '{connectionType}' not found.");

                var builder = ConnectorAdapterBuilder.Build();
                ConnectorAdapter connectorAdapter;

                if (config.CertificateValidationCallback != null)
                {
                    // Use the overload with certificate validation callback
                    connectorAdapter = builder.CreateWebApi(
                        config.TargetIp,
                        config.UserName,
                        config.Password,
                        config.CertificateValidationCallback,
                        config.IgnoreSslErrors);
                }
                else
                {
                    // Use the overload without certificate validation callback
                    connectorAdapter = builder.CreateWebApi(
                        config.TargetIp,
                        config.UserName,
                        config.Password,
                        config.IgnoreSslErrors);
                }

                _plcInstance = new axosimpleTwinController(connectorAdapter);
                _isInitialized = true;
            }
        }

        /// <summary>
        /// Gets the singleton instance of the TwinController.
        /// </summary>
        public static axosimpleTwinController Plc
        {
            get
            {
                if (!_isInitialized)
                    throw new InvalidOperationException("TwinConnectorSelector is not initialized. Call Initialize() first.");

                return _plcInstance!;
            }
        }
    }

    public static class Entry
    {
        private static readonly Lazy<axosimpleTwinController> _plcInstance = new Lazy<axosimpleTwinController>(() =>
        {
            // Initialize the TwinConnectorSelector with the desired ConnectionType
            TwinConnectorSelector.Initialize(ConnectionType.Tia);

            // Return the initialized Plc instance
            return TwinConnectorSelector.Plc;
        }, System.Threading.LazyThreadSafetyMode.ExecutionAndPublication);

        /// <summary>
        /// Provides access to the singleton axosimpleTwinController instance.
        /// </summary>
        public static axosimpleTwinController Plc => _plcInstance.Value;
    }

}
