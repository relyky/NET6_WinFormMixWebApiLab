using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using System.Diagnostics;

namespace WinFormLab
{
  public partial class MainForm : Form
  {
    ILogger<MainForm> _logger;
    IServiceProvider _provider;

    public MainForm(IServiceProvider provider, ILogger<MainForm> logger)
    {
      _logger = logger;
      _provider = provider;
      InitializeComponent();
    }

    void OpenForm(Type formType)
    {
      try
      {
        Form? child = this.MdiChildren.FirstOrDefault(c => c.GetType() == formType);
        if (child == null)
        {
          child = (Form)_provider.GetRequiredService(formType);
          child.MdiParent = this;

          //var ctr = formType.GetConstructor(Type.EmptyTypes);
          //child = (Form)ctr!.Invoke(null);
          //child.MdiParent = this;

          _logger.LogInformation($"建立新視窗：{formType.FullName}");
        }

        child.Show();
        child.Focus();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "出現例外！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        Debugger.Break();
      }
    }

    private void menuFormA01_Click(object sender, EventArgs e)
    {
      OpenForm(typeof(FormA01));
    }

    private void menuFormA02_Click(object sender, EventArgs e)
    {
      OpenForm(typeof(FormA02));
    }

    private void menuFormA03_Click(object sender, EventArgs e)
    {
      OpenForm(typeof(FormA03));
    }

    private void menuFormA04_Click(object sender, EventArgs e)
    {
      OpenForm(typeof(FormA04));
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
      // login
      MessageBox.Show("進行登入程序...未實作");
      // call dialog...
    }

    private void menuLogin_Click(object sender, EventArgs e)
    {
      using var dlg = _provider.GetRequiredService<LoginDialog>(); ;
      //using var dlg = new LoginDialog();

      if (dlg.ShowDialog(this) == DialogResult.OK)
      {
        MessageBox.Show("登入成功 => " + dlg.AuthToken);
      }
      else
      {
        MessageBox.Show("登入失敗。");
      }
    }

    private void menuLogout_Click(object sender, EventArgs e)
    {
      // 清除登入註記
      AppDomain.CurrentDomain.SetData(@"AUTH_TOKEN", null);
    }
  }
}