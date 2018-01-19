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
    public partial class frmCydy : Form
    {
        public frmCydy()
        {
            InitializeComponent();
        }
        private string str;
        private void frmCydy_Load(object sender, EventArgs e)
        {
            
        }
        public void BindData()
        {
            string str1 = "select * from tb_note where type='" + str + "'";
            OleDbConnection conn = BaseClass.ConnClass.DataConn();
            OleDbDataAdapter oda = new OleDbDataAdapter(str1, conn);
            DataSet ds = new DataSet();
            oda.Fill(ds);
            dgvShow.DataSource = ds.Tables[0];
        }
        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbDelete_Click(object sender, EventArgs e)
        {
           string id = dgvShow.SelectedCells[0].Value.ToString();
           OleDbConnection conn = BaseClass.ConnClass.DataConn();
           conn.Open();
           OleDbCommand cmd = new OleDbCommand("delete from tb_note where ID=" + id, conn);
           cmd.ExecuteNonQuery();
           conn.Close();
           MessageBox.Show("É¾³ý³É¹¦");
           BindData();
        }

        private void dgvShow_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = this.dgvShow.SelectedCells[0].Value.ToString();
            string content = this.dgvShow.SelectedCells[2].Value.ToString();
            string type = tvDy.SelectedNode.Text;
            frmDyChange dychange = new frmDyChange();
            dychange.Scontent = content;
            dychange.Sid = id;
            dychange.Stype = type;
            dychange.ShowDialog();
        }

        private void frmCydy_Activated(object sender, EventArgs e)
        {
            BindData();
        }

        private void tvDy_AfterSelect(object sender, TreeViewEventArgs e)
        {
            str = tvDy.SelectedNode.Text;
            BindData();
        }
    }
}