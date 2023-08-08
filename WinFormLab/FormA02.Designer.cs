namespace WinFormLab
{
  partial class FormA02
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
      menuStrip1 = new MenuStrip();
      功能２的選單ToolStripMenuItem = new ToolStripMenuItem();
      panel1 = new Panel();
      button1 = new Button();
      textBox1 = new TextBox();
      label1 = new Label();
      menuStrip1.SuspendLayout();
      panel1.SuspendLayout();
      SuspendLayout();
      // 
      // menuStrip1
      // 
      menuStrip1.ImageScalingSize = new Size(20, 20);
      menuStrip1.Items.AddRange(new ToolStripItem[] { 功能２的選單ToolStripMenuItem });
      menuStrip1.Location = new Point(0, 0);
      menuStrip1.Name = "menuStrip1";
      menuStrip1.Size = new Size(1029, 27);
      menuStrip1.TabIndex = 1;
      menuStrip1.Text = "menuStrip1";
      // 
      // 功能２的選單ToolStripMenuItem
      // 
      功能２的選單ToolStripMenuItem.Name = "功能２的選單ToolStripMenuItem";
      功能２的選單ToolStripMenuItem.Size = new Size(113, 23);
      功能２的選單ToolStripMenuItem.Text = "功能２的選單";
      // 
      // panel1
      // 
      panel1.Controls.Add(label1);
      panel1.Controls.Add(button1);
      panel1.Dock = DockStyle.Top;
      panel1.Location = new Point(0, 27);
      panel1.Name = "panel1";
      panel1.Size = new Size(1029, 98);
      panel1.TabIndex = 2;
      // 
      // button1
      // 
      button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      button1.Location = new Point(884, 19);
      button1.Name = "button1";
      button1.Size = new Size(133, 29);
      button1.TabIndex = 0;
      button1.Text = "今天天氣真好";
      button1.UseVisualStyleBackColor = true;
      button1.Click += button1_Click;
      // 
      // textBox1
      // 
      textBox1.Dock = DockStyle.Fill;
      textBox1.Location = new Point(0, 125);
      textBox1.Multiline = true;
      textBox1.Name = "textBox1";
      textBox1.Size = new Size(1029, 445);
      textBox1.TabIndex = 3;
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Location = new Point(55, 39);
      label1.Name = "label1";
      label1.Size = new Size(129, 19);
      label1.TabIndex = 1;
      label1.Text = "處理批次計算問題";
      // 
      // FormA02
      // 
      AutoScaleDimensions = new SizeF(9F, 19F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(1029, 570);
      Controls.Add(textBox1);
      Controls.Add(panel1);
      Controls.Add(menuStrip1);
      MainMenuStrip = menuStrip1;
      Margin = new Padding(4);
      Name = "FormA02";
      Text = "FormA02";
      menuStrip1.ResumeLayout(false);
      menuStrip1.PerformLayout();
      panel1.ResumeLayout(false);
      panel1.PerformLayout();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion
    private MenuStrip menuStrip1;
    private ToolStripMenuItem 功能２的選單ToolStripMenuItem;
    private Panel panel1;
    private Button button1;
    private TextBox textBox1;
    private Label label1;
  }
}