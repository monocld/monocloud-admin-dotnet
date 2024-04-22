using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Scope Claim response class
/// </summary>
public class ScopeClaim
{
   /// <summary>
   /// Specifies the name of the claim.
   /// </summary>
   public required string Claim { get; set; }

   /// <summary>
   /// Specifies whether the claim will be included in the Identity Token.
   /// </summary>
   public required bool IncludeInIdentityToken { get; set; }

   /// <summary>
   /// Specifies whether the claim will be returned from the user info endpoint.
   /// </summary>
   public required bool IncludeInUserInfo { get; set; }
}


