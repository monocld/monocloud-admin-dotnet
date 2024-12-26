using System;
using System.Collections.Generic;
using MonoCloud.SDK.Core.Helpers;
using System.Text.Json.Serialization;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Patch Branding Page Options Request class
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchBrandingPageOptionsRequest>))]
public class PatchBrandingPageOptionsRequest
{
   /// <summary>
   /// Page Branding Logo Options
   /// </summary>
   public Optional<PatchBrandingPageLogoOptionsRequest> Logo { get; set; }

   /// <summary>
   /// Page Branding Layout Options
   /// </summary>
   public Optional<PatchBrandingPageLayoutOptionsRequest> Layout { get; set; }

   /// <summary>
   /// Page Branding Link Options
   /// </summary>
   public Optional<PatchBrandingPageLinkOptionsRequest> Link { get; set; }

   /// <summary>
   /// Page Branding Link Options
   /// </summary>
   public Optional<PatchBrandingPageInputOptionsRequest> Input { get; set; }

   /// <summary>
   /// Page Branding Checkbox Options
   /// </summary>
   public Optional<PatchBrandingPageCheckboxOptionsRequest> Checkbox { get; set; }

   /// <summary>
   /// Page Branding Button Options
   /// </summary>
   public Optional<PatchBrandingPageButtonOptionsRequest> Button { get; set; }

   /// <summary>
   /// Page Branding Provider Button Options
   /// </summary>
   public Optional<PatchBrandingPageProviderButtonOptionsRequest> ProviderButton { get; set; }

   /// <summary>
   /// Page Branding Code Options
   /// </summary>
   public Optional<PatchBrandingPageCodeOptionsRequest> Code { get; set; }

   /// <summary>
   /// Page Branding Text Options
   /// </summary>
   public Optional<PatchBrandingPageTextOptionsRequest> Text { get; set; }
}


