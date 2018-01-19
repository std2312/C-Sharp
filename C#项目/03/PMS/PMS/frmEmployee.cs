using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PMS.PMSClass;
using System.Data.SqlClient;
namespace PMS
{
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }
        DBOperate operate = new DBOperate();//�������ݿ��������
        private void frmEmployee_Load(object sender, EventArgs e)
        {
            string str = //������ѯ�ַ���
                "select ID as '���',employeeID as 'Ա�����',employeeName as 'Ա������',employeeSex as 'Ա���Ա�',employeeDept as '��������',employeeBirthday as 'Ա������',employeeNation as '����',employeeMarriage as '����״��',employeeDuty as '����ְ��',employeePhone as '��ϵ�绰',employeeAccession as '��ְ����' from tb_employee";
            operate.BindDataGridView(dgvEmployee,str);//����ѯ��Ϣ�󶨵�DataGridView�ؼ�
            dgvEmployee.Columns[0].Width = 40;//���������п��
            dgvEmployee.Columns[1].Width = 80;//���������п��
            treeView1.ImageList = imageList1;//���ÿؼ���ImageList����
            treeView1.ImageIndex = 0;//����ͼ���б������
            treeView1.SelectedImageIndex =0;//����ѡ�нڵ�ʱ��ʾ��ͼ���б�����
            string sql = "select count(*) from tb_employee";//����SQL�ַ���
            toolStripStatusLabel2.Text=operate.HumanNum(sql).ToString()+"��";//��ʾԱ������
            TreeNode tn = treeView1.Nodes.Add("���в���");//��ӽڵ�
            SqlConnection conn = DBConnection.MyConnection();//�������ݿ����Ӷ���
            conn.Open();//�����ݿ�����
            SqlCommand cmd = new SqlCommand("select * from tb_department", conn);//�����������
            SqlDataReader sdr = cmd.ExecuteReader();//�������ݶ�ȡ��
            while (sdr.Read())//��ȡ����
            {
                tn.Nodes.Add(sdr["DepName"].ToString());//��ӽڵ�
            }
            sdr.Close();//�ر����ݶ�ȡ��
            conn.Close();//�ر����ݿ�����
            treeView1.ExpandAll();//չ�����нڵ�
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            string str =//������ѯ�ַ���
                "select ID as '���',employeeID as 'Ա�����',employeeName as 'Ա������',employeeSex as 'Ա���Ա�',employeeDept as '��������',employeeBirthday as 'Ա������',employeeNation as '����',employeeMarriage as '����״��',employeeDuty as '����ְ��',employeePhone as '��ϵ�绰',employeeAccession as '��ְ����' from tb_employee where employeeName like '%"+toolStripTextBox1.Text.Trim()+"%'";
            operate.BindDataGridView(dgvEmployee, str);//����ѯ��Ϣ�󶨵�DataGridView�ؼ�
            dgvEmployee.Columns[0].Width = 40;//���������п��
            dgvEmployee.Columns[1].Width = 80;//���������п��
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string str = e.Node.Text;//�õ�ѡ�нڵ���ַ���
            if (str == "���в���")
            {
                string SQLStr = //������ѯ�ַ���
                     "select ID as '���',employeeID as 'Ա�����',employeeName as 'Ա������',employeeSex as 'Ա���Ա�',employeeDept as '��������',employeeBirthday as 'Ա������',employeeNation as '����',employeeMarriage as '����״��',employeeDuty as '����ְ��',employeePhone as '��ϵ�绰',employeeAccession as '��ְ����' from tb_employee";
                operate.BindDataGridView(dgvEmployee, SQLStr);//����ѯ��Ϣ�󶨵�DataGridView�ؼ�
            }
            else
            {
                string strsql =//������ѯ�ַ���
                    "select ID as '���',employeeID as 'Ա�����',employeeName as 'Ա������',employeeSex as 'Ա���Ա�',employeeDept as '��������',employeeBirthday as 'Ա������',employeeNation as '����',employeeMarriage as '����״��',employeeDuty as '����ְ��',employeePhone as '��ϵ�绰',employeeAccession as '��ְ����' from tb_employee where employeeDept='"+str+"'";
                operate.BindDataGridView(dgvEmployee, strsql);//����ѯ��Ϣ�󶨵�DataGridView�ؼ�
                dgvEmployee.Columns[0].Width = 40;//���������п��
                dgvEmployee.Columns[1].Width = 80;//���������п��
            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            frmAddEmployee addemployee = new frmAddEmployee();//�������Ա����Ϣ�������
            addemployee.ShowDialog();//��ʾģʽ����
        }

        private void dgvEmployee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEmployee.SelectedCells.Count == -1)
            {
                MessageBox.Show("��ѡ��Ҫ�޸ĵ�����", "��ʾ",//������Ϣ�Ի���
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;//�˳��¼�
            }
            else
            {
                string YGName = dgvEmployee.SelectedCells[2].Value.ToString();//��ȡԱ������
                frmEmployeeInfo info = new frmEmployeeInfo();//����Ա����Ϣ�������
                info.YGName = YGName;//Ϊ�ֶθ�ֵ
                info.YGID = dgvEmployee.SelectedCells[1].Value.ToString();//Ϊ�ֶθ�ֵ
                info.ShowDialog();//��ʾģʽ�Ի���
            }
        }

        private void dgvEmployee_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.SelectedCells.Count > 0)
            {
                string YGName = dgvEmployee.SelectedCells[1].Value.ToString();//�õ�Ա�����
                operate.Get_Image(YGName, pictureBox1);//��ʾͼƬ��Ϣ
            }
        }

        private void frmEmployee_Activated(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();//������нڵ�
            frmEmployee_Load(sender, e);//ִ�д���Load�¼�
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.SelectedCells.Count == 0)
            {
                MessageBox.Show(//������Ϣ�Ի���
                    "��ѡ��Ҫ�޸ĵ�����", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;//�˳��¼�
            }
            else
            {
                string YGName = //�õ�Ա������
                    dgvEmployee.SelectedCells[2].Value.ToString();
                frmEmployeeInfo info = new frmEmployeeInfo();//����Ա����Ϣ�������
                info.YGName = YGName;//Ϊ�ֶθ�ֵ
                info.YGID = dgvEmployee.SelectedCells[1].Value.ToString();//Ϊ�ֶθ�ֵ
                info.ShowDialog();//��ʾģʽ����
            }
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvEmployee.SelectedCells.Count == 0)
                {
                    MessageBox.Show("��ѡ��Ҫɾ��������",//������Ϣ�Ի���
                        "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;//�˳��¼�
                }
                else
                {
                    string YGID = dgvEmployee.SelectedCells[1].Value.ToString();//�õ�ID
                    string DelSql =//����SQL�ַ���
                        "delete from tb_employee where employeeID='" + YGID + "'";
                    operate.OperateData(DelSql);//ɾ��Ա����Ϣ
                    operate.DeleUserInfo(YGID);//ɾ��Ա����Ϣ
                    MessageBox.Show("ɾ���ɹ�", "��ʾ",//������Ϣ�Ի���
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch//�����쳣
            {
                MessageBox.Show("ɾ������ʧ��", "��ʾ",//������Ϣ�Ի���
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}