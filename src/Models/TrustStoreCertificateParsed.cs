using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// Trust Store Certificate Chained Response
/// </summary>
public class TrustStoreCertificateParsed
{
   /// <summary>
   /// Certificate Id.
   /// </summary>
   public string Id { get; set; }

   /// <summary>
   /// Specifies if the certificate is enabled.
   /// </summary>
   public bool Enabled { get; set; }

   /// <summary>
   /// Certificate Value.
   /// </summary>
   public string Value { get; set; }

   /// <summary>
   /// The associated name/alias for the certificate.
   /// </summary>
   public string Name { get; set; }

   /// <summary>
   /// The algorithm used to create the signature of the certificate.
   /// </summary>
   public string Algorithm { get; set; }

   /// <summary>
   /// The X.509 format version of the certificate.
   /// </summary>
   public int _Version { get; set; }

   /// <summary>
   /// The subject distinguished names from the certificate.
   /// </summary>
   public Dictionary<string, string> Subject { get; set; }

   /// <summary>
   /// The subject distinguished names from the certificate authority that issued the X.509 certificate.
   /// </summary>
   public Dictionary<string, string> Issuer { get; set; }

   /// <summary>
   /// The serial number of the certificate as a hexadecimal string.
   /// </summary>
   public string SerialNumber { get; set; }

   /// <summary>
   /// Specifies the time (in Epoch) on which a certificate becomes valid.
   /// </summary>
   public long ValidFrom { get; set; }

   /// <summary>
   /// Specifies the time (in Epoch) after which a certificate is no longer valid.
   /// </summary>
   public long ValidTo { get; set; }

   /// <summary>
   /// Specifies whether the certificate contains a private key.
   /// </summary>
   public bool HasPrivateKey { get; set; }

   /// <summary>
   /// Specifies whether the certificate belongs to a certificate authority. If true the certificate can be used to issue other certificates.
   /// </summary>
   public bool IsCa { get; set; }

   /// <summary>
   /// Specifies whether the certificate has expired.
   /// </summary>
   public bool IsExpired { get; set; }

   /// <summary>
   /// Specifies whether the certificate is self signed.
   /// </summary>
   public bool IsSelfSigned { get; set; }

   /// <summary>
   /// Specifies whether the certificate is issued by a certificate in the store.
   /// </summary>
   public bool IsChild { get; set; }

   /// <summary>
   /// List of certificates that are issued by the current certificate.
   /// </summary>
   public List<TrustStoreCertificateParsed> Children { get; set; }
}


