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
    public partial class frmAddDep : Form
    {
        public frmAddDep()
        {
            InitializeComponent();
        }
        DBOperate operate = new DBOperate();//�������ݲ�������
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();//�رմ���
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtDepName.Text.Trim() == "")
            {
                MessageBox.Show("�����벿������", "��ʾ",//������Ϣ�Ի���
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;//�˳��¼�
            }
            else
            {
                string str=//����SQL�ַ���
                    "select count(*) from tb_department where DepName='"+txtDepName.Text.Trim()+"'";
                int i=operate.HumanNum(str);//�õ���¼����
                if (i > 0)
                {
                    MessageBox.Show("�ò����Ѿ�����", "��ʾ",//������Ϣ�Ի���
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;//�˳��¼�
                }
                else
                {
                    string Addsql =//����SQL�ַ���
                        "insert into tb_department(DepName) values('" + txtDepName.Text.Trim() + "')";
                    if (operate.OperateData(Addsql) > 0)
                    {
                        MessageBox.Show("��ӳɹ�", "��ʾ",//������Ϣ�Ի���
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}