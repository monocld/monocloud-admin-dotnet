using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// Banned Thumbprints Request.
/// </summary>
public class AddBannedThumbprintsRequest
{
   /// <summary>
   /// List of banned certificate thumbprints.
   /// </summary>
   public List<string> BannedThumbprints { get; set; }
}


