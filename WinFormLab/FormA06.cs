using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormLab
{
  public partial class FormA06 : Form
  {
    public FormA06()
    {
      InitializeComponent();
    }

    private void FormA06_Load(object sender, EventArgs e)
    {      
      reportViewer1.LocalReport.ReportEmbeddedResource = "WinFormLab.ReportDefinitions.HelloWorldReport.rdlc";
      reportViewer1.RefreshReport();
    }
  }
}
