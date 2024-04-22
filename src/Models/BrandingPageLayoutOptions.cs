using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Branding Page Layout Options response class
/// </summary>
public class BrandingPageLayoutOptions
{
   /// <summary>
   /// Specifies the background of the page
   /// </summary>
   public required BrandingGenericPageBackgroundOptions Background { get; set; }

   /// <summary>
   /// Specifies the size of the card (in Pixels)
   /// </summary>
   public required int CardWidth { get; set; }

   /// <summary>
   /// Specifies position of the card relative to the page
   /// </summary>
   public required string CardPosition { get; set; }

   /// <summary>
   /// Specifies the column in which the card will be positioned on the grid
   /// </summary>
   public required int CardGridColumn { get; set; }

   /// <summary>
   /// Specifies how many columns the card will occupy on the grid
   /// </summary>
   public required int CardGridSpan { get; set; }

   /// <summary>
   /// Specifies the offset (in Pixels) used to position the card horizontally on the page
   /// </summary>
   public required int CardXOffset { get; set; }

   /// <summary>
   /// Specifies the background of the card
   /// </summary>
   public required BrandingGenericPageBackgroundOptions CardBackground { get; set; }

   /// <summary>
   /// Specifies the padding (in Pixels) to be applied to the card
   /// </summary>
   public required float CardPadding { get; set; }

   /// <summary>
   /// Specifies the border width (in Pixels) of the card
   /// </summary>
   public required float CardBorderWidth { get; set; }

   /// <summary>
   /// Specifies the border radius (in Pixels) of the card
   /// </summary>
   public required int CardBorderRadius { get; set; }

   /// <summary>
   /// Specifies the border color (in Hex) of the card
   /// </summary>
   public required string CardBorderColor { get; set; }

   /// <summary>
   /// Specifies the box-shadow of the card
   /// </summary>
   public required BrandingGenericPageShadowOptions CardShadow { get; set; }
}


