using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Claim Resource response class
/// </summary>
public class ClaimResource
{
   /// <summary>
   /// Unique ID of the Resource
   /// </summary>
   public required string Id { get; set; }

   /// <summary>
   /// Specifies if the resource is enabled.
   /// </summary>
   public required bool Enabled { get; set; }

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
   public required bool ShowInDiscoveryDocument { get; set; }

   /// <summary>
   /// Specifies the creation time of the resource (in Epoch).
   /// </summary>
   public required DateTime CreationTime { get; set; }

   /// <summary>
   /// Specifies the last update time of the resource (in Epoch).
   /// </summary>
   public required DateTime LastUpdated { get; set; }

   /// <summary>
   /// The unique name of the claim.
   /// </summary>
   public required string Name { get; set; }

   /// <summary>
   /// Specifies the source of the claim.
   /// </summary>
   public required string Source { get; set; }

   /// <summary>
   /// Specifies whether the user can de-select the claim on the consent screen (if such a feature is implemented in the consent screen).
   /// </summary>
   public required bool Required { get; set; }

   /// <summary>
   /// Specifies whether the consent screen will emphasize this claim (if such a feature is implemented in the consent screen). Use this setting for sensitive or important scopes.
   /// </summary>
   public required bool Emphasize { get; set; }

   /// <summary>
   /// Specifies whether it&#39;s a built-in claim resource.
   /// </summary>
   public required bool IsDefault { get; set; }
}


