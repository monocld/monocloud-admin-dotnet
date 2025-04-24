using System;
using System.Collections.Generic;
using MonoCloud.SDK.Core.Helpers;
using System.Text.Json.Serialization;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Patch Api Resource Client class
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchApiResourceClientRequest>))]
public class PatchApiResourceClientRequest
{
   /// <summary>
   /// Specifies the api scopes the client is allowed to access (by default the client has access to all the resource scopes)
   /// </summary>
   public Optional<List<string>> RestrictedScopes { get; set; }
}


