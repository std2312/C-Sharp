namespace SALE.UI.SystemSetting
{
    partial class FormConsignCorp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsignCorp));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolAdd = new System.Windows.Forms.ToolStripButton();
            this.toolAmend = new System.Windows.Forms.ToolStripButton();
            this.toolDelete = new System.Windows.Forms.ToolStripButton();
            this.toolExit = new System.Windows.Forms.ToolStripButton();
            this.dgvConsignCorp = new System.Windows.Forms.DataGridView();
            this.bsConsignCorp = new System.Windows.Forms.BindingSource(this.components);
            this.ConsignCorpCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConsignCorpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Linkman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsignCorp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsConsignCorp)).BeginInit();
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
            // dgvConsignCorp
            // 
            this.dgvConsignCorp.AllowUserToAddRows = false;
            this.dgvConsignCorp.AllowUserToResizeColumns = false;
            this.dgvConsignCorp.AllowUserToResizeRows = false;
            this.dgvConsignCorp.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsignCorp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConsignCorp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvConsignCorp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ConsignCorpCode,
            this.ConsignCorpName,
            this.Linkman,
            this.PhoneNumber,
            this.Address,
            this.Remark});
            this.dgvConsignCorp.Location = new System.Drawing.Point(0, 26);
            this.dgvConsignCorp.Name = "dgvConsignCorp";
            this.dgvConsignCorp.RowHeadersVisible = false;
            this.dgvConsignCorp.RowTemplate.Height = 23;
            this.dgvConsignCorp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsignCorp.Size = new System.Drawing.Size(451, 308);
            this.dgvConsignCorp.TabIndex = 6;
            this.dgvConsignCorp.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsignCorp_CellDoubleClick);
            // 
            // bsConsignCorp
            // 
            this.bsConsignCorp.AllowNew = false;
            // 
            // ConsignCorpCode
            // 
            this.ConsignCorpCode.DataPropertyName = "ConsignCorpCode";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ConsignCorpCode.DefaultCellStyle = dataGridViewCellStyle2;
            this.ConsignCorpCode.HeaderText = "代码";
            this.ConsignCorpCode.Name = "ConsignCorpCode";
            this.ConsignCorpCode.ReadOnly = true;
            this.ConsignCorpCode.Width = 50;
            // 
            // ConsignCorpName
            // 
            this.ConsignCorpName.DataPropertyName = "ConsignCorpName";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ConsignCorpName.DefaultCellStyle = dataGridViewCellStyle3;
            this.ConsignCorpName.HeaderText = "公司名称";
            this.ConsignCorpName.Name = "ConsignCorpName";
            this.ConsignCorpName.ReadOnly = true;
            this.ConsignCorpName.Width = 180;
            // 
            // Linkman
            // 
            this.Linkman.DataPropertyName = "Linkman";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Linkman.DefaultCellStyle = dataGridViewCellStyle4;
            this.Linkman.HeaderText = "联 系 人";
            this.Linkman.Name = "Linkman";
            this.Linkman.ReadOnly = true;
            this.Linkman.Width = 80;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.PhoneNumber.DefaultCellStyle = dataGridViewCellStyle5;
            this.PhoneNumber.HeaderText = "联系电话";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            this.PhoneNumber.Width = 150;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Address.DefaultCellStyle = dataGridViewCellStyle6;
            this.Address.HeaderText = "地    址";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 200;
            // 
            // Remark
            // 
            this.Remark.DataPropertyName = "Remark";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Remark.DefaultCellStyle = dataGridViewCellStyle7;
            this.Remark.HeaderText = "备    注";
            this.Remark.Name = "Remark";
            this.Remark.ReadOnly = true;
            this.Remark.Width = 200;
            // 
            // FormConsignCorp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 334);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvConsignCorp);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConsignCorp";
            this.ShowInTaskbar = false;
            this.Text = "物流公司";
            this.Load += new System.EventHandler(this.FormConsignCorp_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsignCorp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsConsignCorp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolAdd;
        private System.Windows.Forms.ToolStripButton toolAmend;
        private System.Windows.Forms.ToolStripButton toolDelete;
        private System.Windows.Forms.ToolStripButton toolExit;
        public System.Windows.Forms.BindingSource bsConsignCorp;
        public System.Windows.Forms.DataGridView dgvConsignCorp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsignCorpCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsignCorpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Linkman;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
    }
}