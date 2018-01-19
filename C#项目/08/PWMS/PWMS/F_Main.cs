using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PWMS
{
    public partial class F_Main : Form
    {
        DataClass.MyMeans MyClass = new PWMS.DataClass.MyMeans();
        ModuleClass.MyModule MyMenu = new PWMS.ModuleClass.MyModule();
        public F_Main()
        {
            InitializeComponent();
        }

        #region  通过权限对主窗体进行初始化
        /// <summary>
        /// 对主窗体初始化.
        /// </summary>
        private void Preen_Main()
        {
            statusStrip1.Items[2].Text = DataClass.MyMeans.Login_Name;  //在状态栏显示当前登录的用户名
            treeView1.Nodes.Clear();
            MyMenu.GetMenu(treeView1, menuStrip1);  //调用公共类MyModule下的GetMenu()方法，将menuStrip1控件的子菜单添加到treeView1控件中
            MyMenu.MainMenuF(menuStrip1);   //将菜单栏中的各子菜单项设为不可用状态
            MyMenu.MainPope(menuStrip1, DataClass.MyMeans.Login_Name);  //根据权限设置相应子菜单的可用状态
        }
        #endregion

        private void F_Main_Load(object sender, EventArgs e)
        {
            F_Login FrmLogin = new F_Login();   //声时登录窗体，进行调用
            FrmLogin.Tag = 1;   //将登录窗体的Tag属性设为1，表示调用的是登录窗体
            FrmLogin.ShowDialog();
            FrmLogin.Dispose();
            //当调用的是登录窗体时
            if (DataClass.MyMeans.Login_n == 1)
            {
                Preen_Main();   //自定义方法，通过权限对窗体进行初始化
                MyMenu.PactDay(1);  //MyModule类中的自定义方法，用于查找指定时间内，过生日的职工
                MyMenu.PactDay(2);  //MyModule类中的自定义方法，用于查找合同到期的职工
            }
            DataClass.MyMeans.Login_n = 3;  //将公共变量设为3，便于控制登录窗体的关闭
        }

        private void F_Main_Activated(object sender, EventArgs e)
        {
            if (DataClass.MyMeans.Login_n == 2) //当调用的是重新登录窗体时
                Preen_Main();   //自定义方法，通过权限对窗体进行初始化
            DataClass.MyMeans.Login_n = 3;
        }

        private void 系统退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void Tool_Folk_Click(object sender, EventArgs e)
        {
            MyMenu.Show_Form(sender.ToString().Trim(), 2);
        }

        private void Tool_Stuffbusic_Click(object sender, EventArgs e)
        {
            MyMenu.Show_Form(sender.ToString().Trim(), 1);   //用MyModule公共类中的Show_Form()方法调用各窗体
        }

        private void Tool_ClewBirthday_Click(object sender, EventArgs e)
        {
            MyMenu.Show_Form(sender.ToString().Trim(), 1);
        }

        private void Tool_ClewBargain_Click(object sender, EventArgs e)
        {
            MyMenu.Show_Form(sender.ToString().Trim(), 1);
        }

        private void Tool_Stufind_Click(object sender, EventArgs e)
        {
            MyMenu.Show_Form(sender.ToString().Trim(), 1);
        }

        private void Tool_Stusum_Click(object sender, EventArgs e)
        {
            MyMenu.Show_Form(sender.ToString().Trim(), 1);
        }

        private void Tool_DayWordPad_Click(object sender, EventArgs e)
        {
            MyMenu.Show_Form(sender.ToString().Trim(), 1);
        }

        private void Tool_AddressBook_Click(object sender, EventArgs e)
        {
            MyMenu.Show_Form(sender.ToString().Trim(), 1);
        }

        private void Tool_Back_Click(object sender, EventArgs e)
        {
            MyMenu.Show_Form(sender.ToString().Trim(), 1);
        }

        private void Tool_Clear_Click(object sender, EventArgs e)
        {
            MyMenu.Show_Form(sender.ToString().Trim(), 1);
        }

        private void Tool_NewLogon_Click(object sender, EventArgs e)
        {
            MyMenu.Show_Form(sender.ToString().Trim(), 1);
        }

        private void Tool_Setup_Click(object sender, EventArgs e)
        {
            MyMenu.Show_Form(sender.ToString().Trim(), 1);
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Text.Trim() == "系统退出")   //如果当前节点的文本为“系统退出”
            {
                Application.Exit(); //关闭整个工程
            }
            MyMenu.TreeMenuF(menuStrip1, e);   //用MyModule公共类中的TreeMenuF()方法调用各窗体
        }

        private void Button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_Stuffbusic_Click(object sender, EventArgs e)
        {
            if (Tool_Stuffbusic.Enabled==true)
                Tool_Stuffbusic_Click(sender, e);
            else
                MessageBox.Show("当前用户无权限调用" + "\"" + ((ToolStripButton)sender).Text + "\"" + "窗体");

        }

        private void Button_Stufind_Click(object sender, EventArgs e)
        {
            if (Tool_Stufind.Enabled == true)
                Tool_Stufind_Click(sender, e);
            else
                MessageBox.Show("当前用户无权限调用" + "\"" + ((ToolStripButton)sender).Text + "\"" + "窗体");
        }

        private void Button_ClewBargain_Click(object sender, EventArgs e)
        {
            if (Tool_ClewBargain.Enabled == true)
                Tool_ClewBargain_Click(sender, e);
            else
                MessageBox.Show("当前用户无权限调用" + "\"" + ((ToolStripButton)sender).Text + "\"" + "窗体");

        }

        private void Botton_AddressBook_Click(object sender, EventArgs e)
        {
            if (Tool_AddressBook.Enabled == true)
                Tool_AddressBook_Click(sender, e);
            else
                MessageBox.Show("当前用户无权限调用" + "\"" + ((ToolStripButton)sender).Text + "\"" + "窗体");
        }

        private void Botton_DayWordPad_Click(object sender, EventArgs e)
        {
            if (Tool_DayWordPad.Enabled == true)
                Tool_DayWordPad_Click(sender, e);
            else
                MessageBox.Show("当前用户无权限调用" + "\"" + ((ToolStripButton)sender).Text + "\"" + "窗体");
        }

        private void Tool_Counter_Click(object sender, EventArgs e)
        {
            MyMenu.Show_Form(sender.ToString().Trim(), 1);
        }

        private void Tool_WordBook_Click(object sender, EventArgs e)
        {
            MyMenu.Show_Form(sender.ToString().Trim(), 1);
        }

    }
}