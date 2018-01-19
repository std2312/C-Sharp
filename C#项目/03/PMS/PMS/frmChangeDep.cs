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
    public partial class frmChangeDep : Form
    {
        public frmChangeDep()
        {
            InitializeComponent();
        }
        public string name;//声明字段
        DBOperate operate = new DBOperate();//创建数据库操作对象
        private void frmChangeDep_Load(object sender, EventArgs e)
        {
            txtDepName.Text = name;//得到部门名称
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();//关闭窗体
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql =//创建SQL字符串
                "update tb_department set DepName='" + txtDepName.Text.Trim() + "' where DepName='"+name+"'";
            if (operate.OperateData(sql) > 0)
            {
                MessageBox.Show("部门修改成功", "提示",//弹出消息对话框
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();//关闭窗体
            }
        }
    }
}