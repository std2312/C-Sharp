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
    public partial class frmAddDep : Form
    {
        public frmAddDep()
        {
            InitializeComponent();
        }
        DBOperate operate = new DBOperate();//创建数据操作对象
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();//关闭窗体
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtDepName.Text.Trim() == "")
            {
                MessageBox.Show("请输入部门名称", "提示",//弹出消息对话框
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;//退出事件
            }
            else
            {
                string str=//创建SQL字符串
                    "select count(*) from tb_department where DepName='"+txtDepName.Text.Trim()+"'";
                int i=operate.HumanNum(str);//得到记录数量
                if (i > 0)
                {
                    MessageBox.Show("该部门已经存在", "提示",//弹出消息对话框
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;//退出事件
                }
                else
                {
                    string Addsql =//创建SQL字符串
                        "insert into tb_department(DepName) values('" + txtDepName.Text.Trim() + "')";
                    if (operate.OperateData(Addsql) > 0)
                    {
                        MessageBox.Show("添加成功", "提示",//弹出消息对话框
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}