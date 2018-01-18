using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Daila.NewClass;
using System.Data.OleDb;
using System.Data;

using Daila.NewMehod;
namespace Daila
{
    public partial class frmtbProPathNew : Form
    {
        public frmtbProPathNew()
        {
            InitializeComponent();
        }

        private void frmtbProPathNew_Load(object sender, EventArgs e)
        {
            bntOK.Enabled = false;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox1.Text != "")
            {
                bntOK.Enabled = true;
            }
        }

        private void bntEsce_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntOK_Click(object sender, EventArgs e)
        {
            tbProPathClass tbCalss = new tbProPathClass();
            tbProPathMenthod tbMenthod = new tbProPathMenthod();
            if (textBox1.Text == "")
            {
                MessageBox.Show("名称：不能为空！","提示");
            }
            tbCalss.ProID = tbMenthod.tbProPathID();
            tbCalss.ProName = textBox1.Text;
            tbCalss.ProPath = "0";
            int intResult = tbMenthod.tbProPathMenthodAdd(tbCalss);
            if (intResult == 1)
            {
                MessageBox.Show("添加成功！");
                frmtbProPath frm = (frmtbProPath)this.Owner;
                tbMenthod.filltbProPath(frm.treeView1, frm.imageList1);
                this.Close();

            }
            else
            {
                MessageBox.Show("添加失败！");
            }
        }
    }
}