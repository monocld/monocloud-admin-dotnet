using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// Create Revocation Request.
/// </summary>
public class CreateTrustStoreRevocationRequest
{
   /// <summary>
   /// Specifies if the certificate is enabled.
   /// </summary>
   public bool Enabled { get; set; }

   /// <summary>
   /// Certificate Crl Value.
   /// </summary>
   public string Value { get; set; } = string.Empty;
}


