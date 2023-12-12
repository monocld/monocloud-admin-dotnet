using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// Trust Store Certificate Revocation Parsed Response
/// </summary>
public class TrustStoreRevocationParsed
{
   /// <summary>
   /// Certificate Id.
   /// </summary>
   public string Id { get; set; }

   /// <summary>
   /// Specifies if the certificate is enabled.
   /// </summary>
   public bool Enabled { get; set; }

   /// <summary>
   /// Certificate Crl Value.
   /// </summary>
   public string Value { get; set; }

   /// <summary>
   /// The associated name/alias for the crl.
   /// </summary>
   public string Name { get; set; }

   /// <summary>
   /// The algorithm used to create the crl.
   /// </summary>
   public string Algorithm { get; set; }

   /// <summary>
   /// The format version of the crl.
   /// </summary>
   public int _Version { get; set; }

   /// <summary>
   /// The certificate authority that issued the crl.
   /// </summary>
   public Dictionary<string, string> Issuer { get; set; }

   /// <summary>
   /// Specifies the last update time (in Epoch) of the crl.
   /// </summary>
   public long LastUpdate { get; set; }

   /// <summary>
   /// Specifies the time (in Epoch) at which the next update is supposed to happen.
   /// </summary>
   public long? NextUpdate { get; set; }
}


