using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Password Authenticator Options response class
/// </summary>
public class AuthenticatorsPasswordOptions
{
   /// <summary>
   /// Enable Password Sign-in
   /// </summary>
   public required bool EnableSignIn { get; set; }

   /// <summary>
   /// Enable Password Sign-up
   /// </summary>
   public required bool EnableSignUp { get; set; }

   /// <summary>
   /// Specifies whether to notify the user on successful password update through email.
   /// </summary>
   public required bool EnablePasswordUpdatedEmail { get; set; }

   /// <summary>
   /// If enabled password will be prompted on the same screen as the username.
   /// </summary>
   public required bool PromptPasswordOnInitialScreen { get; set; }

   /// <summary>
   /// Password Strength Options
   /// </summary>
   public required AuthenticatorsPasswordStrengthOptions Strength { get; set; }

   /// <summary>
   /// Password Re-use Options
   /// </summary>
   public required AuthenticatorsPasswordReuseOptions Reuse { get; set; }
}


