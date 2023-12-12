using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Branding Options response class
/// </summary>
public class BrandingOptions
{
   /// <summary>
   /// Email Branding Options
   /// </summary>
   public BrandingEmailOptions Email { get; set; }

   /// <summary>
   /// Sms Branding Options
   /// </summary>
   public BrandingSmsOptions Sms { get; set; }

   /// <summary>
   /// Page Branding Options
   /// </summary>
   public BrandingPageOptions Page { get; set; }

   /// <summary>
   /// Project Branding Options
   /// </summary>
   public BrandingProjectOptions Project { get; set; }
}


