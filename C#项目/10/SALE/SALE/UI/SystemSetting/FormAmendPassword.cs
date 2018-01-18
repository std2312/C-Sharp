using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SALE.Common;
using SALE.DAL;

namespace SALE.UI.SystemSetting
{
    public partial class FormAmendPassword : Form
    {
        public FormAmendPassword()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            errAffirmPassword.Clear();
            errOldPassword.Clear();
            errPassword.Clear();
            if (String.IsNullOrEmpty(txtOldPassword.Text))
            {
                try
                {
                    errOldPassword.SetError(txtOldPassword, "原密码不能为空！");
                    txtOldPassword.Focus();
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "软件提示");
                }
            }
            else
            {
                if (!(txtOldPassword.Text == GlobalProperty.Password))
                {
                    try
                    {
                        errOldPassword.SetError(txtOldPassword, "原密码不正确！");
                        txtOldPassword.Focus();
                        return;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "软件提示");
                    }
                }
            }
            if (String.IsNullOrEmpty(txtPassword.Text))
            {
                try
                {
                    errPassword.SetError(txtPassword, "新密码不能为空！");
                    txtPassword.Focus();
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "软件提示");
                }
            }
            if (!(txtAffirmPassWord.Text == txtPassword.Text))
            {
                try
                {
                    errAffirmPassword.SetError(txtAffirmPassWord, "确认密码与新密码不相同！");
                    txtAffirmPassWord.Focus();
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "软件提示");
                }
            }
            string strSql = "Update Operator Set Password = '" + txtPassword.Text + "' Where OperatorCode = '" + GlobalProperty.OperatorCode + "'";
            try
            {
                if (new DataLogic().ExecDataBySql(strSql) > 0)
                {
                    MessageBox.Show("密码修改成功！", "软体提示");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("密码修改失败！", "软体提示");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "软体提示");
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
