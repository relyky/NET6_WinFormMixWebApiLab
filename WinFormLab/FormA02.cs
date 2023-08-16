using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using SwagClient;
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
  public partial class FormA02 : Form
  {
    readonly IWeatherForecastApi _bizApi;
    readonly IHostEnvironment _env;
    readonly IConfiguration _cfg;

    public FormA02(IWeatherForecastApi bizApi, IHostEnvironment env, IConfiguration cfg)
    {
      _bizApi = bizApi;
      _env = env;
      _cfg = cfg;
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      textBox1.AppendText($"今天天氣真好@{DateTime.Now:HH:mm:ss}{Environment.NewLine}");
    }

    private void menuA02Go_Click(object sender, EventArgs e)
    {
      textBox1.AppendText($"Show me the money@{DateTime.Now:HH:mm:ss}{Environment.NewLine}");
    }

    private void btnSwagger_Click(object sender, EventArgs e)
    {
      using var http = new HttpClient();
      var api = new Client(@"https://localhost:7232", http);
      var result = api.WeatherForecast();

      var json = JsonConvert.SerializeObject(result);
      textBox1.AppendText($"{json}{Environment.NewLine}");
    }

    private void btnRefit_Click(object sender, EventArgs e)
    {
      try
      {
        var result = RefitHelper.RunSync(()=> _bizApi.WeatherForecastAsync());

        var json = JsonConvert.SerializeObject(result);
        textBox1.AppendText($"{json}{Environment.NewLine}");
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "出現例外！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        Debugger.Break();
      }
    }

    private void btnShowEnv_Click(object sender, EventArgs e)
    {
      bool IsDevelopment = _env.IsDevelopment();
      bool IsProduction = _env.IsProduction();

      textBox1.AppendText($"IsDevelopment:{IsDevelopment}, IsProduction:{IsProduction}{Environment.NewLine}");

      string myEnvVar = _cfg.GetValue<string>("MyEnvVar") ?? "nil";

      textBox1.AppendText($"MyEnvVar: {myEnvVar}{Environment.NewLine}");
    }
  }
}
