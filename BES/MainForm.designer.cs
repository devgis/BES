namespace BES.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_system = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_PingPU = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_ShuiPing = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_TuBiao = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_CengDie = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_ChuiZhi = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Relogin = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_User = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_ChgUserPW = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_helpabout = new System.Windows.Forms.ToolStripMenuItem();
            this.miHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.miAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tmi_PingPU = new System.Windows.Forms.ToolStripDropDownButton();
            this.tmi_ShuiPing = new System.Windows.Forms.ToolStripMenuItem();
            this.tmi_TuBiao = new System.Windows.Forms.ToolStripMenuItem();
            this.tmi_CengDie = new System.Windows.Forms.ToolStripMenuItem();
            this.tmi_ChuiZhi = new System.Windows.Forms.ToolStripMenuItem();
            this.tmi_CloseAll = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stlUserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.新书管理NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewBookSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewBookInput = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_system,
            this.新书管理NToolStripMenuItem,
            this.menu_helpabout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(758, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu_system
            // 
            this.menu_system.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_PingPU,
            this.mi_Relogin,
            this.mi_User,
            this.mi_ChgUserPW,
            this.mi_Exit});
            this.menu_system.Image = ((System.Drawing.Image)(resources.GetObject("menu_system.Image")));
            this.menu_system.Name = "menu_system";
            this.menu_system.Size = new System.Drawing.Size(99, 20);
            this.menu_system.Text = "系统维护(&S)";
            // 
            // mi_PingPU
            // 
            this.mi_PingPU.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_ShuiPing,
            this.mi_TuBiao,
            this.mi_CengDie,
            this.mi_ChuiZhi});
            this.mi_PingPU.Image = ((System.Drawing.Image)(resources.GetObject("mi_PingPU.Image")));
            this.mi_PingPU.Name = "mi_PingPU";
            this.mi_PingPU.Size = new System.Drawing.Size(136, 22);
            this.mi_PingPU.Text = "排列窗体(&P)";
            // 
            // mi_ShuiPing
            // 
            this.mi_ShuiPing.Image = ((System.Drawing.Image)(resources.GetObject("mi_ShuiPing.Image")));
            this.mi_ShuiPing.Name = "mi_ShuiPing";
            this.mi_ShuiPing.Size = new System.Drawing.Size(136, 22);
            this.mi_ShuiPing.Text = "水平平铺(&S)";
            this.mi_ShuiPing.Click += new System.EventHandler(this.mi_ShuiPing_Click);
            // 
            // mi_TuBiao
            // 
            this.mi_TuBiao.Image = ((System.Drawing.Image)(resources.GetObject("mi_TuBiao.Image")));
            this.mi_TuBiao.Name = "mi_TuBiao";
            this.mi_TuBiao.Size = new System.Drawing.Size(136, 22);
            this.mi_TuBiao.Text = "图标平铺(&T)";
            this.mi_TuBiao.Visible = false;
            this.mi_TuBiao.Click += new System.EventHandler(this.mi_TuBiao_Click);
            // 
            // mi_CengDie
            // 
            this.mi_CengDie.Image = ((System.Drawing.Image)(resources.GetObject("mi_CengDie.Image")));
            this.mi_CengDie.Name = "mi_CengDie";
            this.mi_CengDie.Size = new System.Drawing.Size(136, 22);
            this.mi_CengDie.Text = "层叠平铺(&C)";
            this.mi_CengDie.Click += new System.EventHandler(this.mi_CengDie_Click);
            // 
            // mi_ChuiZhi
            // 
            this.mi_ChuiZhi.Image = ((System.Drawing.Image)(resources.GetObject("mi_ChuiZhi.Image")));
            this.mi_ChuiZhi.Name = "mi_ChuiZhi";
            this.mi_ChuiZhi.Size = new System.Drawing.Size(136, 22);
            this.mi_ChuiZhi.Text = "垂直平铺(Z)";
            this.mi_ChuiZhi.Click += new System.EventHandler(this.mi_ChuiZhi_Click);
            // 
            // mi_Relogin
            // 
            this.mi_Relogin.Image = ((System.Drawing.Image)(resources.GetObject("mi_Relogin.Image")));
            this.mi_Relogin.Name = "mi_Relogin";
            this.mi_Relogin.Size = new System.Drawing.Size(136, 22);
            this.mi_Relogin.Text = "重新登录(&R)";
            this.mi_Relogin.Click += new System.EventHandler(this.mi_Relogin_Click);
            // 
            // mi_User
            // 
            this.mi_User.Name = "mi_User";
            this.mi_User.Size = new System.Drawing.Size(136, 22);
            this.mi_User.Text = "用户管理(&U)";
            this.mi_User.Click += new System.EventHandler(this.mi_User_Click);
            // 
            // mi_ChgUserPW
            // 
            this.mi_ChgUserPW.Name = "mi_ChgUserPW";
            this.mi_ChgUserPW.Size = new System.Drawing.Size(136, 22);
            this.mi_ChgUserPW.Text = "修改密码(&X)";
            this.mi_ChgUserPW.Click += new System.EventHandler(this.mi_ChgUserPW_Click);
            // 
            // mi_Exit
            // 
            this.mi_Exit.Image = ((System.Drawing.Image)(resources.GetObject("mi_Exit.Image")));
            this.mi_Exit.Name = "mi_Exit";
            this.mi_Exit.Size = new System.Drawing.Size(136, 22);
            this.mi_Exit.Text = "退出系统(&E)";
            this.mi_Exit.Click += new System.EventHandler(this.mi_Exit_Click);
            // 
            // menu_helpabout
            // 
            this.menu_helpabout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miHelp,
            this.miAbout});
            this.menu_helpabout.Image = ((System.Drawing.Image)(resources.GetObject("menu_helpabout.Image")));
            this.menu_helpabout.Name = "menu_helpabout";
            this.menu_helpabout.Size = new System.Drawing.Size(99, 20);
            this.menu_helpabout.Text = "帮助关于(&B)";
            // 
            // miHelp
            // 
            this.miHelp.Image = ((System.Drawing.Image)(resources.GetObject("miHelp.Image")));
            this.miHelp.Name = "miHelp";
            this.miHelp.Size = new System.Drawing.Size(112, 22);
            this.miHelp.Text = "帮助(&H)";
            this.miHelp.Click += new System.EventHandler(this.miHelp_Click);
            // 
            // miAbout
            // 
            this.miAbout.Image = ((System.Drawing.Image)(resources.GetObject("miAbout.Image")));
            this.miAbout.Name = "miAbout";
            this.miAbout.Size = new System.Drawing.Size(112, 22);
            this.miAbout.Text = "关于(&A)";
            this.miAbout.Click += new System.EventHandler(this.miAbout_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmi_PingPU,
            this.tmi_CloseAll});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(758, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tmi_PingPU
            // 
            this.tmi_PingPU.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tmi_PingPU.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmi_ShuiPing,
            this.tmi_TuBiao,
            this.tmi_CengDie,
            this.tmi_ChuiZhi});
            this.tmi_PingPU.Image = ((System.Drawing.Image)(resources.GetObject("tmi_PingPU.Image")));
            this.tmi_PingPU.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tmi_PingPU.Name = "tmi_PingPU";
            this.tmi_PingPU.Size = new System.Drawing.Size(29, 22);
            this.tmi_PingPU.Text = "子窗体(P)";
            // 
            // tmi_ShuiPing
            // 
            this.tmi_ShuiPing.Image = ((System.Drawing.Image)(resources.GetObject("tmi_ShuiPing.Image")));
            this.tmi_ShuiPing.Name = "tmi_ShuiPing";
            this.tmi_ShuiPing.Size = new System.Drawing.Size(136, 22);
            this.tmi_ShuiPing.Text = "水平平铺(&S)";
            this.tmi_ShuiPing.Click += new System.EventHandler(this.mi_ShuiPing_Click);
            // 
            // tmi_TuBiao
            // 
            this.tmi_TuBiao.Image = ((System.Drawing.Image)(resources.GetObject("tmi_TuBiao.Image")));
            this.tmi_TuBiao.Name = "tmi_TuBiao";
            this.tmi_TuBiao.Size = new System.Drawing.Size(136, 22);
            this.tmi_TuBiao.Text = "图标平铺(&T)";
            this.tmi_TuBiao.Visible = false;
            this.tmi_TuBiao.Click += new System.EventHandler(this.mi_TuBiao_Click);
            // 
            // tmi_CengDie
            // 
            this.tmi_CengDie.Image = ((System.Drawing.Image)(resources.GetObject("tmi_CengDie.Image")));
            this.tmi_CengDie.Name = "tmi_CengDie";
            this.tmi_CengDie.Size = new System.Drawing.Size(136, 22);
            this.tmi_CengDie.Text = "层叠平铺(&C)";
            this.tmi_CengDie.Click += new System.EventHandler(this.mi_CengDie_Click);
            // 
            // tmi_ChuiZhi
            // 
            this.tmi_ChuiZhi.Image = ((System.Drawing.Image)(resources.GetObject("tmi_ChuiZhi.Image")));
            this.tmi_ChuiZhi.Name = "tmi_ChuiZhi";
            this.tmi_ChuiZhi.Size = new System.Drawing.Size(136, 22);
            this.tmi_ChuiZhi.Text = "垂直平铺(Z)";
            this.tmi_ChuiZhi.Click += new System.EventHandler(this.mi_ChuiZhi_Click);
            // 
            // tmi_CloseAll
            // 
            this.tmi_CloseAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tmi_CloseAll.Image = global::BES.Forms.Properties.Resources.Exit;
            this.tmi_CloseAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tmi_CloseAll.Name = "tmi_CloseAll";
            this.tmi_CloseAll.Size = new System.Drawing.Size(23, 22);
            this.tmi_CloseAll.Text = "关闭所有窗体";
            this.tmi_CloseAll.ToolTipText = "关闭全部";
            this.tmi_CloseAll.Click += new System.EventHandler(this.tmi_CloseAll_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stlUserName});
            this.statusStrip1.Location = new System.Drawing.Point(0, 452);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(758, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stlUserName
            // 
            this.stlUserName.Name = "stlUserName";
            this.stlUserName.Size = new System.Drawing.Size(131, 17);
            this.stlUserName.Text = "toolStripStatusLabel1";
            // 
            // 新书管理NToolStripMenuItem
            // 
            this.新书管理NToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNewBookSearch,
            this.tsmiNewBookInput});
            this.新书管理NToolStripMenuItem.Name = "新书管理NToolStripMenuItem";
            this.新书管理NToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.新书管理NToolStripMenuItem.Text = "新书管理(&N)";
            // 
            // tsmiNewBookSearch
            // 
            this.tsmiNewBookSearch.Name = "tsmiNewBookSearch";
            this.tsmiNewBookSearch.Size = new System.Drawing.Size(152, 22);
            this.tsmiNewBookSearch.Text = "新书查询(&S)";
            this.tsmiNewBookSearch.Click += new System.EventHandler(this.tsmiNewBookSearch_Click);
            // 
            // tsmiNewBookInput
            // 
            this.tsmiNewBookInput.Name = "tsmiNewBookInput";
            this.tsmiNewBookInput.Size = new System.Drawing.Size(152, 22);
            this.tsmiNewBookInput.Text = "新书录入(&A)";
            this.tsmiNewBookInput.Click += new System.EventHandler(this.tsmiNewBookInput_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BES.Forms.ImageResource.bkgroud;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(758, 474);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图书录入系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_system;
        private System.Windows.Forms.ToolStripMenuItem menu_helpabout;
        private System.Windows.Forms.ToolStripMenuItem mi_Relogin;
        private System.Windows.Forms.ToolStripMenuItem mi_Exit;
        private System.Windows.Forms.ToolStripMenuItem mi_PingPU;
        private System.Windows.Forms.ToolStripMenuItem mi_ShuiPing;
        private System.Windows.Forms.ToolStripMenuItem mi_TuBiao;
        private System.Windows.Forms.ToolStripMenuItem mi_CengDie;
        private System.Windows.Forms.ToolStripMenuItem mi_ChuiZhi;
        private System.Windows.Forms.ToolStripDropDownButton tmi_PingPU;
        private System.Windows.Forms.ToolStripMenuItem tmi_ShuiPing;
        private System.Windows.Forms.ToolStripMenuItem tmi_TuBiao;
        private System.Windows.Forms.ToolStripMenuItem tmi_CengDie;
        private System.Windows.Forms.ToolStripMenuItem tmi_ChuiZhi;
        //private System.Windows.Forms.ToolStripLabel tmiUserName;
        private System.Windows.Forms.ToolStripMenuItem miHelp;
        private System.Windows.Forms.ToolStripMenuItem miAbout;
        private System.Windows.Forms.ToolStripStatusLabel stlUserName;
        private System.Windows.Forms.ToolStripMenuItem mi_User;
        private System.Windows.Forms.ToolStripMenuItem mi_ChgUserPW;
        private System.Windows.Forms.ToolStripButton tmi_CloseAll;
        private System.Windows.Forms.ToolStripMenuItem 新书管理NToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewBookSearch;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewBookInput;
    }
}