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

    void MakeTreeMenu()
    {
      var menuInfo = new[] {
        new { Caption = "FormA01", TypeName = "WinFormLab.FormA01" },
        new { Caption = "FormA02", TypeName = "WinFormLab.FormA02" },
        new { Caption = "FormA03", TypeName = "WinFormLab.FormA03" },
        new { Caption = "FormA04", TypeName = "WinFormLab.FormA04" },
        new { Caption = "FormA05", TypeName = "WinFormLab.FormA05" },
        new { Caption = "FormA06", TypeName = "WinFormLab.FormA06" },
      };

      foreach (var item in menuInfo)
      {
        var menuNode = new TreeNode(item.Caption);
        menuNode.Tag = item.TypeName;
        tvMenu.Nodes.Add(menuNode);
      }
    }

    void MakeTreeMenu2()
    {
      var menuGrp = new[] {
        new {
          Caption = "群組功能A",
          MenuList = new[] {
            new { Caption = "FormA01", TypeName = "WinFormLab.FormA01" },
            new { Caption = "FormA02", TypeName = "WinFormLab.FormA02" },
            new { Caption = "FormA03", TypeName = "WinFormLab.FormA03" },
          }
        },
        new {
          Caption = "群組功能B",
          MenuList = new[] {
            new { Caption = "FormA04", TypeName = "WinFormLab.FormA04" },
            new { Caption = "FormA05", TypeName = "WinFormLab.FormA05" },
            new { Caption = "FormA06", TypeName = "WinFormLab.FormA06" },
          }
        },
      };

      foreach (var grp in menuGrp)
      {
        var grpNode = new TreeNode(grp.Caption);
        foreach (var item in grp.MenuList)
        {
          var menuNode = new TreeNode(item.Caption);
          menuNode.Tag = item.TypeName;
          grpNode.Nodes.Add(menuNode);
        }

        tvMenu.Nodes.Add(grpNode);
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
        //dlg.AuthUser 

        // 依授權生成選單
        MakeTreeMenu2(/* AuthUser */);

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
      string? formTypeName = tvMenu.SelectedNode.Tag as string;
      if (formTypeName == null) return;

      Type? formType = Type.GetType(formTypeName);

      if (formType != null)
        OpenForm(formType);
    }

    /// <summary>
    /// highlight 選取項目
    /// 參考：https://stackoverflow.com/questions/21198668/treenode-selected-backcolor-while-treeview-not-focused
    /// </summary>
    private void tvMenu_Enter(object sender, EventArgs e)
    {
      if (tvMenu.SelectedNode != null)
      {
        tvMenu.SelectedNode.BackColor = Color.Empty;
        tvMenu.SelectedNode.ForeColor = Color.Empty;
      }
    }

    /// <summary>
    /// highlight 選取項目
    /// 參考：https://stackoverflow.com/questions/21198668/treenode-selected-backcolor-while-treeview-not-focused
    /// </summary>
    private void tvMenu_Leave(object sender, EventArgs e)
    {
      if (tvMenu.SelectedNode != null)
      {
        tvMenu.SelectedNode.BackColor = SystemColors.Highlight;
        tvMenu.SelectedNode.ForeColor = Color.White;
      }
    }
  }
}