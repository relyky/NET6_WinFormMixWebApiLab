using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
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
    #endregion

    /// <remarks>
    /// 參考：[Web view in Winforms C# using Microsoft.webview2](https://www.youtube.com/watch?v=6zWxLsC9jr8&ab_channel=ITCoreSoft)
    /// 參考：[Different Ways to Host Web Pages in Windows Forms](https://jason-ge.medium.com/different-ways-to-host-web-pages-in-windows-forms-e8cad8efd117)
    /// 此處 async function 不用加 Task 是特別的狀況，這特別狀況之一是 UI event hanlder 的關系。
    /// 一般 async function 要搭配 Task 才能正常運作。 
    /// </remarks>
    async void FormA05_Load(object sender, EventArgs e)
    {
      await webView.EnsureCoreWebView2Async();

      var bag = _delivery.Dequeue(nameof(FormA05), "NavigateUrl");
      if(bag != null)
      {
        webView.CoreWebView2.Navigate((string)bag.Content);
      }
      else
      {
        string htmlContent = @"<h1 style='color:red;'>未指定瀏覽的網址。</h1>";
        webView.CoreWebView2.NavigateToString(htmlContent);
      }
    }
  }
}
