using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace PMS.PrintForm
{
    public partial class frmUserPrint : Form
    {
        public frmUserPrint()
        {
            InitializeComponent();
        }
        private void frmUserPrint_Load(object sender, EventArgs e)
        {
            string strg = Application.StartupPath.ToString();//得到应用程序路径
            strg = strg.Substring(0, strg.LastIndexOf("\\"));//截取路径
            strg = strg.Substring(0, strg.LastIndexOf("\\"));//截取路径
            strg += @"\CrystalReport";//添加路径
            strg += @"\UserInfo.rpt";//添加文件名称
            crystalReportViewer1.ReportSource = strg;//绑定到控件
        }
    }
}