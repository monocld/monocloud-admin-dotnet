using System;
using System.Collections.Generic;
using MonoCloud.SDK.Core.Helpers;
using System.Text.Json.Serialization;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Patch Branding Analytics Options Request class
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchBrandingAnalyticsOptionsRequest>))]
public class PatchBrandingAnalyticsOptionsRequest
{
   /// <summary>
   /// Specifies the Google Analytics Tracking id.
   /// </summary>
   public Optional<string?> GaTrackingId { get; set; }
}


