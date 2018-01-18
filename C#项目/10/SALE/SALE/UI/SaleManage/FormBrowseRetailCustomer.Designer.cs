namespace SALE.UI.SaleManage
{
    partial class FormBrowseRetailCustomer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtCDNo = new System.Windows.Forms.TextBox();
            this.chbIsCDNo = new System.Windows.Forms.CheckBox();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxProvinceCode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvRetailCustomer = new System.Windows.Forms.DataGridView();
            this.CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProvinceCode = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PostalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.URL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JuridicalPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsCancel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OperatorCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CertificateNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BankCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpenAccBankName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRetailCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReturn);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnQuery);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPhoneNumber);
            this.groupBox1.Controls.Add(this.txtCDNo);
            this.groupBox1.Controls.Add(this.chbIsCDNo);
            this.groupBox1.Controls.Add(this.txtURL);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbxProvinceCode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCustomerName);
            this.groupBox1.Controls.Add(this.lb1);
            this.groupBox1.Location = new System.Drawing.Point(4, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(595, 98);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
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
            this.txtPhoneNumber.Size = new System.Drawing.Size(149, 21);
            this.txtPhoneNumber.TabIndex = 91;
            // 
            // txtCDNo
            // 
            this.txtCDNo.Enabled = false;
            this.txtCDNo.Location = new System.Drawing.Point(66, 70);
            this.txtCDNo.MaxLength = 8;
            this.txtCDNo.Name = "txtCDNo";
            this.txtCDNo.ReadOnly = true;
            this.txtCDNo.Size = new System.Drawing.Size(149, 21);
            this.txtCDNo.TabIndex = 2;
            // 
            // chbIsCDNo
            // 
            this.chbIsCDNo.AutoSize = true;
            this.chbIsCDNo.Location = new System.Drawing.Point(4, 74);
            this.chbIsCDNo.Name = "chbIsCDNo";
            this.chbIsCDNo.Size = new System.Drawing.Size(60, 16);
            this.chbIsCDNo.TabIndex = 120;
            this.chbIsCDNo.Text = "光盘号";
            this.chbIsCDNo.UseVisualStyleBackColor = true;
            this.chbIsCDNo.CheckedChanged += new System.EventHandler(this.chbIsCDNo_CheckedChanged);
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(276, 41);
            this.txtURL.MaxLength = 50;
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(101, 21);
            this.txtURL.TabIndex = 89;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(215, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 12);
            this.label10.TabIndex = 90;
            this.label10.Text = "QQ或Email";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(432, 12);
            this.txtAddress.MaxLength = 50;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(157, 21);
            this.txtAddress.TabIndex = 87;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 88;
            this.label4.Text = "地    址";
            // 
            // cbxProvinceCode
            // 
            this.cbxProvinceCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProvinceCode.FormattingEnabled = true;
            this.cbxProvinceCode.Location = new System.Drawing.Point(276, 12);
            this.cbxProvinceCode.Name = "cbxProvinceCode";
            this.cbxProvinceCode.Size = new System.Drawing.Size(101, 20);
            this.cbxProvinceCode.TabIndex = 86;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 15);
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
            this.txtCustomerName.Size = new System.Drawing.Size(149, 21);
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
            this.groupBox2.Controls.Add(this.dgvRetailCustomer);
            this.groupBox2.Location = new System.Drawing.Point(4, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(595, 261);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "用户档案";
            // 
            // dgvRetailCustomer
            // 
            this.dgvRetailCustomer.AllowUserToAddRows = false;
            this.dgvRetailCustomer.AllowUserToResizeColumns = false;
            this.dgvRetailCustomer.AllowUserToResizeRows = false;
            this.dgvRetailCustomer.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRetailCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRetailCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRetailCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerId,
            this.CustomerName,
            this.PhoneNumber,
            this.ProvinceCode,
            this.Address,
            this.PostalCode,
            this.URL,
            this.CustomerType,
            this.Remark,
            this.JuridicalPerson,
            this.IsCancel,
            this.OperatorCode,
            this.CertificateNumber,
            this.BankCode,
            this.OpenAccBankName,
            this.AccountNumber});
            this.dgvRetailCustomer.Location = new System.Drawing.Point(3, 13);
            this.dgvRetailCustomer.Name = "dgvRetailCustomer";
            this.dgvRetailCustomer.RowHeadersVisible = false;
            this.dgvRetailCustomer.RowTemplate.Height = 23;
            this.dgvRetailCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRetailCustomer.Size = new System.Drawing.Size(588, 245);
            this.dgvRetailCustomer.TabIndex = 0;
            this.dgvRetailCustomer.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRetailCustomer_CellDoubleClick);
            // 
            // CustomerId
            // 
            this.CustomerId.DataPropertyName = "CustomerId";
            this.CustomerId.HeaderText = "代    码";
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.ReadOnly = true;
            this.CustomerId.Visible = false;
            this.CustomerId.Width = 150;
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "CustomerName";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.CustomerName.DefaultCellStyle = dataGridViewCellStyle2;
            this.CustomerName.HeaderText = "用户名称";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            this.CustomerName.Width = 150;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            this.PhoneNumber.HeaderText = "联系电话";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            this.PhoneNumber.Width = 120;
            // 
            // ProvinceCode
            // 
            this.ProvinceCode.DataPropertyName = "ProvinceCode";
            this.ProvinceCode.HeaderText = "所在省市";
            this.ProvinceCode.Name = "ProvinceCode";
            this.ProvinceCode.ReadOnly = true;
            this.ProvinceCode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProvinceCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ProvinceCode.Width = 80;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "地    址";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 200;
            // 
            // PostalCode
            // 
            this.PostalCode.DataPropertyName = "PostalCode";
            this.PostalCode.HeaderText = "邮政编码";
            this.PostalCode.Name = "PostalCode";
            this.PostalCode.ReadOnly = true;
            this.PostalCode.Visible = false;
            this.PostalCode.Width = 80;
            // 
            // URL
            // 
            this.URL.DataPropertyName = "URL";
            this.URL.HeaderText = "QQ或Email";
            this.URL.Name = "URL";
            this.URL.ReadOnly = true;
            this.URL.Width = 120;
            // 
            // CustomerType
            // 
            this.CustomerType.DataPropertyName = "CustomerType";
            this.CustomerType.HeaderText = "用户类型";
            this.CustomerType.Name = "CustomerType";
            this.CustomerType.ReadOnly = true;
            this.CustomerType.Width = 80;
            // 
            // Remark
            // 
            this.Remark.DataPropertyName = "Remark";
            this.Remark.HeaderText = "备    注";
            this.Remark.Name = "Remark";
            this.Remark.ReadOnly = true;
            this.Remark.Width = 200;
            // 
            // JuridicalPerson
            // 
            this.JuridicalPerson.DataPropertyName = "JuridicalPerson";
            this.JuridicalPerson.HeaderText = "法    人";
            this.JuridicalPerson.Name = "JuridicalPerson";
            this.JuridicalPerson.Visible = false;
            // 
            // IsCancel
            // 
            this.IsCancel.DataPropertyName = "IsCancel";
            this.IsCancel.HeaderText = "是否取消";
            this.IsCancel.Name = "IsCancel";
            this.IsCancel.Visible = false;
            // 
            // OperatorCode
            // 
            this.OperatorCode.DataPropertyName = "OperatorCode";
            this.OperatorCode.HeaderText = "操作员代码";
            this.OperatorCode.Name = "OperatorCode";
            this.OperatorCode.Visible = false;
            // 
            // CertificateNumber
            // 
            this.CertificateNumber.DataPropertyName = "CertificateNumber";
            this.CertificateNumber.HeaderText = "身份证号或税号";
            this.CertificateNumber.Name = "CertificateNumber";
            this.CertificateNumber.ReadOnly = true;
            this.CertificateNumber.Visible = false;
            this.CertificateNumber.Width = 150;
            // 
            // BankCode
            // 
            this.BankCode.DataPropertyName = "BankCode";
            this.BankCode.HeaderText = "个人开户银行";
            this.BankCode.Name = "BankCode";
            this.BankCode.ReadOnly = true;
            this.BankCode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BankCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.BankCode.Visible = false;
            this.BankCode.Width = 90;
            // 
            // OpenAccBankName
            // 
            this.OpenAccBankName.DataPropertyName = "OpenAccBankName";
            this.OpenAccBankName.HeaderText = "单位开户行详细名称";
            this.OpenAccBankName.Name = "OpenAccBankName";
            this.OpenAccBankName.ReadOnly = true;
            this.OpenAccBankName.Visible = false;
            this.OpenAccBankName.Width = 150;
            // 
            // AccountNumber
            // 
            this.AccountNumber.DataPropertyName = "AccountNumber";
            this.AccountNumber.HeaderText = "银行账号";
            this.AccountNumber.Name = "AccountNumber";
            this.AccountNumber.ReadOnly = true;
            this.AccountNumber.Visible = false;
            this.AccountNumber.Width = 150;
            // 
            // FormBrowseRetailCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 364);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBrowseRetailCustomer";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "浏览零售用户";
            this.Load += new System.EventHandler(this.FormBrowseRetailCustomer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRetailCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chbIsCDNo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCDNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxProvinceCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgvRetailCustomer;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewComboBoxColumn ProvinceCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn URL;
        private System.Windows.Forms.DataGridViewComboBoxColumn CustomerType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
        private System.Windows.Forms.DataGridViewTextBoxColumn JuridicalPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn OperatorCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn CertificateNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn BankCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpenAccBankName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountNumber;
    }
}