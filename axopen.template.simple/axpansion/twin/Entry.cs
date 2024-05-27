﻿// ixsharpblazor
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
    public static class Entry
    {
        public static string TargetIp { get; } = Environment.GetEnvironmentVariable("AXTARGET"); // <- replace by your IP 

        private static string Pass => string.Empty;//Environment.GetEnvironmentVariable("AX_TARGET_PWD"); // <- Pass in the password that you have set up for the user. NOT AS PLAIN TEXT! Use user secrets instead.
        private const string UserName = "Anonymous"; //<- replace by user name you have set up in your WebAPI settings        

        private const bool IgnoreSslErrors = true; // <- When you have your certificates in order set this to false.

        // public static axosimpleTwinController Plc { get; } 
        //     = new (ConnectorAdapterBuilder.Build()
        //         .CreateWebApi(TargetIp, UserName, Pass, IgnoreSslErrors));


        static string GetCertPath()
        {
            var fp = new FileInfo(Path.Combine(Assembly.GetExecutingAssembly().Location));
            return Path.Combine(fp.DirectoryName, ".certs\\Certificate.cer");
        }

        static X509Certificate2 customCertificate = new X509Certificate2(GetCertPath());

        private static bool CertificateValidation(HttpRequestMessage requestMessage, X509Certificate2 certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            return certificate.Thumbprint == customCertificate.Thumbprint;
        }

        public static axosimpleTwinController Plc { get; }
            = new(ConnectorAdapterBuilder.Build()
                .CreateWebApi(TargetIp, UserName, Pass, CertificateValidation, IgnoreSslErrors));


    }
    
}