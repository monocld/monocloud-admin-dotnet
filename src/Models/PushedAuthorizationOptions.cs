using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Pushed Authorization Options response class
/// </summary>
public class PushedAuthorizationOptions
{
   /// <summary>
   /// Specifies whether Pushed Authorization Requests are required for authorization.
   /// </summary>
   public bool RequirePushedAuthorizationRequests { get; set; }
}


