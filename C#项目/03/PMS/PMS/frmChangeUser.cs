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
    public partial class frmChangeUser : Form
    {
        public frmChangeUser()
        {
            InitializeComponent();
        }
        DBOperate operate = new DBOperate();//创建数据库操作对象
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();//关闭窗体
        }

        private void frmChangeUser_Load(object sender, EventArgs e)
        {
            SqlConnection conn = DBConnection.MyConnection();//创建数据库连接对象
            conn.Open();//打开数据库连接
            SqlCommand cmd = new SqlCommand("select * from tb_User",conn);//创建数据库命令对象
            SqlDataReader sdr = cmd.ExecuteReader();//得到数据读取器
            while (sdr.Read())//读取数据
            {
                comboBox1.Items.Add(sdr["UserName"].ToString());//添加数据项
            }
            conn.Close();//关闭数据库连接
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtpwd.Text.Trim()==""||comboBox1.Text=="")
                {
                    MessageBox.Show("用户名或密码不能为空！", "提示",//弹出消息对话框
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;//退出事件
                }
                else
                {
                    string name = comboBox1.Text;//获取用户名
                    string pwd = txtpwd.Text.Trim();//获取密码
                    SqlConnection conn = DBConnection.MyConnection();//创建数据库连接对象
                    conn.Open();//打开数据库连接
                    SqlCommand cmd = new SqlCommand(//创建数据库命令对象
                        "select * from tb_User where UserName='" + name + "' and UserPwd='" + pwd + "'", conn);
                    SqlDataReader sdr = cmd.ExecuteReader();//创建数据读取器
                    sdr.Read();//读取数据
                    if (sdr.HasRows)//判断是否有数据
                    {
                        string time = DateTime.Now.ToString();//得到时间信息
                        string sql = //创建SQL字符串
                            "update tb_User set LoginTime='" + time + "' where UserName='" + name + "'";
                        operate.OperateData(sql);//更新数据库信息
                        this.MdiParent.Close();//关闭父窗体
                        conn.Close();//关闭连接
                        frmMain Main = new frmMain();//创建主窗体对象
                        Main.User = name;//为字段赋值
                        Main.Logintime = time;//为字段赋值
                        Main.Show();//显示主窗体
                    }
                    else
                    {
                        txtpwd.Text = "";//清空文本内容
                        comboBox1.Text = "";//清空文本内容
                        MessageBox.Show("用户名或密码错误！", "提示",//弹出消息对话框
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)//捕获异常
            {
                MessageBox.Show(ex.Message);//弹出消息对话框
            }
        }
    }
}