namespace BES.Forms.BookManager
{
    partial class AdvanceSearch
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
            this.lwSelected = new System.Windows.Forms.ListView();
            this.btDelete = new System.Windows.Forms.Button();
            this.btOk = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.cbField = new System.Windows.Forms.ComboBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.tbWords = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbOr = new System.Windows.Forms.RadioButton();
            this.rbAnd = new System.Windows.Forms.RadioButton();
            this.cbResult = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lwSelected
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.lwSelected, 3);
            this.lwSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lwSelected.Location = new System.Drawing.Point(13, 48);
            this.lwSelected.Name = "lwSelected";
            this.tableLayoutPanel1.SetRowSpan(this.lwSelected, 2);
            this.lwSelected.Size = new System.Drawing.Size(414, 179);
            this.lwSelected.TabIndex = 0;
            this.lwSelected.UseCompatibleStateImageBehavior = false;
            this.lwSelected.View = System.Windows.Forms.View.List;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(433, 48);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(30, 30);
            this.btDelete.TabIndex = 1;
            this.btDelete.Text = "删";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(245, 0);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(80, 30);
            this.btOk.TabIndex = 2;
            this.btOk.Text = "搜索(&S)";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(331, 0);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(80, 30);
            this.btExit.TabIndex = 3;
            this.btExit.Text = "取消(&E)";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(433, 13);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(30, 29);
            this.btAdd.TabIndex = 4;
            this.btAdd.Text = "增";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // cbField
            // 
            this.cbField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbField.FormattingEnabled = true;
            this.cbField.Location = new System.Drawing.Point(13, 13);
            this.cbField.Name = "cbField";
            this.cbField.Size = new System.Drawing.Size(134, 28);
            this.cbField.TabIndex = 5;
            this.cbField.SelectedIndexChanged += new System.EventHandler(this.cbField_SelectedIndexChanged);
            this.cbField.SelectedValueChanged += new System.EventHandler(this.cbField_SelectedValueChanged);
            // 
            // cbType
            // 
            this.cbType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(153, 13);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(134, 28);
            this.cbType.TabIndex = 6;
            // 
            // tbWords
            // 
            this.tbWords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbWords.Location = new System.Drawing.Point(293, 13);
            this.tbWords.Name = "tbWords";
            this.tbWords.Size = new System.Drawing.Size(134, 26);
            this.tbWords.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel1.Controls.Add(this.cbField, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btAdd, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbWords, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btDelete, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbType, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lwSelected, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(479, 266);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 3);
            this.panel1.Controls.Add(this.rbOr);
            this.panel1.Controls.Add(this.rbAnd);
            this.panel1.Controls.Add(this.cbResult);
            this.panel1.Controls.Add(this.btOk);
            this.panel1.Controls.Add(this.btExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(13, 233);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 30);
            this.panel1.TabIndex = 8;
            // 
            // rbOr
            // 
            this.rbOr.AutoSize = true;
            this.rbOr.Location = new System.Drawing.Point(155, 5);
            this.rbOr.Name = "rbOr";
            this.rbOr.Size = new System.Drawing.Size(41, 24);
            this.rbOr.TabIndex = 6;
            this.rbOr.TabStop = true;
            this.rbOr.Text = "或";
            this.rbOr.UseVisualStyleBackColor = true;
            // 
            // rbAnd
            // 
            this.rbAnd.AutoSize = true;
            this.rbAnd.Checked = true;
            this.rbAnd.Location = new System.Drawing.Point(108, 5);
            this.rbAnd.Name = "rbAnd";
            this.rbAnd.Size = new System.Drawing.Size(41, 24);
            this.rbAnd.TabIndex = 5;
            this.rbAnd.TabStop = true;
            this.rbAnd.Text = "和";
            this.rbAnd.UseVisualStyleBackColor = true;
            // 
            // cbResult
            // 
            this.cbResult.AutoSize = true;
            this.cbResult.Location = new System.Drawing.Point(4, 5);
            this.cbResult.Name = "cbResult";
            this.cbResult.Size = new System.Drawing.Size(98, 24);
            this.cbResult.TabIndex = 4;
            this.cbResult.Text = "结果中查找";
            this.cbResult.UseVisualStyleBackColor = true;
            // 
            // AdvanceSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 266);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdvanceSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "高级查找";
            this.Load += new System.EventHandler(this.AdvanceSearch_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lwSelected;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.ComboBox cbField;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.TextBox tbWords;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbOr;
        private System.Windows.Forms.RadioButton rbAnd;
        private System.Windows.Forms.CheckBox cbResult;

    }
}