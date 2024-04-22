using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Logout Options response class
/// </summary>
public class LogoutOptions
{
   /// <summary>
   /// Specifies whether the user should be automatically redirected to the client specified URL after sign out.
   /// </summary>
   public required bool AutomaticRedirectAfterLogout { get; set; }

   /// <summary>
   /// Specifies whether there should be a prompt before log out.
   /// </summary>
   public required bool ShowLogoutPrompt { get; set; }
}


