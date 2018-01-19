using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PMS.PMSClass;
using System.Text.RegularExpressions;
namespace PMS
{
    public partial class frmChangeUserRedeploy : Form
    {
        public frmChangeUserRedeploy()
        {
            InitializeComponent();
        }
        DBOperate operate = new DBOperate();//创建数据库操作对象
        public string id;//声明id字段
        public string name;//声明name字段
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();//关闭窗体
        }

        private void frmChangeUserRedeploy_Load(object sender, EventArgs e)
        {
            this.Text = "人员调动详细信息["+name+"]";//显示窗体标题
            operate.BindDropdownlist("tb_employee",cbbnum,1);//绑定到ComboBox控件
            operate.BindDropdownlist("tb_department", cbbdep2, 1);//绑定到ComboBox控件
            operate.BindDropdownlist("tb_userJob", cbbjob2, 1);//绑定到ComboBox控件
            string sql =//创建SQL字符串
                "select * from tb_redeploy where UID='"+id+"'";
            DataSet ds = operate.GetTable(sql);//得到数据集
            ds.Dispose();//释放资源
            cbbnum.Text = ds.Tables[0].Rows[0][1].ToString();//得到员工编号信息
            txtname.Text = ds.Tables[0].Rows[0][2].ToString();//得到员工姓名信息
            txtdep1.Text = ds.Tables[0].Rows[0][4].ToString();//得到原部门信息
            cbbdep2.SelectedItem = ds.Tables[0].Rows[0][5].ToString();//得到现部门信息
            txtjob1.Text = ds.Tables[0].Rows[0][6].ToString();//得到原职务信息
            cbbjob2.SelectedItem=ds.Tables[0].Rows[0][7].ToString();//得到现职务信息
            txtpay1.Text = ds.Tables[0].Rows[0][8].ToString();//得到原工资信息
            txtNewPay.Text = ds.Tables[0].Rows[0][9].ToString();//得到工资调整信息
            txtdate.Text = ds.Tables[0].Rows[0][3].ToString();//得到日期信息
            txtexplain.Text = ds.Tables[0].Rows[0][10].ToString();//得到调动说明信息
        }

        private void 增加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
             if (cbbdep2.Text == "" || cbbjob2.Text == "" ||
                 txtNewPay.Text == "" || txtdate.Text == "" ||
                 txtexplain.Text == "")
             {
                 MessageBox.Show("请将信息填写完整！",//弹出消息对话框
                     "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
             else
             {
                 string updatestr =//创建SQL字符串
                     "update tb_redeploy set UNewDep='"+cbbdep2.Text+"',UNewJob='"+cbbjob2.Text+"',UNewPay='"+txtNewPay.Text.Trim()+"',URemoveDate='"+txtdate.Text+"',UPayExplain='"+txtexplain.Text+"' where UID='"+cbbnum.Text+"'";
                 if (operate.OperateData(updatestr) > 0)
                 {
                     MessageBox.Show("修改成功！", "提示",//弹出消息对话框
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                 }
             }
        }

        private void txtNewPay_KeyPress(object sender, KeyPressEventArgs e)
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