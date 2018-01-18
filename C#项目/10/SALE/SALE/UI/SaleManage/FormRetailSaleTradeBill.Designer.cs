namespace SALE.UI.SaleManage
{
    partial class FormRetailSaleTradeBill
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRetailSaleTradeBill));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolAdd = new System.Windows.Forms.ToolStripButton();
            this.toolAmend = new System.Windows.Forms.ToolStripButton();
            this.toolBrowse = new System.Windows.Forms.ToolStripButton();
            this.toolDelete = new System.Windows.Forms.ToolStripButton();
            this.toolExit = new System.Windows.Forms.ToolStripButton();
            this.bsSaleTradeBill = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.contextAmend = new System.Windows.Forms.ToolStripMenuItem();
            this.contextQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.contextDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvSaleTradeBill = new System.Windows.Forms.DataGridView();
            this.SaleBillNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayTypeCode = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.BankCode = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SaleDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TradeBillNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiptMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeCode1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SignDate1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeCode2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SignDate2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeCode3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SignDate3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OperatorCode = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.AppendDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsSaleTradeBill)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleTradeBill)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolAdd,
            this.toolAmend,
            this.toolBrowse,
            this.toolDelete,
            this.toolExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(851, 25);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolAdd
            // 
            this.toolAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolAdd.Image")));
            this.toolAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAdd.Name = "toolAdd";
            this.toolAdd.Size = new System.Drawing.Size(49, 22);
            this.toolAdd.Text = "添加";
            this.toolAdd.Click += new System.EventHandler(this.toolAdd_Click);
            // 
            // toolAmend
            // 
            this.toolAmend.Image = ((System.Drawing.Image)(resources.GetObject("toolAmend.Image")));
            this.toolAmend.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAmend.Name = "toolAmend";
            this.toolAmend.Size = new System.Drawing.Size(49, 22);
            this.toolAmend.Text = "修改";
            this.toolAmend.Click += new System.EventHandler(this.toolAmend_Click);
            // 
            // toolBrowse
            // 
            this.toolBrowse.Image = ((System.Drawing.Image)(resources.GetObject("toolBrowse.Image")));
            this.toolBrowse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBrowse.Name = "toolBrowse";
            this.toolBrowse.Size = new System.Drawing.Size(49, 22);
            this.toolBrowse.Text = "查询";
            this.toolBrowse.Click += new System.EventHandler(this.toolBrowse_Click);
            // 
            // toolDelete
            // 
            this.toolDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolDelete.Image")));
            this.toolDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDelete.Name = "toolDelete";
            this.toolDelete.Size = new System.Drawing.Size(49, 22);
            this.toolDelete.Text = "删除";
            this.toolDelete.Click += new System.EventHandler(this.toolDelete_Click);
            // 
            // toolExit
            // 
            this.toolExit.Image = ((System.Drawing.Image)(resources.GetObject("toolExit.Image")));
            this.toolExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolExit.Name = "toolExit";
            this.toolExit.Size = new System.Drawing.Size(49, 22);
            this.toolExit.Text = "退出";
            this.toolExit.Click += new System.EventHandler(this.toolExit_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextAdd,
            this.contextAmend,
            this.contextQuery,
            this.contextDelete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(131, 92);
            // 
            // contextAdd
            // 
            this.contextAdd.Name = "contextAdd";
            this.contextAdd.Size = new System.Drawing.Size(130, 22);
            this.contextAdd.Text = "添加交易单";
            this.contextAdd.Click += new System.EventHandler(this.contextAdd_Click);
            // 
            // contextAmend
            // 
            this.contextAmend.Name = "contextAmend";
            this.contextAmend.Size = new System.Drawing.Size(130, 22);
            this.contextAmend.Text = "修改交易单";
            this.contextAmend.Click += new System.EventHandler(this.contextAmend_Click);
            // 
            // contextQuery
            // 
            this.contextQuery.Name = "contextQuery";
            this.contextQuery.Size = new System.Drawing.Size(130, 22);
            this.contextQuery.Text = "查询交易单";
            this.contextQuery.Click += new System.EventHandler(this.contextQuery_Click);
            // 
            // contextDelete
            // 
            this.contextDelete.Name = "contextDelete";
            this.contextDelete.Size = new System.Drawing.Size(130, 22);
            this.contextDelete.Text = "删除交易单";
            this.contextDelete.Click += new System.EventHandler(this.contextDelete_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvSaleTradeBill);
            this.groupBox2.Location = new System.Drawing.Point(4, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(843, 461);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "销售交易单";
            // 
            // dgvSaleTradeBill
            // 
            this.dgvSaleTradeBill.AllowUserToAddRows = false;
            this.dgvSaleTradeBill.AllowUserToResizeColumns = false;
            this.dgvSaleTradeBill.AllowUserToResizeRows = false;
            this.dgvSaleTradeBill.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSaleTradeBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSaleTradeBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSaleTradeBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SaleBillNo,
            this.PayTypeCode,
            this.BankCode,
            this.SaleDate,
            this.TradeBillNo,
            this.ReceiptMoney,
            this.EmployeeCode1,
            this.SignDate1,
            this.EmployeeCode2,
            this.SignDate2,
            this.EmployeeCode3,
            this.SignDate3,
            this.Remark1,
            this.OperatorCode,
            this.AppendDate,
            this.Id});
            this.dgvSaleTradeBill.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvSaleTradeBill.Location = new System.Drawing.Point(8, 14);
            this.dgvSaleTradeBill.Name = "dgvSaleTradeBill";
            this.dgvSaleTradeBill.RowHeadersVisible = false;
            this.dgvSaleTradeBill.RowTemplate.Height = 23;
            this.dgvSaleTradeBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSaleTradeBill.Size = new System.Drawing.Size(829, 440);
            this.dgvSaleTradeBill.TabIndex = 2;
            this.dgvSaleTradeBill.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSaleTradeBill_CellDoubleClick);
            // 
            // SaleBillNo
            // 
            this.SaleBillNo.DataPropertyName = "SaleBillNo";
            this.SaleBillNo.HeaderText = "销售单号";
            this.SaleBillNo.Name = "SaleBillNo";
            this.SaleBillNo.ReadOnly = true;
            this.SaleBillNo.Width = 120;
            // 
            // PayTypeCode
            // 
            this.PayTypeCode.DataPropertyName = "PayTypeCode";
            this.PayTypeCode.HeaderText = "交易方式";
            this.PayTypeCode.Name = "PayTypeCode";
            // 
            // BankCode
            // 
            this.BankCode.DataPropertyName = "BankCode";
            this.BankCode.HeaderText = "预存银行";
            this.BankCode.Name = "BankCode";
            // 
            // SaleDate
            // 
            this.SaleDate.DataPropertyName = "SaleDate";
            this.SaleDate.HeaderText = "查款日期";
            this.SaleDate.Name = "SaleDate";
            // 
            // TradeBillNo
            // 
            this.TradeBillNo.DataPropertyName = "TradeBillNo";
            this.TradeBillNo.HeaderText = "交易单号";
            this.TradeBillNo.Name = "TradeBillNo";
            // 
            // ReceiptMoney
            // 
            this.ReceiptMoney.DataPropertyName = "ReceiptMoney";
            this.ReceiptMoney.HeaderText = "实收金额";
            this.ReceiptMoney.Name = "ReceiptMoney";
            // 
            // EmployeeCode1
            // 
            this.EmployeeCode1.DataPropertyName = "EmployeeCode1";
            this.EmployeeCode1.HeaderText = "查 款 人";
            this.EmployeeCode1.Name = "EmployeeCode1";
            // 
            // SignDate1
            // 
            this.SignDate1.DataPropertyName = "SignDate1";
            this.SignDate1.HeaderText = "日    期";
            this.SignDate1.Name = "SignDate1";
            // 
            // EmployeeCode2
            // 
            this.EmployeeCode2.DataPropertyName = "EmployeeCode2";
            this.EmployeeCode2.HeaderText = "光盘制作人";
            this.EmployeeCode2.Name = "EmployeeCode2";
            // 
            // SignDate2
            // 
            this.SignDate2.DataPropertyName = "SignDate2";
            this.SignDate2.HeaderText = "日    期";
            this.SignDate2.Name = "SignDate2";
            // 
            // EmployeeCode3
            // 
            this.EmployeeCode3.DataPropertyName = "EmployeeCode3";
            this.EmployeeCode3.HeaderText = "光盘审校人";
            this.EmployeeCode3.Name = "EmployeeCode3";
            this.EmployeeCode3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeeCode3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // SignDate3
            // 
            this.SignDate3.DataPropertyName = "SignDate3";
            this.SignDate3.HeaderText = "日    期";
            this.SignDate3.Name = "SignDate3";
            // 
            // Remark1
            // 
            this.Remark1.DataPropertyName = "Remark1";
            this.Remark1.HeaderText = "备    注";
            this.Remark1.Name = "Remark1";
            this.Remark1.ReadOnly = true;
            this.Remark1.Width = 200;
            // 
            // OperatorCode
            // 
            this.OperatorCode.DataPropertyName = "OperatorCode";
            this.OperatorCode.HeaderText = "录入人员";
            this.OperatorCode.Name = "OperatorCode";
            this.OperatorCode.ReadOnly = true;
            this.OperatorCode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.OperatorCode.Width = 80;
            // 
            // AppendDate
            // 
            this.AppendDate.DataPropertyName = "AppendDate";
            this.AppendDate.HeaderText = "录入日期";
            this.AppendDate.Name = "AppendDate";
            this.AppendDate.Visible = false;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "自增Id号";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // FormRetailSaleTradeBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 493);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRetailSaleTradeBill";
            this.ShowInTaskbar = false;
            this.Text = "销售交易单";
            this.Load += new System.EventHandler(this.FormRetailSaleTradeBill_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsSaleTradeBill)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleTradeBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripButton toolAdd;
        public System.Windows.Forms.ToolStripButton toolAmend;
        public System.Windows.Forms.ToolStripButton toolBrowse;
        public System.Windows.Forms.ToolStripButton toolDelete;
        private System.Windows.Forms.ToolStripButton toolExit;
        public System.Windows.Forms.BindingSource bsSaleTradeBill;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem contextAdd;
        private System.Windows.Forms.ToolStripMenuItem contextAmend;
        private System.Windows.Forms.ToolStripMenuItem contextDelete;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.DataGridView dgvSaleTradeBill;
        private System.Windows.Forms.ToolStripMenuItem contextQuery;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleBillNo;
        private System.Windows.Forms.DataGridViewComboBoxColumn PayTypeCode;
        private System.Windows.Forms.DataGridViewComboBoxColumn BankCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TradeBillNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiptMoney;
        private System.Windows.Forms.DataGridViewComboBoxColumn EmployeeCode1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SignDate1;
        private System.Windows.Forms.DataGridViewComboBoxColumn EmployeeCode2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SignDate2;
        private System.Windows.Forms.DataGridViewComboBoxColumn EmployeeCode3;
        private System.Windows.Forms.DataGridViewTextBoxColumn SignDate3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark1;
        private System.Windows.Forms.DataGridViewComboBoxColumn OperatorCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppendDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}