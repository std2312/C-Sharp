using System;
using System.Data.SqlClient;
using System.Data;
using System.ComponentModel;
using System.Windows.Forms;

namespace QQClass
{
    /// <summary>
    /// ClassOptionData 的摘要说明。
    /// </summary>
    public class ClassOptionData : Component
    {
        private string ConStr = @"Data Source=127.0.0.1;Initial Catalog=db_MyQQData;User ID=sa";

        public ClassOptionData()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }
        public int ExSQL(string SQLStr)//执行任何SQL语句，返回所影响的行数
        {
            try
            {
                SqlConnection cnn = new SqlConnection(ConStr);
                SqlCommand cmd = new SqlCommand(SQLStr, cnn);
                cnn.Open();
                int i = 0;
                i = cmd.ExecuteNonQuery();
                cmd.Dispose();
                cnn.Close();
                cnn.Dispose();
                return i;
            }
            catch { return 0; }

        }

        public int ExSQLLengData(object Data, string par, string SQLStr)//执行任何SQL语句，返回所影响的行数
        {
            try
            {
                SqlConnection cnn = new SqlConnection(ConStr);
                SqlCommand cmd = new SqlCommand(SQLStr, cnn);
                cnn.Open();
                int i = 0;
                cmd.Parameters.Add(par, System.Data.SqlDbType.Binary);
                i = cmd.ExecuteNonQuery();
                cmd.Dispose();
                cnn.Close();
                cnn.Dispose();
                return i;
            }
            catch { return 0; }

        }

        public int ExSQLR(string SQLStr)//执行任何SQL查询语句，返回所影响的行数
        {
            try
            {
                SqlConnection cnn = new SqlConnection(ConStr);
                SqlCommand cmd = new SqlCommand(SQLStr, cnn);
                cnn.Open();
                SqlDataReader dr;
                int i = 0;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                { i++; }
                cmd.Dispose();
                cnn.Close();
                cnn.Dispose();
                return i;
            }
            catch { return 0; }

        }

        public object ExSQLReField(string field, string SQLStr)//执行任何SQL查询语句，返回一个字段值
        {
            try
            {
                SqlConnection cnn = new SqlConnection(ConStr);
                SqlCommand cmd = new SqlCommand(SQLStr, cnn);
                cnn.Open();
                SqlDataReader dr;
                object fieldValue = null;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                { fieldValue = dr[field]; }
                cmd.Dispose();
                cnn.Close();
                cnn.Dispose();
                return fieldValue;
            }
            catch { return null; }

        }

        public SqlDataReader ExSQLReDr(string SQLStr)//执行任何SQL查询语句，返回一个SqlDataReader
        {
            try
            {
                SqlConnection cnn = new SqlConnection(ConStr);
                SqlCommand cmd = new SqlCommand(SQLStr, cnn);
                cnn.Open();
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                return dr;
            }
            catch { return null; }
        }

    }
}
