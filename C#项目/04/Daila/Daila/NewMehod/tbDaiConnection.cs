using System;
using System.Collections.Generic;
using System.Text;
//引用命名空间
using System.Data.OleDb;
using System.Windows.Forms;
//此类是获取数据库连接
namespace Daila.NewMehod
{
    public class tbDaiConnection
    {
        private OleDbConnection con=null;
        public OleDbConnection OledCon()
        {
            //创建连接数据库的字符串
            string reportPath = Application.StartupPath.Substring(0, Application.StartupPath.Substring(0,
             Application.StartupPath.LastIndexOf("\\")).LastIndexOf("\\"));
            reportPath += @"\DataBase\db_Dainla.mdb";
            string ConStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data source=" + reportPath;
             //创建OleDbConnection对象
            con = new OleDbConnection(ConStr); 
            con.Open();
            return con;
         }//end if
  
        
    }
}
