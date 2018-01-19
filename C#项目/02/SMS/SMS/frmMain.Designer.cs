namespace SMS
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel8 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.名片管理MToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.增加联系人SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.所有联系人CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.短信操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.短信记录SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.已发送短信FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.已接收短信GToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.常用短语MToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加短语KToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.所有短语GToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.密码修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.锁定系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.短信群发RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5,
            this.toolStripStatusLabel6,
            this.toolStripStatusLabel7,
            this.toolStripStatusLabel8});
            this.statusStrip1.Location = new System.Drawing.Point(0, 471);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(656, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(89, 17);
            this.toolStripStatusLabel1.Text = "当前操作用户：";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(11, 17);
            this.toolStripStatusLabel3.Text = "|";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(89, 17);
            this.toolStripStatusLabel4.Text = "当前系统时间：";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel5.Text = "toolStripStatusLabel5";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(11, 17);
            this.toolStripStatusLabel6.Text = "|";
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(89, 17);
            this.toolStripStatusLabel7.Text = "登录系统时间：";
            // 
            // toolStripStatusLabel8
            // 
            this.toolStripStatusLabel8.Name = "toolStripStatusLabel8";
            this.toolStripStatusLabel8.Size = new System.Drawing.Size(0, 17);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.BackgroundImage = global::SMS.Properties.Resources.sort_bg_02;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.名片管理MToolStripMenuItem,
            this.短信操作ToolStripMenuItem,
            this.短信记录SToolStripMenuItem,
            this.常用短语MToolStripMenuItem,
            this.toolStripMenuItem1,
            this.关于ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(656, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 名片管理MToolStripMenuItem
            // 
            this.名片管理MToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.增加联系人SToolStripMenuItem,
            this.所有联系人CToolStripMenuItem});
            this.名片管理MToolStripMenuItem.Name = "名片管理MToolStripMenuItem";
            this.名片管理MToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.名片管理MToolStripMenuItem.Text = "名片管理(&M)";
            // 
            // 增加联系人SToolStripMenuItem
            // 
            this.增加联系人SToolStripMenuItem.Name = "增加联系人SToolStripMenuItem";
            this.增加联系人SToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.增加联系人SToolStripMenuItem.Text = "增加联系人[&L]";
            this.增加联系人SToolStripMenuItem.Click += new System.EventHandler(this.增加联系人SToolStripMenuItem_Click);
            // 
            // 所有联系人CToolStripMenuItem
            // 
            this.所有联系人CToolStripMenuItem.Name = "所有联系人CToolStripMenuItem";
            this.所有联系人CToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.所有联系人CToolStripMenuItem.Text = "所有联系人[&C]";
            this.所有联系人CToolStripMenuItem.Click += new System.EventHandler(this.所有联系人CToolStripMenuItem_Click);
            // 
            // 短信操作ToolStripMenuItem
            // 
            this.短信操作ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.短信群发RToolStripMenuItem});
            this.短信操作ToolStripMenuItem.Name = "短信操作ToolStripMenuItem";
            this.短信操作ToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.短信操作ToolStripMenuItem.Text = "短信操作[&I]";
            // 
            // 短信记录SToolStripMenuItem
            // 
            this.短信记录SToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.已发送短信FToolStripMenuItem,
            this.已接收短信GToolStripMenuItem});
            this.短信记录SToolStripMenuItem.Name = "短信记录SToolStripMenuItem";
            this.短信记录SToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.短信记录SToolStripMenuItem.Text = "短信记录[&S]";
            // 
            // 已发送短信FToolStripMenuItem
            // 
            this.已发送短信FToolStripMenuItem.Name = "已发送短信FToolStripMenuItem";
            this.已发送短信FToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.已发送短信FToolStripMenuItem.Text = "已发送短信[&F]";
            this.已发送短信FToolStripMenuItem.Click += new System.EventHandler(this.已发送短信FToolStripMenuItem_Click);
            // 
            // 已接收短信GToolStripMenuItem
            // 
            this.已接收短信GToolStripMenuItem.Name = "已接收短信GToolStripMenuItem";
            this.已接收短信GToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.已接收短信GToolStripMenuItem.Text = "已接收短信[&G]";
            this.已接收短信GToolStripMenuItem.Click += new System.EventHandler(this.已接收短信GToolStripMenuItem_Click);
            // 
            // 常用短语MToolStripMenuItem
            // 
            this.常用短语MToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加短语KToolStripMenuItem,
            this.所有短语GToolStripMenuItem});
            this.常用短语MToolStripMenuItem.Name = "常用短语MToolStripMenuItem";
            this.常用短语MToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.常用短语MToolStripMenuItem.Text = "常用短语[&W]";
            // 
            // 添加短语KToolStripMenuItem
            // 
            this.添加短语KToolStripMenuItem.Name = "添加短语KToolStripMenuItem";
            this.添加短语KToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.添加短语KToolStripMenuItem.Text = "添加短语[&K]";
            this.添加短语KToolStripMenuItem.Click += new System.EventHandler(this.添加短语KToolStripMenuItem_Click);
            // 
            // 所有短语GToolStripMenuItem
            // 
            this.所有短语GToolStripMenuItem.Name = "所有短语GToolStripMenuItem";
            this.所有短语GToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.所有短语GToolStripMenuItem.Text = "所有短语[&T]";
            this.所有短语GToolStripMenuItem.Click += new System.EventHandler(this.所有短语GToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.密码修改ToolStripMenuItem,
            this.退出系统ToolStripMenuItem,
            this.锁定系统ToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(83, 20);
            this.toolStripMenuItem1.Text = "系统管理[&P]";
            // 
            // 密码修改ToolStripMenuItem
            // 
            this.密码修改ToolStripMenuItem.Name = "密码修改ToolStripMenuItem";
            this.密码修改ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.密码修改ToolStripMenuItem.Text = "密码修改[&U]";
            this.密码修改ToolStripMenuItem.Click += new System.EventHandler(this.密码修改ToolStripMenuItem_Click);
            // 
            // 退出系统ToolStripMenuItem
            // 
            this.退出系统ToolStripMenuItem.Name = "退出系统ToolStripMenuItem";
            this.退出系统ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.退出系统ToolStripMenuItem.Text = "退出系统[&V]";
            this.退出系统ToolStripMenuItem.Click += new System.EventHandler(this.退出系统ToolStripMenuItem_Click);
            // 
            // 锁定系统ToolStripMenuItem
            // 
            this.锁定系统ToolStripMenuItem.Name = "锁定系统ToolStripMenuItem";
            this.锁定系统ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.锁定系统ToolStripMenuItem.Text = "锁定系统[&B]";
            this.锁定系统ToolStripMenuItem.Click += new System.EventHandler(this.锁定系统ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于OToolStripMenuItem});
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.关于ToolStripMenuItem.Text = "帮助[&H]";
            // 
            // 关于OToolStripMenuItem
            // 
            this.关于OToolStripMenuItem.Name = "关于OToolStripMenuItem";
            this.关于OToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.关于OToolStripMenuItem.Text = "关于[&O]";
            this.关于OToolStripMenuItem.Click += new System.EventHandler(this.关于OToolStripMenuItem_Click);
            // 
            // 短信群发RToolStripMenuItem
            // 
            this.短信群发RToolStripMenuItem.Name = "短信群发RToolStripMenuItem";
            this.短信群发RToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.短信群发RToolStripMenuItem.Text = "短信群发[&R]";
            this.短信群发RToolStripMenuItem.Click += new System.EventHandler(this.短信群发RToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SMS.Properties.Resources.bg1;
            this.ClientSize = new System.Drawing.Size(656, 493);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "企业短信群发系统";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel8;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem 名片管理MToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 所有联系人CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 短信操作ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 短信记录SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 已发送短信FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 已接收短信GToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 常用短语MToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加短语KToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 所有短语GToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 密码修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 增加联系人SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 锁定系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 短信群发RToolStripMenuItem;





    }
}

