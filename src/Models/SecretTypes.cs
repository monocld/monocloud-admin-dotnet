using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

public enum SecretTypes
{
    SharedSecret,

    X509Thumbprint,

    X509Name,

    X509IssuerName,

    X509CertificateBase64,

    Jwk
}


