using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The SignUp Generic Restrictions Options response class
/// </summary>
public class SignUpGenericRestrictionsOptions
{
   /// <summary>
   /// Specifies whether or not the restriction is enabled.
   /// </summary>
   public required bool Enabled { get; set; }

   /// <summary>
   /// List of Emails, Phone numbers, and top-level domains to be considered for access control.
   /// </summary>
   public required List<string> Identifiers { get; set; }
}


