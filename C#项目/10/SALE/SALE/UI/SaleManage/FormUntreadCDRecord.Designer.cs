namespace SALE.UI.SaleManage
{
    partial class FormUntreadCDRecord
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
            this.btnExit = new System.Windows.Forms.Button();
            this.contextDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contextAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvUntreadCDRecord = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bsUntreadCDRecord = new System.Windows.Forms.BindingSource(this.components);
            this.CDNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UntreadBillNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUntreadCDRecord)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsUntreadCDRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(305, 209);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 110;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // contextDelete
            // 
            this.contextDelete.Name = "contextDelete";
            this.contextDelete.Size = new System.Drawing.Size(94, 22);
            this.contextDelete.Text = "删除";
            this.contextDelete.Click += new System.EventHandler(this.contextDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(198, 209);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 109;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 198);
            this.groupBox1.TabIndex = 108;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "光盘号管理";
            // 
            // contextAdd
            // 
            this.contextAdd.Name = "contextAdd";
            this.contextAdd.Size = new System.Drawing.Size(94, 22);
            this.contextAdd.Text = "添加";
            this.contextAdd.Click += new System.EventHandler(this.contextAdd_Click);
            // 
            // dgvUntreadCDRecord
            // 
            this.dgvUntreadCDRecord.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUntreadCDRecord.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUntreadCDRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUntreadCDRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CDNo,
            this.Remark,
            this.UntreadBillNo,
            this.Id});
            this.dgvUntreadCDRecord.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvUntreadCDRecord.Location = new System.Drawing.Point(10, 18);
            this.dgvUntreadCDRecord.Name = "dgvUntreadCDRecord";
            this.dgvUntreadCDRecord.RowHeadersWidth = 30;
            this.dgvUntreadCDRecord.RowTemplate.Height = 23;
            this.dgvUntreadCDRecord.Size = new System.Drawing.Size(385, 178);
            this.dgvUntreadCDRecord.TabIndex = 107;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextAdd,
            this.contextDelete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(95, 48);
            // 
            // bsUntreadCDRecord
            // 
            this.bsUntreadCDRecord.AllowNew = false;
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
            // UntreadBillNo
            // 
            this.UntreadBillNo.DataPropertyName = "UntreadBillNo";
            this.UntreadBillNo.HeaderText = "退货单号";
            this.UntreadBillNo.Name = "UntreadBillNo";
            this.UntreadBillNo.Visible = false;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "自增  Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // FormUntreadCDRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 236);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvUntreadCDRecord);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUntreadCDRecord";
            this.ShowInTaskbar = false;
            this.Text = "退货单光盘管理";
            this.Load += new System.EventHandler(this.FormUntreadCDRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUntreadCDRecord)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsUntreadCDRecord)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolStripMenuItem contextDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem contextAdd;
        private System.Windows.Forms.DataGridView dgvUntreadCDRecord;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.BindingSource bsUntreadCDRecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
        private System.Windows.Forms.DataGridViewTextBoxColumn UntreadBillNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}