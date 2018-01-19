using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PMS.PMSClass;
using System.Text.RegularExpressions;
namespace PMS
{
    public partial class frmChangeUserRedeploy : Form
    {
        public frmChangeUserRedeploy()
        {
            InitializeComponent();
        }
        DBOperate operate = new DBOperate();//�������ݿ��������
        public string id;//����id�ֶ�
        public string name;//����name�ֶ�
        private void �˳�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();//�رմ���
        }

        private void frmChangeUserRedeploy_Load(object sender, EventArgs e)
        {
            this.Text = "��Ա������ϸ��Ϣ["+name+"]";//��ʾ�������
            operate.BindDropdownlist("tb_employee",cbbnum,1);//�󶨵�ComboBox�ؼ�
            operate.BindDropdownlist("tb_department", cbbdep2, 1);//�󶨵�ComboBox�ؼ�
            operate.BindDropdownlist("tb_userJob", cbbjob2, 1);//�󶨵�ComboBox�ؼ�
            string sql =//����SQL�ַ���
                "select * from tb_redeploy where UID='"+id+"'";
            DataSet ds = operate.GetTable(sql);//�õ����ݼ�
            ds.Dispose();//�ͷ���Դ
            cbbnum.Text = ds.Tables[0].Rows[0][1].ToString();//�õ�Ա�������Ϣ
            txtname.Text = ds.Tables[0].Rows[0][2].ToString();//�õ�Ա��������Ϣ
            txtdep1.Text = ds.Tables[0].Rows[0][4].ToString();//�õ�ԭ������Ϣ
            cbbdep2.SelectedItem = ds.Tables[0].Rows[0][5].ToString();//�õ��ֲ�����Ϣ
            txtjob1.Text = ds.Tables[0].Rows[0][6].ToString();//�õ�ԭְ����Ϣ
            cbbjob2.SelectedItem=ds.Tables[0].Rows[0][7].ToString();//�õ���ְ����Ϣ
            txtpay1.Text = ds.Tables[0].Rows[0][8].ToString();//�õ�ԭ������Ϣ
            txtNewPay.Text = ds.Tables[0].Rows[0][9].ToString();//�õ����ʵ�����Ϣ
            txtdate.Text = ds.Tables[0].Rows[0][3].ToString();//�õ�������Ϣ
            txtexplain.Text = ds.Tables[0].Rows[0][10].ToString();//�õ�����˵����Ϣ
        }

        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
             if (cbbdep2.Text == "" || cbbjob2.Text == "" ||
                 txtNewPay.Text == "" || txtdate.Text == "" ||
                 txtexplain.Text == "")
             {
                 MessageBox.Show("�뽫��Ϣ��д������",//������Ϣ�Ի���
                     "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
             else
             {
                 string updatestr =//����SQL�ַ���
                     "update tb_redeploy set UNewDep='"+cbbdep2.Text+"',UNewJob='"+cbbjob2.Text+"',UNewPay='"+txtNewPay.Text.Trim()+"',URemoveDate='"+txtdate.Text+"',UPayExplain='"+txtexplain.Text+"' where UID='"+cbbnum.Text+"'";
                 if (operate.OperateData(updatestr) > 0)
                 {
                     MessageBox.Show("�޸ĳɹ���", "��ʾ",//������Ϣ�Ի���
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                 }
             }
        }

        private void txtNewPay_KeyPress(object sender, KeyPressEventArgs e)
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