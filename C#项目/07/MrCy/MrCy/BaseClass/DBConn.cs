using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
namespace MrCy.BaseClass
{
    class DBConn
    {
        public static SqlConnection CyCon()
        {
            return new SqlConnection("server=.;database=db_MrCy;uid=sa;pwd=");
        }
    }
}
