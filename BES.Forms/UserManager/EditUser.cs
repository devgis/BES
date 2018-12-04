using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BES.Forms.UserManager
{
    public partial class EditUser : Form
    {
        private int _userid;
        private int userid
        {
            get{return _userid;}
            set{_userid=value;}
        }
        private DataTable DTCompany;
        public EditUser(int UserId, DataTable DtCompany)
        {
            InitializeComponent();
            this.DTCompany = DtCompany;
            try
            {
                BES.Entities.User u = WSAL.WSUser.GetModel(UserId);
                tbUserName.Text = u.UserName;
                tbUserName.ReadOnly = true;
                tbPassWord.Text = u.UserPassword;
                try
                {
                    cbType.SelectedIndex = u.UserType;
                }
                catch
                {
                    cbType.SelectedIndex = 0;
                }
                try
                {
                    cbCompany.SelectedValue = u.UserCompanyCode;
                }
                catch
                {
                    cbType.SelectedIndex = 0;
                }

                this.userid = UserId;
            }
            catch
            {
                this.Dispose();
            }
        }

        private void tsmiCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认退出？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Dispose();
            }
        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                try
                {
                    if (!SaveDate())
                    {
                        MessageBox.Show("保存失败!");
                    }
                    else
                    {
                        MessageBox.Show("保存成功!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message);
                }
            }
        }
        #region 通用方法
        /// <summary>
        /// 校验数据
        /// </summary>
        /// <returns></returns>
        private bool CheckData()
        {
            if (tbUserName.Text.Trim() == "")
            {
                MessageBox.Show("请输入用户名!");
                tbUserName.Focus();
                return false;
            }
            if (tbPassWord.Text.Trim() == "")
            {
                MessageBox.Show("请输入用户密码!");
                tbPassWord.Focus();
                return false;
            }
            if (cbCompany.SelectedValue == null)
            {
                MessageBox.Show("请选择出版社!");
                cbCompany.Focus();
                return false;
            }
            return true;
        }
        /// <summary>
        /// 获取对象模型
        /// </summary>
        /// <returns></returns>
        private BES.Entities.User GetModel()
        {
            BES.Entities.User model = new BES.Entities.User();
            model.UserID = this.userid;
            model.UserName = tbUserName.Text;
            model.UserPassword = tbPassWord.Text;
            model.UserType = cbType.SelectedIndex;
            model.UserCompanyCode = cbCompany.SelectedValue.ToString();
            return model;
        }
        /// <summary>
        /// 保存数据
        /// </summary>
        /// <returns>成功则返回主表ID</returns>
        private bool SaveDate()
        {
            bool i =false;
            try
            {
                i = WSAL.WSUser.Update(GetModel());
            }
            catch
            { }
            return i;
        }
        #endregion

        private void EditUser_Load(object sender, EventArgs e)
        {
            cbCompany.DataSource = DTCompany;
            cbCompany.DisplayMember = "SHORTNAME";
            cbCompany.ValueMember = "CODE";
        }
    }
}
