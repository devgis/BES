using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BES.Forms.UserManager
{
    public partial class UserList : Form
    {
        private DataTable DTCompany;
        public UserList(DataTable DtCompany)
        {
            InitializeComponent();
            this.DTCompany = DtCompany;
        }

        private void tsmiCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认退出？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Dispose();
            }
        }

        private void tsmiAddRow_Click(object sender, EventArgs e)
        {
            AddUser frmAddUser = new AddUser(this.DTCompany);
            frmAddUser.ShowDialog();
            LoadData();
        }

        private void tsmiRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void UserList_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                dgvUserList.DataSource = WSAL.WSUser.GetList("");
            }
            catch
            {
                MessageBox.Show("加载数据出错，请稍候再试！");
            }
        }

        private void tsmiDeleteRow_Click(object sender, EventArgs e)
        {
            if (dgvUserList.SelectedRows.Count <= 0)
            {
                MessageBox.Show("请选择用户进行删除！");
            }
            else
            {
                try
                {
                    int UserId = Convert.ToInt32(dgvUserList.SelectedRows[0].Cells["UserID"].Value);
                    if (WSAL.WSUser.Delete(UserId))
                    {
                        MessageBox.Show("删除成功！");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("删除失败！");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("出错:"+ex.Message);
                }
            }
        }

        private void tsmiEdit_Click(object sender, EventArgs e)
        {

            if (dgvUserList.SelectedRows.Count <= 0)
            {
                MessageBox.Show("请选择用户进行删除！");
            }
            else
            {
                try
                {
                    int UserId = Convert.ToInt32(dgvUserList.SelectedRows[0].Cells["UserID"].Value);
                    EditUser frmEditUser = new EditUser(UserId, DTCompany);
                    frmEditUser.ShowDialog();
                    LoadData();
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show("加载用户出错:"+ex.Message);
                }
            }
        }
    }
}
