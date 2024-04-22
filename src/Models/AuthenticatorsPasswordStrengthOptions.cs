using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Password Authenticator Strength Options response class
/// </summary>
public class AuthenticatorsPasswordStrengthOptions
{
   /// <summary>
   /// Specifies the minimum character length of password
   /// </summary>
   public required int MinimumLength { get; set; }

   /// <summary>
   /// Specifies the whether a non alphanumeric character is required in the password.
   /// </summary>
   public required bool RequireNonAlphanumericCharacter { get; set; }

   /// <summary>
   /// Specifies the whether a digit is required in the password.
   /// </summary>
   public required bool RequireDigit { get; set; }

   /// <summary>
   /// Specifies the whether a lowercase character is required in the password.
   /// </summary>
   public required bool RequireLowercaseCharacter { get; set; }

   /// <summary>
   /// Specifies the whether a uppercase character is required in the password.
   /// </summary>
   public required bool RequireUppercaseCharacter { get; set; }

   /// <summary>
   /// Specifies the number of unique characters required in the password.
   /// </summary>
   public required int RequiredUniqueCharactersCount { get; set; }
}


