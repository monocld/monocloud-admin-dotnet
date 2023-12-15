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
/// Represents a collection of functions to interact with the Options Api endpoints
/// </summary>
public class OptionsClient : MonoCloudClientBase
{
  /// <summary>
  /// Initializes a new instance of the <see cref="OptionsClient"/> class.
  /// </summary>
  /// <param name="configuration">The <see cref="MonoCloudConfig">MonoCloud Configuration</see></param>
  /// <returns></returns>
  public OptionsClient(MonoCloudConfig configuration) : base(configuration)
  {
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="OptionsClient"/> class.
  /// </summary>
  /// <param name="httpClient">The <see cref="HttpClient"/> which will be used to communicate with the MonoCloud Api</param>
  /// <returns></returns>
  public OptionsClient(HttpClient httpClient) : base(httpClient)
  {
  }

  /// <summary>
  /// Get Authentication Options
  /// </summary>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>AuthenticationOptions</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<AuthenticationOptions>> FindAuthenticationOptionsAsync(CancellationToken cancellationToken = default)
  { 
    var urlBuilder = new StringBuilder();
    urlBuilder.Append("options/authentication?");

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

    return ProcessRequestAsync<AuthenticationOptions>(request, cancellationToken);
  }

  /// <summary>
  /// Update Authentication Options
  /// </summary>
  /// <param name="patchAuthenticationOptionsRequest">Request Body</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>AuthenticationOptions</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<AuthenticationOptions>> PatchAuthenticationOptionsAsync(PatchAuthenticationOptionsRequest patchAuthenticationOptionsRequest, CancellationToken cancellationToken = default)
  { 
    if (patchAuthenticationOptionsRequest == null)
    {
      throw new ArgumentNullException(nameof(patchAuthenticationOptionsRequest));
    }
    
    var urlBuilder = new StringBuilder();
    urlBuilder.Append("options/authentication?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("PATCH"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(patchAuthenticationOptionsRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<AuthenticationOptions>(request, cancellationToken);
  }

  /// <summary>
  /// Get Branding Options
  /// </summary>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>BrandingOptions</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<BrandingOptions>> FindBrandingOptionsAsync(CancellationToken cancellationToken = default)
  { 
    var urlBuilder = new StringBuilder();
    urlBuilder.Append("options/branding?");

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

    return ProcessRequestAsync<BrandingOptions>(request, cancellationToken);
  }

  /// <summary>
  /// Update Branding Options
  /// </summary>
  /// <param name="patchBrandingOptionsRequest">Request Body</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>BrandingOptions</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<BrandingOptions>> PatchBrandingOptionsAsync(PatchBrandingOptionsRequest patchBrandingOptionsRequest, CancellationToken cancellationToken = default)
  { 
    if (patchBrandingOptionsRequest == null)
    {
      throw new ArgumentNullException(nameof(patchBrandingOptionsRequest));
    }
    
    var urlBuilder = new StringBuilder();
    urlBuilder.Append("options/branding?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("PATCH"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(patchBrandingOptionsRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<BrandingOptions>(request, cancellationToken);
  }

  /// <summary>
  /// Get Communication Options
  /// </summary>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>CommunicationOptions</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<CommunicationOptions>> FindCommunicationOptionsAsync(CancellationToken cancellationToken = default)
  { 
    var urlBuilder = new StringBuilder();
    urlBuilder.Append("options/communication?");

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

    return ProcessRequestAsync<CommunicationOptions>(request, cancellationToken);
  }

  /// <summary>
  /// Update Communication Options
  /// </summary>
  /// <param name="patchCommunicationOptionsRequest">Request Body</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>CommunicationOptions</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<CommunicationOptions>> PatchCommunicationOptionsAsync(PatchCommunicationOptionsRequest patchCommunicationOptionsRequest, CancellationToken cancellationToken = default)
  { 
    if (patchCommunicationOptionsRequest == null)
    {
      throw new ArgumentNullException(nameof(patchCommunicationOptionsRequest));
    }
    
    var urlBuilder = new StringBuilder();
    urlBuilder.Append("options/communication?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("PATCH"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(patchCommunicationOptionsRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<CommunicationOptions>(request, cancellationToken);
  }

  /// <summary>
  /// Get Mtls Options
  /// </summary>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>MtlsOptions</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<MtlsOptions>> FindMtlsOptionsAsync(CancellationToken cancellationToken = default)
  { 
    var urlBuilder = new StringBuilder();
    urlBuilder.Append("options/mtls?");

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

    return ProcessRequestAsync<MtlsOptions>(request, cancellationToken);
  }

  /// <summary>
  /// Update Mtls Options
  /// </summary>
  /// <param name="patchMtlsOptionsRequest">Request Body</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>MtlsOptions</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<MtlsOptions>> PatchMtlsOptionsAsync(PatchMtlsOptionsRequest patchMtlsOptionsRequest, CancellationToken cancellationToken = default)
  { 
    if (patchMtlsOptionsRequest == null)
    {
      throw new ArgumentNullException(nameof(patchMtlsOptionsRequest));
    }
    
    var urlBuilder = new StringBuilder();
    urlBuilder.Append("options/mtls?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("PATCH"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(patchMtlsOptionsRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<MtlsOptions>(request, cancellationToken);
  }
}

