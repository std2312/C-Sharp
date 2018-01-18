using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PMS.PMSClass;
using System.IO;
namespace PMS
{
    public partial class frmEmployeeInfo : Form
    {
        public frmEmployeeInfo()
        {
            InitializeComponent();
        }
        DBOperate operate = new DBOperate();//创建数据库操作对象
        public string YGName;//声明字段
        public string YGID;//声明字段
        private void frmEmployeeInfo_Load(object sender, EventArgs e)
        {
            operate.BindDropdownlist("tb_department", cbbYGBumen, 1);//绑定下拉列表
            operate.BindDropdownlist("tb_userJob", txtYGZhiwu, 1);//绑定所有的职务列表
            this.Text = "[ "+YGName+" ]的个人信息";//设置窗体标题
            string sql =//创建SQL字符串
                "select * from tb_employee where employeeID='" + YGID + "'";
            DataSet ds = operate.GetTable(sql);//得到数据集
            ds.Dispose();//释放资源
            txtYGNum.Text = ds.Tables[0].Rows[0][1].ToString();//获取员工编号信息
            txtYGName.Text = ds.Tables[0].Rows[0][2].ToString();//获取员工姓名信息
            cbbYGSex.SelectedItem = ds.Tables[0].Rows[0][3].ToString();//获取性别信息
            cbbYGBumen.SelectedItem = ds.Tables[0].Rows[0][4].ToString();//获取部门信息
            txtYGBirthday.Text = ds.Tables[0].Rows[0][5].ToString();//获取生日信息
            txtYGminzu.SelectedItem = ds.Tables[0].Rows[0][6].ToString();//获取民族信息
            cbbYGHunyin.SelectedItem = ds.Tables[0].Rows[0][7].ToString();//获取婚姻信息
            txtYGZhiwu.SelectedItem = ds.Tables[0].Rows[0][8].ToString();//获取职务信息
            txtYGPhone.Text = ds.Tables[0].Rows[0][9].ToString();//获取电话信息
            txtYGJiuzhi.Text = ds.Tables[0].Rows[0][10].ToString();//获取就职日期
            txtYGPay.Text = ds.Tables[0].Rows[0][12].ToString();//获取工资信息
            operate.Get_Image(YGID, pictureBox1);//获取图像信息
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            try
            {
                string DelSql =//创建数据库连接字符串
                    "delete from tb_employee where employeeID='" + YGID + "'";
                operate.OperateData(DelSql);//删除数据
                operate.DeleUserInfo(YGID);//删除数据
                MessageBox.Show(//弹出消息对话框
                    "删除成功","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();//关闭窗体
            }
            catch
            {
                MessageBox.Show("删除操作失败","提示",//弹出消息对话框
                    MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            this.Close();//关闭窗体
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtYGBirthday.Text.Trim() == "" ||
                    txtYGJiuzhi.Text.Trim() == "" ||
                    txtYGminzu.Text.Trim() == "" ||
                    txtYGName.Text.Trim() == "" ||
                    txtYGNum.Text.Trim() == "" ||
                    txtYGPhone.Text.Trim() == "" ||
                    txtYGZhiwu.Text.Trim() == ""||
                    txtYGPay.Text.Trim()=="")
                {
                    MessageBox.Show("请将信息填写完整", "警告",//弹出消息对话框
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;//退出事件
                }
                else
                {
                    if (txtYGPhone.Text.Length != 11)//判断手机号码位数
                    {
                        MessageBox.Show("手机号码为11位");//弹出消息对话框
                        return;//退出事件
                    }
                    else
                    {
                        string strUpdateSql =//创建SQL字符串
                            "update tb_employee set employeeName='" + txtYGName.Text.Trim() + "',employeeSex='" + cbbYGSex.Text + "',employeeDept='" + cbbYGBumen.Text + "',employeeBirthday='" + txtYGBirthday.Text + "',employeeNation='" + txtYGminzu.Text.Trim() + "',employeeMarriage='" + cbbYGHunyin.Text + "',employeeDuty='" + txtYGZhiwu.Text.Trim() + "',employeePhone='" + txtYGPhone.Text.Trim() + "',employeeAccession='" + txtYGJiuzhi.Text + "',employeePay='"+txtYGPay.Text.Trim()+"' where employeeID='" + YGID + "'";
                        int num = operate.OperateData(strUpdateSql);//更新数据库信息
                        if (openFileDialog1.FileName == "openFileDialog1")
                        { }
                        else
                        {
                            operate.SaveImage(this.txtYGNum.Text.Trim(), openFileDialog1);//保存图像信息
                        }
                        if (num > 0)
                        {
                            string update1 =//创建SQL字符串
                                "update tb_redeploy set UName='" + txtYGName.Text + "',UOldDep='" + cbbYGBumen.Text + "',UOldJob='" + txtYGZhiwu.Text + "',UOldPay='"+txtYGPay.Text+"' where UID='" + txtYGNum.Text + "'";
                            string update2 =//创建SQL字符串
                                "update tb_prize set UserName='" + txtYGName.Text + "',UserDep='"+cbbYGBumen.Text+"' where UserID='" + txtYGNum.Text + "'";
                            string update3 =//创建SQL字符串
                                "update tb_pay set YName='" + txtYGName.Text + "',YSex='" + cbbYGSex.Text + "',Ydep='" + cbbYGBumen.Text + "',YZhiwu='" + txtYGZhiwu.Text + "',YBasePay='"+txtYGPay.Text+"' where YID='" + txtYGNum.Text + "'";
                            string update4 =//创建SQL字符串
                                "update tb_check set Pname='" + txtYGName.Text + "',Pdep='"+cbbYGBumen.Text+"' where PID='" + txtYGNum.Text + "'";
                            operate.OperateData(update1);//更新数据库
                            operate.OperateData(update2);//更新数据库
                            operate.OperateData(update3);//更新数据库
                            operate.OperateData(update4);//更新数据库
                            MessageBox.Show("员工信息修改成功", "提示",//弹出消息对话框
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();//关闭窗体
                        }
                    }
                }
            }
            catch (Exception EX)//捕获异常
            {
                MessageBox.Show(EX.Message, "提示",//弹出消息对话框
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                operate.Read_Image(openFileDialog1, pictureBox1);//读取并显示图像信息
            }
            catch
            {
                MessageBox.Show("加载图片出错");//弹出消息对话框
            }
        }
        private void txtYGPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("只能输入数字", "提示",//弹出消息对话框
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;//已经处理过此事件
            }
        }

        private void txtYGPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("只能输入数字", "提示",//弹出消息对话框
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;//已经处理过此事件
            }
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            PrintForm.frmUserPrint userprint =//创建打印窗体对象
                new PMS.PrintForm.frmUserPrint();
            userprint.ShowDialog();//显示模式窗体
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strg = Application.StartupPath.ToString();//得到应用程序路径信息
            strg = strg.Substring(0, strg.LastIndexOf("\\"));//截取路径信息
            strg = strg.Substring(0, strg.LastIndexOf("\\"));//截取咱径信息
            strg += @"\PMSImage";//添加路径信息
            strg += @"\default.jpg";//添加文件名称
            openFileDialog1.FileName = strg;//设置打开文件路径信息
            pictureBox1.Image=System.Drawing.Image.//显示图像信息
                FromFile(openFileDialog1.FileName);
        }
    }
}