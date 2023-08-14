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
    IConfiguration _cfg;
    IIdentityApi _bizApi;

    //## Property
    public string AuthToken { get; private set; } = string.Empty;

    public LoginDialog(IIdentityApi bizApi, IConfiguration cfg)
    {
      _bizApi = bizApi;
      _cfg = cfg;
      InitializeComponent();
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
      try
      {
        //# UI
        Cursor = Cursors.WaitCursor;
        btnLogin.Enabled = false;

        //# GO
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

        string token = Task.Run(async () => await _bizApi.GenerateTokenAsync(request)).GetAwaiter().GetResult();        
        AppDomain.CurrentDomain.SetData(@"AUTH_TOKEN", token);

        this.AuthToken = token;
        this.DialogResult = DialogResult.OK;
      }
      catch (Exception ex)       
      {
        MessageBox.Show(ex.Message, "出現例外！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        Debugger.Break();
      }
      finally
      {
        //# UI
        this.Cursor = Cursors.Default;
        btnLogin.Enabled = true;
      }

    }
  }
}
