using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Data.OleDb;
using Daila.NewMehod;
using Daila.NewClass;
namespace Daila
{
    public partial class frmCustomerUpdate : Form
    {
        public frmCustomerUpdate()
        {
            InitializeComponent();
        }
        public frmCustomerUpdate(int falg)
        {
            InitializeComponent();
            intFlag = falg;
        }
        public static int intFlag;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        tbCustomerClass tbClass = new tbCustomerClass();
        tbCustomerMethod tbMenthod = new tbCustomerMethod();
        tbDistionMenthod tbDistion = new tbDistionMenthod();//实例字典表类
        private void frmCustomerUpdate_Load(object sender, EventArgs e)
        { //绑定ＴｒｅｅＶｉｅｗ控件
            tbClass.khID = "";
            tbMenthod.filltbProPath(treeView1, imageList1, tbMenthod.tbCustomerSecarf(tbClass, "LikekhID"));

           
            tbDistion.filltb_Importance(cmbkhType);//客户重要程度
            tbDistion.filltb_Industry(cmbkhHandye);//行业
            tbDistion.filltb_Production(cmbkuChangPi);//产品名称
            tbDistion.filltb_Type(cmbkhState);//客户状态

            if (intFlag == 1)
            {
                this.Text = "添加客户信息";
                txtId.Text = tbMenthod.tbCustomerID();//获得客户ID
                bntDelete.Enabled = false;
                bntEsce.Enabled = true;
                bntOK.Enabled = true;
                bntUpdate.Enabled = false;

            }
            if (intFlag == 2)
            {
                this.Text = "修改客户信息";
                bntDelete.Enabled = false;
                bntEsce.Enabled = true;
                bntOK.Enabled =false;
                bntUpdate.Enabled = true;
    
            }
            if (intFlag == 3)
            {
                this.Text = "删除客户信息";

                bntDelete.Enabled = true;
                bntEsce.Enabled = true;
                bntOK.Enabled = false;
                bntUpdate.Enabled = false;
            }
            if (intFlag == 4)
            {
                this.Text = "查询客户信息";
                bntDelete.Enabled = false;
                bntEsce.Enabled = true;
                bntOK.Enabled = false;
                bntUpdate.Enabled = false;
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode.Text != "")
            {
                if (intFlag != 1)
                {
                    tbClass.khID = treeView1.SelectedNode.Text;
                    CusotumsUpdate(tbMenthod.tbCustomerSecarf(tbClass, "khID"));
                }
            }
            
        }
        //修改资料
        public void CusotumsUpdate(OleDbDataReader dr)
        {
            OleDbDataReader older = dr;
            older.Read();
            if(older.HasRows)
            {
               
                txtId.Text = older[0].ToString();
                txtId.Enabled = false;
                txtName.Text = older[1].ToString();
                txtkhPi.Text = older[2].ToString();
                cmbkhType.SelectedIndex = Convert.ToInt32(older[3].ToString());
                string str = older[4].ToString();
                cmbkhHandye.SelectedIndex = Convert.ToInt32(older[4].ToString());
                cmbkhState.SelectedIndex = Convert.ToInt32(older[5].ToString());
                txtkhTel.Text = older[6].ToString();
                txtOfficeTel.Text = older[7].ToString();
                txtEmail.Text = older[8].ToString();
                txtkuAddress.Text = older[9].ToString();
         
                    cmbkuChangPi.Text = older[10].ToString();
                txtkuSum.Text = older[11].ToString();
                txtkuEmploy.Text = older[13].ToString();
            }
        }
        //添加
        private void tntOK_Click(object sender, EventArgs e)
        {
            Fillclass();//调用方法
            int intResult = tbMenthod.tbCustomerAdd(tbClass);//调用方法添加客户信息
            if (intResult == 1)
            {
                MessageBox.Show("添加成功！", "提示");
                tbClass.khID = "";
                tbMenthod.filltbProPath(treeView1, imageList1, tbMenthod.tbCustomerSecarf(tbClass, "LikekhID"));
                ClearFill();
                intFlag = 2;//修改标记
   
            }
            else
            {
                MessageBox.Show("添加失败！", "提示");
                ClearFill();
            }

        }

