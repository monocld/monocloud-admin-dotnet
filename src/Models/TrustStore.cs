using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// Trust Store Response
/// </summary>
public class TrustStore
{
   /// <summary>
   /// List of certificates.
   /// </summary>
   public required List<TrustStoreCertificate> Certificates { get; set; }

   /// <summary>
   /// List of certificate revocations.
   /// </summary>
   public required List<TrustStoreRevocation> Revocations { get; set; }

   /// <summary>
   /// List of banned certificate thumbprints.
   /// </summary>
   public required List<string> BannedThumbprints { get; set; }
}


