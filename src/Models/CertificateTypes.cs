using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

public enum CertificateTypes
{
  /// <summary>
  /// Verifies the certificate with root CA and intermediary CAs
  /// </summary>
  Chained,

  /// <summary>
  /// Verifies the self-signed certificate in the store against the certificate presented by the user
  /// </summary>
  SelfSigned,

  /// <summary>
  /// Verifies both self-signed and chained certificates
  /// </summary>
  All
}


