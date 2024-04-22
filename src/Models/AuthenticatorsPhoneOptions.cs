using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Phone Authenticator Options response class
/// </summary>
public class AuthenticatorsPhoneOptions
{
   /// <summary>
   /// Enable Phone Sign-in
   /// </summary>
   public required bool EnableSignIn { get; set; }

   /// <summary>
   /// Enable Phone Sign-up
   /// </summary>
   public required bool EnableSignUp { get; set; }

   /// <summary>
   /// Enable Phone Jit Provisioning
   /// </summary>
   public required bool EnableJitProvisioning { get; set; }

   /// <summary>
   /// Specifies the expiration period of the code (in seconds)
   /// </summary>
   public required int Expiry { get; set; }

   /// <summary>
   /// Specifies the length of the code
   /// </summary>
   public required int CodeLength { get; set; }
}


