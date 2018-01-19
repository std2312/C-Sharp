namespace SALE.UI.SaleManage
{
    partial class FormBrowseRetailSaleTradeBill
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
            this.dtpSaleDate = new System.Windows.Forms.DateTimePicker();
            this.txtSaleBillNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxBankCode = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxPayTypeCode = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTradeBillNo = new System.Windows.Forms.TextBox();
            this.txtCDNo = new System.Windows.Forms.TextBox();
            this.chbIsCDNo = new System.Windows.Forms.CheckBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxProvinceCode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpSaleDate
            // 
            this.dtpSaleDate.Checked = false;
            this.dtpSaleDate.Location = new System.Drawing.Point(268, 92);
            this.dtpSaleDate.Name = "dtpSaleDate";
            this.dtpSaleDate.ShowCheckBox = true;
            this.dtpSaleDate.Size = new System.Drawing.Size(111, 21);
            this.dtpSaleDate.TabIndex = 122;
            // 
            // txtSaleBillNo
            // 
            this.txtSaleBillNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSaleBillNo.Location = new System.Drawing.Point(268, 51);
            this.txtSaleBillNo.MaxLength = 50;
            this.txtSaleBillNo.Name = "txtSaleBillNo";
            this.txtSaleBillNo.Size = new System.Drawing.Size(111, 21);
            this.txtSaleBillNo.TabIndex = 89;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(211, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 90;
            this.label10.Text = "销售单号";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(504, 132);
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
            this.label2.Location = new System.Drawing.Point(211, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 121;
            this.label2.Text = "查款日期";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(415, 132);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 94;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(326, 132);
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
            this.label6.Location = new System.Drawing.Point(11, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 92;
            this.label6.Text = "联系电话";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(66, 52);
            this.txtPhoneNumber.MaxLength = 50;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(142, 21);
            this.txtPhoneNumber.TabIndex = 91;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxBankCode);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbxPayTypeCode);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTradeBillNo);
            this.groupBox1.Controls.Add(this.dtpSaleDate);
            this.groupBox1.Controls.Add(this.txtSaleBillNo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label10);
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
            this.groupBox1.Size = new System.Drawing.Size(594, 166);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // cbxBankCode
            // 
            this.cbxBankCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBankCode.FormattingEnabled = true;
            this.cbxBankCode.Location = new System.Drawing.Point(66, 92);
            this.cbxBankCode.Name = "cbxBankCode";
            this.cbxBankCode.Size = new System.Drawing.Size(142, 20);
            this.cbxBankCode.TabIndex = 128;
            // 
            // label7
            // 
            this.label7.AutoEllipsis = true;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 127;
            this.label7.Text = "预存银行";
            // 
            // cbxPayTypeCode
            // 
            this.cbxPayTypeCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPayTypeCode.FormattingEnabled = true;
            this.cbxPayTypeCode.Location = new System.Drawing.Point(438, 51);
            this.cbxPayTypeCode.Name = "cbxPayTypeCode";
            this.cbxPayTypeCode.Size = new System.Drawing.Size(148, 20);
            this.cbxPayTypeCode.TabIndex = 126;
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(381, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 125;
            this.label5.Text = "交易方式";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 124;
            this.label3.Text = "交易单号";
            // 
            // txtTradeBillNo
            // 
            this.txtTradeBillNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTradeBillNo.Location = new System.Drawing.Point(438, 92);
            this.txtTradeBillNo.MaxLength = 50;
            this.txtTradeBillNo.Name = "txtTradeBillNo";
            this.txtTradeBillNo.Size = new System.Drawing.Size(148, 21);
            this.txtTradeBillNo.TabIndex = 123;
            // 
            // txtCDNo
            // 
            this.txtCDNo.Enabled = false;
            this.txtCDNo.Location = new System.Drawing.Point(66, 131);
            this.txtCDNo.MaxLength = 8;
            this.txtCDNo.Name = "txtCDNo";
            this.txtCDNo.Size = new System.Drawing.Size(142, 21);
            this.txtCDNo.TabIndex = 2;
            // 
            // chbIsCDNo
            // 
            this.chbIsCDNo.AutoSize = true;
            this.chbIsCDNo.Location = new System.Drawing.Point(4, 133);
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
            // FormBrowseRetailSaleTradeBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 174);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBrowseRetailSaleTradeBill";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "查询销售交易单";
            this.Load += new System.EventHandler(this.FormBrowseRetailSaleTradeBill_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpSaleDate;
        private System.Windows.Forms.TextBox txtSaleBillNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCDNo;
        private System.Windows.Forms.CheckBox chbIsCDNo;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxProvinceCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTradeBillNo;
        private System.Windows.Forms.ComboBox cbxPayTypeCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxBankCode;
    }
}