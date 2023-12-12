using System;
using System.Collections.Generic;
using MonoCloud.SDK.Core.Helpers;
using System.Text.Json.Serialization;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Patch Communication Email SendGrid Options Request class
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchCommunicationEmailSendGridOptionsRequest>))]
public class PatchCommunicationEmailSendGridOptionsRequest
{
   /// <summary>
   /// SendGrid Api Key
   /// </summary>
   public Optional<string> ApiKey { get; set; }
}


