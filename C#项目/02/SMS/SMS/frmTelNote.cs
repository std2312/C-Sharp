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
    public partial class frmTelNote : Form
    {
        public frmTelNote()
        {
            InitializeComponent();
        }

        private void frmTelNote_Load(object sender, EventArgs e)
        {
            OleDbConnection conn = BaseClass.ConnClass.DataConn();
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("select * from tb_tel", conn);
            OleDbDataReader sdr = cmd.ExecuteReader();
            TreeNode newNode1 = treeView1.Nodes.Add("电话簿");
            newNode1.Checked = true;
            while (sdr.Read())
            {
                newNode1.Nodes.Add(sdr[1].ToString());
            }
            sdr.Close();
            conn.Close();
            treeView1.ExpandAll();
            treeView1.SelectedNode = treeView1.Nodes[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.Text == "电话簿")
            {
                MessageBox.Show("请选择用户");
                return;
            }
            else
            {
                if (listBox2.Items.Count == 0)
                {
                    listBox2.Items.Add(treeView1.SelectedNode.Text);
                }
                else
                {
                    for (int i = 0; i < listBox2.Items.Count; i++)
                    {
                        if (treeView1.SelectedNode.Text == listBox2.Items[i].ToString())
                        {
                            MessageBox.Show("已经添加过了");
                            return;
                        }
                    }
                    listBox2.Items.Add(treeView1.SelectedNode.Text);
                }
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            listBox2.Items.Remove(listBox2.SelectedItem);
        }
        public static string num;
        private void AddUser(string name)
        {
            OleDbConnection conn = BaseClass.ConnClass.DataConn();
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("select * from tb_tel where [UserName]='"+name+"'",conn);
            OleDbDataReader sdr = cmd.ExecuteReader();
            sdr.Read();
            num = sdr["UserTel"].ToString();
            conn.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                AddUser(listBox2.Items[i].ToString());
                frmSendSMS sms = (frmSendSMS)this.Owner;
                sms.lvInceptNum.Items.Add(num);
            }
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}