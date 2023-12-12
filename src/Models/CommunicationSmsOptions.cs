using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Communication Sms Options response class
/// </summary>
public class CommunicationSmsOptions
{
   /// <summary>
   /// Twilio Options
   /// </summary>
   public CommunicationSmsTwilioOptions? Twilio { get; set; }

   /// <summary>
   /// Use the the internal keys to send Sms
   /// </summary>
   public bool UseInternalKeys { get; set; }
}


