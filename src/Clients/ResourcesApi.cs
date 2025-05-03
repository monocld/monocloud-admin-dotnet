using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using MonoCloud.SDK.Core.Base;
using MonoCloud.SDK.Core.Exception;
using MonoCloud.SDK.Core.Helpers;
using MonoCloud.SDK.Admin.Models;

namespace MonoCloud.SDK.Admin.Clients;

/// <summary>
/// Represents a collection of functions to interact with the Resources Api endpoints
/// </summary>
public class ResourcesClient : MonoCloudClientBase
{
  /// <summary>
  /// Initializes a new instance of the <see cref="ResourcesClient"/> class.
  /// </summary>
  /// <param name="configuration">The <see cref="MonoCloudConfig">MonoCloud Configuration</see></param>
  /// <returns></returns>
  public ResourcesClient(MonoCloudConfig configuration) : base(configuration)
  {
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="ResourcesClient"/> class.
  /// </summary>
  /// <param name="httpClient">The <see cref="HttpClient"/> which will be used to communicate with the MonoCloud Api</param>
  /// <returns></returns>
  public ResourcesClient(HttpClient httpClient) : base(httpClient)
  {
  }

  /// <summary>
  /// Find an Api Resource by Id
  /// </summary>
  /// <param name="id">Api Resource Id</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>ApiResource</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<ApiResource>> FindApiResourceByIdAsync(string id, CancellationToken cancellationToken = default)
  { 
    if (id == null)
    {
      throw new ArgumentNullException(nameof(id));
    }
    
    var encodedId = HttpUtility.UrlEncode(id);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"resources/api_resources/{encodedId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("GET"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<ApiResource>(request, cancellationToken);
  }

  /// <summary>
  /// Delete an Api Resource
  /// </summary>
  /// <param name="id">Api Resource Id</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns></returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse> DeleteApiResourceAsync(string id, CancellationToken cancellationToken = default)
  { 
    if (id == null)
    {
      throw new ArgumentNullException(nameof(id));
    }
    
    var encodedId = HttpUtility.UrlEncode(id);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"resources/api_resources/{encodedId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("DELETE"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
    };

    return ProcessRequestAsync(request, cancellationToken);
  }

  /// <summary>
  /// Update an Api Resource
  /// </summary>
  /// <param name="id">Api Resource Id</param>
  /// <param name="patchApiResourceRequest">Request Body</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>ApiResource</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<ApiResource>> PatchApiResourceAsync(string id, PatchApiResourceRequest patchApiResourceRequest, CancellationToken cancellationToken = default)
  { 
    if (id == null)
    {
      throw new ArgumentNullException(nameof(id));
    }
    
    if (patchApiResourceRequest == null)
    {
      throw new ArgumentNullException(nameof(patchApiResourceRequest));
    }
    
    var encodedId = HttpUtility.UrlEncode(id);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"resources/api_resources/{encodedId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("PATCH"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(patchApiResourceRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<ApiResource>(request, cancellationToken);
  }

