using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


using Daila.NewMehod;
using Daila.NewClass;
using System.Data.OleDb;

namespace Daila
{
    public partial class frmEmployeeInfo : Form
    {
        public frmEmployeeInfo()
        {
            InitializeComponent();
        }
        public frmEmployeeInfo(int intCount)
        {
            InitializeComponent();
            intFalg = intCount;
        }

        public static int intFalg;

        tbEmployeeClass tbClass = new tbEmployeeClass();
        tbEmployeeMenthod tbMenthod = new tbEmployeeMenthod();
        private void frmEmployeeInfo_Load(object sender, EventArgs e)
        {
            tbClass.strEmployeeID = "";       //清空员工编号
            tbMenthod.fillEmployee(treeView1, imageList1, tbMenthod.tbEmpSecarf(tbClass)); //调用员工信息方法类中的fillEmployee方法绑定TreeView控件
            tbDistionMenthod td = new tbDistionMenthod();                                  //实例方法类绑定CombBox控件
            td.filltb_EmpSex(cmbEmpSex);//调用方法绑定员工性别CombBox控件
            td.filltb_Nation(cmbEmpNation);//调用方法绑定员工民族CombBox控件
            td.filltb_Marital(cmbEmpState);//调用方法绑定员工婚姻状态CombBox控件

            if (intFalg == 1) //添加员工信息操作
            {
                this.Text = "添加员工信息";
                txtEmployeeID.Text = tbMenthod.EmployeeID();//自动获得员工编号
                this.bntOK.Visible = true;
                bntEsce.Enabled = true;
                bntDelete.Enabled = false;
                bntUpdate.Enabled = false;
            }
            if (intFalg == 2)//修改员工信息"操作
            {
                this.Text = "修改员工信息";
                bntUpdate.Enabled = true;
                bntOK.Enabled = false;
                bntDelete.Enabled = false;
                bntEsce.Enabled = true;


            }
            if (intFalg == 3)//删除员工信息操作
            {
                this.Text = "删除员工信息";
                bntOK.Enabled = false;
                bntDelete.Enabled = true;
                bntEsce.Enabled = true;
                bntUpdate.Enabled =false;
            }
            if (intFalg == 4)//查询员工信息操作
            {
                this.Text = "查询员工信息";
                bntOK.Enabled =false;
                bntDelete.Enabled = false;
                bntEsce.Enabled = true;
                bntUpdate.Enabled = false;
            }

        }
        #region 此方法填冲控件信息
        public void FiiInfo(OleDbDataReader dr)
        {
            try
            {
                OleDbDataReader oledr = dr;   //实例一个OleDbDataReader对象
                oledr.Read();                //调用方法查找记录
                if (oledr.HasRows)           //判断记录集中是否有记录
                {
                    txtEmployeeID.Text = oledr[0].ToString();
                    txtEmployeeID.Enabled = false;
                    txtEmpName.Text = oledr[1].ToString();
                    txtEmpEngish.Text = oledr[2].ToString();
                    txtPasswod.Text = oledr[3].ToString();
                    cmbEmpNation.SelectedIndex = Convert.ToInt32(dr[4].ToString());
                    cmbEmpSex.SelectedIndex = Convert.ToInt32(dr[5].ToString());
                    txtEmpIDcard.Text = oledr[6].ToString();
                    dtfldEmpBirthday.Value = Convert.ToDateTime(oledr[7].ToString());
                    txtEmpOfficeTel.Text = oledr[8].ToString();
                    txtEmpOICQ.Text = oledr[9].ToString();
                    txtEmpEmail.Text = oledr[10].ToString();
                    cmbEmpState.SelectedIndex = Convert.ToInt32(oledr[11].ToString());
                    txtEmpCity.Text = oledr[12].ToString();
                    dtEmpWorkDate.Value = Convert.ToDateTime(oledr[13].ToString());
                    dtEmpDemissionDate.Value = Convert.ToDateTime(oledr[14].ToString());
      

                    txtfldEmpRemark.Text = oledr[15].ToString();
                    if (Convert.ToInt32(oledr[16]) == 0)
                    { this.radioButton2.Checked = true; }
                    if (Convert.ToInt32(oledr[16]) == 1)
                    { rdfldEmpWorkFlag1.Checked = true; }
                }
                oledr.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString());   //显示错误信息
            }
        }
        #endregion
        #region 此方法是清空控件内的内容
        public void ClearMenthod()
        {
            txtEmployeeID.Text = "";
          
            txtEmpName.Text ="";
            txtEmpEngish.Text = "";
            txtPasswod.Text = "";
            cmbEmpNation.SelectedIndex = 0;
            cmbEmpSex.SelectedIndex =0;
            txtEmpIDcard.Text = "";
            dtfldEmpBirthday.Value =DateTime.Now;
            txtEmpOfficeTel.Text = "";
            txtEmpOICQ.Text = "";
            txtEmpEmail.Text = "";
            cmbEmpState.SelectedIndex = 0;
            txtEmpCity.Text = "";
            dtEmpWorkDate.Value =DateTime.Now;
            dtEmpDemissionDate.Value = DateTime.Now;

            txtfldEmpRemark.Text = ""; 
            this.radioButton2.Checked = true; 
   
        }
        #endregion

