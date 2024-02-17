using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// Update Revocation Request.
/// </summary>
public class UpdateTrustStoreRevocationRequest
{
   /// <summary>
   /// Certificate Crl Value.
   /// </summary>
   public string Value { get; set; }
}


