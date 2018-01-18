using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
namespace SMS.BaseClass
{
    
    class ConnClass
    {
        public static OleDbConnection DataConn()
        {
            string strg = Application.StartupPath.ToString();
            strg = strg.Substring(0, strg.LastIndexOf("\\"));
            strg = strg.Substring(0, strg.LastIndexOf("\\"));
            strg += @"\DataBase";
            strg += @"\db_SMS.mdb";
            return new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + strg); 
        }
    }
}
