using DemoSysComm;
using Refit;

namespace DemoSysUI.RefitClient;

public interface IMyValueApi
{
  [Get("/api/MyValue")]
  Task<List<MyValue>> QryValuesAsync();

  //[Post("/api/MyValue")]
  //Task<MyValue> AddValueAsync(MyValue formData);

  //[Get("/api/MyValue/{id}")]
  //Task<MyValue?> GetValueAsync([AliasAs("id")] int Id);

  //[Put("/api/MyValue")]
  //Task<MyValue?> UpdValueAsync(MyValue formData);

  //[Delete("/api/MyValue/{id}")]
  //Task<int> DelValueAsync(int id);
}