using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Account Protection User Unblock Email response class
/// </summary>
public class AccountProtectionUserUnblockEmailOptions
{
   /// <summary>
   /// Enable User Unblock through Email.
   /// </summary>
   public bool Enabled { get; set; }

   /// <summary>
   /// Email expiration time in seconds.
   /// </summary>
   public int Expiry { get; set; }
}


