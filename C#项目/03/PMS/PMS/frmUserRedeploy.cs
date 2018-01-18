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
    public partial class frmUserRedeploy : Form
    {
        public frmUserRedeploy()
        {
            InitializeComponent();
        }
        DBOperate operate = new DBOperate();//�������ݿ��������
        private void frmUserRedeploy_Load(object sender, EventArgs e)
        {
            string sql =//����SQL�ַ���
                "select UID as 'Ա�����',UName as 'Ա������',URemoveDate as '����ʱ��',UOldDep as 'ԭ����',UNewDep as '�ֲ���',UOldJob as 'ԭְ��',UNewJob as '��ְ��',UOldPay as 'ԭ����',UNewPay as '���ʵ���',UPayExplain as '����˵��' from tb_redeploy";
            operate.BindDataGridView(dataGridView1,sql);//�󶨵�DataGridView�ؼ�
            string num = "select count(*) from tb_redeploy";//����SQL�ַ���
            toolStripStatusLabel2.Text = operate.HumanNum(num).ToString();//��ʾ��������
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            frmAddUserRedeploy adduserredeploy = new frmAddUserRedeploy();//���������Ա�����������
            adduserredeploy.ShowDialog();//��ʾģʽ����
        }

        private void frmUserRedeploy_Activated(object sender, EventArgs e)
        {
            string sql = //����SQL�ַ���
                "select UID as 'Ա�����',UName as 'Ա������',URemoveDate as '����ʱ��',UOldDep as 'ԭ����',UNewDep as '�ֲ���',UOldJob as 'ԭְ��',UNewJob as '��ְ��',UOldPay as 'ԭ����',UNewPay as '���ʵ���',UPayExplain as '����˵��' from tb_redeploy";
            operate.BindDataGridView(dataGridView1, sql);//�󶨵�DataGridView�ؼ�
            string num =//��������
                "select count(*) from tb_redeploy";
            toolStripStatusLabel2.Text = operate.HumanNum(num).ToString();//��ʾ������Ϣ����
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                string sql =//����SQL�ַ���
                    "delete from tb_redeploy where UID='"+dataGridView1.SelectedCells[0].Value.ToString()+"'";
                if (operate.OperateData(sql)>0)
                {
                    MessageBox.Show("ɾ���ɹ�", "��ʾ",//������Ϣ�Ի���
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("��ѡ��Ҫɾ������Ϣ","��ʾ",//������Ϣ�Ի���
                    MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;//�˳��¼�
            }
        }

        private void toolStripLabel10_Click(object sender, EventArgs e)
        {
            this.Close();//�رմ���
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                string uid = dataGridView1.SelectedCells[0].Value.ToString();//�õ�ID
                string uname = dataGridView1.SelectedCells[1].Value.ToString();//�õ��û���
                frmChangeUserRedeploy changeuserredeploy =//������Ա������ϸ��Ϣ�������
                    new frmChangeUserRedeploy();
                changeuserredeploy.id = uid;//Ϊ�ֶθ�ֵ
                changeuserredeploy.name = uname;//Ϊ�ֶθ�ֵ
                changeuserredeploy.ShowDialog();//��ʾģʽ����
            }
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                string uid = dataGridView1.SelectedCells[0].Value.ToString();//�õ�ID��Ϣ
                string uname = dataGridView1.SelectedCells[1].Value.ToString();//�õ�������Ϣ
                frmChangeUserRedeploy changeuserredeploy =//������Ա������ϸ��Ϣ�������
                    new frmChangeUserRedeploy();
                changeuserredeploy.id = uid;//Ϊ�ֶθ�ֵ
                changeuserredeploy.name = uname;//Ϊ�ֶθ�ֵ
                changeuserredeploy.ShowDialog();//��ʾģʽ����
            }
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            string sql =//����SQL�ַ���
                "select UID as 'Ա�����',UName as 'Ա������',URemoveDate as '����ʱ��',UOldDep as 'ԭ����',UNewDep as '�ֲ���',UOldJob as 'ԭְ��',UNewJob as '��ְ��',UOldPay as 'ԭ����',UNewPay as '���ʵ���',UPayExplain as '����˵��' from tb_redeploy where UName like '%"+toolStripTextBox1.Text.Trim()+"%'";
            operate.BindDataGridView(dataGridView1, sql);//�󶨵�DataGridView�ؼ�
            string num =//����SQL�ַ���
                "select count(*) from tb_redeploy where UName like '%" + toolStripTextBox1.Text.Trim() + "%'";
            toolStripStatusLabel2.Text = operate.HumanNum(num).ToString();//��ʾ����������Ϣ
        }

        private void toolStripLabel9_Click(object sender, EventArgs e)
        {
            PrintForm.frmRedeployPrint redeploy =//������ӡ�������
                new PMS.PrintForm.frmRedeployPrint();
            redeploy.ShowDialog();//��ʾģʽ����
        }
    }
}