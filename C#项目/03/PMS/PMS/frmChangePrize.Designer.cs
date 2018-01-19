namespace PMS
{
    partial class frmChangePrize
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangePrize));
            this.txtFK = new System.Windows.Forms.TextBox();
            this.txtJL = new System.Windows.Forms.TextBox();
            this.txtdep = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.cbbUserJFType = new System.Windows.Forms.ComboBox();
            this.cbbUserNum = new System.Windows.Forms.ComboBox();
            this.txtJFcontent = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.添加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtJFdate = new System.Windows.Forms.DateTimePicker();
            this.txtCXDate = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFK
            // 
            this.txtFK.Location = new System.Drawing.Point(276, 187);
            this.txtFK.Name = "txtFK";
            this.txtFK.Size = new System.Drawing.Size(134, 21);
            this.txtFK.TabIndex = 41;
            this.txtFK.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFK_KeyPress);
            // 
            // txtJL
            // 
            this.txtJL.Location = new System.Drawing.Point(84, 187);
            this.txtJL.Name = "txtJL";
            this.txtJL.Size = new System.Drawing.Size(111, 21);
            this.txtJL.TabIndex = 40;
            this.txtJL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtJL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJL_KeyPress);
            // 
            // txtdep
            // 
            this.txtdep.Enabled = false;
            this.txtdep.Location = new System.Drawing.Point(285, 61);
            this.txtdep.Name = "txtdep";
            this.txtdep.Size = new System.Drawing.Size(125, 21);
            this.txtdep.TabIndex = 37;
            // 
            // txtname
            // 
            this.txtname.Enabled = false;
            this.txtname.Location = new System.Drawing.Point(84, 61);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(111, 21);
            this.txtname.TabIndex = 36;
            // 
            // cbbUserJFType
            // 
            this.cbbUserJFType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbUserJFType.FormattingEnabled = true;
            this.cbbUserJFType.Items.AddRange(new object[] {
            "奖励",
            "惩罚"});
            this.cbbUserJFType.Location = new System.Drawing.Point(285, 32);
            this.cbbUserJFType.Name = "cbbUserJFType";
            this.cbbUserJFType.Size = new System.Drawing.Size(125, 20);
            this.cbbUserJFType.TabIndex = 35;
            this.cbbUserJFType.SelectedIndexChanged += new System.EventHandler(this.cbbUserJFType_SelectedIndexChanged);
            // 
            // cbbUserNum
            // 
            this.cbbUserNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbUserNum.Enabled = false;
            this.cbbUserNum.FormattingEnabled = true;
            this.cbbUserNum.Location = new System.Drawing.Point(84, 32);
            this.cbbUserNum.Name = "cbbUserNum";
            this.cbbUserNum.Size = new System.Drawing.Size(111, 20);
            this.cbbUserNum.TabIndex = 34;
            // 
            // txtJFcontent
            // 
            this.txtJFcontent.Location = new System.Drawing.Point(84, 93);
            this.txtJFcontent.Multiline = true;
            this.txtJFcontent.Name = "txtJFcontent";
            this.txtJFcontent.Size = new System.Drawing.Size(326, 81);
            this.txtJFcontent.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(213, 222);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 32;
            this.label10.Text = "撤销日期：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 31;
            this.label8.Text = "奖罚日期：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(213, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 30;
            this.label7.Text = "罚款金额：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 29;
            this.label6.Text = "奖励金额：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 28;
            this.label5.Text = "奖罚内容：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 27;
            this.label4.Text = "部　　门：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 26;
            this.label3.Text = "姓　　名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 25;
            this.label2.Text = "类　　型：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 24;
            this.label1.Text = "员工编号：";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(418, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 添加ToolStripMenuItem
            // 
            this.添加ToolStripMenuItem.Name = "添加ToolStripMenuItem";
            this.添加ToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.添加ToolStripMenuItem.Text = "修改";
            this.添加ToolStripMenuItem.Click += new System.EventHandler(this.添加ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // txtJFdate
            // 
            this.txtJFdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtJFdate.Location = new System.Drawing.Point(84, 219);
            this.txtJFdate.Name = "txtJFdate";
            this.txtJFdate.Size = new System.Drawing.Size(111, 21);
            this.txtJFdate.TabIndex = 42;
            // 
            // txtCXDate
            // 
            this.txtCXDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtCXDate.Location = new System.Drawing.Point(276, 217);
            this.txtCXDate.Name = "txtCXDate";
            this.txtCXDate.Size = new System.Drawing.Size(134, 21);
            this.txtCXDate.TabIndex = 43;
            // 
            // frmChangePrize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 250);
            this.Controls.Add(this.txtCXDate);
            this.Controls.Add(this.txtJFdate);
            this.Controls.Add(this.txtFK);
            this.Controls.Add(this.txtJL);
            this.Controls.Add(this.txtdep);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.cbbUserJFType);
            this.Controls.Add(this.cbbUserNum);
            this.Controls.Add(this.txtJFcontent);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChangePrize";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChangePrize";
            this.Load += new System.EventHandler(this.frmChangePrize_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFK;
        private System.Windows.Forms.TextBox txtJL;
        private System.Windows.Forms.TextBox txtdep;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.ComboBox cbbUserJFType;
        private System.Windows.Forms.ComboBox cbbUserNum;
        private System.Windows.Forms.TextBox txtJFcontent;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 添加ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker txtJFdate;
        private System.Windows.Forms.DateTimePicker txtCXDate;
    }
}