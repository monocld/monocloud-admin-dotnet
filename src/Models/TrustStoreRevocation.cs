using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// Trust Store Certificate Revocation Response
/// </summary>
public class TrustStoreRevocation
{
   /// <summary>
   /// Certificate Id.
   /// </summary>
   public required string Id { get; set; }

   /// <summary>
   /// Specifies if the certificate is enabled.
   /// </summary>
   public required bool Enabled { get; set; }

   /// <summary>
   /// Certificate Crl Value.
   /// </summary>
   public required string Value { get; set; }
}


