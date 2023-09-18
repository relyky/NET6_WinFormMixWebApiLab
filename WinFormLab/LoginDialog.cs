using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormLab.RefitClient;
using CommonRes.DTO;
using System.Diagnostics;
using System.Reflection.Metadata;

namespace WinFormLab
{
  public partial class LoginDialog : Form
  {
    readonly IConfiguration _cfg;
    readonly IIdentityApi _bizApi;

    //## Property
    public string AuthToken { get; private set; } = string.Empty;

    public LoginDialog(IIdentityApi bizApi, IConfiguration cfg)
    {
      _bizApi = bizApi;
      _cfg = cfg;
      InitializeComponent();
    }

    private void LoginDialog_Load(object sender, EventArgs e)
    {
      txtAccount.Focus();
    }

    private async void btnLogin_Click(object sender, EventArgs e)
    {
      try
      {
        //# UI
        Cursor = Cursors.WaitCursor;
        btnLogin.Enabled = false;

        //# Authenticate and Authorize
        if (!(txtAccount.Text == "foo" && txtMima.Text == "bar"))
        {
          MessageBox.Show("身份認證失敗！請確認帳號、密碼是否正確。", "登入失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
          return;
        }

        //# 
        bool isAdmin = false;
        var request = new TokenGenerationRequest
        {
          UserId = new Guid("12345678-1234-1234-1234-123456789012"),
          Email = "nobody@mail.server",
          CustomClaims = new(new KeyValuePair<string, string>[]
          {
            new("admin", isAdmin ? "true" : "false")
          })
        };

        string token = await _bizApi.GenerateTokenAsync(request);

        AppDomain.CurrentDomain.SetData(@"AUTH_TOKEN", token);

        this.AuthToken = token;
        this.DialogResult = DialogResult.OK;
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "出現例外！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      finally
      {
        //# UI
        this.Cursor = Cursors.Default;
        btnLogin.Enabled = true;
      }

    }

    private void btnExit_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
      txtAccount.Clear();
      txtMima.Clear();
      txtAccount.Focus();
    }

  }
}
