using System;
using System.Collections.Generic;
using MonoCloud.SDK.Core.Helpers;
using System.Text.Json.Serialization;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Patch Branding Page Logo Options Request class
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchBrandingPageLogoOptionsRequest>))]
public class PatchBrandingPageLogoOptionsRequest
{
   /// <summary>
   /// Specifies Uri of the project logo
   /// </summary>
   public Optional<string?> Uri { get; set; }

   /// <summary>
   /// Specifies the height (in Pixels) of the client / project logo
   /// </summary>
   public Optional<int> Height { get; set; }

   /// <summary>
   /// Specifies the horizontal position of the logo
   /// </summary>
   public Optional<string> Position { get; set; }
}


