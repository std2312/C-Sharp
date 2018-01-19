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
    public partial class frmChangePrize : Form
    {
        public frmChangePrize()
        {
            InitializeComponent();
        }
        public string Uid;//声明字段
        public string Uname;//声明字段
        DBOperate operate = new DBOperate();//创建数据库操作对象
        private void frmChangePrize_Load(object sender, EventArgs e)
        {
            if (cbbUserJFType.Text == "奖励")
            {
                txtFK.Enabled = false;//停用罚款文本框
                txtJL.Enabled = true;//启用奖励文本框
            }
            else
            {
                txtJL.Enabled = false;//停用奖励文本框
                txtFK.Enabled = true;//启用罚款文本框
            }
            SqlConnection conn = DBConnection.MyConnection();//创建数据库连接对象
            conn.Open();//打开数据库连接
            SqlCommand cmd = new SqlCommand("select * from tb_employee", conn);//创建数据库命令对象
            SqlDataReader sdr = cmd.ExecuteReader();//创建数据读取器
            while (sdr.Read())//读取数据
            {
                cbbUserNum.Items.Add(sdr["employeeID"].ToString());//添加数据项
            }
            sdr.Close();//关闭数据读取器
            conn.Close();//关闭数据库连接
            this.Text = "[" + Uname + "]";//设置窗体标题
            string sql =//创建SQL字符串
                "select * from tb_prize where UserID='" + Uid + "'";
            DataSet ds = operate.GetTable(sql);//得到数据集
            ds.Dispose();//释放资源
            cbbUserNum.Text = ds.Tables[0].Rows[0][1].ToString();//得到员工编号
            cbbUserJFType.Text = ds.Tables[0].Rows[0][4].ToString();//得到奖罚信息
            txtname.Text = ds.Tables[0].Rows[0][2].ToString();//得到员工姓名
            txtdep.Text = ds.Tables[0].Rows[0][3].ToString();//得到员工部门
            txtJFcontent.Text = ds.Tables[0].Rows[0][5].ToString();//得到奖罚内容
            txtJL.Text = ds.Tables[0].Rows[0][6].ToString();//得到奖励金额
            txtFK.Text = ds.Tables[0].Rows[0][7].ToString();//得到罚款金额
            txtJFdate.Text = ds.Tables[0].Rows[0][8].ToString();//得到奖罚日期
            txtCXDate.Text = ds.Tables[0].Rows[0][9].ToString();//得到撤销日期
        }

        private void cbbUserJFType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbUserJFType.Text == "奖励")
            {
                txtFK.Enabled = false;//停用罚款文本框
                txtJL.Enabled = true;//启用奖励文本框
            }
            else
            {
                txtJL.Enabled = false;//停用奖励文本框
                txtFK.Enabled = true;//启用罚款文本框
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();//关闭窗体
        }

        private void 添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cbbUserNum.Text == "" || cbbUserJFType.Text == "" ||
                txtJFcontent.Text == "" || txtJL.Text == "" ||
                txtFK.Text == "" || txtJFdate.Text == "" || txtCXDate.Text == "")
            {
                MessageBox.Show("请将信息填写完整！", "提示",//弹出消息对话框
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;//退出事件
            }
            else
            {
                if (cbbUserJFType.Text == "奖励")
                {
                    if (Regex.IsMatch(txtJL.Text.Trim(), @"[1-9]\d*.\d{2}"))//判断是否为数字
                    {
                        string sql =//创建SQL字符串
                            "update tb_prize set UserName='" + txtname.Text + "',UserDep='" + txtdep.Text + "',UserJF='" + cbbUserJFType.Text + "',UserJFcontent='" + txtJFcontent.Text + "',UserJLMoney='" + txtJL.Text + "',UserFKMoney='" + txtFK.Text + "',UserJFDate='" + txtJFdate.Text + "',UserCXDate='" + txtCXDate.Text + "' where UserID='" + cbbUserNum.Text + "'";
                        if (operate.OperateData(sql) > 0)
                        {
                            MessageBox.Show("修改成功", "提示",//弹出消息对话框
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("请输入正确金额格式！", "提示",//弹出消息对话框
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;//退出事件
                    }
                }
                else
                {
                    if (Regex.IsMatch(txtFK.Text.Trim(), @"[1-9]\d*.\d{2}"))//判断是否为数字
                    {
                        string sql =//创建SQL字符串
                            "update tb_prize set UserName='" + txtname.Text + "',UserDep='" + txtdep.Text + "',UserJF='" + cbbUserJFType.Text + "',UserJFcontent='" + txtJFcontent.Text + "',UserJLMoney='" + txtJL.Text + "',UserFKMoney='" + txtFK.Text + "',UserJFDate='" + txtJFdate.Text + "',UserCXDate='" + txtCXDate.Text + "' where UserID='" + cbbUserNum.Text + "'";
                        if (operate.OperateData(sql) > 0)
                        {
                            MessageBox.Show("修改成功", "提示",//弹出消息对话框
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    else
                    {
                        MessageBox.Show("请输入正确金额格式！", "提示",//弹出消息对话框
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;//退出事件
                    }
                }
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
    }
}