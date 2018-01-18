using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using PMS.PMSClass;
using System.Text.RegularExpressions;
namespace PMS
{
    public partial class frmAddEmployee : Form
    {
        public frmAddEmployee()
        {
            InitializeComponent();
        }
        DBOperate operate = new DBOperate();//�������ݿ��������
        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            this.Close();//�رմ���
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                operate.Read_Image(openFileDialog1, pictureBox1);//����Ա��ͷ��
            }
            catch//�����쳣
            {
                MessageBox.Show("����ͼƬ����");//������Ϣ�Ի���
            }
        }

        private void frmAddEmployee_Load(object sender, EventArgs e)
        {
            try
            {
                operate.BindDropdownlist("tb_department",cbbYGBumen,1);//�������б�
                cbbYGHunyin.SelectedIndex = 0;//����Ĭ��ѡ��
                cbbYGSex.SelectedIndex = 0;//����Ĭ��ѡ��
                cbbYGBumen.SelectedIndex = 0;//����Ĭ��ѡ��
                txtYGminzu.SelectedIndex = 0;//����Ĭ��ѡ��
                string strg = Application.StartupPath.ToString();//�õ�Ӧ�ó���·��
                strg = strg.Substring(0, strg.LastIndexOf("\\"));//��ȡ·����Ϣ
                strg = strg.Substring(0, strg.LastIndexOf("\\"));//��ȡ·����Ϣ
                strg += @"\PMSImage";//���·����Ϣ
                strg += @"\default.jpg";//���ļ�����
                openFileDialog1.FileName = strg;//���ô��ļ�·����Ϣ
                operate.BindDropdownlist("tb_userJob",txtYGZhiwu, 1);//�����е�ְ���б�
            }
            catch (Exception ex)//�����쳣
            {
                MessageBox.Show(ex.Message);//������Ϣ�Ի���
            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            if (txtYGBirthday.Text.Trim() == "" ||
                txtYGJiuzhi.Text.Trim() == "" || txtYGminzu.Text.Trim() == "" ||
                txtYGName.Text.Trim() == "" || txtYGNum.Text.Trim() == "" ||
                txtYGPhone.Text.Trim() == "" || txtYGZhiwu.Text.Trim() == ""||txtYGPay.Text.Trim()=="")
            {
                MessageBox.Show("�뽫��Ϣ��д����", "����",//������Ϣ�Ի���
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;//�˳��¼�
            }
            else
            {
                if (txtYGPhone.Text.Length != 11)
                {
                    MessageBox.Show("�ֻ�����Ϊ11λ");//������Ϣ�Ի���
                    return;//�˳��¼�
                }
                else
                {
                    string str =//����SQL�ַ���
                        "select count(*) from tb_employee where employeeID='" + txtYGNum.Text + "'";
                    int i = operate.HumanNum(str);//�õ���¼����
                    if (i > 0)
                    {
                        MessageBox.Show("��Ա������Ѿ�����", "��ʾ",//������Ϣ�Ի���
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;//�˳��¼�
                    }
                    else
                    {
                        string strSql =//����SQL�ַ���
                            "insert into tb_employee(employeeID,employeeName,employeeSex,employeeDept,employeeBirthday,employeeNation,employeeMarriage,employeeDuty,employeePhone,employeeAccession,employeePay) values('" + txtYGNum.Text.Trim() + "','" + txtYGName.Text.Trim() + "','" + cbbYGSex.Text + "','" + cbbYGBumen.Text + "','" + txtYGBirthday.Text + "','" + txtYGminzu.Text.Trim() + "','" + cbbYGHunyin.Text + "','" + txtYGZhiwu.Text.Trim() + "','" + txtYGPhone.Text.Trim() + "','" + txtYGJiuzhi.Text + "','" + txtYGPay.Text.Trim() + "')";
                        int num = operate.OperateData(strSql);
                        operate.SaveImage(//��ͼƬ�洢�����ݿ���
                            this.txtYGNum.Text.Trim(), openFileDialog1);
                        if (num > 0)
                        {
                            MessageBox.Show("Ա����Ϣ��ӳɹ�", "��ʾ",//������Ϣ�Ի���
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void txtYGNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar))//�ж������Ƿ�Ϊ����
            {
                MessageBox.Show("ֻ����������", "��ʾ",//������Ϣ�Ի���
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;//�Ѿ�������¼�
            }
        }

        private void txtYGNum_TextChanged(object sender, EventArgs e)
        {
            string str =//����SQL�ַ���
                "select count(*) from tb_employee where employeeID='" + this.txtYGNum.Text.Trim() + "'";
            int m = operate.HumanNum(str);//�õ���¼����
            if (m > 0)
            {
                MessageBox.Show("Ա����Ŵ���", "��ʾ",//������Ϣ�Ի���
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;//�˳��¼�
            }
        }

        private void txtYGPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("ֻ����������", "��ʾ",//������Ϣ�Ի���
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;//�Ѿ�������¼�
            }
        }

        private void txtYGPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar))//�ж�������ֵ�Ƿ�Ϊ����
            {
                MessageBox.Show("ֻ����������", "��ʾ",//������Ϣ�Ի���
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;//�Ѿ�������¼�
            }
        }
    }
}