using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


using Daila.NewClass;

using Daila.NewMehod;
using System.Data.OleDb;
namespace Daila
{
    public partial class frmTel : Form
    {
        public frmTel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                MessageBox.Show("输入查询条件！", "提示");
                textBox1.Focus();
                return;
            }
            tbTelRecordClass tbClass = new tbTelRecordClass();
            tbTelRecordMenthod tbMenthod = new tbTelRecordMenthod();
     
                tbClass.strfldTel = textBox1.Text;
                OleDbDataReader dr = tbMenthod.tbTelRecordSecrf(tbClass,"1");
                dr.Read();
                listView1.Items.Clear();
                if (dr.HasRows)
                {
                    listView1.Items.Add(dr[1].ToString());
                    listView1.Items[0].SubItems.Add(dr[2].ToString());
                    listView1.Items[0].SubItems.Add(dr[3].ToString());
                    listView1.Items[0].SubItems.Add(dr[5].ToString());
                }//
                dr.Close();
     
           
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}