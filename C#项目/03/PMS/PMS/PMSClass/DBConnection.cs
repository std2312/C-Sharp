using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;//引用SQL命名空间
namespace PMS.PMSClass
{
    class DBConnection//定义类型
    {
        /// <summary>
        /// 返回数据库连接的静态方法
        /// </summary>
        /// <returns>方法返回数据库连接对象</returns>
        public static SqlConnection MyConnection()
        {
            return new SqlConnection(//创建数据库连接对象
@"server=.\EXPRESS;database=db_PMS;uid=sa;pwd=");//数据库连接字符串
        }
    }
}
