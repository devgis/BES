using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BES.Forms
{
    public partial class MainForm : Form
    {
        private readonly WaitForm _waitform = new WaitForm();
        public MainForm()
        {
            InitializeComponent();
            if (LoginForm.DevCache.DevUser.UserType == 1)
            {
                stlUserName.Text = "当前用户:[" + LoginForm.DevCache.DevUser.UserName + "] 出版公司:[本公司]";
            }
            else
            {
                stlUserName.Text = "当前用户:[" + LoginForm.DevCache.DevUser.UserName + "] 出版公司:[" + LoginForm.DevCache.DevUser.UserCompanyName + "]";
            }
        }
        #region 系统管理
        private void mi_Exit_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (MessageBox.Show("当前窗口包含未关闭窗口，您认要退出？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Application.ExitThread();
                }
            }
            else
            {
                Application.ExitThread();
            }
        }

        private void mi_Relogin_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (MessageBox.Show("当前窗口包含未关闭窗口，您认要重新启动？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Application.ExitThread();
                }
            }
            else
            {
                Application.ExitThread();
            }
            Application.Restart();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (MessageBox.Show("当前窗口包含子窗体，您确定要关闭当前窗口及其子窗体么？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Application.ExitThread();
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                Application.ExitThread();
            }
        }

        private void mi_User_Click(object sender, EventArgs e)
        {
            BES.Forms.UserManager.UserList frmUserList = new UserManager.UserList(LoginForm.DevCache.DevDataSet.Tables["COMPANY"]);
            frmUserList.WindowState = FormWindowState.Maximized;
            frmUserList.MdiParent = this;
            frmUserList.Show();
        }
        private void mi_ChgUserPW_Click(object sender, EventArgs e)
        {
            BES.Forms.UserManager.ChgPassWord frmChgPassWord = new UserManager.ChgPassWord(LoginForm.DevCache.DevUser.UserName);
            frmChgPassWord.ShowDialog();
        }
        #endregion


        #region 工具栏
        #region 子窗体平铺
        private void mi_ShuiPing_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mi_TuBiao_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
            
        }

        private void mi_CengDie_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void mi_ChuiZhi_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
        #endregion
        private void tmi_CloseAll_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (MessageBox.Show("您确定要关闭当前所有子窗体？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    foreach (Form f in this.MdiChildren)
                    {
                        try
                        {
                            f.Dispose();
                        }
                        catch
                        { }
                    }
                }
            }
        }
        #endregion

        #region 帮助关于
        private void miHelp_Click(object sender, EventArgs e)
        {
            AboutBox frmAboutBox = new AboutBox();
            frmAboutBox.ShowDialog();
        }

        private void miAbout_Click(object sender, EventArgs e)
        {
            AboutBox frmAboutBox = new AboutBox();
            frmAboutBox.ShowDialog();
        }
        #endregion


        private void MainForm_Load(object sender, EventArgs e)
        {
            //this.MdiParent.ControlAdded += new ControlEventHandler(MdiParent_ControlAdded);
            mi_User.Visible = false;
            switch (LoginForm.DevCache.DevUser.UserType)
            {
                case 1:
                    mi_User.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void tsmiNewBookSearch_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "SearchForm_D")
                {
                    f.Show();
                    f.Activate();
                    return;
                }
            }
            BookManager.BookList frmBookList = new BES.Forms.BookManager.BookList();
            frmBookList.Name = "SearchForm_D";
            frmBookList.WindowState = FormWindowState.Maximized;
            frmBookList.MdiParent = this;
            frmBookList.Show();
        }

        private void tsmiNewBookInput_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "AddForm_D")
                {
                    f.Show();
                    f.Activate();
                    return;
                }
            }
            BookManager.AddBook frmAddBook = new BES.Forms.BookManager.AddBook();
            frmAddBook.Name = "AddForm_D";
            frmAddBook.WindowState = FormWindowState.Maximized;
            frmAddBook.MdiParent = this;
            frmAddBook.Show();
        }
    }
}
