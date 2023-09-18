namespace WinFormLab
{
  partial class FormA07
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
      panel1 = new Panel();
      btnDeleteValue = new Button();
      numUpDown1 = new NumericUpDown();
      btnGetValue = new Button();
      btnAddValue = new Button();
      btnGetValues = new Button();
      textBox1 = new TextBox();
      btnUpdateValue = new Button();
      panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)numUpDown1).BeginInit();
      SuspendLayout();
      // 
      // panel1
      // 
      panel1.Controls.Add(btnUpdateValue);
      panel1.Controls.Add(btnDeleteValue);
      panel1.Controls.Add(numUpDown1);
      panel1.Controls.Add(btnGetValue);
      panel1.Controls.Add(btnAddValue);
      panel1.Controls.Add(btnGetValues);
      panel1.Dock = DockStyle.Top;
      panel1.Location = new Point(0, 0);
      panel1.Name = "panel1";
      panel1.Size = new Size(800, 125);
      panel1.TabIndex = 0;
      // 
      // btnDeleteValue
      // 
      btnDeleteValue.Location = new Point(482, 70);
      btnDeleteValue.Name = "btnDeleteValue";
      btnDeleteValue.Size = new Size(94, 29);
      btnDeleteValue.TabIndex = 4;
      btnDeleteValue.Text = "Delete";
      btnDeleteValue.UseVisualStyleBackColor = true;
      btnDeleteValue.Click += btnDeleteValue_Click;
      // 
      // numUpDown1
      // 
      numUpDown1.Location = new Point(201, 70);
      numUpDown1.Name = "numUpDown1";
      numUpDown1.Size = new Size(91, 27);
      numUpDown1.TabIndex = 3;
      // 
      // btnGetValue
      // 
      btnGetValue.Location = new Point(325, 70);
      btnGetValue.Name = "btnGetValue";
      btnGetValue.Size = new Size(130, 29);
      btnGetValue.TabIndex = 2;
      btnGetValue.Text = "Get one  value";
      btnGetValue.UseVisualStyleBackColor = true;
      btnGetValue.Click += btnGetValue_Click;
      // 
      // btnAddValue
      // 
      btnAddValue.Location = new Point(482, 35);
      btnAddValue.Name = "btnAddValue";
      btnAddValue.Size = new Size(130, 29);
      btnAddValue.TabIndex = 1;
      btnAddValue.Text = "Add Value";
      btnAddValue.UseVisualStyleBackColor = true;
      btnAddValue.Click += btnAddValue_Click;
      // 
      // btnGetValues
      // 
      btnGetValues.Location = new Point(325, 35);
      btnGetValues.Name = "btnGetValues";
      btnGetValues.Size = new Size(130, 29);
      btnGetValues.TabIndex = 0;
      btnGetValues.Text = "Get Values";
      btnGetValues.UseVisualStyleBackColor = true;
      btnGetValues.Click += btnGetValues_Click;
      // 
      // textBox1
      // 
      textBox1.Dock = DockStyle.Fill;
      textBox1.Location = new Point(0, 125);
      textBox1.Multiline = true;
      textBox1.Name = "textBox1";
      textBox1.Size = new Size(800, 325);
      textBox1.TabIndex = 1;
      // 
      // btnUpdateValue
      // 
      btnUpdateValue.Location = new Point(624, 70);
      btnUpdateValue.Name = "btnUpdateValue";
      btnUpdateValue.Size = new Size(130, 29);
      btnUpdateValue.TabIndex = 5;
      btnUpdateValue.Text = "Update";
      btnUpdateValue.UseVisualStyleBackColor = true;
      btnUpdateValue.Click += btnUpdateValue_Click;
      // 
      // FormA07
      // 
      AutoScaleDimensions = new SizeF(9F, 19F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(800, 450);
      Controls.Add(textBox1);
      Controls.Add(panel1);
      Name = "FormA07";
      Text = "FormA07";
      panel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)numUpDown1).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Panel panel1;
    private Button btnGetValues;
    private TextBox textBox1;
    private Button btnAddValue;
    private NumericUpDown numUpDown1;
    private Button btnGetValue;
    private Button btnDeleteValue;
    private Button btnUpdateValue;
  }
}