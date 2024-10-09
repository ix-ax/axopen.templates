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
        public static string TargetIp { get; } = "10.222.6.1";//Environment.GetEnvironmentVariable("AXTARGET"); // <- replace by your IP 
        private static string Pass => @"123ABCDabcd$#!"; //Environment.GetEnvironmentVariable("AX_TARGET_PWD");       //Environment.GetEnvironmentVariable("AX_TARGET_PWD"); // <- Pass in the password that you have set up for the user. NOT AS PLAIN TEXT! Use user secrets instead.
        private static string UserName = "adm"; //Environment.GetEnvironmentVariable("AX_USERNAME"); //<- replace by user name you have set up in your WebAPI settings        
        private const bool IgnoreSslErrors = true; // <- When you have your certificates in order set this to false.
        private static string CertificatePath = "certs\\Communication.cer"; 

        static string GetCertPath()
        {
            var fp = new FileInfo(Path.Combine(Assembly.GetExecutingAssembly().Location));
            return Path.Combine(fp.DirectoryName, CertificatePath);
        }

        static readonly X509Certificate2 Certificate = new X509Certificate2(GetCertPath());

        private static bool CertificateValidation(HttpRequestMessage requestMessage, X509Certificate2 certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            return certificate.Thumbprint == Certificate.Thumbprint;
        }

        // Use only one twin controller.
        // Comment out all others that are not used in your case.
        public static axosimpleTwinController SecurePlc { get; }
            = new(ConnectorAdapterBuilder.Build()
            .CreateWebApi(TargetIp, UserName, Pass, CertificateValidation, IgnoreSslErrors));

        // not compatible with FW 4.0
        //public static axosimpleTwinController NonSecurePlc { get; }
        //    = new(ConnectorAdapterBuilder.Build()
        //        .CreateWebApi(TargetIp, "Everybody",string.Empty, IgnoreSslErrors));
    }

    public static class Entry
    {
        public static axosimpleTwinController Plc {get; } = TwinConnectorSelector.SecurePlc;
    }

}
