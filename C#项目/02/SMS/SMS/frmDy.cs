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
    public partial class frmDy : Form
    {
        public frmDy()
        {
            InitializeComponent();
        }

        private void frmDy_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbConnection conn = BaseClass.ConnClass.DataConn();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from tb_note where type='" + comboBox1.SelectedItem.ToString() + "'", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvShow.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        public string  stringSedn="";
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            stringSedn+=dgvShow.SelectedCells[0].Value.ToString();
            frmSendSMS frmsend = (frmSendSMS)this.Owner;
            frmsend.txtSmsContent.Text = stringSedn;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}