using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The SignUp Custom Field Options response class
/// </summary>
public class SignUpCustomFieldOptions
{
   /// <summary>
   /// Specifies if the users are allowed to enter the claim at the time of signup.
   /// </summary>
   public required bool Enabled { get; set; }

   /// <summary>
   /// Specifies if the claim is required at the time of signup.
   /// </summary>
   public required bool Required { get; set; }

   /// <summary>
   /// Specifies the name for the claim.
   /// </summary>
   public required string ClaimName { get; set; }

   /// <summary>
   /// Specifies the claim value type.
   /// </summary>
   public required ValueTypes ValueType { get; set; }

   /// <summary>
   /// Specifies the label to be used for the claim at the time of signup.
   /// </summary>
   public required string Label { get; set; }
}


