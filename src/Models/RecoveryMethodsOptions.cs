using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Recovery Methods Options response class
/// </summary>
public class RecoveryMethodsOptions
{
   /// <summary>
   /// Recovery Methods Email Options
   /// </summary>
   public required RecoveryMethodsEmailOptions Email { get; set; }

   /// <summary>
   /// Recovery Methods Phone Options
   /// </summary>
   public required RecoveryMethodsPhoneOptions Phone { get; set; }
}


