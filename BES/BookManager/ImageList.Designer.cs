namespace BES.Forms.BookManager
{
    partial class ImageList
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageList));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.pMain = new System.Windows.Forms.Panel();
            this.dgvImageList = new System.Windows.Forms.DataGridView();
            this.PhotoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhotoName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PHOTO = new System.Windows.Forms.DataGridViewImageColumn();
            this.ISCOVER = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.pMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImageList)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.tsbDelete,
            this.tsbSave});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(687, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            this.tsbAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdd.Image")));
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(67, 22);
            this.tsbAdd.Text = "添加(&A)";
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(67, 22);
            this.tsbDelete.Text = "删除(&D)";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // tsbSave
            // 
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(67, 22);
            this.tsbSave.Text = "保存(&S)";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // pMain
            // 
            this.pMain.Controls.Add(this.dgvImageList);
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(0, 25);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(687, 299);
            this.pMain.TabIndex = 1;
            // 
            // dgvImageList
            // 
            this.dgvImageList.AllowUserToAddRows = false;
            this.dgvImageList.AllowUserToDeleteRows = false;
            this.dgvImageList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImageList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PhotoID,
            this.PhotoName,
            this.Remarks,
            this.PHOTO,
            this.ISCOVER});
            this.dgvImageList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvImageList.Location = new System.Drawing.Point(0, 0);
            this.dgvImageList.Name = "dgvImageList";
            this.dgvImageList.RowTemplate.Height = 23;
            this.dgvImageList.Size = new System.Drawing.Size(687, 299);
            this.dgvImageList.TabIndex = 0;
            this.dgvImageList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvImageList_CellDoubleClick);
            this.dgvImageList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvImageList_CellClick);
            // 
            // PhotoID
            // 
            this.PhotoID.DataPropertyName = "FILEID";
            this.PhotoID.HeaderText = "PhotoID";
            this.PhotoID.Name = "PhotoID";
            this.PhotoID.Visible = false;
            // 
            // PhotoName
            // 
            this.PhotoName.DataPropertyName = "PHOTOFILENAME";
            this.PhotoName.HeaderText = "图片名";
            this.PhotoName.Name = "PhotoName";
            this.PhotoName.ReadOnly = true;
            this.PhotoName.Width = 200;
            // 
            // Remarks
            // 
            this.Remarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Remarks.DataPropertyName = "REMARKS";
            this.Remarks.HeaderText = "备注";
            this.Remarks.Name = "Remarks";
            // 
            // PHOTO
            // 
            this.PHOTO.HeaderText = "图片";
            this.PHOTO.Name = "PHOTO";
            this.PHOTO.ReadOnly = true;
            // 
            // ISCOVER
            // 
            this.ISCOVER.DataPropertyName = "ISCOVER";
            this.ISCOVER.HeaderText = "是否封面";
            this.ISCOVER.Name = "ISCOVER";
            // 
            // ImageList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 324);
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImageList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "图片列表(双击查看图片)";
            this.Load += new System.EventHandler(this.ImageList_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImageList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.DataGridView dgvImageList;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhotoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhotoName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
        private System.Windows.Forms.DataGridViewImageColumn PHOTO;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ISCOVER;
    }
}