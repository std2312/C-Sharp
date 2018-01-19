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
    public partial class frmUserPrize : Form
    {
        public frmUserPrize()
        {
            InitializeComponent();
        }
        DBOperate operate = new DBOperate();//创建数据库操作对象
        private void frmUserPrize_Load(object sender, EventArgs e)
        {
            string getJFstr = //创建SQL字符串
                "select UserID as '员工编号',UserName as '员工姓名',UserDep as '所属部门',UserJF as '奖/罚',UserJFcontent as '奖罚内容',UserJLMoney as '奖励金额',UserFKMoney as '罚款金额',UserJFDate as '奖罚日期',UserCXDate as '撤销日期' from tb_prize";
            operate.BindDataGridView(dataGridView1,getJFstr);//绑定到DataGridView控件
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();//关闭窗体
        }

        private void 增加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmJFmanage fjmanage = new frmJFmanage();//创建奖罚管理窗体对象
            fjmanage.ShowDialog();//弹出模式对话框
        }

        private void frmUserPrize_Activated(object sender, EventArgs e)
        {
            frmUserPrize_Load(sender, e);//执行窗体Load事件
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            string getJFstr =//创建SQL字符串
                "select UserID as '员工编号',UserName as '员工姓名',UserDep as '所属部门',UserJF as '奖/罚',UserJFcontent as '奖罚内容',UserJLMoney as '奖励金额',UserFKMoney as '罚款金额',UserJFDate as '奖罚日期',UserCXDate as '撤销日期' from tb_prize where UserName like '%"+toolStripTextBox1.Text.Trim()+"%'";
            operate.BindDataGridView(dataGridView1, getJFstr);//绑定到DataGridView控件
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 0)
            {
                MessageBox.Show("请选择要删除的信息", "提示",//弹出消息对话框
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;//退出事件
            }
            else
            {
                string id = dataGridView1.SelectedCells[0].Value.ToString();//获取员工编号
                string sql = //创建SQL字符串
                    "delete from tb_prize where UserID='"+id+"'";
                operate.OperateData(sql);//删除奖罚信息
                MessageBox.Show("删除成功", "提示",//弹出消息对话框
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.SelectedCells[0].Value.ToString();//得到ID
            string name = dataGridView1.SelectedCells[1].Value.ToString();//得到名称
            frmChangePrize prize = new frmChangePrize();//创建更改奖罚窗体对象
            prize.Uid = id;//为字段赋值
            prize.Uname = name;//为字段赋值
            prize.ShowDialog();//弹出模式窗体
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 0)
            {
                MessageBox.Show("请选择要修改的信息", "提示",//弹出消息对话框
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;//退出事件
            }
            else
            {
                string id = dataGridView1.SelectedCells[0].Value.ToString();//得到ID
                string name = dataGridView1.SelectedCells[1].Value.ToString();//得到名称
                frmChangePrize prize = new frmChangePrize();//创建更改奖罚窗体对象
                prize.Uid = id;//为字段赋值
                prize.Uname = name;//为字段赋值
                prize.ShowDialog();//弹出模式窗体
            }
        }

        private void 打印ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintForm.frmPrizePrint prize = new PMS.PrintForm.frmPrizePrint();//创建打印窗体对象
            prize.ShowDialog();//显示模式窗体
        }
    }
}