using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Password Authenticator Reuse Options response class
/// </summary>
public class AuthenticatorsPasswordReuseOptions
{
   /// <summary>
   /// Specifies if there should be any restriction for password reuse.
   /// </summary>
   public required PasswordRestrictionModes RestrictionMode { get; set; }

   /// <summary>
   /// Specifies the time in minutes in which the password cannot be reused.
   /// </summary>
   public required int RestrictionPeriod { get; set; }

   /// <summary>
   /// Specifies the number of previous passwords which cannot be reused.
   /// </summary>
   public required int RestrictionCount { get; set; }
}


