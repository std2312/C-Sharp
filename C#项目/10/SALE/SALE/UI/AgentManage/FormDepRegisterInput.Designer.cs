namespace SALE.UI.AgentManage
{
    partial class FormDepRegisterInput
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYears = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtLeastMoney = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.cbxAgentLevelCode = new System.Windows.Forms.ComboBox();
            this.dtpBeginDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 89;
            this.label5.Text = "备    注";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(336, 136);
            this.txtRemark.MaxLength = 200;
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(174, 61);
            this.txtRemark.TabIndex = 78;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 76;
            this.label4.Text = "结束日期";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(431, 234);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 74;
            this.btnReturn.Text = "返回";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(328, 234);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 73;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 72;
            this.label1.Text = "开始日期";
            // 
            // txtYears
            // 
            this.txtYears.Location = new System.Drawing.Point(72, 95);
            this.txtYears.MaxLength = 2;
            this.txtYears.Name = "txtYears";
            this.txtYears.Size = new System.Drawing.Size(174, 21);
            this.txtYears.TabIndex = 70;
            this.txtYears.TextChanged += new System.EventHandler(this.dtpBeginDate_ValueChanged);
            this.txtYears.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYears_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 71;
            this.label2.Text = "代理年限";
            // 
            // lb2
            // 
            this.lb2.AutoEllipsis = true;
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(279, 17);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(53, 12);
            this.lb2.TabIndex = 69;
            this.lb2.Text = "代理级别";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(15, 17);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(53, 12);
            this.lb1.TabIndex = 68;
            this.lb1.Text = "代 理 商";
            // 
            // label6
            // 
            this.label6.AutoEllipsis = true;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(279, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 94;
            this.label6.Text = "代理折扣";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(336, 54);
            this.txtDiscount.MaxLength = 100;
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.ReadOnly = true;
            this.txtDiscount.Size = new System.Drawing.Size(174, 21);
            this.txtDiscount.TabIndex = 91;
            // 
            // txtLeastMoney
            // 
            this.txtLeastMoney.Location = new System.Drawing.Point(72, 54);
            this.txtLeastMoney.MaxLength = 50;
            this.txtLeastMoney.Name = "txtLeastMoney";
            this.txtLeastMoney.ReadOnly = true;
            this.txtLeastMoney.Size = new System.Drawing.Size(174, 21);
            this.txtLeastMoney.TabIndex = 92;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 93;
            this.label7.Text = "销售任务";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.AcceptsReturn = true;
            this.txtCustomerName.Location = new System.Drawing.Point(72, 13);
            this.txtCustomerName.MaxLength = 50;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(174, 21);
            this.txtCustomerName.TabIndex = 66;
            // 
            // cbxAgentLevelCode
            // 
            this.cbxAgentLevelCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAgentLevelCode.FormattingEnabled = true;
            this.cbxAgentLevelCode.Location = new System.Drawing.Point(336, 13);
            this.cbxAgentLevelCode.Name = "cbxAgentLevelCode";
            this.cbxAgentLevelCode.Size = new System.Drawing.Size(174, 20);
            this.cbxAgentLevelCode.TabIndex = 95;
            this.cbxAgentLevelCode.SelectedIndexChanged += new System.EventHandler(this.cbxAgentLevelCode_SelectedIndexChanged);
            // 
            // dtpBeginDate
            // 
            this.dtpBeginDate.Location = new System.Drawing.Point(336, 95);
            this.dtpBeginDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpBeginDate.Name = "dtpBeginDate";
            this.dtpBeginDate.Size = new System.Drawing.Size(174, 21);
            this.dtpBeginDate.TabIndex = 96;
            this.dtpBeginDate.ValueChanged += new System.EventHandler(this.dtpBeginDate_ValueChanged);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Enabled = false;
            this.dtpEndDate.Location = new System.Drawing.Point(72, 136);
            this.dtpEndDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(174, 21);
            this.dtpEndDate.TabIndex = 97;
            // 
            // FormDepRegisterInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 271);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpBeginDate);
            this.Controls.Add(this.cbxAgentLevelCode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtLeastMoney);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtYears);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lb1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDepRegisterInput";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "代理登记编辑";
            this.Load += new System.EventHandler(this.FormDepRegisterInput_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYears;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtLeastMoney;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.ComboBox cbxAgentLevelCode;
        private System.Windows.Forms.DateTimePicker dtpBeginDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;


    }
}