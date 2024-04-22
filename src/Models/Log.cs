using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Log response class.
/// </summary>
public class Log
{
   /// <summary>
   /// Unique identifier of the log
   /// </summary>
   public required string Id { get; set; }

   /// <summary>
   /// Log Category
   /// </summary>
   public required LogEventCategories Category { get; set; }

   /// <summary>
   /// Log Name.
   /// </summary>
   public required string Name { get; set; }

   /// <summary>
   /// Log Type.
   /// </summary>
   public required LogEventTypes EventType { get; set; }

   /// <summary>
   /// Log event Id.
   /// </summary>
   public required LogEventIds EventId { get; set; }

   /// <summary>
   /// Message
   /// </summary>
   public string? Message { get; set; }

   /// <summary>
   /// The Activity Id.
   /// </summary>
   public string? ActivityId { get; set; }

   /// <summary>
   /// Specifies the event time (in Epoch).
   /// </summary>
   public required DateTime TimeStamp { get; set; }

   /// <summary>
   /// The Request metadata.
   /// </summary>
   public required LogRequestMetadata Metadata { get; set; }

   /// <summary>
   /// Specifies if the log was triggered by a user interactive process.
   /// </summary>
   public required bool Interactive { get; set; }

   /// <summary>
   /// The client Id.
   /// </summary>
   public string? ClientId { get; set; }

   /// <summary>
   /// The Client Name.
   /// </summary>
   public string? ClientName { get; set; }
}


