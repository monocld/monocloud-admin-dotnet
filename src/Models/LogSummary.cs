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
   /// The Activity Id.
   /// </summary>
   public string? ActivityId { get; set; }

   /// <summary>
   /// Specifies the event time (in Epoch).
   /// </summary>
   public long TimeStamp { get; set; }

   /// <summary>
   /// The client Id.
   /// </summary>
   public string? ClientId { get; set; }
}


