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
            string strg = Application.StartupPath.ToString();//�õ�Ӧ�ó���·��
            strg = strg.Substring(0, strg.LastIndexOf("\\"));//��ȡ·����Ϣ
            strg = strg.Substring(0, strg.LastIndexOf("\\"));//��ȡ·����Ϣ
            strg += @"\CrystalReport";//���·����Ϣ
            strg += @"\UserCheck.rpt";//����ļ�����
            crystalReportViewer1.ReportSource = strg;//�󶨵��ؼ�
        }
    }
}