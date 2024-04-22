using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Branding Email Options response class
/// </summary>
public class BrandingEmailOptions
{
   /// <summary>
   /// Welcome Email Branding Options
   /// </summary>
   public required BrandingGenericEmailTemplateOptions Welcome { get; set; }

   /// <summary>
   /// User Blocked Email Branding Options
   /// </summary>
   public required BrandingGenericEmailTemplateOptions UserBlocked { get; set; }

   /// <summary>
   /// Sign In Email Code Branding Options
   /// </summary>
   public required BrandingGenericEmailTemplateOptions SignInCode { get; set; }

   /// <summary>
   /// Sign In Email Link Branding Options
   /// </summary>
   public required BrandingGenericEmailTemplateOptions SignInLink { get; set; }

   /// <summary>
   /// Sign In Email Code and Link Branding Options
   /// </summary>
   public required BrandingGenericEmailTemplateOptions SignInCodeAndLink { get; set; }

   /// <summary>
   /// Verification Email Code Branding Options
   /// </summary>
   public required BrandingGenericEmailTemplateOptions VerificationCode { get; set; }

   /// <summary>
   /// Verification Email Link Branding Options
   /// </summary>
   public required BrandingGenericEmailTemplateOptions VerificationLink { get; set; }

   /// <summary>
   /// Verification Email Code and Link Branding Options
   /// </summary>
   public required BrandingGenericEmailTemplateOptions VerificationCodeAndLink { get; set; }

   /// <summary>
   /// Password Reset Email Code Branding Options
   /// </summary>
   public required BrandingGenericEmailTemplateOptions PasswordResetCode { get; set; }

   /// <summary>
   /// Password Reset Email Link Branding Options
   /// </summary>
   public required BrandingGenericEmailTemplateOptions PasswordResetLink { get; set; }

   /// <summary>
   /// Password Reset Email Code and Link Branding Options
   /// </summary>
   public required BrandingGenericEmailTemplateOptions PasswordResetCodeAndLink { get; set; }

   /// <summary>
   /// Password Updated Email Branding Options
   /// </summary>
   public required BrandingGenericEmailTemplateOptions PasswordUpdated { get; set; }
}


