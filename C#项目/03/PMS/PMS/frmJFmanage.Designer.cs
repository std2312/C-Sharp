namespace PMS
{
    partial class frmJFmanage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJFmanage));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtJFcontent = new System.Windows.Forms.TextBox();
            this.cbbUserNum = new System.Windows.Forms.ComboBox();
            this.cbbUserJFType = new System.Windows.Forms.ComboBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtdep = new System.Windows.Forms.TextBox();
            this.txtJL = new System.Windows.Forms.TextBox();
            this.txtFK = new System.Windows.Forms.TextBox();
            this.txtJFdate = new System.Windows.Forms.DateTimePicker();
            this.txtCXDate = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.添加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "员工编号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "类　　型：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "姓　　名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "部　　门：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "奖罚内容：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "奖励金额：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(212, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "罚款金额：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 8;
            this.label8.Text = "奖罚日期：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(212, 226);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 10;
            this.label10.Text = "撤销日期：";
            // 
            // txtJFcontent
            // 
            this.txtJFcontent.Location = new System.Drawing.Point(83, 97);
            this.txtJFcontent.Multiline = true;
            this.txtJFcontent.Name = "txtJFcontent";
            this.txtJFcontent.Size = new System.Drawing.Size(326, 81);
            this.txtJFcontent.TabIndex = 12;
            // 
            // cbbUserNum
            // 
            this.cbbUserNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbUserNum.FormattingEnabled = true;
            this.cbbUserNum.Location = new System.Drawing.Point(83, 36);
            this.cbbUserNum.Name = "cbbUserNum";
            this.cbbUserNum.Size = new System.Drawing.Size(111, 20);
            this.cbbUserNum.TabIndex = 13;
            this.cbbUserNum.SelectedIndexChanged += new System.EventHandler(this.cbbUserNum_SelectedIndexChanged);
            // 
            // cbbUserJFType
            // 
            this.cbbUserJFType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbUserJFType.FormattingEnabled = true;
            this.cbbUserJFType.Items.AddRange(new object[] {
            "奖励",
            "惩罚"});
            this.cbbUserJFType.Location = new System.Drawing.Point(284, 36);
            this.cbbUserJFType.Name = "cbbUserJFType";
            this.cbbUserJFType.Size = new System.Drawing.Size(125, 20);
            this.cbbUserJFType.TabIndex = 14;
            this.cbbUserJFType.SelectedIndexChanged += new System.EventHandler(this.cbbUserJFType_SelectedIndexChanged);
            // 
            // txtname
            // 
            this.txtname.Enabled = false;
            this.txtname.Location = new System.Drawing.Point(83, 65);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(111, 21);
            this.txtname.TabIndex = 15;
            // 
            // txtdep
            // 
            this.txtdep.Enabled = false;
            this.txtdep.Location = new System.Drawing.Point(284, 65);
            this.txtdep.Name = "txtdep";
            this.txtdep.Size = new System.Drawing.Size(125, 21);
            this.txtdep.TabIndex = 16;
            // 
            // txtJL
            // 
            this.txtJL.Location = new System.Drawing.Point(83, 191);
            this.txtJL.Name = "txtJL";
            this.txtJL.Size = new System.Drawing.Size(111, 21);
            this.txtJL.TabIndex = 21;
            this.txtJL.Text = "0";
            this.txtJL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtJL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJL_KeyPress);
            // 
            // txtFK
            // 
            this.txtFK.Location = new System.Drawing.Point(275, 191);
            this.txtFK.Name = "txtFK";
            this.txtFK.Size = new System.Drawing.Size(134, 21);
            this.txtFK.TabIndex = 22;
            this.txtFK.Text = "0";
            this.txtFK.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFK_KeyPress);
            // 
            // txtJFdate
            // 
            this.txtJFdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtJFdate.Location = new System.Drawing.Point(83, 222);
            this.txtJFdate.Name = "txtJFdate";
            this.txtJFdate.Size = new System.Drawing.Size(111, 21);
            this.txtJFdate.TabIndex = 23;
            // 
            // txtCXDate
            // 
            this.txtCXDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtCXDate.Location = new System.Drawing.Point(275, 221);
            this.txtCXDate.Name = "txtCXDate";
            this.txtCXDate.Size = new System.Drawing.Size(134, 21);
            this.txtCXDate.TabIndex = 24;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(421, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 添加ToolStripMenuItem
            // 
            this.添加ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("添加ToolStripMenuItem.Image")));
            this.添加ToolStripMenuItem.Name = "添加ToolStripMenuItem";
            this.添加ToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.添加ToolStripMenuItem.Text = "添加";
            this.添加ToolStripMenuItem.Click += new System.EventHandler(this.添加ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("退出ToolStripMenuItem.Image")));
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // frmJFmanage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(421, 258);
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
            this.Name = "frmJFmanage";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "员工奖罚管理";
            this.Load += new System.EventHandler(this.frmJFmanage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtJFcontent;
        private System.Windows.Forms.ComboBox cbbUserNum;
        private System.Windows.Forms.ComboBox cbbUserJFType;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtdep;
        private System.Windows.Forms.TextBox txtJL;
        private System.Windows.Forms.TextBox txtFK;
        private System.Windows.Forms.DateTimePicker txtJFdate;
        private System.Windows.Forms.DateTimePicker txtCXDate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 添加ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
    }
}