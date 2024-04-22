using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Client Secret response class
/// </summary>
public class Secret
{
   /// <summary>
   /// Unique ID of the client secret
   /// </summary>
   public required string Id { get; set; }

   /// <summary>
   /// Brief description of the secret
   /// </summary>
   public string? Description { get; set; }

   /// <summary>
   /// The expiration date of the secret (in Epoch)
   /// </summary>
   public DateTime? Expiration { get; set; }

   /// <summary>
   /// Specifies type of secret
   /// </summary>
   public required SecretTypes Type { get; set; }

   /// <summary>
   /// Specifies the creation time of the client secret (in Epoch).
   /// </summary>
   public required DateTime CreationTime { get; set; }

   /// <summary>
   /// Specifies the last update time of the client secret (in Epoch).
   /// </summary>
   public required DateTime LastUpdated { get; set; }
}


