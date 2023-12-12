using System;
using System.Collections.Generic;
using MonoCloud.SDK.Core.Helpers;
using System.Text.Json.Serialization;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Patch Identifiers Options Request class
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchIdentifiersOptionsRequest>))]
public class PatchIdentifiersOptionsRequest
{
   /// <summary>
   /// Email Identifier Options
   /// </summary>
   public Optional<PatchIdentifiersEmailOptionsRequest> Email { get; set; }

   /// <summary>
   /// Phone Identifier Options
   /// </summary>
   public Optional<PatchIdentifiersPhoneOptionsRequest> Phone { get; set; }

   /// <summary>
   /// Username Identifier Options
   /// </summary>
   public Optional<PatchIdentifiersUsernameOptionsRequest> Username { get; set; }
}


