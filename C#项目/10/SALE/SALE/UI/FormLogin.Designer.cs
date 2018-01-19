namespace SALE.UI
{
    partial class FormLogin
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
            this.components = new System.ComponentModel.Container();
            this.picQuit = new System.Windows.Forms.PictureBox();
            this.picReset = new System.Windows.Forms.PictureBox();
            this.picLogin = new System.Windows.Forms.PictureBox();
            this.errInfo = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picQuit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // picQuit
            // 
            this.picQuit.BackColor = System.Drawing.Color.Transparent;
            this.picQuit.Image = global::SALE.Properties.Resources.an_07;
            this.picQuit.Location = new System.Drawing.Point(263, 188);
            this.picQuit.Name = "picQuit";
            this.picQuit.Size = new System.Drawing.Size(55, 24);
            this.picQuit.TabIndex = 11;
            this.picQuit.TabStop = false;
            this.picQuit.Click += new System.EventHandler(this.picQuit_Click);
            // 
            // picReset
            // 
            this.picReset.BackColor = System.Drawing.Color.Transparent;
            this.picReset.Image = global::SALE.Properties.Resources.an_05;
            this.picReset.Location = new System.Drawing.Point(197, 188);
            this.picReset.Name = "picReset";
            this.picReset.Size = new System.Drawing.Size(55, 24);
            this.picReset.TabIndex = 10;
            this.picReset.TabStop = false;
            this.picReset.Click += new System.EventHandler(this.picReset_Click);
            // 
            // picLogin
            // 
            this.picLogin.BackColor = System.Drawing.Color.Transparent;
            this.picLogin.Image = global::SALE.Properties.Resources.an_03;
            this.picLogin.Location = new System.Drawing.Point(131, 188);
            this.picLogin.Name = "picLogin";
            this.picLogin.Size = new System.Drawing.Size(55, 24);
            this.picLogin.TabIndex = 9;
            this.picLogin.TabStop = false;
            this.picLogin.Click += new System.EventHandler(this.picLogin_Click);
            // 
            // errInfo
            // 
            this.errInfo.ContainerControl = this;
            // 
            // txtCode
            // 
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCode.Location = new System.Drawing.Point(200, 123);
            this.txtCode.MaxLength = 10;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(116, 21);
            this.txtCode.TabIndex = 7;
            this.txtCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
            // 
            // txtPwd
            // 
            this.txtPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPwd.Location = new System.Drawing.Point(200, 150);
            this.txtPwd.MaxLength = 20;
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(116, 21);
            this.txtPwd.TabIndex = 8;
            this.txtPwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPwd_KeyDown);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SALE.Properties.Resources.登录小样C_;
            this.ClientSize = new System.Drawing.Size(420, 258);
            this.Controls.Add(this.picQuit);
            this.Controls.Add(this.picReset);
            this.Controls.Add(this.picLogin);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txtPwd);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统登录";
            ((System.ComponentModel.ISupportInitialize)(this.picQuit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picQuit;
        private System.Windows.Forms.PictureBox picReset;
        private System.Windows.Forms.PictureBox picLogin;
        private System.Windows.Forms.ErrorProvider errInfo;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtPwd;
    }
}