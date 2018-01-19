namespace SALE.UI.SaleManage
{
    partial class FormBarterBaseCDRecord
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.contextDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvBarterBaseCDRecord = new System.Windows.Forms.DataGridView();
            this.bsBarterBaseCDRecord = new System.Windows.Forms.BindingSource(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CDNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BarterBillNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarterBaseCDRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBarterBaseCDRecord)).BeginInit();
            this.SuspendLayout();
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
            // dgvBarterBaseCDRecord
            // 
            this.dgvBarterBaseCDRecord.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBarterBaseCDRecord.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBarterBaseCDRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBarterBaseCDRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CDNo,
            this.Remark,
            this.BarterBillNo,
            this.Id});
            this.dgvBarterBaseCDRecord.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvBarterBaseCDRecord.Location = new System.Drawing.Point(10, 18);
            this.dgvBarterBaseCDRecord.Name = "dgvBarterBaseCDRecord";
            this.dgvBarterBaseCDRecord.RowHeadersWidth = 30;
            this.dgvBarterBaseCDRecord.RowTemplate.Height = 23;
            this.dgvBarterBaseCDRecord.Size = new System.Drawing.Size(385, 178);
            this.dgvBarterBaseCDRecord.TabIndex = 119;
            // 
            // bsBarterBaseCDRecord
            // 
            this.bsBarterBaseCDRecord.AllowNew = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(305, 209);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 122;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(198, 209);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 121;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 198);
            this.groupBox1.TabIndex = 120;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "光盘号管理";
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
            // BarterBillNo
            // 
            this.BarterBillNo.DataPropertyName = "BarterBillNo";
            this.BarterBillNo.HeaderText = "调货单号";
            this.BarterBillNo.Name = "BarterBillNo";
            this.BarterBillNo.Visible = false;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "自增  Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // FormBarterBaseCDRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 236);
            this.Controls.Add(this.dgvBarterBaseCDRecord);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBarterBaseCDRecord";
            this.ShowInTaskbar = false;
            this.Text = "调货原光盘管理";
            this.Load += new System.EventHandler(this.FormBarterBaseCDRecord_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarterBaseCDRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBarterBaseCDRecord)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem contextAdd;
        private System.Windows.Forms.ToolStripMenuItem contextDelete;
        private System.Windows.Forms.DataGridView dgvBarterBaseCDRecord;
        private System.Windows.Forms.BindingSource bsBarterBaseCDRecord;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
        private System.Windows.Forms.DataGridViewTextBoxColumn BarterBillNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}