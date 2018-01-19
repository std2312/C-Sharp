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
    public partial class frmUserCheckChange : Form
    {
        public frmUserCheckChange()
        {
            InitializeComponent();
        }
        DBOperate operate = new DBOperate();//�������ݿ��������
        public string pid;//�����ֶ�
        public string pname;//�����ֶ�
        private void �˳�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();//�رմ���
        }

        private void �޸�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtcontent.Text == "" || txtresult.Text == "" ||
                txtscore.Text == "" || txtkp.Text == "")
            {
                MessageBox.Show("�뽫��Ϣ��д����", "��ʾ",//������Ϣ�Ի���
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;//�˳��¼�
            }
            else
            {
                string sql =//����SQL�ַ���
                    "update tb_check set PKpcontent='"+txtcontent.Text+"',PKpResult='"+txtresult.Text+"',PKpscore='"+txtscore.Text+"',PKpPeople='"+txtkp.Text+"',PKpDate='"+txtkpdate.Text+"' where PID='"+cbbnum.Text+"'";
                if (operate.OperateData(sql) > 0)
                {
                    MessageBox.Show("�޸ĳɹ���", "��ʾ",//������Ϣ�Ի���
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void frmUserCheckChange_Load(object sender, EventArgs e)
        {
            this.Text = "��������[" + pname + "]";//���ô������
            operate.BindDropdownlist("tb_employee", cbbnum, 1);//��ComboBox�ؼ�
            string sql = //����SQL�ַ���
                "select * from tb_check where PID='" + pid+ "'";
            DataSet ds = operate.GetTable(sql);//�õ����ݼ�
            ds.Dispose();//�ͷ���Դ
            cbbnum.SelectedItem=ds.Tables[0].Rows[0][1].ToString();//����Ա�����
            txtname.Text = ds.Tables[0].Rows[0][2].ToString();//����Ա������
            txtdep.Text = ds.Tables[0].Rows[0][3].ToString();//����Ա�����ڲ���
            txtcontent.Text = ds.Tables[0].Rows[0][4].ToString();//���ÿ�������
            txtresult.Text = ds.Tables[0].Rows[0][5].ToString();//���ÿ������
            txtscore.Text = ds.Tables[0].Rows[0][6].ToString();//���ÿ�������
            txtkp.Text = ds.Tables[0].Rows[0][7].ToString();//���ÿ�����
            txtkpdate.Text = ds.Tables[0].Rows[0][8].ToString();//���ÿ�������

        }

        private void txtscore_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("ֻ����������", "��ʾ",//������Ϣ�Ի���
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;//�Ѿ�������¼�
            }
        }

        private void txtscore_TextChanged(object sender, EventArgs e)
        {
            if (txtscore.Text == "")
            {
                MessageBox.Show("��������Ϊ��", "��ʾ",//������Ϣ�Ի���
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}