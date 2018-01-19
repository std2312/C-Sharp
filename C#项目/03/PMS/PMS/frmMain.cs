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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public string User;//声明用户名称字段
        public string Logintime;//声明登陆时间字段
        DBOperate operate = new DBOperate();//创建数据库操作对象
        private void frmMain_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = User;//显示用户名
            toolStripStatusLabel5.Text = Logintime;//显示登陆时间
            toolStripMenuItem1.Text = DateTime.Now.ToLongTimeString();//显示系统时间
            string sql = "select * from tb_User where UserName='"+User+"'";//设置数据库查询字符串
            DataSet ds = operate.GetTable(sql);//得到数据集
            string power = ds.Tables[0].Rows[0][3].ToString();//得到用户权限字符串
            if (power == "一般用户")//判断用户权限
            {
                系统管理ToolStripMenuItem.Enabled = false;//停用系统管理菜单
                操作员管理ToolStripMenuItem.Enabled = false;//停用操作员管理菜单
            }
        }

        private void 档案管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployee employee = new frmEmployee();//创建档案管理窗体对象
            employee.ShowDialog();//显示模式窗体
        }

        private void 数据备份ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDataBackup backup = new frmDataBackup();//创建数据备份窗体对象
            backup.ShowDialog();//显示模式窗体
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定退出本系统吗？", "提示",//弹出消息对话框
                MessageBoxButtons.OKCancel, 
                MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                Application.Exit();//退出应用程序
            }
        }

        private void 操作员管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOperator Foperate = new frmOperator();//创建操作员窗体对象
            Foperate.ShowDialog();//显示模式窗体
        }

        private void 修改口令ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePwd changepwd = new frmChangePwd();//创建修改口令窗体对象
            changepwd.MdiParent = this;//设置窗体对象的父窗体
            changepwd.name = User;//为窗体的字符赋值
            changepwd.Show();//显示窗体
        }

        private void 更改操作员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangeUser changeuser = new frmChangeUser();//创建更改操作员窗体对象
            changeuser.MdiParent = this;//设置窗体对象的父窗体
            changeuser.Show();//显示窗体
        }

        private void 奖罚管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserPrize prize = new frmUserPrize();//创建奖罚管理窗体对象
            prize.ShowDialog();//显示模式窗体
        }

        private void 部门管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDepManager depmanager = new frmDepManager();//创建部门管理窗体对象
            depmanager.ShowDialog();//显示模式窗体
        }

        private void 调动管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserRedeploy userredeploy = new frmUserRedeploy();//创建调动管理窗体对象
            userredeploy.ShowDialog();//显示模式窗体
        }

        private void 考评管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserCheck usercheck = new frmUserCheck();//创建考评管理窗体对象
            usercheck.ShowDialog();//显示模式窗体
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripMenuItem1.Text = DateTime.Now.ToLongTimeString();//动态显示系统时间
        }

        private void 考勤津贴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserKqManage kqmanage = new frmUserKqManage();//创建考勤津贴窗体对象
            kqmanage.ShowDialog();//显示模式窗体
        }

        private void 工资总结ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserPay userpay = new frmUserPay();//创建工资总结窗体对象
            userpay.ShowDialog();//显示模式窗体
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();//退出应用程序
        }
    }
}