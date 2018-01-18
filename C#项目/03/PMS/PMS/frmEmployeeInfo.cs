using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PMS.PMSClass;
using System.IO;
namespace PMS
{
    public partial class frmEmployeeInfo : Form
    {
        public frmEmployeeInfo()
        {
            InitializeComponent();
        }
        DBOperate operate = new DBOperate();//�������ݿ��������
        public string YGName;//�����ֶ�
        public string YGID;//�����ֶ�
        private void frmEmployeeInfo_Load(object sender, EventArgs e)
        {
            operate.BindDropdownlist("tb_department", cbbYGBumen, 1);//�������б�
            operate.BindDropdownlist("tb_userJob", txtYGZhiwu, 1);//�����е�ְ���б�
            this.Text = "[ "+YGName+" ]�ĸ�����Ϣ";//���ô������
            string sql =//����SQL�ַ���
                "select * from tb_employee where employeeID='" + YGID + "'";
            DataSet ds = operate.GetTable(sql);//�õ����ݼ�
            ds.Dispose();//�ͷ���Դ
            txtYGNum.Text = ds.Tables[0].Rows[0][1].ToString();//��ȡԱ�������Ϣ
            txtYGName.Text = ds.Tables[0].Rows[0][2].ToString();//��ȡԱ��������Ϣ
            cbbYGSex.SelectedItem = ds.Tables[0].Rows[0][3].ToString();//��ȡ�Ա���Ϣ
            cbbYGBumen.SelectedItem = ds.Tables[0].Rows[0][4].ToString();//��ȡ������Ϣ
            txtYGBirthday.Text = ds.Tables[0].Rows[0][5].ToString();//��ȡ������Ϣ
            txtYGminzu.SelectedItem = ds.Tables[0].Rows[0][6].ToString();//��ȡ������Ϣ
            cbbYGHunyin.SelectedItem = ds.Tables[0].Rows[0][7].ToString();//��ȡ������Ϣ
            txtYGZhiwu.SelectedItem = ds.Tables[0].Rows[0][8].ToString();//��ȡְ����Ϣ
            txtYGPhone.Text = ds.Tables[0].Rows[0][9].ToString();//��ȡ�绰��Ϣ
            txtYGJiuzhi.Text = ds.Tables[0].Rows[0][10].ToString();//��ȡ��ְ����
            txtYGPay.Text = ds.Tables[0].Rows[0][12].ToString();//��ȡ������Ϣ
            operate.Get_Image(YGID, pictureBox1);//��ȡͼ����Ϣ
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            try
            {
                string DelSql =//�������ݿ������ַ���
                    "delete from tb_employee where employeeID='" + YGID + "'";
                operate.OperateData(DelSql);//ɾ������
                operate.DeleUserInfo(YGID);//ɾ������
                MessageBox.Show(//������Ϣ�Ի���
                    "ɾ���ɹ�","��ʾ",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();//�رմ���
            }
            catch
            {
                MessageBox.Show("ɾ������ʧ��","��ʾ",//������Ϣ�Ի���
                    MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            this.Close();//�رմ���
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtYGBirthday.Text.Trim() == "" ||
                    txtYGJiuzhi.Text.Trim() == "" ||
                    txtYGminzu.Text.Trim() == "" ||
                    txtYGName.Text.Trim() == "" ||
                    txtYGNum.Text.Trim() == "" ||
                    txtYGPhone.Text.Trim() == "" ||
                    txtYGZhiwu.Text.Trim() == ""||
                    txtYGPay.Text.Trim()=="")
                {
                    MessageBox.Show("�뽫��Ϣ��д����", "����",//������Ϣ�Ի���
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;//�˳��¼�
                }
                else
                {
                    if (txtYGPhone.Text.Length != 11)//�ж��ֻ�����λ��
                    {
                        MessageBox.Show("�ֻ�����Ϊ11λ");//������Ϣ�Ի���
                        return;//�˳��¼�
                    }
                    else
                    {
                        string strUpdateSql =//����SQL�ַ���
                            "update tb_employee set employeeName='" + txtYGName.Text.Trim() + "',employeeSex='" + cbbYGSex.Text + "',employeeDept='" + cbbYGBumen.Text + "',employeeBirthday='" + txtYGBirthday.Text + "',employeeNation='" + txtYGminzu.Text.Trim() + "',employeeMarriage='" + cbbYGHunyin.Text + "',employeeDuty='" + txtYGZhiwu.Text.Trim() + "',employeePhone='" + txtYGPhone.Text.Trim() + "',employeeAccession='" + txtYGJiuzhi.Text + "',employeePay='"+txtYGPay.Text.Trim()+"' where employeeID='" + YGID + "'";
                        int num = operate.OperateData(strUpdateSql);//�������ݿ���Ϣ
                        if (openFileDialog1.FileName == "openFileDialog1")
                        { }
                        else
                        {
                            operate.SaveImage(this.txtYGNum.Text.Trim(), openFileDialog1);//����ͼ����Ϣ
                        }
                        if (num > 0)
                        {
                            string update1 =//����SQL�ַ���
                                "update tb_redeploy set UName='" + txtYGName.Text + "',UOldDep='" + cbbYGBumen.Text + "',UOldJob='" + txtYGZhiwu.Text + "',UOldPay='"+txtYGPay.Text+"' where UID='" + txtYGNum.Text + "'";
                            string update2 =//����SQL�ַ���
                                "update tb_prize set UserName='" + txtYGName.Text + "',UserDep='"+cbbYGBumen.Text+"' where UserID='" + txtYGNum.Text + "'";
                            string update3 =//����SQL�ַ���
                                "update tb_pay set YName='" + txtYGName.Text + "',YSex='" + cbbYGSex.Text + "',Ydep='" + cbbYGBumen.Text + "',YZhiwu='" + txtYGZhiwu.Text + "',YBasePay='"+txtYGPay.Text+"' where YID='" + txtYGNum.Text + "'";
                            string update4 =//����SQL�ַ���
                                "update tb_check set Pname='" + txtYGName.Text + "',Pdep='"+cbbYGBumen.Text+"' where PID='" + txtYGNum.Text + "'";
                            operate.OperateData(update1);//�������ݿ�
                            operate.OperateData(update2);//�������ݿ�
                            operate.OperateData(update3);//�������ݿ�
                            operate.OperateData(update4);//�������ݿ�
                            MessageBox.Show("Ա����Ϣ�޸ĳɹ�", "��ʾ",//������Ϣ�Ի���
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();//�رմ���
                        }
                    }
                }
            }
            catch (Exception EX)//�����쳣
            {
                MessageBox.Show(EX.Message, "��ʾ",//������Ϣ�Ի���
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                operate.Read_Image(openFileDialog1, pictureBox1);//��ȡ����ʾͼ����Ϣ
            }
            catch
            {
                MessageBox.Show("����ͼƬ����");//������Ϣ�Ի���
            }
        }
        private void txtYGPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("ֻ����������", "��ʾ",//������Ϣ�Ի���
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;//�Ѿ���������¼�
            }
        }

        private void txtYGPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("ֻ����������", "��ʾ",//������Ϣ�Ի���
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;//�Ѿ���������¼�
            }
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            PrintForm.frmUserPrint userprint =//������ӡ�������
                new PMS.PrintForm.frmUserPrint();
            userprint.ShowDialog();//��ʾģʽ����
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strg = Application.StartupPath.ToString();//�õ�Ӧ�ó���·����Ϣ
            strg = strg.Substring(0, strg.LastIndexOf("\\"));//��ȡ·����Ϣ
            strg = strg.Substring(0, strg.LastIndexOf("\\"));//��ȡ�۾���Ϣ
            strg += @"\PMSImage";//���·����Ϣ
            strg += @"\default.jpg";//����ļ�����
            openFileDialog1.FileName = strg;//���ô��ļ�·����Ϣ
            pictureBox1.Image=System.Drawing.Image.//��ʾͼ����Ϣ
                FromFile(openFileDialog1.FileName);
        }
    }
}