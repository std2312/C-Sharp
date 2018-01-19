using System;
using System.Data.SqlClient;
using System.Data;
using System.ComponentModel;
using System.Windows.Forms;

namespace QQClass
{
    /// <summary>
    /// ClassOptionData ��ժҪ˵����
    /// </summary>
    public class ClassOptionData : Component
    {
        private string ConStr = @"Data Source=127.0.0.1;Initial Catalog=db_MyQQData;User ID=sa";

        public ClassOptionData()
        {
            //
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
        }
        public int ExSQL(string SQLStr)//ִ���κ�SQL��䣬������Ӱ�������
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

        public int ExSQLLengData(object Data, string par, string SQLStr)//ִ���κ�SQL��䣬������Ӱ�������
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

        public int ExSQLR(string SQLStr)//ִ���κ�SQL��ѯ��䣬������Ӱ�������
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

        public object ExSQLReField(string field, string SQLStr)//ִ���κ�SQL��ѯ��䣬����һ���ֶ�ֵ
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

        public SqlDataReader ExSQLReDr(string SQLStr)//ִ���κ�SQL��ѯ��䣬����һ��SqlDataReader
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
