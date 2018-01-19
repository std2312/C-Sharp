namespace Daila
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.munStMain = new System.Windows.Forms.MenuStrip();
            this.tlsKu = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsKuMenuItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsKuMenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsKuMenuItemUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsKuMenuItemSecar = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsEm = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsEmMenuItenAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsEmMenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsEmMenuItemUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsEmMenuItemSecar = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsCp = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsCpMenuItemInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsCpMenuItemKind = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsDa = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsDaMenuItemSecar = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsDaMenuItemLaida = new System.Windows.Forms.ToolStripMenuItem();
            this.退出EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lvQs = new System.Windows.Forms.ListView();
            this.bntEm = new System.Windows.Forms.Button();
            this.bntQt = new System.Windows.Forms.Button();
            this.bntKu = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChnlState_LV = new System.Windows.Forms.ListView();
            this.ChnlNo = new System.Windows.Forms.ColumnHeader();
            this.ChnlType = new System.Windows.Forms.ColumnHeader();
            this.ChnlState = new System.Windows.Forms.ColumnHeader();
            this.CallerID = new System.Windows.Forms.ColumnHeader();
            this.DTMF = new System.Windows.Forms.ColumnHeader();
            this.ChnlMsg = new System.Windows.Forms.ColumnHeader();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.munStMain.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // munStMain
            // 
            this.munStMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsKu,
            this.tlsEm,
            this.tlsCp,
            this.tlsDa,
            this.退出EToolStripMenuItem});
            this.munStMain.Location = new System.Drawing.Point(0, 0);
            this.munStMain.Name = "munStMain";
            this.munStMain.Size = new System.Drawing.Size(698, 24);
            this.munStMain.TabIndex = 1;
            this.munStMain.Text = "menuStrip1";
            // 
            // tlsKu
            // 
            this.tlsKu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsKuMenuItemAdd,
            this.tlsKuMenuItemDelete,
            this.tlsKuMenuItemUpdate,
            this.tlsKuMenuItemSecar});
            this.tlsKu.Name = "tlsKu";
            this.tlsKu.Size = new System.Drawing.Size(83, 20);
            this.tlsKu.Text = "客户管理(&K)";
            // 
            // tlsKuMenuItemAdd
            // 
            this.tlsKuMenuItemAdd.Name = "tlsKuMenuItemAdd";
            this.tlsKuMenuItemAdd.Size = new System.Drawing.Size(166, 22);
            this.tlsKuMenuItemAdd.Text = "添加客户信息(&D)";
            this.tlsKuMenuItemAdd.Click += new System.EventHandler(this.tlsKuMenuItemAdd_Click);
            // 
            // tlsKuMenuItemDelete
            // 
            this.tlsKuMenuItemDelete.Name = "tlsKuMenuItemDelete";
            this.tlsKuMenuItemDelete.Size = new System.Drawing.Size(166, 22);
            this.tlsKuMenuItemDelete.Text = "删除客户信息(&R)";
            this.tlsKuMenuItemDelete.Click += new System.EventHandler(this.tlsKuMenuItemDelete_Click);
            // 
            // tlsKuMenuItemUpdate
            // 
            this.tlsKuMenuItemUpdate.Name = "tlsKuMenuItemUpdate";
            this.tlsKuMenuItemUpdate.Size = new System.Drawing.Size(166, 22);
            this.tlsKuMenuItemUpdate.Text = "修改客户信息(&U)";
            this.tlsKuMenuItemUpdate.Click += new System.EventHandler(this.tlsKuMenuItemUpdate_Click);
            // 
            // tlsKuMenuItemSecar
            // 
            this.tlsKuMenuItemSecar.Name = "tlsKuMenuItemSecar";
            this.tlsKuMenuItemSecar.Size = new System.Drawing.Size(166, 22);
            this.tlsKuMenuItemSecar.Text = "查询客户信息(&T）";
            this.tlsKuMenuItemSecar.Click += new System.EventHandler(this.tlsKuMenuItemSecar_Click);
            // 
            // tlsEm
            // 
            this.tlsEm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsEmMenuItenAdd,
            this.tlsEmMenuItemDelete,
            this.tlsEmMenuItemUpdate,
            this.tlsEmMenuItemSecar});
            this.tlsEm.Name = "tlsEm";
            this.tlsEm.Size = new System.Drawing.Size(83, 20);
            this.tlsEm.Text = "员工管理(&Y)";
            // 
            // tlsEmMenuItenAdd
            // 
            this.tlsEmMenuItenAdd.Name = "tlsEmMenuItenAdd";
            this.tlsEmMenuItenAdd.Size = new System.Drawing.Size(160, 22);
            this.tlsEmMenuItenAdd.Text = "添加员工信息(&D)";
            this.tlsEmMenuItenAdd.Click += new System.EventHandler(this.tlsEmMenuItenAdd_Click);
            // 
            // tlsEmMenuItemDelete
            // 
            this.tlsEmMenuItemDelete.Name = "tlsEmMenuItemDelete";
            this.tlsEmMenuItemDelete.Size = new System.Drawing.Size(160, 22);
            this.tlsEmMenuItemDelete.Text = "删除员工信息(&F)";
            this.tlsEmMenuItemDelete.Click += new System.EventHandler(this.tlsEmMenuItemDelete_Click);
            // 
            // tlsEmMenuItemUpdate
            // 
            this.tlsEmMenuItemUpdate.Name = "tlsEmMenuItemUpdate";
            this.tlsEmMenuItemUpdate.Size = new System.Drawing.Size(160, 22);
            this.tlsEmMenuItemUpdate.Text = "查询员工信息(&T)";
            this.tlsEmMenuItemUpdate.Click += new System.EventHandler(this.tlsEmMenuItemUpdate_Click);
            // 
            // tlsEmMenuItemSecar
            // 
            this.tlsEmMenuItemSecar.Name = "tlsEmMenuItemSecar";
            this.tlsEmMenuItemSecar.Size = new System.Drawing.Size(160, 22);
            this.tlsEmMenuItemSecar.Text = "修改员工信息(&H)";
            this.tlsEmMenuItemSecar.Click += new System.EventHandler(this.tlsEmMenuItemSecar_Click);
            // 
            // tlsCp
            // 
            this.tlsCp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsCpMenuItemInfo,
            this.tlsCpMenuItemKind});
            this.tlsCp.Name = "tlsCp";
            this.tlsCp.Size = new System.Drawing.Size(83, 20);
            this.tlsCp.Text = "产品信息(&C)";
            // 
            // tlsCpMenuItemInfo
            // 
            this.tlsCpMenuItemInfo.Name = "tlsCpMenuItemInfo";
            this.tlsCpMenuItemInfo.Size = new System.Drawing.Size(136, 22);
            this.tlsCpMenuItemInfo.Text = "产品分类(&L)";
            this.tlsCpMenuItemInfo.Click += new System.EventHandler(this.tlsCpMenuItemInfo_Click);
            // 
            // tlsCpMenuItemKind
            // 
            this.tlsCpMenuItemKind.Name = "tlsCpMenuItemKind";
            this.tlsCpMenuItemKind.Size = new System.Drawing.Size(136, 22);
            this.tlsCpMenuItemKind.Text = "产品信息(&X)";
            this.tlsCpMenuItemKind.Click += new System.EventHandler(this.tlsCpMenuItemKind_Click);
            // 
            // tlsDa
            // 
            this.tlsDa.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsDaMenuItemSecar,
            this.tlsDaMenuItemLaida});
            this.tlsDa.Name = "tlsDa";
            this.tlsDa.Size = new System.Drawing.Size(83, 20);
            this.tlsDa.Text = "通话管理(&T)";
            // 
            // tlsDaMenuItemSecar
            // 
            this.tlsDaMenuItemSecar.Name = "tlsDaMenuItemSecar";
            this.tlsDaMenuItemSecar.Size = new System.Drawing.Size(136, 22);
            this.tlsDaMenuItemSecar.Text = "电话查询(&C)";
            this.tlsDaMenuItemSecar.Click += new System.EventHandler(this.tlsDaMenuItemSecar_Click);
            // 
            // tlsDaMenuItemLaida
            // 
            this.tlsDaMenuItemLaida.Name = "tlsDaMenuItemLaida";
            this.tlsDaMenuItemLaida.Size = new System.Drawing.Size(136, 22);
            this.tlsDaMenuItemLaida.Text = "来电信息(&D)";
            this.tlsDaMenuItemLaida.Click += new System.EventHandler(this.tlsDaMenuItemLaida_Click);
            // 
            // 退出EToolStripMenuItem
            // 
            this.退出EToolStripMenuItem.Name = "退出EToolStripMenuItem";
            this.退出EToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.退出EToolStripMenuItem.Text = "退出(&E)";
            this.退出EToolStripMenuItem.Click += new System.EventHandler(this.退出EToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "查询客户信息.bmp");
            this.imageList1.Images.SetKeyName(1, "删除客户信息.bmp");
            this.imageList1.Images.SetKeyName(2, "添加客户信息.bmp");
            this.imageList1.Images.SetKeyName(3, "修改客户信息.bmp");
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lvQs);
            this.splitContainer1.Panel1.Controls.Add(this.bntEm);
            this.splitContainer1.Panel1.Controls.Add(this.bntQt);
            this.splitContainer1.Panel1.Controls.Add(this.bntKu);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel2.Controls.Add(this.ChnlState_LV);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(698, 419);
            this.splitContainer1.SplitterDistance = 98;
            this.splitContainer1.TabIndex = 2;
            // 
            // lvQs
            // 
            this.lvQs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvQs.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lvQs.Location = new System.Drawing.Point(3, 25);
            this.lvQs.Name = "lvQs";
            this.lvQs.Size = new System.Drawing.Size(92, 342);
            this.lvQs.TabIndex = 4;
            this.lvQs.UseCompatibleStateImageBehavior = false;
            this.lvQs.Click += new System.EventHandler(this.listView1_Click);
            // 
            // bntEm
            // 
            this.bntEm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bntEm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntEm.Location = new System.Drawing.Point(0, 373);
            this.bntEm.Name = "bntEm";
            this.bntEm.Size = new System.Drawing.Size(98, 23);
            this.bntEm.TabIndex = 3;
            this.bntEm.Text = "员工管理";
            this.bntEm.UseVisualStyleBackColor = true;
            this.bntEm.Click += new System.EventHandler(this.bntEm_Click);
            // 
            // bntQt
            // 
            this.bntQt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bntQt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntQt.Location = new System.Drawing.Point(0, 396);
            this.bntQt.Name = "bntQt";
            this.bntQt.Size = new System.Drawing.Size(98, 23);
            this.bntQt.TabIndex = 2;
            this.bntQt.Text = "其他管理";
            this.bntQt.UseVisualStyleBackColor = true;
            this.bntQt.Click += new System.EventHandler(this.bntQt_Click);
            // 
            // bntKu
            // 
            this.bntKu.Dock = System.Windows.Forms.DockStyle.Top;
            this.bntKu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntKu.Location = new System.Drawing.Point(0, 0);
            this.bntKu.Name = "bntKu";
            this.bntKu.Size = new System.Drawing.Size(98, 27);
            this.bntKu.TabIndex = 1;
            this.bntKu.Text = "客户管理";
            this.bntKu.UseVisualStyleBackColor = true;
            this.bntKu.Click += new System.EventHandler(this.bntKu_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(26, 206);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(534, 201);
            this.dataGridView1.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 200F;
            this.Column1.HeaderText = "客户编号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "公司名称";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "客户姓名";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "公司电话";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "购买产品";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // ChnlState_LV
            // 
            this.ChnlState_LV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ChnlNo,
            this.ChnlType,
            this.ChnlState,
            this.CallerID,
            this.DTMF,
            this.ChnlMsg});
            this.ChnlState_LV.GridLines = true;
            this.ChnlState_LV.Location = new System.Drawing.Point(26, 20);
            this.ChnlState_LV.Name = "ChnlState_LV";
            this.ChnlState_LV.Size = new System.Drawing.Size(534, 172);
            this.ChnlState_LV.TabIndex = 4;
            this.ChnlState_LV.UseCompatibleStateImageBehavior = false;
            this.ChnlState_LV.View = System.Windows.Forms.View.Details;
            // 
            // ChnlNo
            // 
            this.ChnlNo.Text = "通道号";
            // 
            // ChnlType
            // 
            this.ChnlType.Text = "线路类型";
            this.ChnlType.Width = 73;
            // 
            // ChnlState
            // 
            this.ChnlState.Text = "线路状态";
            this.ChnlState.Width = 80;
            // 
            // CallerID
            // 
            this.CallerID.Text = "来电号码";
            this.CallerID.Width = 90;
            // 
            // DTMF
            // 
            this.DTMF.Text = "按键号";
            this.DTMF.Width = 100;
            // 
            // ChnlMsg
            // 
            this.ChnlMsg.Text = "提示信息";
            this.ChnlMsg.Width = 250;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 443);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.munStMain);
            this.MainMenuStrip = this.munStMain;
            this.Name = "frmMain";
            this.Text = "企业电话客服系统";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.munStMain.ResumeLayout(false);
            this.munStMain.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip munStMain;
        private System.Windows.Forms.ToolStripMenuItem tlsKu;
        private System.Windows.Forms.ToolStripMenuItem tlsKuMenuItemAdd;
        private System.Windows.Forms.ToolStripMenuItem tlsKuMenuItemDelete;
        private System.Windows.Forms.ToolStripMenuItem tlsKuMenuItemUpdate;
        private System.Windows.Forms.ToolStripMenuItem tlsKuMenuItemSecar;
        private System.Windows.Forms.ToolStripMenuItem tlsEm;
        private System.Windows.Forms.ToolStripMenuItem tlsEmMenuItenAdd;
        private System.Windows.Forms.ToolStripMenuItem tlsEmMenuItemDelete;
        private System.Windows.Forms.ToolStripMenuItem tlsEmMenuItemUpdate;
        private System.Windows.Forms.ToolStripMenuItem tlsEmMenuItemSecar;
        private System.Windows.Forms.ToolStripMenuItem tlsCp;
        private System.Windows.Forms.ToolStripMenuItem tlsCpMenuItemInfo;
        private System.Windows.Forms.ToolStripMenuItem tlsCpMenuItemKind;
        private System.Windows.Forms.ToolStripMenuItem tlsDa;
        private System.Windows.Forms.ToolStripMenuItem tlsDaMenuItemSecar;
        private System.Windows.Forms.ToolStripMenuItem tlsDaMenuItemLaida;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView lvQs;
        private System.Windows.Forms.Button bntEm;
        private System.Windows.Forms.Button bntQt;
        private System.Windows.Forms.Button bntKu;
        private System.Windows.Forms.ListView ChnlState_LV;
        private System.Windows.Forms.ColumnHeader ChnlNo;
        private System.Windows.Forms.ColumnHeader ChnlType;
        private System.Windows.Forms.ColumnHeader ChnlState;
        private System.Windows.Forms.ColumnHeader CallerID;
        private System.Windows.Forms.ColumnHeader DTMF;
        private System.Windows.Forms.ColumnHeader ChnlMsg;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem 退出EToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;

    }
}