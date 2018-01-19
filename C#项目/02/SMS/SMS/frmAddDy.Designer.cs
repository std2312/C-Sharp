namespace SMS
{
    partial class frmAddDy
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
            this.cbbType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDy = new System.Windows.Forms.TextBox();
            this.pbSubmit = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSubmit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbType
            // 
            this.cbbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbType.FormattingEnabled = true;
            this.cbbType.Items.AddRange(new object[] {
            "常用办公语",
            "订货常用语",
            "发货语",
            "客户联系语",
            "礼貌语",
            "商业语",
            "祝福语"});
            this.cbbType.Location = new System.Drawing.Point(105, 18);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(166, 20);
            this.cbbType.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "选择短语类型：";
            // 
            // txtDy
            // 
            this.txtDy.Location = new System.Drawing.Point(12, 55);
            this.txtDy.Multiline = true;
            this.txtDy.Name = "txtDy";
            this.txtDy.Size = new System.Drawing.Size(393, 141);
            this.txtDy.TabIndex = 3;
            // 
            // pbSubmit
            // 
            this.pbSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSubmit.Image = global::SMS.Properties.Resources.bg_1;
            this.pbSubmit.Location = new System.Drawing.Point(124, 203);
            this.pbSubmit.Name = "pbSubmit";
            this.pbSubmit.Size = new System.Drawing.Size(67, 30);
            this.pbSubmit.TabIndex = 6;
            this.pbSubmit.TabStop = false;
            this.pbSubmit.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::SMS.Properties.Resources.bg_2;
            this.pictureBox2.Location = new System.Drawing.Point(198, 204);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(72, 29);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // frmAddDy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(225)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(411, 233);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pbSubmit);
            this.Controls.Add(this.txtDy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbType);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddDy";
            this.Text = "添加短语";
            this.Load += new System.EventHandler(this.frmAddDy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSubmit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDy;
        private System.Windows.Forms.PictureBox pbSubmit;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}