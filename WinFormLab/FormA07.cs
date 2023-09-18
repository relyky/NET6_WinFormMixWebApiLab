using CommonRes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormLab.RefitClient;

namespace WinFormLab
{
  public partial class FormA07 : Form
  {
    readonly IValuesApi _bizApi;

    public FormA07(IValuesApi bizApi)
    {
      _bizApi = bizApi;
      InitializeComponent();
    }

    private async void btnGetValues_Click(object sender, EventArgs e)
    {
      try
      {
        var result = await _bizApi.QryValuesAsync();
        var json = JsonConvert.SerializeObject(result);
        textBox1.AppendText($"{json}{Environment.NewLine}");
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "出現例外！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        Debugger.Break();
      }
    }

    private async void btnAddValue_Click(object sender, EventArgs e)
    {
      try
      {
        MyValue newValue = new()
        {
          Id = -1,
          Value = $"a value {DateTime.Now:HHmmss}"
        };
        newValue = await _bizApi.AddValueAsync(newValue);
        var json = JsonConvert.SerializeObject(newValue);
        textBox1.AppendText($"加入新值：{json}{Environment.NewLine}");
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "出現例外！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        Debugger.Break();
      }
    }

    private async void btnGetValue_Click(object sender, EventArgs e)
    {
      try
      {
        int Id = (int)numUpDown1.Value;
        var result = await _bizApi.GetValueAsync(Id);

        var json = JsonConvert.SerializeObject(result);
        textBox1.AppendText($"{json}{Environment.NewLine}");
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "出現例外！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        Debugger.Break();
      }
    }

    private async void btnDeleteValue_Click(object sender, EventArgs e)
    {
      try
      {
        int Id = (int)numUpDown1.Value;
        int ret = await _bizApi.DelValueAsync(Id);

        textBox1.AppendText($"刪除 {Id}→{ret}{Environment.NewLine}");
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "出現例外！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        Debugger.Break();
      }
    }

    private async void btnUpdateValue_Click(object sender, EventArgs e)
    {
      try
      {
        int Id = (int)numUpDown1.Value;
        MyValue newFormData = new()
        {
          Id = Id,
          Value = $"a value {DateTime.Now:HHmmss}"
        };

        var result = await _bizApi.UpdValueAsync(newFormData);
        var json = JsonConvert.SerializeObject(result);
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
