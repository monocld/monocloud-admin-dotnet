using System;
using System.Collections.Generic;
using MonoCloud.SDK.Core.Helpers;
using System.Text.Json.Serialization;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Patch Passkey Authenticator Options Request class
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchAuthenticatorsPasskeyOptionsRequest>))]
public class PatchAuthenticatorsPasskeyOptionsRequest
{
   /// <summary>
   /// Enable Passkey Sign-in
   /// </summary>
   public Optional<bool> EnableSignIn { get; set; }

   /// <summary>
   /// Enable Passkey Sign-up
   /// </summary>
   public Optional<bool> EnableSignUp { get; set; }

   /// <summary>
   /// Allow users to autofill passkeys using the username field on the login page
   /// </summary>
   public Optional<bool> AllowPasskeyAutoComplete { get; set; }

   /// <summary>
   /// Prompt users for adding a passkey if the user does not have one
   /// </summary>
   public Optional<bool> PasskeyEnrollment { get; set; }

   /// <summary>
   /// Prompt for adding a passkey on the current device when user authenticated with an external passkey
   /// </summary>
   public Optional<bool> LocalPasskeyEnrollment { get; set; }
}


