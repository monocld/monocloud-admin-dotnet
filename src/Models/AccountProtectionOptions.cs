using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Account Protection response class
/// </summary>
public class AccountProtectionOptions
{
   /// <summary>
   /// Account Protection&#39;s User Lockout Options
   /// </summary>
   public required AccountProtectionUserLockoutOptions UserLockout { get; set; }
}


