using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// Add Revocations Request.
/// </summary>
public class AddTrustStoreRevocationsRequest
{
   /// <summary>
   /// List of certificate revocations.
   /// </summary>
   public List<CreateTrustStoreRevocationRequest> Revocations { get; set; }
}


