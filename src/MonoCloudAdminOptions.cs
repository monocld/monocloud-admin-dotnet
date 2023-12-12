using System;

namespace MonoCloud.SDK.Admin;

public class MonoCloudAdminOptions
{
  public string? Domain { get; set; }
  public string? ApiKey { get; set; }
  public TimeSpan? Timeout { get; set; }
}
