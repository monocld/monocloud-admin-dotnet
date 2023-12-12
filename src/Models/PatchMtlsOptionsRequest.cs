using System;
using System.Collections.Generic;
using MonoCloud.SDK.Core.Helpers;
using System.Text.Json.Serialization;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Patch Mtls Options Request class
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchMtlsOptionsRequest>))]
public class PatchMtlsOptionsRequest
{
   /// <summary>
   /// Enable MTLS
   /// </summary>
   public Optional<bool> Enabled { get; set; }

   /// <summary>
   /// Specifies the permitted certificate types.
   /// </summary>
   public Optional<CertificateTypes> AllowedCertificateTypes { get; set; }

   /// <summary>
   /// If set to true, will validates whether the certificate is intended for authentication
   /// </summary>
   public Optional<bool> ValidateCertificateUse { get; set; }

   /// <summary>
   /// If set to true, will verify the certificate&#39;s validity period
   /// </summary>
   public Optional<bool> ValidateValidityPeriod { get; set; }

   /// <summary>
   /// Specifies the type of revocation check.
   /// </summary>
   public Optional<X509RevocationMode> RevocationMode { get; set; }
}


