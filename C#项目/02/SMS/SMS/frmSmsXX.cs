using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
namespace SMS
{
    public partial class frmSmsXX : Form
    {
        public frmSmsXX()
        {
            InitializeComponent();
        }
        public string content;
        public string ResviceNum;
        public static string NUM;
        public static string JQCOM;
        public static string BTL;
        public string Power = "YIWU-IJDD-CDQW-JDWG";
        public static int k = 0;
        public static int j = 0;
        public string Did;
        public string Dnum;
        public string Dcontent;
        private void frmSmsXX_Load(object sender, EventArgs e)
        {
            txtFrom.Text = Dnum;
            txtContent.Text = Dcontent;
            NUM = BaseClass.GSM.GSMModemGetSnInfoNew(JQCOM, BTL);��//��������
            JQCOM = BaseClass.GSM.GSMModemGetDevice();����//�ãϣͣ�
            BTL = BaseClass.GSM.GSMModemGetBaudrate();����//������
        }
        private void AddMessage(string num, string strcontent, string sendtime)
        {
            OleDbConnection conn = BaseClass.ConnClass.DataConn();
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("insert into tb_TelSend([TelNum],[TelContent],[TelTime]) values('" + num + "','" + strcontent + "','" + sendtime + "')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        private void SendSms(string strcom, string strbtl)
        {
            ////�����豸
            if (BaseClass.GSM.GSMModemInitNew(strcom, strbtl, null, null, false, Power) == false)
            {
                MessageBox.Show("�豸����ʧ��!" + BaseClass.GSM.GSMModemGetErrorMsg(), "��ʾ", MessageBoxButtons.OK);
                return;
            }
            // ���Ͷ���
                AddMessage(txtFrom.Text,txtSmsContent.Text, DateTime.Now.ToString());
                if (BaseClass.GSM.GSMModemSMSsend(null, 8, content, Encoding.Default.GetByteCount(content), txtFrom.Text, false) == true)
                    k++;
                MessageBox.Show("�ظ����ųɹ�!", "��ʾ", MessageBoxButtons.OK);
        }

        private void btnReply_Click(object sender, EventArgs e)
        {
            if (txtSmsContent.Text == "")
            {
                MessageBox.Show("�������������");
            }
            else
            {
                content = txtSmsContent.Text;
                SendSms(JQCOM, BTL);
                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}