using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormLab.Models;
using WinFormLab.ReportDefinitions;

namespace WinFormLab;

/// <remarks>
/// 參考：[ReportViewer Core](https://github.com/lkosson/reportviewercore)
/// </remarks>
public partial class FormA06 : Form
{
  public FormA06()
  {
    InitializeComponent();
  }

  private void FormA06_Load(object sender, EventArgs e)
  {      
    //# 備好報表資料
    ReportDataSet.ReportSampleDataTable data = new ReportDataSet.ReportSampleDataTable();
    data.AddReportSampleRow(1, "Foo", 1001);
    data.AddReportSampleRow(2, "Bar", 3003);
    data.AddReportSampleRow(3, "Baz", 6006);

    //# 填入報表
    reportViewer1.LocalReport.ReportEmbeddedResource = "WinFormLab.ReportDefinitions.HelloWorldReport.rdlc";
    reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("ReportData", (DataTable)data));
    reportViewer1.LocalReport.SetParameters(new[] { new ReportParameter("ReportParameter1", "我來自程式填入的參數值。") });
    reportViewer1.RefreshReport(); // 刷新報表
  }
}
