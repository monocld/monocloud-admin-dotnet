using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Create Client Secret class
/// </summary>
public class CreateSecretRequest
{
   /// <summary>
   /// Brief description of the secret
   /// </summary>
   public string? Description { get; set; }

   /// <summary>
   /// The secret
   /// </summary>
   public string Value { get; set; } = string.Empty;

   /// <summary>
   /// The expiration date of the secret (in Epoch)
   /// </summary>
   public long? Expiration { get; set; }

   /// <summary>
   /// Specifies type of secret
   /// </summary>
   public SecretTypes Type { get; set; } = default;
}


