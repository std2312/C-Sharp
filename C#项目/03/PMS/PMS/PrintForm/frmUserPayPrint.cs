using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PMS.PMSClass;
using System.Data.SqlClient;
namespace PMS.PrintForm
{
    public partial class frmUserPayPrint : Form
    {
        public frmUserPayPrint()
        {
            InitializeComponent();
        }
        DBOperate operate = new DBOperate();//�������ݿ��������
        public string num;//�����ֶ�
        private void frmUserPayPrint_Load(object sender, EventArgs e)
        {
            string str = "select * from tb_pay " + num;//����SQL�ַ���
            SqlConnection conn = DBConnection.MyConnection();//�õ����ݿ����Ӷ���
            SqlDataAdapter sda = new SqlDataAdapter(str, conn);//��������������
            DataSet ds = new DataSet();//�������ݼ�
            sda.Fill(ds);//������ݼ�
            userPay1.SetDataSource(ds.Tables[0]);//��������Դ
            crystalReportViewer1.ReportSource = userPay1;//�󶨵��ؼ�
        }
    }
}