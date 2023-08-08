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
      menuStrip1.SuspendLayout();
      SuspendLayout();
      // 
      // menuStrip1
      // 
      menuStrip1.Items.AddRange(new ToolStripItem[] { menuGroupA });
      menuStrip1.Location = new Point(0, 0);
      menuStrip1.Name = "menuStrip1";
      menuStrip1.Size = new Size(794, 24);
      menuStrip1.TabIndex = 2;
      menuStrip1.Text = "menuStrip1";
      // 
      // menuGroupA
      // 
      menuGroupA.DropDownItems.AddRange(new ToolStripItem[] { menuFormA01, menuFormA02 });
      menuGroupA.Name = "menuGroupA";
      menuGroupA.Size = new Size(79, 20);
      menuGroupA.Text = "開啟新視窗";
      // 
      // menuFormA01
      // 
      menuFormA01.Name = "menuFormA01";
      menuFormA01.Size = new Size(180, 22);
      menuFormA01.Text = "FormA01";
      menuFormA01.Click += menuFormA01_Click;
      // 
      // menuFormA02
      // 
      menuFormA02.Name = "menuFormA02";
      menuFormA02.Size = new Size(180, 22);
      menuFormA02.Text = "FormA02";
      menuFormA02.Click += menuFormA02_Click;
      // 
      // MainForm
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(794, 488);
      Controls.Add(menuStrip1);
      IsMdiContainer = true;
      MainMenuStrip = menuStrip1;
      Margin = new Padding(2);
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
  }
}