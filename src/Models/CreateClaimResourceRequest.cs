using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Create Claim Resource class models an OpenID Connect or OAuth 2.0 claim resource
/// </summary>
public class CreateClaimResourceRequest
{
   /// <summary>
   /// Specifies if the resource is enabled.
   /// </summary>
   public bool? Enabled { get; set; }

   /// <summary>
   /// Display Name for the Resource
   /// </summary>
   public string? DisplayName { get; set; }

   /// <summary>
   /// A brief description about the Resource
   /// </summary>
   public string? Description { get; set; }

   /// <summary>
   /// Specifies whether this resource is shown in the discovery document.
   /// </summary>
   public bool? ShowInDiscoveryDocument { get; set; }

   /// <summary>
   /// The unique name of the claim.
   /// </summary>
   public string Name { get; set; }

   /// <summary>
   /// Specifies the source of the claim.
   /// </summary>
   public string Source { get; set; }
}


