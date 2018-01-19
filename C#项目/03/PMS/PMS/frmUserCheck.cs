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
    public partial class frmUserCheck : Form
    {
        public frmUserCheck()
        {
            InitializeComponent();
        }
        DBOperate operate = new DBOperate();//�������ݿ��������
        private void frmUserCheck_Load(object sender, EventArgs e)
        {
            string str =//����SQL�ַ���
                "select PID as 'Ա�����',Pname as 'Ա������',Pdep as '��������',PKpcontent as '��������',PKpResult as '�������',PKpscore as '��������',PKpPeople as '������',PKpDate as '��������' from tb_check";
            operate.BindDataGridView(dataGridView1,str);//�󶨵�DataGridView�ؼ�
            string num = "select count(*) from tb_check";//����������Ϣ
            toolStripStatusLabel2.Text = operate.HumanNum(num).ToString();//��ʾ������¼����
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            frmAddUserCheck addusercheck = new frmAddUserCheck();//������Ա�����������
            addusercheck.ShowDialog();//��ʾģʽ����
        }

        private void frmUserCheck_Activated(object sender, EventArgs e)
        {
            string str =//����SQL�ַ�������
                "select PID as 'Ա�����',Pname as 'Ա������',Pdep as '��������',PKpcontent as '��������',PKpResult as '�������',PKpscore as '��������',PKpPeople as '������',PKpDate as '��������' from tb_check";
            operate.BindDataGridView(dataGridView1, str);//�󶨵�DataGridView�ؼ�
            string num = "select count(*) from tb_check";//����SQL�ַ�������
            toolStripStatusLabel2.Text = operate.HumanNum(num).ToString();//��ʾ������¼������Ϣ
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                string id = dataGridView1.SelectedCells[0].Value.ToString();//�õ�ID��Ϣ
                string deletesql = "delete from tb_check where PID='"+id+"'";//����SQL�ַ���
                if (operate.OperateData(deletesql) > 0)
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

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            string str =//����SQL�ַ���
                "select PID as 'Ա�����',Pname as 'Ա������',Pdep as '��������',PKpcontent as '��������',PKpResult as '�������',PKpscore as '��������',PKpPeople as '������',PKpDate as '��������' from tb_check where Pname like '%"+toolStripTextBox1.Text+"%'";
            operate.BindDataGridView(dataGridView1, str);//�󶨵�DataGridView�ؼ�
            string num =//����SQL�ַ���
                "select count(*) from tb_check where Pname like '%" + toolStripTextBox1.Text + "%' ";
            toolStripStatusLabel2.Text = operate.HumanNum(num).ToString();//��ʾ������¼����
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                string id = dataGridView1.SelectedCells[0].Value.ToString();//�õ�ID��Ϣ
                string name = dataGridView1.SelectedCells[1].Value.ToString();//�õ�������Ϣ
                frmUserCheckChange usercheckchange = new frmUserCheckChange();//�����������������
                usercheckchange.pid = id;//�����ֶ���Ϣ
                usercheckchange.pname = name;//�����ֶ���Ϣ
                usercheckchange.ShowDialog();//��ʾģʽ����
            }
            else
            {
                MessageBox.Show("��ѡ��Ҫ�޸ĵ���Ϣ", "��ʾ",//������Ϣ�Ի���
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;//�˳��¼�
            }
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                string id = dataGridView1.SelectedCells[0].Value.ToString();//�õ�ID��Ϣ
                string name = dataGridView1.SelectedCells[1].Value.ToString();//�õ��û�����Ϣ
                frmUserCheckChange usercheckchange = new frmUserCheckChange();//�����������������
                usercheckchange.pid = id;//Ϊ�ֶθ�ֵ
                usercheckchange.pname = name;//Ϊ�ֶθ�ֵ
                usercheckchange.ShowDialog();//����ģʽ����
            }
            else
            {
                MessageBox.Show("��ѡ��Ҫ�޸ĵ���Ϣ", "��ʾ",//������Ϣ�Ի���
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;//�˳��¼�
            }
        }

        private void toolStripLabel9_Click(object sender, EventArgs e)
        {
            PMS.PrintForm.frmUserCheckPrint usercheckprint =//������ӡ�������
                new PMS.PrintForm.frmUserCheckPrint();
            usercheckprint.ShowDialog();//����ģʽ����
        }
    }
}