        private void tntEsce_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmProd prod = new frmProd(2);
            prod.Owner = this;
            prod.ShowDialog();
        }
        //修改
        private void bntUpdate_Click(object sender, EventArgs e)
        {
            if (Fillclass()== 1)//调用方法
            {
                int intResult = tbMenthod.tbCustomerUpdate(tbClass);//调用方法添加客户信息
                if (intResult == 1)
                {
                    MessageBox.Show("修改成功！", "提示");
                    tbClass.khID = "";
                    tbMenthod.filltbProPath(treeView1, imageList1, tbMenthod.tbCustomerSecarf(tbClass, "LikekhID"));
                    ClearFill(); 
                    intFlag = 2;

                }
                else
                {
                    MessageBox.Show("修改失败！", "提示");
                    ClearFill();
                    intFlag = 2;

                }
            }
        }
        //公共方法
        public int Fillclass()
        {
            int intFalg=0;
            if (txtName.Text == "")
            {
                MessageBox.Show("公司名称：不能为空！", "提示");

                return intFalg;
            }
            if (txtkhPi.Text == "")
            {
                MessageBox.Show("客户姓名：不能为空！", "提示");
                return intFalg;
            }
            if (txtkuAddress.Text == "")
            {
                MessageBox.Show("公司地址：不能为空！", "提示");
                return intFalg;
            }
            if (txtkhTel.Text == "")
            {
                MessageBox.Show("客户电话：不能为空！", "提示");
                return intFalg;
            }
            if (txtOfficeTel.Text == "")
            {
                MessageBox.Show("办公电话：不能为空！", "提示");
                return intFalg;
            }
            if (txtkuSum.Text == "")
            {
                MessageBox.Show("产品数量：不能为空！", "提示");
                return intFalg;
            }
            if (txtkuEmploy.Text == "")
            {
                MessageBox.Show("经办人：不能为空！", "提示");
                return intFalg;
            }
            tbClass.khID = txtId.Text.Trim();
            tbClass.khHandye = cmbkhHandye.SelectedIndex;
            tbClass.khName = txtName.Text.Trim();
            tbClass.khPi = txtkhPi.Text.Trim();
            tbClass.khState = cmbkhState.SelectedIndex;
            tbClass.khType = cmbkhType.SelectedIndex;
            tbClass.kuAddress = txtkuAddress.Text.Trim();
            tbClass.kuChangPi = cmbkuChangPi.Text;
            tbClass.kuDate = DateTime.Now;
            tbClass.kuDateLaste = DateTime.Now;
            tbClass.kuEmail = txtEmail.Text.Trim();
            tbClass.kuTel = txtkhTel.Text;
            tbClass.kuSum = Convert.ToInt32(txtkuSum.Text.Trim());
            tbClass.kuOffice = txtOfficeTel.Text.Trim();
            tbClass.kuFalg = 0;
            tbClass.kuEmploy = txtkuEmploy.Text.Trim();
            intFlag = 1;
            return intFlag;
        }

        //删除
        private void bntDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("请选择要删除的记录");
                return;
            }
            tbClass.khID = txtId.Text.Trim();
            tbClass.kuFalg = 1;
            int intResult = tbMenthod.tbCustomerDelete(tbClass);//调用方法添加客户信息
            if (intResult == 1)
            {
                MessageBox.Show("删除成功！", "提示");
                tbClass.khID = "";
                tbMenthod.filltbProPath(treeView1, imageList1, tbMenthod.tbCustomerSecarf(tbClass, "LikekhID"));
                ClearFill();
                intFlag = 3;
      
            }
            else
            {
                MessageBox.Show("删除失败！", "提示");
                ClearFill();
                intFlag = 3;
           
            }

        }//
        //此方法清空所有控件内的内容
        public void ClearFill()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtkhPi.Text = "";
            cmbkhType.SelectedIndex = 0;

            cmbkhHandye.SelectedIndex = 0;
            cmbkhState.SelectedIndex =0;
            txtkhTel.Text = "";
            txtOfficeTel.Text = "";
            txtEmail.Text = "";
            txtkuAddress.Text = ""; ;

            cmbkuChangPi.Text = "";
            txtkuSum.Text = "";
            txtkuEmploy.Text = "";
        
        }
    }
}