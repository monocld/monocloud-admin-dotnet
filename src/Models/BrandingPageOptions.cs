using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Branding Page Options response class
/// </summary>
public class BrandingPageOptions
{
   /// <summary>
   /// Specifies Uri of the favicon that will be used on all pages
   /// </summary>
   public string? FaviconUri { get; set; }

   /// <summary>
   /// Page Branding Logo Options
   /// </summary>
   public required BrandingPageLogoOptions Logo { get; set; }

   /// <summary>
   /// Page Branding Layout Options
   /// </summary>
   public required BrandingPageLayoutOptions Layout { get; set; }

   /// <summary>
   /// Page Branding Link Options
   /// </summary>
   public required BrandingPageLinkOptions Link { get; set; }

   /// <summary>
   /// Page Branding Link Options
   /// </summary>
   public required BrandingPageInputOptions Input { get; set; }

   /// <summary>
   /// Page Branding Checkbox Options
   /// </summary>
   public required BrandingPageCheckboxOptions Checkbox { get; set; }

   /// <summary>
   /// Page Branding Button Options
   /// </summary>
   public required BrandingPageButtonOptions Button { get; set; }

   /// <summary>
   /// Page Branding Provider Button Options
   /// </summary>
   public required BrandingPageProviderButtonOptions ProviderButton { get; set; }

   /// <summary>
   /// Page Branding Code Options
   /// </summary>
   public required BrandingPageCodeOptions Code { get; set; }

   /// <summary>
   /// Page Branding Text Options
   /// </summary>
   public required BrandingPageTextOptions Text { get; set; }
}


