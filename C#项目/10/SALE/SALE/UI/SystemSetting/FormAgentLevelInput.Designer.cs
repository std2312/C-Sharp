namespace SALE.UI.SystemSetting
{
    partial class FormAgentLevelInput
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
            this.txtAgentLevelName = new System.Windows.Forms.TextBox();
            this.txtAgentLevelCode = new System.Windows.Forms.TextBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtLeastMoney = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb2
            // 
            this.lb2.AutoEllipsis = true;
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(216, 24);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(53, 12);
            this.lb2.TabIndex = 15;
            this.lb2.Text = "级别名称";
            // 
            // txtAgentLevelName
            // 
            this.txtAgentLevelName.Location = new System.Drawing.Point(272, 20);
            this.txtAgentLevelName.MaxLength = 50;
            this.txtAgentLevelName.Name = "txtAgentLevelName";
            this.txtAgentLevelName.Size = new System.Drawing.Size(149, 21);
            this.txtAgentLevelName.TabIndex = 12;
            this.txtAgentLevelName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAgentLevelName_KeyDown);
            // 
            // txtAgentLevelCode
            // 
            this.txtAgentLevelCode.Location = new System.Drawing.Point(60, 20);
            this.txtAgentLevelCode.Name = "txtAgentLevelCode";
            this.txtAgentLevelCode.ReadOnly = true;
            this.txtAgentLevelCode.Size = new System.Drawing.Size(149, 21);
            this.txtAgentLevelCode.TabIndex = 13;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(4, 23);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(53, 12);
            this.lb1.TabIndex = 14;
            this.lb1.Text = "级别代码";
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 19;
            this.label1.Text = "代理折扣";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(273, 70);
            this.txtDiscount.MaxLength = 3;
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(149, 21);
            this.txtDiscount.TabIndex = 16;
            this.txtDiscount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDiscount_KeyDown);
            this.txtDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiscount_KeyPress);
            // 
            // txtLeastMoney
            // 
            this.txtLeastMoney.Location = new System.Drawing.Point(61, 70);
            this.txtLeastMoney.MaxLength = 9;
            this.txtLeastMoney.Name = "txtLeastMoney";
            this.txtLeastMoney.Size = new System.Drawing.Size(149, 21);
            this.txtLeastMoney.TabIndex = 17;
            this.txtLeastMoney.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLeastMoney_KeyDown);
            this.txtLeastMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLeastMoney_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 18;
            this.label2.Text = "销售任务";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(346, 123);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 21;
            this.btnReturn.Text = "返回";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(243, 123);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FormAgentLevelInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 161);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtLeastMoney);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.txtAgentLevelName);
            this.Controls.Add(this.txtAgentLevelCode);
            this.Controls.Add(this.lb1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAgentLevelInput";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "代理级别编辑";
            this.Load += new System.EventHandler(this.FormAgentLevelInput_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.TextBox txtAgentLevelName;
        private System.Windows.Forms.TextBox txtAgentLevelCode;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtLeastMoney;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnSave;
    }
}