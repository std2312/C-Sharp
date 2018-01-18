using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using PMS.PMSClass;
namespace PMS
{
    public partial class frmDepManager : Form
    {
        public frmDepManager()
        {
            InitializeComponent();
        }
        DBOperate operate = new DBOperate();//�������ݿ��������
        public TreeNode tn;//�����ֶ�
        private void frmDepManager_Load(object sender, EventArgs e)
        {
            treeView1.ImageList = imageList1;//����ImageList����
            treeView1.ImageIndex = 0;//����ImageList����
            treeView1.SelectedImageIndex = 0;//����ѡ�нڵ����ʾ��ImageList����
            tn = treeView1.Nodes.Add("���в���");//��ӽڵ���Ϣ
            SqlConnection conn = DBConnection.MyConnection();//�������ݿ����Ӷ���
            conn.Open();//�����ݿ�����
            SqlCommand cmd = new SqlCommand("select * from tb_department", conn);//�������ݿ��������
            SqlDataReader sdr = cmd.ExecuteReader();//�õ����ݶ�ȡ��
            while (sdr.Read())//��ȡ����
            {
                tn.Nodes.Add(sdr["DepName"].ToString());//��ӽڵ�
            }
            sdr.Close();//�ر����ݶ�ȡ��
            conn.Close();//�ر����ݿ�����
            treeView1.ExpandAll();//չ�����нڵ�
            treeView1.SelectedNode = treeView1.Nodes[0];//���ô������ʱ��treeview�ؼ��ĸ��ڵ㱻ѡ��
        }

        private void �˳�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();//�رմ���
        }

        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddDep adddep = new frmAddDep();//�������ű༭�������
            adddep.ShowDialog();//��ʾģʽ����
        }

        private void frmDepManager_Activated(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();//��սڵ�
            frmDepManager_Load(sender, e);//ִ�д���Load�¼�
        }

        private void ɾ��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.Text == "���в���")
            {
                MessageBox.Show("����ɾ����Ŀ¼", "��ʾ",//������Ϣ�Ի���
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;//�˳��¼�
            }
            else
            {
                if (treeView1.SelectedNode.Text == "����δ����")
                {
                    MessageBox.Show("����ɾ��ȱʡ����", "��ʾ",//������Ϣ�Ի���
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;//�˳��¼�
                }
                else
                {
                    string depname = treeView1.SelectedNode.Text;//�õ�ѡ�нڵ��ı�����
                    string str =//����SQL�ַ���
                        "delete from tb_department where DepName='" + depname + "'";
                    if (operate.OperateData(str) > 0)
                    {
                        MessageBox.Show("����ɾ���ɹ�", "��ʾ",//������Ϣ�Ի���
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    string upstr =//����SQL�ַ���
                        "update tb_employee  set employeeDept='����δ����' where employeeDept='" + depname + "'";
                    operate.OperateData(upstr);//�������ݿ���Ϣ
                }
            }
        }

        private void �޸�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.Text == "���в���")
            {
                MessageBox.Show("�����޸ĸ�Ŀ¼", "��ʾ",//������Ϣ�Ի���
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;//�˳��¼�
            }
            else
            {
                string depName = treeView1.SelectedNode.Text;//�õ�ѡ�нڵ��ı�����
                frmChangeDep changedep = new frmChangeDep();//�����޸Ĳ������ƴ������
                changedep.name = depName;//Ϊ�ֶθ�ֵ
                changedep.ShowDialog();//��ʾģʽ����
            }
        }
    }
}