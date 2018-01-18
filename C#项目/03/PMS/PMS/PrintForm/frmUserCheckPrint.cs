using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PMS.PrintForm
{
    public partial class frmUserCheckPrint : Form
    {
        public frmUserCheckPrint()
        {
            InitializeComponent();
        }

        private void frmUserCheckPrint_Load(object sender, EventArgs e)
        {
            string strg = Application.StartupPath.ToString();//得到应用程序路径
            strg = strg.Substring(0, strg.LastIndexOf("\\"));//截取路径信息
            strg = strg.Substring(0, strg.LastIndexOf("\\"));//截取路径信息
            strg += @"\CrystalReport";//添加路径信息
            strg += @"\UserCheck.rpt";//添加文件名称
            crystalReportViewer1.ReportSource = strg;//绑定到控件
        }
    }
}