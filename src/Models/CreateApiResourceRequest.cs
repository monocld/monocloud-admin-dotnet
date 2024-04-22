using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Create Api Resource class models an OpenID Connect or OAuth 2.0 api resource
/// </summary>
public class CreateApiResourceRequest
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
   /// The audience that will be added to the outgoing access token.
   /// </summary>
   public required string Audience { get; set; }

   /// <summary>
   /// The Api secret is used for the introspection endpoint. The API can authenticate with introspection using the API name and secret.
   /// </summary>
   public List<CreateSecretRequest> ApiSecrets { get; set; }

   /// <summary>
   /// List of API scope names.
   /// </summary>
   public required List<string> Scopes { get; set; }

   /// <summary>
   /// List of associated user claim types that should be included in the Access token.
   /// </summary>
   public required List<string> UserClaims { get; set; }
}


