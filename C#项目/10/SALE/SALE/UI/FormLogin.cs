using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SALE.Common;
using SALE.DAL;

namespace SALE.UI
{
    public partial class FormLogin : Form
    {
        Useful useful = new Useful();
        DataLogic dal = new DataLogic();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
            useful.SetFocus(e, txtPwd);
        }

        private void txtPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                picLogin_Click(sender, e);  //把e传递给EventArgs是多态的特性
            }
        }

        private void picLogin_Click(object sender, EventArgs e)
        {
            SqlDataReader sdr = null;
            if (String.IsNullOrEmpty(txtCode.Text.Trim()))
            {
                MessageBox.Show("登录用户不许为空！","软件提示");
                txtCode.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtPwd.Text))
            {
                MessageBox.Show("登录密码不许为空！", "软件提示");
                txtPwd.Focus();
                return;
            }
            //用户编码不重复
            string strSql = "select * from Operator where OperatorCode = '" + txtCode.Text.Trim() + "'";
            try
            {
                sdr = dal.GetDataReader(strSql);
                if (!sdr.HasRows)  //若该用户编码无数据记录
                {
                    MessageBox.Show("登录用户不正确！","软件提示");
                    txtCode.Focus();
                }
                else
                {
                    sdr.Read(); //读取唯一的一行记录
                    if (!(txtPwd.Text == sdr["Password"].ToString()))  //若密码不相同
                    {
                        MessageBox.Show("登录密码不正确！", "软件提示");
                        txtPwd.Focus();
                    }
                    else
                    {
                        GlobalProperty.OperatorCode = sdr["OperatorCode"].ToString();
                        GlobalProperty.OperatorName = sdr["OperatorName"].ToString();
                        GlobalProperty.Password = sdr["Password"].ToString();
                        GlobalProperty.IsFlag = sdr["IsFlag"].ToString();
                        this.Hide();
                        FormAppMain formAppMain = new FormAppMain();
                        formAppMain.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"软件提示");
            }
            finally
            {
                sdr.Close();
            }
        }

        private void picReset_Click(object sender, EventArgs e)
        {
            txtCode.Text = "";
            txtPwd.Text = "";
        }

        private void picQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
