using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Email Recovery Method Options response class
/// </summary>
public class RecoveryMethodsEmailOptions
{
   /// <summary>
   /// Enable Password recovery through Email.
   /// </summary>
   public required bool Enabled { get; set; }

   /// <summary>
   /// Verification type that should be used for email password reset
   /// </summary>
   public required VerificationTypes VerificationType { get; set; }

   /// <summary>
   /// Allow password reset flow to resume in a different browser
   /// </summary>
   public required bool AllowCrossBrowser { get; set; }

   /// <summary>
   /// Specifies the expiration period of the email (in seconds)
   /// </summary>
   public required int Expiry { get; set; }

   /// <summary>
   /// Specifies the length of the code
   /// </summary>
   public required int CodeLength { get; set; }
}


