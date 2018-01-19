namespace SALE.UI.SaleManage
{
    partial class FormBrowseRetailBarterBaseBillOther
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbIsConsign = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxGoodsSeriesCode1 = new System.Windows.Forms.ComboBox();
            this.cbxGoodsTypeCode1 = new System.Windows.Forms.ComboBox();
            this.chbIsExchange = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpBarterBillDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxBarterType = new System.Windows.Forms.ComboBox();
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
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvBarterBaseBill = new System.Windows.Forms.DataGridView();
            this.BarterBillNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BarterBillDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BarterType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.SaleBillNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsNeedInvoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarterBaseBill)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbIsConsign);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbxGoodsSeriesCode1);
            this.groupBox1.Controls.Add(this.cbxGoodsTypeCode1);
            this.groupBox1.Controls.Add(this.chbIsExchange);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpBarterBillDate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbxBarterType);
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
            this.groupBox1.Location = new System.Drawing.Point(4, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 123);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // chbIsConsign
            // 
            this.chbIsConsign.AutoSize = true;
            this.chbIsConsign.Checked = true;
            this.chbIsConsign.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbIsConsign.Enabled = false;
            this.chbIsConsign.Location = new System.Drawing.Point(382, 69);
            this.chbIsConsign.Name = "chbIsConsign";
            this.chbIsConsign.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chbIsConsign.Size = new System.Drawing.Size(108, 16);
            this.chbIsConsign.TabIndex = 142;
            this.chbIsConsign.Text = "未录入发货信息";
            this.chbIsConsign.UseVisualStyleBackColor = true;
            this.chbIsConsign.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(211, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 141;
            this.label7.Text = "现 版 本";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 140;
            this.label2.Text = "现 种 类";
            // 
            // cbxGoodsSeriesCode1
            // 
            this.cbxGoodsSeriesCode1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGoodsSeriesCode1.FormattingEnabled = true;
            this.cbxGoodsSeriesCode1.Location = new System.Drawing.Point(267, 68);
            this.cbxGoodsSeriesCode1.Name = "cbxGoodsSeriesCode1";
            this.cbxGoodsSeriesCode1.Size = new System.Drawing.Size(111, 20);
            this.cbxGoodsSeriesCode1.TabIndex = 139;
            this.cbxGoodsSeriesCode1.Tag = "GoodsSeriesCode";
            // 
            // cbxGoodsTypeCode1
            // 
            this.cbxGoodsTypeCode1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGoodsTypeCode1.FormattingEnabled = true;
            this.cbxGoodsTypeCode1.Location = new System.Drawing.Point(66, 68);
            this.cbxGoodsTypeCode1.Name = "cbxGoodsTypeCode1";
            this.cbxGoodsTypeCode1.Size = new System.Drawing.Size(142, 20);
            this.cbxGoodsTypeCode1.TabIndex = 138;
            this.cbxGoodsTypeCode1.Tag = "GoodsTypeCode";
            // 
            // chbIsExchange
            // 
            this.chbIsExchange.AutoSize = true;
            this.chbIsExchange.Checked = true;
            this.chbIsExchange.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbIsExchange.Enabled = false;
            this.chbIsExchange.Location = new System.Drawing.Point(382, 69);
            this.chbIsExchange.Name = "chbIsExchange";
            this.chbIsExchange.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chbIsExchange.Size = new System.Drawing.Size(108, 16);
            this.chbIsExchange.TabIndex = 137;
            this.chbIsExchange.Text = "未录入调款信息";
            this.chbIsExchange.UseVisualStyleBackColor = true;
            this.chbIsExchange.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 136;
            this.label3.Text = "换货日期";
            // 
            // dtpBarterBillDate
            // 
            this.dtpBarterBillDate.Checked = false;
            this.dtpBarterBillDate.Location = new System.Drawing.Point(267, 40);
            this.dtpBarterBillDate.Name = "dtpBarterBillDate";
            this.dtpBarterBillDate.ShowCheckBox = true;
            this.dtpBarterBillDate.Size = new System.Drawing.Size(111, 21);
            this.dtpBarterBillDate.TabIndex = 135;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(382, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 131;
            this.label5.Text = "调货类型";
            // 
            // cbxBarterType
            // 
            this.cbxBarterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBarterType.FormattingEnabled = true;
            this.cbxBarterType.Location = new System.Drawing.Point(438, 40);
            this.cbxBarterType.Name = "cbxBarterType";
            this.cbxBarterType.Size = new System.Drawing.Size(148, 20);
            this.cbxBarterType.TabIndex = 126;
            this.cbxBarterType.Tag = "BarterType";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(504, 96);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 95;
            this.btnReturn.Text = "返回";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(415, 96);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 94;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(326, 96);
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
            this.label6.Location = new System.Drawing.Point(11, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 92;
            this.label6.Text = "联系电话";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(66, 40);
            this.txtPhoneNumber.MaxLength = 50;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(142, 21);
            this.txtPhoneNumber.TabIndex = 91;
            // 
            // txtCDNo
            // 
            this.txtCDNo.Enabled = false;
            this.txtCDNo.Location = new System.Drawing.Point(66, 96);
            this.txtCDNo.MaxLength = 8;
            this.txtCDNo.Name = "txtCDNo";
            this.txtCDNo.Size = new System.Drawing.Size(142, 21);
            this.txtCDNo.TabIndex = 2;
            // 
            // chbIsCDNo
            // 
            this.chbIsCDNo.AutoSize = true;
            this.chbIsCDNo.Location = new System.Drawing.Point(4, 98);
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
            this.label4.Location = new System.Drawing.Point(382, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 88;
            this.label4.Text = "地    址";
            // 
            // cbxProvinceCode
            // 
            this.cbxProvinceCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProvinceCode.FormattingEnabled = true;
            this.cbxProvinceCode.Location = new System.Drawing.Point(267, 12);
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
            this.groupBox2.Controls.Add(this.dgvBarterBaseBill);
            this.groupBox2.Location = new System.Drawing.Point(3, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(595, 236);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "换货记录";
            // 
            // dgvBarterBaseBill
            // 
            this.dgvBarterBaseBill.AllowUserToAddRows = false;
            this.dgvBarterBaseBill.AllowUserToResizeColumns = false;
            this.dgvBarterBaseBill.AllowUserToResizeRows = false;
            this.dgvBarterBaseBill.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBarterBaseBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBarterBaseBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBarterBaseBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BarterBillNo,
            this.BarterBillDate,
            this.BarterType,
            this.CustomerName,
            this.PhoneNumber,
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
            this.SaleBillNo,
            this.UnitPrice,
            this.UnitPrice1,
            this.IsNeedInvoice,
            this.Remark1,
            this.CustomerId});
            this.dgvBarterBaseBill.Location = new System.Drawing.Point(4, 12);
            this.dgvBarterBaseBill.Name = "dgvBarterBaseBill";
            this.dgvBarterBaseBill.RowHeadersVisible = false;
            this.dgvBarterBaseBill.RowTemplate.Height = 23;
            this.dgvBarterBaseBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBarterBaseBill.Size = new System.Drawing.Size(585, 220);
            this.dgvBarterBaseBill.TabIndex = 3;
            this.dgvBarterBaseBill.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBarterBaseBill_CellDoubleClick);
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
            // SaleBillNo
            // 
            this.SaleBillNo.DataPropertyName = "SaleBillNo";
            this.SaleBillNo.HeaderText = "销售单号";
            this.SaleBillNo.Name = "SaleBillNo";
            this.SaleBillNo.Visible = false;
            // 
            // UnitPrice
            // 
            this.UnitPrice.DataPropertyName = "UnitPrice";
            this.UnitPrice.HeaderText = "原 单 价";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.Visible = false;
            // 
            // UnitPrice1
            // 
            this.UnitPrice1.DataPropertyName = "UnitPrice1";
            this.UnitPrice1.HeaderText = "现 单 价";
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
            this.Remark1.HeaderText = "换货原因";
            this.Remark1.Name = "Remark1";
            this.Remark1.Visible = false;
            // 
            // CustomerId
            // 
            this.CustomerId.DataPropertyName = "CustomerId";
            this.CustomerId.HeaderText = "用户Id";
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.Visible = false;
            // 
            // FormBrowseRetailBarterBaseBillOther
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 364);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBrowseRetailBarterBaseBillOther";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "查询换货单";
            this.Load += new System.EventHandler(this.FormBrowseRetailBarterBaseBillOther_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarterBaseBill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpBarterBillDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxBarterType;
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
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chbIsExchange;
        public System.Windows.Forms.DataGridView dgvBarterBaseBill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxGoodsSeriesCode1;
        private System.Windows.Forms.ComboBox cbxGoodsTypeCode1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn BarterBillNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn BarterBillDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn BarterType;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleBillNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsNeedInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerId;
        private System.Windows.Forms.CheckBox chbIsConsign;
    }
}