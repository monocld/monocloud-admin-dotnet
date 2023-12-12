using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// Trust Store Certificate Response
/// </summary>
public class TrustStoreCertificate
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
}


