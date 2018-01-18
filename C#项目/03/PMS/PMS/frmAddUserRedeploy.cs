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
    public partial class frmAddUserRedeploy : Form
    {
        public frmAddUserRedeploy()
        {
            InitializeComponent();
        }
        DBOperate operate = new DBOperate();//创建数据库操作对象
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();//关闭窗体
        }

        private void frmAddUserRedeploy_Load(object sender, EventArgs e)
        {
            operate.BindDropdownlist("tb_employee",cbbnum,1);//绑定所有的员工编号
            operate.BindDropdownlist("tb_department",cbbdep2,1);//绑定所有的部门名称
            operate.BindDropdownlist("tb_userJob",cbbjob2,1);//绑定所有的职务列表
        }

        private void cbbnum_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = cbbnum.Text;//得到ID信息
            string sql =//创建SQL字符串
                "select * from tb_employee where employeeID='"+id+"'";
            DataSet ds = operate.GetTable(sql);//得到数据集
            txtname.Text=ds.Tables[0].Rows[0][2].ToString();//显示名称信息
            txtdep1.Text = ds.Tables[0].Rows[0][4].ToString();//显示原部门信息
            txtjob1.Text = ds.Tables[0].Rows[0][8].ToString();//显示原职务信息
            txtpay1.Text = ds.Tables[0].Rows[0][12].ToString();//显示原工资信息
        }

        private void 增加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cbbnum.Text == "" || cbbdep2.Text == "" ||
                cbbjob2.Text == "" || txtNewPay.Text.Trim() == "" ||
                txtdate.Text == "" || txtexplain.Text.Trim() == "")
            {
                MessageBox.Show("请将信息填写完整", "提示",//弹出消息对话框
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;//退出事件
            }
            else
            {
                string sql =//创建SQL字符串
                    "select count(*) from tb_redeploy where UID='"+cbbnum.Text+"'";
                int i = operate.HumanNum(sql);//查找人数
                if (i > 0)
                {
                    MessageBox.Show("已经添加过该员工的调动信息",//弹出消息对话框
                        "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;//退出事件
                }
                else
                {
                    string update1 =//创建SQL字符串
                        "update tb_employee set employeeDept='" + cbbdep2.Text + "' where employeeID='" + cbbnum.Text + "'";
                    operate.OperateData(update1);//更新数据库信息
                    string Insertstr =//创建SQL字符串
                        "insert into tb_redeploy(UID,UName,URemoveDate,UOldDep,UNewDep,UOldJob,UNewJob,UOldPay,UNewPay,UPayExplain) values('"+cbbnum.Text+"','"+txtname.Text+"','"+txtdate.Text+"','"+txtdep1.Text+"','"+cbbdep2.Text+"','"+txtjob1.Text+"','"+cbbjob2.Text+"','"+txtpay1.Text+"','"+txtNewPay.Text.Trim()+"','"+txtexplain.Text+"')";
                    if (operate.OperateData(Insertstr) > 0)
                    {
                        MessageBox.Show("添加成功！", "提示",//弹出消息对话框
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    string updatestr =//创建SQL字符串
                        "update tb_employee set employeePay='" + txtNewPay.Text + "' where employeeID='"+cbbnum.Text+"'";
                    operate.OperateData(updatestr);//更新数据库信息
                }
            }
        }
        private void txtNewPay_KeyPress_1(object sender, KeyPressEventArgs e)
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