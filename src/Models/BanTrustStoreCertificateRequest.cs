using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// Ban Certificate Request.
/// </summary>
public class BanTrustStoreCertificateRequest
{
   /// <summary>
   /// Unique thumbprint of the certificate.
   /// </summary>
   public string Value { get; set; }

   /// <summary>
   /// Specifies the reason for banning the certificate.
   /// </summary>
   public string? Reason { get; set; }

   
   public BannedCertificateType? Type { get; set; }
}


