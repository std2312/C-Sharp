namespace SALE.UI.AgentManage
{
    partial class FormDepRegister
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDepRegister));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvAgentRecord = new System.Windows.Forms.TreeView();
            this.dgvDepRegister = new System.Windows.Forms.DataGridView();
            this.BeginDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Years = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgentLevelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeastMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgentLevelCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsDepRegister = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolAdd = new System.Windows.Forms.ToolStripButton();
            this.toolAmend = new System.Windows.Forms.ToolStripButton();
            this.toolDelete = new System.Windows.Forms.ToolStripButton();
            this.toolExit = new System.Windows.Forms.ToolStripButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepRegister)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDepRegister)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvAgentRecord);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvDepRegister);
            this.splitContainer1.Size = new System.Drawing.Size(662, 396);
            this.splitContainer1.SplitterDistance = 220;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // tvAgentRecord
            // 
            this.tvAgentRecord.Location = new System.Drawing.Point(0, 26);
            this.tvAgentRecord.Name = "tvAgentRecord";
            this.tvAgentRecord.Size = new System.Drawing.Size(220, 370);
            this.tvAgentRecord.TabIndex = 0;
            this.tvAgentRecord.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvAgentRecord_AfterSelect);
            // 
            // dgvDepRegister
            // 
            this.dgvDepRegister.AllowUserToAddRows = false;
            this.dgvDepRegister.AllowUserToResizeColumns = false;
            this.dgvDepRegister.AllowUserToResizeRows = false;
            this.dgvDepRegister.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDepRegister.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDepRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDepRegister.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BeginDate,
            this.EndDate,
            this.Years,
            this.AgentLevelName,
            this.LeastMoney,
            this.Discount,
            this.Remark,
            this.AgentLevelCode});
            this.dgvDepRegister.Location = new System.Drawing.Point(0, 26);
            this.dgvDepRegister.Name = "dgvDepRegister";
            this.dgvDepRegister.RowHeadersVisible = false;
            this.dgvDepRegister.RowTemplate.Height = 23;
            this.dgvDepRegister.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDepRegister.Size = new System.Drawing.Size(441, 370);
            this.dgvDepRegister.TabIndex = 0;
            this.dgvDepRegister.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDepRegister_CellDoubleClick);
            // 
            // BeginDate
            // 
            this.BeginDate.DataPropertyName = "BeginDate";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "D";
            dataGridViewCellStyle2.NullValue = null;
            this.BeginDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.BeginDate.HeaderText = "开始日期";
            this.BeginDate.Name = "BeginDate";
            this.BeginDate.ReadOnly = true;
            // 
            // EndDate
            // 
            this.EndDate.DataPropertyName = "EndDate";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "D";
            dataGridViewCellStyle3.NullValue = null;
            this.EndDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.EndDate.HeaderText = "结束日期";
            this.EndDate.Name = "EndDate";
            this.EndDate.ReadOnly = true;
            // 
            // Years
            // 
            this.Years.DataPropertyName = "Years";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = null;
            this.Years.DefaultCellStyle = dataGridViewCellStyle4;
            this.Years.HeaderText = "年 限 数";
            this.Years.Name = "Years";
            this.Years.ReadOnly = true;
            this.Years.Width = 80;
            // 
            // AgentLevelName
            // 
            this.AgentLevelName.DataPropertyName = "AgentLevelName";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.AgentLevelName.DefaultCellStyle = dataGridViewCellStyle5;
            this.AgentLevelName.HeaderText = "代理级别";
            this.AgentLevelName.Name = "AgentLevelName";
            this.AgentLevelName.ReadOnly = true;
            this.AgentLevelName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // LeastMoney
            // 
            this.LeastMoney.DataPropertyName = "LeastMoney";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.LeastMoney.DefaultCellStyle = dataGridViewCellStyle6;
            this.LeastMoney.HeaderText = "销售任务";
            this.LeastMoney.Name = "LeastMoney";
            this.LeastMoney.ReadOnly = true;
            // 
            // Discount
            // 
            this.Discount.DataPropertyName = "Discount";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = null;
            this.Discount.DefaultCellStyle = dataGridViewCellStyle7;
            this.Discount.HeaderText = "代理折扣";
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            this.Discount.Width = 80;
            // 
            // Remark
            // 
            this.Remark.DataPropertyName = "Remark";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Remark.DefaultCellStyle = dataGridViewCellStyle8;
            this.Remark.HeaderText = "备    注";
            this.Remark.Name = "Remark";
            this.Remark.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Remark.Width = 200;
            // 
            // AgentLevelCode
            // 
            this.AgentLevelCode.DataPropertyName = "AgentLevelCode";
            this.AgentLevelCode.HeaderText = "级别代码";
            this.AgentLevelCode.Name = "AgentLevelCode";
            this.AgentLevelCode.Visible = false;
            // 
            // bsDepRegister
            // 
            this.bsDepRegister.AllowNew = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolAdd,
            this.toolAmend,
            this.toolDelete,
            this.toolExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(662, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolAdd
            // 
            this.toolAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolAdd.Image")));
            this.toolAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAdd.Name = "toolAdd";
            this.toolAdd.Size = new System.Drawing.Size(49, 22);
            this.toolAdd.Text = "添加";
            this.toolAdd.Click += new System.EventHandler(this.toolAdd_Click);
            // 
            // toolAmend
            // 
            this.toolAmend.Image = ((System.Drawing.Image)(resources.GetObject("toolAmend.Image")));
            this.toolAmend.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAmend.Name = "toolAmend";
            this.toolAmend.Size = new System.Drawing.Size(49, 22);
            this.toolAmend.Text = "修改";
            this.toolAmend.Click += new System.EventHandler(this.toolAmend_Click);
            // 
            // toolDelete
            // 
            this.toolDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolDelete.Image")));
            this.toolDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDelete.Name = "toolDelete";
            this.toolDelete.Size = new System.Drawing.Size(49, 22);
            this.toolDelete.Text = "删除";
            this.toolDelete.Click += new System.EventHandler(this.toolDelete_Click);
            // 
            // toolExit
            // 
            this.toolExit.Image = ((System.Drawing.Image)(resources.GetObject("toolExit.Image")));
            this.toolExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolExit.Name = "toolExit";
            this.toolExit.Size = new System.Drawing.Size(49, 22);
            this.toolExit.Text = "退出";
            this.toolExit.Click += new System.EventHandler(this.toolExit_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "打开的文件夹副本.ico");
            this.imageList1.Images.SetKeyName(1, "关闭的文件夹副本.ico");
            // 
            // FormDepRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 396);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDepRegister";
            this.ShowInTaskbar = false;
            this.Text = "代理登记";
            this.Load += new System.EventHandler(this.FormDepRegister_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepRegister)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDepRegister)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.BindingSource bsDepRegister;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolAdd;
        private System.Windows.Forms.ToolStripButton toolAmend;
        private System.Windows.Forms.ToolStripButton toolDelete;
        private System.Windows.Forms.ToolStripButton toolExit;
        public System.Windows.Forms.DataGridView dgvDepRegister;
        public System.Windows.Forms.TreeView tvAgentRecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn BeginDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Years;
        private System.Windows.Forms.DataGridViewTextBoxColumn AgentLevelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeastMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
        private System.Windows.Forms.DataGridViewTextBoxColumn AgentLevelCode;
        private System.Windows.Forms.ImageList imageList1;



    }
}