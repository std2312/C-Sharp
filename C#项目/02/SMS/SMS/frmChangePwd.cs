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
    public partial class frmChangePwd : Form
    {
        public frmChangePwd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("���벻��λ��");
            }
            else
            {
                if (textBox2.Text == "" || textBox2.Text != textBox1.Text)
                {
                    MessageBox.Show("�������벻һ��");
                }
                else
                {
                    OleDbConnection conn = BaseClass.ConnClass.DataConn();
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand("update tb_Admin set [AdminUserPwd]='" + textBox1.Text + "'", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    if (MessageBox.Show("�����޸ĳɹ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmChangePwd_Load(object sender, EventArgs e)
        {

        }
    }
}