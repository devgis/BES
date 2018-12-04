using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BES.Forms.UserManager
{
    public partial class ChgPassWord : Form
    {
        public ChgPassWord(string UserName)
        {
            InitializeComponent();
            lbUserName.Text = UserName;
        }

        private void tsmiCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            if (tbOldPassword.Text.Trim() == "" || tbNewPassword1.Text.Trim() == "" || tbNewPassword2.Text.Trim() == "")
            {
                MessageBox.Show("密码不能为空！");
                return;
            }
            try
            {
                if (tbNewPassword1.Text != tbNewPassword2.Text)
                {
                    MessageBox.Show("两次新密码输入不一致，请稍候再试！");
                    return;
                }
                int iResult = WSAL.WSUser.CheckPassWord(lbUserName.Text, tbOldPassword.Text);
                if (iResult == 1)
                {
                    if (WSAL.WSUser.UpdateUserPassword(lbUserName.Text, tbNewPassword1.Text))
                    {
                        MessageBox.Show("修改密码成功");
                        tbOldPassword.Clear();
                        tbNewPassword1.Clear();
                        tbNewPassword2.Clear();
                    }
                    else
                    {
                        MessageBox.Show("修改密码失败，请稍候再试！");
                    }
                }
                else if (iResult == -1)
                {
                    MessageBox.Show("更改密码失败，请稍候再试！");
                }
                else if (iResult == 0)
                {
                    MessageBox.Show("老密码输入错误，请稍候再试！");
                }
            }
            catch
            {
                MessageBox.Show("出现异常，请稍候再试！");
            }
            
        }
    }
}
