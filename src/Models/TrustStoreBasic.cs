using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// Trust Store Basic Response
/// </summary>
public class TrustStoreBasic
{
   /// <summary>
   /// Id of the trust store
   /// </summary>
   public string Id { get; set; }

   /// <summary>
   /// Name of the trust store
   /// </summary>
   public string Name { get; set; }

   /// <summary>
   /// Specifies if the trust store is enabled.
   /// </summary>
   public bool Enabled { get; set; }

   /// <summary>
   /// Specifies if the trust store is the store used at the default MTLS endpoint.
   /// </summary>
   public bool IsDefault { get; set; }

   /// <summary>
   /// Specifies the number of certificates in the store.
   /// </summary>
   public int CertificateCount { get; set; }

   /// <summary>
   /// Specifies the number of banned thumbprints in the store.
   /// </summary>
   public int BannedThumbprintsCount { get; set; }

   /// <summary>
   /// Specifies the creation time of the trust store (in Epoch).
   /// </summary>
   public DateTime CreationTime { get; set; }

   /// <summary>
   /// Specifies the last update time of the trust store (in Epoch).
   /// </summary>
   public DateTime LastUpdated { get; set; }

   /// <summary>
   /// Specifies the trust store status.
   /// </summary>
   public TrustStoreStatus Status { get; set; }
}


