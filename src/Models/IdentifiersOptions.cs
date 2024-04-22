using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Identifiers Options response class
/// </summary>
public class IdentifiersOptions
{
   /// <summary>
   /// Email Identifier Options
   /// </summary>
   public required IdentifiersEmailOptions Email { get; set; }

   /// <summary>
   /// Phone Identifier Options
   /// </summary>
   public required IdentifiersPhoneOptions Phone { get; set; }

   /// <summary>
   /// Username Identifier Options
   /// </summary>
   public required IdentifiersUsernameOptions Username { get; set; }
}


