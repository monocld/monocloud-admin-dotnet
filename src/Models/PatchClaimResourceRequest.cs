using System;
using System.Collections.Generic;
using MonoCloud.SDK.Core.Helpers;
using System.Text.Json.Serialization;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Patch Claim Resource class
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchClaimResourceRequest>))]
public class PatchClaimResourceRequest
{
   /// <summary>
   /// Specifies if the resource is enabled.
   /// </summary>
   public Optional<bool> Enabled { get; set; }

   /// <summary>
   /// Display Name for the Resource
   /// </summary>
   public Optional<string?> DisplayName { get; set; }

   /// <summary>
   /// A brief description about the Resource
   /// </summary>
   public Optional<string?> Description { get; set; }

   /// <summary>
   /// Specifies whether this resource is shown in the discovery document.
   /// </summary>
   public Optional<bool> ShowInDiscoveryDocument { get; set; }

   /// <summary>
   /// The unique name of the claim.
   /// </summary>
   public Optional<string> Name { get; set; }

   /// <summary>
   /// Specifies the source of the claim.
   /// </summary>
   public Optional<string> Source { get; set; }

   /// <summary>
   /// Specifies whether the user can de-select the claim on the consent screen (if such a feature is implemented in the consent screen).
   /// </summary>
   public Optional<bool> Required { get; set; }

   /// <summary>
   /// Specifies whether the consent screen will emphasize this claim (if such a feature is implemented in the consent screen). Use this setting for sensitive or important scopes.
   /// </summary>
   public Optional<bool> Emphasize { get; set; }
}


