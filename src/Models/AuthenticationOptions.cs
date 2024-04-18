using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Authentication Options response class
/// </summary>
public class AuthenticationOptions
{
   /// <summary>
   /// Account Protection Options
   /// </summary>
   public AccountProtectionOptions AccountProtection { get; set; }

   /// <summary>
   /// Authenticators Options
   /// </summary>
   public AuthenticatorsOptions Authenticators { get; set; }

   /// <summary>
   /// Identifiers Options
   /// </summary>
   public IdentifiersOptions Identifiers { get; set; }

   /// <summary>
   /// Recovery Methods Options
   /// </summary>
   public RecoveryMethodsOptions RecoveryMethods { get; set; }

   /// <summary>
   /// Consent Options
   /// </summary>
   public ConsentOptions Consent { get; set; }

   /// <summary>
   /// Session Options
   /// </summary>
   public SessionOptions Session { get; set; }

   /// <summary>
   /// Logout Options
   /// </summary>
   public LogoutOptions Logout { get; set; }

   /// <summary>
   /// Sign-up Options
   /// </summary>
   public SignUpOptions SignUp { get; set; }
}


