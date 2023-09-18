using CommonRes;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Refit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormLab.RefitClient;

namespace WinFormLab;

public partial class FormA04 : Form
{
  readonly IHostEnvironment _env;
  readonly IConfiguration _cfg;
  readonly IFileHandleApi _bizApi;

  public FormA04(IFileHandleApi bizApi, IHostEnvironment env, IConfiguration cfg)
  {
    _bizApi = bizApi;
    _env = env;
    _cfg = cfg;
    InitializeComponent();
  }

  #region Helper 
  async Task<List<UploadResult>?> UploadFilesAsync(IEnumerable<string> filePathList)
  {
    List<FileStream> fsBuff = new List<FileStream>(); // used to release
    try
    {
      using var content = new MultipartFormDataContent();

      foreach (string filePath in filePathList)
      {
        FileInfo file = new FileInfo(filePath);

        FileStream fs = file.OpenRead();
        fsBuff.Add(fs); // used to release

        var fileContent = new StreamContent(fs);
        fileContent.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");

        content.Add(
          content: fileContent,
          name: "\"files\"",
          fileName: file.Name);
      }

      //var uploadResults = Task.Run(async () => await _bizApi.UploadFileAsync(content)).GetAwaiter().GetResult();
      var uploadResults = await _bizApi.UploadFileAsync(content);

      return uploadResults;
    }
    catch (ApiException ex)
    {
      string errMsg = $"ApiException: {ex.StatusCode:D}-{ex.StatusCode} {ex.Content}";
      throw new ApplicationException(errMsg, ex);
    }
    finally
    {
      //# release resource
      fsBuff.ForEach(fs => fs.Dispose());
    }
  }

  async Task<(byte[] fileBlob, string filename)> DownloadFileAsync(Guid id)
  {
    try
    {
      //HttpContent content = Task.Run(async () => await _bizApi.DowloadFileAsync(id)).GetAwaiter().GetResult();
      HttpContent content = await _bizApi.DowloadFileAsync(id);
      byte[] fileBlob = await content.ReadAsByteArrayAsync();

      string filenameU = content.Headers.GetValues("Content-Disposition").First().Split("filename*=UTF-8''")[1];
      string filename = Uri.UnescapeDataString(filenameU); // 解碼

      return (fileBlob, filename);
    }
    catch (ApiException ex)
    {
      string errMsg = $"ApiException: {ex.StatusCode:D}-{ex.StatusCode} {ex.Content}";
      throw new ApplicationException(errMsg, ex);
    }
  }

  #endregion

  async void button1_Click(object sender, EventArgs e)
  {
    try
    {
      if (DialogResult.OK == openFileDialog1.ShowDialog())
      {
        var uploadResults = await UploadFilesAsync(openFileDialog1.FileNames);
        if (uploadResults != null)
        {
          foreach (var uploadResult in uploadResults)
          {
            textMessage.AppendText($" => 已上傳檔案：{uploadResult.FileName} => {uploadResult.StoredFileName} {uploadResult.ContentType} {Environment.NewLine}");
          }
        }
      }
    }
    catch (Exception ex)
    {
      MessageBox.Show(ex.Message, "出現例外！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
  }

  async void button2_Click(object sender, EventArgs e)
  {
    try
    {
      bool f_testFail = false;
      Guid id = f_testFail ? Guid.Empty : Guid.NewGuid();

      (byte[] fileBlob, string filename) = await DownloadFileAsync(id);

      string downFolder = @"C:\Temp";
      string downFilePath = Path.Combine(downFolder, filename);
      File.WriteAllBytes(downFilePath, fileBlob);

      MessageBox.Show($"下載檔案位置：{downFilePath}", "出現例外！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    catch (Exception ex)
    {
      MessageBox.Show(ex.Message, "出現例外！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
  }
}


