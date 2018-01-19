namespace SALE.UI.AgentManage
{
    partial class FormAgentRecordInput
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
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.txtJuridicalPerson = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCertificateNumber = new System.Windows.Forms.TextBox();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtOpenAccBankName = new System.Windows.Forms.TextBox();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxProvinceCode = new System.Windows.Forms.ComboBox();
            this.cbIsCancel = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(334, 217);
            this.txtRemark.MaxLength = 200;
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(174, 61);
            this.txtRemark.TabIndex = 51;
            this.txtRemark.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRemark_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 50;
            this.label3.Text = "邮政编码";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(77, 94);
            this.txtAddress.MaxLength = 50;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(174, 21);
            this.txtAddress.TabIndex = 48;
            this.txtAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAddress_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 49;
            this.label4.Text = "地    址";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(433, 297);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 47;
            this.btnReturn.Text = "返回";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(330, 297);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 46;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 45;
            this.label1.Text = "所在省市";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(77, 53);
            this.txtPhoneNumber.MaxLength = 50;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(174, 21);
            this.txtPhoneNumber.TabIndex = 43;
            this.txtPhoneNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPhoneNumber_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 44;
            this.label2.Text = "联系电话";
            // 
            // lb2
            // 
            this.lb2.AutoEllipsis = true;
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(277, 16);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(53, 12);
            this.lb2.TabIndex = 41;
            this.lb2.Text = "法    人";
            // 
            // txtJuridicalPerson
            // 
            this.txtJuridicalPerson.Location = new System.Drawing.Point(334, 12);
            this.txtJuridicalPerson.MaxLength = 8;
            this.txtJuridicalPerson.Name = "txtJuridicalPerson";
            this.txtJuridicalPerson.Size = new System.Drawing.Size(174, 21);
            this.txtJuridicalPerson.TabIndex = 39;
            this.txtJuridicalPerson.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtJuridicalPerson_KeyDown);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.AcceptsReturn = true;
            this.txtCustomerName.Location = new System.Drawing.Point(77, 12);
            this.txtCustomerName.MaxLength = 50;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(174, 21);
            this.txtCustomerName.TabIndex = 38;
            this.txtCustomerName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCustomerName_KeyDown);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(20, 16);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(53, 12);
            this.lb1.TabIndex = 40;
            this.lb1.Text = "代 理 商";
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(334, 94);
            this.txtPostalCode.MaxLength = 6;
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(174, 21);
            this.txtPostalCode.TabIndex = 52;
            this.txtPostalCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPostalCode_KeyDown);
            this.txtPostalCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPostalCode_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 63;
            this.label5.Text = "备    注";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 62;
            this.label6.Text = "是否取消";
            // 
            // label7
            // 
            this.label7.AutoEllipsis = true;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(275, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 60;
            this.label7.Text = "税    号";
            // 
            // txtCertificateNumber
            // 
            this.txtCertificateNumber.Location = new System.Drawing.Point(334, 176);
            this.txtCertificateNumber.MaxLength = 20;
            this.txtCertificateNumber.Name = "txtCertificateNumber";
            this.txtCertificateNumber.Size = new System.Drawing.Size(174, 21);
            this.txtCertificateNumber.TabIndex = 57;
            this.txtCertificateNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCertificateNumber_KeyDown);
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(77, 176);
            this.txtAccountNumber.MaxLength = 19;
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(174, 21);
            this.txtAccountNumber.TabIndex = 58;
            this.txtAccountNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAccountNumber_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 59;
            this.label8.Text = "银行账号";
            // 
            // label9
            // 
            this.label9.AutoEllipsis = true;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(277, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 56;
            this.label9.Text = "开户银行";
            // 
            // txtOpenAccBankName
            // 
            this.txtOpenAccBankName.Location = new System.Drawing.Point(334, 135);
            this.txtOpenAccBankName.MaxLength = 100;
            this.txtOpenAccBankName.Name = "txtOpenAccBankName";
            this.txtOpenAccBankName.Size = new System.Drawing.Size(174, 21);
            this.txtOpenAccBankName.TabIndex = 53;
            this.txtOpenAccBankName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOpenAccBankName_KeyDown);
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(77, 135);
            this.txtURL.MaxLength = 50;
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(174, 21);
            this.txtURL.TabIndex = 54;
            this.txtURL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtURL_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 55;
            this.label10.Text = "网    址";
            // 
            // cbxProvinceCode
            // 
            this.cbxProvinceCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProvinceCode.FormattingEnabled = true;
            this.cbxProvinceCode.Location = new System.Drawing.Point(334, 53);
            this.cbxProvinceCode.Name = "cbxProvinceCode";
            this.cbxProvinceCode.Size = new System.Drawing.Size(174, 20);
            this.cbxProvinceCode.TabIndex = 64;
            this.cbxProvinceCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbxProvinceCode_KeyDown);
            // 
            // cbIsCancel
            // 
            this.cbIsCancel.AutoSize = true;
            this.cbIsCancel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbIsCancel.Location = new System.Drawing.Point(107, 219);
            this.cbIsCancel.Name = "cbIsCancel";
            this.cbIsCancel.Size = new System.Drawing.Size(128, 16);
            this.cbIsCancel.TabIndex = 65;
            this.cbIsCancel.Text = "选中表示取消代理";
            this.cbIsCancel.UseVisualStyleBackColor = true;
            // 
            // FormAgentRecordInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 339);
            this.Controls.Add(this.cbIsCancel);
            this.Controls.Add(this.cbxProvinceCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCertificateNumber);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtOpenAccBankName);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPostalCode);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.txtJuridicalPerson);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lb1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAgentRecordInput";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "代理商档案编辑";
            this.Load += new System.EventHandler(this.FormAgentRecordInput_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.TextBox txtJuridicalPerson;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCertificateNumber;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtOpenAccBankName;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxProvinceCode;
        private System.Windows.Forms.CheckBox cbIsCancel;
    }
}