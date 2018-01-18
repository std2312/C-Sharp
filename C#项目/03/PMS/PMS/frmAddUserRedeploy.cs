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
    public partial class frmAddUserRedeploy : Form
    {
        public frmAddUserRedeploy()
        {
            InitializeComponent();
        }
        DBOperate operate = new DBOperate();//�������ݿ��������
        private void �˳�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();//�رմ���
        }

        private void frmAddUserRedeploy_Load(object sender, EventArgs e)
        {
            operate.BindDropdownlist("tb_employee",cbbnum,1);//�����е�Ա�����
            operate.BindDropdownlist("tb_department",cbbdep2,1);//�����еĲ�������
            operate.BindDropdownlist("tb_userJob",cbbjob2,1);//�����е�ְ���б�
        }

        private void cbbnum_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = cbbnum.Text;//�õ�ID��Ϣ
            string sql =//����SQL�ַ���
                "select * from tb_employee where employeeID='"+id+"'";
            DataSet ds = operate.GetTable(sql);//�õ����ݼ�
            txtname.Text=ds.Tables[0].Rows[0][2].ToString();//��ʾ������Ϣ
            txtdep1.Text = ds.Tables[0].Rows[0][4].ToString();//��ʾԭ������Ϣ
            txtjob1.Text = ds.Tables[0].Rows[0][8].ToString();//��ʾԭְ����Ϣ
            txtpay1.Text = ds.Tables[0].Rows[0][12].ToString();//��ʾԭ������Ϣ
        }

        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cbbnum.Text == "" || cbbdep2.Text == "" ||
                cbbjob2.Text == "" || txtNewPay.Text.Trim() == "" ||
                txtdate.Text == "" || txtexplain.Text.Trim() == "")
            {
                MessageBox.Show("�뽫��Ϣ��д����", "��ʾ",//������Ϣ�Ի���
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;//�˳��¼�
            }
            else
            {
                string sql =//����SQL�ַ���
                    "select count(*) from tb_redeploy where UID='"+cbbnum.Text+"'";
                int i = operate.HumanNum(sql);//��������
                if (i > 0)
                {
                    MessageBox.Show("�Ѿ���ӹ���Ա���ĵ�����Ϣ",//������Ϣ�Ի���
                        "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;//�˳��¼�
                }
                else
                {
                    string update1 =//����SQL�ַ���
                        "update tb_employee set employeeDept='" + cbbdep2.Text + "' where employeeID='" + cbbnum.Text + "'";
                    operate.OperateData(update1);//�������ݿ���Ϣ
                    string Insertstr =//����SQL�ַ���
                        "insert into tb_redeploy(UID,UName,URemoveDate,UOldDep,UNewDep,UOldJob,UNewJob,UOldPay,UNewPay,UPayExplain) values('"+cbbnum.Text+"','"+txtname.Text+"','"+txtdate.Text+"','"+txtdep1.Text+"','"+cbbdep2.Text+"','"+txtjob1.Text+"','"+cbbjob2.Text+"','"+txtpay1.Text+"','"+txtNewPay.Text.Trim()+"','"+txtexplain.Text+"')";
                    if (operate.OperateData(Insertstr) > 0)
                    {
                        MessageBox.Show("��ӳɹ���", "��ʾ",//������Ϣ�Ի���
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    string updatestr =//����SQL�ַ���
                        "update tb_employee set employeePay='" + txtNewPay.Text + "' where employeeID='"+cbbnum.Text+"'";
                    operate.OperateData(updatestr);//�������ݿ���Ϣ
                }
            }
        }
        private void txtNewPay_KeyPress_1(object sender, KeyPressEventArgs e)
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