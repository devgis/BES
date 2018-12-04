using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BES.Forms.BookManager
{
    public partial class ViewEditBook : Form
    {
        String TestBOOKID = String.Empty;
        //private int CurrentIndex = 0; //指示当前位置
        //private int CurrentIndex
        //{
        //    get
        //    {
        //        return currentIndex;
        //    }
        //    set
        //    {
        //        currentIndex = value;
        //    }
        //}

        private readonly WaitForm _waitform = new WaitForm();
        //private List<BES.Entities.PLU> lisNotSaved = new List<BES.Entities.PLU>();
        //private static List<BES.Entities.PLU> lisSaved = null;
        //private List<BES.Entities.PLU> GetSaved()
        //{
        //    if (lisSaved == null)
        //    {
        //        _waitform.sValue = "加载数据中......";
        //        _waitform.Show();
        //        try
        //        {
        //            lisSaved = WSAL.WSPLU.GetModelList("PUBLISHER='" + LoginForm.DevCache.DevUser.UserCompanyCode + "'");
        //        }
        //        catch
        //        {
        //            MessageBox.Show("加载记录失败！");
        //        }
        //        _waitform.Hide();
        //    }
        //    return lisSaved;
        //}

        public ViewEditBook(String BookID)
        {
            InitializeComponent();
            TestBOOKID = BookID;
        }

        private void AddBook_Load(object sender, EventArgs e)
        {
            this.Refresh();
            _waitform.sValue = "准备数据中......";
            _waitform.Show();
            #region 加载数据
            //大分类 一级分类
            cbDEPARTMENT.DataSource = LoginForm.DevCache.DevDataSet.Tables["DEPARTMENT"];
            cbDEPARTMENT.DisplayMember = "DPTNAME";
            cbDEPARTMENT.ValueMember = "DPTCODE";

            ////经销商 
            //cbFRANCHISEE.DataSource = LoginForm.DevCache.DevDataSet.Tables["SALECOMPANY"];
            //cbFRANCHISEE.DisplayMember = "SHORTNAME";
            //cbFRANCHISEE.ValueMember = "CODE";

            //小类 中图法分类
            cbCLASS.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            cbCLASS.DataSource = LoginForm.DevCache.DevDataSet.Tables["CLASS"];
            cbCLASS.DisplayMember = "CLSNAME";
            cbCLASS.ValueMember = "CLSCODE";

            //版别
            cbPublisher.DataSource = LoginForm.DevCache.DevDataSet.Tables["COMPANY"];
            cbPublisher.DisplayMember = "NAME";
            cbPublisher.ValueMember = "CODE";

            //物品种类
            cbPYSTYPE.DataSource = LoginForm.DevCache.DevDataSet.Tables["PYSTYPE"];
            cbPYSTYPE.DisplayMember = "DESCRIPT";
            cbPYSTYPE.ValueMember = "PYSTYPE";

            //装帧表
            cbBINDING.DataSource = LoginForm.DevCache.DevDataSet.Tables["BINDING"];
            cbBINDING.DisplayMember = "DESCRIPT";
            cbBINDING.ValueMember = "BINDING";

            //开本表
            cbBKSIZE.DataSource = LoginForm.DevCache.DevDataSet.Tables["SIZE"];
            cbBKSIZE.DisplayMember = "DESCRIPT";
            cbBKSIZE.ValueMember = "BKSIZE";

            #region COMBOX选择值变化时修改相应编码
            //if (cbDEPARTMENT.SelectedValue != null && cbDEPARTMENT.SelectedValue.ToString() != "System.Data.DataRowView")
            //{
            //    tbDEPARTMENT.Text = cbDEPARTMENT.SelectedValue.ToString();
            //}

            //if (cbCLASS.SelectedValue != null && cbCLASS.SelectedValue.ToString() != "System.Data.DataRowView")
            //{
            //    tbCLASS.Text = cbCLASS.SelectedValue.ToString();
            //}

            //if (cbPYSTYPE.SelectedValue != null && cbPYSTYPE.SelectedValue.ToString() != "System.Data.DataRowView")
            //{
            //    tbPYSTYPE.Text = cbPYSTYPE.SelectedValue.ToString();
            //}
            cbBINDING.Text = String.Empty;
            cbBKSIZE.Text = String.Empty;
            //if (cbFRANCHISEE.SelectedValue != null && cbFRANCHISEE.SelectedValue.ToString() != "System.Data.DataRowView")
            //{
            //    tbFRANCHISEE.Text = cbFRANCHISEE.SelectedValue.ToString();
            //}
        #endregion

            tbCREATBY.Text = LoginForm.DevCache.DevUser.UserName;
            tbCREDATE.Text = LoginForm.DevCache.LoginTime.ToString("yyyy-MM-dd");
            //tbPUBLISHER.Text = LoginForm.DevCache.DevUser.UserCompanyName;

            try
            {
                BES.Entities.PLU pModel = WSAL.WSPLU.GetModel(TestBOOKID);
                LoadDataByModel(pModel);
            }
            catch(Exception ex)
            {
                MessageBox.Show("加载数据失败:" + ex.Message);
                this.Dispose();
            }
            #endregion
            _waitform.Hide();
        }

        #region COMBOX选择值变化时修改相应编码
        //private void cbDEPARTMENT_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cbDEPARTMENT.SelectedValue != null && cbDEPARTMENT.SelectedValue.ToString() != "System.Data.DataRowView")
        //    {
        //        tbDEPARTMENT.Text = cbDEPARTMENT.SelectedValue.ToString();
        //    }
        //}

        //private void cbCLASS_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cbCLASS.SelectedValue != null && cbCLASS.SelectedValue.ToString() != "System.Data.DataRowView")
        //    {
        //        tbCLASS.Text = cbCLASS.SelectedValue.ToString();
        //    }
        //}

        //private void cbPYSTYPE_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cbPYSTYPE.SelectedValue != null && cbPYSTYPE.SelectedValue.ToString() != "System.Data.DataRowView")
        //    {
        //        tbPYSTYPE.Text = cbPYSTYPE.SelectedValue.ToString();
        //    }
        //}

        //private void cbFRANCHISEE_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cbFRANCHISEE.SelectedValue != null && cbFRANCHISEE.SelectedValue.ToString() != "System.Data.DataRowView")
        //    {
        //        tbFRANCHISEE.Text = cbFRANCHISEE.SelectedValue.ToString();
        //    }
        //}
        #endregion

        #region 通用方法
        private bool CheckData()
        {
            if(String.IsNullOrEmpty(tbISBN.Text.Trim()))
            {
                MessageBox.Show("ISBN不能为空！");
                tbISBN.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(tbTITLE.Text.Trim()))
            {
                MessageBox.Show("书名不能为空！");
                tbTITLE.Focus();
                return false;
            }

            if (cbDEPARTMENT.SelectedValue == null || String.IsNullOrEmpty(cbDEPARTMENT.SelectedValue.ToString()))
            {
                MessageBox.Show("一级不能为空！");
                cbDEPARTMENT.Focus();
                return false;
            }

            if (cbCLASS.Value == null || String.IsNullOrEmpty(cbCLASS.Value.ToString()) || String.IsNullOrEmpty(tbCLASS.Text.Trim()))
            {
                MessageBox.Show("中图法分类不能为空！");
                cbCLASS.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(tbRDIS.Text.Trim()))
            {
                MessageBox.Show("请输入发货折扣！");
                tbRDIS.Focus();
                return false;
            }
            else
            {
                try
                {
                    if (Convert.ToDecimal(tbRDIS.Text) > 100 || Convert.ToDecimal(tbRDIS.Text) <= 0)
                    {
                        MessageBox.Show("发货折扣为0~100之间的小数！");
                        tbRDIS.Focus();
                        return false;
                    }
                }
                catch
                {
                    MessageBox.Show("发货折扣为0~100之间的小数！");
                    tbRDIS.Focus();
                    return false;
                }
            }

            if (cbPublisher.Value == null || String.IsNullOrEmpty(cbPublisher.Value.ToString()))
            {
                MessageBox.Show("货品种类不能为空！");
                cbPublisher.Focus();
                return false;
            }
            //if (String.IsNullOrEmpty(tbFRANCHISEE.Text.Trim()))
            //{
            //    MessageBox.Show("经销商不能为空！");
            //    cbFRANCHISEE.Focus();
            //    return false;
            //}
            return true;
        }

        private BES.Entities.PLU GetModel()
        {
            BES.Entities.PLU pluModel=new BES.Entities.PLU();
            pluModel.AUTHOR=tbAUTHOR.Text;
            pluModel.BINDING = cbBINDING.SelectedValue.ToString();
            pluModel.BKSIZE = cbBKSIZE.SelectedValue.ToString();
            try
            {
                pluModel.CLSCODE = cbCLASS.Text.ToString();
            }
            catch
            { }
            pluModel.CREATBY=LoginForm.DevCache.DevUser.UserName;
            pluModel.CREDATE = LoginForm.DevCache.LoginTime.Date;
            pluModel.DPTCODE = cbDEPARTMENT.SelectedValue.ToString();
            try
            {
                pluModel.EDITION = Convert.ToInt32(tbEDITION.Text);
            }
            catch
            {
                pluModel.EDITION = 0;
            }
            pluModel.EXTCODE = "";//书号延长码
            pluModel.FRANCHISEE = LoginForm.DevCache.DevUser.UserCompanyCode;
            pluModel.FULLCAT = "";//CIP分类号
            pluModel.HIPRICE = 0m;
            pluModel.ISABOOK = 9;//9是书
            pluModel.ISBN = tbISBN.Text;
            if (cbISBN.Checked)
            {
                pluModel.ISISBN = 0;
            }
            else
            {
                pluModel.ISISBN = 1;
            }
            pluModel.ISUSED = 0;
            pluModel.MODBY = LoginForm.DevCache.DevUser.UserName;
            pluModel.MODDATE= LoginForm.DevCache.LoginTime.Date;
            try
            {
                pluModel.NPRINT = Convert.ToInt32(tbNPRINT.Text);
            }
            catch
            {
                pluModel.NPRINT = 0;
            }
            try
            {
                pluModel.PAGES = Convert.ToInt32(tbPAGES.Text);
            }
            catch
            {
                pluModel.PAGES = 0;
            }
            pluModel.PKPC = 0;
            try
            {
                pluModel.PKQTY = Convert.ToInt32(tbPKQTY.Text);
            }
            catch
            {
                pluModel.PKQTY = 0;
            }
            pluModel.PKSTYLE = String.Empty;
            pluModel.PKWT = 0;
            pluModel.PLUCODE = TestBOOKID;
            try
            {
                pluModel.PRICE = Convert.ToDecimal(tbPRICE.Text);
            }
            catch
            {
                pluModel.PRICE = 0;
            }
            pluModel.PUBDATE = dtpPUBDATE.Value.Date;
            try
            {
                pluModel.PUBLISHER = cbPublisher.Value.ToString();
            }
            catch
            { }
            try
            {
                pluModel.PYSTYPE = cbPYSTYPE.SelectedValue.ToString();//版别
            }
            catch
            { }
            try
            {
                pluModel.RDISC = Convert.ToDecimal(tbRDIS.Text);
            }
            catch
            {
                pluModel.RDISC = 0m;
            }
            pluModel.SERIES = tbSERIES.Text;
            pluModel.SIJIAOHAO = pluModel.PLUCODE;
            pluModel.TITLE = tbTITLE.Text;
            pluModel.TRANSLATOR = tbTRANSLATOR.Text;
            try
            {
                pluModel.WORDS = Convert.ToInt32(tbWORDS.Text);
            }
            catch
            {
                pluModel.WORDS = 0;
            }
            pluModel.DuZheDingWei = tbDuZheDingWei.Text;
            pluModel.ShangJiaJianYi = tbShangJiaJianYi.Text;
            pluModel.MaiDian = tbMaiDian.Text;
            pluModel.JianJie = tbJianJie.Text;
            return pluModel;
        }

        private void SaveData()
        {
            try
            {
                if (WSAL.WSPLU.Update(GetModel()))
                {
                    MessageBox.Show("修改成功！");
                }
                else
                {
                    MessageBox.Show("修改失败！");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("发生异常:" + ex.Message);
            }
        }

        private void SetReadOnly()
        {
            cbPYSTYPE.Enabled = false;
            tbAUTHOR.ReadOnly = true;
            //tbBINDING.ReadOnly = true;
            //tbBKSIZE.ReadOnly = true;
            //tbCLASS.ReadOnly = true;
            //tbDEPARTMENT.ReadOnly = true;
            tbEDITION.ReadOnly = true;
            //tbFRANCHISEE.ReadOnly = true;
            tbISBN.ReadOnly = true;
            tbNPRINT.ReadOnly = true;
            tbPAGES.ReadOnly = true;
            //tbBINDING.ReadOnly = true;
            tbPRICE.ReadOnly = true;
            dtpPUBDATE.Enabled = true;
            //tbPUBLISHER.ReadOnly = true;
            //tbPYSTYPE.ReadOnly = true;
            tbRDIS.ReadOnly = true;
            tbSERIES.ReadOnly = true;
            tbTITLE.ReadOnly = true;
            tbTRANSLATOR.ReadOnly = true;
            tbWORDS.ReadOnly = true;
            tbDuZheDingWei.ReadOnly = true;
            tbShangJiaJianYi.ReadOnly = true;
            tbShangJiaJianYi.ReadOnly = true;
            tbMaiDian.ReadOnly = true;
            tbJianJie.ReadOnly = true;

            dtpPUBDATE.Enabled = false;
            tbNPRINTCount.ReadOnly = true;
            tbNPRINT.ReadOnly = true;

            cbBINDING.Enabled = false;
            cbBKSIZE.Enabled = false;
            cbCLASS.Enabled = false;
            cbDEPARTMENT.Enabled = false;
            //cbFRANCHISEE.Enabled = false;
            cbISBN.Enabled = false;
            cbPublisher.Enabled = false;

            tsbDelete.Visible = false;
            tsbSave.Visible = false;
            tsbUploadPhoto.Visible = false;
            pbCover.DoubleClick += new EventHandler(pbCover_DoubleClick2);
        }

        void pbCover_DoubleClick2(object sender, EventArgs e)
        {
            MessageBox.Show("没有权限编辑图片!");
        }

        private void SetEditable()
        {
            tbAUTHOR.ReadOnly = false;
            //tbBINDING.ReadOnly = false;
            //tbBKSIZE.ReadOnly = false;
            //tbCLASS.ReadOnly = false;
            //tbDEPARTMENT.ReadOnly = false;
            tbEDITION.ReadOnly = false;
            //tbFRANCHISEE.ReadOnly = false;
            tbISBN.ReadOnly = false;
            tbNPRINT.ReadOnly = false;
            tbPAGES.ReadOnly = false;
            //tbBINDING.ReadOnly = false;
            tbPRICE.ReadOnly = false;
            dtpPUBDATE.Enabled = false;
            //tbPUBLISHER.ReadOnly = true;
            //tbPYSTYPE.ReadOnly = false;
            tbRDIS.ReadOnly = false;
            tbSERIES.ReadOnly = false;
            tbTITLE.ReadOnly = false;
            tbTRANSLATOR.ReadOnly = false;
            tbWORDS.ReadOnly = false;
            tbDuZheDingWei.ReadOnly = false;
            tbShangJiaJianYi.ReadOnly = false;
            tbShangJiaJianYi.ReadOnly = false;
            tbMaiDian.ReadOnly = false;
            tbJianJie.ReadOnly = false;

            dtpPUBDATE.Enabled = true;
            tbNPRINT.ReadOnly = false;

            cbBINDING.Enabled = true;
            cbBKSIZE.Enabled = true;
            cbCLASS.Enabled = true;
            cbDEPARTMENT.Enabled = true;
            //cbFRANCHISEE.Enabled = true;
            cbISBN.Enabled = true;
            cbPublisher.Enabled = true;
        }

        private void SetEmpty()
        {
            
            tbAUTHOR.Text = String.Empty;
            //tbBINDING.Text = String.Empty;
            //tbBKSIZE.Text = String.Empty;
            //tbCLASS.Text = String.Empty;
            //tbDEPARTMENT.Text = String.Empty;
            tbEDITION.Text = String.Empty;
            //tbFRANCHISEE.Text = String.Empty;
            tbISBN.Text = String.Empty;
            tbNPRINT.Text = String.Empty;
            tbPAGES.Text = String.Empty;
            //tbBINDING.Text = String.Empty;
            tbPRICE.Text = String.Empty;
            dtpPUBDATE.Value = LoginForm.DevCache.LoginTime.Date;
            //tbPUBLISHER.Text = String.Empty;
            //tbPYSTYPE.Text = String.Empty;
            tbRDIS.Text = String.Empty;
            tbSERIES.Text = String.Empty;
            tbTITLE.Text = String.Empty;
            tbTRANSLATOR.Text = String.Empty;
            tbWORDS.Text = String.Empty;
            tbDuZheDingWei.Text = String.Empty;
            tbShangJiaJianYi.Text = String.Empty;
            tbShangJiaJianYi.Text = String.Empty;
            tbMaiDian.Text = String.Empty;
            tbJianJie.Text = String.Empty;

            dtpPUBDATE.Value = LoginForm.DevCache.LoginTime.Date;
            tbNPRINT.Text = String.Empty;

            cbBINDING.SelectedIndex = 0;
            cbBKSIZE.SelectedIndex = 0;
            //cbCLASS.SelectedIndex = 0;
            cbDEPARTMENT.SelectedIndex = 0;
            //cbFRANCHISEE.SelectedIndex = 0;
            //cbPublisher.SelectedIndex = 0;
            pbCover.Image = null;

            tsbSave.Enabled = true;
        }


        #endregion

        private void tsbSave_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                SaveData();
            }
        }

        #region 效验输入数字

        private void tbEDITION_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(tbEDITION.Text))
                {
                    Convert.ToInt32(tbEDITION.Text);
                }
            }
            catch
            {
                tbEDITION.Text = "0";
            }
        }

        private void tbPAGES_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(tbPAGES.Text))
                {
                    Convert.ToInt32(tbPAGES.Text);
                }

            }
            catch
            {
                tbPAGES.Text = "0";
            }
        }

        private void tbNPRINT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(tbNPRINT.Text))
                {
                    Convert.ToInt32(tbNPRINT.Text);
                }
            }
            catch
            {
                tbNPRINT.Text = "0";
            }
        }

        private void tbWORDS_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(tbWORDS.Text))
                {
                    Convert.ToInt32(tbWORDS.Text);
                }
            }
            catch
            {
                tbWORDS.Text = "0";
            }
        }

        private void tbNPRINTCount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(tbNPRINTCount.Text))
                {
                    Convert.ToInt32(tbNPRINTCount.Text);
                }
            }
            catch
            {
                tbNPRINTCount.Text = "0";
            }
        }

        private void tbPRICE_Leave(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(tbPRICE.Text))
                {
                    Convert.ToDecimal(tbPRICE.Text);
                }
            }
            catch
            {
                MessageBox.Show("定价必须是数字!");
                tbPRICE.Text = "";
                tbPRICE.Focus();
            }
        }


        #endregion

        private void tsbUploadPhoto_Click(object sender, EventArgs e)
        {
            //获取图片列表
            if (String.IsNullOrEmpty(TestBOOKID))
            {
                MessageBox.Show("请先保存图书信息 再进行图片上传！");
            }
            else
            {
                ImageList frmImageList = new ImageList(TestBOOKID);
                frmImageList.ShowDialog();
                try
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(WSAL.WSPLU.GetCover(TestBOOKID));
                    pbCover.Image = Image.FromStream(ms);
                }
                catch
                {
                    pbCover.Image = null;
                }
            }
        }

        private void LoadDataByModel(BES.Entities.PLU pMode)
        {
            if (pMode.FRANCHISEE != LoginForm.DevCache.DevUser.UserCompanyCode)
            {
                pbCover.DoubleClick -= new EventHandler(pbCover_DoubleClick);
                SetReadOnly();
            }
            else
            {
                pbCover.DoubleClick += new EventHandler(pbCover_DoubleClick);
            }
            TestBOOKID = pMode.PLUCODE;
            tbAUTHOR.Text = pMode.AUTHOR;
            //tbBINDING.Text = pMode.BINDING;
            try
            {
                cbBINDING.SelectedValue = pMode.BINDING;
            }
            catch
            {
                cbBINDING.Text = String.Empty;
            }
            //tbBKSIZE.Text = pMode.BKSIZE;
            //cbBKSIZE.SelectedValue = pMode.BKSIZE;
            try
            {
                cbBKSIZE.SelectedValue = pMode.BKSIZE;
            }
            catch
            {
                cbBKSIZE.Text = String.Empty;
            }
            //tbCLASS.Text = String.Empty;
            //cbCLASS.SelectedText = String.Empty;
            cbCLASS.SelectAll();
            cbCLASS.SelectedText = pMode.CLSCODE;
            //tbDEPARTMENT.Text = String.Empty;
            cbDEPARTMENT.SelectedValue = pMode.DPTCODE;
            tbEDITION.Text = pMode.EDITION.ToString();
            //cbFRANCHISEE.SelectedValue = pMode.FRANCHISEE;
            tbISBN.Text = pMode.ISBN;
            if (pMode.ISISBN == 0)
            {
                cbISBN.Checked = true;
            }
            tbNPRINT.Text = pMode.NPRINT.ToString();
            tbPAGES.Text = pMode.PAGES.ToString();
            tbPRICE.Text = pMode.PRICE.ToString();
            dtpPUBDATE.Value = pMode.PUBDATE.Date;
            //tbPUBLISHER.Text = LoginForm.DevCache.DevUser.UserCompanyName;
            
            try
            {
                cbPublisher.Value = pMode.PUBLISHER;//版别
            }
            catch
            { }
            if (pMode.FRANCHISEE != LoginForm.DevCache.DevUser.UserCompanyCode)
            {
                tbRDIS.Text = String.Empty;
            }
            else
            {
                tbRDIS.Text = pMode.RDISC.ToString();
            }
            tbSERIES.Text = pMode.SERIES;
            tbTITLE.Text = pMode.TITLE;
            tbTRANSLATOR.Text = pMode.TRANSLATOR;
            tbWORDS.Text = pMode.WORDS.ToString();
            tbDuZheDingWei.Text = pMode.DuZheDingWei;
            tbShangJiaJianYi.Text = pMode.ShangJiaJianYi;
            tbMaiDian.Text = pMode.MaiDian;
            tbJianJie.Text = pMode.JianJie;
            try
            {
                cbPYSTYPE.SelectedValue = pMode.PYSTYPE;//版别
            }
            catch
            { }
            //cbBINDING.SelectedIndex = 0;
            //cbBKSIZE.SelectedIndex = 0;
            //cbCLASS.SelectedIndex = 0;
            //cbDEPARTMENT.SelectedIndex = 0;
            //cbFRANCHISEE.SelectedIndex = 0;
            //cbPYSTYPE.SelectedIndex = 0;
            tsbSave.Enabled = true;

            tbCREATBY.Text = pMode.CREATBY;
            tbCREDATE.Text = pMode.CREDATE.ToString("yyyy-MM-dd");
            tbMODBY.Text = pMode.MODBY;
            tbMODDATE.Text = pMode.MODDATE.ToString("yyyy-MM-dd");
            tbPKQTY.Text = pMode.PKQTY.ToString();
            //cbPYSTYPE.SelectedValue=pMode.PYSTYPE;//版别
            try
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream(WSAL.WSPLU.GetCover(pMode.PLUCODE));
                pbCover.Image = Image.FromStream(ms);
            }
            catch
            { }
        }


        private void tsbNew_Click(object sender, EventArgs e)
        {
            AddBook frmAddBook = new AddBook();
            frmAddBook.WindowState = FormWindowState.Maximized;
            frmAddBook.MdiParent = this.MdiParent;
            frmAddBook.Show();

        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认删除当前项？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (WSAL.WSPLU.Delete(TestBOOKID))
                {
                    MessageBox.Show("删除成功！");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("删除失败！");
                    return;
                }
                
            }
        }

        private void tsbExit_Click(object sender, EventArgs e)
        {
            ////if (MessageBox.Show("确认退出？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            ////{
            ////    this.Dispose();
            ////}
            this.Dispose();
        }

        private void tbJianJie_DoubleClick(object sender, EventArgs e)
        {
            ShowText frmShowText = new ShowText(tbJianJie.Text);
            frmShowText.ShowDialog();
        }

        private void pbCover_DoubleClick(object sender, EventArgs e)
        {
            //获取图片列表
            if (String.IsNullOrEmpty(TestBOOKID))
            {
                MessageBox.Show("请先保存图书信息 再进行图片上传！");
            }
            else
            {
                ImageList frmImageList = new ImageList(TestBOOKID);
                frmImageList.ShowDialog();
                try
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(WSAL.WSPLU.GetCover(TestBOOKID));
                    pbCover.Image = Image.FromStream(ms);
                }
                catch
                {
                    pbCover.Image = null;
                }
            }
        }

        //private void cbCLASS_TextChanged(object sender, EventArgs e)
        //{
        //    if (!String.IsNullOrEmpty(cbCLASS.Text))
        //    {
        //        try
        //        {
        //            tbCLASS.Text = cbCLASS.SelectedValue.ToString();
        //        }
        //        catch
        //        {
        //            tbCLASS.Text = String.Empty;
        //        }

        //    }
        //    else
        //    {
        //        tbCLASS.Text = String.Empty;
        //    }
        //}

        private void tbRDIS_TextChanged(object sender, EventArgs e)
        {
            if (tbRDIS.Text.Contains("-"))
            {
                tbRDIS.Text = tbRDIS.Text.Trim('-');
            }
        }

        private void tbRDIS_Leave(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDecimal(tbRDIS.Text);
            }
            catch
            {
                MessageBox.Show("发货折扣为0~100之间的小数！");
                tbRDIS.Text = "";
                tbRDIS.Focus();
            }
        }

        private void cbCLASS_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //if (cbCLASS.SelectedText == cbCLASS.Value.ToString())
                //{
                //    tbCLASS.Text = String.Empty;
                //}
                //else
                //{
                tbCLASS.Text = cbCLASS.Value.ToString();
                //}
            }
            catch
            {
                tbCLASS.Text = String.Empty;
            }
        }

        private void tbPKQTY_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(tbPKQTY.Text))
                {
                    Convert.ToInt32(tbPKQTY.Text);
                }
            }
            catch
            {
                tbPKQTY.Text = "";
            }
        }

    }
}