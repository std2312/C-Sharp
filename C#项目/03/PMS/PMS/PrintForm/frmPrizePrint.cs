using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PMS.PrintForm
{
    public partial class frmPrizePrint : Form
    {
        public frmPrizePrint()
        {
            InitializeComponent();
        }

        private void frmPrizePrint_Load(object sender, EventArgs e)
        {
            string strg = Application.StartupPath.ToString();//�õ�Ӧ�ó���·��
            strg = strg.Substring(0, strg.LastIndexOf("\\"));//��ȡ·����Ϣ
            strg = strg.Substring(0, strg.LastIndexOf("\\"));//��ȡ·����Ϣ
            strg += @"\CrystalReport";//���·����Ϣ
            strg += @"\UserPrize.rpt";//����ļ�����
            crystalReportViewer1.ReportSource = strg;//�󶨵��ؼ�
        }
    }
}