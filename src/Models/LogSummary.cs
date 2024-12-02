using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Log Summary response
/// </summary>
public class LogSummary
{
   /// <summary>
   /// Unique identifier of the log
   /// </summary>
   public Guid Id { get; set; }

   /// <summary>
   /// Specifies the event time (in Epoch).
   /// </summary>
   public DateTime TimeStamp { get; set; }

   /// <summary>
   /// Log Category
   /// </summary>
   public LogCategories Category { get; set; }

   /// <summary>
   /// Log Name.
   /// </summary>
   public string Name { get; set; }

   /// <summary>
   /// Log Description.
   /// </summary>
   public string Description { get; set; }

   /// <summary>
   /// Log Type.
   /// </summary>
   public EventTypes Type { get; set; }

   /// <summary>
   /// Log code.
   /// </summary>
   public EventCodes Code { get; set; }

   /// <summary>
   /// Message
   /// </summary>
   public string? Message { get; set; }

   /// <summary>
   /// The system details
   /// </summary>
   public LogSystem System { get; set; }

   /// <summary>
   /// The request details
   /// </summary>
   public LogRequest Request { get; set; }

   /// <summary>
   /// The source of the request
   /// </summary>
   public string? Source { get; set; }

   /// <summary>
   /// The actor who performed the action
   /// </summary>
   public LogActor Actor { get; set; }

   /// <summary>
   /// List of targets
   /// </summary>
   public List<LogTarget> Targets { get; set; }

   /// <summary>
   /// The client details
   /// </summary>
   public LogClient? Client { get; set; }

   /// <summary>
   /// The Log Details response
   /// </summary>
   public object Details { get; set; }
}


