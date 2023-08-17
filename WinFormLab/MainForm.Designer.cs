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
      TreeNode treeNode22 = new TreeNode("FormA01");
      TreeNode treeNode23 = new TreeNode("FormA02");
      TreeNode treeNode24 = new TreeNode("FormA03");
      TreeNode treeNode25 = new TreeNode("FormA04");
      TreeNode treeNode26 = new TreeNode("FormA05");
      TreeNode treeNode27 = new TreeNode("FormA06");
      TreeNode treeNode28 = new TreeNode("開啟新視窗", new TreeNode[] { treeNode22, treeNode23, treeNode24, treeNode25, treeNode26, treeNode27 });
      TreeNode treeNode29 = new TreeNode("節點7");
      TreeNode treeNode30 = new TreeNode("節點12");
      TreeNode treeNode31 = new TreeNode("節點13");
      TreeNode treeNode32 = new TreeNode("節點1", new TreeNode[] { treeNode29, treeNode30, treeNode31 });
      TreeNode treeNode33 = new TreeNode("節點6");
      TreeNode treeNode34 = new TreeNode("節點14");
      TreeNode treeNode35 = new TreeNode("節點2", new TreeNode[] { treeNode33, treeNode34 });
      TreeNode treeNode36 = new TreeNode("節點4");
      TreeNode treeNode37 = new TreeNode("節點15");
      TreeNode treeNode38 = new TreeNode("節點3", new TreeNode[] { treeNode36, treeNode37 });
      TreeNode treeNode39 = new TreeNode("節點16");
      TreeNode treeNode40 = new TreeNode("節點17");
      TreeNode treeNode41 = new TreeNode("節點18");
      TreeNode treeNode42 = new TreeNode("節點8", new TreeNode[] { treeNode39, treeNode40, treeNode41 });
      menuStrip1 = new MenuStrip();
      menuToggleFuncs = new ToolStripMenuItem();
      系統ToolStripMenuItem = new ToolStripMenuItem();
      變更密碼ToolStripMenuItem = new ToolStripMenuItem();
      使用原來身份ToolStripMenuItem = new ToolStripMenuItem();
      使用代理身份ToolStripMenuItem = new ToolStripMenuItem();
      menuLogout = new ToolStripMenuItem();
      menuGroupA = new ToolStripMenuItem();
      menuFormA01 = new ToolStripMenuItem();
      menuFormA02 = new ToolStripMenuItem();
      menuFormA03 = new ToolStripMenuItem();
      menuFormA04 = new ToolStripMenuItem();
      menuFormA05 = new ToolStripMenuItem();
      toolStripSeparator1 = new ToolStripSeparator();
      tvMenu = new TreeView();
      splitter1 = new Splitter();
      statusStrip1 = new StatusStrip();
      tssStatus = new ToolStripStatusLabel();
      menuStrip1.SuspendLayout();
      statusStrip1.SuspendLayout();
      SuspendLayout();
      // 
      // menuStrip1
      // 
      menuStrip1.Font = new Font("微軟正黑體", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
      menuStrip1.ImageScalingSize = new Size(20, 20);
      menuStrip1.Items.AddRange(new ToolStripItem[] { menuToggleFuncs, 系統ToolStripMenuItem, menuGroupA });
      menuStrip1.Location = new Point(0, 0);
      menuStrip1.Name = "menuStrip1";
      menuStrip1.Padding = new Padding(9, 3, 0, 3);
      menuStrip1.Size = new Size(1267, 32);
      menuStrip1.TabIndex = 2;
      menuStrip1.Text = "menuStrip1";
      // 
      // menuToggleFuncs
      // 
      menuToggleFuncs.Image = Properties.Resources.saicon2;
      menuToggleFuncs.Name = "menuToggleFuncs";
      menuToggleFuncs.Size = new Size(78, 26);
      menuToggleFuncs.Text = "開始";
      menuToggleFuncs.Click += menuToggleFuncs_Click;
      // 
      // 系統ToolStripMenuItem
      // 
      系統ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 變更密碼ToolStripMenuItem, 使用原來身份ToolStripMenuItem, 使用代理身份ToolStripMenuItem, menuLogout });
      系統ToolStripMenuItem.Name = "系統ToolStripMenuItem";
      系統ToolStripMenuItem.Size = new Size(58, 26);
      系統ToolStripMenuItem.Text = "系統";
      // 
      // 變更密碼ToolStripMenuItem
      // 
      變更密碼ToolStripMenuItem.Name = "變更密碼ToolStripMenuItem";
      變更密碼ToolStripMenuItem.Size = new Size(196, 26);
      變更密碼ToolStripMenuItem.Text = "變更密碼";
      // 
      // 使用原來身份ToolStripMenuItem
      // 
      使用原來身份ToolStripMenuItem.Name = "使用原來身份ToolStripMenuItem";
      使用原來身份ToolStripMenuItem.Size = new Size(196, 26);
      使用原來身份ToolStripMenuItem.Text = "使用原來身份";
      // 
      // 使用代理身份ToolStripMenuItem
      // 
      使用代理身份ToolStripMenuItem.Name = "使用代理身份ToolStripMenuItem";
      使用代理身份ToolStripMenuItem.Size = new Size(196, 26);
      使用代理身份ToolStripMenuItem.Text = "使用代理身份";
      // 
      // menuLogout
      // 
      menuLogout.Name = "menuLogout";
      menuLogout.Size = new Size(196, 26);
      menuLogout.Text = "登出";
      menuLogout.Click += menuLogout_Click;
      // 
      // menuGroupA
      // 
      menuGroupA.DropDownItems.AddRange(new ToolStripItem[] { menuFormA01, menuFormA02, menuFormA03, menuFormA04, menuFormA05, toolStripSeparator1 });
      menuGroupA.Name = "menuGroupA";
      menuGroupA.Size = new Size(109, 26);
      menuGroupA.Text = "開啟新視窗";
      // 
      // menuFormA01
      // 
      menuFormA01.Name = "menuFormA01";
      menuFormA01.Size = new Size(168, 26);
      menuFormA01.Text = "FormA01";
      menuFormA01.Click += menuFormA01_Click;
      // 
      // menuFormA02
      // 
      menuFormA02.Name = "menuFormA02";
      menuFormA02.Size = new Size(168, 26);
      menuFormA02.Text = "FormA02";
      menuFormA02.Click += menuFormA02_Click;
      // 
      // menuFormA03
      // 
      menuFormA03.Name = "menuFormA03";
      menuFormA03.Size = new Size(168, 26);
      menuFormA03.Text = "FormA03";
      menuFormA03.Click += menuFormA03_Click;
      // 
      // menuFormA04
      // 
      menuFormA04.Name = "menuFormA04";
      menuFormA04.Size = new Size(168, 26);
      menuFormA04.Text = "FormA04";
      menuFormA04.Click += menuFormA04_Click;
      // 
      // menuFormA05
      // 
      menuFormA05.Name = "menuFormA05";
      menuFormA05.Size = new Size(168, 26);
      menuFormA05.Text = "FormA05";
      menuFormA05.Click += menuFormA05_Click;
      // 
      // toolStripSeparator1
      // 
      toolStripSeparator1.Name = "toolStripSeparator1";
      toolStripSeparator1.Size = new Size(165, 6);
      // 
      // tvMenu
      // 
      tvMenu.Dock = DockStyle.Left;
      tvMenu.Location = new Point(0, 32);
      tvMenu.Name = "tvMenu";
      treeNode22.Name = "nodeFormA01";
      treeNode22.Tag = "WinFormLab.FormA01";
      treeNode22.Text = "FormA01";
      treeNode23.Name = "nodeFormA02";
      treeNode23.Tag = "WinFormLab.FormA02";
      treeNode23.Text = "FormA02";
      treeNode24.Name = "nodeFormA03";
      treeNode24.Tag = "WinFormLab.FormA03";
      treeNode24.Text = "FormA03";
      treeNode25.Name = "nodeFormA04";
      treeNode25.Tag = "WinFormLab.FormA04";
      treeNode25.Text = "FormA04";
      treeNode26.Name = "nodeFormA05";
      treeNode26.Tag = "WinFormLab.FormA05";
      treeNode26.Text = "FormA05";
      treeNode27.Name = "nodeFormA06";
      treeNode27.Tag = "WinFormLab.FormA06";
      treeNode27.Text = "FormA06";
      treeNode28.Name = "funcGrp0";
      treeNode28.Text = "開啟新視窗";
      treeNode29.Name = "節點7";
      treeNode29.Text = "節點7";
      treeNode30.Name = "節點12";
      treeNode30.Text = "節點12";
      treeNode31.Name = "節點13";
      treeNode31.Text = "節點13";
      treeNode32.Name = "節點1";
      treeNode32.Text = "節點1";
      treeNode33.Name = "節點6";
      treeNode33.Text = "節點6";
      treeNode34.Name = "節點14";
      treeNode34.Text = "節點14";
      treeNode35.Name = "節點2";
      treeNode35.Text = "節點2";
      treeNode36.Name = "節點4";
      treeNode36.Text = "節點4";
      treeNode37.Name = "節點15";
      treeNode37.Text = "節點15";
      treeNode38.Name = "節點3";
      treeNode38.Text = "節點3";
      treeNode39.Name = "節點16";
      treeNode39.Text = "節點16";
      treeNode40.Name = "節點17";
      treeNode40.Text = "節點17";
      treeNode41.Name = "節點18";
      treeNode41.Text = "節點18";
      treeNode42.Name = "節點8";
      treeNode42.Text = "節點8";
      tvMenu.Nodes.AddRange(new TreeNode[] { treeNode28, treeNode32, treeNode35, treeNode38, treeNode42 });
      tvMenu.Size = new Size(221, 618);
      tvMenu.TabIndex = 5;
      tvMenu.AfterSelect += tvMenu_AfterSelect;
      tvMenu.Enter += tvMenu_Enter;
      tvMenu.Leave += tvMenu_Leave;
      // 
      // splitter1
      // 
      splitter1.Location = new Point(221, 32);
      splitter1.Name = "splitter1";
      splitter1.Size = new Size(4, 618);
      splitter1.TabIndex = 9;
      splitter1.TabStop = false;
      // 
      // statusStrip1
      // 
      statusStrip1.ImageScalingSize = new Size(20, 20);
      statusStrip1.Items.AddRange(new ToolStripItem[] { tssStatus });
      statusStrip1.Location = new Point(0, 650);
      statusStrip1.Name = "statusStrip1";
      statusStrip1.Size = new Size(1267, 25);
      statusStrip1.TabIndex = 11;
      statusStrip1.Text = "statusStrip1";
      // 
      // tssStatus
      // 
      tssStatus.Name = "tssStatus";
      tssStatus.Size = new Size(39, 19);
      tssStatus.Text = "狀態";
      // 
      // MainForm
      // 
      AutoScaleDimensions = new SizeF(10F, 22F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(1267, 675);
      Controls.Add(splitter1);
      Controls.Add(tvMenu);
      Controls.Add(statusStrip1);
      Controls.Add(menuStrip1);
      Font = new Font("微軟正黑體", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
      IsMdiContainer = true;
      MainMenuStrip = menuStrip1;
      Name = "MainForm";
      StartPosition = FormStartPosition.CenterScreen;
      Text = "MainForm";
      Load += MainForm_Load;
      menuStrip1.ResumeLayout(false);
      menuStrip1.PerformLayout();
      statusStrip1.ResumeLayout(false);
      statusStrip1.PerformLayout();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private MenuStrip menuStrip1;
    private TreeView tvMenu;
    private ToolStripMenuItem menuToggleFuncs;
    private Splitter splitter1;
    private ToolStripMenuItem 系統ToolStripMenuItem;
    private ToolStripMenuItem 變更密碼ToolStripMenuItem;
    private ToolStripMenuItem 使用原來身份ToolStripMenuItem;
    private ToolStripMenuItem 使用代理身份ToolStripMenuItem;
    private ToolStripMenuItem 離開ToolStripMenuItem;
    private ToolStripMenuItem menuGroupA;
    private ToolStripMenuItem menuFormA01;
    private ToolStripMenuItem menuFormA02;
    private ToolStripMenuItem menuFormA03;
    private ToolStripMenuItem menuFormA04;
    private ToolStripMenuItem menuFormA05;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripMenuItem menuLogout;
    private ToolStripMenuItem formA01ToolStripMenuItem;
    private StatusStrip statusStrip1;
    private ToolStripStatusLabel tssStatus;
  }
}