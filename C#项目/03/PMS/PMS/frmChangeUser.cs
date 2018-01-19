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
    public partial class frmChangeUser : Form
    {
        public frmChangeUser()
        {
            InitializeComponent();
        }
        DBOperate operate = new DBOperate();//�������ݿ��������
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();//�رմ���
        }

        private void frmChangeUser_Load(object sender, EventArgs e)
        {
            SqlConnection conn = DBConnection.MyConnection();//�������ݿ����Ӷ���
            conn.Open();//�����ݿ�����
            SqlCommand cmd = new SqlCommand("select * from tb_User",conn);//�������ݿ��������
            SqlDataReader sdr = cmd.ExecuteReader();//�õ����ݶ�ȡ��
            while (sdr.Read())//��ȡ����
            {
                comboBox1.Items.Add(sdr["UserName"].ToString());//���������
            }
            conn.Close();//�ر����ݿ�����
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtpwd.Text.Trim()==""||comboBox1.Text=="")
                {
                    MessageBox.Show("�û��������벻��Ϊ�գ�", "��ʾ",//������Ϣ�Ի���
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;//�˳��¼�
                }
                else
                {
                    string name = comboBox1.Text;//��ȡ�û���
                    string pwd = txtpwd.Text.Trim();//��ȡ����
                    SqlConnection conn = DBConnection.MyConnection();//�������ݿ����Ӷ���
                    conn.Open();//�����ݿ�����
                    SqlCommand cmd = new SqlCommand(//�������ݿ��������
                        "select * from tb_User where UserName='" + name + "' and UserPwd='" + pwd + "'", conn);
                    SqlDataReader sdr = cmd.ExecuteReader();//�������ݶ�ȡ��
                    sdr.Read();//��ȡ����
                    if (sdr.HasRows)//�ж��Ƿ�������
                    {
                        string time = DateTime.Now.ToString();//�õ�ʱ����Ϣ
                        string sql = //����SQL�ַ���
                            "update tb_User set LoginTime='" + time + "' where UserName='" + name + "'";
                        operate.OperateData(sql);//�������ݿ���Ϣ
                        this.MdiParent.Close();//�رո�����
                        conn.Close();//�ر�����
                        frmMain Main = new frmMain();//�������������
                        Main.User = name;//Ϊ�ֶθ�ֵ
                        Main.Logintime = time;//Ϊ�ֶθ�ֵ
                        Main.Show();//��ʾ������
                    }
                    else
                    {
                        txtpwd.Text = "";//����ı�����
                        comboBox1.Text = "";//����ı�����
                        MessageBox.Show("�û������������", "��ʾ",//������Ϣ�Ի���
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)//�����쳣
            {
                MessageBox.Show(ex.Message);//������Ϣ�Ի���
            }
        }
    }
}