using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Mtls Options response class
/// </summary>
public class MtlsOptions
{
   /// <summary>
   /// Enable MTLS
   /// </summary>
   public bool Enabled { get; set; }

   /// <summary>
   /// Specifies the permitted certificate types.
   /// </summary>
   public CertificateTypes AllowedCertificateTypes { get; set; }

   /// <summary>
   /// If set to true, will validates whether the certificate is intended for authentication
   /// </summary>
   public bool ValidateCertificateUse { get; set; }

   /// <summary>
   /// If set to true, will verify the certificate&#39;s validity period
   /// </summary>
   public bool ValidateValidityPeriod { get; set; }

   /// <summary>
   /// Specifies the type of revocation check.
   /// </summary>
   public X509RevocationMode RevocationMode { get; set; }
}


