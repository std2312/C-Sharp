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
    public partial class frmUserCheck : Form
    {
        public frmUserCheck()
        {
            InitializeComponent();
        }
        DBOperate operate = new DBOperate();//创建数据库操作对象
        private void frmUserCheck_Load(object sender, EventArgs e)
        {
            string str =//创建SQL字符串
                "select PID as '员工编号',Pname as '员工姓名',Pdep as '所属部门',PKpcontent as '考评内容',PKpResult as '考评结果',PKpscore as '考评分数',PKpPeople as '考评人',PKpDate as '考评日期' from tb_check";
            operate.BindDataGridView(dataGridView1,str);//绑定到DataGridView控件
            string num = "select count(*) from tb_check";//查找数量信息
            toolStripStatusLabel2.Text = operate.HumanNum(num).ToString();//显示考评记录数量
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            frmAddUserCheck addusercheck = new frmAddUserCheck();//创建人员考评窗体对象
            addusercheck.ShowDialog();//显示模式窗体
        }

        private void frmUserCheck_Activated(object sender, EventArgs e)
        {
            string str =//创建SQL字符串对象
                "select PID as '员工编号',Pname as '员工姓名',Pdep as '所属部门',PKpcontent as '考评内容',PKpResult as '考评结果',PKpscore as '考评分数',PKpPeople as '考评人',PKpDate as '考评日期' from tb_check";
            operate.BindDataGridView(dataGridView1, str);//绑定到DataGridView控件
            string num = "select count(*) from tb_check";//创建SQL字符串对象
            toolStripStatusLabel2.Text = operate.HumanNum(num).ToString();//显示考评记录数量信息
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                string id = dataGridView1.SelectedCells[0].Value.ToString();//得到ID信息
                string deletesql = "delete from tb_check where PID='"+id+"'";//创建SQL字符串
                if (operate.OperateData(deletesql) > 0)
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

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            string str =//创建SQL字符串
                "select PID as '员工编号',Pname as '员工姓名',Pdep as '所属部门',PKpcontent as '考评内容',PKpResult as '考评结果',PKpscore as '考评分数',PKpPeople as '考评人',PKpDate as '考评日期' from tb_check where Pname like '%"+toolStripTextBox1.Text+"%'";
            operate.BindDataGridView(dataGridView1, str);//绑定到DataGridView控件
            string num =//创建SQL字符串
                "select count(*) from tb_check where Pname like '%" + toolStripTextBox1.Text + "%' ";
            toolStripStatusLabel2.Text = operate.HumanNum(num).ToString();//显示考评记录数量
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                string id = dataGridView1.SelectedCells[0].Value.ToString();//得到ID信息
                string name = dataGridView1.SelectedCells[1].Value.ToString();//得到姓名信息
                frmUserCheckChange usercheckchange = new frmUserCheckChange();//创建考评管理窗体对象
                usercheckchange.pid = id;//设置字段信息
                usercheckchange.pname = name;//设置字段信息
                usercheckchange.ShowDialog();//显示模式窗体
            }
            else
            {
                MessageBox.Show("请选择要修改的信息", "提示",//弹出消息对话框
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;//退出事件
            }
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                string id = dataGridView1.SelectedCells[0].Value.ToString();//得到ID信息
                string name = dataGridView1.SelectedCells[1].Value.ToString();//得到用户名信息
                frmUserCheckChange usercheckchange = new frmUserCheckChange();//创建考评管理窗体对象
                usercheckchange.pid = id;//为字段赋值
                usercheckchange.pname = name;//为字段赋值
                usercheckchange.ShowDialog();//弹出模式窗体
            }
            else
            {
                MessageBox.Show("请选择要修改的信息", "提示",//弹出消息对话框
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;//退出事件
            }
        }

        private void toolStripLabel9_Click(object sender, EventArgs e)
        {
            PMS.PrintForm.frmUserCheckPrint usercheckprint =//创建打印窗体对象
                new PMS.PrintForm.frmUserCheckPrint();
            usercheckprint.ShowDialog();//弹出模式窗体
        }
    }
}