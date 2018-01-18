namespace Daila
{
    partial class frmEmployeeInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeInfo));
            this.bntEsce = new System.Windows.Forms.Button();
            this.bntOK = new System.Windows.Forms.Button();
            this.txtEmpOICQ = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rdfldEmpWorkFlag1 = new System.Windows.Forms.RadioButton();
            this.dtEmpDemissionDate = new System.Windows.Forms.DateTimePicker();
            this.cmbEmpSex = new System.Windows.Forms.ComboBox();
            this.dtEmpWorkDate = new System.Windows.Forms.DateTimePicker();
            this.dtfldEmpBirthday = new System.Windows.Forms.DateTimePicker();
            this.cmbEmpState = new System.Windows.Forms.ComboBox();
            this.cmbEmpNation = new System.Windows.Forms.ComboBox();
            this.txtfldEmpRemark = new System.Windows.Forms.TextBox();
            this.txtEmpCity = new System.Windows.Forms.TextBox();
            this.txtEmpEmail = new System.Windows.Forms.TextBox();
            this.txtEmpOfficeTel = new System.Windows.Forms.TextBox();
            this.txtEmpIDcard = new System.Windows.Forms.TextBox();
            this.txtEmpEngish = new System.Windows.Forms.TextBox();
            this.txtPasswod = new System.Windows.Forms.TextBox();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.bntUpdate = new System.Windows.Forms.Button();
            this.bntDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bntEsce
            // 
            this.bntEsce.Location = new System.Drawing.Point(600, 337);
            this.bntEsce.Name = "bntEsce";
            this.bntEsce.Size = new System.Drawing.Size(100, 23);
            this.bntEsce.TabIndex = 87;
            this.bntEsce.Text = "取消(&C)";
            this.bntEsce.UseVisualStyleBackColor = true;
            this.bntEsce.Click += new System.EventHandler(this.bntEsce_Click);
            // 
            // bntOK
            // 
            this.bntOK.Location = new System.Drawing.Point(193, 337);
            this.bntOK.Name = "bntOK";
            this.bntOK.Size = new System.Drawing.Size(104, 23);
            this.bntOK.TabIndex = 86;
            this.bntOK.Text = "添加(&F)";
            this.bntOK.UseVisualStyleBackColor = true;
            this.bntOK.Click += new System.EventHandler(this.bntOK_Click);
            // 
            // txtEmpOICQ
            // 
            this.txtEmpOICQ.Location = new System.Drawing.Point(481, 301);
            this.txtEmpOICQ.MaxLength = 20;
            this.txtEmpOICQ.Name = "txtEmpOICQ";
            this.txtEmpOICQ.Size = new System.Drawing.Size(219, 21);
            this.txtEmpOICQ.TabIndex = 83;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(260, 306);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(35, 16);
            this.radioButton2.TabIndex = 82;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "是";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // rdfldEmpWorkFlag1
            // 
            this.rdfldEmpWorkFlag1.AutoSize = true;
            this.rdfldEmpWorkFlag1.Location = new System.Drawing.Point(317, 306);
            this.rdfldEmpWorkFlag1.Name = "rdfldEmpWorkFlag1";
            this.rdfldEmpWorkFlag1.Size = new System.Drawing.Size(35, 16);
            this.rdfldEmpWorkFlag1.TabIndex = 81;
            this.rdfldEmpWorkFlag1.Text = "否";
            this.rdfldEmpWorkFlag1.UseVisualStyleBackColor = true;
            // 
            // dtEmpDemissionDate
            // 
            this.dtEmpDemissionDate.Location = new System.Drawing.Point(652, 154);
            this.dtEmpDemissionDate.Name = "dtEmpDemissionDate";
            this.dtEmpDemissionDate.Size = new System.Drawing.Size(112, 21);
            this.dtEmpDemissionDate.TabIndex = 80;
            // 
            // cmbEmpSex
            // 
            this.cmbEmpSex.FormattingEnabled = true;
            this.cmbEmpSex.Location = new System.Drawing.Point(652, 228);
            this.cmbEmpSex.Name = "cmbEmpSex";
            this.cmbEmpSex.Size = new System.Drawing.Size(114, 20);
            this.cmbEmpSex.TabIndex = 79;
            // 
            // dtEmpWorkDate
            // 
            this.dtEmpWorkDate.Location = new System.Drawing.Point(652, 116);
            this.dtEmpWorkDate.Name = "dtEmpWorkDate";
            this.dtEmpWorkDate.Size = new System.Drawing.Size(112, 21);
            this.dtEmpWorkDate.TabIndex = 78;
            // 
            // dtfldEmpBirthday
            // 
            this.dtfldEmpBirthday.Location = new System.Drawing.Point(481, 270);
            this.dtfldEmpBirthday.Name = "dtfldEmpBirthday";
            this.dtfldEmpBirthday.Size = new System.Drawing.Size(111, 21);
            this.dtfldEmpBirthday.TabIndex = 77;
            // 
            // cmbEmpState
            // 
            this.cmbEmpState.FormattingEnabled = true;
            this.cmbEmpState.Location = new System.Drawing.Point(260, 267);
            this.cmbEmpState.Name = "cmbEmpState";
            this.cmbEmpState.Size = new System.Drawing.Size(92, 20);
            this.cmbEmpState.TabIndex = 76;
            // 
            // cmbEmpNation
            // 
            this.cmbEmpNation.FormattingEnabled = true;
            this.cmbEmpNation.Location = new System.Drawing.Point(652, 195);
            this.cmbEmpNation.Name = "cmbEmpNation";
            this.cmbEmpNation.Size = new System.Drawing.Size(114, 20);
            this.cmbEmpNation.TabIndex = 75;
            // 
            // txtfldEmpRemark
            // 
            this.txtfldEmpRemark.AllowDrop = true;
            this.txtfldEmpRemark.Location = new System.Drawing.Point(262, 160);
            this.txtfldEmpRemark.MaxLength = 50;
            this.txtfldEmpRemark.Multiline = true;
            this.txtfldEmpRemark.Name = "txtfldEmpRemark";
            this.txtfldEmpRemark.Size = new System.Drawing.Size(308, 91);
            this.txtfldEmpRemark.TabIndex = 73;
            // 
            // txtEmpCity
            // 
            this.txtEmpCity.Location = new System.Drawing.Point(260, 125);
            this.txtEmpCity.MaxLength = 50;
            this.txtEmpCity.Name = "txtEmpCity";
            this.txtEmpCity.Size = new System.Drawing.Size(309, 21);
            this.txtEmpCity.TabIndex = 72;
            // 
            // txtEmpEmail
            // 
            this.txtEmpEmail.Location = new System.Drawing.Point(560, 74);
            this.txtEmpEmail.MaxLength = 30;
            this.txtEmpEmail.Name = "txtEmpEmail";
            this.txtEmpEmail.Size = new System.Drawing.Size(204, 21);
            this.txtEmpEmail.TabIndex = 71;
            // 
            // txtEmpOfficeTel
            // 
            this.txtEmpOfficeTel.Location = new System.Drawing.Point(262, 98);
            this.txtEmpOfficeTel.MaxLength = 20;
            this.txtEmpOfficeTel.Name = "txtEmpOfficeTel";
            this.txtEmpOfficeTel.Size = new System.Drawing.Size(189, 21);
            this.txtEmpOfficeTel.TabIndex = 70;
            // 
            // txtEmpIDcard
            // 
            this.txtEmpIDcard.Location = new System.Drawing.Point(560, 41);
            this.txtEmpIDcard.MaxLength = 18;
            this.txtEmpIDcard.Name = "txtEmpIDcard";
            this.txtEmpIDcard.Size = new System.Drawing.Size(204, 21);
            this.txtEmpIDcard.TabIndex = 69;
            // 
            // txtEmpEngish
            // 
            this.txtEmpEngish.Location = new System.Drawing.Point(262, 44);
            this.txtEmpEngish.MaxLength = 20;
            this.txtEmpEngish.Name = "txtEmpEngish";
            this.txtEmpEngish.Size = new System.Drawing.Size(189, 21);
            this.txtEmpEngish.TabIndex = 68;
            // 
            // txtPasswod
            // 
            this.txtPasswod.Location = new System.Drawing.Point(262, 71);
            this.txtPasswod.MaxLength = 20;
            this.txtPasswod.Name = "txtPasswod";
            this.txtPasswod.PasswordChar = '*';
            this.txtPasswod.Size = new System.Drawing.Size(189, 21);
            this.txtPasswod.TabIndex = 67;
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(560, 14);
            this.txtEmpName.MaxLength = 30;
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(204, 21);
            this.txtEmpName.TabIndex = 66;
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(261, 17);
            this.txtEmployeeID.MaxLength = 30;
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(190, 21);
            this.txtEmployeeID.TabIndex = 65;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(190, 306);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 12);
            this.label20.TabIndex = 64;
            this.label20.Text = "是否在职：";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(581, 158);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 12);
            this.label18.TabIndex = 62;
            this.label18.Text = "离职时间：";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(190, 163);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 61;
            this.label17.Text = "工作简历：";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(190, 128);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 12);
            this.label16.TabIndex = 60;
            this.label16.Text = "家庭住址：";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(479, 83);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 12);
            this.label15.TabIndex = 59;
            this.label15.Text = "EMAIL：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(581, 125);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 58;
            this.label12.Text = "入职时间：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(190, 270);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 57;
            this.label11.Text = "婚姻状态：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(422, 304);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 56;
            this.label10.Text = "QQ：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(479, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 55;
            this.label9.Text = "身份证号：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(391, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 54;
            this.label8.Text = "出生日期：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(592, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 53;
            this.label7.Text = "性别：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(191, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 52;
            this.label6.Text = "初始密码：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 51;
            this.label5.Text = "联系电话：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(592, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 50;
            this.label4.Text = "民族：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 49;
            this.label3.Text = "登录名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(479, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 48;
            this.label2.Text = "员工姓名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 47;
            this.label1.Text = "员工编号：";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 18);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(168, 349);
            this.treeView1.TabIndex = 88;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1.bmp");
            this.imageList1.Images.SetKeyName(1, "2.bmp");
            // 
            // bntUpdate
            // 
            this.bntUpdate.Location = new System.Drawing.Point(331, 337);
            this.bntUpdate.Name = "bntUpdate";
            this.bntUpdate.Size = new System.Drawing.Size(104, 23);
            this.bntUpdate.TabIndex = 89;
            this.bntUpdate.Text = "修改(&H)";
            this.bntUpdate.UseVisualStyleBackColor = true;
            this.bntUpdate.Click += new System.EventHandler(this.bntUpdate_Click);
            // 
            // bntDelete
            // 
            this.bntDelete.Location = new System.Drawing.Point(465, 337);
            this.bntDelete.Name = "bntDelete";
            this.bntDelete.Size = new System.Drawing.Size(104, 23);
            this.bntDelete.TabIndex = 90;
            this.bntDelete.Text = "删除(&D)";
            this.bntDelete.UseVisualStyleBackColor = true;
            this.bntDelete.Click += new System.EventHandler(this.bntDelete_Click);
            // 
            // frmEmployeeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 387);
            this.Controls.Add(this.bntDelete);
            this.Controls.Add(this.bntUpdate);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.bntEsce);
            this.Controls.Add(this.bntOK);
            this.Controls.Add(this.txtEmpOICQ);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.rdfldEmpWorkFlag1);
            this.Controls.Add(this.dtEmpDemissionDate);
            this.Controls.Add(this.cmbEmpSex);
            this.Controls.Add(this.dtEmpWorkDate);
            this.Controls.Add(this.dtfldEmpBirthday);
            this.Controls.Add(this.cmbEmpState);
            this.Controls.Add(this.cmbEmpNation);
            this.Controls.Add(this.txtfldEmpRemark);
            this.Controls.Add(this.txtEmpCity);
            this.Controls.Add(this.txtEmpEmail);
            this.Controls.Add(this.txtEmpOfficeTel);
            this.Controls.Add(this.txtEmpIDcard);
            this.Controls.Add(this.txtEmpEngish);
            this.Controls.Add(this.txtPasswod);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmEmployeeInfo";
            this.Text = "frmEmployeeInfo";
            this.Load += new System.EventHandler(this.frmEmployeeInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntEsce;
        private System.Windows.Forms.Button bntOK;
        private System.Windows.Forms.TextBox txtEmpOICQ;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rdfldEmpWorkFlag1;
        private System.Windows.Forms.DateTimePicker dtEmpDemissionDate;
        private System.Windows.Forms.ComboBox cmbEmpSex;
        private System.Windows.Forms.DateTimePicker dtEmpWorkDate;
        private System.Windows.Forms.DateTimePicker dtfldEmpBirthday;
        private System.Windows.Forms.ComboBox cmbEmpState;
        private System.Windows.Forms.ComboBox cmbEmpNation;
        private System.Windows.Forms.TextBox txtfldEmpRemark;
        private System.Windows.Forms.TextBox txtEmpCity;
        private System.Windows.Forms.TextBox txtEmpEmail;
        private System.Windows.Forms.TextBox txtEmpOfficeTel;
        private System.Windows.Forms.TextBox txtEmpIDcard;
        private System.Windows.Forms.TextBox txtEmpEngish;
        private System.Windows.Forms.TextBox txtPasswod;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeView1;
        public System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button bntUpdate;
        private System.Windows.Forms.Button bntDelete;
    }
}