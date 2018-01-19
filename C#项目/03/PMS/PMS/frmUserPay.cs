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
    public partial class frmUserPay : Form
    {
        public frmUserPay()
        {
            InitializeComponent();
        }
        DBOperate operate = new DBOperate();//�������ݿ��������
        private void toolStripLabel6_Click(object sender, EventArgs e)
        {
            this.Close();//�رմ���
        }
        public string months;//�����ֶ�
        private void frmUserPay_Load(object sender, EventArgs e)
        {
            string sql =//����SQL�ַ���
                "select YID as '���',YName as '����',YSex as '�Ա�',Ydep as '����',YZhiwu as 'ְ��',YBasePay as '��������',YJintie as 'ְ�����',Yjiangli as '����',YFK as '����',Yquanqin as 'ȫ�ڽ���',Yjiaban as '�Ӱ๤��',Yyingfa as 'Ӧ������',Ygeren as '��������˰',Ypay as 'ʵ������',YMonth as 'ͳ���·�' from tb_pay";
            operate.BindDataGridView(dataGridView1, sql);//�󶨵�DataGridView�ؼ�
            months = "";//����Ϊ���ַ���
            for (int i = 1; i <= 12; i++)
            {
                toolStripComboBox1.Items.Add(i + "��");//����·���Ϣ
            }
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            PrintForm.frmUserPayPrint payprint =//������ӡ�������
                new PMS.PrintForm.frmUserPayPrint();
            payprint.num = months;//Ϊ������ֶθ�ֵ
            payprint.ShowDialog();//��ʾģʽ����
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string xmonth = toolStripComboBox1.SelectedItem.ToString().Substring(0, 1);//�õ�ѡ����·�
            string sql =//����SQL�ַ���
                "select YID as '���',YName as '����',YSex as '�Ա�',Ydep as '����',YZhiwu as 'ְ��',YBasePay as '��������',YJintie as 'ְ�����',Yjiangli as '����',YFK as '����',Yquanqin as 'ȫ�ڽ���',Yjiaban as '�Ӱ๤��',Yyingfa as 'Ӧ������',Ygeren as '��������˰',Ypay as 'ʵ������',YMonth as 'ͳ���·�' from tb_pay where YMonth='" + xmonth + "'";
            operate.BindDataGridView(dataGridView1, sql);//�󶨵�DataGridView�ؼ�
            months = "where YMonth='" + xmonth + "'";//����SQL�ַ���
        }
    }
}