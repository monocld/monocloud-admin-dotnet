using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Account Protection UserLockout response class
/// </summary>
public class AccountProtectionUserLockoutOptions
{
   /// <summary>
   /// Enable User Lockout
   /// </summary>
   public required bool Enabled { get; set; }

   /// <summary>
   /// Maximum Number of failed attempts a user account can have before the user is locked out. The specified value is inclusive of the count.
   /// </summary>
   public required int MaxFailedAccessAttempts { get; set; }

   /// <summary>
   /// Lockout duration in minutes once a user account has been locked out.
   /// </summary>
   public required int UserLockoutTimeSpan { get; set; }

   /// <summary>
   /// Lockout duration in minutes once an Ip address has been locked out.
   /// </summary>
   public required int IpLockoutTimeSpan { get; set; }

   /// <summary>
   /// Whitelisted IP Addresses where the Account Protection does not trigger.
   /// </summary>
   public required List<string> AllowedIps { get; set; }

   /// <summary>
   /// Types of Lockouts to enable per User Account
   /// </summary>
   public required UserLockoutTypes LockoutType { get; set; }

   /// <summary>
   /// Account Protection User Unblock Options
   /// </summary>
   public required AccountProtectionUserUnblockOptions UserUnblock { get; set; }
}


