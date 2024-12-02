using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// Indicates if the event is a success or fail event.
/// </summary>
public enum EventTypes
{
  /// <summary>
  /// Success event
  /// </summary>
  Success,

  /// <summary>
  /// Failure event
  /// </summary>
  Failure,

  /// <summary>
  /// Information event
  /// </summary>
  Information,

  /// <summary>
  /// Error event
  /// </summary>
  Error
}


