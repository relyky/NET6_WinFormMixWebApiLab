namespace WinFormLab
{
  partial class LoginDialog
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
      btnLogin = new Button();
      pictureBox1 = new PictureBox();
      label1 = new Label();
      pictureBox2 = new PictureBox();
      pictureBox3 = new PictureBox();
      txtAccount = new TextBox();
      txtMima = new TextBox();
      btnExit = new Button();
      btnClear = new Button();
      ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
      ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
      ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
      SuspendLayout();
      // 
      // btnLogin
      // 
      btnLogin.BackColor = Color.FromArgb(0, 117, 214);
      btnLogin.Font = new Font("微軟正黑體", 10F, FontStyle.Regular, GraphicsUnit.Point);
      btnLogin.ForeColor = Color.White;
      btnLogin.Location = new Point(28, 344);
      btnLogin.Name = "btnLogin";
      btnLogin.Size = new Size(240, 39);
      btnLogin.TabIndex = 3;
      btnLogin.Text = "登入";
      btnLogin.UseVisualStyleBackColor = false;
      btnLogin.Click += btnLogin_Click;
      // 
      // pictureBox1
      // 
      pictureBox1.Image = Properties.Resources.saicon2;
      pictureBox1.Location = new Point(101, 54);
      pictureBox1.Name = "pictureBox1";
      pictureBox1.Size = new Size(87, 71);
      pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
      pictureBox1.TabIndex = 1;
      pictureBox1.TabStop = false;
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Font = new Font("Bahnschrift", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
      label1.ForeColor = Color.FromArgb(0, 117, 214);
      label1.Location = new Point(77, 128);
      label1.Name = "label1";
      label1.Size = new Size(133, 45);
      label1.TabIndex = 2;
      label1.Text = "LOG IN";
      // 
      // pictureBox2
      // 
      pictureBox2.Image = Properties.Resources.user;
      pictureBox2.Location = new Point(28, 212);
      pictureBox2.Name = "pictureBox2";
      pictureBox2.Size = new Size(25, 25);
      pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
      pictureBox2.TabIndex = 3;
      pictureBox2.TabStop = false;
      // 
      // pictureBox3
      // 
      pictureBox3.Image = Properties.Resources._lock;
      pictureBox3.Location = new Point(28, 269);
      pictureBox3.Name = "pictureBox3";
      pictureBox3.Size = new Size(25, 25);
      pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
      pictureBox3.TabIndex = 4;
      pictureBox3.TabStop = false;
      // 
      // txtAccount
      // 
      txtAccount.Font = new Font("微軟正黑體", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
      txtAccount.ForeColor = Color.FromArgb(0, 117, 214);
      txtAccount.Location = new Point(63, 207);
      txtAccount.Name = "txtAccount";
      txtAccount.PlaceholderText = "帳號";
      txtAccount.Size = new Size(205, 30);
      txtAccount.TabIndex = 1;
      // 
      // txtMima
      // 
      txtMima.Font = new Font("微軟正黑體", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
      txtMima.ForeColor = Color.FromArgb(0, 117, 214);
      txtMima.Location = new Point(63, 267);
      txtMima.Name = "txtMima";
      txtMima.PasswordChar = '*';
      txtMima.PlaceholderText = "密碼";
      txtMima.Size = new Size(205, 30);
      txtMima.TabIndex = 2;
      // 
      // btnExit
      // 
      btnExit.BackColor = SystemColors.Control;
      btnExit.FlatAppearance.BorderSize = 0;
      btnExit.FlatStyle = FlatStyle.Flat;
      btnExit.Font = new Font("微軟正黑體", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
      btnExit.ForeColor = Color.FromArgb(0, 117, 214);
      btnExit.Location = new Point(101, 389);
      btnExit.Name = "btnExit";
      btnExit.Size = new Size(94, 29);
      btnExit.TabIndex = 5;
      btnExit.Text = "離開";
      btnExit.UseVisualStyleBackColor = false;
      btnExit.Click += btnExit_Click;
      // 
      // btnClear
      // 
      btnClear.BackColor = SystemColors.Control;
      btnClear.FlatAppearance.BorderSize = 0;
      btnClear.FlatStyle = FlatStyle.Flat;
      btnClear.Font = new Font("微軟正黑體", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
      btnClear.ForeColor = Color.FromArgb(0, 117, 214);
      btnClear.Location = new Point(207, 309);
      btnClear.Name = "btnClear";
      btnClear.Size = new Size(61, 29);
      btnClear.TabIndex = 4;
      btnClear.Text = "清除";
      btnClear.UseVisualStyleBackColor = false;
      btnClear.Click += btnClear_Click;
      // 
      // LoginDialog
      // 
      AcceptButton = btnLogin;
      AutoScaleDimensions = new SizeF(9F, 19F);
      AutoScaleMode = AutoScaleMode.Font;
      CancelButton = btnExit;
      ClientSize = new Size(290, 439);
      Controls.Add(btnClear);
      Controls.Add(btnExit);
      Controls.Add(txtMima);
      Controls.Add(txtAccount);
      Controls.Add(pictureBox3);
      Controls.Add(pictureBox2);
      Controls.Add(label1);
      Controls.Add(pictureBox1);
      Controls.Add(btnLogin);
      FormBorderStyle = FormBorderStyle.FixedDialog;
      MaximizeBox = false;
      MinimizeBox = false;
      Name = "LoginDialog";
      ShowInTaskbar = false;
      StartPosition = FormStartPosition.CenterScreen;
      Text = "登入ＸＸＸ系統";
      TopMost = true;
      Load += LoginDialog_Load;
      ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
      ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
      ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Button btnLogin;
    private PictureBox pictureBox1;
    private Label label1;
    private PictureBox pictureBox2;
    private PictureBox pictureBox3;
    private TextBox txtAccount;
    private TextBox txtMima;
    private Button btnExit;
    private Button btnClear;
  }
}