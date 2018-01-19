namespace SMS
{
    partial class frmSendSMS
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
            this.btnSelTel = new System.Windows.Forms.Button();
            this.lvInceptNum = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtaddnum = new System.Windows.Forms.TextBox();
            this.btnDelIncept = new System.Windows.Forms.Button();
            this.btnIncept = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtSmsContent = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.ckbselect = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSelTel);
            this.groupBox1.Controls.Add(this.lvInceptNum);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtaddnum);
            this.groupBox1.Controls.Add(this.btnDelIncept);
            this.groupBox1.Controls.Add(this.btnIncept);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 151);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "短消息接收者";
            // 
            // btnSelTel
            // 
            this.btnSelTel.Location = new System.Drawing.Point(471, 118);
            this.btnSelTel.Name = "btnSelTel";
            this.btnSelTel.Size = new System.Drawing.Size(50, 23);
            this.btnSelTel.TabIndex = 8;
            this.btnSelTel.Text = "电话簿";
            this.btnSelTel.UseVisualStyleBackColor = true;
            this.btnSelTel.Click += new System.EventHandler(this.btnSelTel_Click);
            // 
            // lvInceptNum
            // 
            this.lvInceptNum.Location = new System.Drawing.Point(12, 14);
            this.lvInceptNum.MultiSelect = false;
            this.lvInceptNum.Name = "lvInceptNum";
            this.lvInceptNum.Size = new System.Drawing.Size(549, 97);
            this.lvInceptNum.TabIndex = 7;
            this.lvInceptNum.UseCompatibleStateImageBehavior = false;
            this.lvInceptNum.View = System.Windows.Forms.View.SmallIcon;
            this.lvInceptNum.SelectedIndexChanged += new System.EventHandler(this.lvInceptNum_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "添加短消息接收者：";
            // 
            // txtaddnum
            // 
            this.txtaddnum.Location = new System.Drawing.Point(129, 119);
            this.txtaddnum.MaxLength = 11;
            this.txtaddnum.Name = "txtaddnum";
            this.txtaddnum.Size = new System.Drawing.Size(173, 21);
            this.txtaddnum.TabIndex = 3;
            this.txtaddnum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtaddnum_KeyPress);
            // 
            // btnDelIncept
            // 
            this.btnDelIncept.Location = new System.Drawing.Point(389, 118);
            this.btnDelIncept.Name = "btnDelIncept";
            this.btnDelIncept.Size = new System.Drawing.Size(75, 23);
            this.btnDelIncept.TabIndex = 1;
            this.btnDelIncept.Text = "删除接收者";
            this.btnDelIncept.UseVisualStyleBackColor = true;
            this.btnDelIncept.Click += new System.EventHandler(this.btnDelIncept_Click);
            // 
            // btnIncept
            // 
            this.btnIncept.Location = new System.Drawing.Point(308, 118);
            this.btnIncept.Name = "btnIncept";
            this.btnIncept.Size = new System.Drawing.Size(75, 23);
            this.btnIncept.TabIndex = 0;
            this.btnIncept.Text = "添加接收者";
            this.btnIncept.UseVisualStyleBackColor = true;
            this.btnIncept.Click += new System.EventHandler(this.btnIncept_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.btnSend);
            this.groupBox2.Controls.Add(this.txtSmsContent);
            this.groupBox2.Controls.Add(this.btnInsert);
            this.groupBox2.Controls.Add(this.ckbselect);
            this.groupBox2.Location = new System.Drawing.Point(12, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(567, 203);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "短信内容";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(318, 173);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(124, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "取消发送短消息";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancol_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(157, 173);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(118, 23);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "立即发送短消息";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtSmsContent
            // 
            this.txtSmsContent.Location = new System.Drawing.Point(11, 43);
            this.txtSmsContent.Multiline = true;
            this.txtSmsContent.Name = "txtSmsContent";
            this.txtSmsContent.Size = new System.Drawing.Size(550, 124);
            this.txtSmsContent.TabIndex = 4;
            this.txtSmsContent.TextChanged += new System.EventHandler(this.txtSmsContent_TextChanged);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(157, 16);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 3;
            this.btnInsert.Text = "插入短语";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // ckbselect
            // 
            this.ckbselect.AutoSize = true;
            this.ckbselect.Checked = true;
            this.ckbselect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbselect.Location = new System.Drawing.Point(11, 20);
            this.ckbselect.Name = "ckbselect";
            this.ckbselect.Size = new System.Drawing.Size(132, 16);
            this.ckbselect.TabIndex = 0;
            this.ckbselect.Text = "自动加入接收者称呼";
            this.ckbselect.UseVisualStyleBackColor = true;
            // 
            // frmSendSMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(225)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(591, 376);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSendSMS";
            this.Text = "短信群发";
            this.Load += new System.EventHandler(this.frmSendSMS_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.CheckBox ckbselect;
        private System.Windows.Forms.Button btnDelIncept;
        private System.Windows.Forms.Button btnIncept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtaddnum;
        public System.Windows.Forms.TextBox txtSmsContent;
        private System.Windows.Forms.Button btnSelTel;
        public System.Windows.Forms.ListView lvInceptNum;
    }
}