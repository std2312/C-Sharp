namespace SMS
{
    partial class frmAddUser
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbConcel = new System.Windows.Forms.PictureBox();
            this.pbSubmit = new System.Windows.Forms.PictureBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbSex = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbConcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSubmit)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbConcel);
            this.groupBox1.Controls.Add(this.pbSubmit);
            this.groupBox1.Controls.Add(this.txtNum);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbbSex);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 112);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "添加联系人电话";
            // 
            // pbConcel
            // 
            this.pbConcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbConcel.Image = global::SMS.Properties.Resources.bg_2;
            this.pbConcel.Location = new System.Drawing.Point(204, 77);
            this.pbConcel.Name = "pbConcel";
            this.pbConcel.Size = new System.Drawing.Size(78, 29);
            this.pbConcel.TabIndex = 9;
            this.pbConcel.TabStop = false;
            this.pbConcel.Click += new System.EventHandler(this.pbConcel_Click);
            // 
            // pbSubmit
            // 
            this.pbSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSubmit.Image = global::SMS.Properties.Resources.bg_1;
            this.pbSubmit.Location = new System.Drawing.Point(133, 78);
            this.pbSubmit.Name = "pbSubmit";
            this.pbSubmit.Size = new System.Drawing.Size(65, 28);
            this.pbSubmit.TabIndex = 8;
            this.pbSubmit.TabStop = false;
            this.pbSubmit.Click += new System.EventHandler(this.pbSubmit_Click);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(60, 50);
            this.txtNum.MaxLength = 11;
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(279, 21);
            this.txtNum.TabIndex = 5;
            this.txtNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "电话：";
            // 
            // cbbSex
            // 
            this.cbbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSex.FormattingEnabled = true;
            this.cbbSex.Items.AddRange(new object[] {
            "帅哥",
            "靓妹"});
            this.cbbSex.Location = new System.Drawing.Point(260, 17);
            this.cbbSex.Name = "cbbSex";
            this.cbbSex.Size = new System.Drawing.Size(79, 20);
            this.cbbSex.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "性别：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(60, 16);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(147, 21);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名：";
            // 
            // frmAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(225)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(448, 133);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddUser";
            this.Text = "增加联系人";
            this.Load += new System.EventHandler(this.frmAddUser_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbConcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSubmit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbSex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbSubmit;
        private System.Windows.Forms.PictureBox pbConcel;
    }
}