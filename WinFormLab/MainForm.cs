using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using WinFormLab.Models;

namespace WinFormLab
{
  public partial class MainForm : Form
  {
    readonly ILogger<MainForm> _logger;
    readonly IServiceProvider _provider;
    readonly DeliveryQueue _delivery;

    public MainForm(IServiceProvider provider, ILogger<MainForm> logger, DeliveryQueue delivery)
    {
      _logger = logger;
      _provider = provider;
      _delivery = delivery;
      InitializeComponent();
    }

    #region Helper
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
    #endregion

    private void MainForm_Load(object sender, EventArgs e)
    {
      // login

      using var dlg = _provider.GetRequiredService<LoginDialog>(); ;
      //using var dlg = new LoginDialog();

      if (dlg.ShowDialog(this) == DialogResult.OK)
      {
        // 登入後顯示
        this.Show();
        this.Focus();
        return;
      }

      // 預設離開系統
      Application.Exit();
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

    private void menuFormA05_Click(object sender, EventArgs e)
    {
      // 在開啟畫面前先把參數送過去
      _delivery.Enqueue(new DeliveryBag
      {
        Sender = nameof(MainForm),
        Receiver = nameof(FormA05),
        Subject = "NavigateUrl",
        Content = "http://www.asiavista.com.tw/asvtwko"
      });

      OpenForm(typeof(FormA05));
    }

    private void menuLogout_Click(object sender, EventArgs e)
    {
      // 清除登入註記
      AppDomain.CurrentDomain.SetData(@"AUTH_TOKEN", null);

      // 離開系統
      Application.Exit();
    }

    private void menuToggleFuncs_Click(object sender, EventArgs e)
    {
      tvMenu.Visible = !tvMenu.Visible;
    }

    private void tvMenu_AfterSelect(object sender, TreeViewEventArgs e)
    {
      var node = tvMenu.SelectedNode;

      Type? formType = node.Name switch
      {
        "nodeFormA01" => typeof(FormA01),
        "nodeFormA02" => typeof(FormA02),
        "nodeFormA03" => typeof(FormA03),
        "nodeFormA04" => typeof(FormA04),
        "nodeFormA05" => typeof(FormA05),
        _ => null
      }; ;

      if (formType != null)
        OpenForm(formType);
    }
  }
}