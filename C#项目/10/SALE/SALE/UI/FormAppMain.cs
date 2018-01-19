using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SALE.BLL.Other;
using SALE.Common;

namespace SALE.UI
{
    public partial class FormAppMain : Form
    {
        AppMain am = new AppMain(); 

        public FormAppMain()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.timerTime.Start();
            this.statusLabelOperator.Text = "当前操作员：" + GlobalProperty.OperatorName;
            am.SetMenuItemEnabled(menuStripMain);
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            //通过(ToolStripMenuItem)sender.Tag.ToString()的值，判断该操作员是否具有权限，若无权限，给与提示
            am.ShowForm((ToolStripMenuItem)sender, this);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.statusLabelTime.Text = "当前时间：" + DateTime.Now.ToString();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("确定要退出吗？", "软件提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            this.Dispose();
        }
    }
}
