namespace SALE.UI.SaleManage
{
    partial class FormRetailUntreadGatherBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRetailUntreadGatherBill));
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
            this.dgvUntreadGatherBill = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.UntreadBillNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodsTypeCode = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.GoodsSeriesCode = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsComplete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IsReturnInvoice = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IsShatter = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EmployeeCode2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SignDate2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OperatorCode = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.AppendDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsUntreadGatherBill)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUntreadGatherBill)).BeginInit();
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
            this.toolStrip1.TabIndex = 13;
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
            this.contextAdd.Text = "添加收货单";
            this.contextAdd.Click += new System.EventHandler(this.toolAdd_Click);
            // 
            // contextAmend
            // 
            this.contextAmend.Name = "contextAmend";
            this.contextAmend.Size = new System.Drawing.Size(130, 22);
            this.contextAmend.Text = "修改收货单";
            this.contextAmend.Click += new System.EventHandler(this.toolAmend_Click);
            // 
            // contextQuery
            // 
            this.contextQuery.Name = "contextQuery";
            this.contextQuery.Size = new System.Drawing.Size(130, 22);
            this.contextQuery.Text = "查询收货单";
            this.contextQuery.Click += new System.EventHandler(this.toolBrowse_Click);
            // 
            // contextDelete
            // 
            this.contextDelete.Name = "contextDelete";
            this.contextDelete.Size = new System.Drawing.Size(130, 22);
            this.contextDelete.Text = "删除收货单";
            this.contextDelete.Click += new System.EventHandler(this.toolDelete_Click);
            // 
            // dgvUntreadGatherBill
            // 
            this.dgvUntreadGatherBill.AllowUserToAddRows = false;
            this.dgvUntreadGatherBill.AllowUserToResizeColumns = false;
            this.dgvUntreadGatherBill.AllowUserToResizeRows = false;
            this.dgvUntreadGatherBill.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUntreadGatherBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUntreadGatherBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUntreadGatherBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UntreadBillNo,
            this.CustomerName,
            this.Address,
            this.GoodsTypeCode,
            this.GoodsSeriesCode,
            this.Quantity,
            this.Remark1,
            this.IsComplete,
            this.IsReturnInvoice,
            this.IsShatter,
            this.EmployeeCode2,
            this.SignDate2,
            this.OperatorCode,
            this.AppendDate,
            this.Id});
            this.dgvUntreadGatherBill.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvUntreadGatherBill.Location = new System.Drawing.Point(8, 14);
            this.dgvUntreadGatherBill.Name = "dgvUntreadGatherBill";
            this.dgvUntreadGatherBill.RowHeadersVisible = false;
            this.dgvUntreadGatherBill.RowTemplate.Height = 23;
            this.dgvUntreadGatherBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUntreadGatherBill.Size = new System.Drawing.Size(829, 440);
            this.dgvUntreadGatherBill.TabIndex = 2;
            this.dgvUntreadGatherBill.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUntreadGatherBill_CellDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvUntreadGatherBill);
            this.groupBox2.Location = new System.Drawing.Point(4, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(843, 461);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "收货单";
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
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "退货数量";
            this.Quantity.Name = "Quantity";
            // 
            // Remark1
            // 
            this.Remark1.DataPropertyName = "Remark1";
            this.Remark1.HeaderText = "退货原因";
            this.Remark1.Name = "Remark1";
            // 
            // IsComplete
            // 
            this.IsComplete.DataPropertyName = "IsComplete";
            this.IsComplete.FalseValue = "0";
            this.IsComplete.HeaderText = "产品是否齐全";
            this.IsComplete.Name = "IsComplete";
            this.IsComplete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsComplete.TrueValue = "1";
            // 
            // IsReturnInvoice
            // 
            this.IsReturnInvoice.DataPropertyName = "IsReturnInvoice";
            this.IsReturnInvoice.FalseValue = "0";
            this.IsReturnInvoice.HeaderText = "发票是否退还";
            this.IsReturnInvoice.Name = "IsReturnInvoice";
            this.IsReturnInvoice.TrueValue = "1";
            // 
            // IsShatter
            // 
            this.IsShatter.DataPropertyName = "IsShatter";
            this.IsShatter.FalseValue = "0";
            this.IsShatter.HeaderText = "产品是否损坏";
            this.IsShatter.Name = "IsShatter";
            this.IsShatter.TrueValue = "1";
            // 
            // EmployeeCode2
            // 
            this.EmployeeCode2.DataPropertyName = "EmployeeCode2";
            this.EmployeeCode2.HeaderText = "收 货 人";
            this.EmployeeCode2.Name = "EmployeeCode2";
            this.EmployeeCode2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // SignDate2
            // 
            this.SignDate2.DataPropertyName = "SignDate2";
            this.SignDate2.HeaderText = "签字日期";
            this.SignDate2.Name = "SignDate2";
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
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "收货单的Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // FormRetailUntreadGatherBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 493);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRetailUntreadGatherBill";
            this.ShowInTaskbar = false;
            this.Text = "收货单";
            this.Load += new System.EventHandler(this.FormRetailUntreadGatherBill_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsUntreadGatherBill)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUntreadGatherBill)).EndInit();
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
        public System.Windows.Forms.DataGridView dgvUntreadGatherBill;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn UntreadBillNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewComboBoxColumn GoodsTypeCode;
        private System.Windows.Forms.DataGridViewComboBoxColumn GoodsSeriesCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsComplete;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsReturnInvoice;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsShatter;
        private System.Windows.Forms.DataGridViewComboBoxColumn EmployeeCode2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SignDate2;
        private System.Windows.Forms.DataGridViewComboBoxColumn OperatorCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppendDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}