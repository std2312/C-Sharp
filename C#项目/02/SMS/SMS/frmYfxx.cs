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
    public partial class frmYfxx : Form
    {
        public frmYfxx()
        {
            InitializeComponent();
        }

        private void frmYfxx_Load(object sender, EventArgs e)
        {
            BindSms();
            comboBox1.SelectedIndex = 0;
            comboBox1.SelectedText = "电话号码";
        }
        private void BindSms()
        {
            OleDbConnection conn = BaseClass.ConnClass.DataConn();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from tb_TelSend order by ID desc",conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定删除吗？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    string id = dataGridView1.SelectedCells[0].Value.ToString();
                    string str = "delete from tb_TelSend where ID=" + id;
                    DelData(str);
                    MessageBox.Show("删除成功");
                    BindSms();
                }
                else
                {
                    MessageBox.Show("请选择要删除的信息");
                }
            }
        }

        private void DelData(string strsql)
        {
            OleDbConnection conn = BaseClass.ConnClass.DataConn();
            conn.Open();
            OleDbCommand cmd = new OleDbCommand(strsql,conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定删除吗？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                string str = "delete from tb_TelSend";
                DelData(str);
                MessageBox.Show("信息已经全部清空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                BindSms();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BindSms();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            string strsql = "";
            if (textBox1.Text == "")
            {
                MessageBox.Show("请输入关键字");
            }
            else
            {
                string comstr=comboBox1.SelectedItem.ToString();
                switch(comstr)
                {
                    case "手机号码": strsql = "select * from tb_TelSend where TelNum like '%" + textBox1.Text + "%'"; break;
                    case "短信内容": strsql = "select * from tb_TelSend where TelContent like '%" + textBox1.Text + "%'"; break;
                    case "发送时间": strsql = "select * from tb_TelSend where TelTime like '%" + textBox1.Text + "%'"; break;
                }
                OleDbConnection conn = BaseClass.ConnClass.DataConn();
                OleDbDataAdapter da = new OleDbDataAdapter(strsql, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }
    }
}