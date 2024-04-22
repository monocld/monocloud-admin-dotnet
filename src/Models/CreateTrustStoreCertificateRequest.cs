using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// Create Certificate Request.
/// </summary>
public class CreateTrustStoreCertificateRequest
{
   /// <summary>
   /// Specifies if the certificate is enabled.
   /// </summary>
   public bool? Enabled { get; set; }

   /// <summary>
   /// Certificate Value.
   /// </summary>
   public required string Value { get; set; }
}


