using System;
using System.Collections.Generic;
using MonoCloud.SDK.Core.Helpers;
using System.Text.Json.Serialization;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Patch Generic Branding Custom Sms Options Request class
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchBrandingGenericCustomSmsOptionsRequest>))]
public class PatchBrandingGenericCustomSmsOptionsRequest
{
   /// <summary>
   /// Specifies whether to use the custom template.
   /// </summary>
   public Optional<bool> UseCustomTemplate { get; set; }

   /// <summary>
   /// Custom LiquidJS template for the SMS
   /// </summary>
   public Optional<string?> Template { get; set; }
}


