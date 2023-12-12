using System;
using System.Collections.Generic;
using MonoCloud.SDK.Core.Helpers;
using System.Text.Json.Serialization;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Patch Communication Email Options Request class
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchCommunicationEmailOptionsRequest>))]
public class PatchCommunicationEmailOptionsRequest
{
   /// <summary>
   /// SendGrid Email Options
   /// </summary>
   public Optional<PatchCommunicationEmailSendGridOptionsRequest?> SendGrid { get; set; }

   /// <summary>
   /// Use the the internal keys to send Emails
   /// </summary>
   public Optional<bool> UseInternalKeys { get; set; }

   /// <summary>
   /// From Email Address
   /// </summary>
   public Optional<string?> FromEmail { get; set; }

   /// <summary>
   /// From Name
   /// </summary>
   public Optional<string?> FromName { get; set; }
}


