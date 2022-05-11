using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace BES.Forms.BookManager
{
    public partial class ImageList : Form
    {
        private readonly WaitForm _waitform = new WaitForm();
        private String _BookID;
        public ImageList(String BookID)
        {
            InitializeComponent();
            _BookID = BookID;
        }

        private void ImageList_Load(object sender, EventArgs e)
        {
            _waitform.sValue = "加载中.......";
            _waitform.Show();
            try
            {
                DataSet dsTemp = WSAL.WSPLU.GetImageList(_BookID);
                if (dsTemp != null && dsTemp.Tables[0] != null && dsTemp.Tables[0].Rows.Count > 0)
                {
                    //dgvImageList.DataSource = dsTemp.Tables[0];
                    foreach (DataRow dr in dsTemp.Tables[0].Rows)
                    {
                        int iIndex = dgvImageList.Rows.Add();
                        dgvImageList.Rows[iIndex].Cells["PhotoID"].Value = dr["FileID"];
                        dgvImageList.Rows[iIndex].Cells["PhotoName"].Value = dr["PhotoFileName"];
                        dgvImageList.Rows[iIndex].Cells["Remarks"].Value = dr["Remarks"];
                        if (dr["IsCover"] != null)
                        {
                            if (dr["IsCover"].ToString().ToLower() == "true")
                            {
                                (dgvImageList.Rows[iIndex].Cells["ISCOVER"] as DataGridViewCheckBoxCell).Value = true;
                                (dgvImageList.Rows[iIndex].Cells["ISCOVER"] as DataGridViewCheckBoxCell).Selected = true;
                            }
                        }

                        try
                        {
                            dgvImageList.Rows[iIndex].Cells["PHOTO"].Tag=(byte[])dr["Photo"];
                        }
                        catch
                        { }

                        //ISCOVER
                        try
                        {
                            System.IO.MemoryStream ms = new System.IO.MemoryStream((byte[])dr["Photo"]);
                            
                            dgvImageList.Rows[iIndex].Cells["PHOTO"].Value = System.Drawing.Image.FromStream(ms);
                        }
                        catch
                        { }


                    }
                    //foreach (DataGridViewRow dgvr in dgvImageList.Rows)
                    //{
                    //    try
                    //    {
                    //        System.IO.MemoryStream ms = new System.IO.MemoryStream((byte[])dgvr.Cells["PHOTOvalue"].Value);
                            
                    //    }
                    //    catch
                    //    { }
                    //}
                }
            }
            catch
            {
                _waitform.Hide();
                MessageBox.Show("加载失败！");
                this.Dispose();
            }
            _waitform.Hide();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog frmOFG = new OpenFileDialog();
            frmOFG.Multiselect = false;
            frmOFG.Filter = "图片格式|*.jpg;*.jpeg;*.bmp;*.png;*.gif";
            if (frmOFG.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    String photoFilePaht = frmOFG.FileName;
                    FileInfo file = new FileInfo(photoFilePaht);
                    if (file.Length > 5*1024 * 1024)
                    {
                        MessageBox.Show("选择的文件太大！");
                    }
                    else
                    {
                        int iIndex=dgvImageList.Rows.Add();
                        dgvImageList.Rows[iIndex].Cells["PhotoID"].Value = Guid.NewGuid().ToString();
                        dgvImageList.Rows[iIndex].Cells["PhotoName"].Value = frmOFG.SafeFileName;
                        dgvImageList.Rows[iIndex].Cells["PHOTO"].Value = Image.FromFile(photoFilePaht);

                        FileStream fs = new FileStream(photoFilePaht, FileMode.Open, FileAccess.Read);
                        Byte[] bByte = new byte[fs.Length];
                        fs.Read(bByte, 0, Convert.ToInt32(fs.Length));
                        fs.Close();
                        dgvImageList.Rows[iIndex].Cells["PHOTO"].Tag = bByte;
                    }
                    //Image pImage = Image.FromFile(photoFilePaht);
                    //Bitmap bitmap = new Bitmap(pImage, new Size(pbPhotoView.Width, pbPhotoView.Height));
                    //pbPhotoView.Image = bitmap;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("加载图片失败：" + ex.Message, "GIS系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            if (dgvImageList.Rows.Count <= 0)
            {
                MessageBox.Show("请添加图片进行保存！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                List<BES.Entities.PhotoFile> lstPhotoFile = new List<BES.Entities.PhotoFile>();
                foreach (DataGridViewRow dgvr in dgvImageList.Rows)
                {
                    BES.Entities.PhotoFile pFile = new BES.Entities.PhotoFile();
                    pFile.BookID = this._BookID;
                    pFile.FileID = pFile.PhotoFileName = dgvr.Cells["PhotoID"].Value.ToString();
                    if ((dgvr.Cells["ISCOVER"] as DataGridViewCheckBoxCell).Value == null)
                    {
                        pFile.IsCover = false;
                    }
                    else
                    {
                        pFile.IsCover = (bool)(dgvr.Cells["ISCOVER"] as DataGridViewCheckBoxCell).Value;
                    }
                    //pFile.Photo = (dgvr.Cells["PHOTO"].Value as Image).; Image.t
                    //MemoryStream ms = new MemoryStream();
                    //(dgvr.Cells["PHOTO"].Value as Image).Save(ms, ImageFormat.Jpeg);
                    pFile.Photo = (byte[])dgvr.Cells["PHOTO"].Tag;
                    pFile.PhotoFileName = dgvr.Cells["PhotoName"].Value.ToString();
                    if (dgvr.Cells["Remarks"].Value!=null)
                    {
                        pFile.Remarks = dgvr.Cells["Remarks"].Value.ToString();
                    }
                    else
                    {
                        pFile.Remarks = String.Empty;
                    }
                    lstPhotoFile.Add(pFile);
                }
                try
                {
                    if (WSAL.WSPLU.AddImageList(lstPhotoFile))
                    {
                        MessageBox.Show("保存成功！！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("保存失败！！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("保存过程发生错误："+ex.Message+" 请检查！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (dgvImageList.SelectedRows.Count <= 0)
            {
                MessageBox.Show("请选择图片进行删除！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                foreach (DataGridViewRow dgvr in dgvImageList.SelectedRows)
                {
                    dgvImageList.Rows.Remove(dgvr);
                }
            }
        }

        private void dgvImageList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 3)
                {
                    Image image = dgvImageList.Rows[e.RowIndex].Cells["PHOTO"].Value as Image;
                    BES.Forms.Other.ViewPhoto frmViewPhoto = new BES.Forms.Other.ViewPhoto(image);
                    frmViewPhoto.ShowDialog();
                }
            }
            catch
            { }
        }

        private void dgvImageList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                DataGridViewCheckBoxCell chkCell=dgvImageList.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewCheckBoxCell;
                if (chkCell.Selected)
                {
                    for (int i = 0; i < dgvImageList.Rows.Count; i++)
                    {
                        if (i != e.RowIndex)
                        {
                            DataGridViewCheckBoxCell noChkCell = dgvImageList.Rows[i].Cells[e.ColumnIndex] as DataGridViewCheckBoxCell;
                            noChkCell.Value = false;
                        }
                    }
                }
            }
        }
    }
}