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
    public partial class frmDai : Form
    {
        public frmDai()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            tbTelRecordClass tbClass = new tbTelRecordClass();
            tbTelRecordMenthod tbMenthod = new tbTelRecordMenthod();
             
      
                tbClass.strsType="¥Ú»Î";
 
           
  
            OleDbDataReader dr = tbMenthod.tbTelRecordSecrf(tbClass, "2");
          
            listView1.Items.Clear();
            int intFalg = 0;
            while (dr.Read())
            {
                listView1.Items.Add(dr[1].ToString());
                listView1.Items[intFalg].SubItems.Add(dr[2].ToString());
                listView1.Items[intFalg].SubItems.Add(dr[3].ToString());
                listView1.Items[intFalg].SubItems.Add(dr[5].ToString());
                intFalg++;
            }//
            dr.Close();
     

        }

        private void frmDai_Load(object sender, EventArgs e)
        {

        }
    }
}