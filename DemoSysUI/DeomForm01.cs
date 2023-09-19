using DemoSysUI.RefitClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoSysUI
{
  public partial class DeomForm01 : Form
  {
    readonly IMyValueApi _bizApi;

    public DeomForm01(IMyValueApi bizApi)
    {
      _bizApi = bizApi;
      InitializeComponent();
    }

    private void DeomForm01_Load(object sender, EventArgs e)
    {

    }

    private async void button1_Click(object sender, EventArgs e)
    {
      try
      {
        var result = await _bizApi.QryValuesAsync();
        var json = JsonSerializer.Serialize(result);
        textBox1.AppendText($"{json}{Environment.NewLine}");
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "出現例外！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        Debugger.Break();
      }

    }
  }
}
