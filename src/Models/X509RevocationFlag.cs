using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

public enum X509RevocationFlag
{
  /// <summary>
  /// Only the end certificate is checked for revocation
  /// </summary>
  EndCertificateOnly,

  /// <summary>
  /// The entire chain of certificates is checked for revocation
  /// </summary>
  EntireChain
}


