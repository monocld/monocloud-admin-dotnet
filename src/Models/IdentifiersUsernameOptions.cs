using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Username Identifier Options response class
/// </summary>
public class IdentifiersUsernameOptions
{
   /// <summary>
   /// Specifies if the users are allowed to sign-in using a username
   /// </summary>
   public required bool EnableSignIn { get; set; }

   /// <summary>
   /// Specifies if the users are allowed to enter a username at the time of registration.
   /// </summary>
   public required bool ShowAtSignUp { get; set; }

   /// <summary>
   /// Specifies if the username is required at the time of registration.
   /// </summary>
   public required bool RequiredAtSignUp { get; set; }

   /// <summary>
   /// Specifies the minimum length required for the username.
   /// </summary>
   public required int MinimumLength { get; set; }
}


