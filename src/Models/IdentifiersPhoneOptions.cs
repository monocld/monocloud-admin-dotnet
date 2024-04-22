using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Phone Identifier Options response class
/// </summary>
public class IdentifiersPhoneOptions
{
   /// <summary>
   /// Specifies if the users are allowed to sign-in using a phone number
   /// </summary>
   public required bool EnableSignIn { get; set; }

   /// <summary>
   /// Specifies if the users are allowed to enter a phone number at the time of registration.
   /// </summary>
   public required bool ShowAtSignUp { get; set; }

   /// <summary>
   /// Specifies if the phone number is required at the time of registration.
   /// </summary>
   public required bool RequiredAtSignUp { get; set; }

   /// <summary>
   /// Phone verification related to Sign Up
   /// </summary>
   public required IdentifiersPhoneVerificationOptions Verification { get; set; }
}


