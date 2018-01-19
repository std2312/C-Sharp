namespace MyQQClient
{
    partial class F_Chat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Chat));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tool_Video = new System.Windows.Forms.ToolStripButton();
            this.p_Send = new System.Windows.Forms.Panel();
            this.panel_Hold = new System.Windows.Forms.Panel();
            this.Rich_Out = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.rich_Input = new System.Windows.Forms.RichTextBox();
            this.panel_Bot = new System.Windows.Forms.Panel();
            this.button_Send = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panel_TRight = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel_Show = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_Incepl = new System.Windows.Forms.Button();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.panel_Right = new System.Windows.Forms.Panel();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.panel_Left = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel_Botton = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.udpSocket1 = new QQClass.UDPSocket(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.p_Send.SuspendLayout();
            this.panel_Hold.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panel_Bot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel_TRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel_Show.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.panel_Right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.panel_Left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel_Botton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool_Video});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(534, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tool_Video
            // 
            this.tool_Video.Image = ((System.Drawing.Image)(resources.GetObject("tool_Video.Image")));
            this.tool_Video.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_Video.Name = "tool_Video";
            this.tool_Video.Size = new System.Drawing.Size(49, 22);
            this.tool_Video.Text = "视频";
            this.tool_Video.Click += new System.EventHandler(this.tool_Video_Click);
            // 
            // p_Send
            // 
            this.p_Send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.p_Send.Controls.Add(this.panel_Hold);
            this.p_Send.Controls.Add(this.panel_TRight);
            this.p_Send.Controls.Add(this.panel_Show);
            this.p_Send.Controls.Add(this.panel_Right);
            this.p_Send.Controls.Add(this.panel_Left);
            this.p_Send.Controls.Add(this.panel_Botton);
            this.p_Send.Controls.Add(this.panel_Top);
            this.p_Send.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_Send.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.p_Send.ForeColor = System.Drawing.SystemColors.ControlText;
            this.p_Send.Location = new System.Drawing.Point(0, 25);
            this.p_Send.Name = "p_Send";
            this.p_Send.Size = new System.Drawing.Size(534, 331);
            this.p_Send.TabIndex = 2;
            // 
            // panel_Hold
            // 
            this.panel_Hold.Controls.Add(this.Rich_Out);
            this.panel_Hold.Controls.Add(this.panel1);
            this.panel_Hold.Controls.Add(this.rich_Input);
            this.panel_Hold.Controls.Add(this.panel_Bot);
            this.panel_Hold.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Hold.Location = new System.Drawing.Point(10, 10);
            this.panel_Hold.Name = "panel_Hold";
            this.panel_Hold.Size = new System.Drawing.Size(349, 311);
            this.panel_Hold.TabIndex = 7;
            // 
            // Rich_Out
            // 
            this.Rich_Out.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Rich_Out.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Rich_Out.Location = new System.Drawing.Point(0, 0);
            this.Rich_Out.Name = "Rich_Out";
            this.Rich_Out.Size = new System.Drawing.Size(349, 166);
            this.Rich_Out.TabIndex = 12;
            this.Rich_Out.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 166);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 24);
            this.panel1.TabIndex = 11;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(0, 0);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(349, 24);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 0;
            this.pictureBox7.TabStop = false;
            // 
            // rich_Input
            // 
            this.rich_Input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rich_Input.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rich_Input.Location = new System.Drawing.Point(0, 190);
            this.rich_Input.Name = "rich_Input";
            this.rich_Input.Size = new System.Drawing.Size(349, 83);
            this.rich_Input.TabIndex = 10;
            this.rich_Input.Text = "";
            // 
            // panel_Bot
            // 
            this.panel_Bot.BackColor = System.Drawing.Color.Gainsboro;
            this.panel_Bot.Controls.Add(this.button_Send);
            this.panel_Bot.Controls.Add(this.button_Close);
            this.panel_Bot.Controls.Add(this.pictureBox6);
            this.panel_Bot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Bot.Location = new System.Drawing.Point(0, 273);
            this.panel_Bot.Name = "panel_Bot";
            this.panel_Bot.Size = new System.Drawing.Size(349, 38);
            this.panel_Bot.TabIndex = 9;
            // 
            // button_Send
            // 
            this.button_Send.Location = new System.Drawing.Point(245, 9);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(75, 23);
            this.button_Send.TabIndex = 3;
            this.button_Send.Text = "发送";
            this.button_Send.UseVisualStyleBackColor = true;
            this.button_Send.Click += new System.EventHandler(this.button_Send_Click);
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(155, 9);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(75, 23);
            this.button_Close.TabIndex = 2;
            this.button_Close.Text = "关闭";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(0, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(349, 38);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            // 
            // panel_TRight
            // 
            this.panel_TRight.Controls.Add(this.pictureBox5);
            this.panel_TRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_TRight.Location = new System.Drawing.Point(359, 10);
            this.panel_TRight.Name = "panel_TRight";
            this.panel_TRight.Size = new System.Drawing.Size(10, 311);
            this.panel_TRight.TabIndex = 6;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(0, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(10, 311);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // panel_Show
            // 
            this.panel_Show.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel_Show.Controls.Add(this.panel5);
            this.panel_Show.Controls.Add(this.panel3);
            this.panel_Show.Controls.Add(this.panel4);
            this.panel_Show.Controls.Add(this.panel2);
            this.panel_Show.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Show.Location = new System.Drawing.Point(369, 10);
            this.panel_Show.Name = "panel_Show";
            this.panel_Show.Size = new System.Drawing.Size(155, 311);
            this.panel_Show.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pictureBox9);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 138);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(155, 23);
            this.panel5.TabIndex = 3;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(0, 0);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(155, 23);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 0;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox8);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(155, 138);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(0, 0);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(155, 138);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 0;
            this.pictureBox8.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 161);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(155, 119);
            this.panel4.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.button_Incepl);
            this.panel2.Controls.Add(this.pictureBox10);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 280);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(155, 31);
            this.panel2.TabIndex = 0;
            this.panel2.Visible = false;
            // 
            // button_Incepl
            // 
            this.button_Incepl.Location = new System.Drawing.Point(60, 4);
            this.button_Incepl.Name = "button_Incepl";
            this.button_Incepl.Size = new System.Drawing.Size(88, 23);
            this.button_Incepl.TabIndex = 1;
            this.button_Incepl.Text = "关闭视频";
            this.button_Incepl.UseVisualStyleBackColor = true;
            this.button_Incepl.Click += new System.EventHandler(this.button_Incepl_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(0, 0);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(155, 31);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 0;
            this.pictureBox10.TabStop = false;
            // 
            // panel_Right
            // 
            this.panel_Right.Controls.Add(this.pictureBox11);
            this.panel_Right.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Right.Location = new System.Drawing.Point(524, 10);
            this.panel_Right.Name = "panel_Right";
            this.panel_Right.Size = new System.Drawing.Size(10, 311);
            this.panel_Right.TabIndex = 4;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(0, 0);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(10, 311);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 0;
            this.pictureBox11.TabStop = false;
            // 
            // panel_Left
            // 
            this.panel_Left.Controls.Add(this.pictureBox4);
            this.panel_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Left.Location = new System.Drawing.Point(0, 10);
            this.panel_Left.Name = "panel_Left";
            this.panel_Left.Size = new System.Drawing.Size(10, 311);
            this.panel_Left.TabIndex = 3;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(10, 311);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // panel_Botton
            // 
            this.panel_Botton.Controls.Add(this.pictureBox3);
            this.panel_Botton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Botton.Location = new System.Drawing.Point(0, 321);
            this.panel_Botton.Name = "panel_Botton";
            this.panel_Botton.Size = new System.Drawing.Size(534, 10);
            this.panel_Botton.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(534, 10);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // panel_Top
            // 
            this.panel_Top.Controls.Add(this.pictureBox2);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(534, 10);
            this.panel_Top.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(534, 10);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // udpSocket1
            // 
            this.udpSocket1.Active = false;
            this.udpSocket1.LocalHost = "127.0.0.1";
            this.udpSocket1.LocalPort = 11005;
            this.udpSocket1.DataArrival += new QQClass.UDPSocket.DataArrivalEventHandler(this.udpSocket1_DataArrival);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // F_Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 356);
            this.Controls.Add(this.p_Send);
            this.Controls.Add(this.toolStrip1);
            this.Name = "F_Chat";
            this.Text = "F_Chat";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.F_Chat_FormClosed);
            this.Load += new System.EventHandler(this.F_Chat_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.p_Send.ResumeLayout(false);
            this.panel_Hold.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panel_Bot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel_TRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel_Show.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.panel_Right.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            this.panel_Left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel_Botton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel_Top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tool_Video;
        private System.Windows.Forms.Panel p_Send;
        private System.Windows.Forms.Panel panel_Left;
        private System.Windows.Forms.Panel panel_Botton;
        private System.Windows.Forms.Panel panel_Right;
        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Panel panel_Hold;
        private System.Windows.Forms.Panel panel_TRight;
        private System.Windows.Forms.Panel panel_Show;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rich_Input;
        private System.Windows.Forms.Panel panel_Bot;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.RichTextBox Rich_Out;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button button_Send;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Button button_Incepl;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private QQClass.UDPSocket udpSocket1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}