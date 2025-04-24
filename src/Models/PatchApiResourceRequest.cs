using System;
using System.Collections.Generic;
using MonoCloud.SDK.Core.Helpers;
using System.Text.Json.Serialization;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Patch Api Resource class
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchApiResourceRequest>))]
public class PatchApiResourceRequest
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
   /// The audience that will be added to the outgoing access token.
   /// </summary>
   public Optional<string> Audience { get; set; }

   /// <summary>
   /// Specifies whether the resource requires an exclusive access token.
   /// </summary>
   public Optional<bool> RequireExclusiveToken { get; set; }

   /// <summary>
   /// List of associated user claim types that should be included in the Access token.
   /// </summary>
   public Optional<List<string>> UserClaims { get; set; }
}


