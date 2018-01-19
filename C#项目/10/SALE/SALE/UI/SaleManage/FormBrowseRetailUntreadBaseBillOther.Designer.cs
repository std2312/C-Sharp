namespace SALE.UI.SaleManage
{
    partial class FormBrowseRetailUntreadBaseBillOther
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtCDNo = new System.Windows.Forms.TextBox();
            this.chbIsCDNo = new System.Windows.Forms.CheckBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxProvinceCode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbIsRefund = new System.Windows.Forms.CheckBox();
            this.chbIsGather = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxGoodsSeriesCode = new System.Windows.Forms.ComboBox();
            this.cbxGoodsTypeCode = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dtpUntreadBillDate = new System.Windows.Forms.DateTimePicker();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvUntreadBaseBill = new System.Windows.Forms.DataGridView();
            this.UntreadBillNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UntreadBillDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WriteOffType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WriteOffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodsTypeCode = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.GoodsSeriesCode = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeCode1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SignDate1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OperatorCode = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.BankCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpenAccBankName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppendDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleBillNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsNeedInvoice = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BillDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CertificateNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUntreadBaseBill)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(504, 98);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 95;
            this.btnReturn.Text = "返回";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(415, 98);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 94;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(326, 98);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 93;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 92;
            this.label6.Text = "联系电话";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(66, 41);
            this.txtPhoneNumber.MaxLength = 50;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(142, 21);
            this.txtPhoneNumber.TabIndex = 91;
            // 
            // txtCDNo
            // 
            this.txtCDNo.Enabled = false;
            this.txtCDNo.Location = new System.Drawing.Point(66, 101);
            this.txtCDNo.MaxLength = 8;
            this.txtCDNo.Name = "txtCDNo";
            this.txtCDNo.Size = new System.Drawing.Size(142, 21);
            this.txtCDNo.TabIndex = 2;
            // 
            // chbIsCDNo
            // 
            this.chbIsCDNo.AutoSize = true;
            this.chbIsCDNo.Location = new System.Drawing.Point(4, 103);
            this.chbIsCDNo.Name = "chbIsCDNo";
            this.chbIsCDNo.Size = new System.Drawing.Size(60, 16);
            this.chbIsCDNo.TabIndex = 120;
            this.chbIsCDNo.Text = "光盘号";
            this.chbIsCDNo.UseVisualStyleBackColor = true;
            this.chbIsCDNo.CheckedChanged += new System.EventHandler(this.chbIsCDNo_CheckedChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(438, 12);
            this.txtAddress.MaxLength = 50;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(148, 21);
            this.txtAddress.TabIndex = 87;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 88;
            this.label4.Text = "地    址";
            // 
            // cbxProvinceCode
            // 
            this.cbxProvinceCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProvinceCode.FormattingEnabled = true;
            this.cbxProvinceCode.Location = new System.Drawing.Point(268, 12);
            this.cbxProvinceCode.Name = "cbxProvinceCode";
            this.cbxProvinceCode.Size = new System.Drawing.Size(111, 20);
            this.cbxProvinceCode.TabIndex = 86;
            this.cbxProvinceCode.Tag = "ProvinceCode";
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 85;
            this.label1.Text = "所在省市";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbIsRefund);
            this.groupBox1.Controls.Add(this.chbIsGather);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbxGoodsSeriesCode);
            this.groupBox1.Controls.Add(this.cbxGoodsTypeCode);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.dtpUntreadBillDate);
            this.groupBox1.Controls.Add(this.btnReturn);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnQuery);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPhoneNumber);
            this.groupBox1.Controls.Add(this.txtCDNo);
            this.groupBox1.Controls.Add(this.chbIsCDNo);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbxProvinceCode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCustomerName);
            this.groupBox1.Controls.Add(this.lb1);
            this.groupBox1.Location = new System.Drawing.Point(4, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 128);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // chbIsRefund
            // 
            this.chbIsRefund.AutoSize = true;
            this.chbIsRefund.Checked = true;
            this.chbIsRefund.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbIsRefund.Enabled = false;
            this.chbIsRefund.Location = new System.Drawing.Point(213, 73);
            this.chbIsRefund.Name = "chbIsRefund";
            this.chbIsRefund.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chbIsRefund.Size = new System.Drawing.Size(108, 16);
            this.chbIsRefund.TabIndex = 134;
            this.chbIsRefund.Text = "未录入退款信息";
            this.chbIsRefund.UseVisualStyleBackColor = true;
            this.chbIsRefund.Visible = false;
            // 
            // chbIsGather
            // 
            this.chbIsGather.AutoSize = true;
            this.chbIsGather.Checked = true;
            this.chbIsGather.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbIsGather.Enabled = false;
            this.chbIsGather.Location = new System.Drawing.Point(213, 73);
            this.chbIsGather.Name = "chbIsGather";
            this.chbIsGather.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chbIsGather.Size = new System.Drawing.Size(108, 16);
            this.chbIsGather.TabIndex = 133;
            this.chbIsGather.Text = "未录入收货信息";
            this.chbIsGather.UseVisualStyleBackColor = true;
            this.chbIsGather.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(381, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 132;
            this.label7.Text = "产品版本";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 131;
            this.label5.Text = "产品种类";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 130;
            this.label2.Text = "退货日期";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 130;
            this.label3.Text = "退货日期";
            // 
            // cbxGoodsSeriesCode
            // 
            this.cbxGoodsSeriesCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGoodsSeriesCode.FormattingEnabled = true;
            this.cbxGoodsSeriesCode.Location = new System.Drawing.Point(438, 41);
            this.cbxGoodsSeriesCode.Name = "cbxGoodsSeriesCode";
            this.cbxGoodsSeriesCode.Size = new System.Drawing.Size(148, 20);
            this.cbxGoodsSeriesCode.TabIndex = 128;
            this.cbxGoodsSeriesCode.Tag = "GoodsSeriesCode";
            // 
            // cbxGoodsTypeCode
            // 
            this.cbxGoodsTypeCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGoodsTypeCode.FormattingEnabled = true;
            this.cbxGoodsTypeCode.Location = new System.Drawing.Point(268, 41);
            this.cbxGoodsTypeCode.Name = "cbxGoodsTypeCode";
            this.cbxGoodsTypeCode.Size = new System.Drawing.Size(111, 20);
            this.cbxGoodsTypeCode.TabIndex = 126;
            this.cbxGoodsTypeCode.Tag = "GoodsTypeCode";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(109, 203);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowCheckBox = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(111, 21);
            this.dateTimePicker1.TabIndex = 122;
            // 
            // dtpUntreadBillDate
            // 
            this.dtpUntreadBillDate.Checked = false;
            this.dtpUntreadBillDate.Location = new System.Drawing.Point(66, 70);
            this.dtpUntreadBillDate.Name = "dtpUntreadBillDate";
            this.dtpUntreadBillDate.ShowCheckBox = true;
            this.dtpUntreadBillDate.Size = new System.Drawing.Size(142, 21);
            this.dtpUntreadBillDate.TabIndex = 122;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.AcceptsReturn = true;
            this.txtCustomerName.Location = new System.Drawing.Point(66, 12);
            this.txtCustomerName.MaxLength = 50;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(142, 21);
            this.txtCustomerName.TabIndex = 0;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(11, 15);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(53, 12);
            this.lb1.TabIndex = 84;
            this.lb1.Text = "用户名称";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvUntreadBaseBill);
            this.groupBox2.Location = new System.Drawing.Point(4, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(595, 229);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "退货记录";
            // 
            // dgvUntreadBaseBill
            // 
            this.dgvUntreadBaseBill.AllowUserToAddRows = false;
            this.dgvUntreadBaseBill.AllowUserToResizeColumns = false;
            this.dgvUntreadBaseBill.AllowUserToResizeRows = false;
            this.dgvUntreadBaseBill.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUntreadBaseBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUntreadBaseBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUntreadBaseBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UntreadBillNo,
            this.UntreadBillDate,
            this.CustomerName,
            this.Address,
            this.PhoneNumber,
            this.WriteOffType,
            this.WriteOffName,
            this.GoodsTypeCode,
            this.GoodsSeriesCode,
            this.UnitPrice,
            this.Quantity,
            this.AccountNumber,
            this.EmployeeCode1,
            this.SignDate1,
            this.Remark1,
            this.OperatorCode,
            this.BankCode,
            this.OpenAccBankName,
            this.AppendDate,
            this.CustomerId,
            this.SaleBillNo,
            this.IsNeedInvoice,
            this.BillDate,
            this.CustomerType,
            this.CertificateNumber});
            this.dgvUntreadBaseBill.Location = new System.Drawing.Point(6, 14);
            this.dgvUntreadBaseBill.Name = "dgvUntreadBaseBill";
            this.dgvUntreadBaseBill.RowHeadersVisible = false;
            this.dgvUntreadBaseBill.RowTemplate.Height = 23;
            this.dgvUntreadBaseBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUntreadBaseBill.Size = new System.Drawing.Size(584, 209);
            this.dgvUntreadBaseBill.TabIndex = 3;
            this.dgvUntreadBaseBill.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUntreadBaseBill_CellDoubleClick);
            // 
            // UntreadBillNo
            // 
            this.UntreadBillNo.DataPropertyName = "UntreadBillNo";
            this.UntreadBillNo.HeaderText = "退货单号";
            this.UntreadBillNo.Name = "UntreadBillNo";
            // 
            // UntreadBillDate
            // 
            this.UntreadBillDate.DataPropertyName = "UntreadBillDate";
            this.UntreadBillDate.HeaderText = "退货日期";
            this.UntreadBillDate.Name = "UntreadBillDate";
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
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            this.PhoneNumber.HeaderText = "联系电话";
            this.PhoneNumber.Name = "PhoneNumber";
            // 
            // WriteOffType
            // 
            this.WriteOffType.DataPropertyName = "WriteOffType";
            this.WriteOffType.HeaderText = "报销类型";
            this.WriteOffType.Name = "WriteOffType";
            this.WriteOffType.Visible = false;
            // 
            // WriteOffName
            // 
            this.WriteOffName.DataPropertyName = "WriteOffName";
            this.WriteOffName.HeaderText = "报销人姓名或报销单位名称";
            this.WriteOffName.Name = "WriteOffName";
            this.WriteOffName.Visible = false;
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
            this.UnitPrice.HeaderText = "单    价";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.Visible = false;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "退货数量";
            this.Quantity.Name = "Quantity";
            // 
            // AccountNumber
            // 
            this.AccountNumber.DataPropertyName = "AccountNumber";
            this.AccountNumber.HeaderText = "银行账号";
            this.AccountNumber.Name = "AccountNumber";
            this.AccountNumber.Visible = false;
            // 
            // EmployeeCode1
            // 
            this.EmployeeCode1.DataPropertyName = "EmployeeCode1";
            this.EmployeeCode1.HeaderText = "下 单 人";
            this.EmployeeCode1.Name = "EmployeeCode1";
            this.EmployeeCode1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeeCode1.Visible = false;
            // 
            // SignDate1
            // 
            this.SignDate1.DataPropertyName = "SignDate1";
            this.SignDate1.HeaderText = "签字日期";
            this.SignDate1.Name = "SignDate1";
            this.SignDate1.Visible = false;
            // 
            // Remark1
            // 
            this.Remark1.DataPropertyName = "Remark1";
            this.Remark1.HeaderText = "退货原因";
            this.Remark1.Name = "Remark1";
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
            // BankCode
            // 
            this.BankCode.DataPropertyName = "BankCode";
            this.BankCode.HeaderText = "银行代码";
            this.BankCode.Name = "BankCode";
            this.BankCode.Visible = false;
            // 
            // OpenAccBankName
            // 
            this.OpenAccBankName.DataPropertyName = "OpenAccBankName";
            this.OpenAccBankName.HeaderText = "企业帐户";
            this.OpenAccBankName.Name = "OpenAccBankName";
            this.OpenAccBankName.Visible = false;
            // 
            // AppendDate
            // 
            this.AppendDate.DataPropertyName = "AppendDate";
            this.AppendDate.HeaderText = "录入日期";
            this.AppendDate.Name = "AppendDate";
            this.AppendDate.Visible = false;
            // 
            // CustomerId
            // 
            this.CustomerId.DataPropertyName = "CustomerId";
            this.CustomerId.HeaderText = "客户Id";
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.Visible = false;
            // 
            // SaleBillNo
            // 
            this.SaleBillNo.DataPropertyName = "SaleBillNo";
            this.SaleBillNo.HeaderText = "销售单号";
            this.SaleBillNo.Name = "SaleBillNo";
            this.SaleBillNo.ReadOnly = true;
            this.SaleBillNo.Visible = false;
            this.SaleBillNo.Width = 120;
            // 
            // IsNeedInvoice
            // 
            this.IsNeedInvoice.DataPropertyName = "IsNeedInvoice";
            this.IsNeedInvoice.HeaderText = "是否要发票";
            this.IsNeedInvoice.Name = "IsNeedInvoice";
            this.IsNeedInvoice.Visible = false;
            // 
            // BillDate
            // 
            this.BillDate.DataPropertyName = "BillDate";
            this.BillDate.HeaderText = "订单日期";
            this.BillDate.Name = "BillDate";
            this.BillDate.Visible = false;
            // 
            // CustomerType
            // 
            this.CustomerType.DataPropertyName = "CustomerType";
            this.CustomerType.HeaderText = "用户类型";
            this.CustomerType.Name = "CustomerType";
            this.CustomerType.Visible = false;
            // 
            // CertificateNumber
            // 
            this.CertificateNumber.DataPropertyName = "CertificateNumber";
            this.CertificateNumber.HeaderText = "证件号码";
            this.CertificateNumber.Name = "CertificateNumber";
            this.CertificateNumber.Visible = false;
            // 
            // FormBrowseRetailUntreadBaseBillOther
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 364);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBrowseRetailUntreadBaseBillOther";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "查询退货单";
            this.Load += new System.EventHandler(this.FormBrowseRetailUntreadBaseBillOther_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUntreadBaseBill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtCDNo;
        private System.Windows.Forms.CheckBox chbIsCDNo;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxProvinceCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxGoodsSeriesCode;
        private System.Windows.Forms.ComboBox cbxGoodsTypeCode;
        private System.Windows.Forms.DateTimePicker dtpUntreadBillDate;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox chbIsGather;
        public System.Windows.Forms.DataGridView dgvUntreadBaseBill;
        private System.Windows.Forms.CheckBox chbIsRefund;
        private System.Windows.Forms.DataGridViewTextBoxColumn UntreadBillNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn UntreadBillDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn WriteOffType;
        private System.Windows.Forms.DataGridViewTextBoxColumn WriteOffName;
        private System.Windows.Forms.DataGridViewComboBoxColumn GoodsTypeCode;
        private System.Windows.Forms.DataGridViewComboBoxColumn GoodsSeriesCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountNumber;
        private System.Windows.Forms.DataGridViewComboBoxColumn EmployeeCode1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SignDate1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark1;
        private System.Windows.Forms.DataGridViewComboBoxColumn OperatorCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn BankCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpenAccBankName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppendDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleBillNo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsNeedInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerType;
        private System.Windows.Forms.DataGridViewTextBoxColumn CertificateNumber;
    }
}