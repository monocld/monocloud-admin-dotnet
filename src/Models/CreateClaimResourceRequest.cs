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
   public bool Enabled { get; set; } = true;

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
   public bool ShowInDiscoveryDocument { get; set; } = true;

   /// <summary>
   /// The unique name of the claim.
   /// </summary>
   public string Name { get; set; } = string.Empty;

   /// <summary>
   /// Specifies the source of the claim.
   /// </summary>
   public string Source { get; set; } = string.Empty;

   /// <summary>
   /// Specifies whether the user can de-select the claim on the consent screen (if such a feature is implemented in the consent screen).
   /// </summary>
   public bool Required { get; set; } = false;

   /// <summary>
   /// Specifies whether the consent screen will emphasize this claim (if such a feature is implemented in the consent screen). Use this setting for sensitive or important scopes.
   /// </summary>
   public bool Emphasize { get; set; } = false;
}


