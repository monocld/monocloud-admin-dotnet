using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Branding Page Checkbox Options response class
/// </summary>
public class BrandingPageCheckboxOptions
{
   /// <summary>
   /// Specifies the background of the checkbox
   /// </summary>
   public required BrandingGenericPageBackgroundOptions Background { get; set; }

   /// <summary>
   /// Specifies the border radius (in pixels) of the checkbox
   /// </summary>
   public required int BorderRadius { get; set; }

   /// <summary>
   /// Specifies the border color (in Hex) of the checkbox
   /// </summary>
   public required string BorderColor { get; set; }

   /// <summary>
   /// Specifies the border width (in Pixels) of the checkbox
   /// </summary>
   public required float BorderWidth { get; set; }

   /// <summary>
   /// Specifies the background of the checkbox when it is in the hover state
   /// </summary>
   public required BrandingGenericPageBackgroundOptions HoverBackground { get; set; }

   /// <summary>
   /// Specifies the border color (in Hex) of the checkbox when it is in the hover state
   /// </summary>
   public required string HoverBorderColor { get; set; }

   /// <summary>
   /// Specifies the border width (in Pixels) of the checkbox when it is in the hover state
   /// </summary>
   public required float HoverBorderWidth { get; set; }

   /// <summary>
   /// Specifies the background of the checkbox when it is in the disabled state
   /// </summary>
   public required BrandingGenericPageBackgroundOptions DisabledBackground { get; set; }

   /// <summary>
   /// Specifies the background of the checkbox when it is in the checked state
   /// </summary>
   public required BrandingGenericPageBackgroundOptions CheckedBackground { get; set; }

   /// <summary>
   /// Specifies the border color (in Hex) of the checkbox when it is in the checked state
   /// </summary>
   public required string CheckedBorderColor { get; set; }

   /// <summary>
   /// Specifies the color (in Hex) of the check-mark in the checkbox when it is in the checked state
   /// </summary>
   public required string CheckMarkColor { get; set; }
}


