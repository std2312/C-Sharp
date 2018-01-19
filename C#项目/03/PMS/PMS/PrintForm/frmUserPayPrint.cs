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
        DBOperate operate = new DBOperate();//创建数据库操作对象
        public string num;//声明字段
        private void frmUserPayPrint_Load(object sender, EventArgs e)
        {
            string str = "select * from tb_pay " + num;//创建SQL字符串
            SqlConnection conn = DBConnection.MyConnection();//得到数据库连接对象
            SqlDataAdapter sda = new SqlDataAdapter(str, conn);//创建数据适配器
            DataSet ds = new DataSet();//创建数据集
            sda.Fill(ds);//填充数据集
            userPay1.SetDataSource(ds.Tables[0]);//设置数据源
            crystalReportViewer1.ReportSource = userPay1;//绑定到控件
        }
    }
}