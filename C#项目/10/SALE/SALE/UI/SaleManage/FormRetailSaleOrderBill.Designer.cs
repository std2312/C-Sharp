namespace SALE.UI.SaleManage
{
    partial class FormRetailSaleOrderBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRetailSaleOrderBill));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolSave = new System.Windows.Forms.ToolStripButton();
            this.toolAdd = new System.Windows.Forms.ToolStripButton();
            this.toolAmend = new System.Windows.Forms.ToolStripButton();
            this.toolCancel = new System.Windows.Forms.ToolStripButton();
            this.toolBrowse = new System.Windows.Forms.ToolStripButton();
            this.toolDelete = new System.Windows.Forms.ToolStripButton();
            this.toolExit = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.chbIsAgent = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbCustomerType = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxProvinceCode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.gbCustomerType = new System.Windows.Forms.GroupBox();
            this.rbCustomerType3 = new System.Windows.Forms.RadioButton();
            this.rbCustomerType2 = new System.Windows.Forms.RadioButton();
            this.cbxCustomerId = new System.Windows.Forms.ComboBox();
            this.dgvSaleOrderBill = new System.Windows.Forms.DataGridView();
            this.SaleBillNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodsTypeCode = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.GoodsSeriesCode = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsNeedInvoice = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.WriteOffType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WriteOffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CertificateNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SignDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OperatorCode = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.AppendDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.contextAmend = new System.Windows.Forms.ToolStripMenuItem();
            this.contextDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bsSaleOrderBill = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbCustomerType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleOrderBill)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsSaleOrderBill)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSave,
            this.toolAdd,
            this.toolAmend,
            this.toolCancel,
            this.toolBrowse,
            this.toolDelete,
            this.toolExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(851, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolSave
            // 
            this.toolSave.Enabled = false;
            this.toolSave.Image = ((System.Drawing.Image)(resources.GetObject("toolSave.Image")));
            this.toolSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSave.Name = "toolSave";
            this.toolSave.Size = new System.Drawing.Size(49, 22);
            this.toolSave.Text = "保存";
            this.toolSave.Click += new System.EventHandler(this.toolSave_Click);
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
            this.toolAmend.Enabled = false;
            this.toolAmend.Image = ((System.Drawing.Image)(resources.GetObject("toolAmend.Image")));
            this.toolAmend.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAmend.Name = "toolAmend";
            this.toolAmend.Size = new System.Drawing.Size(49, 22);
            this.toolAmend.Text = "修改";
            this.toolAmend.Click += new System.EventHandler(this.toolAmend_Click);
            // 
            // toolCancel
            // 
            this.toolCancel.Enabled = false;
            this.toolCancel.Image = ((System.Drawing.Image)(resources.GetObject("toolCancel.Image")));
            this.toolCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolCancel.Name = "toolCancel";
            this.toolCancel.Size = new System.Drawing.Size(49, 22);
            this.toolCancel.Text = "取消";
            this.toolCancel.Click += new System.EventHandler(this.toolCancel_Click);
            // 
            // toolBrowse
            // 
            this.toolBrowse.Image = ((System.Drawing.Image)(resources.GetObject("toolBrowse.Image")));
            this.toolBrowse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBrowse.Name = "toolBrowse";
            this.toolBrowse.Size = new System.Drawing.Size(49, 22);
            this.toolBrowse.Text = "浏览";
            this.toolBrowse.Click += new System.EventHandler(this.toolBrowse_Click);
            // 
            // toolDelete
            // 
            this.toolDelete.Enabled = false;
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
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.chbIsAgent);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvSaleOrderBill);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(851, 468);
            this.splitContainer1.SplitterDistance = 131;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 9;
            // 
            // chbIsAgent
            // 
            this.chbIsAgent.AutoSize = true;
            this.chbIsAgent.Enabled = false;
            this.chbIsAgent.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chbIsAgent.Location = new System.Drawing.Point(15, 6);
            this.chbIsAgent.Name = "chbIsAgent";
            this.chbIsAgent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chbIsAgent.Size = new System.Drawing.Size(63, 16);
            this.chbIsAgent.TabIndex = 1;
            this.chbIsAgent.Text = "代理商";
            this.chbIsAgent.UseVisualStyleBackColor = true;
            this.chbIsAgent.CheckedChanged += new System.EventHandler(this.chbIsAgent_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbCustomerType);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPhoneNumber);
            this.groupBox1.Controls.Add(this.txtRemark);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtURL);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtPostalCode);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbxProvinceCode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCustomerName);
            this.groupBox1.Controls.Add(this.lb1);
            this.groupBox1.Controls.Add(this.gbCustomerType);
            this.groupBox1.Controls.Add(this.cbxCustomerId);
            this.groupBox1.Location = new System.Drawing.Point(4, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(843, 105);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "用户基本信息";
            // 
            // lbCustomerType
            // 
            this.lbCustomerType.AutoEllipsis = true;
            this.lbCustomerType.AutoSize = true;
            this.lbCustomerType.Location = new System.Drawing.Point(15, 80);
            this.lbCustomerType.Name = "lbCustomerType";
            this.lbCustomerType.Size = new System.Drawing.Size(53, 12);
            this.lbCustomerType.TabIndex = 84;
            this.lbCustomerType.Text = "用户类型";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 82;
            this.label6.Text = "联系电话";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(71, 45);
            this.txtPhoneNumber.MaxLength = 50;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.ReadOnly = true;
            this.txtPhoneNumber.Size = new System.Drawing.Size(156, 21);
            this.txtPhoneNumber.TabIndex = 81;
            this.txtPhoneNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPhoneNumber_KeyDown);
            // 
            // txtRemark
            // 
            this.txtRemark.AcceptsReturn = true;
            this.txtRemark.Location = new System.Drawing.Point(475, 45);
            this.txtRemark.MaxLength = 100;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.ReadOnly = true;
            this.txtRemark.Size = new System.Drawing.Size(365, 21);
            this.txtRemark.TabIndex = 79;
            this.txtRemark.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRemark_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(419, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 78;
            this.label5.Text = "备    注";
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(290, 45);
            this.txtURL.MaxLength = 50;
            this.txtURL.Name = "txtURL";
            this.txtURL.ReadOnly = true;
            this.txtURL.Size = new System.Drawing.Size(126, 21);
            this.txtURL.TabIndex = 73;
            this.txtURL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtURL_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(230, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 12);
            this.label10.TabIndex = 74;
            this.label10.Text = "QQ或Email";
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(709, 16);
            this.txtPostalCode.MaxLength = 6;
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.ReadOnly = true;
            this.txtPostalCode.Size = new System.Drawing.Size(131, 21);
            this.txtPostalCode.TabIndex = 71;
            this.txtPostalCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPostalCode_KeyDown);
            this.txtPostalCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPostalCode_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(653, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 69;
            this.label3.Text = "邮政编码";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(475, 16);
            this.txtAddress.MaxLength = 50;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(174, 21);
            this.txtAddress.TabIndex = 67;
            this.txtAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAddress_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(419, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 68;
            this.label4.Text = "地    址";
            // 
            // cbxProvinceCode
            // 
            this.cbxProvinceCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProvinceCode.Enabled = false;
            this.cbxProvinceCode.FormattingEnabled = true;
            this.cbxProvinceCode.Location = new System.Drawing.Point(290, 16);
            this.cbxProvinceCode.Name = "cbxProvinceCode";
            this.cbxProvinceCode.Size = new System.Drawing.Size(126, 20);
            this.cbxProvinceCode.TabIndex = 66;
            this.cbxProvinceCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbxProvinceCode_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 65;
            this.label1.Text = "所在省市";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.AcceptsReturn = true;
            this.txtCustomerName.Location = new System.Drawing.Point(71, 16);
            this.txtCustomerName.MaxLength = 50;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(156, 21);
            this.txtCustomerName.TabIndex = 41;
            this.txtCustomerName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCustomerName_KeyDown);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(14, 19);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(53, 12);
            this.lb1.TabIndex = 42;
            this.lb1.Text = "用户名称";
            // 
            // gbCustomerType
            // 
            this.gbCustomerType.Controls.Add(this.rbCustomerType3);
            this.gbCustomerType.Controls.Add(this.rbCustomerType2);
            this.gbCustomerType.Location = new System.Drawing.Point(71, 68);
            this.gbCustomerType.Name = "gbCustomerType";
            this.gbCustomerType.Size = new System.Drawing.Size(156, 32);
            this.gbCustomerType.TabIndex = 87;
            this.gbCustomerType.TabStop = false;
            // 
            // rbCustomerType3
            // 
            this.rbCustomerType3.AutoSize = true;
            this.rbCustomerType3.Enabled = false;
            this.rbCustomerType3.Location = new System.Drawing.Point(98, 12);
            this.rbCustomerType3.Name = "rbCustomerType3";
            this.rbCustomerType3.Size = new System.Drawing.Size(47, 16);
            this.rbCustomerType3.TabIndex = 86;
            this.rbCustomerType3.Text = "单位";
            this.rbCustomerType3.UseVisualStyleBackColor = true;
            // 
            // rbCustomerType2
            // 
            this.rbCustomerType2.AutoSize = true;
            this.rbCustomerType2.Checked = true;
            this.rbCustomerType2.Enabled = false;
            this.rbCustomerType2.Location = new System.Drawing.Point(15, 12);
            this.rbCustomerType2.Name = "rbCustomerType2";
            this.rbCustomerType2.Size = new System.Drawing.Size(47, 16);
            this.rbCustomerType2.TabIndex = 85;
            this.rbCustomerType2.TabStop = true;
            this.rbCustomerType2.Text = "个人";
            this.rbCustomerType2.UseVisualStyleBackColor = true;
            // 
            // cbxCustomerId
            // 
            this.cbxCustomerId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCustomerId.Enabled = false;
            this.cbxCustomerId.FormattingEnabled = true;
            this.cbxCustomerId.Location = new System.Drawing.Point(71, 16);
            this.cbxCustomerId.Name = "cbxCustomerId";
            this.cbxCustomerId.Size = new System.Drawing.Size(156, 20);
            this.cbxCustomerId.TabIndex = 88;
            this.cbxCustomerId.Visible = false;
            this.cbxCustomerId.SelectedIndexChanged += new System.EventHandler(this.cbxCustomerId_SelectedIndexChanged);
            // 
            // dgvSaleOrderBill
            // 
            this.dgvSaleOrderBill.AllowUserToAddRows = false;
            this.dgvSaleOrderBill.AllowUserToResizeColumns = false;
            this.dgvSaleOrderBill.AllowUserToResizeRows = false;
            this.dgvSaleOrderBill.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSaleOrderBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSaleOrderBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSaleOrderBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SaleBillNo,
            this.BillDate,
            this.CustomerId,
            this.GoodsTypeCode,
            this.GoodsSeriesCode,
            this.UnitPrice,
            this.Discount,
            this.Quantity,
            this.SaleMoney,
            this.IsNeedInvoice,
            this.WriteOffType,
            this.WriteOffName,
            this.CertificateNumber,
            this.EmployeeCode,
            this.SignDate,
            this.Remark,
            this.OperatorCode,
            this.AppendDate});
            this.dgvSaleOrderBill.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvSaleOrderBill.Location = new System.Drawing.Point(9, 15);
            this.dgvSaleOrderBill.Name = "dgvSaleOrderBill";
            this.dgvSaleOrderBill.RowHeadersVisible = false;
            this.dgvSaleOrderBill.RowTemplate.Height = 23;
            this.dgvSaleOrderBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSaleOrderBill.Size = new System.Drawing.Size(833, 312);
            this.dgvSaleOrderBill.TabIndex = 1;
            this.dgvSaleOrderBill.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSaleOrderBill_CellDoubleClick);
            // 
            // SaleBillNo
            // 
            this.SaleBillNo.DataPropertyName = "SaleBillNo";
            this.SaleBillNo.HeaderText = "销售单号";
            this.SaleBillNo.Name = "SaleBillNo";
            this.SaleBillNo.ReadOnly = true;
            this.SaleBillNo.Width = 120;
            // 
            // BillDate
            // 
            this.BillDate.DataPropertyName = "BillDate";
            this.BillDate.HeaderText = "订货日期";
            this.BillDate.Name = "BillDate";
            this.BillDate.ReadOnly = true;
            this.BillDate.Width = 90;
            // 
            // CustomerId
            // 
            this.CustomerId.DataPropertyName = "CustomerId";
            this.CustomerId.HeaderText = "用户Id";
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.ReadOnly = true;
            this.CustomerId.Visible = false;
            // 
            // GoodsTypeCode
            // 
            this.GoodsTypeCode.DataPropertyName = "GoodsTypeCode";
            this.GoodsTypeCode.HeaderText = "订购种类";
            this.GoodsTypeCode.Name = "GoodsTypeCode";
            this.GoodsTypeCode.ReadOnly = true;
            this.GoodsTypeCode.Width = 120;
            // 
            // GoodsSeriesCode
            // 
            this.GoodsSeriesCode.DataPropertyName = "GoodsSeriesCode";
            this.GoodsSeriesCode.HeaderText = "订购版本";
            this.GoodsSeriesCode.Name = "GoodsSeriesCode";
            this.GoodsSeriesCode.ReadOnly = true;
            // 
            // UnitPrice
            // 
            this.UnitPrice.DataPropertyName = "UnitPrice";
            this.UnitPrice.HeaderText = "标准单价";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            this.UnitPrice.Width = 80;
            // 
            // Discount
            // 
            this.Discount.DataPropertyName = "Discount";
            this.Discount.HeaderText = "折扣系数";
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            this.Discount.Width = 80;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "数    量";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 80;
            // 
            // SaleMoney
            // 
            this.SaleMoney.DataPropertyName = "SaleMoney";
            dataGridViewCellStyle2.NullValue = "Quantity*UnitPrice";
            this.SaleMoney.DefaultCellStyle = dataGridViewCellStyle2;
            this.SaleMoney.HeaderText = "销售总额";
            this.SaleMoney.Name = "SaleMoney";
            this.SaleMoney.Visible = false;
            // 
            // IsNeedInvoice
            // 
            this.IsNeedInvoice.DataPropertyName = "IsNeedInvoice";
            this.IsNeedInvoice.FalseValue = "0";
            this.IsNeedInvoice.HeaderText = "是否要发票";
            this.IsNeedInvoice.Name = "IsNeedInvoice";
            this.IsNeedInvoice.ReadOnly = true;
            this.IsNeedInvoice.TrueValue = "1";
            // 
            // WriteOffType
            // 
            this.WriteOffType.DataPropertyName = "WriteOffType";
            this.WriteOffType.HeaderText = "报销类型";
            this.WriteOffType.Name = "WriteOffType";
            this.WriteOffType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.WriteOffType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // WriteOffName
            // 
            this.WriteOffName.DataPropertyName = "WriteOffName";
            this.WriteOffName.HeaderText = "报销人或单位名称";
            this.WriteOffName.Name = "WriteOffName";
            this.WriteOffName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.WriteOffName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CertificateNumber
            // 
            this.CertificateNumber.DataPropertyName = "CertificateNumber";
            this.CertificateNumber.HeaderText = "证件号码";
            this.CertificateNumber.Name = "CertificateNumber";
            // 
            // EmployeeCode
            // 
            this.EmployeeCode.DataPropertyName = "EmployeeCode";
            this.EmployeeCode.HeaderText = "下 单 人";
            this.EmployeeCode.Name = "EmployeeCode";
            this.EmployeeCode.ReadOnly = true;
            this.EmployeeCode.Width = 80;
            // 
            // SignDate
            // 
            this.SignDate.DataPropertyName = "SignDate";
            this.SignDate.HeaderText = "日    期";
            this.SignDate.Name = "SignDate";
            this.SignDate.ReadOnly = true;
            this.SignDate.Width = 90;
            // 
            // Remark
            // 
            this.Remark.DataPropertyName = "Remark";
            this.Remark.HeaderText = "备    注";
            this.Remark.Name = "Remark";
            this.Remark.ReadOnly = true;
            this.Remark.Width = 200;
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextAdd,
            this.contextAmend,
            this.contextDelete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 92);
            // 
            // contextAdd
            // 
            this.contextAdd.Name = "contextAdd";
            this.contextAdd.Size = new System.Drawing.Size(152, 22);
            this.contextAdd.Text = "添加订货单";
            this.contextAdd.Click += new System.EventHandler(this.contextAdd_Click);
            // 
            // contextAmend
            // 
            this.contextAmend.Name = "contextAmend";
            this.contextAmend.Size = new System.Drawing.Size(152, 22);
            this.contextAmend.Text = "修改订货单";
            this.contextAmend.Click += new System.EventHandler(this.contextAmend_Click);
            // 
            // contextDelete
            // 
            this.contextDelete.Name = "contextDelete";
            this.contextDelete.Size = new System.Drawing.Size(152, 22);
            this.contextDelete.Text = "删除订货单";
            this.contextDelete.Click += new System.EventHandler(this.contextDelete_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(4, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(843, 330);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "销售订货单";
            // 
            // FormRetailSaleOrderBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 493);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRetailSaleOrderBill";
            this.Text = "订货单";
            this.Load += new System.EventHandler(this.FormRetailOperation_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbCustomerType.ResumeLayout(false);
            this.gbCustomerType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleOrderBill)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsSaleOrderBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolExit;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbCustomerType;
        private System.Windows.Forms.GroupBox gbCustomerType;
        public System.Windows.Forms.TextBox txtCustomerName;
        public System.Windows.Forms.ComboBox cbxProvinceCode;
        public System.Windows.Forms.TextBox txtURL;
        public System.Windows.Forms.TextBox txtPostalCode;
        public System.Windows.Forms.TextBox txtAddress;
        public System.Windows.Forms.TextBox txtRemark;
        public System.Windows.Forms.TextBox txtPhoneNumber;
        public System.Windows.Forms.RadioButton rbCustomerType3;
        public System.Windows.Forms.RadioButton rbCustomerType2;
        public System.Windows.Forms.ToolStripButton toolAdd;
        public System.Windows.Forms.ToolStripButton toolAmend;
        public System.Windows.Forms.ToolStripButton toolDelete;
        public System.Windows.Forms.ToolStripButton toolSave;
        public System.Windows.Forms.ToolStripButton toolCancel;
        public System.Windows.Forms.ToolStripButton toolBrowse;
        public System.Windows.Forms.BindingSource bsSaleOrderBill;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem contextAdd;
        private System.Windows.Forms.ToolStripMenuItem contextAmend;
        private System.Windows.Forms.ToolStripMenuItem contextDelete;
        public System.Windows.Forms.DataGridView dgvSaleOrderBill;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleBillNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerId;
        private System.Windows.Forms.DataGridViewComboBoxColumn GoodsTypeCode;
        private System.Windows.Forms.DataGridViewComboBoxColumn GoodsSeriesCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleMoney;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsNeedInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn WriteOffType;
        private System.Windows.Forms.DataGridViewTextBoxColumn WriteOffName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CertificateNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn SignDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
        private System.Windows.Forms.DataGridViewComboBoxColumn OperatorCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppendDate;
        public System.Windows.Forms.ComboBox cbxCustomerId;
        public System.Windows.Forms.CheckBox chbIsAgent;
    }
}