using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PMS.PMSClass;
namespace PMS
{
    public partial class frmChangePwd : Form
    {
        public frmChangePwd()
        {
            InitializeComponent();
        }
        DBOperate operate = new DBOperate();//创建数据库操作对象
        public string name;//声明字段
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNewPwd.Text.Trim() == "" ||
                txtNewPwd2.Text.Trim() == "" ||
                txtOldPwd.Text.Trim() == "")
            {
                MessageBox.Show("请将数据填写完整", "提示",//弹出消息对话框
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;//退出事件
            }
            else
            {
                string str =//创建SQL字符串
                    "select count(*) from tb_User where UserName='" + name + "' and UserPwd='" + this.txtOldPwd.Text.Trim() + "'";
                int i = operate.HumanNum(str);//得到记录数量
                if (i > 0)
                {
                    if (txtNewPwd.Text.Trim() != txtNewPwd2.Text.Trim())
                    {
                        MessageBox.Show("两次密码不一致", "提示",//弹出消息对话框
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;//退出事件
                    }
                    else
                    {
                        string updatestr =//创建SQL字符串
                            "update tb_User set UserPwd='" + txtNewPwd2.Text.Trim() + "' where UserName='" + name + "'";
                        operate.OperateData(updatestr);//更新数据库信息
                        MessageBox.Show("密码修改成功", "提示",//弹出消息对话框
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();//关闭窗体
                    }
                }
                else
                {
                    MessageBox.Show("旧密码错误", "提示",//弹出消息对话框
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;//退出事件
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();//关闭窗体
        }
    }
}