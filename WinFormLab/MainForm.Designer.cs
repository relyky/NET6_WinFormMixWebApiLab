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
      TreeNode treeNode1 = new TreeNode("FormA01");
      TreeNode treeNode2 = new TreeNode("FormA02");
      TreeNode treeNode3 = new TreeNode("FormA03");
      TreeNode treeNode4 = new TreeNode("FormA04");
      TreeNode treeNode5 = new TreeNode("FormA05");
      TreeNode treeNode6 = new TreeNode("FormA06");
      TreeNode treeNode7 = new TreeNode("FormA07");
      TreeNode treeNode8 = new TreeNode("開啟新視窗", new TreeNode[] { treeNode1, treeNode2, treeNode3, treeNode4, treeNode5, treeNode6, treeNode7 });
      TreeNode treeNode9 = new TreeNode("節點7");
      TreeNode treeNode10 = new TreeNode("節點12");
      TreeNode treeNode11 = new TreeNode("節點13");
      TreeNode treeNode12 = new TreeNode("節點1", new TreeNode[] { treeNode9, treeNode10, treeNode11 });
      TreeNode treeNode13 = new TreeNode("節點6");
      TreeNode treeNode14 = new TreeNode("節點14");
      TreeNode treeNode15 = new TreeNode("節點2", new TreeNode[] { treeNode13, treeNode14 });
      TreeNode treeNode16 = new TreeNode("節點4");
      TreeNode treeNode17 = new TreeNode("節點15");
      TreeNode treeNode18 = new TreeNode("節點3", new TreeNode[] { treeNode16, treeNode17 });
      TreeNode treeNode19 = new TreeNode("節點16");
      TreeNode treeNode20 = new TreeNode("節點17");
      TreeNode treeNode21 = new TreeNode("節點18");
      TreeNode treeNode22 = new TreeNode("節點8", new TreeNode[] { treeNode19, treeNode20, treeNode21 });
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
      treeNode1.Name = "nodeFormA01";
      treeNode1.Tag = "WinFormLab.FormA01";
      treeNode1.Text = "FormA01";
      treeNode2.Name = "nodeFormA02";
      treeNode2.Tag = "WinFormLab.FormA02";
      treeNode2.Text = "FormA02";
      treeNode3.Name = "nodeFormA03";
      treeNode3.Tag = "WinFormLab.FormA03";
      treeNode3.Text = "FormA03";
      treeNode4.Name = "nodeFormA04";
      treeNode4.Tag = "WinFormLab.FormA04";
      treeNode4.Text = "FormA04";
      treeNode5.Name = "nodeFormA05";
      treeNode5.Tag = "WinFormLab.FormA05";
      treeNode5.Text = "FormA05";
      treeNode6.Name = "nodeFormA06";
      treeNode6.Tag = "WinFormLab.FormA06";
      treeNode6.Text = "FormA06";
      treeNode7.Name = "nodeFormA07";
      treeNode7.Tag = "WinFormLab.FormA07";
      treeNode7.Text = "FormA07";
      treeNode8.Name = "funcGrp0";
      treeNode8.Text = "開啟新視窗";
      treeNode9.Name = "節點7";
      treeNode9.Text = "節點7";
      treeNode10.Name = "節點12";
      treeNode10.Text = "節點12";
      treeNode11.Name = "節點13";
      treeNode11.Text = "節點13";
      treeNode12.Name = "節點1";
      treeNode12.Text = "節點1";
      treeNode13.Name = "節點6";
      treeNode13.Text = "節點6";
      treeNode14.Name = "節點14";
      treeNode14.Text = "節點14";
      treeNode15.Name = "節點2";
      treeNode15.Text = "節點2";
      treeNode16.Name = "節點4";
      treeNode16.Text = "節點4";
      treeNode17.Name = "節點15";
      treeNode17.Text = "節點15";
      treeNode18.Name = "節點3";
      treeNode18.Text = "節點3";
      treeNode19.Name = "節點16";
      treeNode19.Text = "節點16";
      treeNode20.Name = "節點17";
      treeNode20.Text = "節點17";
      treeNode21.Name = "節點18";
      treeNode21.Text = "節點18";
      treeNode22.Name = "節點8";
      treeNode22.Text = "節點8";
      tvMenu.Nodes.AddRange(new TreeNode[] { treeNode8, treeNode12, treeNode15, treeNode18, treeNode22 });
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