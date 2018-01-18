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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public string adminname;
        public string admintime;
        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel5.Text = DateTime.Now.ToString();
            toolStripStatusLabel2.Text = adminname;
            toolStripStatusLabel8.Text = admintime;
            OleDbConnection conn = BaseClass.ConnClass.DataConn();
            OleDbCommand cmd = new OleDbCommand("select power from tb_Admin where AdminUserName='"+adminname+"'",conn);
            conn.Open();
            string userPower = Convert.ToString(cmd.ExecuteScalar());
            if (userPower == "0")
            {
                ��Ƭ����MToolStripMenuItem.Enabled = false;
                ���ż�¼SToolStripMenuItem.Enabled = false;
                ���ö���MToolStripMenuItem.Enabled = false;
            }
            conn.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel5.Text = DateTime.Now.ToString();
        }

        private void ����OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.MdiParent = this;
            ab.Show();
        }

        private void ���ж���GToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCydy fydy = new frmCydy();
            fydy.ShowDialog();
        }

        private void ��Ӷ���KToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddDy adddy = new frmAddDy();
            adddy.MdiParent = this;
            adddy.Show();
        }

        private void ������ϵ��CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTel tel = new frmTel();
            tel.MdiParent = this;
            tel.Show();
        }

        private void �ѷ��Ͷ���FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmYfxx yfxx = new frmYfxx();
            yfxx.MdiParent = this;
            yfxx.Show();
        }

        private void �ѽ��ն���GToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmResvice res = new frmResvice();
            res.MdiParent = this;
            res.Show();
        }

        private void �˳�ϵͳToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ȷ��Ҫ�˳���ϵͳ��", "����", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void �����޸�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePwd pwd = new frmChangePwd();
            pwd.MdiParent = this;
            pwd.Show();
        }

        private void ������ϵ��SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUser users = new frmAddUser();
            users.MdiParent = this;
            users.Show();
        }

        private void ����ϵͳToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLock formlock = new frmLock();
            formlock.Owner = this;
            formlock.ShowDialog();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show("ȷ��Ҫ�˳���ϵͳ��", "����", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                frmMain main = new frmMain();
                main.Show();
            }
        }
        private void ����Ⱥ��RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSendSMS sendsms = new frmSendSMS();
            sendsms.MdiParent = this;
            sendsms.Show();
        }
    }
}