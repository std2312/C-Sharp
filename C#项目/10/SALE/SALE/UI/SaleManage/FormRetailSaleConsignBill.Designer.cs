namespace SALE.UI.SaleManage
{
    partial class FormRetailSaleConsignBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRetailSaleConsignBill));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolAdd = new System.Windows.Forms.ToolStripButton();
            this.toolAmend = new System.Windows.Forms.ToolStripButton();
            this.toolBrowse = new System.Windows.Forms.ToolStripButton();
            this.toolDelete = new System.Windows.Forms.ToolStripButton();
            this.toolExit = new System.Windows.Forms.ToolStripButton();
            this.bsSaleConsignBill = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.contextAmend = new System.Windows.Forms.ToolStripMenuItem();
            this.contextQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.contextDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvSaleConsignBill = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SaleBillNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsComplete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.GoodsTypeCode1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.GoodsSeriesCode1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ConsignDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpressBillNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsignCorpCode = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.EmployeeCode4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SignDate4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OperatorCode = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.AppendDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsSaleConsignBill)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleConsignBill)).BeginInit();
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
            this.toolStrip1.TabIndex = 11;
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
            this.contextAdd.Text = "添加发货单";
            this.contextAdd.Click += new System.EventHandler(this.contextAdd_Click);
            // 
            // contextAmend
            // 
            this.contextAmend.Name = "contextAmend";
            this.contextAmend.Size = new System.Drawing.Size(130, 22);
            this.contextAmend.Text = "修改发货单";
            this.contextAmend.Click += new System.EventHandler(this.contextAmend_Click);
            // 
            // contextQuery
            // 
            this.contextQuery.Name = "contextQuery";
            this.contextQuery.Size = new System.Drawing.Size(130, 22);
            this.contextQuery.Text = "查询发货单";
            this.contextQuery.Click += new System.EventHandler(this.contextQuery_Click);
            // 
            // contextDelete
            // 
            this.contextDelete.Name = "contextDelete";
            this.contextDelete.Size = new System.Drawing.Size(130, 22);
            this.contextDelete.Text = "删除发货单";
            this.contextDelete.Click += new System.EventHandler(this.contextDelete_Click);
            // 
            // dgvSaleConsignBill
            // 
            this.dgvSaleConsignBill.AllowUserToAddRows = false;
            this.dgvSaleConsignBill.AllowUserToResizeColumns = false;
            this.dgvSaleConsignBill.AllowUserToResizeRows = false;
            this.dgvSaleConsignBill.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSaleConsignBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSaleConsignBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSaleConsignBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SaleBillNo,
            this.IsComplete,
            this.GoodsTypeCode1,
            this.GoodsSeriesCode1,
            this.ConsignDate,
            this.ExpressBillNo,
            this.ConsignCorpCode,
            this.EmployeeCode4,
            this.SignDate4,
            this.Remark2,
            this.OperatorCode,
            this.AppendDate,
            this.Id});
            this.dgvSaleConsignBill.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvSaleConsignBill.Location = new System.Drawing.Point(8, 14);
            this.dgvSaleConsignBill.Name = "dgvSaleConsignBill";
            this.dgvSaleConsignBill.RowHeadersVisible = false;
            this.dgvSaleConsignBill.RowTemplate.Height = 23;
            this.dgvSaleConsignBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSaleConsignBill.Size = new System.Drawing.Size(829, 440);
            this.dgvSaleConsignBill.TabIndex = 2;
            this.dgvSaleConsignBill.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSaleConsignBill_CellDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvSaleConsignBill);
            this.groupBox2.Location = new System.Drawing.Point(4, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(843, 461);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "销售发货单";
            // 
            // SaleBillNo
            // 
            this.SaleBillNo.DataPropertyName = "SaleBillNo";
            this.SaleBillNo.HeaderText = "销售单号";
            this.SaleBillNo.Name = "SaleBillNo";
            this.SaleBillNo.ReadOnly = true;
            this.SaleBillNo.Width = 120;
            // 
            // IsComplete
            // 
            this.IsComplete.DataPropertyName = "IsComplete";
            this.IsComplete.FalseValue = "0";
            this.IsComplete.HeaderText = "是否完整";
            this.IsComplete.Name = "IsComplete";
            this.IsComplete.TrueValue = "1";
            // 
            // GoodsTypeCode1
            // 
            this.GoodsTypeCode1.DataPropertyName = "GoodsTypeCode1";
            this.GoodsTypeCode1.HeaderText = "实发种类";
            this.GoodsTypeCode1.Name = "GoodsTypeCode1";
            // 
            // GoodsSeriesCode1
            // 
            this.GoodsSeriesCode1.DataPropertyName = "GoodsSeriesCode1";
            this.GoodsSeriesCode1.HeaderText = "实发版本";
            this.GoodsSeriesCode1.Name = "GoodsSeriesCode1";
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
            this.ConsignCorpCode.HeaderText = "发货公司";
            this.ConsignCorpCode.Name = "ConsignCorpCode";
            // 
            // EmployeeCode4
            // 
            this.EmployeeCode4.DataPropertyName = "EmployeeCode4";
            this.EmployeeCode4.HeaderText = "发 货 人";
            this.EmployeeCode4.Name = "EmployeeCode4";
            // 
            // SignDate4
            // 
            this.SignDate4.DataPropertyName = "SignDate4";
            this.SignDate4.HeaderText = "日    期";
            this.SignDate4.Name = "SignDate4";
            // 
            // Remark2
            // 
            this.Remark2.DataPropertyName = "Remark2";
            this.Remark2.HeaderText = "备    注";
            this.Remark2.Name = "Remark2";
            // 
            // OperatorCode
            // 
            this.OperatorCode.DataPropertyName = "OperatorCode";
            this.OperatorCode.HeaderText = "录入人员";
            this.OperatorCode.Name = "OperatorCode";
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
            // FormRetailSaleConsignBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 493);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRetailSaleConsignBill";
            this.Text = "销售发货单";
            this.Load += new System.EventHandler(this.FormRetailSaleConsignBill_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsSaleConsignBill)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleConsignBill)).EndInit();
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
        public System.Windows.Forms.BindingSource bsSaleConsignBill;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem contextAdd;
        private System.Windows.Forms.ToolStripMenuItem contextAmend;
        private System.Windows.Forms.ToolStripMenuItem contextQuery;
        private System.Windows.Forms.ToolStripMenuItem contextDelete;
        public System.Windows.Forms.DataGridView dgvSaleConsignBill;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleBillNo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsComplete;
        private System.Windows.Forms.DataGridViewComboBoxColumn GoodsTypeCode1;
        private System.Windows.Forms.DataGridViewComboBoxColumn GoodsSeriesCode1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsignDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpressBillNo;
        private System.Windows.Forms.DataGridViewComboBoxColumn ConsignCorpCode;
        private System.Windows.Forms.DataGridViewComboBoxColumn EmployeeCode4;
        private System.Windows.Forms.DataGridViewTextBoxColumn SignDate4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark2;
        private System.Windows.Forms.DataGridViewComboBoxColumn OperatorCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppendDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}