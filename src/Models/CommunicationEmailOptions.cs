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
   /// Provider used to send Emails
   /// </summary>
   public EmailProviders Provider { get; set; }

   /// <summary>
   /// Default email address from where the emails will be sent.
   /// </summary>
   public string DefaultFromEmail { get; set; }
}


