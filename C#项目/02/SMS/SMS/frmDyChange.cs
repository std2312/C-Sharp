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
    public partial class frmDyChange : Form
    {
        public frmDyChange()
        {
            InitializeComponent();
        }
        public string Stype;
        public string Scontent;
        public string Sid;
        private void frmDyChange_Load(object sender, EventArgs e)
        {
            txttype.Text = Stype;
            txtContent.Text = Scontent;
        }

        private void btnSure_Click(object sender, EventArgs e)
        {
            if (txtContent.Text == "")
            {
                MessageBox.Show("«Î ‰»Î≥£”√∂Ã”Ô");
            }
            else
            {
                OleDbConnection conn = BaseClass.ConnClass.DataConn();
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("update tb_note set [note]='"+txtContent.Text+"' where ID="+Sid, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                this.Hide();

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}