using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// Add Certificate Revocation Request.
/// </summary>
public class AddCertificateRevocationRequest
{
   /// <summary>
   /// Crl Pem Value.
   /// </summary>
   public string Value { get; set; }
}


