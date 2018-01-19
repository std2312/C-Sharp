namespace SALE.UI.SaleManage
{
    partial class FormRetailBarterBaseBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRetailBarterBaseBill));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolAdd = new System.Windows.Forms.ToolStripButton();
            this.toolAmend = new System.Windows.Forms.ToolStripButton();
            this.toolBrowse = new System.Windows.Forms.ToolStripButton();
            this.toolDelete = new System.Windows.Forms.ToolStripButton();
            this.toolExit = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.contextAmend = new System.Windows.Forms.ToolStripMenuItem();
            this.contextQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.contextDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvBarterBaseBill = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bsBarterBaseBill = new System.Windows.Forms.BindingSource(this.components);
            this.BarterBillNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BarterBillDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BarterType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodsTypeCode = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.GoodsSeriesCode = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.GoodsTypeCode1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.GoodsSeriesCode1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.BarterQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeCode1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SignDate1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OperatorCode = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.AppendDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleBillNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsNeedInvoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarterBaseBill)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsBarterBaseBill)).BeginInit();
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
            this.toolStrip1.TabIndex = 17;
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
            this.contextAdd.Text = "添加换货单";
            this.contextAdd.Click += new System.EventHandler(this.toolAdd_Click);
            // 
            // contextAmend
            // 
            this.contextAmend.Name = "contextAmend";
            this.contextAmend.Size = new System.Drawing.Size(130, 22);
            this.contextAmend.Text = "修改换货单";
            this.contextAmend.Click += new System.EventHandler(this.toolAmend_Click);
            // 
            // contextQuery
            // 
            this.contextQuery.Name = "contextQuery";
            this.contextQuery.Size = new System.Drawing.Size(130, 22);
            this.contextQuery.Text = "查询换货单";
            this.contextQuery.Click += new System.EventHandler(this.toolBrowse_Click);
            // 
            // contextDelete
            // 
            this.contextDelete.Name = "contextDelete";
            this.contextDelete.Size = new System.Drawing.Size(130, 22);
            this.contextDelete.Text = "删除换货单";
            this.contextDelete.Click += new System.EventHandler(this.toolDelete_Click);
            // 
            // dgvBarterBaseBill
            // 
            this.dgvBarterBaseBill.AllowUserToAddRows = false;
            this.dgvBarterBaseBill.AllowUserToResizeColumns = false;
            this.dgvBarterBaseBill.AllowUserToResizeRows = false;
            this.dgvBarterBaseBill.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBarterBaseBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBarterBaseBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBarterBaseBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BarterBillNo,
            this.BarterBillDate,
            this.BarterType,
            this.CustomerName,
            this.Address,
            this.GoodsTypeCode,
            this.GoodsSeriesCode,
            this.GoodsTypeCode1,
            this.GoodsSeriesCode1,
            this.BarterQuantity,
            this.EmployeeCode1,
            this.SignDate1,
            this.OperatorCode,
            this.AppendDate,
            this.PhoneNumber,
            this.SaleBillNo,
            this.CustomerId,
            this.UnitPrice,
            this.UnitPrice1,
            this.IsNeedInvoice,
            this.Remark1});
            this.dgvBarterBaseBill.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvBarterBaseBill.Location = new System.Drawing.Point(8, 14);
            this.dgvBarterBaseBill.Name = "dgvBarterBaseBill";
            this.dgvBarterBaseBill.RowHeadersVisible = false;
            this.dgvBarterBaseBill.RowTemplate.Height = 23;
            this.dgvBarterBaseBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBarterBaseBill.Size = new System.Drawing.Size(829, 440);
            this.dgvBarterBaseBill.TabIndex = 2;
            this.dgvBarterBaseBill.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBarterBaseBill_CellDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvBarterBaseBill);
            this.groupBox2.Location = new System.Drawing.Point(4, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(843, 461);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "换货单";
            // 
            // BarterBillNo
            // 
            this.BarterBillNo.DataPropertyName = "BarterBillNo";
            this.BarterBillNo.HeaderText = "换货单号";
            this.BarterBillNo.Name = "BarterBillNo";
            // 
            // BarterBillDate
            // 
            this.BarterBillDate.DataPropertyName = "BarterBillDate";
            this.BarterBillDate.HeaderText = "换货日期";
            this.BarterBillDate.Name = "BarterBillDate";
            // 
            // BarterType
            // 
            this.BarterType.DataPropertyName = "BarterType";
            this.BarterType.HeaderText = "换货类型";
            this.BarterType.Name = "BarterType";
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
            this.Address.HeaderText = "地    址";
            this.Address.Name = "Address";
            // 
            // GoodsTypeCode
            // 
            this.GoodsTypeCode.DataPropertyName = "GoodsTypeCode";
            this.GoodsTypeCode.HeaderText = "原产品种类";
            this.GoodsTypeCode.Name = "GoodsTypeCode";
            // 
            // GoodsSeriesCode
            // 
            this.GoodsSeriesCode.DataPropertyName = "GoodsSeriesCode";
            this.GoodsSeriesCode.HeaderText = "原产品版本";
            this.GoodsSeriesCode.Name = "GoodsSeriesCode";
            // 
            // GoodsTypeCode1
            // 
            this.GoodsTypeCode1.DataPropertyName = "GoodsTypeCode1";
            this.GoodsTypeCode1.HeaderText = "现产品种类";
            this.GoodsTypeCode1.Name = "GoodsTypeCode1";
            // 
            // GoodsSeriesCode1
            // 
            this.GoodsSeriesCode1.DataPropertyName = "GoodsSeriesCode1";
            this.GoodsSeriesCode1.HeaderText = "现产品版本";
            this.GoodsSeriesCode1.Name = "GoodsSeriesCode1";
            // 
            // BarterQuantity
            // 
            this.BarterQuantity.DataPropertyName = "BarterQuantity";
            this.BarterQuantity.HeaderText = "调货数量";
            this.BarterQuantity.Name = "BarterQuantity";
            // 
            // EmployeeCode1
            // 
            this.EmployeeCode1.DataPropertyName = "EmployeeCode1";
            this.EmployeeCode1.HeaderText = "下 单 人";
            this.EmployeeCode1.Name = "EmployeeCode1";
            this.EmployeeCode1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // SignDate1
            // 
            this.SignDate1.DataPropertyName = "SignDate1";
            this.SignDate1.HeaderText = "签字日期";
            this.SignDate1.Name = "SignDate1";
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
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            this.PhoneNumber.HeaderText = "联系电话";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Visible = false;
            // 
            // SaleBillNo
            // 
            this.SaleBillNo.DataPropertyName = "SaleBillNo";
            this.SaleBillNo.HeaderText = "销售单号";
            this.SaleBillNo.Name = "SaleBillNo";
            this.SaleBillNo.Visible = false;
            // 
            // CustomerId
            // 
            this.CustomerId.DataPropertyName = "CustomerId";
            this.CustomerId.HeaderText = "用户ID";
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.Visible = false;
            // 
            // UnitPrice
            // 
            this.UnitPrice.DataPropertyName = "UnitPrice";
            this.UnitPrice.HeaderText = "原单价";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.Visible = false;
            // 
            // UnitPrice1
            // 
            this.UnitPrice1.DataPropertyName = "UnitPrice1";
            this.UnitPrice1.HeaderText = "现单价";
            this.UnitPrice1.Name = "UnitPrice1";
            this.UnitPrice1.Visible = false;
            // 
            // IsNeedInvoice
            // 
            this.IsNeedInvoice.DataPropertyName = "IsNeedInvoice";
            this.IsNeedInvoice.HeaderText = "是否有发票";
            this.IsNeedInvoice.Name = "IsNeedInvoice";
            this.IsNeedInvoice.Visible = false;
            // 
            // Remark1
            // 
            this.Remark1.DataPropertyName = "Remark1";
            this.Remark1.HeaderText = "备     注";
            this.Remark1.Name = "Remark1";
            this.Remark1.Visible = false;
            // 
            // FormRetailBarterBaseBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 493);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRetailBarterBaseBill";
            this.ShowInTaskbar = false;
            this.Text = "换货单";
            this.Load += new System.EventHandler(this.FormRetailBarterBaseBill_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarterBaseBill)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsBarterBaseBill)).EndInit();
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
        public System.Windows.Forms.BindingSource bsBarterBaseBill;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem contextAdd;
        private System.Windows.Forms.ToolStripMenuItem contextAmend;
        private System.Windows.Forms.ToolStripMenuItem contextQuery;
        private System.Windows.Forms.ToolStripMenuItem contextDelete;
        public System.Windows.Forms.DataGridView dgvBarterBaseBill;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn BarterBillNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn BarterBillDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn BarterType;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewComboBoxColumn GoodsTypeCode;
        private System.Windows.Forms.DataGridViewComboBoxColumn GoodsSeriesCode;
        private System.Windows.Forms.DataGridViewComboBoxColumn GoodsTypeCode1;
        private System.Windows.Forms.DataGridViewComboBoxColumn GoodsSeriesCode1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BarterQuantity;
        private System.Windows.Forms.DataGridViewComboBoxColumn EmployeeCode1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SignDate1;
        private System.Windows.Forms.DataGridViewComboBoxColumn OperatorCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppendDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleBillNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsNeedInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark1;
    }
}