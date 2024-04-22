using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Branding Page Provider Button Options response class
/// </summary>
public class BrandingPageProviderButtonOptions
{
   /// <summary>
   /// Specifies the border radius (in Pixels) of the login provider buttons
   /// </summary>
   public required int BorderRadius { get; set; }

   /// <summary>
   /// Specifies the border color (in Hex) of the login provider buttons
   /// </summary>
   public required string BorderColor { get; set; }

   /// <summary>
   /// Specifies the border width (in Pixels) of the login provider buttons
   /// </summary>
   public required float BorderWidth { get; set; }

   /// <summary>
   /// Specifies the box-shadow of the login provider buttons
   /// </summary>
   public required BrandingGenericPageShadowOptions Shadow { get; set; }

   /// <summary>
   /// Specifies the background of the login provider buttons
   /// </summary>
   public required BrandingGenericPageBackgroundOptions Background { get; set; }

   /// <summary>
   /// Specifies the color (in Hex) of the text contained in the login provider buttons
   /// </summary>
   public required string TextColor { get; set; }

   /// <summary>
   /// Specifies the alignment of the text contained in the login provider buttons
   /// </summary>
   public required string TextAlignment { get; set; }

   /// <summary>
   /// Specifies the border color (in Hex) of the login provider buttons when in the hover state
   /// </summary>
   public required string HoverBorderColor { get; set; }

   /// <summary>
   /// Specifies the border width (in Pixels) of the login provider buttons when in the hover state
   /// </summary>
   public required float HoverBorderWidth { get; set; }

   /// <summary>
   /// Specifies the box-shadow of the login provider buttons when in the hover state
   /// </summary>
   public required BrandingGenericPageShadowOptions HoverShadow { get; set; }

   /// <summary>
   /// Specifies the background of the login provider buttons when in the hover state
   /// </summary>
   public required BrandingGenericPageBackgroundOptions HoverBackground { get; set; }

   /// <summary>
   /// Specifies the color (in Hex) of the text contained in the login provider buttons when in the hover state
   /// </summary>
   public required string HoverTextColor { get; set; }
}


