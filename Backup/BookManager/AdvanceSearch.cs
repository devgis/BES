using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BES.Forms.BookManager
{
    public partial class AdvanceSearch : Form
    {
        private bool inResult;
        public bool InResult
        {
            get
            {
                return inResult;
            }
            set
            {
                inResult = value;
            }
        }
        private String where;
        public String Where
        {
            get
            {
                return where;
            }
            set
            {
                where = value;
            }
        }

        public AdvanceSearch()
        {
            InitializeComponent();
        }

        private void AdvanceSearch_Load(object sender, EventArgs e)
        {
            cbField.DataSource = LoginForm.DevCache.DevDataSet.Tables["SEARCHBOOKFILTER"];
            cbField.DisplayMember = "TYPENAME";
            cbField.ValueMember = "TYPEVALUE";
            cbField.SelectedIndex = 0;
            //cbField.SelectedIndex = 0;
            //ListViewItem lwi = new ListViewItem();
            //ListViewItem.ListViewSubItem lvs1 = new ListViewItem.ListViewSubItem();
            //lvs1.Text = "cccc1";
            //ListViewItem.ListViewSubItem lvs2 = new ListViewItem.ListViewSubItem();
            //lvs2.Text = "cccc2";
            //lwi.SubItems.Add(lvs1);
            //lwi.SubItems.Add(lvs2);
            //lwi.Text = "ccccccccccccccccccccccccccccccccccccc";
            //lwi.Tag = "fdfdfd";
            //lwSelected.Items.Add(lwi);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lwi in lwSelected.SelectedItems)
            {
                lwSelected.Items.Remove(lwi);
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbField_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cbField.Text) && !String.IsNullOrEmpty(cbType.Text) && !String.IsNullOrEmpty(tbWords.Text))
            {
                ListViewItem lwi = new ListViewItem();
                lwi.Text = cbField.Text + cbType.SelectedItem.ToString()+ "'" + tbWords.Text + "'";
                switch(cbType.Text.Trim())
                {
                    //�ַ�������
                    case "��":
                        lwi.Tag = cbType.Tag.ToString() +  " = '" + tbWords.Text + "' ";
                        break;
                    case "ģ��ƥ��":
                        lwi.Tag = cbType.Tag.ToString() + " like '%" + tbWords.Text + "%' ";
                        break;
                    case "��ʼ":
                        lwi.Tag = cbType.Tag.ToString() + " like '" + tbWords.Text + "%' ";
                        break;
                    case "����":
                        lwi.Tag = cbType.Tag.ToString() + " like '%" + tbWords.Text + "' ";
                        break;
                    //ʱ��������ֵ����
                    case "����":
                        lwi.Tag = cbType.Tag.ToString() + " > " + tbWords.Text + " ";
                        break;
                    case "���ڵ���":
                        lwi.Tag = cbType.Tag.ToString() + " >= " + tbWords.Text + " ";
                        break;
                    case "����":
                        lwi.Tag = cbType.Tag.ToString() + " = " + tbWords.Text + " ";
                        break;
                    case "������":
                        lwi.Tag = cbType.Tag.ToString() + " <> " + tbWords.Text + " ";
                        break;
                    case "С��":
                        lwi.Tag = cbType.Tag.ToString() + " < " + tbWords.Text + " ";
                        break;
                    case "С�ڵ���":
                        lwi.Tag = cbType.Tag.ToString() + " <= " + tbWords.Text + " ";
                        break;
                }
                lwSelected.Items.Add(lwi);
            }
            else
            {
                MessageBox.Show("��ѡ��ֵ��������ؼ��ʣ�");
            }
        }

        private void cbField_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbField.SelectedValue != null && cbField.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                String[] sList = cbField.SelectedValue.ToString().Split('|');
                cbType.Items.Clear();
                cbType.Tag = sList[0];
                for (int i = 1; i < sList.Length; i++)
                {
                    if (!String.IsNullOrEmpty(sList[i]))
                    {
                        cbType.Items.Add(sList[i]);
                    }
                }
            }
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            InResult = cbResult.Checked;
            if (rbAnd.Checked)
            {
                Where = "1=1";
                foreach (ListViewItem lvi in lwSelected.Items)
                {
                    Where += " AND " + lvi.Tag.ToString();
                }
            }
            else
            {
                if (lwSelected.Items.Count > 0)
                {
                    Where = "0=1";
                    foreach (ListViewItem lvi in lwSelected.Items)
                    {
                        Where += " OR " + lvi.Tag.ToString();
                    }
                }
            }
            this.DialogResult = DialogResult.OK;
        }

    }
}
