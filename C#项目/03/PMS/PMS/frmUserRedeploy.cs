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
    public partial class frmUserRedeploy : Form
    {
        public frmUserRedeploy()
        {
            InitializeComponent();
        }
        DBOperate operate = new DBOperate();//创建数据库操作对象
        private void frmUserRedeploy_Load(object sender, EventArgs e)
        {
            string sql =//创建SQL字符串
                "select UID as '员工编号',UName as '员工姓名',URemoveDate as '调动时间',UOldDep as '原部门',UNewDep as '现部门',UOldJob as '原职务',UNewJob as '现职务',UOldPay as '原工资',UNewPay as '工资调整',UPayExplain as '调动说明' from tb_redeploy";
            operate.BindDataGridView(dataGridView1,sql);//绑定到DataGridView控件
            string num = "select count(*) from tb_redeploy";//创建SQL字符串
            toolStripStatusLabel2.Text = operate.HumanNum(num).ToString();//显示调动人数
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            frmAddUserRedeploy adduserredeploy = new frmAddUserRedeploy();//创建添加人员调动窗体对象
            adduserredeploy.ShowDialog();//显示模式窗体
        }

        private void frmUserRedeploy_Activated(object sender, EventArgs e)
        {
            string sql = //创建SQL字符串
                "select UID as '员工编号',UName as '员工姓名',URemoveDate as '调动时间',UOldDep as '原部门',UNewDep as '现部门',UOldJob as '原职务',UNewJob as '现职务',UOldPay as '原工资',UNewPay as '工资调整',UPayExplain as '调动说明' from tb_redeploy";
            operate.BindDataGridView(dataGridView1, sql);//绑定到DataGridView控件
            string num =//查找数量
                "select count(*) from tb_redeploy";
            toolStripStatusLabel2.Text = operate.HumanNum(num).ToString();//显示调动信息数量
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                string sql =//创建SQL字符串
                    "delete from tb_redeploy where UID='"+dataGridView1.SelectedCells[0].Value.ToString()+"'";
                if (operate.OperateData(sql)>0)
                {
                    MessageBox.Show("删除成功", "提示",//弹出消息对话框
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("请选择要删除的信息","提示",//弹出消息对话框
                    MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;//退出事件
            }
        }

        private void toolStripLabel10_Click(object sender, EventArgs e)
        {
            this.Close();//关闭窗体
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                string uid = dataGridView1.SelectedCells[0].Value.ToString();//得到ID
                string uname = dataGridView1.SelectedCells[1].Value.ToString();//得到用户名
                frmChangeUserRedeploy changeuserredeploy =//创建人员调动详细信息窗体对象
                    new frmChangeUserRedeploy();
                changeuserredeploy.id = uid;//为字段赋值
                changeuserredeploy.name = uname;//为字段赋值
                changeuserredeploy.ShowDialog();//显示模式窗体
            }
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                string uid = dataGridView1.SelectedCells[0].Value.ToString();//得到ID信息
                string uname = dataGridView1.SelectedCells[1].Value.ToString();//得到姓名信息
                frmChangeUserRedeploy changeuserredeploy =//创建人员调动详细信息窗体对象
                    new frmChangeUserRedeploy();
                changeuserredeploy.id = uid;//为字段赋值
                changeuserredeploy.name = uname;//为字段赋值
                changeuserredeploy.ShowDialog();//显示模式窗体
            }
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            string sql =//创建SQL字符串
                "select UID as '员工编号',UName as '员工姓名',URemoveDate as '调动时间',UOldDep as '原部门',UNewDep as '现部门',UOldJob as '原职务',UNewJob as '现职务',UOldPay as '原工资',UNewPay as '工资调整',UPayExplain as '调动说明' from tb_redeploy where UName like '%"+toolStripTextBox1.Text.Trim()+"%'";
            operate.BindDataGridView(dataGridView1, sql);//绑定到DataGridView控件
            string num =//创建SQL字符串
                "select count(*) from tb_redeploy where UName like '%" + toolStripTextBox1.Text.Trim() + "%'";
            toolStripStatusLabel2.Text = operate.HumanNum(num).ToString();//显示调动数量信息
        }

        private void toolStripLabel9_Click(object sender, EventArgs e)
        {
            PrintForm.frmRedeployPrint redeploy =//创建打印窗体对象
                new PMS.PrintForm.frmRedeployPrint();
            redeploy.ShowDialog();//显示模式窗体
        }
    }
}