using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Branding Page Button Options response class
/// </summary>
public class BrandingPageButtonOptions
{
   /// <summary>
   /// Specifies the font size (in Rem) of the text contained in the button
   /// </summary>
   public required float FontSize { get; set; }

   /// <summary>
   /// Specifies the vertical padding (in Pixels) of the button
   /// </summary>
   public required float PaddingY { get; set; }

   /// <summary>
   /// Specifies the border radius (in Pixels) of the button
   /// </summary>
   public required int BorderRadius { get; set; }

   /// <summary>
   /// Specifies the border color (in Hex) of the button
   /// </summary>
   public required string BorderColor { get; set; }

   /// <summary>
   /// Specifies the border width (in Pixels) of the button
   /// </summary>
   public required float BorderWidth { get; set; }

   /// <summary>
   /// Specifies the box-shadow of the button
   /// </summary>
   public required BrandingGenericPageShadowOptions Shadow { get; set; }

   /// <summary>
   /// Specifies the background of the button
   /// </summary>
   public required BrandingGenericPageBackgroundOptions Background { get; set; }

   /// <summary>
   /// Specifies the color (in Hex) of the text contained in the button
   /// </summary>
   public required string TextColor { get; set; }

   /// <summary>
   /// Specifies the border color (in Hex) of the button when it is in the hover state
   /// </summary>
   public required string HoverBorderColor { get; set; }

   /// <summary>
   /// Specifies the border width (in Pixels) of the button when it is in the hover state
   /// </summary>
   public required float HoverBorderWidth { get; set; }

   /// <summary>
   /// Specifies the box-shadow of the button when it is in the hover state
   /// </summary>
   public required BrandingGenericPageShadowOptions HoverShadow { get; set; }

   /// <summary>
   /// Specifies the background of the button when it is in the hover state
   /// </summary>
   public required BrandingGenericPageBackgroundOptions HoverBackground { get; set; }

   /// <summary>
   /// Specifies the color (in Hex) of the text contained in the button when it is in the hover state
   /// </summary>
   public required string HoverTextColor { get; set; }

   /// <summary>
   /// Specifies the border color (in Hex) of the outline type button
   /// </summary>
   public required string OutlineBorderColor { get; set; }

   /// <summary>
   /// Specifies border width (in Pixels) of the outline type button
   /// </summary>
   public required float OutlineBorderWidth { get; set; }

   /// <summary>
   /// Specifies the box-shadow of the outline type button
   /// </summary>
   public required BrandingGenericPageShadowOptions OutlineShadow { get; set; }

   /// <summary>
   /// Specifies the color (in Hex) of the text contained in the outline type button
   /// </summary>
   public required string OutlineTextColor { get; set; }

   /// <summary>
   /// Specifies border color (in Hex) of the outline type button when it is in the hover state
   /// </summary>
   public required string OutlineHoverBorderColor { get; set; }

   /// <summary>
   /// Specifies border width (in Pixels) of the outline type button when it is in the hover state
   /// </summary>
   public required float OutlineHoverBorderWidth { get; set; }

   /// <summary>
   /// Specifies the box-shadow of the outline type button when it is in the hover state
   /// </summary>
   public required BrandingGenericPageShadowOptions OutlineHoverShadow { get; set; }

   /// <summary>
   /// Specifies the color (in Hex) of the text contained in the outline type button when it is in the hover state
   /// </summary>
   public required string OutlineHoverTextColor { get; set; }
}


