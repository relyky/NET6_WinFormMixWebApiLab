namespace WinFormLab
{
  partial class FormA01
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
      label1 = new Label();
      menuStrip1 = new MenuStrip();
      功能作業群ＡToolStripMenuItem = new ToolStripMenuItem();
      第一個功能ToolStripMenuItem = new ToolStripMenuItem();
      第二個指令ToolStripMenuItem = new ToolStripMenuItem();
      功能作業群ＢToolStripMenuItem = new ToolStripMenuItem();
      menuStrip1.SuspendLayout();
      SuspendLayout();
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Location = new Point(96, 133);
      label1.Name = "label1";
      label1.Size = new Size(123, 19);
      label1.TabIndex = 0;
      label1.Text = "這裡是 FormA01";
      // 
      // menuStrip1
      // 
      menuStrip1.ImageScalingSize = new Size(20, 20);
      menuStrip1.Items.AddRange(new ToolStripItem[] { 功能作業群ＡToolStripMenuItem, 功能作業群ＢToolStripMenuItem });
      menuStrip1.Location = new Point(0, 0);
      menuStrip1.Name = "menuStrip1";
      menuStrip1.Size = new Size(965, 27);
      menuStrip1.TabIndex = 1;
      menuStrip1.Text = "menuStrip1";
      // 
      // 功能作業群ＡToolStripMenuItem
      // 
      功能作業群ＡToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 第一個功能ToolStripMenuItem, 第二個指令ToolStripMenuItem });
      功能作業群ＡToolStripMenuItem.Name = "功能作業群ＡToolStripMenuItem";
      功能作業群ＡToolStripMenuItem.Size = new Size(113, 23);
      功能作業群ＡToolStripMenuItem.Text = "功能作業群Ａ";
      // 
      // 第一個功能ToolStripMenuItem
      // 
      第一個功能ToolStripMenuItem.Name = "第一個功能ToolStripMenuItem";
      第一個功能ToolStripMenuItem.Size = new Size(224, 26);
      第一個功能ToolStripMenuItem.Text = "第一個功能";
      // 
      // 第二個指令ToolStripMenuItem
      // 
      第二個指令ToolStripMenuItem.Name = "第二個指令ToolStripMenuItem";
      第二個指令ToolStripMenuItem.Size = new Size(224, 26);
      第二個指令ToolStripMenuItem.Text = "第二個指令";
      // 
      // 功能作業群ＢToolStripMenuItem
      // 
      功能作業群ＢToolStripMenuItem.Name = "功能作業群ＢToolStripMenuItem";
      功能作業群ＢToolStripMenuItem.Size = new Size(113, 23);
      功能作業群ＢToolStripMenuItem.Text = "功能作業群Ｂ";
      // 
      // FormA01
      // 
      AutoScaleDimensions = new SizeF(9F, 19F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(965, 572);
      Controls.Add(label1);
      Controls.Add(menuStrip1);
      MainMenuStrip = menuStrip1;
      Name = "FormA01";
      Text = "FormA01";
      menuStrip1.ResumeLayout(false);
      menuStrip1.PerformLayout();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label label1;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem 功能作業群ＡToolStripMenuItem;
    private ToolStripMenuItem 功能作業群ＢToolStripMenuItem;
    private ToolStripMenuItem 第一個功能ToolStripMenuItem;
    private ToolStripMenuItem 第二個指令ToolStripMenuItem;
  }
}