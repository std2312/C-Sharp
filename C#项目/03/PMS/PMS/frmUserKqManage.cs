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
    public partial class frmUserKqManage : Form
    {
        public frmUserKqManage()
        {
            InitializeComponent();
        }
        DBOperate operate = new DBOperate();//�������ݿ��������
        public string Ydate;//�����ֶ�
        private void frmUserKqManage_Load(object sender, EventArgs e)
        {
            operate.BindDropdownlist("tb_employee",cbbYnum,1);
            for (int i = 1; i <= 12; i++)
            {
                toolStripComboBox1.Items.Add(i+"��");//����·�
            }
        }

        private void cbbYnum_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = cbbYnum.Text;//�õ�ID��Ϣ
            string sql =//����SQL�ַ���
                "select * from tb_employee where employeeID='" + id + "'";
            DataSet ds = operate.GetTable(sql);//�õ����ݼ�
            ds.Dispose();//�ͷ���Դ
            txtYname.Text = ds.Tables[0].Rows[0][2].ToString();//�õ�������Ϣ
            txtYsex.Text = ds.Tables[0].Rows[0][3].ToString();//�õ��Ա���Ϣ
            txtYdep.Text = ds.Tables[0].Rows[0][4].ToString();//�õ�������Ϣ
            txtYzhiwu.Text = ds.Tables[0].Rows[0][8].ToString();//�õ�ְ����Ϣ
            txtYbasepay.Text = ds.Tables[0].Rows[0][12].ToString();//�õ�����������Ϣ
            switch (txtYzhiwu.Text)
            {
                case "�ܾ���": txtYjintie.Text = "500"; break;//�жϽ���
                case "���ܾ���": txtYjintie.Text = "400"; break;//�жϽ���
                case "��Ŀ����": txtYjintie.Text = "300"; break;//�жϽ���
                case "���ž���": txtYjintie.Text = "200"; break;//�жϽ���
                case "����Ա": txtYjintie.Text = "100"; break;//�жϽ���
                case "��Ա"://�жϽ���
                case "����": txtYjintie.Text = "50"; break;//�жϽ���
            }
            string sql1 =//����SQL�ַ���
                "select * from tb_prize where UserID='"+id+"'";
            DataSet ds1 = operate.GetTable(sql1);//�õ����ݼ�
            ds.Dispose();//�ͷ���Դ
            string str =//����SQL�ַ���
                "select count(*) from tb_prize where UserID='" + id + "'";
            int i = operate.HumanNum(str);//��ȡ��¼����
            if (i > 0)
            {
                if (ds1.Tables[0].Rows[0][8].ToString().Substring(6, 1) == Ydate)
                {
                    txtYjiangli.Text = ds1.Tables[0].Rows[0][6].ToString();//�õ�������Ϣ
                    txtYfakuan.Text = ds1.Tables[0].Rows[0][7].ToString();//�õ�������Ϣ
                }
                else
                {
                    txtYfakuan.Text = "0";//�õ�������Ϣ
                    txtYjiangli.Text = "0";//�õ�������Ϣ
                }
            }
            else
            {
                txtYfakuan.Text = "0";//�õ�������Ϣ
                txtYjiangli.Text = "0";//�õ�������Ϣ
            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            if (txtYjiaban.Text == "" || txtYquanqin.Text == "" ||
                toolStripComboBox1.Text == "" || cbbYnum.Text == "")
            {
                MessageBox.Show("����ѡ���ʵ��·ݣ�Ȼ����Ϣ��д����",//������Ϣ�Ի���
                    "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string str =//����SQL�ַ���
                    "select count(*) from tb_pay where YID='" + cbbYnum.Text + "' and YMonth='"+Ydate+"'";
                int i = operate.HumanNum(str);//�õ���¼����
                if (i > 0)
                {
                    MessageBox.Show(Ydate + "�·�" + txtYname.Text +//������Ϣ�Ի���
                        "�Ĺ����Ѿ�����ͳ��", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {
                        string id = cbbYnum.Text;//Ա�����
                        string name = txtYname.Text;//Ա������
                        string sex = txtYsex.Text;//Ա���Ա�
                        string dep = txtYdep.Text;//Ա������
                        string zhiwu = txtYzhiwu.Text;//ְ��
                        string basepay = txtYbasepay.Text;//��������
                        string zhiwujintie = txtYjintie.Text;//ְ�����
                        string jiangli = txtYjiangli.Text;//����
                        string fakuan = txtYfakuan.Text;//����
                        string quanqin = txtYquanqin.Text;//ȫ�ڽ���
                        string jiaban = txtYjiaban.Text;//�Ӱ๤��
                        string Ymonth = Ydate;//�·�
                        decimal yingfa = Convert.ToDecimal(basepay) +//�����������˰
                            Convert.ToDecimal(zhiwujintie) + Convert.ToDecimal(jiangli)
                            - Convert.ToDecimal(fakuan) + Convert.ToDecimal(quanqin) +
                            Convert.ToDecimal(jiaban);//Ӧ������
                        decimal geren = operate.GYSD(Convert.ToInt32(yingfa));//�����������˰
                        decimal shifa = yingfa - geren;//ʵ������
                        string sql =//����SQL�ַ���
                            "insert into tb_pay(YID,YName,YSex,Ydep,YZhiwu,YBasePay,YJintie,Yjiangli,YFK,Yquanqin,Yjiaban,Yyingfa,Ygeren,Ypay,YMonth) values('" + id + "','" + name + "','" + sex + "','" + dep + "','" + zhiwu + "','" + basepay + "','" + zhiwujintie + "','" + jiangli + "','" + fakuan + "','" + quanqin + "','" + jiaban + "','" + yingfa + "','" + geren + "','" + shifa + "','" + Ydate + "')";
                        if (operate.OperateData(sql) > 0)
                        {
                            MessageBox.Show("��ӳɹ�", "��ʾ",//������Ϣ�Ի���
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)//�����쳣
                    {
                        MessageBox.Show(ex.Message);//������Ϣ�Ի���
                    }
                }
            }
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbYnum.Enabled = true;//���ÿؼ�
            Ydate = toolStripComboBox1.SelectedItem.//�õ��·���Ϣ
                ToString().Substring(0,1);
        }

        private void txtYquanqin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("ֻ����������", "��ʾ",//������Ϣ�Ի���
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;//�Ѿ���������¼�
            }
        }

        private void txtYjiaban_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("ֻ����������", "��ʾ",//������Ϣ�Ի���
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;//�Ѿ���������¼�
            }
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            this.Close();//�رմ���
        }
    }
}