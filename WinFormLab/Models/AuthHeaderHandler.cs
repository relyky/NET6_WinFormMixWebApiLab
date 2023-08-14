using System.Net.Http.Headers;

namespace WinFormLab.Models;

/// <summary>
/// Custom delegating handler for adding Auth headers to outbound requests
/// </summary>
class AuthHeaderHandler : DelegatingHandler
{
  protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
  {
    //## 自 token 存放庫取得
    string? token = AppDomain.CurrentDomain.GetData("AUTH_TOKEN") as string;

    //※ potentially refresh token here if it has expired etc.

    if (!String.IsNullOrWhiteSpace(token))
      request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);

    var resp = await base.SendAsync(request, cancellationToken);
    return resp;
  }
}