using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Account Protection User Unblock response class
/// </summary>
public class AccountProtectionUserUnblockOptions
{
   /// <summary>
   /// User Unblock Email Options
   /// </summary>
   public required AccountProtectionUserUnblockEmailOptions Email { get; set; }
}


