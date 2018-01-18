using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
namespace SMS
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtLoginName.Focus();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtLoginName.Text == "")
                {
                    MessageBox.Show("用户名不能为空");
                }
                else
                {
                    if (txtLoginPwd.Text == "")
                    {
                        MessageBox.Show("密码不能为空");
                    }
                    else
                    {
                        OleDbConnection conn = BaseClass.ConnClass.DataConn();
                        conn.Open();
                        OleDbCommand cmd = new OleDbCommand("select count(*) from tb_Admin where AdminUserName='" + txtLoginName.Text + "' and AdminUserPwd='" + txtLoginPwd.Text + "'", conn);
                        int i = Convert.ToInt32(cmd.ExecuteScalar());
                        if (i > 0)
                        {
                            frmMain main = new frmMain();
                            main.adminname = txtLoginName.Text;
                            main.admintime = DateTime.Now.ToShortDateString();
                            main.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("用户名或者密码错误");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtLoginPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnLogin_Click(sender,e);
            }
        }
    }
}