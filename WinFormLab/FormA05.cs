using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using WinFormLab.Models;

namespace WinFormLab
{
  public partial class FormA05 : Form
  {
    readonly DeliveryQueue _delivery;

    public FormA05(DeliveryQueue delivery)
    {
      _delivery = delivery;
      InitializeComponent();
    }

    #region Helper

    /// <summary>
    /// 參考：[Web view in Winforms C# using Microsoft.webview2](https://www.youtube.com/watch?v=6zWxLsC9jr8&ab_channel=ITCoreSoft)
    /// </summary>
    async Task InitBrowserAsync()
    {
      await webView.EnsureCoreWebView2Async();
    }

    #endregion

    async void FormA05_Load(object sender, EventArgs e)
    {
      await InitBrowserAsync();

      var bag = _delivery.Dequeue(nameof(FormA05), "NavigateUrl");

      if(bag != null)
      {
        webView.CoreWebView2.Navigate((string)bag.Content);
      }
      else
      {
        webView.CoreWebView2.Navigate("https://www.google.com/");
      }
    }
  }
}
