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
        public string User;//�����û������ֶ�
        public string Logintime;//������½ʱ���ֶ�
        DBOperate operate = new DBOperate();//�������ݿ��������
        private void frmMain_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = User;//��ʾ�û���
            toolStripStatusLabel5.Text = Logintime;//��ʾ��½ʱ��
            toolStripMenuItem1.Text = DateTime.Now.ToLongTimeString();//��ʾϵͳʱ��
            string sql = "select * from tb_User where UserName='"+User+"'";//�������ݿ��ѯ�ַ���
            DataSet ds = operate.GetTable(sql);//�õ����ݼ�
            string power = ds.Tables[0].Rows[0][3].ToString();//�õ��û�Ȩ���ַ���
            if (power == "һ���û�")//�ж��û�Ȩ��
            {
                ϵͳ����ToolStripMenuItem.Enabled = false;//ͣ��ϵͳ����˵�
                ����Ա����ToolStripMenuItem.Enabled = false;//ͣ�ò���Ա����˵�
            }
        }

        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployee employee = new frmEmployee();//�����������������
            employee.ShowDialog();//��ʾģʽ����
        }

        private void ���ݱ���ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDataBackup backup = new frmDataBackup();//�������ݱ��ݴ������
            backup.ShowDialog();//��ʾģʽ����
        }

        private void �˳�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ȷ���˳���ϵͳ��", "��ʾ",//������Ϣ�Ի���
                MessageBoxButtons.OKCancel, 
                MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                Application.Exit();//�˳�Ӧ�ó���
            }
        }

        private void ����Ա����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOperator Foperate = new frmOperator();//��������Ա�������
            Foperate.ShowDialog();//��ʾģʽ����
        }

        private void �޸Ŀ���ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePwd changepwd = new frmChangePwd();//�����޸Ŀ�������
            changepwd.MdiParent = this;//���ô������ĸ�����
            changepwd.name = User;//Ϊ������ַ���ֵ
            changepwd.Show();//��ʾ����
        }

        private void ���Ĳ���ԱToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangeUser changeuser = new frmChangeUser();//�������Ĳ���Ա�������
            changeuser.MdiParent = this;//���ô������ĸ�����
            changeuser.Show();//��ʾ����
        }

        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserPrize prize = new frmUserPrize();//�����������������
            prize.ShowDialog();//��ʾģʽ����
        }

        private void ���Ź���ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDepManager depmanager = new frmDepManager();//�������Ź��������
            depmanager.ShowDialog();//��ʾģʽ����
        }

        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserRedeploy userredeploy = new frmUserRedeploy();//�����������������
            userredeploy.ShowDialog();//��ʾģʽ����
        }

        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserCheck usercheck = new frmUserCheck();//�����������������
            usercheck.ShowDialog();//��ʾģʽ����
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripMenuItem1.Text = DateTime.Now.ToLongTimeString();//��̬��ʾϵͳʱ��
        }

        private void ���ڽ���ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserKqManage kqmanage = new frmUserKqManage();//�������ڽ����������
            kqmanage.ShowDialog();//��ʾģʽ����
        }

        private void �����ܽ�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserPay userpay = new frmUserPay();//���������ܽᴰ�����
            userpay.ShowDialog();//��ʾģʽ����
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();//�˳�Ӧ�ó���
        }
    }
}