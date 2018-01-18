namespace SMS
{
    partial class frmCydy
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("常用办公语");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("订货常用语");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("发货语");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("客户联系语");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("礼貌语");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("商业语");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("祝福语");
            this.tvDy = new System.Windows.Forms.TreeView();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.pbDelete = new System.Windows.Forms.PictureBox();
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            this.SuspendLayout();
            // 
            // tvDy
            // 
            this.tvDy.Location = new System.Drawing.Point(4, 11);
            this.tvDy.Name = "tvDy";
            treeNode1.Checked = true;
            treeNode1.Name = "tv2";
            treeNode1.Text = "常用办公语";
            treeNode2.Name = "tv3";
            treeNode2.Text = "订货常用语";
            treeNode3.Name = "tv4";
            treeNode3.Text = "发货语";
            treeNode4.Name = "tv5";
            treeNode4.Text = "客户联系语";
            treeNode5.Name = "tv6";
            treeNode5.Text = "礼貌语";
            treeNode6.Name = "tv7";
            treeNode6.Text = "商业语";
            treeNode7.Name = "tv8";
            treeNode7.Text = "祝福语";
            this.tvDy.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7});
            this.tvDy.Size = new System.Drawing.Size(137, 304);
            this.tvDy.TabIndex = 2;
            this.tvDy.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvDy_AfterSelect);
            // 
            // pbClose
            // 
            this.pbClose.Image = global::SMS.Properties.Resources.an_2;
            this.pbClose.Location = new System.Drawing.Point(341, 290);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(70, 33);
            this.pbClose.TabIndex = 7;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // pbDelete
            // 
            this.pbDelete.Image = global::SMS.Properties.Resources.an_1;
            this.pbDelete.Location = new System.Drawing.Point(267, 290);
            this.pbDelete.Name = "pbDelete";
            this.pbDelete.Size = new System.Drawing.Size(67, 33);
            this.pbDelete.TabIndex = 6;
            this.pbDelete.TabStop = false;
            this.pbDelete.Click += new System.EventHandler(this.pbDelete_Click);
            // 
            // dgvShow
            // 
            this.dgvShow.AllowUserToAddRows = false;
            this.dgvShow.AllowUserToResizeRows = false;
            this.dgvShow.BackgroundColor = System.Drawing.Color.White;
            this.dgvShow.ColumnHeadersVisible = false;
            this.dgvShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvShow.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvShow.Location = new System.Drawing.Point(156, 11);
            this.dgvShow.MultiSelect = false;
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.ReadOnly = true;
            this.dgvShow.RowHeadersVisible = false;
            this.dgvShow.RowTemplate.Height = 23;
            this.dgvShow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShow.Size = new System.Drawing.Size(415, 275);
            this.dgvShow.TabIndex = 3;
            this.dgvShow.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShow_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "note";
            this.Column2.HeaderText = "";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 423;
            // 
            // frmCydy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(225)))), ((int)(((byte)(204)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(583, 321);
            this.Controls.Add(this.pbClose);
            this.Controls.Add(this.pbDelete);
            this.Controls.Add(this.dgvShow);
            this.Controls.Add(this.tvDy);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCydy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "常用短语";
            this.Activated += new System.EventHandler(this.frmCydy_Activated);
            this.Load += new System.EventHandler(this.frmCydy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvDy;
        private System.Windows.Forms.PictureBox pbDelete;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.DataGridView dgvShow;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}