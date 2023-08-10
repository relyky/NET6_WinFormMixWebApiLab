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
      toolStripMenuItemA02 = new ToolStripMenuItem();
      menuA02Go = new ToolStripMenuItem();
      panel1 = new Panel();
      btnRefit = new Button();
      btnSwagger = new Button();
      label1 = new Label();
      button1 = new Button();
      textBox1 = new TextBox();
      btnShowEnv = new Button();
      menuStrip1.SuspendLayout();
      panel1.SuspendLayout();
      SuspendLayout();
      // 
      // menuStrip1
      // 
      menuStrip1.ImageScalingSize = new Size(20, 20);
      menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItemA02 });
      menuStrip1.Location = new Point(0, 0);
      menuStrip1.Name = "menuStrip1";
      menuStrip1.Size = new Size(1029, 27);
      menuStrip1.TabIndex = 1;
      menuStrip1.Text = "menuStrip1";
      // 
      // toolStripMenuItemA02
      // 
      toolStripMenuItemA02.DropDownItems.AddRange(new ToolStripItem[] { menuA02Go });
      toolStripMenuItemA02.Name = "toolStripMenuItemA02";
      toolStripMenuItemA02.Size = new Size(113, 23);
      toolStripMenuItemA02.Text = "功能２的選單";
      // 
      // menuA02Go
      // 
      menuA02Go.Name = "menuA02Go";
      menuA02Go.Size = new Size(180, 26);
      menuA02Go.Text = "menuA02Go";
      menuA02Go.Click += menuA02Go_Click;
      // 
      // panel1
      // 
      panel1.Controls.Add(btnShowEnv);
      panel1.Controls.Add(btnRefit);
      panel1.Controls.Add(btnSwagger);
      panel1.Controls.Add(label1);
      panel1.Controls.Add(button1);
      panel1.Dock = DockStyle.Top;
      panel1.Location = new Point(0, 27);
      panel1.Name = "panel1";
      panel1.Size = new Size(1029, 98);
      panel1.TabIndex = 2;
      // 
      // btnRefit
      // 
      btnRefit.Location = new Point(550, 20);
      btnRefit.Name = "btnRefit";
      btnRefit.Size = new Size(161, 29);
      btnRefit.TabIndex = 3;
      btnRefit.Text = "Call Refit";
      btnRefit.UseVisualStyleBackColor = true;
      btnRefit.Click += btnRefit_Click;
      // 
      // btnSwagger
      // 
      btnSwagger.Location = new Point(717, 20);
      btnSwagger.Name = "btnSwagger";
      btnSwagger.Size = new Size(161, 29);
      btnSwagger.TabIndex = 2;
      btnSwagger.Text = "Call Swagger";
      btnSwagger.UseVisualStyleBackColor = true;
      btnSwagger.Click += btnSwagger_Click;
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
      // btnShowEnv
      // 
      btnShowEnv.Location = new Point(383, 19);
      btnShowEnv.Name = "btnShowEnv";
      btnShowEnv.Size = new Size(161, 29);
      btnShowEnv.TabIndex = 4;
      btnShowEnv.Text = "Show Env.";
      btnShowEnv.UseVisualStyleBackColor = true;
      btnShowEnv.Click += btnShowEnv_Click;
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
    private ToolStripMenuItem toolStripMenuItemA02;
    private Panel panel1;
    private Button button1;
    private TextBox textBox1;
    private Label label1;
    private ToolStripMenuItem menuA02Go;
    private Button btnSwagger;
    private Button btnRefit;
    private Button btnShowEnv;
  }
}