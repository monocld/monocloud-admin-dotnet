using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Log Summary response class
/// </summary>
public class LogSummary
{
   /// <summary>
   /// Unique identifier of the log
   /// </summary>
   public string Id { get; set; }

   /// <summary>
   /// Log Category
   /// </summary>
   public LogEventCategories Category { get; set; }

   /// <summary>
   /// Log Name.
   /// </summary>
   public string Name { get; set; }

   /// <summary>
   /// Log Type.
   /// </summary>
   public LogEventTypes EventType { get; set; }

   /// <summary>
   /// Log event Id.
   /// </summary>
   public LogEventIds EventId { get; set; }

   /// <summary>
   /// The Activity Id.
   /// </summary>
   public string? ActivityId { get; set; }

   /// <summary>
   /// Specifies the event time (in Epoch).
   /// </summary>
   public DateTime TimeStamp { get; set; }

   /// <summary>
   /// Specifies if the log was triggered by a user interactive process.
   /// </summary>
   public bool Interactive { get; set; }

   /// <summary>
   /// The client Id.
   /// </summary>
   public string? ClientId { get; set; }

   /// <summary>
   /// The Client Name.
   /// </summary>
   public string? ClientName { get; set; }
}


