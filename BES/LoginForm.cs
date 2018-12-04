using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BES.Forms
{
    public partial class LoginForm : Form
    {
        public static BES.Entities.DevCache DevCache;
        private readonly WaitForm _waitform = new WaitForm();
        //public static string UserName="";
        //public static int UserType = 2;
        public LoginForm()
        {
            InitializeComponent();
        }
        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (tbPassword.Text.Trim() == "" || tbUserName.Text.Trim() == "")
            {
                MessageBox.Show("用户名密码不能为空，请重输！");
            }
            else
            {
                _waitform.sValue = "登录中，请稍等......";
                this.Visible = false;
                _waitform.Show();
                try
                {
                    
                    //UserType = WSAL.WSUser.GetUserType(tbUserName.Text);
                    int iResult = WSAL.WSUser.CheckPassWord(tbUserName.Text, tbPassword.Text);
                    if (iResult == 1)
                    {
                        _waitform.sValue = "密码验证成功，加载缓存......";
                        try
                        {
                            DevCache = WSAL.WSCommon.GetCache(tbUserName.Text);
                            //加载本地数据库
                            try
                            {
                                DataSet LoaclDataSet = new DataSet();
                                LoaclDataSet = WSAL.WSInfo.GetLocalTable();
                                foreach (DataTable dt in LoaclDataSet.Tables)
                                {
                                    DevCache.DevDataSet.Tables.Add(dt.Copy());
                                }
                            }
                            catch
                            {
                                _waitform.Hide();
                                MessageBox.Show("加载本地数据出错，请重试！");
                                return;
                            }
                        }
                        catch
                        {
                            _waitform.Hide();
                            MessageBox.Show("加载缓存失败，请重试！");
                            return;
                        }
                        
                        //UserName = tbUserName.Text;
                        MainForm frmMain = new MainForm();
                        frmMain.Show();
                        _waitform.Hide();
                    }
                    else if (iResult == -1)
                    {
                        _waitform.Hide();
                        this.Visible = true;
                        MessageBox.Show("用户不存在，请重输！");
                        tbUserName.Clear();
                        tbPassword.Clear();
                        tbUserName.Focus();
                    }
                    else if (iResult == 0)
                    {
                        _waitform.Hide();
                        this.Visible = true;
                        MessageBox.Show("密码错误，请重输！");
                        tbPassword.Clear();
                        tbPassword.Focus();
                    }
                }
                catch
                {
                    _waitform.Hide();
                    this.Visible = true;
                    MessageBox.Show("发生未知错误！");
                }
                
            }
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void lbUpdate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _waitform.sValue = "更新中请稍等。。。。。。";
            this.Hide();
            _waitform.Show();
            try
            {
                if (WSAL.WSInfo.UpdateLocalTable())
                {
                    _waitform.Hide();
                    MessageBox.Show("更新成功！");
                }
                else
                {
                    _waitform.Hide();
                    MessageBox.Show("更新失败！");
                }
            }
            catch(Exception ex)
            {
                _waitform.Hide();
                MessageBox.Show("更新失败"+ex.Message);
            }
            this.Show();
            _waitform.Hide();
        }
    }
}
