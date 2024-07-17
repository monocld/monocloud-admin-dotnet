using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Passkey Authenticator Options response class
/// </summary>
public class AuthenticatorsPasskeyOptions
{
   /// <summary>
   /// Enable Passkey Sign-in
   /// </summary>
   public bool EnableSignIn { get; set; }

   /// <summary>
   /// Enable Passkey Sign-up
   /// </summary>
   public bool EnableSignUp { get; set; }

   /// <summary>
   /// Allow users to autofill passkeys using the username field on the login page
   /// </summary>
   public bool AllowPasskeyAutoComplete { get; set; }

   /// <summary>
   /// Prompt users for adding a passkey if the user does not have one
   /// </summary>
   public bool PasskeyEnrollment { get; set; }

   /// <summary>
   /// Prompt for adding a passkey on the current device when user authenticated with an external passkey
   /// </summary>
   public bool LocalPasskeyEnrollment { get; set; }
}


