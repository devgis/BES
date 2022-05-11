using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace BES.Forms.BookManager
{
    public partial class AddBook : Form
    {
        String TestBOOKID = String.Empty;
        private int CurrentIndex = 0; //ָʾ��ǰλ��
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
        private List<BES.Entities.PLU> lisNotSaved = new List<BES.Entities.PLU>();
        private static List<BES.Entities.PLU> lisSaved = null;
        private List<BES.Entities.PLU> GetSaved()
        {
            if (lisSaved == null)
            {
                _waitform.sValue = "����������......";
                _waitform.Show();
                try
                {
                    lisSaved = WSAL.WSPLU.GetModelList("FRANCHISEE='" + LoginForm.DevCache.DevUser.UserCompanyCode + "'");
                }
                catch
                {
                    MessageBox.Show("���ؼ�¼ʧ�ܣ�");
                }
                _waitform.Hide();
            }
            return lisSaved;
        }
        
        public AddBook()
        {
            InitializeComponent();
        }

        private void AddBook_Load(object sender, EventArgs e)
        {
            this.Refresh();
            _waitform.sValue = "׼��������......";
            _waitform.Show();
            #region ��������
            //����� һ������
            cbDEPARTMENT.DataSource = LoginForm.DevCache.DevDataSet.Tables["DEPARTMENT"];
            cbDEPARTMENT.DisplayMember = "DPTNAME";
            cbDEPARTMENT.ValueMember =  "DPTCODE";

            //������ 
            //cbFRANCHISEE.DataSource = LoginForm.DevCache.DevDataSet.Tables["SALECOMPANY"];
            //cbFRANCHISEE.DisplayMember = "SHORTNAME";
            //cbFRANCHISEE.ValueMember =  "CODE";

            //С�� ��ͼ������
            cbCLASS.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            cbCLASS.DataSource = LoginForm.DevCache.DevDataSet.Tables["CLASS"];
            cbCLASS.DisplayMember = "CLSCODE";
            cbCLASS.ValueMember = "CLSNAME";

            //���
            cbPublisher.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
            cbPublisher.DataSource = LoginForm.DevCache.DevDataSet.Tables["COMPANY"];
            cbPublisher.DisplayMember = "NAME";
            cbPublisher.ValueMember = "CODE";

            //��Ʒ����
            cbPYSTYPE.DataSource = LoginForm.DevCache.DevDataSet.Tables["PYSTYPE"];
            cbPYSTYPE.DisplayMember = "DESCRIPT";
            cbPYSTYPE.ValueMember = "PYSTYPE";

            //װ֡��
            cbBINDING.DataSource = LoginForm.DevCache.DevDataSet.Tables["BINDING"];
            cbBINDING.DisplayMember = "DESCRIPT";
            cbBINDING.ValueMember =  "BINDING";

            //������
            cbBKSIZE.DataSource = LoginForm.DevCache.DevDataSet.Tables["SIZE"];
            cbBKSIZE.DisplayMember = "DESCRIPT";
            cbBKSIZE.ValueMember =  "BKSIZE";
            cbBINDING.Text = String.Empty;
            cbBKSIZE.Text = String.Empty;
            #region COMBOXѡ��ֵ�仯ʱ�޸���Ӧ����
            //if (cbDEPARTMENT.SelectedValue != null && cbDEPARTMENT.SelectedValue.ToString() != "System.Data.DataRowView")
            //{
            //    tbDEPARTMENT.Text = cbDEPARTMENT.SelectedValue.ToString();
            //}
            cbDEPARTMENT.Text = String.Empty;
            ///tbDEPARTMENT.Text = String.Empty;

            //if (cbCLASS.SelectedValue != null && cbCLASS.SelectedValue.ToString() != "System.Data.DataRowView")
            //{
            //    tbCLASS.Text = cbCLASS.SelectedValue.ToString();
            //}
            cbCLASS.Text = String.Empty;
            cbPYSTYPE.Text = String.Empty;
            //tbCLASS.Text = String.Empty;

            //if (cbBINDING.SelectedValue != null && cbBINDING.SelectedValue.ToString() != "System.Data.DataRowView")
            //{
            //    tbBINDING.Text = cbBINDING.SelectedValue.ToString();
            //}

            //if (cbBKSIZE.SelectedValue != null && cbBKSIZE.SelectedValue.ToString() != "System.Data.DataRowView")
            //{
            //    tbBKSIZE.Text = cbBKSIZE.SelectedValue.ToString();
            //}

            //if (cbPYSTYPE.SelectedValue != null && cbPYSTYPE.SelectedValue.ToString() != "System.Data.DataRowView")
            //{
            //    tbPYSTYPE.Text = cbPYSTYPE.SelectedValue.ToString();
            //}

            //if (cbFRANCHISEE.SelectedValue != null && cbFRANCHISEE.SelectedValue.ToString() != "System.Data.DataRowView")
            //{
            //    tbFRANCHISEE.Text = cbFRANCHISEE.SelectedValue.ToString();
            //}
        #endregion

            tbCREATBY.Text = LoginForm.DevCache.DevUser.UserName;
            tbCREDATE.Text = LoginForm.DevCache.LoginTime.ToString("yyyy-MM-dd");
            //tbPUBLISHER.Text = LoginForm.DevCache.DevUser.UserCompanyName;

            lisNotSaved.Add(GetModel());
            #endregion
            _waitform.Hide();
        }

        #region COMBOXѡ��ֵ�仯ʱ�޸���Ӧ����
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

        //private void cbBINDING_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cbBINDING.SelectedValue != null && cbBINDING.SelectedValue.ToString() != "System.Data.DataRowView")
        //    {
        //        tbBINDING.Text = cbBINDING.SelectedValue.ToString();
        //    }
        //}

        //private void cbBKSIZE_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cbBKSIZE.SelectedValue != null && cbBKSIZE.SelectedValue.ToString() != "System.Data.DataRowView")
        //    {
        //        tbBKSIZE.Text = cbBKSIZE.SelectedValue.ToString();
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

        #region ͨ�÷���
        private bool CheckData()
        {
            if(String.IsNullOrEmpty(tbISBN.Text.Trim()))
            {
                MessageBox.Show("ISBN����Ϊ�գ�");
                tbISBN.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(tbTITLE.Text.Trim()))
            {
                MessageBox.Show("��������Ϊ�գ�");
                tbTITLE.Focus();
                return false;
            }

            if (cbDEPARTMENT.SelectedValue==null|| String.IsNullOrEmpty(cbDEPARTMENT.SelectedValue.ToString()))
            {
                MessageBox.Show("һ������Ϊ�գ�");
                cbDEPARTMENT.Focus();
                return false;
            }

            if (cbBINDING.SelectedValue == null || String.IsNullOrEmpty(cbBINDING.SelectedValue.ToString()))
            {
                MessageBox.Show("��ѡ��װ֡��");
                cbBINDING.Focus();
                return false;
            }
            if (cbBKSIZE.SelectedValue == null || String.IsNullOrEmpty(cbBKSIZE.SelectedValue.ToString()))
            {
                MessageBox.Show("��ѡ�񿪱���");
                cbBKSIZE.Focus();
                return false;
            }

            if (cbCLASS.Value == null || String.IsNullOrEmpty(cbCLASS.Value.ToString())||String.IsNullOrEmpty(tbCLASS.Text.Trim()))
            {
                MessageBox.Show("��ͼ�����಻��Ϊ�գ�");
                cbCLASS.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(tbRDIS.Text.Trim()))
            {
                MessageBox.Show("�����뷢���ۿۣ�");
                tbRDIS.Focus();
                return false;
            }
            else
            {
                try
                {
                    if (Convert.ToDecimal(tbRDIS.Text) > 100 || Convert.ToDecimal(tbRDIS.Text) <= 0)
                    {
                        MessageBox.Show("�����ۿ�Ϊ0~100֮���С����");
                        tbRDIS.Focus();
                        return false;
                    }
                }
                catch
                {
                    MessageBox.Show("�����ۿ�Ϊ0~100֮���С����");
                    tbRDIS.Focus();
                    return false;
                }
            }

            if (cbPublisher.Value == null || String.IsNullOrEmpty(cbPublisher.Value.ToString()))
            {
                MessageBox.Show("��Ʒ���಻��Ϊ�գ�");
                cbPublisher.Focus();
                return false;
            }
            //if (String.IsNullOrEmpty(tbFRANCHISEE.Text.Trim()))
            //{
            //    MessageBox.Show("�����̲���Ϊ�գ�");
            //    cbFRANCHISEE.Focus();
            //    return false;
            //}
            return true;
        }

        private BES.Entities.PLU GetModel()
        {
            BES.Entities.PLU pluModel=new BES.Entities.PLU();
            pluModel.AUTHOR=tbAUTHOR.Text;
            pluModel.BINDING=cbBINDING.SelectedValue.ToString();
            pluModel.BKSIZE=cbBKSIZE.SelectedValue.ToString();
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
            pluModel.EXTCODE = "";//����ӳ���
            pluModel.FRANCHISEE = LoginForm.DevCache.DevUser.UserCompanyCode;
            pluModel.FULLCAT = "";//CIP�����
            pluModel.HIPRICE = 0m;
            pluModel.ISABOOK = 9;//9����
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
            if (String.IsNullOrEmpty(TestBOOKID))
            {
                pluModel.PLUCODE = Guid.NewGuid().ToString();
            }
            else
            {
                pluModel.PLUCODE = TestBOOKID;
            }
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
                pluModel.PYSTYPE = cbPYSTYPE.SelectedValue.ToString();//���
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
                BES.Entities.PLU modelPLU=GetModel();
                if (String.IsNullOrEmpty(TestBOOKID))
                {

                    if (WSAL.WSPLU.Add(modelPLU))
                    {
                        MessageBox.Show("����ɹ���");
                        GetSaved().Insert(0,modelPLU);
                        CurrentIndex = 1;
                        TestBOOKID = modelPLU.PLUCODE;
                        lisNotSaved[0] = new BES.Entities.PLU();
                    }
                    else
                    {
                        MessageBox.Show("����ʧ�ܣ�");
                    }
                }
                else
                {
                    modelPLU.PLUCODE = TestBOOKID;
                    modelPLU.SIJIAOHAO = TestBOOKID;
                    GetSaved()[CurrentIndex] = modelPLU;
                    if (WSAL.WSPLU.Update(modelPLU))
                    {
                        MessageBox.Show("�޸ĳɹ���");
                        //GetSaved()[CurrentIndex-1] = modelPLU;
                        //TestBOOKID = modelPLU.PLUCODE;
                    }
                    else
                    {
                        MessageBox.Show("�޸�ʧ�ܣ�");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("�����쳣:" + ex.Message);
            }
        }

        private void SetReadOnly()
        {
            //tbAUTHOR.ReadOnly = true;
            //tbBINDING.ReadOnly = true;
            //tbBKSIZE.ReadOnly = true;
            //tbCLASS.ReadOnly = true;
            //tbDEPARTMENT.ReadOnly = true;
            //tbEDITION.ReadOnly = true;
            //tbFRANCHISEE.ReadOnly = true;
            //tbISBN.ReadOnly = true;
            //tbNPRINT.ReadOnly = true;
            //tbPAGES.ReadOnly = true;
            //tbBINDING.ReadOnly = true;
            //tbPRICE.ReadOnly = true;
            //dtpPUBDATE.Enabled = true;
            //tbPUBLISHER.ReadOnly = true;
            //tbPYSTYPE.ReadOnly = true;
            //tbRDIS.ReadOnly = true;
            //tbSERIES.ReadOnly = true;
            //tbTITLE.ReadOnly = true;
            //tbTRANSLATOR.ReadOnly = true;
            //tbWORDS.ReadOnly = true;
            //tbDuZheDingWei.ReadOnly = true;
            //tbShangJiaJianYi.ReadOnly = true;
            //tbShangJiaJianYi.ReadOnly = true;
            //tbMaiDian.ReadOnly = true;
            //tbJianJie.ReadOnly=true;

            //dtpPUBDATE.Enabled = false;
            //tbNPRINTCount.ReadOnly = true;
            //tbNPRINT.ReadOnly = true;

            //cbBINDING.Enabled = false;
            //cbBKSIZE.Enabled = false;
            //cbCLASS.Enabled = false;
            //cbDEPARTMENT.Enabled = false;
            //cbFRANCHISEE.Enabled = false;
            //cbISBN.Enabled = false;
            //cbPYSTYPE.Enabled = false;
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

            cbBINDING.Text = String.Empty;
            cbBKSIZE.Text = String.Empty;
            //cbCLASS.SelectedIndex = 0;
            cbDEPARTMENT.Text = String.Empty;
            cbCLASS.Text = String.Empty;
            cbPublisher.Text = String.Empty;
            //cbFRANCHISEE.SelectedIndex = 0;
            //cbPublisher.SelectedIndex = 0;

            tbEDITION.Text = String.Empty;
            tbNPRINT.Text = String.Empty;
            tbPAGES.Text = String.Empty;
            tbNPRINTCount.Text = String.Empty;
            tbWORDS.Text = String.Empty;

            pbCover.Image = null;

            tsbSave.Enabled = true;
            TestBOOKID = String.Empty;
        }


        #endregion

        private void tsbSave_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                SaveData();
            }
        }

        #region Ч����������

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
                MessageBox.Show("���۱���������!");
                tbPRICE.Text = "";
                tbPRICE.Focus();
            }
        }

        #endregion

        private void tsbUploadPhoto_Click(object sender, EventArgs e)
        {
            //��ȡͼƬ�б�
            if (String.IsNullOrEmpty(TestBOOKID))
            {
                MessageBox.Show("���ȱ���ͼ����Ϣ �ٽ���ͼƬ�ϴ���");
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

        #region �����¼��ҳ
        private void LoadDateByIndex(ref int CurrentIndex)
        {
            BES.Entities.PLU pModel;
            if (CurrentIndex <= 0)
            {
                if (Math.Abs(CurrentIndex) + 1 > lisNotSaved.Count)
                {
                    TestBOOKID = String.Empty;
                    MessageBox.Show("��ǰ��¼�Ѿ��ǵ�һҳ��");
                    CurrentIndex = CurrentIndex + 1;
                    return;
                }
                else
                {
                    SetEditable();
                    TestBOOKID = String.Empty;
                    //tsbDelete.Enabled = true;
                    //tsbSave.Enabled = true;
                    pModel = lisNotSaved[Math.Abs(CurrentIndex)];
                    LoadDataByModel(pModel);
                }
            }
            else
            {
                if (CurrentIndex == 0)
                {
                    SetEditable();
                    TestBOOKID = String.Empty;
                    //tsbDelete.Enabled = true;
                    //tsbSave.Enabled = true;
                    pModel = lisNotSaved[0];
                    CurrentIndex = 0;
                    LoadDataByModel(pModel);
                }
                else
                {
                    if (GetSaved() == null || GetSaved().Count == 0)
                    {
                        MessageBox.Show("��ǰ��¼�Ѿ������һҳ��");
                        CurrentIndex = CurrentIndex -1;
                        return;
                    }
                    else
                    {
                        SetReadOnly();
                        //tsbDelete.Enabled = false;
                        //tsbSave.Enabled = false;
                        pModel = GetSaved()[CurrentIndex-1];
                        LoadDataByModel(pModel);
                    }
                }
            }
        }

        private void LoadDataByModel(BES.Entities.PLU pMode)
        {

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
            cbPublisher.Value = pMode.PUBLISHER;
            tbRDIS.Text = pMode.RDISC.ToString();
            tbSERIES.Text = pMode.SERIES;
            tbTITLE.Text = pMode.TITLE;
            tbTRANSLATOR.Text = pMode.TRANSLATOR;
            tbWORDS.Text = pMode.WORDS.ToString();
            tbDuZheDingWei.Text = pMode.DuZheDingWei;
            tbShangJiaJianYi.Text = pMode.ShangJiaJianYi;
            tbMaiDian.Text = pMode.MaiDian;
            tbJianJie.Text = pMode.JianJie;

            tbCREATBY.Text = pMode.CREATBY;
            tbCREDATE.Text = pMode.CREDATE.ToString("yyyy-MM-dd");
            tbMODBY.Text = pMode.MODBY;
            tbMODDATE.Text = pMode.MODDATE.ToString("yyyy-MM-dd");
            //cbBINDING.SelectedIndex = 0;
            //cbBKSIZE.SelectedIndex = 0;
            //cbCLASS.SelectedIndex = 0;
            //cbDEPARTMENT.SelectedIndex = 0;
            //cbFRANCHISEE.SelectedIndex = 0;
            //cbPYSTYPE.SelectedIndex = 0;
            tbPKQTY.Text = pMode.PKQTY.ToString();
            tsbSave.Enabled = true;
            try
            {
                cbPYSTYPE.SelectedValue = pMode.PYSTYPE;//���
            }
            catch
            { }

            try
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream(WSAL.WSPLU.GetCover(pMode.PLUCODE));
                pbCover.Image = Image.FromStream(ms);
            }
            catch
            {
                pbCover.Image = null;
            }
        }

        private void tsbFirst_Click(object sender, EventArgs e)
        {
            try
            {
                //dgvSameISBN.Rows.Clear();
                dgvSameISBN.DataSource = null;
            }
            catch
            { }

            if (CurrentIndex <= 0)
            {
                lisNotSaved[Math.Abs(CurrentIndex)] = GetModel();
            }
            CurrentIndex = 1-lisNotSaved.Count;
            LoadDateByIndex(ref CurrentIndex);
        }

        private void tsbPrevious_Click(object sender, EventArgs e)
        {
            try
            {
                //dgvSameISBN.Rows.Clear();
                dgvSameISBN.DataSource = null;
            }
            catch
            { }

            if (CurrentIndex <= 0)
            {
                lisNotSaved[Math.Abs(CurrentIndex)] = GetModel();
            }
            CurrentIndex = CurrentIndex-1;
            LoadDateByIndex(ref CurrentIndex);
        }

        private void tsbNext_Click(object sender, EventArgs e)
        {
            try
            {
                //dgvSameISBN.Rows.Clear();
                dgvSameISBN.DataSource = null;
            }
            catch
            { }


            if (CurrentIndex <= 0)
            {
                lisNotSaved[Math.Abs(CurrentIndex)] = GetModel();
            }
            if (CurrentIndex >= GetSaved().Count)
            {
                MessageBox.Show("�Ѿ������һ����¼��");
                return;
            }
            else
            {
                CurrentIndex = CurrentIndex + 1;
            }
            LoadDateByIndex(ref CurrentIndex);
        }

        private void tsbLast_Click(object sender, EventArgs e)
        {
            try
            {
                //dgvSameISBN.Rows.Clear();
                dgvSameISBN.DataSource = null;
            }
            catch
            { }

            //if (CurrentIndex <= 0)
            //{
            //    lisNotSaved[Math.Abs(CurrentIndex)] = GetModel();
            //}
            if (GetSaved() == null || GetSaved().Count == 0)
            {
                MessageBox.Show("�Ѿ������һҳ��");
                return;
            }
            else
            {
                CurrentIndex = GetSaved().Count;
            }
            LoadDateByIndex(ref CurrentIndex);
        }
        #endregion

        private void tsbNew_Click(object sender, EventArgs e)
        {
            if (CurrentIndex > 0)
            {
                CurrentIndex = 0;
                SetEmpty();
                SetEditable();
            }
            else
            {
                lisNotSaved[Math.Abs(CurrentIndex)] = GetModel();
                SetEmpty();
                SetEditable();
            }

            lisNotSaved.Insert(Math.Abs(CurrentIndex), GetModel());
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ȷ��ɾ����ǰ�", "ϵͳ��ʾ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (CurrentIndex <= 0)
                {
                    SetEmpty();
                    return;
                }
                if (String.IsNullOrEmpty(TestBOOKID))
                {
                    if (lisNotSaved.Count > 1)
                    {
                        lisNotSaved.RemoveAt(Math.Abs(CurrentIndex));
                        CurrentIndex = CurrentIndex + 1;
                    }
                    else
                    {
                        SetEmpty();
                        lisNotSaved[0] = GetModel();
                        CurrentIndex = 0;
                    }
                    
                }
                else
                {
                    if (WSAL.WSPLU.Delete(TestBOOKID))
                    {
                        GetSaved().RemoveAt(CurrentIndex-1);
                        if (CurrentIndex < GetSaved().Count)
                        {
                            CurrentIndex = CurrentIndex - 1;
                        }
                        else
                        {
                            CurrentIndex = GetSaved().Count;
                        }
                    }
                    else
                    {
                        MessageBox.Show("ɾ��ʧ�ܣ�");
                        return;
                    }
                    //�����ݿ�ɾ��
                }
                MessageBox.Show("ɾ���ɹ���");
                LoadDateByIndex(ref CurrentIndex);
            }
        }

        private void tsbCancel_Click(object sender, EventArgs e)
        {
            LoadDateByIndex(ref CurrentIndex);
        }

        private void tsbExit_Click(object sender, EventArgs e)
        {
            //if (lisNotSaved.Count > 0)
            //{
            //    if (MessageBox.Show("��ǰ��δ�����ȷ���˳���", "ϵͳ��ʾ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            //    {
            //        this.Dispose();
            //    }
            //}
            this.Dispose();
        }

        private void tbISBN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _waitform.sValue = "����������......";
                _waitform.Show();
                try
                {
                    dgvSameISBN.DataSource = WSAL.WSPLU.GetListByISBN(tbISBN.Text).Tables[0];
                    dgvSameISBN.Update();
                }
                catch
                {
                    _waitform.Hide();
                    MessageBox.Show("����ʧ�ܣ�");
                }
                _waitform.Hide();
            }
        }

        private void tbJianJie_DoubleClick(object sender, EventArgs e)
        {
            ShowText frmShowText = new ShowText(tbJianJie.Text);
            frmShowText.ShowDialog();
        }

        private void pbCover_DoubleClick(object sender, EventArgs e)
        {
            //��ȡͼƬ�б�
            if (String.IsNullOrEmpty(TestBOOKID))
            {
                MessageBox.Show("���ȱ���ͼ����Ϣ �ٽ���ͼƬ�ϴ���");
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
            //if (!String.IsNullOrEmpty(cbCLASS.Text))
            //{
            //    try
            //    {
            //        tbCLASS.Text = cbCLASS.SelectedValue.ToString();
            //    }
            //    catch
            //    {
            //        tbCLASS.Text = String.Empty;
            //    }

            //}
            //else
            //{
            //    tbCLASS.Text = String.Empty;
            //}
        }

        private void tbRDIS_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDecimal(tbRDIS.Text) > 100 || CurrentIndex < 0)
                {
                    MessageBox.Show("�����ۿ�Ϊ0~100֮���С����");
                    tbRDIS.Text = "";
                    tbRDIS.Focus();
                }
            }
            catch
            {
                MessageBox.Show("�����ۿ�Ϊ0~100֮���С����");
                tbRDIS.Text = "";
                tbRDIS.Focus();
            }
        }

        private void tbISBN_Leave(object sender, EventArgs e)
        {
            _waitform.sValue = "����������......";
            _waitform.Show();
            try
            {
                dgvSameISBN.DataSource = WSAL.WSPLU.GetListByISBN(tbISBN.Text).Tables[0];
                dgvSameISBN.Update();
            }
            catch
            {
                _waitform.Hide();
                MessageBox.Show("����ʧ�ܣ�");
            }
            _waitform.Hide();
        }

        private void dgvSameISBN_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            { return; }
            else
            {

                if (dgvSameISBN.Rows[e.RowIndex].Cells["BOOKID"].Value != null && !String.IsNullOrEmpty(dgvSameISBN.Rows[e.RowIndex].Cells["BOOKID"].Value.ToString()))
                {
                    try
                    {
                        ViewEditBook frmViewEditBook = new ViewEditBook(dgvSameISBN.Rows[e.RowIndex].Cells["BOOKID"].Value.ToString());
                        frmViewEditBook.WindowState = FormWindowState.Maximized;
                        frmViewEditBook.MdiParent = this.MdiParent;
                        frmViewEditBook.Show();
                    }
                    catch
                    { }
                }
            }
        }

        private void tbRDIS_TextChanged(object sender, EventArgs e)
        {
            if (tbRDIS.Text.Contains("-"))
            {
                tbRDIS.Text=tbRDIS.Text.Trim('-');
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