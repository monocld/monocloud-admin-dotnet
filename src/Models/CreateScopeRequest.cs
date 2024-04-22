using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Create Scope Resource class
/// </summary>
public class CreateScopeRequest
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
   /// The unique name of the scope. This is the value a client will use for the scope parameter in the authorize request.
   /// </summary>
   public required string Name { get; set; }

   /// <summary>
   /// Specifies the type of scope
   /// </summary>
   public ScopeTypes? Type { get; set; }

   /// <summary>
   /// Specifies whether the user can de-select the scope on the consent screen (if such a feature is implemented in the consent screen).
   /// </summary>
   public bool? Required { get; set; }

   /// <summary>
   /// Specifies whether the consent screen will emphasize this scope (if such a feature is implemented in the consent screen). Use this setting for sensitive or important scopes.
   /// </summary>
   public bool? Emphasize { get; set; }

   /// <summary>
   /// List of associated user claim types that should be included in the Identity token, Access Token or as returned from the User Info Endpoint.
   /// </summary>
   public required List<CreateScopeClaimRequest> UserClaims { get; set; }
}


