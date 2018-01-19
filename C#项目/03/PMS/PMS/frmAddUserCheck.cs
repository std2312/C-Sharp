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
    public partial class frmAddUserCheck : Form
    {
        public frmAddUserCheck()
        {
            InitializeComponent();
        }
        DBOperate operate = new DBOperate();//�������ݿ��������
        private void �˳�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();//�رմ���
        }

        private void frmAddUserCheck_Load(object sender, EventArgs e)
        {
            operate.BindDropdownlist("tb_employee",cbbnum,1);//��ComboBox�ؼ�
        }

        private void cbbnum_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql =//����SQL�ַ���
                "select * from tb_employee where employeeID='"+cbbnum.Text+"'";
            DataSet ds = operate.GetTable(sql);//�õ����ݼ�
            ds.Dispose();//�ͷ���Դ
            txtdep.Text = ds.Tables[0].Rows[0][4].ToString();//�õ��Ų���Ϣ
            txtname.Text = ds.Tables[0].Rows[0][2].ToString();//�õ�Ա������
        }

        private void ���ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cbbnum.Text == "" || txtcontent.Text == "" ||
                txtresult.Text == "" || txtkp.Text == "" ||
                txtscore.Text == "")
            {
                MessageBox.Show("�뽫��Ϣ��д����", "��ʾ",//������Ϣ�Ի���
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;//�˳��¼�
            }
            else
            {
                string sql =//����SQL�ַ���
                    "select count(*) from tb_check where PID='"+cbbnum.Text+"'";
                int i = operate.HumanNum(sql);//��ѯָ��Ա��������Ϣ
                if (i > 0)
                {
                    MessageBox.Show("��Ա���Ѿ�����������",//������Ϣ�Ի���
                        "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;//�˳��¼�
                }
                else
                {
                    string addstr =//����SQL�ַ���
                        "insert into tb_check(PID,Pname,Pdep,PKpcontent,PKpResult,PKpscore,PKpPeople,PKpDate) values('" + cbbnum.Text + "','" + txtname.Text + "','" + txtdep.Text + "','" + txtcontent.Text + "','" + txtresult.Text + "','" + txtscore.Text + "','" + txtkp.Text + "','" + txtkpdate.Text+ "')";
                    if (operate.OperateData(addstr) > 0)
                    {
                        MessageBox.Show("��ӳɹ���", "��ʾ",//������Ϣ�Ի���
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void txtscore_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("ֻ����������", "��ʾ",//������Ϣ�Ի���
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;//�Ѿ���������¼�
            }
        }

        private void txtscore_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtscore.Text == "")
                {
                    MessageBox.Show("��������Ϊ��",//������Ϣ�Ի���
                        "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;//�˳��¼�
                }
                else
                {
                    if (Convert.ToInt32(txtscore.Text) > 100)
                    {
                        MessageBox.Show("����Ϊ100��", "��ʾ",//������Ϣ�Ի���
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;//�˳��¼�
                    }
                }
            }
            catch
            {
                MessageBox.Show("��������", "��ʾ",//������Ϣ�Ի���
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}