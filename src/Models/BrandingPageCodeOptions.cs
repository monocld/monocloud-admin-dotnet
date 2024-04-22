using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Branding Page Code Options response class
/// </summary>
public class BrandingPageCodeOptions
{
   /// <summary>
   /// Specifies the color (in Hex) of the text contained in the the code box
   /// </summary>
   public required string TextColor { get; set; }

   /// <summary>
   /// Specifies the font size (in Rem) of the text contained in the the code box
   /// </summary>
   public required float FontSize { get; set; }

   /// <summary>
   /// Specifies the font weight of the text contained in the the code box
   /// </summary>
   public required int FontWeight { get; set; }

   /// <summary>
   /// Specifies the space between the code characters (in em) in the code box
   /// </summary>
   public required float LetterSpacing { get; set; }

   /// <summary>
   /// Specifies the background of the code box
   /// </summary>
   public required BrandingGenericPageBackgroundOptions Background { get; set; }

   /// <summary>
   /// Specifies the border width (in Pixels) of the code box
   /// </summary>
   public required float BorderWidth { get; set; }

   /// <summary>
   /// Specifies the border color (in Hex) of the code box
   /// </summary>
   public required string BorderColor { get; set; }

   /// <summary>
   /// Specifies the border radius (in Pixels) of the code box
   /// </summary>
   public required int BorderRadius { get; set; }
}


