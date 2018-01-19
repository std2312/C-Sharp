using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Daila.NewClass;
using System.Data.OleDb;
using System.Data;
using  Daila.NewMehod;
namespace Daila
{
    public partial class frmtbProPath : Form
    {
        public frmtbProPath()
        {
            InitializeComponent();
        }
        public frmtbProPath(int intFalg1)
        {
            InitializeComponent();
            intFalg = intFalg1;
        }
        //控件操作状态，1表示，添加产品分类信息，0表示选择产品分类信息
        public static int intFalg;
        //实例
        tbProPathMenthod tbMenthod = new tbProPathMenthod();
        private void bntNew_Click(object sender, EventArgs e)
        {
            //实例添加产品类别窗体对象
            frmtbProPathNew pathNew = new frmtbProPathNew(); 
            //设置所属窗体
            pathNew.Owner = this;
            //模式显示窗体
            pathNew.ShowDialog();

       
        }


        private void frmtbProPath_Load(object sender, EventArgs e)
        {
            //调用方法将产品类别信息添加至treeView控件中
            tbMenthod.filltbProPath(treeView1,imageList1);
            //添加商品信息将，bntOK按钮隐藏
            if (intFalg == 1)
            {
                bntOK.Visible = false;
                this.Text = "产品分类";
            }
            else
            {
                this.Text = "选择产品类别";
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            intFalg = 0;
            this.Close();
        }

        private void bntOK_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.Text != "")
            {
                frmtbProduction fmtb = (frmtbProduction)this.Owner;
                fmtb.txtProPath.Text = treeView1.SelectedNode.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("请选择产品分类！","提示");
            }
            
        }

        private void frmtbProPath_FormClosed(object sender, FormClosedEventArgs e)
        {
            intFalg = 0;
        }


    }
}