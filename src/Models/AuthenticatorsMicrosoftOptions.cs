using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Microsoft Authenticator Options response class
/// </summary>
public class AuthenticatorsMicrosoftOptions
{
   /// <summary>
   /// Enable External Provider Sign-in
   /// </summary>
   public required bool EnableSignIn { get; set; }

   /// <summary>
   /// Enable External Provider Sign-up
   /// </summary>
   public required bool EnableSignUp { get; set; }

   /// <summary>
   /// If set to true, will sync the profile with each login
   /// </summary>
   public required bool SyncUserProfileAlways { get; set; }

   /// <summary>
   /// Client Id issued for the customer by provider
   /// </summary>
   public required string ClientId { get; set; }

   /// <summary>
   /// Client Secret issued for the customer by provider
   /// </summary>
   public required string ClientSecret { get; set; }

   /// <summary>
   /// List of provider scopes to be obtained
   /// </summary>
   public required List<string> Scopes { get; set; }

   /// <summary>
   /// Specifies if we should treat the email received from the external provider as verified.
   /// </summary>
   public required bool TreatEmailAsVerified { get; set; }
}


