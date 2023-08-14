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
  IHostEnvironment _env;
  IConfiguration _cfg;
  IFileHandleApi _bizApi;

  //## State
  string errMsg = string.Empty;
  bool f_loading = false;

  public FormA04(IFileHandleApi bizApi, IHostEnvironment env, IConfiguration cfg)
  {
    _bizApi = bizApi;
    _env = env;
    _cfg = cfg;
    InitializeComponent();
  }

  #region Helper 
  List<UploadResult>? UploadFiles(IEnumerable<string> filePathList)
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

      var uploadResults = Task.Run(async () => await _bizApi.UploadFileAsync(content)).GetAwaiter().GetResult();
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

  (byte[] fileBlob, string filename) DownloadFile(Guid id)
  {
    try
    {
      //HttpContent content = _bizApi.DowloadFileAsync(id).Result;
      HttpContent content = Task.Run(async () => await _bizApi.DowloadFileAsync(id)).GetAwaiter().GetResult();
      byte[] fileBlob = content.ReadAsByteArrayAsync().Result;

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

  void button1_Click(object sender, EventArgs e)
  {
    try
    {
      if (DialogResult.OK == openFileDialog1.ShowDialog())
      {
        var uploadResults = UploadFiles(openFileDialog1.FileNames);
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
      Debugger.Break();
    }
  }

  void button2_Click(object sender, EventArgs e)
  {
    try
    {
      bool f_testFail = false;
      Guid id = f_testFail ? Guid.Empty : Guid.NewGuid();

      (byte[] fileBlob, string filename) = DownloadFile(id);

      string downFolder = @"C:\Temp";
      string downFilePath = Path.Combine(downFolder, filename);
      File.WriteAllBytes(downFilePath, fileBlob);

      MessageBox.Show($"下載檔案位置：{downFilePath}", "出現例外！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    catch (Exception ex)
    {
      MessageBox.Show(ex.Message, "出現例外！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      Debugger.Break();
    }
  }
}


