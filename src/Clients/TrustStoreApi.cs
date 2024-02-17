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
/// Represents a collection of functions to interact with the TrustStore Api endpoints
/// </summary>
public class TrustStoreClient : MonoCloudClientBase
{
  /// <summary>
  /// Initializes a new instance of the <see cref="TrustStoreClient"/> class.
  /// </summary>
  /// <param name="configuration">The <see cref="MonoCloudConfig">MonoCloud Configuration</see></param>
  /// <returns></returns>
  public TrustStoreClient(MonoCloudConfig configuration) : base(configuration)
  {
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="TrustStoreClient"/> class.
  /// </summary>
  /// <param name="httpClient">The <see cref="HttpClient"/> which will be used to communicate with the MonoCloud Api</param>
  /// <returns></returns>
  public TrustStoreClient(HttpClient httpClient) : base(httpClient)
  {
  }

  /// <summary>
  /// Get Truststore
  /// </summary>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>TrustStore</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<TrustStore>> GetTrustStoreAsync(CancellationToken cancellationToken = default)
  { 
    var urlBuilder = new StringBuilder();
    urlBuilder.Append("truststore?");

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

    return ProcessRequestAsync<TrustStore>(request, cancellationToken);
  }

  /// <summary>
  /// Add a Certificates to truststore
  /// </summary>
  /// <param name="createTrustStoreCertificateRequest">Request Body</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>TrustStore</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<TrustStore>> AddCertificateAsync(CreateTrustStoreCertificateRequest createTrustStoreCertificateRequest, CancellationToken cancellationToken = default)
  { 
    if (createTrustStoreCertificateRequest == null)
    {
      throw new ArgumentNullException(nameof(createTrustStoreCertificateRequest));
    }
    
    var urlBuilder = new StringBuilder();
    urlBuilder.Append("truststore/certificates?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("POST"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(createTrustStoreCertificateRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<TrustStore>(request, cancellationToken);
  }

  /// <summary>
  /// Enable a Certificate
  /// </summary>
  /// <param name="id">Certificate Id</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>TrustStoreCertificate</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<TrustStoreCertificate>> EnableCertificateAsync(string id, CancellationToken cancellationToken = default)
  { 
    if (id == null)
    {
      throw new ArgumentNullException(nameof(id));
    }
    
    var encodedId = HttpUtility.UrlEncode(id);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"truststore/certificates/{encodedId}/enable?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("POST"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<TrustStoreCertificate>(request, cancellationToken);
  }

  /// <summary>
  /// Disable a Certificate
  /// </summary>
  /// <param name="id">Certificate Id</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>TrustStoreCertificate</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<TrustStoreCertificate>> DisableCertificateAsync(string id, CancellationToken cancellationToken = default)
  { 
    if (id == null)
    {
      throw new ArgumentNullException(nameof(id));
    }
    
    var encodedId = HttpUtility.UrlEncode(id);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"truststore/certificates/{encodedId}/disable?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("POST"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<TrustStoreCertificate>(request, cancellationToken);
  }

  /// <summary>
  /// Delete a Certificate
  /// </summary>
  /// <param name="id">Certificate Id</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns></returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse> DeleteCertificateAsync(string id, CancellationToken cancellationToken = default)
  { 
    if (id == null)
    {
      throw new ArgumentNullException(nameof(id));
    }
    
    var encodedId = HttpUtility.UrlEncode(id);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"truststore/certificates/{encodedId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("DELETE"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
    };

    return ProcessRequestAsync(request, cancellationToken);
  }

  /// <summary>
  /// Add a Certificate Revocation to truststore
  /// </summary>
  /// <param name="createTrustStoreRevocationRequest">Request Body</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>TrustStore</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<TrustStore>> AddCertificateRevocationAsync(CreateTrustStoreRevocationRequest createTrustStoreRevocationRequest, CancellationToken cancellationToken = default)
  { 
    if (createTrustStoreRevocationRequest == null)
    {
      throw new ArgumentNullException(nameof(createTrustStoreRevocationRequest));
    }
    
    var urlBuilder = new StringBuilder();
    urlBuilder.Append("truststore/revocations?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("POST"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(createTrustStoreRevocationRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<TrustStore>(request, cancellationToken);
  }

  /// <summary>
  /// Enable a Certificate Revocation
  /// </summary>
  /// <param name="id">Certificate Revocation Id</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>TrustStoreRevocation</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<TrustStoreRevocation>> EnableCertificateRevocationAsync(string id, CancellationToken cancellationToken = default)
  { 
    if (id == null)
    {
      throw new ArgumentNullException(nameof(id));
    }
    
    var encodedId = HttpUtility.UrlEncode(id);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"truststore/revocations/{encodedId}/enable?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("POST"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<TrustStoreRevocation>(request, cancellationToken);
  }

  /// <summary>
  /// Disable a Certificate Revocation
  /// </summary>
  /// <param name="id">Certificate Revocation Id</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>TrustStoreRevocation</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<TrustStoreRevocation>> DisableCertificateRevocationAsync(string id, CancellationToken cancellationToken = default)
  { 
    if (id == null)
    {
      throw new ArgumentNullException(nameof(id));
    }
    
    var encodedId = HttpUtility.UrlEncode(id);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"truststore/revocations/{encodedId}/disable?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("POST"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<TrustStoreRevocation>(request, cancellationToken);
  }

  /// <summary>
  /// Delete a Certificate Revocation
  /// </summary>
  /// <param name="id">Certificate Revocation Id</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns></returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse> DeleteCertificateRevocationAsync(string id, CancellationToken cancellationToken = default)
  { 
    if (id == null)
    {
      throw new ArgumentNullException(nameof(id));
    }
    
    var encodedId = HttpUtility.UrlEncode(id);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"truststore/revocations/{encodedId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("DELETE"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
    };

    return ProcessRequestAsync(request, cancellationToken);
  }

  /// <summary>
  /// Update a Certificate Revocation
  /// </summary>
  /// <param name="id">Certificate Revocation Id</param>
  /// <param name="updateTrustStoreRevocationRequest">Update certificate revocation request</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>TrustStoreRevocation</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<TrustStoreRevocation>> UpdateCertificateRevocationAsync(string id, UpdateTrustStoreRevocationRequest updateTrustStoreRevocationRequest, CancellationToken cancellationToken = default)
  { 
    if (id == null)
    {
      throw new ArgumentNullException(nameof(id));
    }
    
    if (updateTrustStoreRevocationRequest == null)
    {
      throw new ArgumentNullException(nameof(updateTrustStoreRevocationRequest));
    }
    
    var encodedId = HttpUtility.UrlEncode(id);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"truststore/revocations/{encodedId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("PATCH"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(updateTrustStoreRevocationRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<TrustStoreRevocation>(request, cancellationToken);
  }

  /// <summary>
  /// Adds a list of banned certificate thumbprints
  /// </summary>
  /// <param name="addBannedThumbprintsRequest">Request Body</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>TrustStore</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<TrustStore>> AddBannedThumbprintsAsync(AddBannedThumbprintsRequest addBannedThumbprintsRequest, CancellationToken cancellationToken = default)
  { 
    if (addBannedThumbprintsRequest == null)
    {
      throw new ArgumentNullException(nameof(addBannedThumbprintsRequest));
    }
    
    var urlBuilder = new StringBuilder();
    urlBuilder.Append("truststore/thumbprints?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("POST"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(addBannedThumbprintsRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<TrustStore>(request, cancellationToken);
  }

  /// <summary>
  /// Delete a Banned Thumbprint
  /// </summary>
  /// <param name="thumbprint">Thumbprint</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns></returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse> DeleteBannedThumbprintAsync(string thumbprint, CancellationToken cancellationToken = default)
  { 
    if (thumbprint == null)
    {
      throw new ArgumentNullException(nameof(thumbprint));
    }
    
    var encodedThumbprint = HttpUtility.UrlEncode(thumbprint);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"truststore/encodedThumbprints/{encodedThumbprint}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("DELETE"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
    };

    return ProcessRequestAsync(request, cancellationToken);
  }
}

