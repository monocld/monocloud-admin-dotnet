using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// Indicates the type of actor who performed an action.
/// </summary>
public enum ActorTypes
{
  /// <summary>
  /// Unknown
  /// </summary>
  Unknown,

  /// <summary>
  /// The system
  /// </summary>
  System,

  /// <summary>
  /// Api Key
  /// </summary>
  ApiKey,

  /// <summary>
  /// Private Api Key
  /// </summary>
  PrivateApiKey,

  /// <summary>
  /// Public Api Key
  /// </summary>
  PublicApiKey,

  /// <summary>
  /// A user
  /// </summary>
  User,

  /// <summary>
  /// Api
  /// </summary>
  Api,

  /// <summary>
  /// Client
  /// </summary>
  Client
}


