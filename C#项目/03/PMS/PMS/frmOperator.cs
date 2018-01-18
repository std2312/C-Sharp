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
    public partial class frmOperator : Form
    {
        public frmOperator()
        {
            InitializeComponent();
        }
        DBOperate operate = new DBOperate();//�������ݿ��������
        private void �˳�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();//�رմ���
        }

        private void frmOperator_Load(object sender, EventArgs e)
        {
            string getUser =//����SQL�ַ���
                "select UserName as '�û���',UserPwd as '����',UserPower as 'Ȩ��' from  tb_User";
            operate.BindDataGridView(dataGridView1,getUser);//�󶨵�DataGridView�ؼ�
            dataGridView1.Columns[0].Width = 88;//�����п��
            dataGridView1.Columns[1].Width = 85;//�����п��
            dataGridView1.Columns[2].Width = 88;//�����п��
            comboBox1.SelectedIndex = 0;//����Ĭ��ѡ����
        }

        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                txtOUser.Enabled = true;//�����ı���ؼ�
                txtOPwd.Enabled = true;//�����ı���ؼ�
                comboBox1.Enabled = true;//����ComboBox�ؼ�
                string str =//����SQL�ַ���
                    "select count(*) from tb_User where UserName='"+txtOUser.Text.Trim()+"'";
                int i = operate.HumanNum(str);//�õ���¼����
                if (i > 0)
                {
                    MessageBox.Show("����Ա���ڣ�", "��ʾ",//������Ϣ�Ի���
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;//�˳��¼�
                }
                else
                {
                    if (txtOUser.Text.Trim() == "" || txtOPwd.Text.Trim() == "")
                    {
                        MessageBox.Show("��Ϣ��������", "��ʾ",//������Ϣ�Ի���
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;//�˳��¼�
                    }
                    else
                    {
                        string InsertSql =//����SQL�ַ���
                            "insert into tb_User(UserName,UserPwd,UserPower) values('" + txtOUser.Text.Trim() + "','" + txtOPwd.Text.Trim() + "','" + comboBox1.Text + "')";
                        operate.OperateData(InsertSql);//�����ݿ��в�������
                        txtOPwd.Text = "";//����ı�����
                        txtOUser.Text = "";//����ı�����
                        MessageBox.Show("���Ӳ���Ա�ɹ���", "��ʾ",//������Ϣ�Ի���
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            {
                MessageBox.Show("���Ӳ���Աʧ�ܣ�","��ʾ",//������Ϣ�Ի���
                    MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string name=dataGridView1.SelectedCells[0].Value.ToString();//�õ��û���
            string str =//����SQL�ַ���
                "select * from tb_User where UserName='"+name+"'";
            DataSet ds = operate.GetTable(str);//�õ����ݼ�
            ds.Dispose();//�ͷ���Դ
            txtOUser.Text = ds.Tables[0].Rows[0][1].ToString();//�õ��û���
            txtOPwd.Text = ds.Tables[0].Rows[0][2].ToString();//�õ�����
            comboBox1.SelectedItem = ds.Tables[0].Rows[0][3].ToString();//����ѡ����
        }

        private void ɾ��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 0)
            {
                MessageBox.Show("��ѡ��Ҫɾ���Ĺ���Ա", "��ʾ",//������Ϣ�Ի���
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;//�˳��¼�
            }
            else
            {
                string username = dataGridView1.SelectedCells[0].Value.ToString();//�õ��û���
                string strsql =//����SQL�ַ���
                    "delete from tb_User where UserName='"+username+"'";
                operate.OperateData(strsql);//ɾ�����ݿ���ָ����¼
                MessageBox.Show("ɾ���ɹ���", "��ʾ",//������Ϣ�Ի���
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmOperator_Activated(object sender, EventArgs e)
        {
            frmOperator_Load(sender, e);//ִ�д���Load�¼�
        }

        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtOUser.Text.Trim() == "" || txtOPwd.Text.Trim() == "")
            {
                MessageBox.Show("��Ϣ��������", "��ʾ",//������Ϣ�Ի���
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;//�˳��¼�
            }
            else
            {
                string str =//����SQL�ַ�������
                    "select count(*) from tb_User where UserName='" + txtOUser.Text.Trim() + "'";
                int i = operate.HumanNum(str);//������¼����
                if (i > 0)
                {
                    string updatestr =//����SQL�ַ���
                        "update tb_User set UserPwd='" + txtOPwd.Text.Trim() + "',UserPower='" + comboBox1.Text + "' where UserName='" + txtOUser.Text.Trim() + "'";
                    operate.OperateData(updatestr);//�������ݿ���Ϣ
                    MessageBox.Show("��Ϣ�޸ĳɹ���", "��ʾ",//������Ϣ�Ի���
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtOPwd.Text = "";//����ı�����
                    txtOUser.Text = "";//����ı�����
                }
                else
                {
                    MessageBox.Show("ָ���û������ڣ�", "��ʾ",//������Ϣ�Ի���
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}