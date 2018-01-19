namespace SALE.UI.SaleManage
{
    partial class FormRetailBarterConsignBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRetailBarterConsignBill));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolAdd = new System.Windows.Forms.ToolStripButton();
            this.toolAmend = new System.Windows.Forms.ToolStripButton();
            this.toolBrowse = new System.Windows.Forms.ToolStripButton();
            this.toolDelete = new System.Windows.Forms.ToolStripButton();
            this.toolExit = new System.Windows.Forms.ToolStripButton();
            this.dgvBarterConsignBill = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.contextAmend = new System.Windows.Forms.ToolStripMenuItem();
            this.contextQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.contextDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bsBarterConsignBill = new System.Windows.Forms.BindingSource(this.components);
            this.BarterBillNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodsTypeCode = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.GoodsSeriesCode = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.IsComplete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ConsignDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpressBillNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsignCorpCode = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.EmployeeCode3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SignDate3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OperatorCode = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.AppendDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarterConsignBill)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsBarterConsignBill)).BeginInit();
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
            // dgvBarterConsignBill
            // 
            this.dgvBarterConsignBill.AllowUserToAddRows = false;
            this.dgvBarterConsignBill.AllowUserToResizeColumns = false;
            this.dgvBarterConsignBill.AllowUserToResizeRows = false;
            this.dgvBarterConsignBill.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBarterConsignBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBarterConsignBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBarterConsignBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BarterBillNo,
            this.CustomerName,
            this.Address,
            this.GoodsTypeCode,
            this.GoodsSeriesCode,
            this.IsComplete,
            this.ConsignDate,
            this.ExpressBillNo,
            this.ConsignCorpCode,
            this.EmployeeCode3,
            this.SignDate3,
            this.OperatorCode,
            this.AppendDate,
            this.Id,
            this.Remark3});
            this.dgvBarterConsignBill.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvBarterConsignBill.Location = new System.Drawing.Point(7, 14);
            this.dgvBarterConsignBill.Name = "dgvBarterConsignBill";
            this.dgvBarterConsignBill.RowHeadersVisible = false;
            this.dgvBarterConsignBill.RowTemplate.Height = 23;
            this.dgvBarterConsignBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBarterConsignBill.Size = new System.Drawing.Size(829, 440);
            this.dgvBarterConsignBill.TabIndex = 3;
            this.dgvBarterConsignBill.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBarterConsignBill_CellDoubleClick);
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
            this.contextAdd.Text = "添加发货单";
            this.contextAdd.Click += new System.EventHandler(this.toolAdd_Click);
            // 
            // contextAmend
            // 
            this.contextAmend.Name = "contextAmend";
            this.contextAmend.Size = new System.Drawing.Size(130, 22);
            this.contextAmend.Text = "修改发货单";
            this.contextAmend.Click += new System.EventHandler(this.toolAmend_Click);
            // 
            // contextQuery
            // 
            this.contextQuery.Name = "contextQuery";
            this.contextQuery.Size = new System.Drawing.Size(130, 22);
            this.contextQuery.Text = "查询发货单";
            this.contextQuery.Click += new System.EventHandler(this.toolBrowse_Click);
            // 
            // contextDelete
            // 
            this.contextDelete.Name = "contextDelete";
            this.contextDelete.Size = new System.Drawing.Size(130, 22);
            this.contextDelete.Text = "删除发货单";
            this.contextDelete.Click += new System.EventHandler(this.toolDelete_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvBarterConsignBill);
            this.groupBox2.Location = new System.Drawing.Point(4, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(843, 461);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "发货单";
            // 
            // bsBarterConsignBill
            // 
            this.bsBarterConsignBill.AllowNew = true;
            // 
            // BarterBillNo
            // 
            this.BarterBillNo.DataPropertyName = "BarterBillNo";
            this.BarterBillNo.HeaderText = "换货单号";
            this.BarterBillNo.Name = "BarterBillNo";
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
            this.GoodsTypeCode.HeaderText = "实发种类";
            this.GoodsTypeCode.Name = "GoodsTypeCode";
            this.GoodsTypeCode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // GoodsSeriesCode
            // 
            this.GoodsSeriesCode.DataPropertyName = "GoodsSeriesCode";
            this.GoodsSeriesCode.HeaderText = "实发版本";
            this.GoodsSeriesCode.Name = "GoodsSeriesCode";
            this.GoodsSeriesCode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // IsComplete
            // 
            this.IsComplete.DataPropertyName = "IsComplete";
            this.IsComplete.FalseValue = "0";
            this.IsComplete.HeaderText = "是否齐全";
            this.IsComplete.Name = "IsComplete";
            this.IsComplete.TrueValue = "1";
            // 
            // ConsignDate
            // 
            this.ConsignDate.DataPropertyName = "ConsignDate";
            this.ConsignDate.HeaderText = "发货日期";
            this.ConsignDate.Name = "ConsignDate";
            // 
            // ExpressBillNo
            // 
            this.ExpressBillNo.DataPropertyName = "ExpressBillNo";
            this.ExpressBillNo.HeaderText = "快递单号";
            this.ExpressBillNo.Name = "ExpressBillNo";
            // 
            // ConsignCorpCode
            // 
            this.ConsignCorpCode.DataPropertyName = "ConsignCorpCode";
            this.ConsignCorpCode.HeaderText = "快递公司";
            this.ConsignCorpCode.Name = "ConsignCorpCode";
            // 
            // EmployeeCode3
            // 
            this.EmployeeCode3.DataPropertyName = "EmployeeCode3";
            this.EmployeeCode3.HeaderText = "发  货 人";
            this.EmployeeCode3.Name = "EmployeeCode3";
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
            this.Id.HeaderText = "自增序号";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Remark3
            // 
            this.Remark3.DataPropertyName = "Remark3";
            this.Remark3.HeaderText = "备    注";
            this.Remark3.Name = "Remark3";
            this.Remark3.Visible = false;
            // 
            // FormRetailBarterConsignBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 493);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRetailBarterConsignBill";
            this.ShowInTaskbar = false;
            this.Text = "发货单";
            this.Load += new System.EventHandler(this.FormRetailBarterConsignBill_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarterConsignBill)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsBarterConsignBill)).EndInit();
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
        public System.Windows.Forms.DataGridView dgvBarterConsignBill;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem contextAdd;
        private System.Windows.Forms.ToolStripMenuItem contextAmend;
        private System.Windows.Forms.ToolStripMenuItem contextQuery;
        private System.Windows.Forms.ToolStripMenuItem contextDelete;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.BindingSource bsBarterConsignBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn BarterBillNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewComboBoxColumn GoodsTypeCode;
        private System.Windows.Forms.DataGridViewComboBoxColumn GoodsSeriesCode;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsComplete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsignDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpressBillNo;
        private System.Windows.Forms.DataGridViewComboBoxColumn ConsignCorpCode;
        private System.Windows.Forms.DataGridViewComboBoxColumn EmployeeCode3;
        private System.Windows.Forms.DataGridViewTextBoxColumn SignDate3;
        private System.Windows.Forms.DataGridViewComboBoxColumn OperatorCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppendDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark3;
    }
}