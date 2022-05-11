namespace BES.Forms.BookManager
{
    partial class BookList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookList));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tstbWord = new System.Windows.Forms.ToolStripTextBox();
            this.tscbType = new System.Windows.Forms.ToolStripComboBox();
            this.tsbSearch = new System.Windows.Forms.ToolStripButton();
            this.tsbAdvance = new System.Windows.Forms.ToolStripButton();
            this.tsbExit = new System.Windows.Forms.ToolStripButton();
            this.pMain = new System.Windows.Forms.Panel();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.BOOKID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BOOKNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SERIALNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AUTHOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRANSLATER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLSNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RDISC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PUBDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PUBLISHERNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BINDINGNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SIZENAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EDITION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NPRINT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAGES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WORDS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PYSTYPENAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FRANCHISEENAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DUZHEDINGWEI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAIDIAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SHANGJIAJIANYI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JIANJIE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.pMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstbWord,
            this.tscbType,
            this.tsbSearch,
            this.tsbAdvance,
            this.tsbExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(601, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tstbWord
            // 
            this.tstbWord.Name = "tstbWord";
            this.tstbWord.Size = new System.Drawing.Size(100, 25);
            // 
            // tscbType
            // 
            this.tscbType.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tscbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscbType.Items.AddRange(new object[] {
            "书号",
            "书名"});
            this.tscbType.Name = "tscbType";
            this.tscbType.Size = new System.Drawing.Size(80, 25);
            // 
            // tsbSearch
            // 
            this.tsbSearch.Image = ((System.Drawing.Image)(resources.GetObject("tsbSearch.Image")));
            this.tsbSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSearch.Name = "tsbSearch";
            this.tsbSearch.Size = new System.Drawing.Size(67, 22);
            this.tsbSearch.Text = "查询(&S)";
            this.tsbSearch.Click += new System.EventHandler(this.tsbSearch_Click);
            // 
            // tsbAdvance
            // 
            this.tsbAdvance.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdvance.Image")));
            this.tsbAdvance.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdvance.Name = "tsbAdvance";
            this.tsbAdvance.Size = new System.Drawing.Size(91, 22);
            this.tsbAdvance.Text = "高级查询(&A)";
            this.tsbAdvance.Click += new System.EventHandler(this.tsbAdvance_Click);
            // 
            // tsbExit
            // 
            this.tsbExit.Image = ((System.Drawing.Image)(resources.GetObject("tsbExit.Image")));
            this.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.Size = new System.Drawing.Size(67, 22);
            this.tsbExit.Text = "退出(&E)";
            this.tsbExit.Click += new System.EventHandler(this.tsbExit_Click);
            // 
            // pMain
            // 
            this.pMain.Controls.Add(this.dgvList);
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(0, 25);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(601, 241);
            this.pMain.TabIndex = 1;
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BOOKID,
            this.ISBN,
            this.BOOKNAME,
            this.SERIALNAME,
            this.AUTHOR,
            this.TRANSLATER,
            this.CLSNAME,
            this.Column1,
            this.price,
            this.RDISC,
            this.PUBDATE,
            this.PUBLISHERNAME,
            this.BINDINGNAME,
            this.SIZENAME,
            this.EDITION,
            this.NPRINT,
            this.PAGES,
            this.WORDS,
            this.Column10,
            this.PYSTYPENAME,
            this.FRANCHISEENAME,
            this.DUZHEDINGWEI,
            this.MAIDIAN,
            this.SHANGJIAJIANYI,
            this.JIANJIE});
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(0, 0);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.Size = new System.Drawing.Size(601, 241);
            this.dgvList.TabIndex = 0;
            this.dgvList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellDoubleClick);
            // 
            // BOOKID
            // 
            this.BOOKID.DataPropertyName = "PLUCODE";
            this.BOOKID.HeaderText = "BOOKID";
            this.BOOKID.Name = "BOOKID";
            this.BOOKID.ReadOnly = true;
            this.BOOKID.Visible = false;
            // 
            // ISBN
            // 
            this.ISBN.DataPropertyName = "ISBN";
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            this.ISBN.ReadOnly = true;
            // 
            // BOOKNAME
            // 
            this.BOOKNAME.DataPropertyName = "TITLE";
            this.BOOKNAME.HeaderText = "书名";
            this.BOOKNAME.Name = "BOOKNAME";
            this.BOOKNAME.ReadOnly = true;
            // 
            // SERIALNAME
            // 
            this.SERIALNAME.DataPropertyName = "SERIES";
            this.SERIALNAME.HeaderText = "丛书名";
            this.SERIALNAME.Name = "SERIALNAME";
            this.SERIALNAME.ReadOnly = true;
            // 
            // AUTHOR
            // 
            this.AUTHOR.DataPropertyName = "AUTHOR";
            this.AUTHOR.HeaderText = "作者";
            this.AUTHOR.Name = "AUTHOR";
            this.AUTHOR.ReadOnly = true;
            // 
            // TRANSLATER
            // 
            this.TRANSLATER.DataPropertyName = "TRANSLATOR";
            this.TRANSLATER.HeaderText = "译者";
            this.TRANSLATER.Name = "TRANSLATER";
            this.TRANSLATER.ReadOnly = true;
            // 
            // CLSNAME
            // 
            this.CLSNAME.DataPropertyName = "DPTNAME";
            this.CLSNAME.HeaderText = "一级分类";
            this.CLSNAME.Name = "CLSNAME";
            this.CLSNAME.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CLSNAME";
            this.Column1.HeaderText = "中图法分类";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // price
            // 
            this.price.DataPropertyName = "PRICE";
            this.price.HeaderText = "定价";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // RDISC
            // 
            this.RDISC.DataPropertyName = "RDISC";
            this.RDISC.HeaderText = "折扣";
            this.RDISC.Name = "RDISC";
            this.RDISC.ReadOnly = true;
            this.RDISC.Visible = false;
            // 
            // PUBDATE
            // 
            this.PUBDATE.DataPropertyName = "PUBDATE";
            this.PUBDATE.HeaderText = "出版日期";
            this.PUBDATE.Name = "PUBDATE";
            this.PUBDATE.ReadOnly = true;
            // 
            // PUBLISHERNAME
            // 
            this.PUBLISHERNAME.DataPropertyName = "PUBLISHERNAME";
            this.PUBLISHERNAME.HeaderText = "出版社";
            this.PUBLISHERNAME.Name = "PUBLISHERNAME";
            this.PUBLISHERNAME.ReadOnly = true;
            // 
            // BINDINGNAME
            // 
            this.BINDINGNAME.DataPropertyName = "BINDINGNAME";
            this.BINDINGNAME.HeaderText = "装祯";
            this.BINDINGNAME.Name = "BINDINGNAME";
            this.BINDINGNAME.ReadOnly = true;
            // 
            // SIZENAME
            // 
            this.SIZENAME.DataPropertyName = "SIZENAME";
            this.SIZENAME.HeaderText = "开本";
            this.SIZENAME.Name = "SIZENAME";
            this.SIZENAME.ReadOnly = true;
            // 
            // EDITION
            // 
            this.EDITION.DataPropertyName = "EDITION";
            this.EDITION.HeaderText = "版次";
            this.EDITION.Name = "EDITION";
            this.EDITION.ReadOnly = true;
            // 
            // NPRINT
            // 
            this.NPRINT.DataPropertyName = "NPRINT";
            this.NPRINT.HeaderText = "印次";
            this.NPRINT.Name = "NPRINT";
            this.NPRINT.ReadOnly = true;
            // 
            // PAGES
            // 
            this.PAGES.DataPropertyName = "PAGES";
            this.PAGES.HeaderText = "页数";
            this.PAGES.Name = "PAGES";
            this.PAGES.ReadOnly = true;
            // 
            // WORDS
            // 
            this.WORDS.DataPropertyName = "WORDS";
            this.WORDS.HeaderText = "字数";
            this.WORDS.Name = "WORDS";
            this.WORDS.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "印数";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Visible = false;
            // 
            // PYSTYPENAME
            // 
            this.PYSTYPENAME.DataPropertyName = "PYSTYPENAME";
            this.PYSTYPENAME.HeaderText = "版别";
            this.PYSTYPENAME.Name = "PYSTYPENAME";
            this.PYSTYPENAME.ReadOnly = true;
            // 
            // FRANCHISEENAME
            // 
            this.FRANCHISEENAME.DataPropertyName = "FRANCHISEENAME";
            this.FRANCHISEENAME.HeaderText = "经销商";
            this.FRANCHISEENAME.Name = "FRANCHISEENAME";
            this.FRANCHISEENAME.ReadOnly = true;
            // 
            // DUZHEDINGWEI
            // 
            this.DUZHEDINGWEI.DataPropertyName = "DUZHEDINGWEI";
            this.DUZHEDINGWEI.HeaderText = "读者定位";
            this.DUZHEDINGWEI.Name = "DUZHEDINGWEI";
            this.DUZHEDINGWEI.ReadOnly = true;
            // 
            // MAIDIAN
            // 
            this.MAIDIAN.DataPropertyName = "MAIDIAN";
            this.MAIDIAN.HeaderText = "卖点";
            this.MAIDIAN.Name = "MAIDIAN";
            this.MAIDIAN.ReadOnly = true;
            // 
            // SHANGJIAJIANYI
            // 
            this.SHANGJIAJIANYI.DataPropertyName = "SHANGJIAJIANYI";
            this.SHANGJIAJIANYI.HeaderText = "上架建议";
            this.SHANGJIAJIANYI.Name = "SHANGJIAJIANYI";
            this.SHANGJIAJIANYI.ReadOnly = true;
            // 
            // JIANJIE
            // 
            this.JIANJIE.DataPropertyName = "JIANJIE";
            this.JIANJIE.HeaderText = "图书简介";
            this.JIANJIE.Name = "JIANJIE";
            this.JIANJIE.ReadOnly = true;
            // 
            // BookList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 266);
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BookList";
            this.Text = "图书查询";
            this.Load += new System.EventHandler(this.BookList_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox tscbType;
        private System.Windows.Forms.ToolStripButton tsbSearch;
        private System.Windows.Forms.ToolStripButton tsbAdvance;
        private System.Windows.Forms.ToolStripButton tsbExit;
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.ToolStripTextBox tstbWord;
        private System.Windows.Forms.DataGridViewTextBoxColumn BOOKID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn BOOKNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn SERIALNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn AUTHOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRANSLATER;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLSNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn RDISC;
        private System.Windows.Forms.DataGridViewTextBoxColumn PUBDATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PUBLISHERNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn BINDINGNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn SIZENAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn EDITION;
        private System.Windows.Forms.DataGridViewTextBoxColumn NPRINT;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAGES;
        private System.Windows.Forms.DataGridViewTextBoxColumn WORDS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn PYSTYPENAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn FRANCHISEENAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn DUZHEDINGWEI;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAIDIAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn SHANGJIAJIANYI;
        private System.Windows.Forms.DataGridViewTextBoxColumn JIANJIE;
    }
}