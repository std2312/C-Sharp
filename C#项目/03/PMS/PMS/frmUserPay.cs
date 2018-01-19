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
    public partial class frmUserPay : Form
    {
        public frmUserPay()
        {
            InitializeComponent();
        }
        DBOperate operate = new DBOperate();//创建数据库操作对象
        private void toolStripLabel6_Click(object sender, EventArgs e)
        {
            this.Close();//关闭窗体
        }
        public string months;//声明字段
        private void frmUserPay_Load(object sender, EventArgs e)
        {
            string sql =//创建SQL字符串
                "select YID as '编号',YName as '姓名',YSex as '性别',Ydep as '部门',YZhiwu as '职务',YBasePay as '基本工资',YJintie as '职务津贴',Yjiangli as '奖励',YFK as '罚款',Yquanqin as '全勤奖金',Yjiaban as '加班工资',Yyingfa as '应发工资',Ygeren as '个人所得税',Ypay as '实发工资',YMonth as '统计月份' from tb_pay";
            operate.BindDataGridView(dataGridView1, sql);//绑定到DataGridView控件
            months = "";//设置为空字符串
            for (int i = 1; i <= 12; i++)
            {
                toolStripComboBox1.Items.Add(i + "月");//添加月份信息
            }
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            PrintForm.frmUserPayPrint payprint =//创建打印窗体对象
                new PMS.PrintForm.frmUserPayPrint();
            payprint.num = months;//为对象的字段赋值
            payprint.ShowDialog();//显示模式窗体
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string xmonth = toolStripComboBox1.SelectedItem.ToString().Substring(0, 1);//得到选择的月份
            string sql =//创建SQL字符串
                "select YID as '编号',YName as '姓名',YSex as '性别',Ydep as '部门',YZhiwu as '职务',YBasePay as '基本工资',YJintie as '职务津贴',Yjiangli as '奖励',YFK as '罚款',Yquanqin as '全勤奖金',Yjiaban as '加班工资',Yyingfa as '应发工资',Ygeren as '个人所得税',Ypay as '实发工资',YMonth as '统计月份' from tb_pay where YMonth='" + xmonth + "'";
            operate.BindDataGridView(dataGridView1, sql);//绑定到DataGridView控件
            months = "where YMonth='" + xmonth + "'";//创建SQL字符串
        }
    }
}