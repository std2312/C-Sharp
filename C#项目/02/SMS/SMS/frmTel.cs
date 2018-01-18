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
    public partial class frmTel : Form
    {
        public frmTel()
        {
            InitializeComponent();
        }

        private void frmTel_Load(object sender, EventArgs e)
        {
            SetTelData();
        }
        private void SetTelData()
        {
            OleDbConnection conn = BaseClass.ConnClass.DataConn();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from tb_tel order by ID desc",conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvAllUser.DataSource = ds.Tables[0];
        }
        private void pbDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定删除吗？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                string id = dgvAllUser.SelectedCells[0].Value.ToString();
                OleDbConnection conn = BaseClass.ConnClass.DataConn();
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("delete from tb_tel where ID=" + id, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("删除联系人成功");
                SetTelData();
            }
        }
        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}