  /// <summary>
  /// Gets all Api Resource Secrets
  /// </summary>
  /// <param name="resourceId">Resource Id</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>List&lt;Secret&gt;</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<List<Secret>>> GetAllApiResourceSecretsAsync(string resourceId, CancellationToken cancellationToken = default)
  { 
    if (resourceId == null)
    {
      throw new ArgumentNullException(nameof(resourceId));
    }
    
    var encodedResourceId = HttpUtility.UrlEncode(resourceId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"resources/api_resources/{encodedResourceId}/secrets?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("GET"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<List<Secret>>(request, cancellationToken);
  }

  /// <summary>
  /// Create an Api Resource Secret
  /// </summary>
  /// <param name="resourceId">Resource Id</param>
  /// <param name="createSecretRequest">Request Body</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>Secret</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<Secret>> CreateApiResourceSecretAsync(string resourceId, CreateSecretRequest createSecretRequest, CancellationToken cancellationToken = default)
  { 
    if (resourceId == null)
    {
      throw new ArgumentNullException(nameof(resourceId));
    }
    
    if (createSecretRequest == null)
    {
      throw new ArgumentNullException(nameof(createSecretRequest));
    }
    
    var encodedResourceId = HttpUtility.UrlEncode(resourceId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"resources/api_resources/{encodedResourceId}/secrets?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("POST"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(createSecretRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<Secret>(request, cancellationToken);
  }

  /// <summary>
  /// Find an Api Resource Secret by Id
  /// </summary>
  /// <param name="resourceId">Resource Id</param>
  /// <param name="secretId">Secret Id</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>Secret</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<Secret>> FindApiResourceSecretByIdAsync(string resourceId, string secretId, CancellationToken cancellationToken = default)
  { 
    if (resourceId == null)
    {
      throw new ArgumentNullException(nameof(resourceId));
    }
    
    if (secretId == null)
    {
      throw new ArgumentNullException(nameof(secretId));
    }
    
    var encodedResourceId = HttpUtility.UrlEncode(resourceId);

    var encodedSecretId = HttpUtility.UrlEncode(secretId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"resources/api_resources/{encodedResourceId}/secrets/{encodedSecretId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("GET"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<Secret>(request, cancellationToken);
  }

  /// <summary>
  /// Delete an Api Resource Secret
  /// </summary>
  /// <param name="resourceId">ResourceId Id</param>
  /// <param name="secretId">Secret Id</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns></returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse> DeleteApiResourceSecretAsync(string resourceId, string secretId, CancellationToken cancellationToken = default)
  { 
    if (resourceId == null)
    {
      throw new ArgumentNullException(nameof(resourceId));
    }
    
    if (secretId == null)
    {
      throw new ArgumentNullException(nameof(secretId));
    }
    
    var encodedResourceId = HttpUtility.UrlEncode(resourceId);

    var encodedSecretId = HttpUtility.UrlEncode(secretId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"resources/api_resources/{encodedResourceId}/secrets/{encodedSecretId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("DELETE"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
    };

    return ProcessRequestAsync(request, cancellationToken);
  }

  /// <summary>
  /// Get all the Api Scopes
  /// </summary>
  /// <param name="resourceId">Api Resource Id</param>
  /// <param name="page">Page Number</param>
  /// <param name="size">Page Size</param>
  /// <param name="filter">Value by which the resources needs to be filtered.</param>
  /// <param name="sort">Value in &#39;sort_key:sort_order&#39; format, by which results will be sorted. Sort order value can be &#39;1&#39; for ascending and &#39;-1&#39; for descending.  Acceptable sort key values are &#39;name&#39;, &#39;display_name&#39;, &#39;description&#39;, and &#39;creation_time&#39;</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>List&lt;ApiScope&gt;</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<List<ApiScope>, PageModel>> GetAllApiScopesAsync(string resourceId, int? page = 1, int? size = 10, string? filter = default, string? sort = default, CancellationToken cancellationToken = default)
  { 
    if (resourceId == null)
    {
      throw new ArgumentNullException(nameof(resourceId));
    }
    
    var encodedResourceId = HttpUtility.UrlEncode(resourceId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"resources/api_resources/{encodedResourceId}/scopes?");

    if (page != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("page") + "=").Append(HttpUtility.UrlEncode(page.ToString())).Append("&");
    }

    if (size != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("size") + "=").Append(HttpUtility.UrlEncode(size.ToString())).Append("&");
    }

    if (filter != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("filter") + "=").Append(HttpUtility.UrlEncode(filter)).Append("&");
    }

    if (sort != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("sort") + "=").Append(HttpUtility.UrlEncode(sort)).Append("&");
    }

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("GET"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<List<ApiScope>, PageModel>(request, cancellationToken);
  }

