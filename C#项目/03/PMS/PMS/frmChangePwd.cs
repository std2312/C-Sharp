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
    public partial class frmChangePwd : Form
    {
        public frmChangePwd()
        {
            InitializeComponent();
        }
        DBOperate operate = new DBOperate();//�������ݿ��������
        public string name;//�����ֶ�
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNewPwd.Text.Trim() == "" ||
                txtNewPwd2.Text.Trim() == "" ||
                txtOldPwd.Text.Trim() == "")
            {
                MessageBox.Show("�뽫������д����", "��ʾ",//������Ϣ�Ի���
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;//�˳��¼�
            }
            else
            {
                string str =//����SQL�ַ���
                    "select count(*) from tb_User where UserName='" + name + "' and UserPwd='" + this.txtOldPwd.Text.Trim() + "'";
                int i = operate.HumanNum(str);//�õ���¼����
                if (i > 0)
                {
                    if (txtNewPwd.Text.Trim() != txtNewPwd2.Text.Trim())
                    {
                        MessageBox.Show("�������벻һ��", "��ʾ",//������Ϣ�Ի���
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;//�˳��¼�
                    }
                    else
                    {
                        string updatestr =//����SQL�ַ���
                            "update tb_User set UserPwd='" + txtNewPwd2.Text.Trim() + "' where UserName='" + name + "'";
                        operate.OperateData(updatestr);//�������ݿ���Ϣ
                        MessageBox.Show("�����޸ĳɹ�", "��ʾ",//������Ϣ�Ի���
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();//�رմ���
                    }
                }
                else
                {
                    MessageBox.Show("���������", "��ʾ",//������Ϣ�Ի���
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;//�˳��¼�
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();//�رմ���
        }
    }
}