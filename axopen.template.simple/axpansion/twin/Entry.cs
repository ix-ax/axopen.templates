// ixsharpblazor
// Copyright (c) 2023 Peter Kurhajec (PTKu), MTS,  and Contributors. All Rights Reserved.
// Contributors: https://github.com/ix-ax/axsharp/graphs/contributors
// See the LICENSE file in the repository root for more information.
// https://github.com/ix-ax/axsharp/blob/dev/LICENSE
// Third party licenses: https://github.com/ix-ax/axsharp/blob/master/notices.md

#define TIA

using AXSharp.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AXSharp.Connector.S71500.WebApi;
using System.Net.Security;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace axosimple
{
    public static class Entry
    {

#if HWC
        public static string TargetIp { get; } = Environment.GetEnvironmentVariable("AXTARGET"); // <- replace by your IP 
        private static string Pass => Environment.GetEnvironmentVariable("AX_TARGET_PWD");       //Environment.GetEnvironmentVariable("AX_TARGET_PWD"); // <- Pass in the password that you have set up for the user. NOT AS PLAIN TEXT! Use user secrets instead.
        private static string UserName = Environment.GetEnvironmentVariable("AX_USERNAME"); //<- replace by user name you have set up in your WebAPI settings        
        private const bool IgnoreSslErrors = true; // <- When you have your certificates in order set this to false.

        static string GetCertPath()
        {
            var fp = new FileInfo(Path.Combine(Assembly.GetExecutingAssembly().Location));
            return Path.Combine(fp.DirectoryName, ".certs\\plc_line.cer");
        }

        static X509Certificate2 customCertificate = new X509Certificate2(GetCertPath());

        private static bool CertificateValidation(HttpRequestMessage requestMessage, X509Certificate2 certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            return certificate.Thumbprint == customCertificate.Thumbprint;
        }

        public static axosimpleTwinController Plc { get; }
            = new(ConnectorAdapterBuilder.Build()
                .CreateWebApi(TargetIp, UserName, Pass, CertificateValidation, IgnoreSslErrors));
#endif

#if TIA
        public static string TargetIp { get; } = Environment.GetEnvironmentVariable("AXTARGET"); // <- replace by your IP 
        private static string Pass => @"123ABCDabcd$#!"; //Environment.GetEnvironmentVariable("AX_TARGET_PWD");       //Environment.GetEnvironmentVariable("AX_TARGET_PWD"); // <- Pass in the password that you have set up for the user. NOT AS PLAIN TEXT! Use user secrets instead.
        private static string UserName = "adm"; //Environment.GetEnvironmentVariable("AX_USERNAME"); //<- replace by user name you have set up in your WebAPI settings        
        private const bool IgnoreSslErrors = true; // <- When you have your certificates in order set this to false.

        static string GetCertPath()
        {
            var fp = new FileInfo(Path.Combine(Assembly.GetExecutingAssembly().Location));
            return Path.Combine(fp.DirectoryName, ".certs\\TIA\\Communication.cer");
        }

        static X509Certificate2 customCertificate = new X509Certificate2(GetCertPath());

        private static bool CertificateValidation(HttpRequestMessage requestMessage, X509Certificate2 certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            return certificate.Thumbprint == customCertificate.Thumbprint;
        }

        public static axosimpleTwinController Plc { get; }
            = new(ConnectorAdapterBuilder.Build()
                .CreateWebApi(TargetIp, UserName, Pass, CertificateValidation, IgnoreSslErrors));
#endif

#if TIA_NON_SECURE
        public static string TargetIp { get; } = "192.168.0.10";//Environment.GetEnvironmentVariable("AXTARGET"); // <- replace by your IP 
        private static string Pass => string.Empty; //Environment.GetEnvironmentVariable("AX_TARGET_PWD");       //Environment.GetEnvironmentVariable("AX_TARGET_PWD"); // <- Pass in the password that you have set up for the user. NOT AS PLAIN TEXT! Use user secrets instead.
        private static string UserName = "Everybody"; //Environment.GetEnvironmentVariable("AX_USERNAME"); //<- replace by user name you have set up in your WebAPI settings        
        private const bool IgnoreSslErrors = true; // <- When you have your certificates in order set this to false.

        public static axosimpleTwinController Plc { get; }
            = new(ConnectorAdapterBuilder.Build()
                .CreateWebApi(TargetIp, UserName, Pass, IgnoreSslErrors));
#endif        
    }

}