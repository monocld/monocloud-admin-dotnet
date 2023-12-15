using MonoCloud.SDK.Admin.Models;
using Moq;
using Moq.Contrib.HttpClient;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;

namespace MonoCloud.SDK.Admin.UnitTests;

public class SDKTests
{
  private readonly Mock<HttpMessageHandler> _httpMessageHandlerMock;
  private Dictionary<string, object> _requestMessage = new();
  private readonly MonoCloudAdminClient _adminClient;

  public SDKTests()
  {
    _httpMessageHandlerMock = new Mock<HttpMessageHandler>(MockBehavior.Strict);
    var httpClient = _httpMessageHandlerMock.CreateClient();
    httpClient.BaseAddress = new Uri("https://mock.com");
    _adminClient = new MonoCloudAdminClient(httpClient);
  }

  [Fact]
  public async Task Create_should_only_send_set_fields()
  {
    SetMockResponse(new Client());

    await _adminClient.Clients.CreateClientAsync(new CreateClientRequest
    {
      ClientName = "client"
    });

    Assert.NotEmpty(_requestMessage);
    Assert.Equal("client", _requestMessage["client_name"]);
    Assert.Single(_requestMessage);
  }

  [Fact]
  public async Task Create_should_send_correct_enum()
  {
    SetMockResponse(new Client());

    await _adminClient.Clients.CreateClientAsync(new CreateClientRequest
    {
      RefreshTokenExpiration = RefreshTokenExpirationTypes.Absolute
    });

    Assert.NotEmpty(_requestMessage);
    Assert.Equal("absolute", _requestMessage["refresh_token_expiration"]);
    Assert.Single(_requestMessage);
  }

  [Fact]
  public async Task Create_should_send_correct_list()
  {
    SetMockResponse(new Client());

    await _adminClient.Clients.CreateClientAsync(new CreateClientRequest
    {
      AllowedScopes = ["openid"]
    });

    Assert.NotEmpty(_requestMessage);
    Assert.Equivalent(new JArray("openid"), _requestMessage["allowed_scopes"]);
    Assert.Single(_requestMessage);
  }

  [Fact]
  public async Task Create_should_send_correct_datetime()
  {
    SetMockResponse(new Client());

    const long nowEpoch = 1000;
    var now = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(nowEpoch);

    await _adminClient.Clients.CreateClientSecretAsync("client", new CreateSecretRequest
    {
      Expiration = now
    });

    Assert.NotEmpty(_requestMessage);
    Assert.Equivalent(nowEpoch, _requestMessage["expiration"]);
    Assert.Single(_requestMessage);
  }

  [Fact]
  public async Task Patch_should_only_send_set_fields()
  {
    SetMockResponse(new Client());

    await _adminClient.Clients.PatchClientAsync("1234", new PatchClientRequest
    {
      ClientName = "client"
    });

    Assert.NotEmpty(_requestMessage);
    Assert.Equal("client", _requestMessage["client_name"]);
    Assert.Single(_requestMessage);
  }

  [Fact]
  public async Task Patch_should_send_null_fields_when_set()
  {
    SetMockResponse(new Client());

    await _adminClient.Clients.PatchClientAsync("1234", new PatchClientRequest
    {
      ClientName = null!
    });

    Assert.NotEmpty(_requestMessage);
    Assert.Null(_requestMessage["client_name"]);
    Assert.Single(_requestMessage);
  }

  [Fact]
  public async Task Get_should_receive_correct_datetime()
  {
    var now = DateTimeOffset.UtcNow.ToUnixTimeSeconds();

    SetMockResponse(new
    {
      creation_time = now
    });

    var result = await _adminClient.Clients.FindClientByIdAsync("client");

    Assert.NotNull(result);
    Assert.Equivalent(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(now), result.Data.CreationTime);
  }

  [Fact]
  public async Task Get_should_receive_correct_nullable_datetime()
  {
    SetMockResponse(new
    {
      expiration = (long?)null
    });

    var result = await _adminClient.Clients.FindClientSecretByIdAsync("client", "1");

    Assert.Null(result.Data.Expiration);
  }

  [Fact]
  public async Task Get_with_paging_should_receive_correct_result()
  {
    SetMockResponse(new List<Client>
    {
      new(),
      new()
    }, headers: new Dictionary<string, string>
    {
      { "x-Pagination", """{"total_count":20,"page_size":2,"current_page":3,"has_next":true,"has_previous":true}""" }
    });

    var result = await _adminClient.Clients.GetAllClientsAsync();

    Assert.Equal(2, result.Data.Count);
    Assert.Equal(20, result.PageData.TotalCount);
    Assert.Equal(2, result.PageData.PageSize);
    Assert.Equal(3, result.PageData.CurrentPage);
    Assert.True(result.PageData.HasNext);
    Assert.True(result.PageData.HasPrevious);
  }

  [Fact]
  public async Task Get_with_paging_should_handle_no_pagination_header()
  {
    SetMockResponse(new List<Client>
    {
      new(),
      new()
    });

    var result = await _adminClient.Clients.GetAllClientsAsync();

    Assert.Equal(2, result.Data.Count);
    Assert.Equal(0, result.PageData.TotalCount);
    Assert.Equal(0, result.PageData.PageSize);
    Assert.Equal(0, result.PageData.CurrentPage);
    Assert.False(result.PageData.HasNext);
    Assert.False(result.PageData.HasPrevious);
  }

  private void SetMockResponse(object request, HttpStatusCode code = HttpStatusCode.OK, IDictionary<string, string>? headers = null) =>
    _httpMessageHandlerMock.SetupRequest(async message =>
    {
      try
      {
        var val = await message.Content!.ReadAsStringAsync();
        _requestMessage = JsonConvert.DeserializeObject<Dictionary<string, object>>(val)!;
      }
      catch
      {
        //
      }
      return true;
    }).ReturnsJsonResponse(code, request, configure: (message) =>
    {
      if (headers is not null)
      {
        foreach (var httpResponseHeader in headers)
        {
          message.Headers.Add(httpResponseHeader.Key, httpResponseHeader.Value);
        }
      }
    });
}
