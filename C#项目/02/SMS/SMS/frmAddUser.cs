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
    public partial class frmAddUser : Form
    {
        public frmAddUser()
        {
            InitializeComponent();
        }

        private void frmAddUser_Load(object sender, EventArgs e)
        {
            cbbSex.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != 8 && !char.IsDigit(e.KeyChar)) && e.KeyChar != 13)
            {
                MessageBox.Show("请输入数字");
                e.Handled = true;
            }
        }
        private void pbSubmit_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("请输入姓名");
            }
            else
            {
                if (txtNum.Text.Length < 11)
                {
                    MessageBox.Show("电话号码位11位");
                }
                else
                {
                    OleDbConnection conn = BaseClass.ConnClass.DataConn();
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand("insert into tb_tel([UserName],[UserSex],[UserTel]) values('" + txtName.Text + "','" + cbbSex.SelectedItem.ToString() + "','" + txtNum.Text + "')", conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("增加联系人成功");
                    txtName.Text = "";
                    txtNum.Text = "";
                    conn.Close();
                }
            }
        }

        private void pbConcel_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtNum.Text = "";
        }
    }
}