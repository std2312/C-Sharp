namespace SALE.UI.ChartAnalyse.WinForm
{
    partial class FormDifferentMonthSaleAnalyse
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
            this.dtpEndMonth = new System.Windows.Forms.DateTimePicker();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQuery = new System.Windows.Forms.Button();
            this.gbCollectType = new System.Windows.Forms.GroupBox();
            this.rbMoney = new System.Windows.Forms.RadioButton();
            this.rbQuantity = new System.Windows.Forms.RadioButton();
            this.dtpStartMonth = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.crvCollect = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbCollectType.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpEndMonth
            // 
            this.dtpEndMonth.CustomFormat = "yyyy年MM月";
            this.dtpEndMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndMonth.Location = new System.Drawing.Point(76, 59);
            this.dtpEndMonth.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpEndMonth.Name = "dtpEndMonth";
            this.dtpEndMonth.Size = new System.Drawing.Size(120, 21);
            this.dtpEndMonth.TabIndex = 120;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.crvCollect);
            this.splitContainer1.Size = new System.Drawing.Size(1033, 549);
            this.splitContainer1.SplitterDistance = 249;
            this.splitContainer1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpEndMonth);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnQuery);
            this.groupBox1.Controls.Add(this.gbCollectType);
            this.groupBox1.Controls.Add(this.dtpStartMonth);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 298);
            this.groupBox1.TabIndex = 125;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(121, 242);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 124;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 119;
            this.label1.Text = "结束月份";
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(22, 242);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 123;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // gbCollectType
            // 
            this.gbCollectType.Controls.Add(this.rbMoney);
            this.gbCollectType.Controls.Add(this.rbQuantity);
            this.gbCollectType.Location = new System.Drawing.Point(22, 91);
            this.gbCollectType.Name = "gbCollectType";
            this.gbCollectType.Size = new System.Drawing.Size(174, 122);
            this.gbCollectType.TabIndex = 132;
            this.gbCollectType.TabStop = false;
            this.gbCollectType.Text = "对比图分类";
            // 
            // rbMoney
            // 
            this.rbMoney.AutoSize = true;
            this.rbMoney.Location = new System.Drawing.Point(54, 41);
            this.rbMoney.Name = "rbMoney";
            this.rbMoney.Size = new System.Drawing.Size(95, 16);
            this.rbMoney.TabIndex = 128;
            this.rbMoney.Text = "销售额对比图";
            this.rbMoney.UseVisualStyleBackColor = true;

            // 
            // rbQuantity
            // 
            this.rbQuantity.AutoSize = true;
            this.rbQuantity.Checked = true;
            this.rbQuantity.Location = new System.Drawing.Point(54, 18);
            this.rbQuantity.Name = "rbQuantity";
            this.rbQuantity.Size = new System.Drawing.Size(95, 16);
            this.rbQuantity.TabIndex = 127;
            this.rbQuantity.TabStop = true;
            this.rbQuantity.Text = "销售量对比图";
            this.rbQuantity.UseVisualStyleBackColor = true;

            // 
            // dtpStartMonth
            // 
            this.dtpStartMonth.CustomFormat = "yyyy年MM月";
            this.dtpStartMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartMonth.Location = new System.Drawing.Point(76, 20);
            this.dtpStartMonth.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpStartMonth.Name = "dtpStartMonth";
            this.dtpStartMonth.Size = new System.Drawing.Size(120, 21);
            this.dtpStartMonth.TabIndex = 116;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 115;
            this.label9.Text = "开始月份";
            // 
            // crvCollect
            // 
            this.crvCollect.ActiveViewIndex = -1;
            this.crvCollect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvCollect.DisplayGroupTree = false;
            this.crvCollect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvCollect.Location = new System.Drawing.Point(0, 0);
            this.crvCollect.Name = "crvCollect";
            this.crvCollect.SelectionFormula = "";
            this.crvCollect.Size = new System.Drawing.Size(780, 549);
            this.crvCollect.TabIndex = 0;
            this.crvCollect.ViewTimeSelectionFormula = "";
            // 
            // FormDifferentMonthSaleAnalyse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 549);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDifferentMonthSaleAnalyse";
            this.ShowInTaskbar = false;
            this.Text = "不同月份之间销售情况对比分析图";
            this.Load += new System.EventHandler(this.FormDifferentMonthSaleAnalyse_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbCollectType.ResumeLayout(false);
            this.gbCollectType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpEndMonth;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.GroupBox gbCollectType;
        private System.Windows.Forms.RadioButton rbMoney;
        private System.Windows.Forms.RadioButton rbQuantity;
        private System.Windows.Forms.DateTimePicker dtpStartMonth;
        private System.Windows.Forms.Label label9;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvCollect;
    }
}