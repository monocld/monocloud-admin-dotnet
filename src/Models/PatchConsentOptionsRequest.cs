using System;
using System.Collections.Generic;
using MonoCloud.SDK.Core.Helpers;
using System.Text.Json.Serialization;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Patch Consent Options Request class
/// </summary>
[JsonConverter(typeof(PatchConverter<PatchConsentOptionsRequest>))]
public class PatchConsentOptionsRequest
{
   /// <summary>
   /// Since access tokens have finite lifetimes, refresh tokens allow requesting new access tokens without user interaction. The clients need to be explicitly authorized by the User to request for refresh tokens. This option specifies if all the clients need Consent from the User for Offline Access.
   /// </summary>
   public Optional<bool> ConsentRequiredForOfflineAccess { get; set; }
}


