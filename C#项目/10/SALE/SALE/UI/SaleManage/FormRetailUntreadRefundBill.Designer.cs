namespace SALE.UI.SaleManage
{
    partial class FormRetailUntreadRefundBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRetailUntreadRefundBill));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolAdd = new System.Windows.Forms.ToolStripButton();
            this.toolAmend = new System.Windows.Forms.ToolStripButton();
            this.toolBrowse = new System.Windows.Forms.ToolStripButton();
            this.toolDelete = new System.Windows.Forms.ToolStripButton();
            this.toolExit = new System.Windows.Forms.ToolStripButton();
            this.bsUntreadGatherBill = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.contextAmend = new System.Windows.Forms.ToolStripMenuItem();
            this.contextQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.contextDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvUntreadRefundBill = new System.Windows.Forms.DataGridView();
            this.UntreadBillNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodsTypeCode = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.GoodsSeriesCode = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UntreadMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayTypeCode = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.BankCode = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.UntreadMoneyDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TradeBillNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FactUntreadMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeCode3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SignDate3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OperatorCode = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.AppendDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsUntreadGatherBill)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUntreadRefundBill)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            this.toolStrip1.TabIndex = 15;
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
            this.contextAdd.Text = "添加退款单";
            this.contextAdd.Click += new System.EventHandler(this.toolAdd_Click);
            // 
            // contextAmend
            // 
            this.contextAmend.Name = "contextAmend";
            this.contextAmend.Size = new System.Drawing.Size(130, 22);
            this.contextAmend.Text = "修改退款单";
            this.contextAmend.Click += new System.EventHandler(this.toolAmend_Click);
            // 
            // contextQuery
            // 
            this.contextQuery.Name = "contextQuery";
            this.contextQuery.Size = new System.Drawing.Size(130, 22);
            this.contextQuery.Text = "查询退款单";
            this.contextQuery.Click += new System.EventHandler(this.toolBrowse_Click);
            // 
            // contextDelete
            // 
            this.contextDelete.Name = "contextDelete";
            this.contextDelete.Size = new System.Drawing.Size(130, 22);
            this.contextDelete.Text = "删除退款单";
            this.contextDelete.Click += new System.EventHandler(this.toolDelete_Click);
            // 
            // dgvUntreadRefundBill
            // 
            this.dgvUntreadRefundBill.AllowUserToAddRows = false;
            this.dgvUntreadRefundBill.AllowUserToResizeColumns = false;
            this.dgvUntreadRefundBill.AllowUserToResizeRows = false;
            this.dgvUntreadRefundBill.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUntreadRefundBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUntreadRefundBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUntreadRefundBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UntreadBillNo,
            this.CustomerName,
            this.Address,
            this.GoodsTypeCode,
            this.GoodsSeriesCode,
            this.UnitPrice,
            this.Quantity,
            this.UntreadMoney,
            this.PayTypeCode,
            this.BankCode,
            this.UntreadMoneyDate,
            this.TradeBillNo,
            this.FactUntreadMoney,
            this.EmployeeCode3,
            this.SignDate3,
            this.OperatorCode,
            this.AppendDate,
            this.Id});
            this.dgvUntreadRefundBill.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvUntreadRefundBill.Location = new System.Drawing.Point(8, 14);
            this.dgvUntreadRefundBill.Name = "dgvUntreadRefundBill";
            this.dgvUntreadRefundBill.RowHeadersVisible = false;
            this.dgvUntreadRefundBill.RowTemplate.Height = 23;
            this.dgvUntreadRefundBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUntreadRefundBill.Size = new System.Drawing.Size(829, 440);
            this.dgvUntreadRefundBill.TabIndex = 2;
            this.dgvUntreadRefundBill.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUntreadRefundBill_CellDoubleClick);
            // 
            // UntreadBillNo
            // 
            this.UntreadBillNo.DataPropertyName = "UntreadBillNo";
            this.UntreadBillNo.HeaderText = "退货单号";
            this.UntreadBillNo.Name = "UntreadBillNo";
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.HeaderText = "用户名称";
            this.CustomerName.Name = "CustomerName";
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "用户地址";
            this.Address.Name = "Address";
            // 
            // GoodsTypeCode
            // 
            this.GoodsTypeCode.DataPropertyName = "GoodsTypeCode";
            this.GoodsTypeCode.HeaderText = "产品种类";
            this.GoodsTypeCode.Name = "GoodsTypeCode";
            // 
            // GoodsSeriesCode
            // 
            this.GoodsSeriesCode.DataPropertyName = "GoodsSeriesCode";
            this.GoodsSeriesCode.HeaderText = "产品版本";
            this.GoodsSeriesCode.Name = "GoodsSeriesCode";
            // 
            // UnitPrice
            // 
            this.UnitPrice.DataPropertyName = "UnitPrice";
            this.UnitPrice.HeaderText = "退 货 价";
            this.UnitPrice.Name = "UnitPrice";
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "退货数量";
            this.Quantity.Name = "Quantity";
            // 
            // UntreadMoney
            // 
            this.UntreadMoney.DataPropertyName = "UntreadMoney";
            this.UntreadMoney.HeaderText = "应退金额";
            this.UntreadMoney.Name = "UntreadMoney";
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
            this.BankCode.HeaderText = "交易银行";
            this.BankCode.Name = "BankCode";
            // 
            // UntreadMoneyDate
            // 
            this.UntreadMoneyDate.DataPropertyName = "UntreadMoneyDate";
            this.UntreadMoneyDate.HeaderText = "退款日期";
            this.UntreadMoneyDate.Name = "UntreadMoneyDate";
            // 
            // TradeBillNo
            // 
            this.TradeBillNo.DataPropertyName = "TradeBillNo";
            this.TradeBillNo.HeaderText = "交易单号";
            this.TradeBillNo.Name = "TradeBillNo";
            // 
            // FactUntreadMoney
            // 
            this.FactUntreadMoney.DataPropertyName = "FactUntreadMoney";
            this.FactUntreadMoney.HeaderText = "实退金额";
            this.FactUntreadMoney.Name = "FactUntreadMoney";
            // 
            // EmployeeCode3
            // 
            this.EmployeeCode3.DataPropertyName = "EmployeeCode3";
            this.EmployeeCode3.HeaderText = "退 款 人";
            this.EmployeeCode3.Name = "EmployeeCode3";
            this.EmployeeCode3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // SignDate3
            // 
            this.SignDate3.DataPropertyName = "SignDate3";
            this.SignDate3.HeaderText = "签字日期";
            this.SignDate3.Name = "SignDate3";
            // 
            // OperatorCode
            // 
            this.OperatorCode.DataPropertyName = "OperatorCode";
            this.OperatorCode.HeaderText = "录入人员";
            this.OperatorCode.Name = "OperatorCode";
            this.OperatorCode.ReadOnly = true;
            this.OperatorCode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.OperatorCode.Visible = false;
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
            this.Id.HeaderText = "退款单的Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvUntreadRefundBill);
            this.groupBox2.Location = new System.Drawing.Point(4, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(843, 461);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "退款单";
            // 
            // FormRetailUntreadRefundBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 493);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRetailUntreadRefundBill";
            this.ShowInTaskbar = false;
            this.Text = "退款单";
            this.Load += new System.EventHandler(this.FormRetailUntreadRefundBill_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsUntreadGatherBill)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUntreadRefundBill)).EndInit();
            this.groupBox2.ResumeLayout(false);
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
        public System.Windows.Forms.BindingSource bsUntreadGatherBill;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem contextAdd;
        private System.Windows.Forms.ToolStripMenuItem contextAmend;
        private System.Windows.Forms.ToolStripMenuItem contextQuery;
        private System.Windows.Forms.ToolStripMenuItem contextDelete;
        public System.Windows.Forms.DataGridView dgvUntreadRefundBill;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn UntreadBillNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewComboBoxColumn GoodsTypeCode;
        private System.Windows.Forms.DataGridViewComboBoxColumn GoodsSeriesCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn UntreadMoney;
        private System.Windows.Forms.DataGridViewComboBoxColumn PayTypeCode;
        private System.Windows.Forms.DataGridViewComboBoxColumn BankCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn UntreadMoneyDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TradeBillNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FactUntreadMoney;
        private System.Windows.Forms.DataGridViewComboBoxColumn EmployeeCode3;
        private System.Windows.Forms.DataGridViewTextBoxColumn SignDate3;
        private System.Windows.Forms.DataGridViewComboBoxColumn OperatorCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppendDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}