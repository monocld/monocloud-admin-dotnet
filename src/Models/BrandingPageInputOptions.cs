using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Branding Page Input Options response class
/// </summary>
public class BrandingPageInputOptions
{
   /// <summary>
   /// Specifies the text font size (in Rem) of the input box
   /// </summary>
   public required float FontSize { get; set; }

   /// <summary>
   /// Specifies the text color (in Hex) of the input box
   /// </summary>
   public required string TextColor { get; set; }

   /// <summary>
   /// Specifies the background of the input box
   /// </summary>
   public required BrandingGenericPageBackgroundOptions Background { get; set; }

   /// <summary>
   /// Specifies the border radius (in Pixels) of the input box
   /// </summary>
   public required int BorderRadius { get; set; }

   /// <summary>
   /// Specifies the border color (in Hex) of the input box
   /// </summary>
   public required string BorderColor { get; set; }

   /// <summary>
   /// Specifies the border width (in Pixels) of the input box
   /// </summary>
   public required float BorderWidth { get; set; }

   /// <summary>
   /// Specifies the box-shadow of the input box
   /// </summary>
   public required BrandingGenericPageShadowOptions Shadow { get; set; }

   /// <summary>
   /// Specifies the border color (in Hex) of the input box
   /// </summary>
   public required string FocusBorderColor { get; set; }

   /// <summary>
   /// Specifies the border width (in Pixels) of the input box when it is in the focused state
   /// </summary>
   public required float FocusBorderWidth { get; set; }

   /// <summary>
   /// Specifies the box-shadow of the input box when it is in the focused state
   /// </summary>
   public required BrandingGenericPageShadowOptions FocusShadow { get; set; }

   /// <summary>
   /// Specifies the text color (in Hex) of the input box when it is in the focused state
   /// </summary>
   public required string FocusTextColor { get; set; }

   /// <summary>
   /// Specifies the label color (in Hex) of the input box
   /// </summary>
   public required string LabelColor { get; set; }

   /// <summary>
   /// Specifies the label color (in Hex) of the input box when it is in the focused state
   /// </summary>
   public required string FocusLabelColor { get; set; }

   /// <summary>
   /// Specifies the box-shadow of the input box when it is in the error state
   /// </summary>
   public required BrandingGenericPageShadowOptions ErrorShadow { get; set; }

   /// <summary>
   /// Specifies the box-shadow of the input when it is in the error and focused state
   /// </summary>
   public required BrandingGenericPageShadowOptions ErrorFocusShadow { get; set; }
}


