namespace SALE.UI.SystemSetting
{
    partial class FormProvinceInput
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
            this.lb2 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.txtProvinceName = new System.Windows.Forms.TextBox();
            this.txtProvinceCode = new System.Windows.Forms.TextBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb2
            // 
            this.lb2.AutoEllipsis = true;
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(28, 75);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(53, 12);
            this.lb2.TabIndex = 17;
            this.lb2.Text = "省市名称";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(170, 116);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 160;
            this.btnReturn.Text = "返回";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // txtProvinceName
            // 
            this.txtProvinceName.Location = new System.Drawing.Point(85, 71);
            this.txtProvinceName.MaxLength = 50;
            this.txtProvinceName.Name = "txtProvinceName";
            this.txtProvinceName.Size = new System.Drawing.Size(160, 21);
            this.txtProvinceName.TabIndex = 13;
            // 
            // txtProvinceCode
            // 
            this.txtProvinceCode.Location = new System.Drawing.Point(85, 21);
            this.txtProvinceCode.Name = "txtProvinceCode";
            this.txtProvinceCode.ReadOnly = true;
            this.txtProvinceCode.Size = new System.Drawing.Size(160, 21);
            this.txtProvinceCode.TabIndex = 14;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(28, 24);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(53, 12);
            this.lb1.TabIndex = 15;
            this.lb1.Text = "代    码";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(30, 116);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 120;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FormProvinceInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 161);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.txtProvinceName);
            this.Controls.Add(this.txtProvinceCode);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.btnSave);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProvinceInput";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "省市编辑";
            this.Load += new System.EventHandler(this.FormProvinceInput_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox txtProvinceName;
        private System.Windows.Forms.TextBox txtProvinceCode;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Button btnSave;
    }
}