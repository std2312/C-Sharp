namespace Daila
{
    partial class frmProd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProd));
            this.button3 = new System.Windows.Forms.Button();
            this.bntOK = new System.Windows.Forms.Button();
            this.bntNew = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(131, 238);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "取消";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // bntOK
            // 
            this.bntOK.Location = new System.Drawing.Point(73, 238);
            this.bntOK.Name = "bntOK";
            this.bntOK.Size = new System.Drawing.Size(52, 23);
            this.bntOK.TabIndex = 6;
            this.bntOK.Text = "确定";
            this.bntOK.UseVisualStyleBackColor = true;
            this.bntOK.Click += new System.EventHandler(this.bntOK_Click);
            // 
            // bntNew
            // 
            this.bntNew.Location = new System.Drawing.Point(12, 238);
            this.bntNew.Name = "bntNew";
            this.bntNew.Size = new System.Drawing.Size(55, 23);
            this.bntNew.TabIndex = 5;
            this.bntNew.Text = "新建";
            this.bntNew.UseVisualStyleBackColor = true;
            this.bntNew.Click += new System.EventHandler(this.bntNew_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(183, 221);
            this.treeView1.TabIndex = 4;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1.bmp");
            this.imageList1.Images.SetKeyName(1, "2.bmp");
            // 
            // frmProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 266);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bntOK);
            this.Controls.Add(this.bntNew);
            this.Controls.Add(this.treeView1);
            this.Name = "frmProd";
            this.Text = "选择产品";
            this.Load += new System.EventHandler(this.frmProd_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button bntOK;
        private System.Windows.Forms.Button bntNew;
        public System.Windows.Forms.TreeView treeView1;
        public System.Windows.Forms.ImageList imageList1;
    }
}