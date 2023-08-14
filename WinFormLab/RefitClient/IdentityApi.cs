using Refit;
using CommonRes.DTO;

namespace WinFormLab.RefitClient;

public interface IIdentityApi
{
  [Post("/api/Identity/GenerateToken")]
  Task<String> GenerateTokenAsync(TokenGenerationRequest request);
}
