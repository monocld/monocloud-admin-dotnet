using System;
using System.Collections.Generic;
using MonoCloud.SDK.Core.Helpers;
using System.Text.Json.Serialization;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Patch Communication Sms Options Request class
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchCommunicationSmsOptionsRequest>))]
public class PatchCommunicationSmsOptionsRequest
{
   /// <summary>
   /// Twilio Options
   /// </summary>
   public Optional<PatchCommunicationSmsTwilioOptionsRequest?> Twilio { get; set; }

   /// <summary>
   /// Use the the internal keys to send Sms
   /// </summary>
   public Optional<bool> UseInternalKeys { get; set; }
}


