namespace SALE.UI.SystemSetting
{
    partial class FormGoodsTypeInput
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
            this.btnSave = new System.Windows.Forms.Button();
            this.lb1 = new System.Windows.Forms.Label();
            this.txtGoodsTypeCode = new System.Windows.Forms.TextBox();
            this.txtGoodsTypeName = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lb2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(32, 114);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(30, 22);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(53, 12);
            this.lb1.TabIndex = 3;
            this.lb1.Text = "类别代码";
            // 
            // txtGoodsTypeCode
            // 
            this.txtGoodsTypeCode.Location = new System.Drawing.Point(87, 19);
            this.txtGoodsTypeCode.Name = "txtGoodsTypeCode";
            this.txtGoodsTypeCode.ReadOnly = true;
            this.txtGoodsTypeCode.Size = new System.Drawing.Size(160, 21);
            this.txtGoodsTypeCode.TabIndex = 2;
            // 
            // txtGoodsTypeName
            // 
            this.txtGoodsTypeName.Location = new System.Drawing.Point(87, 69);
            this.txtGoodsTypeName.MaxLength = 50;
            this.txtGoodsTypeName.Name = "txtGoodsTypeName";
            this.txtGoodsTypeName.Size = new System.Drawing.Size(160, 21);
            this.txtGoodsTypeName.TabIndex = 1;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(172, 114);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "返回";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lb2
            // 
            this.lb2.AutoEllipsis = true;
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(30, 73);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(53, 12);
            this.lb2.TabIndex = 5;
            this.lb2.Text = "类别名称";
            // 
            // FormGoodsTypeInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 161);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.txtGoodsTypeName);
            this.Controls.Add(this.txtGoodsTypeCode);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.btnSave);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGoodsTypeInput";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "产品大类编辑";
            this.Load += new System.EventHandler(this.FormGoodsTypeInput_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.TextBox txtGoodsTypeCode;
        private System.Windows.Forms.TextBox txtGoodsTypeName;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lb2;
    }
}