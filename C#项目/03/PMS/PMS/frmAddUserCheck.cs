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
    public partial class frmAddUserCheck : Form
    {
        public frmAddUserCheck()
        {
            InitializeComponent();
        }
        DBOperate operate = new DBOperate();//创建数据库操作对象
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();//关闭窗体
        }

        private void frmAddUserCheck_Load(object sender, EventArgs e)
        {
            operate.BindDropdownlist("tb_employee",cbbnum,1);//绑定ComboBox控件
        }

        private void cbbnum_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql =//创建SQL字符串
                "select * from tb_employee where employeeID='"+cbbnum.Text+"'";
            DataSet ds = operate.GetTable(sql);//得到数据集
            ds.Dispose();//释放资源
            txtdep.Text = ds.Tables[0].Rows[0][4].ToString();//得到门部信息
            txtname.Text = ds.Tables[0].Rows[0][2].ToString();//得到员工姓名
        }

        private void 添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cbbnum.Text == "" || txtcontent.Text == "" ||
                txtresult.Text == "" || txtkp.Text == "" ||
                txtscore.Text == "")
            {
                MessageBox.Show("请将信息填写完整", "提示",//弹出消息对话框
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;//退出事件
            }
            else
            {
                string sql =//创建SQL字符串
                    "select count(*) from tb_check where PID='"+cbbnum.Text+"'";
                int i = operate.HumanNum(sql);//查询指定员工考评信息
                if (i > 0)
                {
                    MessageBox.Show("该员工已经做过考评！",//弹出消息对话框
                        "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;//退出事件
                }
                else
                {
                    string addstr =//创建SQL字符串
                        "insert into tb_check(PID,Pname,Pdep,PKpcontent,PKpResult,PKpscore,PKpPeople,PKpDate) values('" + cbbnum.Text + "','" + txtname.Text + "','" + txtdep.Text + "','" + txtcontent.Text + "','" + txtresult.Text + "','" + txtscore.Text + "','" + txtkp.Text + "','" + txtkpdate.Text+ "')";
                    if (operate.OperateData(addstr) > 0)
                    {
                        MessageBox.Show("添加成功！", "提示",//弹出消息对话框
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void txtscore_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("只能输入数字", "提示",//弹出消息对话框
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;//已经处理过此事件
            }
        }

        private void txtscore_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtscore.Text == "")
                {
                    MessageBox.Show("分数不能为空",//弹出消息对话框
                        "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;//退出事件
                }
                else
                {
                    if (Convert.ToInt32(txtscore.Text) > 100)
                    {
                        MessageBox.Show("满分为100分", "提示",//弹出消息对话框
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;//退出事件
                    }
                }
            }
            catch
            {
                MessageBox.Show("输入有误！", "提示",//弹出消息对话框
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}