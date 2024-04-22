using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Phone Recovery Method Options response class
/// </summary>
public class RecoveryMethodsPhoneOptions
{
   /// <summary>
   /// Enable Password recovery through Phone.
   /// </summary>
   public required bool Enabled { get; set; }

   /// <summary>
   /// Specifies the expiration period of the code (in seconds)
   /// </summary>
   public required int Expiry { get; set; }

   /// <summary>
   /// Specifies the length of the code
   /// </summary>
   public required int CodeLength { get; set; }
}


