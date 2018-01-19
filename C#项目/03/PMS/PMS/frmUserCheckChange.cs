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
    public partial class frmUserCheckChange : Form
    {
        public frmUserCheckChange()
        {
            InitializeComponent();
        }
        DBOperate operate = new DBOperate();//创建数据库操作对象
        public string pid;//声明字段
        public string pname;//声明字段
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();//关闭窗体
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtcontent.Text == "" || txtresult.Text == "" ||
                txtscore.Text == "" || txtkp.Text == "")
            {
                MessageBox.Show("请将信息填写完整", "提示",//弹出消息对话框
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;//退出事件
            }
            else
            {
                string sql =//创建SQL字符串
                    "update tb_check set PKpcontent='"+txtcontent.Text+"',PKpResult='"+txtresult.Text+"',PKpscore='"+txtscore.Text+"',PKpPeople='"+txtkp.Text+"',PKpDate='"+txtkpdate.Text+"' where PID='"+cbbnum.Text+"'";
                if (operate.OperateData(sql) > 0)
                {
                    MessageBox.Show("修改成功！", "提示",//弹出消息对话框
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void frmUserCheckChange_Load(object sender, EventArgs e)
        {
            this.Text = "考评管理[" + pname + "]";//设置窗体标题
            operate.BindDropdownlist("tb_employee", cbbnum, 1);//绑定ComboBox控件
            string sql = //创建SQL字符串
                "select * from tb_check where PID='" + pid+ "'";
            DataSet ds = operate.GetTable(sql);//得到数据集
            ds.Dispose();//释放资源
            cbbnum.SelectedItem=ds.Tables[0].Rows[0][1].ToString();//设置员工编号
            txtname.Text = ds.Tables[0].Rows[0][2].ToString();//设置员工姓名
            txtdep.Text = ds.Tables[0].Rows[0][3].ToString();//设置员工所在部门
            txtcontent.Text = ds.Tables[0].Rows[0][4].ToString();//设置考评内容
            txtresult.Text = ds.Tables[0].Rows[0][5].ToString();//设置考评结果
            txtscore.Text = ds.Tables[0].Rows[0][6].ToString();//设置考评分数
            txtkp.Text = ds.Tables[0].Rows[0][7].ToString();//设置考评人
            txtkpdate.Text = ds.Tables[0].Rows[0][8].ToString();//设置考评日期

        }

        private void txtscore_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("只能输入数字", "提示",//弹出消息对话框
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;//已经处理该事件
            }
        }

        private void txtscore_TextChanged(object sender, EventArgs e)
        {
            if (txtscore.Text == "")
            {
                MessageBox.Show("分数不能为空", "提示",//弹出消息对话框
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}