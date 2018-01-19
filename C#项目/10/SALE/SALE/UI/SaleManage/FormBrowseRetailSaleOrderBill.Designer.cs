namespace SALE.UI.SaleManage
{
    partial class FormBrowseRetailSaleOrderBill
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbConsign = new System.Windows.Forms.CheckBox();
            this.chbIsTrade = new System.Windows.Forms.CheckBox();
            this.dtpBillDate = new System.Windows.Forms.DateTimePicker();
            this.txtSaleBillNo = new System.Windows.Forms.TextBox();
            this.lbSaleBillNo = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
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
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvRetailSaleOrderBill = new System.Windows.Forms.DataGridView();
            this.SaleBillNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodsTypeCode = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.GoodsSeriesCode = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PostalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeCode = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ProvinceCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.URL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OperatorCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppendDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerId1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsNeedInvoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WriteOffType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WriteOffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CertificateNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SignDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRetailSaleOrderBill)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbConsign);
            this.groupBox1.Controls.Add(this.chbIsTrade);
            this.groupBox1.Controls.Add(this.dtpBillDate);
            this.groupBox1.Controls.Add(this.txtSaleBillNo);
            this.groupBox1.Controls.Add(this.lbSaleBillNo);
            this.groupBox1.Controls.Add(this.btnReturn);
            this.groupBox1.Controls.Add(this.label2);
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
            this.groupBox1.Size = new System.Drawing.Size(595, 98);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // chbConsign
            // 
            this.chbConsign.AutoSize = true;
            this.chbConsign.Checked = true;
            this.chbConsign.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbConsign.Enabled = false;
            this.chbConsign.Location = new System.Drawing.Point(383, 43);
            this.chbConsign.Name = "chbConsign";
            this.chbConsign.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chbConsign.Size = new System.Drawing.Size(204, 16);
            this.chbConsign.TabIndex = 124;
            this.chbConsign.Text = "未录入发货单（但已录入交易单）";
            this.chbConsign.UseVisualStyleBackColor = true;
            this.chbConsign.Visible = false;
            // 
            // chbIsTrade
            // 
            this.chbIsTrade.AutoSize = true;
            this.chbIsTrade.Checked = true;
            this.chbIsTrade.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbIsTrade.Location = new System.Drawing.Point(459, 43);
            this.chbIsTrade.Name = "chbIsTrade";
            this.chbIsTrade.Size = new System.Drawing.Size(108, 16);
            this.chbIsTrade.TabIndex = 123;
            this.chbIsTrade.Text = "未录入交易单的";
            this.chbIsTrade.UseVisualStyleBackColor = true;
            this.chbIsTrade.Visible = false;
            // 
            // dtpBillDate
            // 
            this.dtpBillDate.Checked = false;
            this.dtpBillDate.Location = new System.Drawing.Point(268, 41);
            this.dtpBillDate.Name = "dtpBillDate";
            this.dtpBillDate.ShowCheckBox = true;
            this.dtpBillDate.Size = new System.Drawing.Size(111, 21);
            this.dtpBillDate.TabIndex = 122;
            // 
            // txtSaleBillNo
            // 
            this.txtSaleBillNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSaleBillNo.Location = new System.Drawing.Point(435, 41);
            this.txtSaleBillNo.MaxLength = 50;
            this.txtSaleBillNo.Name = "txtSaleBillNo";
            this.txtSaleBillNo.Size = new System.Drawing.Size(154, 21);
            this.txtSaleBillNo.TabIndex = 89;
            this.txtSaleBillNo.Visible = false;
            // 
            // lbSaleBillNo
            // 
            this.lbSaleBillNo.AutoSize = true;
            this.lbSaleBillNo.Location = new System.Drawing.Point(379, 44);
            this.lbSaleBillNo.Name = "lbSaleBillNo";
            this.lbSaleBillNo.Size = new System.Drawing.Size(53, 12);
            this.lbSaleBillNo.TabIndex = 90;
            this.lbSaleBillNo.Text = "销售单号";
            this.lbSaleBillNo.Visible = false;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(504, 70);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 95;
            this.btnReturn.Text = "返回";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 121;
            this.label2.Text = "订单日期";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(415, 70);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 94;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(326, 70);
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
            this.txtCDNo.Location = new System.Drawing.Point(66, 70);
            this.txtCDNo.MaxLength = 8;
            this.txtCDNo.Name = "txtCDNo";
            this.txtCDNo.ReadOnly = true;
            this.txtCDNo.Size = new System.Drawing.Size(142, 21);
            this.txtCDNo.TabIndex = 2;
            // 
            // chbIsCDNo
            // 
            this.chbIsCDNo.AutoSize = true;
            this.chbIsCDNo.Location = new System.Drawing.Point(3, 72);
            this.chbIsCDNo.Name = "chbIsCDNo";
            this.chbIsCDNo.Size = new System.Drawing.Size(60, 16);
            this.chbIsCDNo.TabIndex = 120;
            this.chbIsCDNo.Text = "光盘号";
            this.chbIsCDNo.UseVisualStyleBackColor = true;
            this.chbIsCDNo.CheckedChanged += new System.EventHandler(this.chbIsCDNo_CheckedChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(435, 12);
            this.txtAddress.MaxLength = 50;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(154, 21);
            this.txtAddress.TabIndex = 87;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(379, 15);
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
            this.groupBox2.Controls.Add(this.dgvRetailSaleOrderBill);
            this.groupBox2.Location = new System.Drawing.Point(4, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(595, 261);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "信息记录";
            // 
            // dgvRetailSaleOrderBill
            // 
            this.dgvRetailSaleOrderBill.AllowUserToAddRows = false;
            this.dgvRetailSaleOrderBill.AllowUserToResizeColumns = false;
            this.dgvRetailSaleOrderBill.AllowUserToResizeRows = false;
            this.dgvRetailSaleOrderBill.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRetailSaleOrderBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvRetailSaleOrderBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRetailSaleOrderBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SaleBillNo,
            this.BillDate,
            this.CustomerName,
            this.GoodsTypeCode,
            this.GoodsSeriesCode,
            this.Quantity,
            this.PhoneNumber,
            this.Address,
            this.PostalCode,
            this.EmployeeCode,
            this.ProvinceCode,
            this.URL,
            this.CustomerType,
            this.Remark,
            this.OperatorCode,
            this.AppendDate,
            this.CustomerId,
            this.CustomerId1,
            this.UnitPrice,
            this.Discount,
            this.IsNeedInvoice,
            this.WriteOffType,
            this.WriteOffName,
            this.CertificateNumber,
            this.SignDate});
            this.dgvRetailSaleOrderBill.Location = new System.Drawing.Point(3, 13);
            this.dgvRetailSaleOrderBill.Name = "dgvRetailSaleOrderBill";
            this.dgvRetailSaleOrderBill.RowHeadersVisible = false;
            this.dgvRetailSaleOrderBill.RowTemplate.Height = 23;
            this.dgvRetailSaleOrderBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRetailSaleOrderBill.Size = new System.Drawing.Size(588, 245);
            this.dgvRetailSaleOrderBill.TabIndex = 0;
            this.dgvRetailSaleOrderBill.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRetailSaleOrderBill_CellDoubleClick);
            // 
            // SaleBillNo
            // 
            this.SaleBillNo.DataPropertyName = "SaleBillNo";
            this.SaleBillNo.HeaderText = "销售单号";
            this.SaleBillNo.Name = "SaleBillNo";
            // 
            // BillDate
            // 
            this.BillDate.DataPropertyName = "BillDate";
            this.BillDate.HeaderText = "订单日期";
            this.BillDate.Name = "BillDate";
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.HeaderText = "用户名称";
            this.CustomerName.Name = "CustomerName";
            // 
            // GoodsTypeCode
            // 
            this.GoodsTypeCode.DataPropertyName = "GoodsTypeCode";
            this.GoodsTypeCode.HeaderText = "订购种类";
            this.GoodsTypeCode.Name = "GoodsTypeCode";
            // 
            // GoodsSeriesCode
            // 
            this.GoodsSeriesCode.DataPropertyName = "GoodsSeriesCode";
            this.GoodsSeriesCode.HeaderText = "订购版本";
            this.GoodsSeriesCode.Name = "GoodsSeriesCode";
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "数    量";
            this.Quantity.Name = "Quantity";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            this.PhoneNumber.HeaderText = "联系电话";
            this.PhoneNumber.Name = "PhoneNumber";
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "地    址";
            this.Address.Name = "Address";
            // 
            // PostalCode
            // 
            this.PostalCode.DataPropertyName = "PostalCode";
            this.PostalCode.HeaderText = "邮政编码";
            this.PostalCode.Name = "PostalCode";
            // 
            // EmployeeCode
            // 
            this.EmployeeCode.DataPropertyName = "EmployeeCode";
            this.EmployeeCode.HeaderText = "下 单 人";
            this.EmployeeCode.Name = "EmployeeCode";
            // 
            // ProvinceCode
            // 
            this.ProvinceCode.DataPropertyName = "ProvinceCode";
            this.ProvinceCode.HeaderText = "所在省市";
            this.ProvinceCode.Name = "ProvinceCode";
            this.ProvinceCode.Visible = false;
            // 
            // URL
            // 
            this.URL.DataPropertyName = "URL";
            this.URL.HeaderText = "QQ或Email";
            this.URL.Name = "URL";
            this.URL.Visible = false;
            // 
            // CustomerType
            // 
            this.CustomerType.DataPropertyName = "CustomerType";
            this.CustomerType.HeaderText = "用户类型";
            this.CustomerType.Name = "CustomerType";
            this.CustomerType.Visible = false;
            // 
            // Remark
            // 
            this.Remark.DataPropertyName = "Remark";
            this.Remark.HeaderText = "备    注";
            this.Remark.Name = "Remark";
            this.Remark.Visible = false;
            // 
            // OperatorCode
            // 
            this.OperatorCode.DataPropertyName = "OperatorCode";
            this.OperatorCode.HeaderText = "录入人";
            this.OperatorCode.Name = "OperatorCode";
            this.OperatorCode.Visible = false;
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
            this.CustomerId.HeaderText = "用户Id";
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.Visible = false;
            // 
            // CustomerId1
            // 
            this.CustomerId1.DataPropertyName = "CustomerId1";
            this.CustomerId1.HeaderText = "CustomerId1";
            this.CustomerId1.Name = "CustomerId1";
            this.CustomerId1.Visible = false;
            // 
            // UnitPrice
            // 
            this.UnitPrice.DataPropertyName = "UnitPrice";
            this.UnitPrice.HeaderText = "单价";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.Visible = false;
            // 
            // Discount
            // 
            this.Discount.DataPropertyName = "Discount";
            this.Discount.HeaderText = "折扣";
            this.Discount.Name = "Discount";
            this.Discount.Visible = false;
            // 
            // IsNeedInvoice
            // 
            this.IsNeedInvoice.DataPropertyName = "IsNeedInvoice";
            this.IsNeedInvoice.HeaderText = "是否发票";
            this.IsNeedInvoice.Name = "IsNeedInvoice";
            this.IsNeedInvoice.Visible = false;
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
            this.WriteOffName.HeaderText = "报销人或单位名称";
            this.WriteOffName.Name = "WriteOffName";
            this.WriteOffName.Visible = false;
            // 
            // CertificateNumber
            // 
            this.CertificateNumber.DataPropertyName = "CertificateNumber";
            this.CertificateNumber.HeaderText = "证件号码";
            this.CertificateNumber.Name = "CertificateNumber";
            this.CertificateNumber.Visible = false;
            // 
            // SignDate
            // 
            this.SignDate.DataPropertyName = "SignDate";
            this.SignDate.HeaderText = "日期";
            this.SignDate.Name = "SignDate";
            this.SignDate.Visible = false;
            // 
            // FormBrowseRetailSaleOrderBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 364);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBrowseRetailSaleOrderBill";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "浏览销售订单";
            this.Load += new System.EventHandler(this.FormBrowseRetailSaleOrderBill_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRetailSaleOrderBill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtCDNo;
        private System.Windows.Forms.CheckBox chbIsCDNo;
        private System.Windows.Forms.TextBox txtSaleBillNo;
        private System.Windows.Forms.Label lbSaleBillNo;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxProvinceCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpBillDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvRetailSaleOrderBill;
        private System.Windows.Forms.CheckBox chbIsTrade;
        private System.Windows.Forms.CheckBox chbConsign;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleBillNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewComboBoxColumn GoodsTypeCode;
        private System.Windows.Forms.DataGridViewComboBoxColumn GoodsSeriesCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostalCode;
        private System.Windows.Forms.DataGridViewComboBoxColumn EmployeeCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProvinceCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn URL;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
        private System.Windows.Forms.DataGridViewTextBoxColumn OperatorCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppendDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerId1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsNeedInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn WriteOffType;
        private System.Windows.Forms.DataGridViewTextBoxColumn WriteOffName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CertificateNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn SignDate;
    }
}