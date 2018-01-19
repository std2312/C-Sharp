using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Daila.NewMehod;
using Daila.NewClass;

namespace Daila
{
    public partial class frmtbProduction : Form
    {
        public frmtbProduction()
        {
            InitializeComponent();
        }
        public frmtbProduction(int Falg)
        {
            InitializeComponent();
            intFalg = Falg;
        }
        public int intFalg;
        private void bntEsce_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            frmtbProPath frmPaht = new frmtbProPath();
            frmPaht.Owner = this;
            frmPaht.ShowDialog() ;
        }
  
        private void bntOK_Click(object sender, EventArgs e)
        {
            if (txtProNo.Text == "")
            {
                MessageBox.Show("商品编号不能为空！","提示");
                txtProNo.Focus();
                return;
            }
            if (txtProName.Text == "")
            {
                MessageBox.Show("商品名称不能为空！", "提示");
                txtProName.Focus();
                return;
            }
            if (txtSellPrice.Text == "")
            {
                MessageBox.Show("商品单价不能为空！", "提示");
                txtSellPrice.Focus();
                return;
            }
            if(txtProPath.Text=="")
                {
                    MessageBox.Show("商品类别不能为空！", "提示");
                    txtProPath.Focus();
                    return;
                }
                if (txtProOperator.Text == "")
                {
                    MessageBox.Show("经办人不能为空！", "提示");
                    txtProOperator.Focus();
                    return;
                
                }
                tbProductionClass tbClass = new tbProductionClass();
                tbClass.strProNo = txtProNo.Text;
                tbClass.strProName = txtProName.Text;
                tbClass.dePrice = Convert.ToDecimal(txtSellPrice.Text);

                tbClass.strProPath = txtProPath.Text;
                tbClass.strProManufacturer = txtProManufacturer.Text;
                if (txtProPOV.Text != "")
                {
                    tbClass.intProPOV = Convert.ToInt32(txtProPOV.Text.Trim());
                }
                tbClass.strProExplain = txtProExplain.Text;
                tbClass.daProRegDate = DateTime.Now;
                tbClass.strProOperator = txtProOperator.Text;
                tbClass.strProMemo = txtProMemo.Text;
                tbClass.ProFalg = "0";
                int intResult = tbmenthod.tbProductionAdd(tbClass);
                if (intResult == 1)
                {
                    MessageBox.Show("添加成功！");
                    if (intFalg == 1)
                    {
                        frmProd prod = (frmProd)this.Owner;
                        tbmenthod.filltProd(prod.treeView1,prod.imageList1);
                        this.Close();
                        
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("添加失败！");
                    this.Close();
                    
                }

        }
        tbProductionMenthod tbmenthod = new tbProductionMenthod();
        private void frmtbProduction_Load(object sender, EventArgs e)
        {
            txtProNo.Text = tbmenthod.tbProductionID();
            txtProName.Focus();

        }

        private void txtProPOV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("只能输入数字", "有情提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
            }

        }
    }
}