using System;
using System.Collections.Generic;

namespace MonoCloud.SDK.Admin.Models;

/// <summary>
/// The Communication Email Options response class
/// </summary>
public class CommunicationEmailOptions
{
   /// <summary>
   /// SendGrid Email Options
   /// </summary>
   public CommunicationEmailSendGridOptions? SendGrid { get; set; }

   /// <summary>
   /// Use the the internal keys to send Emails
   /// </summary>
   public bool UseInternalKeys { get; set; }

   /// <summary>
   /// Default email address from where the emails will be sent.
   /// </summary>
   public string DefaultFromEmail { get; set; }

   /// <summary>
   /// From Email Address
   /// </summary>
   public string? FromEmail { get; set; }

   /// <summary>
   /// From Name
   /// </summary>
   public string? FromName { get; set; }
}


