using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Email Authenticator Options response class
/// </summary>
public class AuthenticatorsEmailOptions
{
   /// <summary>
   /// Enable Email Sign-in
   /// </summary>
   public required bool EnableSignIn { get; set; }

   /// <summary>
   /// Enable Email Sign-up
   /// </summary>
   public required bool EnableSignUp { get; set; }

   /// <summary>
   /// Enable Email Jit Provisioning
   /// </summary>
   public required bool EnableJitProvisioning { get; set; }

   /// <summary>
   /// Specifies the type of verification tokens to be sent
   /// </summary>
   public required VerificationTypes VerificationType { get; set; }

   /// <summary>
   /// Allow sign up/sign in flow to resume in a different browser
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


