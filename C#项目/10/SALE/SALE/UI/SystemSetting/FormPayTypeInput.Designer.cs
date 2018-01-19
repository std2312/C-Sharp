namespace SALE.UI.SystemSetting
{
    partial class FormPayTypeInput
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
            this.txtPayTypeName = new System.Windows.Forms.TextBox();
            this.txtPayTypeCode = new System.Windows.Forms.TextBox();
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
            this.lb2.TabIndex = 11;
            this.lb2.Text = "支付方式";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(170, 116);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 10;
            this.btnReturn.Text = "返回";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // txtPayTypeName
            // 
            this.txtPayTypeName.Location = new System.Drawing.Point(85, 71);
            this.txtPayTypeName.MaxLength = 50;
            this.txtPayTypeName.Name = "txtPayTypeName";
            this.txtPayTypeName.Size = new System.Drawing.Size(160, 21);
            this.txtPayTypeName.TabIndex = 7;
            // 
            // txtPayTypeCode
            // 
            this.txtPayTypeCode.Location = new System.Drawing.Point(85, 21);
            this.txtPayTypeCode.Name = "txtPayTypeCode";
            this.txtPayTypeCode.ReadOnly = true;
            this.txtPayTypeCode.Size = new System.Drawing.Size(160, 21);
            this.txtPayTypeCode.TabIndex = 8;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(28, 24);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(41, 12);
            this.lb1.TabIndex = 9;
            this.lb1.Text = "代  码";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(30, 116);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FormPayTypeInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 161);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.txtPayTypeName);
            this.Controls.Add(this.txtPayTypeCode);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.btnSave);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPayTypeInput";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "支付方式编辑";
            this.Load += new System.EventHandler(this.FormPayTypeInput_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox txtPayTypeName;
        private System.Windows.Forms.TextBox txtPayTypeCode;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Button btnSave;
    }
}