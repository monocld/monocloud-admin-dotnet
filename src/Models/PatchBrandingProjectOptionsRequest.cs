using System;
using System.Collections.Generic;
using MonoCloud.SDK.Core.Helpers;
using System.Text.Json.Serialization;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Patch Branding Project Options Request class
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchBrandingProjectOptionsRequest>))]
public class PatchBrandingProjectOptionsRequest
{
   /// <summary>
   /// Project Url
   /// </summary>
   public Optional<string?> DefaultUrl { get; set; }

   /// <summary>
   /// Support Url
   /// </summary>
   public Optional<string?> SupportUrl { get; set; }

   /// <summary>
   /// Support Email
   /// </summary>
   public Optional<string?> SupportEmail { get; set; }
}


