using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Branding Page Link Options response class
/// </summary>
public class BrandingPageLinkOptions
{
   /// <summary>
   /// Specifies the color (in Hex) of the link text
   /// </summary>
   public required string Color { get; set; }

   /// <summary>
   /// Specifies the text decoration to be applied on the link text
   /// </summary>
   public required string Decoration { get; set; }

   /// <summary>
   /// Specifies the color of the link text when it is in the hover state
   /// </summary>
   public required string HoverColor { get; set; }

   /// <summary>
   /// Specifies the text decoration to be applied on the link text when it is in the hover state
   /// </summary>
   public required string HoverDecoration { get; set; }
}


