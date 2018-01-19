using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PMS.PMSClass;
using System.Data.SqlClient;
using System.Collections;
using System.IO;
namespace PMS
{
    public partial class frmDataBackup : Form
    {
        public frmDataBackup()
        {
            InitializeComponent();
        }
        public string strg;//声明字段
        private void button1_Click(object sender, EventArgs e)//备份数据库
        {
            try
            {
                strg = Application.StartupPath.ToString();//得到应用程序路径
                strg = strg.Substring(0, strg.LastIndexOf("\\"));//截取路径
                strg = strg.Substring(0, strg.LastIndexOf("\\"));//截取路径
                strg += @"\Backup";//添加路径信息
                string sqltxt =//设置SQL字符串
                    @"BACKUP DATABASE db_PMS TO Disk='" + strg + "\\PMS.bak" + "'";
                if (File.Exists(strg + "\\PMS.bak"))//判断文件是否存在
                {
                    File.Delete(strg + "\\PMS.bak");//删除文件
                    SqlConnection conn = DBConnection.MyConnection();//创建数据库连接对象
                    conn.Open();//连接数据库
                    SqlCommand cmd = new SqlCommand(sqltxt, conn);//创建数据库命令对象
                    cmd.ExecuteNonQuery();//执行操作
                    conn.Dispose();//释放数据库连接资源
                    if (MessageBox.Show("备份成功", "提示", MessageBoxButtons.OK,//弹出消息对话框
                        MessageBoxIcon.Exclamation) == DialogResult.OK)
                    {
                        this.Close();//关闭窗体
                    }
                }
                else
                {
                    SqlConnection conn = DBConnection.MyConnection();//创建数据库连接对象
                    conn.Open();//连接数据库
                    SqlCommand cmd = new SqlCommand(sqltxt, conn);//创建数据库命令对象
                    cmd.ExecuteNonQuery();//执行操作
                    conn.Dispose();//释放数据库连接资源
                    if (MessageBox.Show("备份成功", "提示", MessageBoxButtons.OK,//弹出消息对话框
                        MessageBoxIcon.Exclamation) == DialogResult.OK)
                    {
                        this.Close();//关闭窗体
                    }
                }
            }
            catch (Exception ex)//捕获异常
            {
                MessageBox.Show(ex.Message.ToString(), "提示",//弹出消息对话框
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)//还原数据库
        {
            try
            {
                SqlConnection conn = DBConnection.MyConnection();//创建数据库连接
                string path = Application.StartupPath.ToString();//得到应用程序路径
                path = path.Substring(0, path.LastIndexOf("\\"));//截取路径
                path = path.Substring(0, path.LastIndexOf("\\"));//截取路径
                path += "\\Backup\\PMS.bak";//添加路径信息
                string str =//创建SQL字符串
                    "use master restore database db_PMS from Disk='" + path + "'";
                conn.Open();//打开数据库连接
                SqlCommand cmd = new SqlCommand(str, conn);//创建数据库命令对象
                cmd.ExecuteNonQuery();//执行操作
                conn.Close();//关闭连接
                if (MessageBox.Show("还原成功", "提示",//弹出消息对话框
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    this.Close();//关闭数据库连接
                }
            }
            catch//捕获异常
            {
                button2_Click(sender, e);//执行按钮Click事件
            }
        }
    }
}