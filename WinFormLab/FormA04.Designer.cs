namespace WinFormLab
{
  partial class FormA04
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
      button1 = new Button();
      openFileDialog1 = new OpenFileDialog();
      textMessage = new TextBox();
      panel1 = new Panel();
      button2 = new Button();
      panel1.SuspendLayout();
      SuspendLayout();
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Location = new Point(48, 31);
      label1.Name = "label1";
      label1.Size = new Size(134, 19);
      label1.TabIndex = 0;
      label1.Text = "這裡是FormA04。";
      // 
      // button1
      // 
      button1.Location = new Point(583, 31);
      button1.Name = "button1";
      button1.Size = new Size(94, 29);
      button1.TabIndex = 1;
      button1.Text = "上傳檔案";
      button1.UseVisualStyleBackColor = true;
      button1.Click += button1_Click;
      // 
      // openFileDialog1
      // 
      openFileDialog1.FileName = "openFileDialog1";
      openFileDialog1.Multiselect = true;
      // 
      // textMessage
      // 
      textMessage.Dock = DockStyle.Fill;
      textMessage.Location = new Point(0, 122);
      textMessage.Multiline = true;
      textMessage.Name = "textMessage";
      textMessage.ReadOnly = true;
      textMessage.Size = new Size(800, 328);
      textMessage.TabIndex = 2;
      // 
      // panel1
      // 
      panel1.Controls.Add(button2);
      panel1.Controls.Add(button1);
      panel1.Controls.Add(label1);
      panel1.Dock = DockStyle.Top;
      panel1.Location = new Point(0, 0);
      panel1.Name = "panel1";
      panel1.Size = new Size(800, 122);
      panel1.TabIndex = 3;
      // 
      // button2
      // 
      button2.Location = new Point(440, 31);
      button2.Name = "button2";
      button2.Size = new Size(94, 29);
      button2.TabIndex = 2;
      button2.Text = "下載檔案";
      button2.UseVisualStyleBackColor = true;
      button2.Click += button2_Click;
      // 
      // FormA04
      // 
      AutoScaleDimensions = new SizeF(9F, 19F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(800, 450);
      Controls.Add(textMessage);
      Controls.Add(panel1);
      Name = "FormA04";
      Text = "FormA04";
      panel1.ResumeLayout(false);
      panel1.PerformLayout();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label label1;
    private Button button1;
    private OpenFileDialog openFileDialog1;
    private TextBox textMessage;
    private Panel panel1;
    private Button button2;
  }
}