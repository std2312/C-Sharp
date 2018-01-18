namespace SALE.UI.SystemSetting
{
    partial class FormOperator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOperator));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolAdd = new System.Windows.Forms.ToolStripButton();
            this.toolAmend = new System.Windows.Forms.ToolStripButton();
            this.toolDelete = new System.Windows.Forms.ToolStripButton();
            this.toolExit = new System.Windows.Forms.ToolStripButton();
            this.dgvOperator = new System.Windows.Forms.DataGridView();
            this.OperatorCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OperatorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsFlag = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bsOperator = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOperator)).BeginInit();
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
            this.toolStrip1.TabIndex = 5;
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
            // dgvOperator
            // 
            this.dgvOperator.AllowUserToAddRows = false;
            this.dgvOperator.AllowUserToResizeColumns = false;
            this.dgvOperator.AllowUserToResizeRows = false;
            this.dgvOperator.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOperator.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOperator.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvOperator.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OperatorCode,
            this.OperatorName,
            this.Password,
            this.IsFlag});
            this.dgvOperator.Location = new System.Drawing.Point(0, 26);
            this.dgvOperator.Name = "dgvOperator";
            this.dgvOperator.RowHeadersVisible = false;
            this.dgvOperator.RowTemplate.Height = 23;
            this.dgvOperator.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOperator.Size = new System.Drawing.Size(451, 308);
            this.dgvOperator.TabIndex = 6;
            this.dgvOperator.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOperator_CellDoubleClick);
            // 
            // OperatorCode
            // 
            this.OperatorCode.DataPropertyName = "OperatorCode";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.OperatorCode.DefaultCellStyle = dataGridViewCellStyle2;
            this.OperatorCode.HeaderText = "操作员代码";
            this.OperatorCode.Name = "OperatorCode";
            this.OperatorCode.ReadOnly = true;
            this.OperatorCode.Width = 150;
            // 
            // OperatorName
            // 
            this.OperatorName.DataPropertyName = "OperatorName";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.OperatorName.DefaultCellStyle = dataGridViewCellStyle3;
            this.OperatorName.HeaderText = "操作员名称";
            this.OperatorName.Name = "OperatorName";
            this.OperatorName.ReadOnly = true;
            this.OperatorName.Width = 150;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.Password.DefaultCellStyle = dataGridViewCellStyle4;
            this.Password.HeaderText = "操作员密码";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.Visible = false;
            // 
            // IsFlag
            // 
            this.IsFlag.DataPropertyName = "IsFlag";
            this.IsFlag.FalseValue = "0";
            this.IsFlag.HeaderText = "是否超级用户";
            this.IsFlag.Name = "IsFlag";
            this.IsFlag.ReadOnly = true;
            this.IsFlag.TrueValue = "1";
            this.IsFlag.Width = 140;
            // 
            // FormOperator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 334);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvOperator);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOperator";
            this.ShowInTaskbar = false;
            this.Text = "操作员维护";
            this.Load += new System.EventHandler(this.FormOperator_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOperator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolAdd;
        private System.Windows.Forms.ToolStripButton toolAmend;
        private System.Windows.Forms.ToolStripButton toolDelete;
        private System.Windows.Forms.ToolStripButton toolExit;
        public System.Windows.Forms.DataGridView dgvOperator;
        public System.Windows.Forms.BindingSource bsOperator;
        private System.Windows.Forms.DataGridViewTextBoxColumn OperatorCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn OperatorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsFlag;
    }
}