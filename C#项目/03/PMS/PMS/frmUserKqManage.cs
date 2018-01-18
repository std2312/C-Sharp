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
    public partial class frmUserKqManage : Form
    {
        public frmUserKqManage()
        {
            InitializeComponent();
        }
        DBOperate operate = new DBOperate();//创建数据库操作对象
        public string Ydate;//声明字段
        private void frmUserKqManage_Load(object sender, EventArgs e)
        {
            operate.BindDropdownlist("tb_employee",cbbYnum,1);
            for (int i = 1; i <= 12; i++)
            {
                toolStripComboBox1.Items.Add(i+"月");//添加月份
            }
        }

        private void cbbYnum_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = cbbYnum.Text;//得到ID信息
            string sql =//创建SQL字符串
                "select * from tb_employee where employeeID='" + id + "'";
            DataSet ds = operate.GetTable(sql);//得到数据集
            ds.Dispose();//释放资源
            txtYname.Text = ds.Tables[0].Rows[0][2].ToString();//得到姓名信息
            txtYsex.Text = ds.Tables[0].Rows[0][3].ToString();//得到性别信息
            txtYdep.Text = ds.Tables[0].Rows[0][4].ToString();//得到部门信息
            txtYzhiwu.Text = ds.Tables[0].Rows[0][8].ToString();//得到职务信息
            txtYbasepay.Text = ds.Tables[0].Rows[0][12].ToString();//得到基本工资信息
            switch (txtYzhiwu.Text)
            {
                case "总经理": txtYjintie.Text = "500"; break;//判断津贴
                case "副总经理": txtYjintie.Text = "400"; break;//判断津贴
                case "项目经理": txtYjintie.Text = "300"; break;//判断津贴
                case "部门经理": txtYjintie.Text = "200"; break;//判断津贴
                case "程序员": txtYjintie.Text = "100"; break;//判断津贴
                case "文员"://判断津贴
                case "后勤": txtYjintie.Text = "50"; break;//判断津贴
            }
            string sql1 =//创建SQL字符串
                "select * from tb_prize where UserID='"+id+"'";
            DataSet ds1 = operate.GetTable(sql1);//得到数据集
            ds.Dispose();//释放资源
            string str =//创建SQL字符串
                "select count(*) from tb_prize where UserID='" + id + "'";
            int i = operate.HumanNum(str);//获取记录数量
            if (i > 0)
            {
                if (ds1.Tables[0].Rows[0][8].ToString().Substring(6, 1) == Ydate)
                {
                    txtYjiangli.Text = ds1.Tables[0].Rows[0][6].ToString();//得到奖励信息
                    txtYfakuan.Text = ds1.Tables[0].Rows[0][7].ToString();//得到罚款信息
                }
                else
                {
                    txtYfakuan.Text = "0";//得到罚款信息
                    txtYjiangli.Text = "0";//得到奖励信息
                }
            }
            else
            {
                txtYfakuan.Text = "0";//得到罚款信息
                txtYjiangli.Text = "0";//得到奖励信息
            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            if (txtYjiaban.Text == "" || txtYquanqin.Text == "" ||
                toolStripComboBox1.Text == "" || cbbYnum.Text == "")
            {
                MessageBox.Show("请先选择工资的月份，然后将信息填写完整",//弹出消息对话框
                    "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string str =//创建SQL字符串
                    "select count(*) from tb_pay where YID='" + cbbYnum.Text + "' and YMonth='"+Ydate+"'";
                int i = operate.HumanNum(str);//得到记录数量
                if (i > 0)
                {
                    MessageBox.Show(Ydate + "月份" + txtYname.Text +//弹出消息对话框
                        "的工资已经做过统计", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {
                        string id = cbbYnum.Text;//员工编号
                        string name = txtYname.Text;//员工姓名
                        string sex = txtYsex.Text;//员工性别
                        string dep = txtYdep.Text;//员工部门
                        string zhiwu = txtYzhiwu.Text;//职务
                        string basepay = txtYbasepay.Text;//基本工资
                        string zhiwujintie = txtYjintie.Text;//职务津贴
                        string jiangli = txtYjiangli.Text;//奖金
                        string fakuan = txtYfakuan.Text;//罚款
                        string quanqin = txtYquanqin.Text;//全勤奖金
                        string jiaban = txtYjiaban.Text;//加班工资
                        string Ymonth = Ydate;//月份
                        decimal yingfa = Convert.ToDecimal(basepay) +//计算个人所得税
                            Convert.ToDecimal(zhiwujintie) + Convert.ToDecimal(jiangli)
                            - Convert.ToDecimal(fakuan) + Convert.ToDecimal(quanqin) +
                            Convert.ToDecimal(jiaban);//应发工资
                        decimal geren = operate.GYSD(Convert.ToInt32(yingfa));//计算个人所得税
                        decimal shifa = yingfa - geren;//实发工资
                        string sql =//创建SQL字符串
                            "insert into tb_pay(YID,YName,YSex,Ydep,YZhiwu,YBasePay,YJintie,Yjiangli,YFK,Yquanqin,Yjiaban,Yyingfa,Ygeren,Ypay,YMonth) values('" + id + "','" + name + "','" + sex + "','" + dep + "','" + zhiwu + "','" + basepay + "','" + zhiwujintie + "','" + jiangli + "','" + fakuan + "','" + quanqin + "','" + jiaban + "','" + yingfa + "','" + geren + "','" + shifa + "','" + Ydate + "')";
                        if (operate.OperateData(sql) > 0)
                        {
                            MessageBox.Show("添加成功", "提示",//弹出消息对话框
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)//捕获异常
                    {
                        MessageBox.Show(ex.Message);//弹出消息对话框
                    }
                }
            }
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbYnum.Enabled = true;//启用控件
            Ydate = toolStripComboBox1.SelectedItem.//得到月份信息
                ToString().Substring(0,1);
        }

        private void txtYquanqin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("只能输入数字", "提示",//弹出消息对话框
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;//已经处理过此事件
            }
        }

        private void txtYjiaban_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("只能输入数字", "提示",//弹出消息对话框
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;//已经处理过此事件
            }
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            this.Close();//关闭窗体
        }
    }
}