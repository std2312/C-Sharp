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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        DBOperate operate = new DBOperate();//�����������ݿ����
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //try
            //{
                if (txtUserName.Text == "" || txtUserPwd.Text == "")//�ж��û����������Ƿ�Ϊ��
                {
                    MessageBox.Show("�û��������벻��Ϊ�գ�",//������Ϣ�Ի���
                        "��ʾ", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;//�˳��¼�
                }
                else
                {
                    string name = txtUserName.Text.Trim();//�Ƴ��û���ǰ���ͺ󲿵Ŀո�
                    string pwd = txtUserPwd.Text.Trim();//�Ƴ�����ǰ���ͺ󲿵Ŀո�
                    SqlConnection conn = PMSClass.DBConnection.MyConnection();//�������ݿ����Ӷ���
                    conn.Open();//���ӵ�SQL���ݿ�
                    SqlCommand cmd = new SqlCommand(//�������ݿ��������
                        "select * from tb_User where UserName='" + 
                        name + "' and UserPwd='" + pwd + "'", conn);
                    SqlDataReader sdr = cmd.ExecuteReader();//�õ����ݶ�ȡ������
                    sdr.Read();//��ȡһ����¼
                    if (sdr.HasRows)//�ж��Ƿ��������
                    {
                        string time = DateTime.Now.ToString();//�õ�ϵͳʱ���ַ���
                        string sql = "update tb_User set LoginTime='" //���ø������ݿ��SQL���
                            + time + "' where UserName='" + name + "'";
                        operate.OperateData(sql);//�������ݿ�����
                        conn.Close();//�ر����ݿ�����
                        this.Hide();//���ش���
                        frmMain Main = new frmMain();//�������������
                        Main.User = name;//Ϊ�������ֶθ�ֵ
                        Main.Logintime = time;//Ϊ�������ֶθ�ֵ
                        Main.Show();//��ʾ������
                    }
                    else
                    {
                        txtUserName.Text = "";//����û���
                        txtUserPwd.Text = "";//�������
                        MessageBox.Show("�û������������", "��ʾ",//������Ϣ�Ի���
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            //}
            //catch (Exception ex)//�����쳣
            //{
            //    MessageBox.Show(ex.Message);//������Ϣ�Ի���
            //}
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();//�رմ���
        }
    }
}