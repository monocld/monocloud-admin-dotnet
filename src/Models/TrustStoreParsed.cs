using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// Trust Store Parsed Response
/// </summary>
public class TrustStoreParsed
{
   /// <summary>
   /// List of certificates.
   /// </summary>
   public List<TrustStoreCertificateParsed> Certificates { get; set; }

   /// <summary>
   /// List of certificate revocations.
   /// </summary>
   public List<TrustStoreRevocationParsed> Revocations { get; set; }

   /// <summary>
   /// List of banned certificate thumbprints.
   /// </summary>
   public List<string> BannedThumbprints { get; set; }
}


