using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


using Daila.NewClass;
using Daila.NewMehod;
using System.Data.OleDb;

namespace Daila
{
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbFind.Text == "")
            {
                MessageBox.Show("请选择查询条件！","提示");
                cmbFind.Focus();
                return;
            }
            if (txtWord.Text == "")
            {
                MessageBox.Show("请输入查询条件！", "提示");
                txtWord.Focus();
                return;
            }
            tbCustomerClass tbClass = new tbCustomerClass();
            tbCustomerMethod tbMenthod = new tbCustomerMethod();
            
          
            switch (cmbFind.Text)
            {
                case "客户编号":
                    tbClass.khID = txtWord.Text.Trim();
                    int intFalg = tbMenthod.fillDataGridView(dataGridView1, tbMenthod.tbCustomerSecarf(tbClass, "khID"), DataGridViewCount(tbMenthod.tbCustomerSecarf(tbClass, "khID")));
                    if (intFalg == 0)
                    { DtatClear(); }//调用方法清空控件
                  break;
                case "客户姓名":
                    tbClass.khPi = txtWord.Text.Trim();
                    int intFalgName = tbMenthod.fillDataGridView(dataGridView1, tbMenthod.tbCustomerSecarf(tbClass, "khName"), DataGridViewCount(tbMenthod.tbCustomerSecarf(tbClass, "khName")));
                    if (intFalgName == 0)
                    { DtatClear(); }//调用方法清空控件
                  break;
                case "公司名称":
                    tbClass.khName = txtWord.Text.Trim();
                    int intFalgCName = tbMenthod.fillDataGridView(dataGridView1, tbMenthod.tbCustomerSecarf(tbClass, "kuComputy"), DataGridViewCount(tbMenthod.tbCustomerSecarf(tbClass, "kuComputy")));
                    if (intFalgCName == 0)
                    { DtatClear(); }//调用方法清空控件
                  break;
                case "电话查询":
                    tbClass.kuTel = txtWord.Text.Trim();
                    tbClass.kuOffice = txtWord.Text.Trim();
                    int intFalgTel = tbMenthod.fillDataGridView(dataGridView1, tbMenthod.tbCustomerSecarf(tbClass, "khTel"), DataGridViewCount(tbMenthod.tbCustomerSecarf(tbClass, "khTel")));
                    if (intFalgTel == 0)
                    { DtatClear(); }//调用方法清空控件
                    break;
            
            }//end
            
        }

        public void DtatClear()
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1[0,i].Value = "";
                dataGridView1[1, i].Value = "";
                dataGridView1[2, i].Value = "";
                dataGridView1[3, i].Value = "";
                dataGridView1[4, i].Value = "";
               


            }
        }
        private void frmCustomer_Load(object sender, EventArgs e)
        {

        }

        private void bntLike_Click(object sender, EventArgs e)
        {
            if (cmbFind.Text == "")
            {
                MessageBox.Show("请选择查询条件！", "提示");
                cmbFind.Focus();
                return;
            } 
            tbCustomerClass tbClass = new tbCustomerClass();
            tbCustomerMethod tbMenthod = new tbCustomerMethod();


            switch (cmbFind.Text)
            {
                case "客户编号":
                    tbClass.khID = txtWord.Text.Trim();
                    int intCout = DataGridViewCount(tbMenthod.tbCustomerSecarf(tbClass, "LikekhID"));
                    int intFalg = DataGridFalg(tbMenthod.tbCustomerSecarf(tbClass, "LikekhID"),intCout);
                    if (intFalg == 0)
                    { DtatClear(); }//调用方法清空控件
                    break;
                case "客户姓名":
                    tbClass.khPi = txtWord.Text.Trim();
                    int intCout1 = DataGridViewCount(tbMenthod.tbCustomerSecarf(tbClass, "LikekhName"));
                    int intFalgName = DataGridFalg(tbMenthod.tbCustomerSecarf(tbClass, "LikekhName"),intCout1);
                    if (intFalgName == 0)
                    { DtatClear(); }//调用方法清空控件
                    break;
                case "公司名称":
                    tbClass.khName = txtWord.Text.Trim();
                    int intCout2 = DataGridViewCount(tbMenthod.tbCustomerSecarf(tbClass, "kuComputylike"));
                    int intFalgCName = DataGridFalg(tbMenthod.tbCustomerSecarf(tbClass, "kuComputylike"), intCout2);
                    if (intFalgCName == 0)
                    { DtatClear(); }//调用方法清空控件
                    break;
                case "电话查询":
                    tbClass.kuTel = txtWord.Text.Trim();
                    tbClass.kuOffice = txtWord.Text.Trim();
                    int intCout3 = DataGridViewCount(tbMenthod.tbCustomerSecarf(tbClass, "khTelLike"));
                    int intFalgTel = DataGridFalg(tbMenthod.tbCustomerSecarf(tbClass, "khTelLike"), intCout3);
         
                    if (intFalgTel == 0)
                    { DtatClear(); }//调用方法清空控件
                    break;

            }//end

        }//
        #region //获取控件数量
        public int DataGridViewCount(OleDbDataReader dr)
        {
            int intFalg = 0;
            try
            {
                OleDbDataReader oledDr = dr;　
                while (oledDr.Read())
                {

                  　 intFalg++;
                }
                return intFalg;
            }
            catch (Exception ee)
            {
                return intFalg;
            }

        }
        #endregion
        #region//填冲控件
        public int DataGridFalg(OleDbDataReader dr,int intCount)
        {
            int intFalg = 0;
            try
            {
                OleDbDataReader oledDr = dr;
                intFalg = 0;
                dataGridView1.RowCount = intCount; 
                while (oledDr.Read())
                {
                    this.dataGridView1[0, intFalg].Value = oledDr[0].ToString();
                    this.dataGridView1[1, intFalg].Value = oledDr[1].ToString();
                    this.dataGridView1[2, intFalg].Value = oledDr[2].ToString();
                    this.dataGridView1[3, intFalg].Value = oledDr[7].ToString();
                    this.dataGridView1[4, intFalg].Value = oledDr[10].ToString();
                    intFalg++;
                }
                return intFalg;
            }
            catch (Exception ee)
            {
                return intFalg;
            }
        }
        #endregion

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bntEsce_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}