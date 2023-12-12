using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// Specifies the type of the key
/// </summary>
public enum KeyMaterialTypes
{
    X509,

    Jwk,

    Ecdsa,

    Rsa
}


