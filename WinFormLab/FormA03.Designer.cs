namespace WinFormLab
{
  partial class FormA03
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
      dataGridView1 = new DataGridView();
      ColumnPersonId = new DataGridViewTextBoxColumn();
      ColumnName = new DataGridViewTextBoxColumn();
      ColumnSurname = new DataGridViewTextBoxColumn();
      ColumnProfession = new DataGridViewTextBoxColumn();
      label1 = new Label();
      label2 = new Label();
      label3 = new Label();
      label4 = new Label();
      txtPersonId = new TextBox();
      txtSurname = new TextBox();
      txtName = new TextBox();
      txtProfession = new TextBox();
      ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
      SuspendLayout();
      // 
      // dataGridView1
      // 
      dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnPersonId, ColumnName, ColumnSurname, ColumnProfession });
      dataGridView1.Location = new Point(12, 177);
      dataGridView1.Name = "dataGridView1";
      dataGridView1.ReadOnly = true;
      dataGridView1.RowHeadersWidth = 51;
      dataGridView1.RowTemplate.Height = 29;
      dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      dataGridView1.Size = new Size(910, 343);
      dataGridView1.TabIndex = 0;
      dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
      // 
      // ColumnPersonId
      // 
      ColumnPersonId.DataPropertyName = "PersonId";
      ColumnPersonId.HeaderText = "識別碼";
      ColumnPersonId.MinimumWidth = 6;
      ColumnPersonId.Name = "ColumnPersonId";
      ColumnPersonId.ReadOnly = true;
      ColumnPersonId.Width = 125;
      // 
      // ColumnName
      // 
      ColumnName.DataPropertyName = "Name";
      ColumnName.HeaderText = "名稱";
      ColumnName.MinimumWidth = 6;
      ColumnName.Name = "ColumnName";
      ColumnName.ReadOnly = true;
      ColumnName.Width = 125;
      // 
      // ColumnSurname
      // 
      ColumnSurname.DataPropertyName = "Surname";
      ColumnSurname.HeaderText = "姓氏";
      ColumnSurname.MinimumWidth = 6;
      ColumnSurname.Name = "ColumnSurname";
      ColumnSurname.ReadOnly = true;
      ColumnSurname.Width = 125;
      // 
      // ColumnProfession
      // 
      ColumnProfession.DataPropertyName = "Profession";
      ColumnProfession.HeaderText = "職業";
      ColumnProfession.MinimumWidth = 6;
      ColumnProfession.Name = "ColumnProfession";
      ColumnProfession.ReadOnly = true;
      ColumnProfession.Width = 125;
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Location = new Point(15, 16);
      label1.Name = "label1";
      label1.Size = new Size(54, 19);
      label1.TabIndex = 1;
      label1.Text = "識別碼";
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Location = new Point(331, 16);
      label2.Name = "label2";
      label2.Size = new Size(39, 19);
      label2.TabIndex = 2;
      label2.Text = "名稱";
      // 
      // label3
      // 
      label3.AutoSize = true;
      label3.Location = new Point(574, 16);
      label3.Name = "label3";
      label3.Size = new Size(39, 19);
      label3.TabIndex = 3;
      label3.Text = "姓氏";
      // 
      // label4
      // 
      label4.AutoSize = true;
      label4.Location = new Point(12, 86);
      label4.Name = "label4";
      label4.Size = new Size(39, 19);
      label4.TabIndex = 4;
      label4.Text = "職業";
      // 
      // txtPersonId
      // 
      txtPersonId.Location = new Point(12, 46);
      txtPersonId.Name = "txtPersonId";
      txtPersonId.Size = new Size(125, 27);
      txtPersonId.TabIndex = 5;
      // 
      // txtSurname
      // 
      txtSurname.Location = new Point(574, 38);
      txtSurname.Name = "txtSurname";
      txtSurname.Size = new Size(125, 27);
      txtSurname.TabIndex = 6;
      // 
      // txtName
      // 
      txtName.Location = new Point(331, 46);
      txtName.Name = "txtName";
      txtName.Size = new Size(125, 27);
      txtName.TabIndex = 7;
      // 
      // txtProfession
      // 
      txtProfession.Location = new Point(12, 120);
      txtProfession.Name = "txtProfession";
      txtProfession.Size = new Size(687, 27);
      txtProfession.TabIndex = 8;
      // 
      // FormA03
      // 
      AutoScaleDimensions = new SizeF(9F, 19F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(934, 532);
      Controls.Add(txtProfession);
      Controls.Add(txtName);
      Controls.Add(txtSurname);
      Controls.Add(txtPersonId);
      Controls.Add(label4);
      Controls.Add(label3);
      Controls.Add(label2);
      Controls.Add(label1);
      Controls.Add(dataGridView1);
      Name = "FormA03";
      Text = "FormA03: DataGridView 複習";
      Load += FormA03_Load;
      ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private DataGridView dataGridView1;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private DataGridViewTextBoxColumn ColumnPersonId;
    private DataGridViewTextBoxColumn ColumnName;
    private DataGridViewTextBoxColumn ColumnSurname;
    private DataGridViewTextBoxColumn ColumnProfession;
    private TextBox txtPersonId;
    private TextBox txtSurname;
    private TextBox txtName;
    private TextBox txtProfession;
  }
}