  /// <summary>
  /// Create an Api Scope
  /// </summary>
  /// <param name="resourceId">Api Resource Id</param>
  /// <param name="createApiScopeRequest">Request Body</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>ApiScope</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<ApiScope>> CreateApiScopeAsync(string resourceId, CreateApiScopeRequest createApiScopeRequest, CancellationToken cancellationToken = default)
  { 
    if (resourceId == null)
    {
      throw new ArgumentNullException(nameof(resourceId));
    }
    
    if (createApiScopeRequest == null)
    {
      throw new ArgumentNullException(nameof(createApiScopeRequest));
    }
    
    var encodedResourceId = HttpUtility.UrlEncode(resourceId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"resources/api_resources/{encodedResourceId}/scopes?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("POST"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(createApiScopeRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<ApiScope>(request, cancellationToken);
  }

  /// <summary>
  /// Find an Api Scope by Id
  /// </summary>
  /// <param name="id">Scope Id</param>
  /// <param name="resourceId">Api Resource Id</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>ApiScope</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<ApiScope>> FindApiScopeByIdAsync(string id, string resourceId, CancellationToken cancellationToken = default)
  { 
    if (id == null)
    {
      throw new ArgumentNullException(nameof(id));
    }
    
    if (resourceId == null)
    {
      throw new ArgumentNullException(nameof(resourceId));
    }
    
    var encodedId = HttpUtility.UrlEncode(id);

    var encodedResourceId = HttpUtility.UrlEncode(resourceId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"resources/api_resources/{encodedResourceId}/scopes/{encodedId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("GET"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<ApiScope>(request, cancellationToken);
  }

  /// <summary>
  /// Delete an Api Scope
  /// </summary>
  /// <param name="id">Scope Id</param>
  /// <param name="resourceId">Api Resource Id</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns></returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse> DeleteApiScopeAsync(string id, string resourceId, CancellationToken cancellationToken = default)
  { 
    if (id == null)
    {
      throw new ArgumentNullException(nameof(id));
    }
    
    if (resourceId == null)
    {
      throw new ArgumentNullException(nameof(resourceId));
    }
    
    var encodedId = HttpUtility.UrlEncode(id);

    var encodedResourceId = HttpUtility.UrlEncode(resourceId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"resources/api_resources/{encodedResourceId}/scopes/{encodedId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("DELETE"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
    };

    return ProcessRequestAsync(request, cancellationToken);
  }

  /// <summary>
  /// Update an Api Scope
  /// </summary>
  /// <param name="id">Scope Id</param>
  /// <param name="resourceId">Api Resource Id</param>
  /// <param name="patchApiScopeRequest">Request Body</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>ApiScope</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<ApiScope>> PatchApiScopeAsync(string id, string resourceId, PatchApiScopeRequest patchApiScopeRequest, CancellationToken cancellationToken = default)
  { 
    if (id == null)
    {
      throw new ArgumentNullException(nameof(id));
    }
    
    if (resourceId == null)
    {
      throw new ArgumentNullException(nameof(resourceId));
    }
    
    if (patchApiScopeRequest == null)
    {
      throw new ArgumentNullException(nameof(patchApiScopeRequest));
    }
    
    var encodedId = HttpUtility.UrlEncode(id);

    var encodedResourceId = HttpUtility.UrlEncode(resourceId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"resources/api_resources/{encodedResourceId}/scopes/{encodedId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("PATCH"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(patchApiScopeRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<ApiScope>(request, cancellationToken);
  }

  /// <summary>
  /// Get all the Client Api Resource Associations
  /// </summary>
  /// <param name="clientId">Api Resource Id</param>
  /// <param name="page">Page Number</param>
  /// <param name="size">Page Size</param>
  /// <param name="sort">Value in &#39;sort_key:sort_order&#39; format, by which results will be sorted. Sort order value can be &#39;1&#39; for ascending and &#39;-1&#39; for descending.  Acceptable sort key values are &#39;client_id&#39;, &#39;creation_time&#39; and &#39;last_updated&#39;</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>List&lt;ApiResourceClient&gt;</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<List<ApiResourceClient>, PageModel>> GetAllClientApiResourcesAsync(string clientId, int? page = 1, int? size = 10, string? sort = default, CancellationToken cancellationToken = default)
  { 
    if (clientId == null)
    {
      throw new ArgumentNullException(nameof(clientId));
    }
    
    var encodedClientId = HttpUtility.UrlEncode(clientId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"resources/api_resources/clients/{encodedClientId}?");

    if (page != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("page") + "=").Append(HttpUtility.UrlEncode(page.ToString())).Append("&");
    }

    if (size != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("size") + "=").Append(HttpUtility.UrlEncode(size.ToString())).Append("&");
    }

    if (sort != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("sort") + "=").Append(HttpUtility.UrlEncode(sort)).Append("&");
    }

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("GET"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<List<ApiResourceClient>, PageModel>(request, cancellationToken);
  }

  /// <summary>
  /// Get all the Api Resource Client Associations
  /// </summary>
  /// <param name="resourceId">Api Resource Id</param>
  /// <param name="page">Page Number</param>
  /// <param name="size">Page Size</param>
  /// <param name="sort">Value in &#39;sort_key:sort_order&#39; format, by which results will be sorted. Sort order value can be &#39;1&#39; for ascending and &#39;-1&#39; for descending.  Acceptable sort key values are &#39;client_id&#39;, &#39;creation_time&#39; and &#39;last_updated&#39;</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>List&lt;ApiResourceClient&gt;</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<List<ApiResourceClient>, PageModel>> GetAllApiResourceClientsAsync(string resourceId, int? page = 1, int? size = 10, string? sort = default, CancellationToken cancellationToken = default)
  { 
    if (resourceId == null)
    {
      throw new ArgumentNullException(nameof(resourceId));
    }
    
    var encodedResourceId = HttpUtility.UrlEncode(resourceId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"resources/api_resources/{encodedResourceId}/clients?");

    if (page != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("page") + "=").Append(HttpUtility.UrlEncode(page.ToString())).Append("&");
    }

    if (size != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("size") + "=").Append(HttpUtility.UrlEncode(size.ToString())).Append("&");
    }

