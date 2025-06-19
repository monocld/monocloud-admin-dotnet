using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// Ban Certificate Request.
/// </summary>
public class BanTrustStoreCertificateRequest
{
   /// <summary>
   /// Thumbprint of the certificate to be banned
   /// </summary>
   public string Thumbprint { get; set; }
}


