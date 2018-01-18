namespace SALE.UI.DataReport.WinForm
{
    partial class FormOperationCollect
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
            this.btnExit = new System.Windows.Forms.Button();
            this.gbCollectType = new System.Windows.Forms.GroupBox();
            this.rbUntread = new System.Windows.Forms.RadioButton();
            this.rbSale = new System.Windows.Forms.RadioButton();
            this.chbNoAgent = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.chbAgent = new System.Windows.Forms.CheckBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.crvCollect = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.gbCollectType.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(121, 305);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 124;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gbCollectType
            // 
            this.gbCollectType.Controls.Add(this.rbUntread);
            this.gbCollectType.Controls.Add(this.rbSale);
            this.gbCollectType.Location = new System.Drawing.Point(22, 128);
            this.gbCollectType.Name = "gbCollectType";
            this.gbCollectType.Size = new System.Drawing.Size(174, 143);
            this.gbCollectType.TabIndex = 132;
            this.gbCollectType.TabStop = false;
            this.gbCollectType.Text = "汇总分类";
            // 
            // rbUntread
            // 
            this.rbUntread.AutoSize = true;
            this.rbUntread.Location = new System.Drawing.Point(54, 50);
            this.rbUntread.Name = "rbUntread";
            this.rbUntread.Size = new System.Drawing.Size(71, 16);
            this.rbUntread.TabIndex = 128;
            this.rbUntread.Text = "退货汇总";
            this.rbUntread.UseVisualStyleBackColor = true;
            // 
            // rbSale
            // 
            this.rbSale.AutoSize = true;
            this.rbSale.Checked = true;
            this.rbSale.Location = new System.Drawing.Point(54, 17);
            this.rbSale.Name = "rbSale";
            this.rbSale.Size = new System.Drawing.Size(71, 16);
            this.rbSale.TabIndex = 127;
            this.rbSale.TabStop = true;
            this.rbSale.Text = "销售汇总";
            this.rbSale.UseVisualStyleBackColor = true;
            // 
            // chbNoAgent
            // 
            this.chbNoAgent.AutoSize = true;
            this.chbNoAgent.Checked = true;
            this.chbNoAgent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbNoAgent.Location = new System.Drawing.Point(148, 98);
            this.chbNoAgent.Name = "chbNoAgent";
            this.chbNoAgent.Size = new System.Drawing.Size(48, 16);
            this.chbNoAgent.TabIndex = 1;
            this.chbNoAgent.Text = "普通";
            this.chbNoAgent.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 126;
            this.label3.Text = "用户类型";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(76, 20);
            this.dtpStartDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.ShowCheckBox = true;
            this.dtpStartDate.Size = new System.Drawing.Size(120, 21);
            this.dtpStartDate.TabIndex = 116;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 115;
            this.label9.Text = "开始日期";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(76, 59);
            this.dtpEndDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.ShowCheckBox = true;
            this.dtpEndDate.Size = new System.Drawing.Size(120, 21);
            this.dtpEndDate.TabIndex = 120;
            // 
            // chbAgent
            // 
            this.chbAgent.AutoSize = true;
            this.chbAgent.Checked = true;
            this.chbAgent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbAgent.Location = new System.Drawing.Point(76, 98);
            this.chbAgent.Name = "chbAgent";
            this.chbAgent.Size = new System.Drawing.Size(48, 16);
            this.chbAgent.TabIndex = 0;
            this.chbAgent.Text = "代理";
            this.chbAgent.UseVisualStyleBackColor = true;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(22, 305);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 123;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
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
            this.splitContainer1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpEndDate);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnQuery);
            this.groupBox1.Controls.Add(this.chbAgent);
            this.groupBox1.Controls.Add(this.gbCollectType);
            this.groupBox1.Controls.Add(this.chbNoAgent);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpStartDate);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 347);
            this.groupBox1.TabIndex = 125;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 119;
            this.label1.Text = "结束日期";
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
            // FormOperationCollect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 549);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOperationCollect";
            this.ShowInTaskbar = false;
            this.Text = "汇总表";
            this.Load += new System.EventHandler(this.FormOperationCollect_Load);
            this.gbCollectType.ResumeLayout(false);
            this.gbCollectType.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox gbCollectType;
        private System.Windows.Forms.RadioButton rbUntread;
        private System.Windows.Forms.RadioButton rbSale;
        private System.Windows.Forms.CheckBox chbNoAgent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.CheckBox chbAgent;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvCollect;
    }
}