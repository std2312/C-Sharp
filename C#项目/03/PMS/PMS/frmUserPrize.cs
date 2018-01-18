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
    public partial class frmUserPrize : Form
    {
        public frmUserPrize()
        {
            InitializeComponent();
        }
        DBOperate operate = new DBOperate();//�������ݿ��������
        private void frmUserPrize_Load(object sender, EventArgs e)
        {
            string getJFstr = //����SQL�ַ���
                "select UserID as 'Ա�����',UserName as 'Ա������',UserDep as '��������',UserJF as '��/��',UserJFcontent as '��������',UserJLMoney as '�������',UserFKMoney as '������',UserJFDate as '��������',UserCXDate as '��������' from tb_prize";
            operate.BindDataGridView(dataGridView1,getJFstr);//�󶨵�DataGridView�ؼ�
        }

        private void �˳�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();//�رմ���
        }

        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmJFmanage fjmanage = new frmJFmanage();//�����������������
            fjmanage.ShowDialog();//����ģʽ�Ի���
        }

        private void frmUserPrize_Activated(object sender, EventArgs e)
        {
            frmUserPrize_Load(sender, e);//ִ�д���Load�¼�
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            string getJFstr =//����SQL�ַ���
                "select UserID as 'Ա�����',UserName as 'Ա������',UserDep as '��������',UserJF as '��/��',UserJFcontent as '��������',UserJLMoney as '�������',UserFKMoney as '������',UserJFDate as '��������',UserCXDate as '��������' from tb_prize where UserName like '%"+toolStripTextBox1.Text.Trim()+"%'";
            operate.BindDataGridView(dataGridView1, getJFstr);//�󶨵�DataGridView�ؼ�
        }

        private void ɾ��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 0)
            {
                MessageBox.Show("��ѡ��Ҫɾ������Ϣ", "��ʾ",//������Ϣ�Ի���
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;//�˳��¼�
            }
            else
            {
                string id = dataGridView1.SelectedCells[0].Value.ToString();//��ȡԱ�����
                string sql = //����SQL�ַ���
                    "delete from tb_prize where UserID='"+id+"'";
                operate.OperateData(sql);//ɾ��������Ϣ
                MessageBox.Show("ɾ���ɹ�", "��ʾ",//������Ϣ�Ի���
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.SelectedCells[0].Value.ToString();//�õ�ID
            string name = dataGridView1.SelectedCells[1].Value.ToString();//�õ�����
            frmChangePrize prize = new frmChangePrize();//�������Ľ����������
            prize.Uid = id;//Ϊ�ֶθ�ֵ
            prize.Uname = name;//Ϊ�ֶθ�ֵ
            prize.ShowDialog();//����ģʽ����
        }

        private void �޸�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 0)
            {
                MessageBox.Show("��ѡ��Ҫ�޸ĵ���Ϣ", "��ʾ",//������Ϣ�Ի���
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;//�˳��¼�
            }
            else
            {
                string id = dataGridView1.SelectedCells[0].Value.ToString();//�õ�ID
                string name = dataGridView1.SelectedCells[1].Value.ToString();//�õ�����
                frmChangePrize prize = new frmChangePrize();//�������Ľ����������
                prize.Uid = id;//Ϊ�ֶθ�ֵ
                prize.Uname = name;//Ϊ�ֶθ�ֵ
                prize.ShowDialog();//����ģʽ����
            }
        }

        private void ��ӡToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintForm.frmPrizePrint prize = new PMS.PrintForm.frmPrizePrint();//������ӡ�������
            prize.ShowDialog();//��ʾģʽ����
        }
    }
}