        //此方法为共公方法，判断文本是否为空，传递参数
        public int pulicMenhod()
        {
            int intResult = 0; //判断是否输入信息
            if (txtEmployeeID.Text == "")
            {
                MessageBox.Show("员工编号：不能为空！", "提示");
                txtEmployeeID.Focus();
                return intResult;
            }
            if (txtEmpName.Text == "")
            {
                MessageBox.Show("员工姓名：不能为空！", "提示");
                txtEmpName.Focus();
                return intResult;
            }
            if (txtEmpEngish.Text == "")
            {
                MessageBox.Show("登录：不能为空！", "提示");
                txtEmpEngish.Focus();
                return intResult;
            }
            if (txtPasswod.Text == "")
            {
                MessageBox.Show("密码：不能为空！", "提示");
                txtPasswod.Focus();
                return intResult;
            }
            tbClass.strEmployeeID = txtEmployeeID.Text.Trim();
            tbClass.strEmpName = txtEmpName.Text.Trim();
            tbClass.EmpEngish = txtEmpEngish.Text.Trim();
            tbClass.EmpPasword = txtPasswod.Text.Trim();
            tbClass.shEmpNation = cmbEmpNation.SelectedIndex;
            tbClass.shEmpSex = cmbEmpSex.SelectedIndex;
            tbClass.strEmpIDcard = txtEmpIDcard.Text.Trim();
            tbClass.strEmpSpecialty = dtfldEmpBirthday.Value;
            tbClass.strEmpOfficeTel = txtEmpOfficeTel.Text.Trim();
            tbClass.strEmpOICQ = txtEmpOICQ.Text.Trim();
            tbClass.strEmpEmail = txtEmpEmail.Text.Trim();
            tbClass.shEmpState = cmbEmpState.SelectedIndex;
            tbClass.shEmpCity = txtEmpCity.Text;
            tbClass.EmpWorkDate = dtEmpWorkDate.Value;
            tbClass.EmpDemissionDate = dtEmpDemissionDate.Value;
            tbClass.strfldEmpRemark = txtfldEmpRemark.Text.Trim();
            if (rdfldEmpWorkFlag1.Checked == true)
            {
                tbClass.byfldEmpWorkFlag = 1;
            }
            if (this.radioButton2.Checked == true)
            {
                tbClass.byfldEmpWorkFlag = 0;

            }
            tbClass.EmpRegDate = DateTime.Now;
            intResult = 1;
            return intResult;

        }


        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode.Text != "")   //判断是否选择员工编号
            {
                if (intFalg != 1)//此处判断是否为添加操作，如果为添加操作，不执行代码
                {
                    tbClass.strEmployeeID = treeView1.SelectedNode.Text; //将选择的员工编号赋给实体类
                    FiiInfo(tbMenthod.tbEmpSecarf(tbClass));//调用方法显数据
                }
            }
        }
        //退出按
        private void bntEsce_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //添加员工信息
        private void bntOK_Click(object sender, EventArgs e)
        {
           
            if (pulicMenhod() == 1)// 调用方法判断输入信息是否正确1表示正确，0表法错误
            {
                if (tbMenthod.tbEmpSecarfInfo(tbClass) == 0)
                {

                    int intResult = tbMenthod.tbEmployeeAdd(tbClass);//调用方法添加员工信息反回值，1表示成功，0表示失败
                    if (intResult == 1)//
                    {
                        MessageBox.Show("添加成功！", "提示");
                        tbClass.strEmployeeID = "";
                        tbMenthod.fillEmployee(treeView1, imageList1, tbMenthod.tbEmpSecarf(tbClass));
                        ClearMenthod();//清空控件内的文本
                        txtEmployeeID.Text = tbMenthod.EmployeeID();//自动获得员工编号
                        intFalg = 1;

                    }
                    else
                    {
                        MessageBox.Show("添加失败！", "提示");
                        ClearMenthod();//清空控件内的文本
                        txtEmployeeID.Text = tbMenthod.EmployeeID();//自动获得员工编号
                        intFalg = 1;

                    }
                }
                else
                {
                    MessageBox.Show("登录名称重复，请重新输入！","提示");
                    txtEmpEngish.Text = "";
                    txtEmpEngish.Focus();
                }
            }


         }
        //删除员工信息
        private void bntDelete_Click(object sender, EventArgs e)
        {
            if (txtEmployeeID.Text == "")
            {
                MessageBox.Show("请选择要删除的员工信息");
                return;
            }

                tbClass.strEmployeeID = txtEmployeeID.Text.Trim();
                tbClass.byfldEmpWorkFlag = 1;
                //调用方法添加员工信息
                int intResult1 = tbMenthod.tbEmployeeDelete(tbClass);
                if (intResult1 == 1)
                {
                    MessageBox.Show("删除成功！", "提示");
                    tbClass.strEmployeeID = "";
                    //调用方法刷新TreeView控件
                    tbMenthod.fillEmployee(treeView1, imageList1, tbMenthod.tbEmpSecarf(tbClass));
                    ClearMenthod();//清空控件内的文本
                    intFalg = 3;
                }
                else
                {
                    MessageBox.Show("删除失败！", "提示");
                    ClearMenthod();//清空控件内的文本
                    intFalg = 3;
                  
                }
        }// end if 

        //修改员工信息
        private void bntUpdate_Click(object sender, EventArgs e)
        {

            if (pulicMenhod() == 1)// 调用方法判断输入信息是否正确，1表示正确，0表法错误
            {

                int intResult = tbMenthod.tbEmployeeUpdate(tbClass);//调用方法修改信息
                if (intResult == 1)
                {
                    MessageBox.Show("修改成功！", "提示");
                    tbClass.strEmployeeID = "";

                    tbMenthod.fillEmployee(treeView1, imageList1, tbMenthod.tbEmpSecarf(tbClass));
                    ClearMenthod();//清空控件内的文本
                    intFalg = 2;
                }
                else
                {
                    MessageBox.Show("修改失败！", "提示");
                    ClearMenthod(); //清空控件内的文本
                    intFalg = 2;//修改

                }
            }

        }


    }
}