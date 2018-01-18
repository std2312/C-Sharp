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
    public partial class frmResvice : Form
    {
        public frmResvice()
        {
            InitializeComponent();
        }
        public static string jcom;
        public static string btl;
        public string power = "YIWU-IJDD-CDQW-JDWG";
        private void frmResvice_Load(object sender, EventArgs e)
        {
            jcom=BaseClass.GSM.GSMModemGetDevice();　　//ＣＯＭ１
            btl = BaseClass.GSM.GSMModemGetBaudrate();　　//波特率
            //连接设备
            if (BaseClass.GSM.GSMModemInitNew(jcom, btl, null, null, false, power) == false)
            {
                MessageBox.Show("设备连接失败!" + BaseClass.GSM.GSMModemGetErrorMsg(), "提示", MessageBoxButtons.OK);
                return;
            }
            string smscontent = BaseClass.GSM.GSMModemSMSReadAll(1);
            if (smscontent==null)
            {
                MessageBox.Show("暂时没有新的信息！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                DelData();
                string newstr = smscontent.Replace("||", "#");
                string[] scontent = newstr.Split('#');
                string smscon = "";
                for (int i = 0; i < scontent.Length; i++)
                {
                    smscon = scontent[i];
                    string[] a = smscon.Split('|');
                    string b = "";
                    b = a[0].ToString();
                    if (b.Length < 11&&smscon!="")
                    {
                        string smsstr = b;
                        string smscot = scontent[i].Substring(b.Length, scontent[i].Length - b.Length).Replace("|", "");
                        AddData(smsstr, smscot);
                    }
                    else
                    {
                        if (smscon != "")
                        {
                            if (scontent[i].Substring(0, 1) == "|")
                            {
                                string smsstr = scontent[i].Substring(3, scontent[i].Length - 3).Substring(0, 11);
                                string smscot = scontent[i].Substring(14, scontent[i].Length - 14).Replace("|", "");
                                AddData(smsstr, smscot);
                            }
                            else
                            {
                                string smsstr = scontent[i].Substring(2, scontent[i].Length - 2).Substring(0, 11);
                                string smscot = scontent[i].Substring(13, scontent[i].Length - 13).Replace("|", "");
                                AddData(smsstr, smscot);
                            }
                        }
                    }
                    //MessageBox.Show(smscon);
                }
                GetData();
            }
        }
        private void AddData(string num,string content)
        {
            OleDbConnection conn = BaseClass.ConnClass.DataConn();
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("insert into tb_Resvice([smsnum],[smscontent]) values('"+num+"','"+content+"')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        private void DelData()
        {
            OleDbConnection conn = BaseClass.ConnClass.DataConn();
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("delete from tb_Resvice", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        private void GetData()
        {
            OleDbConnection conn = BaseClass.ConnClass.DataConn();
            OleDbDataAdapter sda = new OleDbDataAdapter("select * from tb_Resvice order by ID DESC", conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dgvResvice.DataSource = ds.Tables[0];
            conn.Close();
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dgvResvice.SelectedCells[0].Value.ToString();
            string snum = dgvResvice.SelectedCells[1].Value.ToString();
            string stxt = dgvResvice.SelectedCells[2].Value.ToString();

            frmSmsXX smsxx = new frmSmsXX();
            smsxx.Did = id;
            smsxx.Dnum = snum;
            smsxx.Dcontent = stxt;
            smsxx.Show();
        }
    }
}