using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BES.Forms.BookManager
{
    public partial class BookList : Form
    {
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
        private readonly WaitForm _waitform = new WaitForm();
        public BookList()
        {
            InitializeComponent();
        }

        private void BookList_Load(object sender, EventArgs e)
        {
            tscbType.SelectedIndex = 0;
        }

        private void tsbSearch_Click(object sender, EventArgs e)
        {
            _waitform.sValue = "查询中,请稍后.......";
            _waitform.Show();
            String sWhere = String.Empty;
            if (tscbType.Text == "书号")
            {
                sWhere = String.Format("ISBN LIKE '%{0}%'", tstbWord.Text.Trim());
            }
            else if (tscbType.Text == "书名")
            {
                sWhere = String.Format("TITLE LIKE '%{0}%'", tstbWord.Text.Trim());
            }
            Where = sWhere;
            try
            {
                dgvList.DataSource = WSAL.WSPLU.SearchBook(sWhere).Tables[0];
            }
            catch
            {
                _waitform.Hide();
                MessageBox.Show("查询出错，请检查！");
            }
            _waitform.Hide();
        }

        private void dgvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            { return; }
            else
            {

                if (dgvList.Rows[e.RowIndex].Cells["BOOKID"].Value != null && !String.IsNullOrEmpty(dgvList.Rows[e.RowIndex].Cells["BOOKID"].Value.ToString()))
                {
                    try
                    {
                        ViewEditBook frmViewEditBook = new ViewEditBook(dgvList.Rows[e.RowIndex].Cells["BOOKID"].Value.ToString());
                        frmViewEditBook.WindowState = FormWindowState.Maximized;
                        frmViewEditBook.MdiParent = this.MdiParent;
                        frmViewEditBook.Show();
                    }
                    catch
                    { }
                }
            }
        }

        private void tsbAdvance_Click(object sender, EventArgs e)
        {
            AdvanceSearch frmAdvanceSearch = new AdvanceSearch();
            frmAdvanceSearch.ShowDialog();
            if (frmAdvanceSearch.DialogResult == DialogResult.OK)
            {
                _waitform.sValue = "查询中,请稍后.......";
                _waitform.Show();
                if (frmAdvanceSearch.InResult)
                {
                    if (String.IsNullOrEmpty(Where))
                    {
                        Where = "1=1 ";
                    }
                    Where = "("+Where +") AND (" +frmAdvanceSearch.Where+")";
                }
                else
                {
                    Where = frmAdvanceSearch.Where;
                }
                try
                {
                    dgvList.DataSource = WSAL.WSPLU.SearchBook(Where).Tables[0];
                }
                catch
                {
                    _waitform.Hide();
                    MessageBox.Show("查询出错，查询条件：["+Where+"]");
                }
                _waitform.Hide();
            }
        }

        private void tsbExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}