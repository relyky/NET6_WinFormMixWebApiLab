using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
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
  }
}