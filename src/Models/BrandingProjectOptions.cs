using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Branding Project Options response class
/// </summary>
public class BrandingProjectOptions
{
   /// <summary>
   /// Project Url
   /// </summary>
   public string? DefaultUrl { get; set; }

   /// <summary>
   /// Support Url
   /// </summary>
   public string? SupportUrl { get; set; }

   /// <summary>
   /// Support Email
   /// </summary>
   public string? SupportEmail { get; set; }
}


