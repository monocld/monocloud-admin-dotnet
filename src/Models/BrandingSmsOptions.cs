using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Branding Sms Options response class
/// </summary>
public class BrandingSmsOptions
{
   /// <summary>
   /// SignIn Sms Code Branding Options
   /// </summary>
   public required BrandingGenericSmsTemplateOptions SignIn { get; set; }

   /// <summary>
   /// Verification Sms Code Branding Options
   /// </summary>
   public required BrandingGenericSmsTemplateOptions Verification { get; set; }

   /// <summary>
   /// Password Reset Sms Code Branding Options
   /// </summary>
   public required BrandingGenericSmsTemplateOptions PasswordReset { get; set; }
}


