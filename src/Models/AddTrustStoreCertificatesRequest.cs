using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// Add Certificates Request.
/// </summary>
public class AddTrustStoreCertificatesRequest
{
   /// <summary>
   /// List of certificates.
   /// </summary>
   public List<CreateTrustStoreCertificateRequest> Certificates { get; set; } = new();
}


