using System;
using System.Collections.Generic;
using MonoCloud.SDK.Core.Helpers;
using System.Text.Json.Serialization;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Patch account protection user unblock email options request class
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchAccountProtectionUserUnblockEmailOptionsRequest>))]
public class PatchAccountProtectionUserUnblockEmailOptionsRequest
{
   /// <summary>
   /// Enable User Unblock through Email.
   /// </summary>
   public Optional<bool> Enabled { get; set; }

   /// <summary>
   /// Email expiration time in seconds.
   /// </summary>
   public Optional<int> Expiry { get; set; }
}


