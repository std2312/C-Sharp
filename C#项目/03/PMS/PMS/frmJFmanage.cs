using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using PMS.PMSClass;
using System.Text.RegularExpressions;
namespace PMS
{
    public partial class frmJFmanage : Form
    {
        public frmJFmanage()
        {
            InitializeComponent();
        }
        DBOperate operate = new DBOperate();//创建数据库操作对象
        private void frmJFmanage_Load(object sender, EventArgs e)
        {
            SqlConnection conn = DBConnection.MyConnection();//创建数据库连接对象
            conn.Open();//打开数据库连接
            SqlCommand cmd = new SqlCommand("select * from tb_employee", conn);//创建数据库命令对象
            SqlDataReader sdr = cmd.ExecuteReader();//得到数据读取器
            while (sdr.Read())//读取数据
            {
                cbbUserNum.Items.Add(sdr["employeeID"].ToString());//添加数据项
            }
            sdr.Close();//关闭数据读取器
            conn.Close();//关闭数据库连接
        }

        private void cbbUserNum_SelectedIndexChanged(object sender, EventArgs e)
        {
           string str =//创建SQL字符串
               "select * from tb_employee where employeeID='" + cbbUserNum.Text + "'";
           DataSet ds = operate.GetTable(str);//得到数据集
           ds.Dispose();//释放资源
           txtname.Text = ds.Tables[0].Rows[0][2].ToString();//得到用户名
           txtdep.Text = ds.Tables[0].Rows[0][4].ToString();//得到部门信息
        }

        private void cbbUserJFType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbUserJFType.Text == "奖励")
            {
                txtFK.Enabled = false;//停用罚款文本框
                txtFK.Text = "0";//清空罚款文本框
                txtJL.Enabled = true;//应用奖励文本框
            }
            else
            {
                txtJL.Enabled = false;//停用奖励文本框
                txtJL.Text = "0";//清空奖励文本框
                txtFK.Enabled = true;//启用罚款文本框
            }
        }

        private void txtJL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("只能输入数字", "提示",//弹出消息对话框
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;//已经处理过此事件
            }
        }

        private void txtFK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("只能输入数字", "提示",//弹出消息对话框
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;//已经处理过此事件
            }
        }

        private void 添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cbbUserNum.Text == "" || cbbUserJFType.Text == "" ||
                txtJFcontent.Text == "" || txtJFdate.Text == "" ||
                txtCXDate.Text == "")
            {
                MessageBox.Show("请将信息填写完整！", "提示",//弹出消息对话框
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;//退出事件
            }
            else
            {
                if (cbbUserJFType.Text == "奖励")
                {
                    if (txtJL.Text == "")
                    {
                        MessageBox.Show("请输入奖励金额！",//弹出消息对话框
                            "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;//退出事件
                    }
                    else
                    {
                        string sql =//创建SQL字符串
                            "select count(*) from tb_prize where UserID='" + cbbUserNum.Text + "'";
                        int i = operate.HumanNum(sql);//得到记录数量
                        if (i > 0)
                        {
                            MessageBox.Show("员工编号已经存在！", "提示",//弹出消息对话框
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;//退出事件
                        }
                        else
                        {
                            string str =//创建SQL字符串
                                "insert into tb_prize(UserID,UserName,UserDep,UserJF,UserJFcontent,UserJLMoney,UserFKMoney,UserJFDate,UserCXDate) values('" + cbbUserNum.Text + "','" + txtname.Text + "','" + txtdep.Text + "','" + cbbUserJFType.Text + "','" + txtJFcontent.Text + "','" + txtJL.Text + "','" + txtFK.Text + "','" + txtJFdate.Text + "','" + txtCXDate.Text + "')";
                            operate.OperateData(str);//向数据库插入数据
                            MessageBox.Show("添加成功！", "提示",//弹出消息对话框
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    try
                    {
                        if (txtFK.Text == "")
                        {
                            MessageBox.Show("罚款金额不为空");//弹出消息对话框
                        }
                        else
                        {
                            string sql =//创建SQL字符串
                                "select count(*) from tb_prize where UserID='" + cbbUserNum.Text + "'";
                            int i = operate.HumanNum(sql);//得到记录数量
                            if (i > 0)
                            {
                                MessageBox.Show("员工编号已经存在！", "提示",//弹出消息对话框
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;//退出事件
                            }
                            else
                            {
                                string str =//创建SQL字符串
                                    "insert into tb_prize(UserID,UserName,UserDep,UserJF,UserJFcontent,UserJLMoney,UserFKMoney,UserJFDate,UserCXDate) values('" + cbbUserNum.Text + "','" + txtname.Text + "','" + txtdep.Text + "','" + cbbUserJFType.Text + "','" + txtJFcontent.Text + "','" + txtJL.Text + "','" + txtFK.Text + "','" + txtJFdate.Text + "','" + txtCXDate.Text + "')";
                                operate.OperateData(str);//向数据库插入数据
                                MessageBox.Show("添加成功！", "提示",//弹出消息对话框
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    catch(Exception ex)//捕获异常
                    {
                        MessageBox.Show(ex.Message);//弹出消息对话框
                    }
                }
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();//关闭窗体
        }
    }
}