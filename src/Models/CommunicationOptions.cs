using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Communication Options response class
/// </summary>
public class CommunicationOptions
{
   /// <summary>
   /// Email - Communication Options
   /// </summary>
   public required CommunicationEmailOptions Email { get; set; }

   /// <summary>
   /// Sms - Communication Options
   /// </summary>
   public required CommunicationSmsOptions Sms { get; set; }
}


