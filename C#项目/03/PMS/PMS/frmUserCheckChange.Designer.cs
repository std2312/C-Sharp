namespace PMS
{
    partial class frmUserCheckChange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserCheckChange));
            this.txtkpdate = new System.Windows.Forms.DateTimePicker();
            this.txtscore = new System.Windows.Forms.TextBox();
            this.txtkp = new System.Windows.Forms.TextBox();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.txtcontent = new System.Windows.Forms.TextBox();
            this.txtdep = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.cbbnum = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtkpdate
            // 
            this.txtkpdate.CustomFormat = "0000-00-00";
            this.txtkpdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtkpdate.Location = new System.Drawing.Point(348, 203);
            this.txtkpdate.Name = "txtkpdate";
            this.txtkpdate.Size = new System.Drawing.Size(108, 21);
            this.txtkpdate.TabIndex = 35;
            // 
            // txtscore
            // 
            this.txtscore.Location = new System.Drawing.Point(68, 201);
            this.txtscore.MaxLength = 3;
            this.txtscore.Name = "txtscore";
            this.txtscore.Size = new System.Drawing.Size(88, 21);
            this.txtscore.TabIndex = 34;
            this.txtscore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtscore_KeyPress);
            this.txtscore.TextChanged += new System.EventHandler(this.txtscore_TextChanged);
            // 
            // txtkp
            // 
            this.txtkp.Location = new System.Drawing.Point(207, 202);
            this.txtkp.Name = "txtkp";
            this.txtkp.Size = new System.Drawing.Size(78, 21);
            this.txtkp.TabIndex = 33;
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(68, 130);
            this.txtresult.Multiline = true;
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(388, 62);
            this.txtresult.TabIndex = 32;
            // 
            // txtcontent
            // 
            this.txtcontent.Location = new System.Drawing.Point(68, 64);
            this.txtcontent.Multiline = true;
            this.txtcontent.Name = "txtcontent";
            this.txtcontent.Size = new System.Drawing.Size(388, 57);
            this.txtcontent.TabIndex = 31;
            // 
            // txtdep
            // 
            this.txtdep.Enabled = false;
            this.txtdep.Location = new System.Drawing.Point(356, 32);
            this.txtdep.Name = "txtdep";
            this.txtdep.Size = new System.Drawing.Size(100, 21);
            this.txtdep.TabIndex = 30;
            // 
            // txtname
            // 
            this.txtname.Enabled = false;
            this.txtname.Location = new System.Drawing.Point(211, 32);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(102, 21);
            this.txtname.TabIndex = 29;
            // 
            // cbbnum
            // 
            this.cbbnum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbnum.Enabled = false;
            this.cbbnum.FormattingEnabled = true;
            this.cbbnum.Location = new System.Drawing.Point(68, 33);
            this.cbbnum.Name = "cbbnum";
            this.cbbnum.Size = new System.Drawing.Size(100, 20);
            this.cbbnum.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(287, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 27;
            this.label8.Text = "考评日期：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(156, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 26;
            this.label7.Text = "考评人：";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 25;
            this.label6.Text = "考评分数：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 24;
            this.label5.Text = "考评结果：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 23;
            this.label4.Text = "考评内容：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 22;
            this.label3.Text = "部门：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 21;
            this.label2.Text = "姓名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 20;
            this.label1.Text = "员工编号：";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(465, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 添加ToolStripMenuItem
            // 
            this.修改ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("修改ToolStripMenuItem.Image")));
            this.修改ToolStripMenuItem.Name = "修改ToolStripMenuItem";
            this.修改ToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.修改ToolStripMenuItem.Text = "修改";
            this.修改ToolStripMenuItem.Click += new System.EventHandler(this.修改ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("退出ToolStripMenuItem.Image")));
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // frmUserCheckChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(465, 233);
            this.Controls.Add(this.txtkpdate);
            this.Controls.Add(this.txtscore);
            this.Controls.Add(this.txtkp);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.txtcontent);
            this.Controls.Add(this.txtdep);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.cbbnum);
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
            this.Name = "frmUserCheckChange";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "考评管理";
            this.Load += new System.EventHandler(this.frmUserCheckChange_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker txtkpdate;
        private System.Windows.Forms.TextBox txtscore;
        private System.Windows.Forms.TextBox txtkp;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.TextBox txtcontent;
        private System.Windows.Forms.TextBox txtdep;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.ComboBox cbbnum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
    }
}