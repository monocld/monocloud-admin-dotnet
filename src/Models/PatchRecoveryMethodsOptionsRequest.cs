using System;
using System.Collections.Generic;
using MonoCloud.SDK.Core.Helpers;
using System.Text.Json.Serialization;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Patch Recovery Methods Options Request class
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchRecoveryMethodsOptionsRequest>))]
public class PatchRecoveryMethodsOptionsRequest
{
   /// <summary>
   /// Recovery Methods Email Options
   /// </summary>
   public Optional<PatchRecoveryMethodsEmailOptionsRequest> Email { get; set; }

   /// <summary>
   /// Recovery Methods Phone Options
   /// </summary>
   public Optional<PatchRecoveryMethodsPhoneOptionsRequest> Phone { get; set; }
}


