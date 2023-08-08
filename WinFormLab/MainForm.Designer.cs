namespace WinFormLab
{
  partial class MainForm
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      menuStrip1 = new MenuStrip();
      menuGroupA = new ToolStripMenuItem();
      menuFormA01 = new ToolStripMenuItem();
      menuFormA02 = new ToolStripMenuItem();
      menuFormA03 = new ToolStripMenuItem();
      menuStrip1.SuspendLayout();
      SuspendLayout();
      // 
      // menuStrip1
      // 
      menuStrip1.ImageScalingSize = new Size(20, 20);
      menuStrip1.Items.AddRange(new ToolStripItem[] { menuGroupA });
      menuStrip1.Location = new Point(0, 0);
      menuStrip1.Name = "menuStrip1";
      menuStrip1.Padding = new Padding(8, 3, 0, 3);
      menuStrip1.Size = new Size(1021, 30);
      menuStrip1.TabIndex = 2;
      menuStrip1.Text = "menuStrip1";
      // 
      // menuGroupA
      // 
      menuGroupA.DropDownItems.AddRange(new ToolStripItem[] { menuFormA01, menuFormA02, menuFormA03 });
      menuGroupA.Name = "menuGroupA";
      menuGroupA.Size = new Size(98, 24);
      menuGroupA.Text = "開啟新視窗";
      // 
      // menuFormA01
      // 
      menuFormA01.Name = "menuFormA01";
      menuFormA01.Size = new Size(224, 26);
      menuFormA01.Text = "FormA01";
      menuFormA01.Click += menuFormA01_Click;
      // 
      // menuFormA02
      // 
      menuFormA02.Name = "menuFormA02";
      menuFormA02.Size = new Size(224, 26);
      menuFormA02.Text = "FormA02";
      menuFormA02.Click += menuFormA02_Click;
      // 
      // menuFormA03
      // 
      menuFormA03.Name = "menuFormA03";
      menuFormA03.Size = new Size(224, 26);
      menuFormA03.Text = "FormA03";
      menuFormA03.Click += menuFormA03_Click;
      // 
      // MainForm
      // 
      AutoScaleDimensions = new SizeF(9F, 19F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(1021, 618);
      Controls.Add(menuStrip1);
      IsMdiContainer = true;
      MainMenuStrip = menuStrip1;
      Name = "MainForm";
      Text = "MainForm";
      menuStrip1.ResumeLayout(false);
      menuStrip1.PerformLayout();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private MenuStrip menuStrip1;
    private ToolStripMenuItem menuGroupA;
    private ToolStripMenuItem menuFormA01;
    private ToolStripMenuItem menuFormA02;
    private ToolStripMenuItem menuFormA03;
  }
}