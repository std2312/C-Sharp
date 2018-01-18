using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using PMS.PMSClass;
using System.Text.RegularExpressions;
namespace PMS
{
    public partial class frmJFmanage : Form
    {
        public frmJFmanage()
        {
            InitializeComponent();
        }
        DBOperate operate = new DBOperate();//�������ݿ��������
        private void frmJFmanage_Load(object sender, EventArgs e)
        {
            SqlConnection conn = DBConnection.MyConnection();//�������ݿ����Ӷ���
            conn.Open();//�����ݿ�����
            SqlCommand cmd = new SqlCommand("select * from tb_employee", conn);//�������ݿ��������
            SqlDataReader sdr = cmd.ExecuteReader();//�õ����ݶ�ȡ��
            while (sdr.Read())//��ȡ����
            {
                cbbUserNum.Items.Add(sdr["employeeID"].ToString());//���������
            }
            sdr.Close();//�ر����ݶ�ȡ��
            conn.Close();//�ر����ݿ�����
        }

        private void cbbUserNum_SelectedIndexChanged(object sender, EventArgs e)
        {
           string str =//����SQL�ַ���
               "select * from tb_employee where employeeID='" + cbbUserNum.Text + "'";
           DataSet ds = operate.GetTable(str);//�õ����ݼ�
           ds.Dispose();//�ͷ���Դ
           txtname.Text = ds.Tables[0].Rows[0][2].ToString();//�õ��û���
           txtdep.Text = ds.Tables[0].Rows[0][4].ToString();//�õ�������Ϣ
        }

        private void cbbUserJFType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbUserJFType.Text == "����")
            {
                txtFK.Enabled = false;//ͣ�÷����ı���
                txtFK.Text = "0";//��շ����ı���
                txtJL.Enabled = true;//Ӧ�ý����ı���
            }
            else
            {
                txtJL.Enabled = false;//ͣ�ý����ı���
                txtJL.Text = "0";//��ս����ı���
                txtFK.Enabled = true;//���÷����ı���
            }
        }

        private void txtJL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("ֻ����������", "��ʾ",//������Ϣ�Ի���
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;//�Ѿ���������¼�
            }
        }

        private void txtFK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("ֻ����������", "��ʾ",//������Ϣ�Ի���
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;//�Ѿ���������¼�
            }
        }

        private void ���ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cbbUserNum.Text == "" || cbbUserJFType.Text == "" ||
                txtJFcontent.Text == "" || txtJFdate.Text == "" ||
                txtCXDate.Text == "")
            {
                MessageBox.Show("�뽫��Ϣ��д������", "��ʾ",//������Ϣ�Ի���
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;//�˳��¼�
            }
            else
            {
                if (cbbUserJFType.Text == "����")
                {
                    if (txtJL.Text == "")
                    {
                        MessageBox.Show("�����뽱����",//������Ϣ�Ի���
                            "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;//�˳��¼�
                    }
                    else
                    {
                        string sql =//����SQL�ַ���
                            "select count(*) from tb_prize where UserID='" + cbbUserNum.Text + "'";
                        int i = operate.HumanNum(sql);//�õ���¼����
                        if (i > 0)
                        {
                            MessageBox.Show("Ա������Ѿ����ڣ�", "��ʾ",//������Ϣ�Ի���
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;//�˳��¼�
                        }
                        else
                        {
                            string str =//����SQL�ַ���
                                "insert into tb_prize(UserID,UserName,UserDep,UserJF,UserJFcontent,UserJLMoney,UserFKMoney,UserJFDate,UserCXDate) values('" + cbbUserNum.Text + "','" + txtname.Text + "','" + txtdep.Text + "','" + cbbUserJFType.Text + "','" + txtJFcontent.Text + "','" + txtJL.Text + "','" + txtFK.Text + "','" + txtJFdate.Text + "','" + txtCXDate.Text + "')";
                            operate.OperateData(str);//�����ݿ��������
                            MessageBox.Show("��ӳɹ���", "��ʾ",//������Ϣ�Ի���
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    try
                    {
                        if (txtFK.Text == "")
                        {
                            MessageBox.Show("�����Ϊ��");//������Ϣ�Ի���
                        }
                        else
                        {
                            string sql =//����SQL�ַ���
                                "select count(*) from tb_prize where UserID='" + cbbUserNum.Text + "'";
                            int i = operate.HumanNum(sql);//�õ���¼����
                            if (i > 0)
                            {
                                MessageBox.Show("Ա������Ѿ����ڣ�", "��ʾ",//������Ϣ�Ի���
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;//�˳��¼�
                            }
                            else
                            {
                                string str =//����SQL�ַ���
                                    "insert into tb_prize(UserID,UserName,UserDep,UserJF,UserJFcontent,UserJLMoney,UserFKMoney,UserJFDate,UserCXDate) values('" + cbbUserNum.Text + "','" + txtname.Text + "','" + txtdep.Text + "','" + cbbUserJFType.Text + "','" + txtJFcontent.Text + "','" + txtJL.Text + "','" + txtFK.Text + "','" + txtJFdate.Text + "','" + txtCXDate.Text + "')";
                                operate.OperateData(str);//�����ݿ��������
                                MessageBox.Show("��ӳɹ���", "��ʾ",//������Ϣ�Ի���
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    catch(Exception ex)//�����쳣
                    {
                        MessageBox.Show(ex.Message);//������Ϣ�Ի���
                    }
                }
            }
        }

        private void �˳�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();//�رմ���
        }
    }
}