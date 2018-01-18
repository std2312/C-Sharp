namespace SALE.UI.SystemSetting
{
    partial class FormAgentLevel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgentLevel));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolAdd = new System.Windows.Forms.ToolStripButton();
            this.toolAmend = new System.Windows.Forms.ToolStripButton();
            this.toolDelete = new System.Windows.Forms.ToolStripButton();
            this.toolExit = new System.Windows.Forms.ToolStripButton();
            this.dgvAgentLevel = new System.Windows.Forms.DataGridView();
            this.bsAgentLevel = new System.Windows.Forms.BindingSource(this.components);
            this.AgentLevelCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgentLevelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeastMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgentLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAgentLevel)).BeginInit();
            this.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(451, 25);
            this.toolStrip1.TabIndex = 3;
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
            // dgvAgentLevel
            // 
            this.dgvAgentLevel.AllowUserToAddRows = false;
            this.dgvAgentLevel.AllowUserToResizeColumns = false;
            this.dgvAgentLevel.AllowUserToResizeRows = false;
            this.dgvAgentLevel.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAgentLevel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAgentLevel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAgentLevel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AgentLevelCode,
            this.AgentLevelName,
            this.LeastMoney,
            this.Discount});
            this.dgvAgentLevel.Location = new System.Drawing.Point(0, 26);
            this.dgvAgentLevel.Name = "dgvAgentLevel";
            this.dgvAgentLevel.RowHeadersVisible = false;
            this.dgvAgentLevel.RowTemplate.Height = 23;
            this.dgvAgentLevel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAgentLevel.Size = new System.Drawing.Size(451, 308);
            this.dgvAgentLevel.TabIndex = 4;
            this.dgvAgentLevel.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAgentLevel_CellDoubleClick);
            // 
            // AgentLevelCode
            // 
            this.AgentLevelCode.DataPropertyName = "AgentLevelCode";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.AgentLevelCode.DefaultCellStyle = dataGridViewCellStyle2;
            this.AgentLevelCode.HeaderText = "级别代码";
            this.AgentLevelCode.Name = "AgentLevelCode";
            this.AgentLevelCode.ReadOnly = true;
            this.AgentLevelCode.Width = 80;
            // 
            // AgentLevelName
            // 
            this.AgentLevelName.DataPropertyName = "AgentLevelName";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.AgentLevelName.DefaultCellStyle = dataGridViewCellStyle3;
            this.AgentLevelName.HeaderText = "级别名称";
            this.AgentLevelName.Name = "AgentLevelName";
            this.AgentLevelName.ReadOnly = true;
            this.AgentLevelName.Width = 170;
            // 
            // LeastMoney
            // 
            this.LeastMoney.DataPropertyName = "LeastMoney";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.LeastMoney.DefaultCellStyle = dataGridViewCellStyle4;
            this.LeastMoney.HeaderText = "销售任务";
            this.LeastMoney.Name = "LeastMoney";
            this.LeastMoney.ReadOnly = true;
            this.LeastMoney.Width = 118;
            // 
            // Discount
            // 
            this.Discount.DataPropertyName = "Discount";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Discount.DefaultCellStyle = dataGridViewCellStyle5;
            this.Discount.HeaderText = "代理折扣";
            this.Discount.Name = "Discount";
            this.Discount.Width = 80;
            // 
            // FormAgentLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 334);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvAgentLevel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAgentLevel";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "代理级别";
            this.Load += new System.EventHandler(this.FormAgentLevel_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgentLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAgentLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolAdd;
        private System.Windows.Forms.ToolStripButton toolAmend;
        private System.Windows.Forms.ToolStripButton toolDelete;
        private System.Windows.Forms.ToolStripButton toolExit;
        public System.Windows.Forms.DataGridView dgvAgentLevel;
        public System.Windows.Forms.BindingSource bsAgentLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn AgentLevelCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn AgentLevelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeastMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
    }
}