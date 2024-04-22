using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Branding Generic Sms Template Options response class
/// </summary>
public class BrandingGenericSmsTemplateOptions
{
   /// <summary>
   /// Specifies whether to use the custom template.
   /// </summary>
   public required bool UseCustomTemplate { get; set; }

   /// <summary>
   /// Custom LiquidJS template for the SMS
   /// </summary>
   public string? Template { get; set; }
}


