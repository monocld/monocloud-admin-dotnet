using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Authentication Options response class
/// </summary>
public class AuthenticationOptions
{
   /// <summary>
   /// Pushed Authorization Request Options
   /// </summary>
   public required PushedAuthorizationOptions PushedAuthorization { get; set; }

   /// <summary>
   /// Account Protection Options
   /// </summary>
   public required AccountProtectionOptions AccountProtection { get; set; }

   /// <summary>
   /// Authenticators Options
   /// </summary>
   public required AuthenticatorsOptions Authenticators { get; set; }

   /// <summary>
   /// Identifiers Options
   /// </summary>
   public required IdentifiersOptions Identifiers { get; set; }

   /// <summary>
   /// Recovery Methods Options
   /// </summary>
   public required RecoveryMethodsOptions RecoveryMethods { get; set; }

   /// <summary>
   /// Session Options
   /// </summary>
   public required SessionOptions Session { get; set; }

   /// <summary>
   /// Logout Options
   /// </summary>
   public required LogoutOptions Logout { get; set; }

   /// <summary>
   /// Sign-up Options
   /// </summary>
   public required SignUpOptions SignUp { get; set; }
}


