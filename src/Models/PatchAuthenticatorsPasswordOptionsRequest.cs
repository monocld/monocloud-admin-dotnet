using System;
using System.Collections.Generic;
using MonoCloud.SDK.Core.Helpers;
using System.Text.Json.Serialization;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Patch Password Authenticator Options Request class
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchAuthenticatorsPasswordOptionsRequest>))]
public class PatchAuthenticatorsPasswordOptionsRequest
{
   /// <summary>
   /// Enable Password Sign-in
   /// </summary>
   public Optional<bool> EnableSignIn { get; set; }

   /// <summary>
   /// Enable Password Sign-up
   /// </summary>
   public Optional<bool> EnableSignUp { get; set; }

   /// <summary>
   /// Specifies whether to notify the user on successful password update through email.
   /// </summary>
   public Optional<bool> EnablePasswordUpdatedEmail { get; set; }

   /// <summary>
   /// If enabled password will be prompted on the same screen as the username.
   /// </summary>
   public Optional<bool> PromptPasswordOnInitialScreen { get; set; }

   /// <summary>
   /// Specifies the expiration period of the password (in days)
   /// </summary>
   public Optional<int?> Expiry { get; set; }

   /// <summary>
   /// Password Strength Options
   /// </summary>
   public Optional<PatchAuthenticatorsPasswordStrengthOptionsRequest> Strength { get; set; }

   /// <summary>
   /// Password Re-use Options
   /// </summary>
   public Optional<PatchAuthenticatorsPasswordReuseOptionsRequest> Reuse { get; set; }
}


