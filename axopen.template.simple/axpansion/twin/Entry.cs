#define TIA
// ixsharpblazor
// Copyright (c) 2023 Peter Kurhajec (PTKu), MTS,  and Contributors. All Rights Reserved.
// Contributors: https://github.com/ix-ax/axsharp/graphs/contributors
// See the LICENSE file in the repository root for more information.
// https://github.com/ix-ax/axsharp/blob/dev/LICENSE
// Third party licenses: https://github.com/ix-ax/axsharp/blob/master/notices.md

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
    public class TwinConnectorSelector
    {
        public static string TargetIp { get; } = Environment.GetEnvironmentVariable("AXTARGET"); // <- replace by your IP 
        private static string Pass => @"123ABCDabcd$#!"; //Environment.GetEnvironmentVariable("AX_TARGET_PWD");       //Environment.GetEnvironmentVariable("AX_TARGET_PWD"); // <- Pass in the password that you have set up for the user. NOT AS PLAIN TEXT! Use user secrets instead.
        private static string UserName = "adm"; //Environment.GetEnvironmentVariable("AX_USERNAME"); //<- replace by user name you have set up in your WebAPI settings        
        private const bool IgnoreSslErrors = true; // <- When you have your certificates in order set this to false.
        private static string CertificatePath = ".certs\\Communication.cer"; //".certs\\plc_line.cer"  

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
        public static s7_1516_v40TwinController SecurePlc { get; }
            = new(ConnectorAdapterBuilder.Build()
            .CreateWebApi(TargetIp, UserName, Pass, CertificateValidation, IgnoreSslErrors));

        // not compatible with FW 4.0
        //public static s7_1516_v40TwinController NonSecurePlc { get; }
        //    = new(ConnectorAdapterBuilder.Build()
        //        .CreateWebApi(TargetIp, "Everybody",string.Empty, IgnoreSslErrors));
    }
    
    public static class Entry
    {
        public static s7_1516_v40TwinController Plc {get; } = TwinConnectorSelector.SecurePlc;
    }
}