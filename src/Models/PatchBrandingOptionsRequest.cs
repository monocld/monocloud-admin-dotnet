using System;
using System.Collections.Generic;
using MonoCloud.SDK.Core.Helpers;
using System.Text.Json.Serialization;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Patch Branding Options Request class
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchBrandingOptionsRequest>))]
public class PatchBrandingOptionsRequest
{
   /// <summary>
   /// Email Branding Options
   /// </summary>
   public Optional<PatchBrandingEmailOptionsRequest> Email { get; set; }

   /// <summary>
   /// Sms Branding Options
   /// </summary>
   public Optional<PatchBrandingSmsOptionsRequest> Sms { get; set; }

   /// <summary>
   /// Page Branding Options
   /// </summary>
   public Optional<PatchBrandingPageOptionsRequest> Page { get; set; }
}


