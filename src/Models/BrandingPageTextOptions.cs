using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Branding Page Text Options response class
/// </summary>
public class BrandingPageTextOptions
{
   /// <summary>
   /// Specifies the font size (in Rem) of the regular text
   /// </summary>
   public required float RegularFontSize { get; set; }

   /// <summary>
   /// Specifies the font weight of the regule text
   /// </summary>
   public required int RegularFontWeight { get; set; }

   /// <summary>
   /// Specifies the font size (in Rem) of the small text
   /// </summary>
   public required float SmallFontSize { get; set; }

   /// <summary>
   /// Specifies the font size (in Rem) of the extra-small text
   /// </summary>
   public required float ExtraSmallFontSize { get; set; }

   /// <summary>
   /// Specifies the color (in Hex) of the regular text
   /// </summary>
   public required string TextColor { get; set; }

   /// <summary>
   /// Specifies the color (in Hex) of the error text
   /// </summary>
   public required string ErrorColor { get; set; }

   /// <summary>
   /// Specifies the color (in Hex) of an error element when it is in the hover state
   /// </summary>
   public required string ErrorHoverColor { get; set; }

   /// <summary>
   /// Specifies the alignment of the heading text relative to the card
   /// </summary>
   public required string HeadingAlignment { get; set; }

   /// <summary>
   /// Specifies the font size (in Rem) of the heading text
   /// </summary>
   public required float HeadingFontSize { get; set; }

   /// <summary>
   /// Specifies the font weight of the heading text
   /// </summary>
   public required int HeadingFontWeight { get; set; }

   /// <summary>
   /// Specifies the font size (in Rem) of the sub-heading text
   /// </summary>
   public required float SubHeadingFontSize { get; set; }

   /// <summary>
   /// Specifies the font weight of the sub-heading text
   /// </summary>
   public required int SubHeadingFontWeight { get; set; }
}


