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
            string strg = Application.StartupPath.ToString();//�õ�Ӧ�ó���·��
            strg = strg.Substring(0, strg.LastIndexOf("\\"));//��ȡ·��
            strg = strg.Substring(0, strg.LastIndexOf("\\"));//��ȡ·��
            strg += @"\CrystalReport";//���·��
            strg += @"\UserInfo.rpt";//����ļ�����
            crystalReportViewer1.ReportSource = strg;//�󶨵��ؼ�
        }
    }
}