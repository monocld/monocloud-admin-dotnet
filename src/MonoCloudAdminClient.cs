using System.Net.Http;
using MonoCloud.SDK.Admin.Clients;
using MonoCloud.SDK.Core.Base;

namespace MonoCloud.SDK.Admin;

/// <summary>
/// The MonoCloud Admin Client Class
/// </summary>
public class MonoCloudAdminClient
{ 
  /// <summary>
  /// Gets the BrandingClient instance to interact with the Branding Api endpoints
  /// </summary>
  public BrandingClient Branding { get; }

  /// <summary>
  /// Gets the ClientsClient instance to interact with the Clients Api endpoints
  /// </summary>
  public ClientsClient Clients { get; }

  /// <summary>
  /// Gets the KeysClient instance to interact with the Keys Api endpoints
  /// </summary>
  public KeysClient Keys { get; }

  /// <summary>
  /// Gets the LogsClient instance to interact with the Logs Api endpoints
  /// </summary>
  public LogsClient Logs { get; }

  /// <summary>
  /// Gets the OptionsClient instance to interact with the Options Api endpoints
  /// </summary>
  public OptionsClient Options { get; }

  /// <summary>
  /// Gets the ResourcesClient instance to interact with the Resources Api endpoints
  /// </summary>
  public ResourcesClient Resources { get; }

  /// <summary>
  /// Gets the TrustStoreClient instance to interact with the TrustStore Api endpoints
  /// </summary>
  public TrustStoreClient TrustStore { get; }

  /// <summary>
  /// Initializes the MonoCloud Admin Client Class
  /// </summary>
  /// <param name="configuration">The <see cref="MonoCloudConfig">MonoCloud Configuration</see></param>
  public MonoCloudAdminClient(MonoCloudConfig configuration)
  { 
    Branding = new BrandingClient(configuration);
    Clients = new ClientsClient(configuration);
    Keys = new KeysClient(configuration);
    Logs = new LogsClient(configuration);
    Options = new OptionsClient(configuration);
    Resources = new ResourcesClient(configuration);
    TrustStore = new TrustStoreClient(configuration);
  }


  /// <summary>
  /// Initializes the MonoCloud Admin Client Class
  /// </summary>
  /// <param name="httpClient">The <see cref="HttpClient"/> which will be used to communicate with the MonoCloud Api</param>
  public MonoCloudAdminClient(HttpClient httpClient)
  { 
    Branding = new BrandingClient(httpClient);
    Clients = new ClientsClient(httpClient);
    Keys = new KeysClient(httpClient);
    Logs = new LogsClient(httpClient);
    Options = new OptionsClient(httpClient);
    Resources = new ResourcesClient(httpClient);
    TrustStore = new TrustStoreClient(httpClient);
  }
}
