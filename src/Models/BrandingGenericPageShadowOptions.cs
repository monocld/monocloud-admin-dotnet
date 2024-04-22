using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Branding Generic Page Shadow Options response class
/// </summary>
public class BrandingGenericPageShadowOptions
{
   /// <summary>
   /// Specifies the horizontal offset of the shadow (in Pixels)
   /// </summary>
   public required float HOffset { get; set; }

   /// <summary>
   /// Specifies the vertical offset of the shadow (in Pixels)
   /// </summary>
   public required float VOffset { get; set; }

   /// <summary>
   /// Specifies the blur radius (in Pixels)
   /// </summary>
   public required float Blur { get; set; }

   /// <summary>
   /// Specifies the spread radius (in Pixels)
   /// </summary>
   public required float Spread { get; set; }

   /// <summary>
   /// Specifies the color of the shadow (in Hex)
   /// </summary>
   public required string Color { get; set; }

   /// <summary>
   /// Specifies if the shadow is an inner shadow
   /// </summary>
   public required bool Inset { get; set; }
}


