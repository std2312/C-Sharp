namespace SALE.UI.SaleManage
{
    partial class FormSaleCDRecord
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
            this.dgvSaleCDRecord = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.contextDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.bsSaleCDRecord = new System.Windows.Forms.BindingSource(this.components);
            this.CDNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleConsignBillId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleCDRecord)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsSaleCDRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSaleCDRecord
            // 
            this.dgvSaleCDRecord.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSaleCDRecord.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSaleCDRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaleCDRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CDNo,
            this.Remark,
            this.SaleConsignBillId,
            this.Id});
            this.dgvSaleCDRecord.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvSaleCDRecord.Location = new System.Drawing.Point(8, 15);
            this.dgvSaleCDRecord.Name = "dgvSaleCDRecord";
            this.dgvSaleCDRecord.RowHeadersWidth = 30;
            this.dgvSaleCDRecord.RowTemplate.Height = 23;
            this.dgvSaleCDRecord.Size = new System.Drawing.Size(385, 178);
            this.dgvSaleCDRecord.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextAdd,
            this.contextDelete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(95, 48);
            // 
            // contextAdd
            // 
            this.contextAdd.Name = "contextAdd";
            this.contextAdd.Size = new System.Drawing.Size(94, 22);
            this.contextAdd.Text = "添加";
            this.contextAdd.Click += new System.EventHandler(this.contextAdd_Click);
            // 
            // contextDelete
            // 
            this.contextDelete.Name = "contextDelete";
            this.contextDelete.Size = new System.Drawing.Size(94, 22);
            this.contextDelete.Text = "删除";
            this.contextDelete.Click += new System.EventHandler(this.contextDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 198);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "光盘号管理";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(196, 206);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 105;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(303, 206);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 106;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // bsSaleCDRecord
            // 
            this.bsSaleCDRecord.AllowNew = false;
            // 
            // CDNo
            // 
            this.CDNo.DataPropertyName = "CDNo";
            this.CDNo.HeaderText = "光 盘 号";
            this.CDNo.MaxInputLength = 10;
            this.CDNo.Name = "CDNo";
            this.CDNo.Width = 150;
            // 
            // Remark
            // 
            this.Remark.DataPropertyName = "Remark";
            this.Remark.HeaderText = "备    注";
            this.Remark.Name = "Remark";
            this.Remark.Width = 200;
            // 
            // SaleConsignBillId
            // 
            this.SaleConsignBillId.DataPropertyName = "SaleConsignBillId";
            this.SaleConsignBillId.HeaderText = "发货单自增Id";
            this.SaleConsignBillId.Name = "SaleConsignBillId";
            this.SaleConsignBillId.Visible = false;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "自增  Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // FormSaleCDRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 236);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvSaleCDRecord);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSaleCDRecord";
            this.ShowInTaskbar = false;
            this.Text = "发货单光盘管理";
            this.Load += new System.EventHandler(this.FormSaleCDRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleCDRecord)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsSaleCDRecord)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSaleCDRecord;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem contextAdd;
        private System.Windows.Forms.ToolStripMenuItem contextDelete;
        private System.Windows.Forms.BindingSource bsSaleCDRecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleConsignBillId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}