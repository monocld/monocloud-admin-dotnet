using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Apple Authenticator Options Response class
/// </summary>
public class AuthenticatorsAppleOptions
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
   /// Specifies if we should trust the email verified scope received from the external provider.
   /// </summary>
   public required bool TrustEmailVerifiedScope { get; set; }

   /// <summary>
   /// Apple generated teamId
   /// </summary>
   public required string TeamId { get; set; }

   /// <summary>
   /// Apple generated keyId
   /// </summary>
   public required string KeyId { get; set; }
}


