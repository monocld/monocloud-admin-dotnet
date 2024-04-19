using System;
using System.Collections.Generic;
using MonoCloud.SDK.Core.Helpers;
using System.Text.Json.Serialization;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Patch Pushed Authorization Options Request class
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchPushedAuthorizationOptionsRequest>))]
public class PatchPushedAuthorizationOptionsRequest
{
   /// <summary>
   /// Specifies whether Pushed Authorization Requests are required for authorization.
   /// </summary>
   public Optional<bool> RequirePushedAuthorizationRequests { get; set; }
}


