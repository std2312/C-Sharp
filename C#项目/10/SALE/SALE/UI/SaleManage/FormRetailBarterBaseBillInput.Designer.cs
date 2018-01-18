namespace SALE.UI.SaleManage
{
    partial class FormRetailBarterBaseBillInput
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
            this.label11 = new System.Windows.Forms.Label();
            this.txtBarterBillNo = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.cbxGoodsTypeCode = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.cbxGoodsSeriesCode = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpBarterBillDate = new System.Windows.Forms.DateTimePicker();
            this.txtSaleBillNo = new System.Windows.Forms.TextBox();
            this.chbIsAmendBillNo = new System.Windows.Forms.CheckBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lb1 = new System.Windows.Forms.Label();
            this.txtRemark1 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.dtpSignDate1 = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.cbxEmployeeCode1 = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbIsNeedInvoice0 = new System.Windows.Forms.RadioButton();
            this.rbIsNeedInvoice1 = new System.Windows.Forms.RadioButton();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtUnitPrice1 = new System.Windows.Forms.TextBox();
            this.cbxGoodsTypeCode1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxGoodsSeriesCode1 = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.cbxBarterType = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtTotalBanlance = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBarterQuantity = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCD = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(658, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 12);
            this.label11.TabIndex = 111;
            this.label11.Text = "NO";
            // 
            // txtBarterBillNo
            // 
            this.txtBarterBillNo.AcceptsReturn = true;
            this.txtBarterBillNo.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBarterBillNo.Location = new System.Drawing.Point(680, 23);
            this.txtBarterBillNo.MaxLength = 13;
            this.txtBarterBillNo.Name = "txtBarterBillNo";
            this.txtBarterBillNo.ReadOnly = true;
            this.txtBarterBillNo.Size = new System.Drawing.Size(110, 21);
            this.txtBarterBillNo.TabIndex = 112;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtUnitPrice);
            this.groupBox4.Controls.Add(this.cbxGoodsTypeCode);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.cbxGoodsSeriesCode);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(4, 43);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(399, 49);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "原产品信息";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(340, 18);
            this.txtUnitPrice.MaxLength = 9;
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(56, 21);
            this.txtUnitPrice.TabIndex = 128;
            this.txtUnitPrice.TextChanged += new System.EventHandler(this.txtUnitPrice_TextChanged);
            this.txtUnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnitPrice_KeyPress);
            // 
            // cbxGoodsTypeCode
            // 
            this.cbxGoodsTypeCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGoodsTypeCode.FormattingEnabled = true;
            this.cbxGoodsTypeCode.Location = new System.Drawing.Point(65, 18);
            this.cbxGoodsTypeCode.Name = "cbxGoodsTypeCode";
            this.cbxGoodsTypeCode.Size = new System.Drawing.Size(105, 20);
            this.cbxGoodsTypeCode.TabIndex = 92;
            this.cbxGoodsTypeCode.Tag = "GoodsTypeCode";
            // 
            // label21
            // 
            this.label21.AutoEllipsis = true;
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 22);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(53, 12);
            this.label21.TabIndex = 103;
            this.label21.Text = "原 种 类";
            // 
            // label23
            // 
            this.label23.AutoEllipsis = true;
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(171, 22);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(41, 12);
            this.label23.TabIndex = 119;
            this.label23.Text = "原版本";
            // 
            // cbxGoodsSeriesCode
            // 
            this.cbxGoodsSeriesCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGoodsSeriesCode.FormattingEnabled = true;
            this.cbxGoodsSeriesCode.Location = new System.Drawing.Point(216, 18);
            this.cbxGoodsSeriesCode.Name = "cbxGoodsSeriesCode";
            this.cbxGoodsSeriesCode.Size = new System.Drawing.Size(93, 20);
            this.cbxGoodsSeriesCode.TabIndex = 120;
            this.cbxGoodsSeriesCode.Tag = "GoodsSeriesCode";
            this.cbxGoodsSeriesCode.SelectedIndexChanged += new System.EventHandler(this.cbxGoodsSeriesCode_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoEllipsis = true;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(308, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 121;
            this.label8.Text = "单价";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(174, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 111;
            this.label5.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 65;
            this.label2.Text = "销售单号";
            // 
            // dtpBarterBillDate
            // 
            this.dtpBarterBillDate.Location = new System.Drawing.Point(668, 18);
            this.dtpBarterBillDate.Name = "dtpBarterBillDate";
            this.dtpBarterBillDate.Size = new System.Drawing.Size(126, 21);
            this.dtpBarterBillDate.TabIndex = 89;
            // 
            // txtSaleBillNo
            // 
            this.txtSaleBillNo.AcceptsReturn = true;
            this.txtSaleBillNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSaleBillNo.Location = new System.Drawing.Point(67, 18);
            this.txtSaleBillNo.MaxLength = 13;
            this.txtSaleBillNo.Name = "txtSaleBillNo";
            this.txtSaleBillNo.Size = new System.Drawing.Size(89, 21);
            this.txtSaleBillNo.TabIndex = 103;
            this.txtSaleBillNo.TextChanged += new System.EventHandler(this.txtSaleBillNo_TextChanged);
            this.txtSaleBillNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSaleBillNo_KeyDown);
            // 
            // chbIsAmendBillNo
            // 
            this.chbIsAmendBillNo.AutoSize = true;
            this.chbIsAmendBillNo.Location = new System.Drawing.Point(584, 26);
            this.chbIsAmendBillNo.Name = "chbIsAmendBillNo";
            this.chbIsAmendBillNo.Size = new System.Drawing.Size(72, 16);
            this.chbIsAmendBillNo.TabIndex = 116;
            this.chbIsAmendBillNo.Text = "修改单号";
            this.chbIsAmendBillNo.UseVisualStyleBackColor = true;
            this.chbIsAmendBillNo.CheckedChanged += new System.EventHandler(this.chbIsAmendBillNo_CheckedChanged);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("宋体", 4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBrowse.Location = new System.Drawing.Point(155, 17);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(20, 23);
            this.btnBrowse.TabIndex = 104;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(609, 22);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(53, 12);
            this.lb1.TabIndex = 42;
            this.lb1.Text = "换货日期";
            // 
            // txtRemark1
            // 
            this.txtRemark1.Location = new System.Drawing.Point(461, 133);
            this.txtRemark1.MaxLength = 100;
            this.txtRemark1.Name = "txtRemark1";
            this.txtRemark1.Size = new System.Drawing.Size(333, 21);
            this.txtRemark1.TabIndex = 102;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(405, 136);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 12);
            this.label20.TabIndex = 101;
            this.label20.Text = "备    注";
            // 
            // dtpSignDate1
            // 
            this.dtpSignDate1.Location = new System.Drawing.Point(219, 163);
            this.dtpSignDate1.Name = "dtpSignDate1";
            this.dtpSignDate1.ShowCheckBox = true;
            this.dtpSignDate1.Size = new System.Drawing.Size(122, 21);
            this.dtpSignDate1.TabIndex = 100;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(174, 166);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 12);
            this.label19.TabIndex = 99;
            this.label19.Text = "下单日";
            // 
            // cbxEmployeeCode1
            // 
            this.cbxEmployeeCode1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEmployeeCode1.FormattingEnabled = true;
            this.cbxEmployeeCode1.Location = new System.Drawing.Point(67, 163);
            this.cbxEmployeeCode1.Name = "cbxEmployeeCode1";
            this.cbxEmployeeCode1.Size = new System.Drawing.Size(101, 20);
            this.cbxEmployeeCode1.TabIndex = 98;
            this.cbxEmployeeCode1.Tag = "EmployeeCode";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(11, 166);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 12);
            this.label18.TabIndex = 4;
            this.label18.Text = "下 单 人";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbIsNeedInvoice0);
            this.groupBox1.Controls.Add(this.rbIsNeedInvoice1);
            this.groupBox1.Controls.Add(this.txtPhoneNumber);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtCustomerName);
            this.groupBox1.Controls.Add(this.cbxBarterType);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSaleBillNo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpBarterBillDate);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.lb1);
            this.groupBox1.Controls.Add(this.txtRemark1);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.dtpSignDate1);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.cbxEmployeeCode1);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.txtTotalBanlance);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtBarterQuantity);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Location = new System.Drawing.Point(3, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(801, 198);
            this.groupBox1.TabIndex = 110;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "换货信息";
            // 
            // rbIsNeedInvoice0
            // 
            this.rbIsNeedInvoice0.AutoSize = true;
            this.rbIsNeedInvoice0.Checked = true;
            this.rbIsNeedInvoice0.Location = new System.Drawing.Point(752, 103);
            this.rbIsNeedInvoice0.Name = "rbIsNeedInvoice0";
            this.rbIsNeedInvoice0.Size = new System.Drawing.Size(35, 16);
            this.rbIsNeedInvoice0.TabIndex = 131;
            this.rbIsNeedInvoice0.TabStop = true;
            this.rbIsNeedInvoice0.Text = "否";
            this.rbIsNeedInvoice0.UseVisualStyleBackColor = true;
            // 
            // rbIsNeedInvoice1
            // 
            this.rbIsNeedInvoice1.AutoSize = true;
            this.rbIsNeedInvoice1.Location = new System.Drawing.Point(690, 103);
            this.rbIsNeedInvoice1.Name = "rbIsNeedInvoice1";
            this.rbIsNeedInvoice1.Size = new System.Drawing.Size(35, 16);
            this.rbIsNeedInvoice1.TabIndex = 130;
            this.rbIsNeedInvoice1.TabStop = true;
            this.rbIsNeedInvoice1.Text = "是";
            this.rbIsNeedInvoice1.UseVisualStyleBackColor = true;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Enabled = false;
            this.txtPhoneNumber.Location = new System.Drawing.Point(461, 102);
            this.txtPhoneNumber.MaxLength = 50;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(146, 21);
            this.txtPhoneNumber.TabIndex = 129;
            // 
            // txtAddress
            // 
            this.txtAddress.Enabled = false;
            this.txtAddress.Location = new System.Drawing.Point(67, 133);
            this.txtAddress.MaxLength = 50;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(333, 21);
            this.txtAddress.TabIndex = 128;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtUnitPrice1);
            this.groupBox2.Controls.Add(this.cbxGoodsTypeCode1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbxGoodsSeriesCode1);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Location = new System.Drawing.Point(406, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(391, 49);
            this.groupBox2.TabIndex = 122;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "现产品信息";
            // 
            // txtUnitPrice1
            // 
            this.txtUnitPrice1.Location = new System.Drawing.Point(326, 18);
            this.txtUnitPrice1.MaxLength = 9;
            this.txtUnitPrice1.Name = "txtUnitPrice1";
            this.txtUnitPrice1.Size = new System.Drawing.Size(58, 21);
            this.txtUnitPrice1.TabIndex = 129;
            this.txtUnitPrice1.TextChanged += new System.EventHandler(this.txtUnitPrice1_TextChanged);
            this.txtUnitPrice1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnitPrice1_KeyPress);
            // 
            // cbxGoodsTypeCode1
            // 
            this.cbxGoodsTypeCode1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGoodsTypeCode1.FormattingEnabled = true;
            this.cbxGoodsTypeCode1.Location = new System.Drawing.Point(51, 18);
            this.cbxGoodsTypeCode1.Name = "cbxGoodsTypeCode1";
            this.cbxGoodsTypeCode1.Size = new System.Drawing.Size(101, 20);
            this.cbxGoodsTypeCode1.TabIndex = 92;
            this.cbxGoodsTypeCode1.Tag = "GoodsTypeCode";
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 103;
            this.label3.Text = "现种类";
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 119;
            this.label4.Text = "现版本";
            // 
            // cbxGoodsSeriesCode1
            // 
            this.cbxGoodsSeriesCode1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGoodsSeriesCode1.FormattingEnabled = true;
            this.cbxGoodsSeriesCode1.Location = new System.Drawing.Point(200, 18);
            this.cbxGoodsSeriesCode1.Name = "cbxGoodsSeriesCode1";
            this.cbxGoodsSeriesCode1.Size = new System.Drawing.Size(93, 20);
            this.cbxGoodsSeriesCode1.TabIndex = 120;
            this.cbxGoodsSeriesCode1.Tag = "GoodsSeriesCode";
            this.cbxGoodsSeriesCode1.SelectedIndexChanged += new System.EventHandler(this.cbxGoodsSeriesCode1_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoEllipsis = true;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(294, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 12);
            this.label16.TabIndex = 121;
            this.label16.Text = "单价";
            // 
            // label15
            // 
            this.label15.AutoEllipsis = true;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 136);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 127;
            this.label15.Text = "地    址";
            // 
            // label14
            // 
            this.label14.AutoEllipsis = true;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(609, 105);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 12);
            this.label14.TabIndex = 126;
            this.label14.Text = "是否要发票";
            // 
            // label13
            // 
            this.label13.AutoEllipsis = true;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(405, 105);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 125;
            this.label13.Text = "联系电话";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Enabled = false;
            this.txtCustomerName.Location = new System.Drawing.Point(219, 18);
            this.txtCustomerName.MaxLength = 50;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(181, 21);
            this.txtCustomerName.TabIndex = 118;
            // 
            // cbxBarterType
            // 
            this.cbxBarterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBarterType.FormattingEnabled = true;
            this.cbxBarterType.Location = new System.Drawing.Point(461, 18);
            this.cbxBarterType.Name = "cbxBarterType";
            this.cbxBarterType.Size = new System.Drawing.Size(146, 20);
            this.cbxBarterType.TabIndex = 117;
            this.cbxBarterType.Tag = "BarterType";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(405, 21);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(53, 12);
            this.label22.TabIndex = 112;
            this.label22.Text = "换货类型";
            // 
            // txtTotalBanlance
            // 
            this.txtTotalBanlance.Location = new System.Drawing.Point(219, 102);
            this.txtTotalBanlance.MaxLength = 13;
            this.txtTotalBanlance.Name = "txtTotalBanlance";
            this.txtTotalBanlance.ReadOnly = true;
            this.txtTotalBanlance.Size = new System.Drawing.Size(181, 21);
            this.txtTotalBanlance.TabIndex = 96;
            // 
            // label7
            // 
            this.label7.AutoEllipsis = true;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(174, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 84;
            this.label7.Text = "总差额";
            // 
            // txtBarterQuantity
            // 
            this.txtBarterQuantity.Location = new System.Drawing.Point(67, 102);
            this.txtBarterQuantity.MaxLength = 5;
            this.txtBarterQuantity.Name = "txtBarterQuantity";
            this.txtBarterQuantity.Size = new System.Drawing.Size(101, 21);
            this.txtBarterQuantity.TabIndex = 73;
            this.txtBarterQuantity.TextChanged += new System.EventHandler(this.txtBarterQuantity_TextChanged);
            this.txtBarterQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarterQuantity_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 74;
            this.label10.Text = "数    量";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(684, 260);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 115;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(464, 260);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 114;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(293, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 16);
            this.label1.TabIndex = 113;
            this.label1.Text = "编  程  词  典  换  货  单";
            // 
            // btnCD
            // 
            this.btnCD.Location = new System.Drawing.Point(574, 260);
            this.btnCD.Name = "btnCD";
            this.btnCD.Size = new System.Drawing.Size(75, 23);
            this.btnCD.TabIndex = 117;
            this.btnCD.Text = "光盘档案";
            this.btnCD.UseVisualStyleBackColor = true;
            this.btnCD.Click += new System.EventHandler(this.btnCD_Click);
            // 
            // FormRetailBarterBaseBillInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 297);
            this.Controls.Add(this.btnCD);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtBarterBillNo);
            this.Controls.Add(this.chbIsAmendBillNo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRetailBarterBaseBillInput";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "换货单编辑";
            this.Load += new System.EventHandler(this.FormRetailBarterBaseBillInput_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DateTimePicker dtpBarterBillDate;
        public System.Windows.Forms.TextBox txtSaleBillNo;
        private System.Windows.Forms.CheckBox chbIsAmendBillNo;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label label21;
        public System.Windows.Forms.TextBox txtRemark1;
        private System.Windows.Forms.Label label20;
        public System.Windows.Forms.DateTimePicker dtpSignDate1;
        private System.Windows.Forms.Label label19;
        public System.Windows.Forms.ComboBox cbxEmployeeCode1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txtTotalBanlance;
        public System.Windows.Forms.ComboBox cbxGoodsTypeCode;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtBarterQuantity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label22;
        public System.Windows.Forms.ComboBox cbxBarterType;
        public System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label23;
        public System.Windows.Forms.ComboBox cbxGoodsSeriesCode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.ComboBox cbxGoodsTypeCode1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox cbxGoodsSeriesCode1;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.TextBox txtUnitPrice;
        public System.Windows.Forms.TextBox txtUnitPrice1;
        public System.Windows.Forms.TextBox txtAddress;
        public System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.RadioButton rbIsNeedInvoice0;
        private System.Windows.Forms.RadioButton rbIsNeedInvoice1;
        public System.Windows.Forms.TextBox txtBarterBillNo;
        private System.Windows.Forms.Button btnCD;
    }
}