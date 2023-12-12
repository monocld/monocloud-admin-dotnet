using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The KeyMaterial Response class
/// </summary>
public class KeyMaterial
{
   /// <summary>
   /// Unique identifier of the key.
   /// </summary>
   public string Id { get; set; }

   /// <summary>
   /// Specifies the type of algorithm used for signing.
   /// </summary>
   public SigningAlgorithms SigningAlgorithm { get; set; }

   /// <summary>
   /// Specifies whether the key is current default.
   /// </summary>
   public bool IsCurrent { get; set; }

   /// <summary>
   /// Specifies whether the key is system generated or not.
   /// </summary>
   public bool IsSystemGenerated { get; set; }

   /// <summary>
   /// Specifies the current use of the key.
   /// </summary>
   public KeyMaterialUses Use { get; set; }

   /// <summary>
   /// Specifies the use for which the key was created.
   /// </summary>
   public KeyMaterialUses OriginalUse { get; set; }

   /// <summary>
   /// Specifies the type of key.
   /// </summary>
   public KeyMaterialTypes KeyType { get; set; }

   /// <summary>
   /// Specifies the creation time of the key (in Epoch).
   /// </summary>
   public long CreationTime { get; set; }

   /// <summary>
   /// Specifies the time ( in Epoch ) from which the key is valid.
   /// </summary>
   public long ValidFrom { get; set; }

   /// <summary>
   /// Specifies the time ( in Epoch ) upto which the key is valid.
   /// </summary>
   public long? ValidTo { get; set; }

   /// <summary>
   /// Specifies the revocation time of the key ( in Epoch ).
   /// </summary>
   public long? RevocationDate { get; set; }

   /// <summary>
   /// Specifies the time ( in Epoch ) at which the key was rotated.
   /// </summary>
   public long? RotationDate { get; set; }
}


