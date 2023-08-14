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
      SuspendLayout();
      // 
      // btnLogin
      // 
      btnLogin.Location = new Point(117, 287);
      btnLogin.Name = "btnLogin";
      btnLogin.Size = new Size(94, 29);
      btnLogin.TabIndex = 0;
      btnLogin.Text = "登入";
      btnLogin.UseVisualStyleBackColor = true;
      btnLogin.Click += btnLogin_Click;
      // 
      // LoginDialog
      // 
      AcceptButton = btnLogin;
      AutoScaleDimensions = new SizeF(9F, 19F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(339, 425);
      Controls.Add(btnLogin);
      FormBorderStyle = FormBorderStyle.FixedDialog;
      MaximizeBox = false;
      MinimizeBox = false;
      Name = "LoginDialog";
      ShowInTaskbar = false;
      StartPosition = FormStartPosition.CenterScreen;
      Text = "登入";
      ResumeLayout(false);
    }

    #endregion

    private Button btnLogin;
  }
}