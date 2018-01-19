using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using PMS.PMSClass;
namespace PMS
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        DBOperate operate = new DBOperate();//创建操作数据库对象
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //try
            //{
                if (txtUserName.Text == "" || txtUserPwd.Text == "")//判断用户名和密码是否为空
                {
                    MessageBox.Show("用户名或密码不能为空！",//弹出消息对话框
                        "提示", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;//退出事件
                }
                else
                {
                    string name = txtUserName.Text.Trim();//移除用户名前部和后部的空格
                    string pwd = txtUserPwd.Text.Trim();//移除密码前部和后部的空格
                    SqlConnection conn = PMSClass.DBConnection.MyConnection();//创建数据库连接对象
                    conn.Open();//连接到SQL数据库
                    SqlCommand cmd = new SqlCommand(//创建数据库命令对象
                        "select * from tb_User where UserName='" + 
                        name + "' and UserPwd='" + pwd + "'", conn);
                    SqlDataReader sdr = cmd.ExecuteReader();//得到数据读取器对象
                    sdr.Read();//读取一条记录
                    if (sdr.HasRows)//判断是否包含数据
                    {
                        string time = DateTime.Now.ToString();//得到系统时间字符串
                        string sql = "update tb_User set LoginTime='" //设置更新数据库的SQL语句
                            + time + "' where UserName='" + name + "'";
                        operate.OperateData(sql);//更新数据库内容
                        conn.Close();//关闭数据库连接
                        this.Hide();//隐藏窗体
                        frmMain Main = new frmMain();//创建主窗体对象
                        Main.User = name;//为主窗体字段赋值
                        Main.Logintime = time;//为主窗体字段赋值
                        Main.Show();//显示主窗体
                    }
                    else
                    {
                        txtUserName.Text = "";//清空用户名
                        txtUserPwd.Text = "";//清空密码
                        MessageBox.Show("用户名或密码错误！", "提示",//弹出消息对话框
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            //}
            //catch (Exception ex)//捕获异常
            //{
            //    MessageBox.Show(ex.Message);//弹出消息对话框
            //}
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();//关闭窗体
        }
    }
}