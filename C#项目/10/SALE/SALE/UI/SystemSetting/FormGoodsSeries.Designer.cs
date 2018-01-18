namespace SALE.UI.SystemSetting
{
    partial class FormGoodsSeries
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGoodsSeries));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolAdd = new System.Windows.Forms.ToolStripButton();
            this.toolAmend = new System.Windows.Forms.ToolStripButton();
            this.toolDelete = new System.Windows.Forms.ToolStripButton();
            this.toolExit = new System.Windows.Forms.ToolStripButton();
            this.dgvGoodsSeries = new System.Windows.Forms.DataGridView();
            this.GoodsSeriesCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodsSeriesName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoodsSeries)).BeginInit();
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
            this.toolStrip1.TabIndex = 1;
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
            // dgvGoodsSeries
            // 
            this.dgvGoodsSeries.AllowUserToAddRows = false;
            this.dgvGoodsSeries.AllowUserToResizeColumns = false;
            this.dgvGoodsSeries.AllowUserToResizeRows = false;
            this.dgvGoodsSeries.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGoodsSeries.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGoodsSeries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvGoodsSeries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GoodsSeriesCode,
            this.GoodsSeriesName,
            this.UnitPrice});
            this.dgvGoodsSeries.Location = new System.Drawing.Point(0, 26);
            this.dgvGoodsSeries.Name = "dgvGoodsSeries";
            this.dgvGoodsSeries.RowHeadersVisible = false;
            this.dgvGoodsSeries.RowTemplate.Height = 23;
            this.dgvGoodsSeries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGoodsSeries.Size = new System.Drawing.Size(451, 308);
            this.dgvGoodsSeries.TabIndex = 2;
            this.dgvGoodsSeries.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGoodsSeries_CellDoubleClick);
            // 
            // GoodsSeriesCode
            // 
            this.GoodsSeriesCode.DataPropertyName = "GoodsSeriesCode";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.GoodsSeriesCode.DefaultCellStyle = dataGridViewCellStyle2;
            this.GoodsSeriesCode.HeaderText = "系列代码";
            this.GoodsSeriesCode.Name = "GoodsSeriesCode";
            this.GoodsSeriesCode.ReadOnly = true;
            this.GoodsSeriesCode.Width = 108;
            // 
            // GoodsSeriesName
            // 
            this.GoodsSeriesName.DataPropertyName = "GoodsSeriesName";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.GoodsSeriesName.DefaultCellStyle = dataGridViewCellStyle3;
            this.GoodsSeriesName.HeaderText = "系列名称";
            this.GoodsSeriesName.Name = "GoodsSeriesName";
            this.GoodsSeriesName.ReadOnly = true;
            this.GoodsSeriesName.Width = 210;
            // 
            // UnitPrice
            // 
            this.UnitPrice.DataPropertyName = "UnitPrice";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.UnitPrice.DefaultCellStyle = dataGridViewCellStyle4;
            this.UnitPrice.HeaderText = "单价";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            this.UnitPrice.Width = 128;
            // 
            // FormGoodsSeries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 334);
            this.Controls.Add(this.dgvGoodsSeries);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGoodsSeries";
            this.ShowInTaskbar = false;
            this.Text = "产品系列";
            this.Load += new System.EventHandler(this.FormGoodsSeries_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoodsSeries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolAdd;
        private System.Windows.Forms.ToolStripButton toolAmend;
        private System.Windows.Forms.ToolStripButton toolDelete;
        private System.Windows.Forms.ToolStripButton toolExit;
        public System.Windows.Forms.DataGridView dgvGoodsSeries;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsSeriesCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsSeriesName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
    }
}