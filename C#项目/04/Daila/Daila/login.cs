using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Data.OleDb;
using Daila.NewClass;
using Daila.NewMehod;
namespace Daila
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        
        private void bntOK_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                MessageBox.Show("用户名不能为空！","提示");
                txtUser.Focus();
                return;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("密码不能为空！", "提示");
                txtPassword.Focus();
                return;
            }
            tbEmployeeClass tbClass = new tbEmployeeClass();
            tbClass.EmpEngish = txtUser.Text;
            tbClass.EmpPasword = txtPassword.Text;
            tbEmployeeMenthod tbMenhod=new tbEmployeeMenthod();
            if (tbMenhod.tbEmpLog(tbClass) == 1)
            {
                frmMain frman = new frmMain();
                frman.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("登录失败！","提示");
                txtPassword.Text = "";
                txtUser.Text = "";
            }
            
        }

        private void bntEsce_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}