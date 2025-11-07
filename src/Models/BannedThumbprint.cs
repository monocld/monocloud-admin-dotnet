using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// Banned Thumbprint Response
/// </summary>
public class BannedThumbprint
{
   /// <summary>
   /// Unique thumbprint of the certificate.
   /// </summary>
   public string Value { get; set; }

   /// <summary>
   /// Specifies the reason for banning the certificate.
   /// </summary>
   public string? Reason { get; set; }

   /// <summary>
   /// Specifies the creation time (in Epoch).
   /// </summary>
   public DateTime CreationTime { get; set; }
}


