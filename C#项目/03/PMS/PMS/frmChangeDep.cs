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
    public partial class frmChangeDep : Form
    {
        public frmChangeDep()
        {
            InitializeComponent();
        }
        public string name;//�����ֶ�
        DBOperate operate = new DBOperate();//�������ݿ��������
        private void frmChangeDep_Load(object sender, EventArgs e)
        {
            txtDepName.Text = name;//�õ���������
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();//�رմ���
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql =//����SQL�ַ���
                "update tb_department set DepName='" + txtDepName.Text.Trim() + "' where DepName='"+name+"'";
            if (operate.OperateData(sql) > 0)
            {
                MessageBox.Show("�����޸ĳɹ�", "��ʾ",//������Ϣ�Ի���
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();//�رմ���
            }
        }
    }
}