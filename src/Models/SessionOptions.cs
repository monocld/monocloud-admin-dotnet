using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Session Options response class
/// </summary>
public class SessionOptions
{
   /// <summary>
   /// Persistence Mode of the session.
   /// </summary>
   public required SessionPersistenceModes PersistenceMode { get; set; }

   /// <summary>
   /// Expiration Type
   /// </summary>
   public required ExpirationTypes ExpirationType { get; set; }

   /// <summary>
   /// Specifies the duration in minutes after which the user session will expire in accordance with the expiration type.
   /// </summary>
   public required int RememberMeDuration { get; set; }

   /// <summary>
   /// Specifies the duration in minutes after which the user session will expire regardless of the expiration type.
   /// </summary>
   public required int LogoutAfter { get; set; }
}


