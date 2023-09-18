using Refit;
using CommonRes;

namespace WinFormLab.RefitClient;

public interface IValuesApi
{
  [Get("/api/Values")]
  Task<List<MyValue>> QryValuesAsync();

  [Post("/api/Values")]
  Task<MyValue> AddValueAsync(MyValue formData);

  [Get("/api/Values/{id}")]
  Task<MyValue?> GetValueAsync([AliasAs("id")] int Id);

  [Put("/api/Values")]
  Task<MyValue?> UpdValueAsync(MyValue formData);

  [Delete("/api/Values/{id}")]
  Task<int> DelValueAsync(int id);
}
