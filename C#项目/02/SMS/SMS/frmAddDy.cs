using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
namespace SMS
{
    public partial class frmAddDy : Form
    {
        public frmAddDy()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void frmAddDy_Load(object sender, EventArgs e)
        {
            cbbType.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string strtype = cbbType.SelectedItem.ToString();
            string strnote = txtDy.Text;
            OleDbConnection conn = BaseClass.ConnClass.DataConn();
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("insert into tb_note([type],[note]) values('" + strtype + "','" + strnote + "')", conn);
            cmd.ExecuteNonQuery();
            txtDy.Text = "";
            MessageBox.Show("Ìí¼Ó³É¹¦");
            conn.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}