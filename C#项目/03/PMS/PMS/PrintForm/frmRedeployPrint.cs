using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PMS.PrintForm
{
    public partial class frmRedeployPrint : Form
    {
        public frmRedeployPrint()
        {
            InitializeComponent();
        }

        private void frmRedeployPrint_Load(object sender, EventArgs e)
        {
            string strg = Application.StartupPath.ToString();//�õ�Ӧ�ó���·����Ϣ
            strg = strg.Substring(0, strg.LastIndexOf("\\"));//��ȡ·����Ϣ
            strg = strg.Substring(0, strg.LastIndexOf("\\"));//��ȡ·����Ϣ
            strg += @"\CrystalReport";//���·����Ϣ
            strg += @"\UserRedeploy.rpt";//����ļ�����
            crystalReportViewer1.ReportSource = strg;//�󶨵��ؼ�
        }
    }
}