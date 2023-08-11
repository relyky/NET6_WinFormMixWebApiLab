using Refit;
using CommonRes;

namespace WinFormLab.RefitClient;

/// <remarks>
/// 下載檔案參考：
/// https://stackoverflow.com/questions/42141274/refit-c-how-to-download-a-file
/// https://learn.microsoft.com/en-us/answers/questions/1033258/download-file-in-c-net-core
/// https://stackoverflow.com/questions/93551/how-to-encode-the-filename-parameter-of-content-disposition-header-in-http
/// </remarks>
public interface IFileHandleApi
{
  [Post("/api/FileHandle/DownloadFile")]
  Task<HttpContent> DowloadFileAsync(Guid id);

  [Post("/api/FileHandle/UploadFile")]
  Task<List<UploadResult>> UploadFileAsync(MultipartFormDataContent content);

  [Post("/api/FileHandle/Echo")]
  Task<string> EchoAsync();  
}
