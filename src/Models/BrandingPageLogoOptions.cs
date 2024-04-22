using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Branding Page Logo Options response class
/// </summary>
public class BrandingPageLogoOptions
{
   /// <summary>
   /// Specifies Uri of the project logo
   /// </summary>
   public string? Uri { get; set; }

   /// <summary>
   /// Specifies the height (in Pixels) of the client / project logo
   /// </summary>
   public required int Height { get; set; }

   /// <summary>
   /// Specifies the horizontal position of the logo
   /// </summary>
   public required string Position { get; set; }
}


