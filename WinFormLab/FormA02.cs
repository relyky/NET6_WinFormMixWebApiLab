using Newtonsoft.Json;
using SwagClient;
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

namespace WinFormLab
{
  public partial class FormA02 : Form
  {
    IWeatherForecastApi bizApi;

    public FormA02(IWeatherForecastApi _bizApi)
    {
      bizApi = _bizApi;
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
      var result = bizApi.WeatherForecastAsync().Result;;
      var json = JsonConvert.SerializeObject(result);

      textBox1.AppendText($"{json}{Environment.NewLine}");
    }
  }
}
