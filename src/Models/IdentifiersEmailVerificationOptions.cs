using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Email Identifier Verification Options response class
/// </summary>
public class IdentifiersEmailVerificationOptions
{
   /// <summary>
   /// Specifies whether the email should be verified at registration.
   /// </summary>
   public required bool VerifyAtSignUp { get; set; }

   /// <summary>
   /// Specifies the type of verification tokens to be sent
   /// </summary>
   public required VerificationTypes VerificationType { get; set; }

   /// <summary>
   /// Allow sign up/sign in flow to resume in a different browser
   /// </summary>
   public required bool AllowCrossBrowser { get; set; }

   /// <summary>
   /// Specifies the expiration period of the code (in seconds)
   /// </summary>
   public required int Expiry { get; set; }

   /// <summary>
   /// Specifies the length of the code
   /// </summary>
   public required int CodeLength { get; set; }
}


