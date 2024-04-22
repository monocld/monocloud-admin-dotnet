using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Email Identifier Options response class
/// </summary>
public class IdentifiersEmailOptions
{
   /// <summary>
   /// Specifies if the users are allowed to sign-in using an email
   /// </summary>
   public required bool EnableSignIn { get; set; }

   /// <summary>
   /// Specifies if the users are allowed to enter an email at the time of registration.
   /// </summary>
   public required bool ShowAtSignUp { get; set; }

   /// <summary>
   /// Specifies if the email is required at the time of registration.
   /// </summary>
   public required bool RequiredAtSignUp { get; set; }

   /// <summary>
   /// Email verification related to Sign Up
   /// </summary>
   public required IdentifiersEmailVerificationOptions Verification { get; set; }
}