    if (sort != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("sort") + "=").Append(HttpUtility.UrlEncode(sort)).Append("&");
    }

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("GET"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<List<ApiResourceClient>, PageModel>(request, cancellationToken);
  }

  /// <summary>
  /// Find an Api Resource Client Association
  /// </summary>
  /// <param name="resourceId">Api Resource Id</param>
  /// <param name="clientId">Client Id</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>ApiResourceClient</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<ApiResourceClient>> FindApiResourceClientAsync(string resourceId, string clientId, CancellationToken cancellationToken = default)
  { 
    if (resourceId == null)
    {
      throw new ArgumentNullException(nameof(resourceId));
    }
    
    if (clientId == null)
    {
      throw new ArgumentNullException(nameof(clientId));
    }
    
    var encodedResourceId = HttpUtility.UrlEncode(resourceId);

    var encodedClientId = HttpUtility.UrlEncode(clientId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"resources/api_resources/{encodedResourceId}/clients/{encodedClientId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("GET"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<ApiResourceClient>(request, cancellationToken);
  }

  /// <summary>
  /// Create an Api Resource Client Association
  /// </summary>
  /// <param name="resourceId">Api Resource Id</param>
  /// <param name="clientId">Client Id</param>
  /// <param name="createApiResourceClientRequest">Request Body</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>ApiResourceClient</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<ApiResourceClient>> CreateApiResourceClientAsync(string resourceId, string clientId, CreateApiResourceClientRequest createApiResourceClientRequest, CancellationToken cancellationToken = default)
  { 
    if (resourceId == null)
    {
      throw new ArgumentNullException(nameof(resourceId));
    }
    
    if (clientId == null)
    {
      throw new ArgumentNullException(nameof(clientId));
    }
    
    if (createApiResourceClientRequest == null)
    {
      throw new ArgumentNullException(nameof(createApiResourceClientRequest));
    }
    
    var encodedResourceId = HttpUtility.UrlEncode(resourceId);

    var encodedClientId = HttpUtility.UrlEncode(clientId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"resources/api_resources/{encodedResourceId}/clients/{encodedClientId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("POST"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(createApiResourceClientRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<ApiResourceClient>(request, cancellationToken);
  }

  /// <summary>
  /// Remove an Api Resource Client Association
  /// </summary>
  /// <param name="resourceId">ResourceId Id</param>
  /// <param name="clientId">Client Id</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns></returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse> RemoveApiResourceClientAsync(string resourceId, string clientId, CancellationToken cancellationToken = default)
  { 
    if (resourceId == null)
    {
      throw new ArgumentNullException(nameof(resourceId));
    }
    
    if (clientId == null)
    {
      throw new ArgumentNullException(nameof(clientId));
    }
    
    var encodedResourceId = HttpUtility.UrlEncode(resourceId);

    var encodedClientId = HttpUtility.UrlEncode(clientId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"resources/api_resources/{encodedResourceId}/clients/{encodedClientId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("DELETE"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
    };

    return ProcessRequestAsync(request, cancellationToken);
  }

  /// <summary>
  /// Update an Api Resource Client Association
  /// </summary>
  /// <param name="resourceId">Api Resource Id</param>
  /// <param name="clientId">Client Id</param>
  /// <param name="patchApiResourceClientRequest">Request Body</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>ApiResourceClient</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<ApiResourceClient>> PatchApiResourceClientAsync(string resourceId, string clientId, PatchApiResourceClientRequest patchApiResourceClientRequest, CancellationToken cancellationToken = default)
  { 
    if (resourceId == null)
    {
      throw new ArgumentNullException(nameof(resourceId));
    }
    
    if (clientId == null)
    {
      throw new ArgumentNullException(nameof(clientId));
    }
    
    if (patchApiResourceClientRequest == null)
    {
      throw new ArgumentNullException(nameof(patchApiResourceClientRequest));
    }
    
    var encodedResourceId = HttpUtility.UrlEncode(resourceId);

    var encodedClientId = HttpUtility.UrlEncode(clientId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"resources/api_resources/{encodedResourceId}/clients/{encodedClientId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("PATCH"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(patchApiResourceClientRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<ApiResourceClient>(request, cancellationToken);
  }

  /// <summary>
  /// Find a Scope by Id
  /// </summary>
  /// <param name="id">Scope Id</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>Scope</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<Scope>> FindScopeByIdAsync(string id, CancellationToken cancellationToken = default)
  { 
    if (id == null)
    {
      throw new ArgumentNullException(nameof(id));
    }
    
    var encodedId = HttpUtility.UrlEncode(id);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"resources/scopes/{encodedId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("GET"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<Scope>(request, cancellationToken);
  }

  /// <summary>
  /// Delete a Scope
  /// </summary>
  /// <param name="id">Scope Id</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns></returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse> DeleteScopeAsync(string id, CancellationToken cancellationToken = default)
  { 
    if (id == null)
    {
      throw new ArgumentNullException(nameof(id));
    }
    
    var encodedId = HttpUtility.UrlEncode(id);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"resources/scopes/{encodedId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("DELETE"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
    };

    return ProcessRequestAsync(request, cancellationToken);
  }

  /// <summary>
  /// Update a scope
  /// </summary>
  /// <param name="id">Scope Id</param>
  /// <param name="patchScopeRequest">Request Body</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>Scope</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<Scope>> PatchScopeAsync(string id, PatchScopeRequest patchScopeRequest, CancellationToken cancellationToken = default)
  { 
    if (id == null)
    {
      throw new ArgumentNullException(nameof(id));
    }
    
    if (patchScopeRequest == null)
    {
      throw new ArgumentNullException(nameof(patchScopeRequest));
    }
    
    var encodedId = HttpUtility.UrlEncode(id);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"resources/scopes/{encodedId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("PATCH"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(patchScopeRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<Scope>(request, cancellationToken);
  }

  /// <summary>
  /// Find an Claim Resource by Id
  /// </summary>
  /// <param name="id">Claim Resource Id</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>ClaimResource</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<ClaimResource>> FindClaimResourceByIdAsync(string id, CancellationToken cancellationToken = default)
  { 
    if (id == null)
    {
      throw new ArgumentNullException(nameof(id));
    }
    
    var encodedId = HttpUtility.UrlEncode(id);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"resources/claim_resources/{encodedId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("GET"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<ClaimResource>(request, cancellationToken);
  }

  /// <summary>
  /// Delete an Claim Resource
  /// </summary>
  /// <param name="id">Claim Resource Id</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns></returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse> DeleteClaimResourceAsync(string id, CancellationToken cancellationToken = default)
  { 
    if (id == null)
    {
      throw new ArgumentNullException(nameof(id));
    }
    
    var encodedId = HttpUtility.UrlEncode(id);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"resources/claim_resources/{encodedId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("DELETE"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
    };

    return ProcessRequestAsync(request, cancellationToken);
  }

  /// <summary>
  /// Update an Claim Resource
  /// </summary>
  /// <param name="id">Claim Resource Id</param>
  /// <param name="patchClaimResourceRequest">Request Body</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>ClaimResource</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<ClaimResource>> PatchClaimResourceAsync(string id, PatchClaimResourceRequest patchClaimResourceRequest, CancellationToken cancellationToken = default)
  { 
    if (id == null)
    {
      throw new ArgumentNullException(nameof(id));
    }
    
    if (patchClaimResourceRequest == null)
    {
      throw new ArgumentNullException(nameof(patchClaimResourceRequest));
    }
    
    var encodedId = HttpUtility.UrlEncode(id);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"resources/claim_resources/{encodedId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("PATCH"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(patchClaimResourceRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<ClaimResource>(request, cancellationToken);
  }

  /// <summary>
  /// Get all the Api Resources
  /// </summary>
  /// <param name="page">Page Number</param>
  /// <param name="size">Page Size</param>
  /// <param name="filter">Value by which the resources needs to be filtered.</param>
  /// <param name="sort">Value in &#39;sort_key:sort_order&#39; format, by which results will be sorted. Sort order value can be &#39;1&#39; for ascending and &#39;-1&#39; for descending.  Acceptable sort key values are &#39;name&#39;, &#39;display_name&#39;, &#39;description&#39;, and &#39;creation_time&#39;</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>List&lt;ApiResource&gt;</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<List<ApiResource>, PageModel>> GetAllApiResourcesAsync(int? page = 1, int? size = 10, string? filter = default, string? sort = default, CancellationToken cancellationToken = default)
  { 
    var urlBuilder = new StringBuilder();
    urlBuilder.Append("resources/api_resources?");

    if (page != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("page") + "=").Append(HttpUtility.UrlEncode(page.ToString())).Append("&");
    }

    if (size != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("size") + "=").Append(HttpUtility.UrlEncode(size.ToString())).Append("&");
    }

    if (filter != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("filter") + "=").Append(HttpUtility.UrlEncode(filter)).Append("&");
    }

    if (sort != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("sort") + "=").Append(HttpUtility.UrlEncode(sort)).Append("&");
    }

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("GET"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<List<ApiResource>, PageModel>(request, cancellationToken);
  }

  /// <summary>
  /// Create an Api Resource
  /// </summary>
  /// <param name="createApiResourceRequest">Request Body</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>ApiResource</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<ApiResource>> CreateApiResourceAsync(CreateApiResourceRequest createApiResourceRequest, CancellationToken cancellationToken = default)
  { 
    if (createApiResourceRequest == null)
    {
      throw new ArgumentNullException(nameof(createApiResourceRequest));
    }
    
    var urlBuilder = new StringBuilder();
    urlBuilder.Append("resources/api_resources?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("POST"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(createApiResourceRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<ApiResource>(request, cancellationToken);
  }

  /// <summary>
  /// Get all the Scopes
  /// </summary>
  /// <param name="page">Page Number</param>
  /// <param name="size">Page Size</param>
  /// <param name="filter">Value by which the resources needs to be filtered.</param>
  /// <param name="sort">Value in &#39;sort_key:sort_order&#39; format, by which results will be sorted. Sort order value can be &#39;1&#39; for ascending and &#39;-1&#39; for descending.  Acceptable sort key values are &#39;name&#39;, &#39;display_name&#39;, &#39;description&#39;, and &#39;creation_time&#39;</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>List&lt;Scope&gt;</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<List<Scope>, PageModel>> GetAllScopesAsync(int? page = 1, int? size = 10, string? filter = default, string? sort = default, CancellationToken cancellationToken = default)
  { 
    var urlBuilder = new StringBuilder();
    urlBuilder.Append("resources/scopes?");

    if (page != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("page") + "=").Append(HttpUtility.UrlEncode(page.ToString())).Append("&");
    }

    if (size != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("size") + "=").Append(HttpUtility.UrlEncode(size.ToString())).Append("&");
    }

    if (filter != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("filter") + "=").Append(HttpUtility.UrlEncode(filter)).Append("&");
    }

    if (sort != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("sort") + "=").Append(HttpUtility.UrlEncode(sort)).Append("&");
    }

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("GET"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<List<Scope>, PageModel>(request, cancellationToken);
  }

  /// <summary>
  /// Create a Scope
  /// </summary>
  /// <param name="createScopeRequest">Request Body</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>Scope</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<Scope>> CreateScopeAsync(CreateScopeRequest createScopeRequest, CancellationToken cancellationToken = default)
  { 
    if (createScopeRequest == null)
    {
      throw new ArgumentNullException(nameof(createScopeRequest));
    }
    
    var urlBuilder = new StringBuilder();
    urlBuilder.Append("resources/scopes?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("POST"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(createScopeRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<Scope>(request, cancellationToken);
  }

  /// <summary>
  /// Get all the Claim Resources
  /// </summary>
  /// <param name="page">Page Number</param>
  /// <param name="size">Page Size</param>
  /// <param name="filter">Value by which the resources needs to be filtered.</param>
  /// <param name="sort">Value in &#39;sort_key:sort_order&#39; format, by which results will be sorted. Sort order value can be &#39;1&#39; for ascending and &#39;-1&#39; for descending.  Acceptable sort key values are &#39;name&#39;, &#39;display_name&#39;, &#39;description&#39;, and &#39;creation_time&#39;</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>List&lt;ClaimResource&gt;</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<List<ClaimResource>, PageModel>> GetAllClaimResourcesAsync(int? page = 1, int? size = 10, string? filter = default, string? sort = default, CancellationToken cancellationToken = default)
  { 
    var urlBuilder = new StringBuilder();
    urlBuilder.Append("resources/claim_resources?");

    if (page != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("page") + "=").Append(HttpUtility.UrlEncode(page.ToString())).Append("&");
    }

    if (size != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("size") + "=").Append(HttpUtility.UrlEncode(size.ToString())).Append("&");
    }

    if (filter != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("filter") + "=").Append(HttpUtility.UrlEncode(filter)).Append("&");
    }

    if (sort != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("sort") + "=").Append(HttpUtility.UrlEncode(sort)).Append("&");
    }

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("GET"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<List<ClaimResource>, PageModel>(request, cancellationToken);
  }

  /// <summary>
  /// Create an Claim Resource
  /// </summary>
  /// <param name="createClaimResourceRequest">Request Body</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>ClaimResource</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<ClaimResource>> CreateClaimResourceAsync(CreateClaimResourceRequest createClaimResourceRequest, CancellationToken cancellationToken = default)
  { 
    if (createClaimResourceRequest == null)
    {
      throw new ArgumentNullException(nameof(createClaimResourceRequest));
    }
    
    var urlBuilder = new StringBuilder();
    urlBuilder.Append("resources/claim_resources?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("POST"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(createClaimResourceRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<ClaimResource>(request, cancellationToken);
  }
}

