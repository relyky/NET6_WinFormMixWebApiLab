using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;
using CommonRes;

namespace WebApi1.Controllers;

[Authorize]
[Route("api/[controller]")]
[ApiController]
public class FileHandleController : ControllerBase
{
  //# for injection
  readonly ILogger<FileHandleController> _logger;
  readonly IWebHostEnvironment _env;

  public FileHandleController(ILogger<FileHandleController> logger, IWebHostEnvironment env)
  {
    _logger = logger;
    _env = env;
  }

  [HttpPost("[action]")]
  [SwaggerResponse(200, type: typeof(string))]
  public IActionResult Echo()
  {
    return Ok($"echo at {DateTime.Now:HH:mm:ss.}");
  }

  [HttpPost("[action]")]
  [SwaggerResponse(200, type: typeof(byte[]))]
  [SwaggerResponse(400, type: typeof(string))]
  public IActionResult DownloadFile(Guid id)
  {
    // 模擬邏輯失敗！
    if (id == Guid.Empty)
    {
      return BadRequest("模擬邏輯失敗！");
    }

    FileInfo fi = new FileInfo(@"Template\全行客訴案件統計暨同期分析比較.xlsx");

    if (System.IO.File.Exists(fi.FullName))
    {
      return File(System.IO.File.ReadAllBytes(fi.FullName), "application/octet-stream", fi.Name);
    }

    return NotFound();
  }

  [HttpPost("[action]")]
  [SwaggerResponse(200, type: typeof(List<UploadResult>))]
  [SwaggerResponse(400, type: typeof(string))]
  public async Task<IActionResult> UploadFile(List<IFormFile> files)
  {
    //// 模擬邏輯失敗！
    //return BadRequest("我錯了！");

     List<UploadResult> uploadResults = new();

    foreach (IFormFile file in files)
    {
      string trustedFileNameForDisplay = WebUtility.HtmlEncode(file.FileName);
      string trustedFileNameForStorage = Path.GetRandomFileName();
      string path = Path.Combine(_env.ContentRootPath, "uploads", trustedFileNameForStorage);

      await using FileStream fs = new FileStream(path, FileMode.Create);
      await file.CopyToAsync(fs);

      uploadResults.Add(new UploadResult
      {
        FileName = trustedFileNameForDisplay,
        StoredFileName = trustedFileNameForStorage
      });
    }

    return Ok(uploadResults);
  }
}
