namespace WinFormLab
{
  partial class FormA06
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
      SuspendLayout();
      // 
      // reportViewer1
      // 
      reportViewer1.Dock = DockStyle.Fill;
      reportViewer1.Location = new Point(8, 8);
      reportViewer1.Name = "ReportViewer";
      reportViewer1.ServerReport.BearerToken = null;
      reportViewer1.Size = new Size(729, 403);
      reportViewer1.TabIndex = 0;
      // 
      // FormA06
      // 
      AutoScaleDimensions = new SizeF(9F, 19F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(745, 419);
      Controls.Add(reportViewer1);
      Name = "FormA06";
      Padding = new Padding(8);
      Text = "FormA06";
      Load += FormA06_Load;
      ResumeLayout(false);
    }

    #endregion

    private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
  }
}