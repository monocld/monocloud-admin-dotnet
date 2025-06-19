using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// Certificate Revocation Response
/// </summary>
public class CertificateRevocation
{
   /// <summary>
   /// Revocation Id.
   /// </summary>
   public string Id { get; set; }

   /// <summary>
   /// Crl Pem Value.
   /// </summary>
   public string Value { get; set; }

   /// <summary>
   /// Thumbprint of the CA certificate the crl belongs to.
   /// </summary>
   public string IssuerThumbprint { get; set; }

   /// <summary>
   /// Specifies the issued time of the revocation (in Epoch).
   /// </summary>
   public DateTime IssuedAt { get; set; }

   /// <summary>
   /// Specifies the creation time of the revocation (in Epoch).
   /// </summary>
   public DateTime CreationTime { get; set; }
}


