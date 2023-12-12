using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Consent Options response class
/// </summary>
public class ConsentOptions
{
   /// <summary>
   /// Since access tokens have finite lifetimes, refresh tokens allow requesting new access tokens without user interaction. The clients need to be explicitly authorized by the User to request for refresh tokens. This option specifies if all the clients need Consent from the User for Offline Access.
   /// </summary>
   public bool ConsentRequiredForOfflineAccess { get; set; }
}


