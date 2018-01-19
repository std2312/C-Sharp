namespace MyQQServer
{
    partial class F_Server
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.控制台ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.开始服务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LV_SysUser = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.ColumnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.ColumnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.ColumnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.ColumnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.udpSocket1 = new QQClass.UDPSocket(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.控制台ToolStripMenuItem,
            this.系统ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(560, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 控制台ToolStripMenuItem
            // 
            this.控制台ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开始服务ToolStripMenuItem});
            this.控制台ToolStripMenuItem.Name = "控制台ToolStripMenuItem";
            this.控制台ToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.控制台ToolStripMenuItem.Text = "控制台";
            // 
            // 开始服务ToolStripMenuItem
            // 
            this.开始服务ToolStripMenuItem.Name = "开始服务ToolStripMenuItem";
            this.开始服务ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.开始服务ToolStripMenuItem.Text = "开始服务";
            this.开始服务ToolStripMenuItem.Click += new System.EventHandler(this.Tool_Open);
            // 
            // 系统ToolStripMenuItem
            // 
            this.系统ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退出ToolStripMenuItem});
            this.系统ToolStripMenuItem.Name = "系统ToolStripMenuItem";
            this.系统ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.系统ToolStripMenuItem.Text = "系统";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LV_SysUser
            // 
            this.LV_SysUser.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader2,
            this.ColumnHeader3,
            this.ColumnHeader6,
            this.ColumnHeader4});
            this.LV_SysUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LV_SysUser.FullRowSelect = true;
            this.LV_SysUser.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LV_SysUser.Location = new System.Drawing.Point(0, 25);
            this.LV_SysUser.Name = "LV_SysUser";
            this.LV_SysUser.Size = new System.Drawing.Size(560, 307);
            this.LV_SysUser.TabIndex = 15;
            this.LV_SysUser.UseCompatibleStateImageBehavior = false;
            this.LV_SysUser.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "ID";
            this.ColumnHeader1.Width = 72;
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.Text = "IP地址";
            this.ColumnHeader2.Width = 158;
            // 
            // ColumnHeader3
            // 
            this.ColumnHeader3.Text = "端口";
            this.ColumnHeader3.Width = 94;
            // 
            // ColumnHeader6
            // 
            this.ColumnHeader6.Text = "姓名";
            this.ColumnHeader6.Width = 127;
            // 
            // ColumnHeader4
            // 
            this.ColumnHeader4.Text = "状态";
            this.ColumnHeader4.Width = 88;
            // 
            // udpSocket1
            // 
            this.udpSocket1.Active = false;
            this.udpSocket1.LocalHost = "127.0.0.1";
            this.udpSocket1.LocalPort = 11000;
            this.udpSocket1.DataArrival += new QQClass.UDPSocket.DataArrivalEventHandler(this.sockUDP1_DataArrival);
            // 
            // F_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 332);
            this.Controls.Add(this.LV_SysUser);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "F_Server";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "控制台";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.F_Server_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 控制台ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 开始服务ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        internal System.Windows.Forms.ListView LV_SysUser;
        internal System.Windows.Forms.ColumnHeader ColumnHeader1;
        internal System.Windows.Forms.ColumnHeader ColumnHeader2;
        internal System.Windows.Forms.ColumnHeader ColumnHeader3;
        internal System.Windows.Forms.ColumnHeader ColumnHeader4;
        internal System.Windows.Forms.ColumnHeader ColumnHeader6;
        private QQClass.UDPSocket udpSocket1;
    }
}

