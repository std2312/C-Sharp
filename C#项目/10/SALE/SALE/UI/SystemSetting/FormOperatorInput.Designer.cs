namespace SALE.UI.SystemSetting
{
    partial class FormOperatorInput
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAffirmPassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.txtOperatorName = new System.Windows.Forms.TextBox();
            this.txtOperatorCode = new System.Windows.Forms.TextBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(347, 120);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 31;
            this.btnReturn.Text = "返回";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(244, 120);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 29;
            this.label1.Text = "确认密码";
            // 
            // txtAffirmPassword
            // 
            this.txtAffirmPassword.Location = new System.Drawing.Point(274, 67);
            this.txtAffirmPassword.MaxLength = 20;
            this.txtAffirmPassword.Name = "txtAffirmPassword";
            this.txtAffirmPassword.PasswordChar = '*';
            this.txtAffirmPassword.Size = new System.Drawing.Size(149, 21);
            this.txtAffirmPassword.TabIndex = 26;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(62, 67);
            this.txtPassword.MaxLength = 20;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(149, 21);
            this.txtPassword.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 28;
            this.label2.Text = "操作密码";
            // 
            // lb2
            // 
            this.lb2.AutoEllipsis = true;
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(217, 21);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(53, 12);
            this.lb2.TabIndex = 25;
            this.lb2.Text = "操作名称";
            // 
            // txtOperatorName
            // 
            this.txtOperatorName.Location = new System.Drawing.Point(273, 17);
            this.txtOperatorName.MaxLength = 8;
            this.txtOperatorName.Name = "txtOperatorName";
            this.txtOperatorName.Size = new System.Drawing.Size(149, 21);
            this.txtOperatorName.TabIndex = 22;
            // 
            // txtOperatorCode
            // 
            this.txtOperatorCode.Location = new System.Drawing.Point(61, 17);
            this.txtOperatorCode.Name = "txtOperatorCode";
            this.txtOperatorCode.ReadOnly = true;
            this.txtOperatorCode.Size = new System.Drawing.Size(149, 21);
            this.txtOperatorCode.TabIndex = 23;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(5, 20);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(53, 12);
            this.lb1.TabIndex = 24;
            this.lb1.Text = "操作代码";
            // 
            // FormOperatorInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 161);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAffirmPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.txtOperatorName);
            this.Controls.Add(this.txtOperatorCode);
            this.Controls.Add(this.lb1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOperatorInput";
            this.ShowInTaskbar = false;
            this.Text = "操作员编辑";
            this.Load += new System.EventHandler(this.FormOperatorInput_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAffirmPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.TextBox txtOperatorName;
        private System.Windows.Forms.TextBox txtOperatorCode;
        private System.Windows.Forms.Label lb1;
    }
}