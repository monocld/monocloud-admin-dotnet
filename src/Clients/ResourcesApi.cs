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
  public Task<MonoCloudResponse<ApiResource>> FindApiResourceById(string id, CancellationToken cancellationToken = default)
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
  public Task<MonoCloudResponse> DeleteApiResource(string id, CancellationToken cancellationToken = default)
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
  public Task<MonoCloudResponse<ApiResource>> PatchApiResource(string id, PatchApiResourceRequest patchApiResourceRequest, CancellationToken cancellationToken = default)
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
  /// Find an Api Resource Secret by Id
  /// </summary>
  /// <param name="resourceId">Resource Id</param>
  /// <param name="secretId">Secret Id</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>SecretValue</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<SecretValue>> FindApiResourceSecretById(string resourceId, string secretId, CancellationToken cancellationToken = default)
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

    return ProcessRequestAsync<SecretValue>(request, cancellationToken);
  }

  /// <summary>
  /// Delete an Api Resource Secret
  /// </summary>
  /// <param name="resourceId">ResourceId Id</param>
  /// <param name="secretId">Secret Id</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns></returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse> DeleteApiResourceSecret(string resourceId, string secretId, CancellationToken cancellationToken = default)
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
  /// Find a Scope by Id
  /// </summary>
  /// <param name="id">Scope Id</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>Scope</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<Scope>> FindScopeById(string id, CancellationToken cancellationToken = default)
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
  public Task<MonoCloudResponse> DeleteScope(string id, CancellationToken cancellationToken = default)
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
  public Task<MonoCloudResponse<Scope>> PatchScope(string id, PatchScopeRequest patchScopeRequest, CancellationToken cancellationToken = default)
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
  public Task<MonoCloudResponse<ClaimResource>> FindClaimResourceById(string id, CancellationToken cancellationToken = default)
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
  public Task<MonoCloudResponse> DeleteClaimResource(string id, CancellationToken cancellationToken = default)
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
  public Task<MonoCloudResponse<ClaimResource>> PatchClaimResource(string id, PatchClaimResourceRequest patchClaimResourceRequest, CancellationToken cancellationToken = default)
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
  public Task<MonoCloudResponse<List<ApiResource>>> GetAllApiResources(int? page = 1, int? size = 10, string? filter = default, string? sort = default, CancellationToken cancellationToken = default)
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

    return ProcessRequestAsync<List<ApiResource>>(request, cancellationToken);
  }

  /// <summary>
  /// Create an Api Resource
  /// </summary>
  /// <param name="createApiResourceRequest">Request Body</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>ApiResource</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<ApiResource>> CreateApiResource(CreateApiResourceRequest createApiResourceRequest, CancellationToken cancellationToken = default)
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
  /// <param name="type">The type of scope by which the results should be filtered. Allowed values are &#39;api&#39; &amp; &#39;identity&#39;</param>
  /// <param name="page">Page Number</param>
  /// <param name="size">Page Size</param>
  /// <param name="filter">Value by which the resources needs to be filtered.</param>
  /// <param name="sort">Value in &#39;sort_key:sort_order&#39; format, by which results will be sorted. Sort order value can be &#39;1&#39; for ascending and &#39;-1&#39; for descending.  Acceptable sort key values are &#39;name&#39;, &#39;display_name&#39;, &#39;description&#39;, and &#39;creation_time&#39;</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>List&lt;Scope&gt;</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<List<Scope>>> GetAllScopes(string? type = default, int? page = 1, int? size = 10, string? filter = default, string? sort = default, CancellationToken cancellationToken = default)
  { 
    var urlBuilder = new StringBuilder();
    urlBuilder.Append("resources/scopes?");

    if (type != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("type") + "=").Append(HttpUtility.UrlEncode(type)).Append("&");
    }

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

    return ProcessRequestAsync<List<Scope>>(request, cancellationToken);
  }

  /// <summary>
  /// Create a Scope
  /// </summary>
  /// <param name="createScopeRequest">Request Body</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>Scope</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<Scope>> CreateScope(CreateScopeRequest createScopeRequest, CancellationToken cancellationToken = default)
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
  public Task<MonoCloudResponse<List<ClaimResource>>> GetAllClaimResources(int? page = 1, int? size = 10, string? filter = default, string? sort = default, CancellationToken cancellationToken = default)
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

    return ProcessRequestAsync<List<ClaimResource>>(request, cancellationToken);
  }

  /// <summary>
  /// Create an Claim Resource
  /// </summary>
  /// <param name="createClaimResourceRequest">Request Body</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>ClaimResource</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<ClaimResource>> CreateClaimResource(CreateClaimResourceRequest createClaimResourceRequest, CancellationToken cancellationToken = default)
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

  /// <summary>
  /// Create an Api Resource Secret
  /// </summary>
  /// <param name="resourceId">Resource Id</param>
  /// <param name="createSecretRequest">Request Body</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>Secret</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<Secret>> CreateApiResourceSecret(string resourceId, CreateSecretRequest createSecretRequest, CancellationToken cancellationToken = default)
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
}

