using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;//����SQL�����ռ�
namespace PMS.PMSClass
{
    class DBConnection//��������
    {
        /// <summary>
        /// �������ݿ����ӵľ�̬����
        /// </summary>
        /// <returns>�����������ݿ����Ӷ���</returns>
        public static SqlConnection MyConnection()
        {
            return new SqlConnection(//�������ݿ����Ӷ���
@"server=.\EXPRESS;database=db_PMS;uid=sa;pwd=");//���ݿ������ַ���
        }
    }
}
