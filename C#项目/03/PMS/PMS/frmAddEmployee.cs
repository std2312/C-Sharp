using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using PMS.PMSClass;
using System.Text.RegularExpressions;
namespace PMS
{
    public partial class frmAddEmployee : Form
    {
        public frmAddEmployee()
        {
            InitializeComponent();
        }
        DBOperate operate = new DBOperate();//创建数据库操作对象
        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            this.Close();//关闭窗体
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                operate.Read_Image(openFileDialog1, pictureBox1);//加载员工头像
            }
            catch//捕获异常
            {
                MessageBox.Show("加载图片出错");//弹出消息对话框
            }
        }

        private void frmAddEmployee_Load(object sender, EventArgs e)
        {
            try
            {
                operate.BindDropdownlist("tb_department",cbbYGBumen,1);//绑定下拉列表
                cbbYGHunyin.SelectedIndex = 0;//设置默认选项
                cbbYGSex.SelectedIndex = 0;//设置默认选项
                cbbYGBumen.SelectedIndex = 0;//设置默认选项
                txtYGminzu.SelectedIndex = 0;//设置默认选项
                string strg = Application.StartupPath.ToString();//得到应用程序路径
                strg = strg.Substring(0, strg.LastIndexOf("\\"));//截取路径信息
                strg = strg.Substring(0, strg.LastIndexOf("\\"));//截取路径信息
                strg += @"\PMSImage";//添加路径信息
                strg += @"\default.jpg";//添文件名称
                openFileDialog1.FileName = strg;//设置打开文件路径信息
                operate.BindDropdownlist("tb_userJob",txtYGZhiwu, 1);//绑定所有的职务列表
            }
            catch (Exception ex)//捕获异常
            {
                MessageBox.Show(ex.Message);//弹出消息对话框
            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            if (txtYGBirthday.Text.Trim() == "" ||
                txtYGJiuzhi.Text.Trim() == "" || txtYGminzu.Text.Trim() == "" ||
                txtYGName.Text.Trim() == "" || txtYGNum.Text.Trim() == "" ||
                txtYGPhone.Text.Trim() == "" || txtYGZhiwu.Text.Trim() == ""||txtYGPay.Text.Trim()=="")
            {
                MessageBox.Show("请将信息填写完整", "警告",//弹出消息对话框
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;//退出事件
            }
            else
            {
                if (txtYGPhone.Text.Length != 11)
                {
                    MessageBox.Show("手机号码为11位");//弹出消息对话框
                    return;//退出事件
                }
                else
                {
                    string str =//创建SQL字符串
                        "select count(*) from tb_employee where employeeID='" + txtYGNum.Text + "'";
                    int i = operate.HumanNum(str);//得到记录数量
                    if (i > 0)
                    {
                        MessageBox.Show("该员工编号已经存在", "提示",//弹出消息对话框
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;//退出事件
                    }
                    else
                    {
                        string strSql =//创建SQL字符串
                            "insert into tb_employee(employeeID,employeeName,employeeSex,employeeDept,employeeBirthday,employeeNation,employeeMarriage,employeeDuty,employeePhone,employeeAccession,employeePay) values('" + txtYGNum.Text.Trim() + "','" + txtYGName.Text.Trim() + "','" + cbbYGSex.Text + "','" + cbbYGBumen.Text + "','" + txtYGBirthday.Text + "','" + txtYGminzu.Text.Trim() + "','" + cbbYGHunyin.Text + "','" + txtYGZhiwu.Text.Trim() + "','" + txtYGPhone.Text.Trim() + "','" + txtYGJiuzhi.Text + "','" + txtYGPay.Text.Trim() + "')";
                        int num = operate.OperateData(strSql);
                        operate.SaveImage(//将图片存储到数据库中
                            this.txtYGNum.Text.Trim(), openFileDialog1);
                        if (num > 0)
                        {
                            MessageBox.Show("员工信息添加成功", "提示",//弹出消息对话框
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void txtYGNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar))//判断输入是否为数字
            {
                MessageBox.Show("只能输入数字", "提示",//弹出消息对话框
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;//已经处理此事件
            }
        }

        private void txtYGNum_TextChanged(object sender, EventArgs e)
        {
            string str =//创建SQL字符串
                "select count(*) from tb_employee where employeeID='" + this.txtYGNum.Text.Trim() + "'";
            int m = operate.HumanNum(str);//得到记录数量
            if (m > 0)
            {
                MessageBox.Show("员工编号存在", "提示",//弹出消息对话框
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;//退出事件
            }
        }

        private void txtYGPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("只能输入数字", "提示",//弹出消息对话框
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;//已经处理此事件
            }
        }

        private void txtYGPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar))//判断输入数值是否为数字
            {
                MessageBox.Show("只能输入数字", "提示",//弹出消息对话框
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;//已经处理此事件
            }
        }
    }
}