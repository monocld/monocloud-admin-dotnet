using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Branding Email Generic Template Options response class
/// </summary>
public class BrandingGenericEmailTemplateOptions
{
   /// <summary>
   /// Specifies whether to use the custom template.
   /// </summary>
   public bool UseCustomTemplate { get; set; }

   /// <summary>
   /// Specifies the text to be used as the email subject
   /// </summary>
   public string? Subject { get; set; }

   /// <summary>
   /// Specifies the URI for the custom template to be used
   /// </summary>
   public string? TemplateUri { get; set; }
}


