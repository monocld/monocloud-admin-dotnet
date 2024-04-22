using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Api Resource response class
/// </summary>
public class ApiResource
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
   /// The audience that will be added to the outgoing access token.
   /// </summary>
   public required string Audience { get; set; }

   /// <summary>
   /// The Api secret is used for the introspection endpoint. The API can authenticate with introspection using the API name and secret.
   /// </summary>
   public required List<Secret> ApiSecrets { get; set; }

   /// <summary>
   /// List of API scope names.
   /// </summary>
   public required List<string> Scopes { get; set; }

   /// <summary>
   /// List of associated user claim types that should be included in the Access token.
   /// </summary>
   public required List<string> UserClaims { get; set; }
}


