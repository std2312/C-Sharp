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
    public partial class frmChangePrize : Form
    {
        public frmChangePrize()
        {
            InitializeComponent();
        }
        public string Uid;//�����ֶ�
        public string Uname;//�����ֶ�
        DBOperate operate = new DBOperate();//�������ݿ��������
        private void frmChangePrize_Load(object sender, EventArgs e)
        {
            if (cbbUserJFType.Text == "����")
            {
                txtFK.Enabled = false;//ͣ�÷����ı���
                txtJL.Enabled = true;//���ý����ı���
            }
            else
            {
                txtJL.Enabled = false;//ͣ�ý����ı���
                txtFK.Enabled = true;//���÷����ı���
            }
            SqlConnection conn = DBConnection.MyConnection();//�������ݿ����Ӷ���
            conn.Open();//�����ݿ�����
            SqlCommand cmd = new SqlCommand("select * from tb_employee", conn);//�������ݿ��������
            SqlDataReader sdr = cmd.ExecuteReader();//�������ݶ�ȡ��
            while (sdr.Read())//��ȡ����
            {
                cbbUserNum.Items.Add(sdr["employeeID"].ToString());//���������
            }
            sdr.Close();//�ر����ݶ�ȡ��
            conn.Close();//�ر����ݿ�����
            this.Text = "[" + Uname + "]";//���ô������
            string sql =//����SQL�ַ���
                "select * from tb_prize where UserID='" + Uid + "'";
            DataSet ds = operate.GetTable(sql);//�õ����ݼ�
            ds.Dispose();//�ͷ���Դ
            cbbUserNum.Text = ds.Tables[0].Rows[0][1].ToString();//�õ�Ա�����
            cbbUserJFType.Text = ds.Tables[0].Rows[0][4].ToString();//�õ�������Ϣ
            txtname.Text = ds.Tables[0].Rows[0][2].ToString();//�õ�Ա������
            txtdep.Text = ds.Tables[0].Rows[0][3].ToString();//�õ�Ա������
            txtJFcontent.Text = ds.Tables[0].Rows[0][5].ToString();//�õ���������
            txtJL.Text = ds.Tables[0].Rows[0][6].ToString();//�õ��������
            txtFK.Text = ds.Tables[0].Rows[0][7].ToString();//�õ�������
            txtJFdate.Text = ds.Tables[0].Rows[0][8].ToString();//�õ���������
            txtCXDate.Text = ds.Tables[0].Rows[0][9].ToString();//�õ���������
        }

        private void cbbUserJFType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbUserJFType.Text == "����")
            {
                txtFK.Enabled = false;//ͣ�÷����ı���
                txtJL.Enabled = true;//���ý����ı���
            }
            else
            {
                txtJL.Enabled = false;//ͣ�ý����ı���
                txtFK.Enabled = true;//���÷����ı���
            }
        }

        private void �˳�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();//�رմ���
        }

        private void ���ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cbbUserNum.Text == "" || cbbUserJFType.Text == "" ||
                txtJFcontent.Text == "" || txtJL.Text == "" ||
                txtFK.Text == "" || txtJFdate.Text == "" || txtCXDate.Text == "")
            {
                MessageBox.Show("�뽫��Ϣ��д������", "��ʾ",//������Ϣ�Ի���
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;//�˳��¼�
            }
            else
            {
                if (cbbUserJFType.Text == "����")
                {
                    if (Regex.IsMatch(txtJL.Text.Trim(), @"[1-9]\d*.\d{2}"))//�ж��Ƿ�Ϊ����
                    {
                        string sql =//����SQL�ַ���
                            "update tb_prize set UserName='" + txtname.Text + "',UserDep='" + txtdep.Text + "',UserJF='" + cbbUserJFType.Text + "',UserJFcontent='" + txtJFcontent.Text + "',UserJLMoney='" + txtJL.Text + "',UserFKMoney='" + txtFK.Text + "',UserJFDate='" + txtJFdate.Text + "',UserCXDate='" + txtCXDate.Text + "' where UserID='" + cbbUserNum.Text + "'";
                        if (operate.OperateData(sql) > 0)
                        {
                            MessageBox.Show("�޸ĳɹ�", "��ʾ",//������Ϣ�Ի���
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("��������ȷ����ʽ��", "��ʾ",//������Ϣ�Ի���
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;//�˳��¼�
                    }
                }
                else
                {
                    if (Regex.IsMatch(txtFK.Text.Trim(), @"[1-9]\d*.\d{2}"))//�ж��Ƿ�Ϊ����
                    {
                        string sql =//����SQL�ַ���
                            "update tb_prize set UserName='" + txtname.Text + "',UserDep='" + txtdep.Text + "',UserJF='" + cbbUserJFType.Text + "',UserJFcontent='" + txtJFcontent.Text + "',UserJLMoney='" + txtJL.Text + "',UserFKMoney='" + txtFK.Text + "',UserJFDate='" + txtJFdate.Text + "',UserCXDate='" + txtCXDate.Text + "' where UserID='" + cbbUserNum.Text + "'";
                        if (operate.OperateData(sql) > 0)
                        {
                            MessageBox.Show("�޸ĳɹ�", "��ʾ",//������Ϣ�Ի���
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    else
                    {
                        MessageBox.Show("��������ȷ����ʽ��", "��ʾ",//������Ϣ�Ի���
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;//�˳��¼�
                    }
                }
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
    }
}