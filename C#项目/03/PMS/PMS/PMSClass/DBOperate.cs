using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Drawing;
namespace PMS.PMSClass
{
    class DBOperate
    {
        SqlConnection conn = DBConnection.MyConnection();//�õ����ݿ����Ӷ���

        /// <summary>
        /// �������ݿ⣬ִ�и���SQL���
        /// </summary>
        /// <param name="strSql">SQL���</param>
        /// <returns>����������Ӱ�������</returns>
        public int OperateData(string strSql)
        {
            conn.Open();//�����ݿ�����
            SqlCommand cmd = new SqlCommand(strSql, conn);//�����������
            int i = (int)cmd.ExecuteNonQuery();//ִ��SQL����
            conn.Close();//�ر����ݿ�����
            return i;//������ֵ
        }























        /// <summary>
        /// �������ڰ�DataGridView�ؼ�
        /// </summary>
        /// <param name="dgv">DataGridView�ؼ�</param>
        /// <param name="sql">SQL���</param>
        public void BindDataGridView(DataGridView dgv, string sql)
        {
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);//������������������
            DataSet ds = new DataSet();//�������ݼ�����
            sda.Fill(ds);//������ݼ�
            dgv.DataSource = ds.Tables[0];//�󶨵����ݱ�
            ds.Dispose();//�ͷ���Դ
        }

        /// <summary>
        /// ����ָ�����ݱ������
        /// </summary>
        /// <param name="strsql">SQL���</param>
        /// <returns>��������ָ����¼������</returns>
        public int HumanNum(string strsql)
        {
            conn.Open();//�����ݿ�����
            SqlCommand cmd = new SqlCommand(strsql, conn);//�����������
            int i = (int)cmd.ExecuteScalar();//ִ��SQL����
            conn.Close();//�ر����ݿ�����
            return i;//������ֵ
        }

        /// <summary>
        /// ��ʾѡ���ͼƬ
        /// </summary>
        /// <param name="openF">ͼ���ļ���·��</param>
        /// <param name="MyImage">PictureBox�ؼ�</param>
        public void Read_Image(OpenFileDialog openF, PictureBox MyImage)
        {
            openF.Filter = "*.jpg|*.jpg|*.bmp|*.bmp";//ɸѡ���ļ��ĸ�ʽ
            if (openF.ShowDialog() == DialogResult.OK)//�������ͼƬ�ļ�
            {
                try
                {
                    MyImage.Image = System.Drawing.Image.//����PictureBox�ؼ���Image����
                        FromFile(openF.FileName);
                }
                catch
                {
                    MessageBox.Show("��ѡ���ͼƬ���ܱ���ȡ���ļ����Ͳ��ԣ�",//������Ϣ�Ի���
                        "����", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        /// <summary>
        /// ��ͼƬ�Զ����ƴ������ݿ���
        /// </summary>
        /// <param name="MID">Ա�����</param>
        /// <param name="openF">���ļ��Ի������</param>
        public void SaveImage(string MID, OpenFileDialog openF)
        {
            string P_str = openF.FileName;//�õ�ͼƬ������·��
            FileStream fs = new FileStream(//�����ļ�������
                P_str, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);//���������ƶ�ȡ��
            byte[] imgBytesIn = br.ReadBytes((int)fs.Length);//�������뵽�ֽ�������
            conn.Open();//�����ݿ�����
            StringBuilder strSql = new StringBuilder();//�����ַ���������
            strSql.Append(//�����ַ���
                "update tb_employee Set employeePhoto=@Photo where employeeID=" + MID);
            SqlCommand cmd = new SqlCommand(strSql.ToString(), conn);//�����������
            cmd.Parameters.Add("@Photo", SqlDbType.Binary).Value = imgBytesIn;//��Ӳ���
            cmd.ExecuteNonQuery();//ִ��SQL����
            conn.Close();//�ر����ݿ�����
        }

        /// <summary>
        /// ��ͼƬ�����ݿ���ȡ��
        /// </summary>
        /// <param name="ygname">Ա�����</param>
        /// <param name="pb">PictureBox����</param>
        public void Get_Image(string ygname, PictureBox pb)
        {
            byte[] imagebytes = null;//�����ֽ��������
            conn.Open();//�����ݿ�����
            SqlCommand com = new SqlCommand(//�����������
                "select * from tb_employee where employeeID='" + ygname + "'", conn);
            SqlDataReader dr = com.ExecuteReader();//ִ��SQl����
            while (dr.Read())//��ȡ���ݿ��е�����
            {
                imagebytes = (byte[])dr.GetValue(11);//�õ�ͼ����ֽ�����
            }
            dr.Close();//�ر����ݶ�ȡ��
            conn.Close();//�ر����ݿ�����
            MemoryStream ms = new MemoryStream(imagebytes);//�����ڴ�������
            Bitmap bmpt = new Bitmap(ms);//�õ�BMP����
            pb.Image = bmpt;//��ʾͼ����Ϣ
        }

        /// <summary>
        /// ʹ�ô˷������Եõ����ݼ�
        /// </summary>
        /// <param name="sql">SQL���</param>
        /// <returns>�����������ݼ�</returns>
        public DataSet GetTable(string sql)
        {
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);//������������������
            DataSet ds = new DataSet();//�������ݼ�
            sda.Fill(ds);//������ݼ�
            ds.Dispose();//�ͷ���Դ
            return ds;//�������ݼ�
        }

        /// <summary>
        /// //�������б�
        /// </summary>
        /// <param name="strTable">���ݿ����</param>
        /// <param name="cb">ComboBox����</param>
        /// <param name="i">ָ������������</param>
        public void BindDropdownlist(string strTable, ComboBox cb, int i)
        {
            conn.Open();//�����ݿ�����
            SqlCommand cmd = new SqlCommand(//�����������
                "select * from " + strTable, conn);
            SqlDataReader sdr = cmd.ExecuteReader();//�õ����ݶ�ȡ��
            while (sdr.Read())
            {
                cb.Items.Add(sdr[i].ToString());//�����Ϣ
            }
            conn.Close();//�ر����ݿ�����
        }

        /// <summary>
        /// �����������˰
        /// </summary>
        /// <param name="pay">����</param>
        /// <returns>��������˰</returns>
        public decimal GYSD(int pay)
        {
            decimal tax = 0;//��������˰
            int Y = pay - 1600;//��˰����=ÿ�¹���-1600
            if (pay <= 1600)//����С��1600
            {
                tax = 0;//û�и�������˰
            }
            else
            {
                if (Y >= 0 || Y <= 500)
                {
                    tax = (decimal)(Y * 0.05);//�����������˰
                }
                else
                {
                    if (Y > 500 || Y <= 2000)
                    {
                        tax = (decimal)(Y * 0.1 - 25);//�����������˰
                    }
                    else
                    {
                        if (Y > 2000 || Y <= 5000)
                        {
                            tax = (decimal)(Y * 0.15 - 125);//�����������˰
                        }
                        else
                        {
                            if (Y > 5000 || Y <= 20000)
                            {
                                tax = (decimal)(Y * 0.2 - 375);//�����������˰
                            }
                            else
                            {
                                if (Y > 20000 || Y <= 40000)
                                {
                                    tax = (decimal)(Y * 0.25 - 1375);//�����������˰
                                }
                                else
                                {
                                    if (Y > 40000 || Y <= 60000)
                                    {
                                        tax = (decimal)(Y * 0.3 - 3375);//�����������˰
                                    }
                                    else
                                    {
                                        if (Y > 60000 || Y <= 80000)
                                        {
                                            tax = (decimal)(Y * 0.35 - 6375);//�����������˰
                                        }
                                        else
                                        {
                                            if (Y > 80000 || Y <= 100000)
                                            {
                                                tax = (decimal)(Y * 0.4 - 10375);//�����������˰
                                            }
                                            else
                                            {
                                                if (Y > 100000)
                                                {
                                                    tax = (decimal)(Y * 0.45 - 15375);//�����������˰
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return tax;//�������ظ�������˰
        }
        public void DeleUserInfo(string id)//ɾ��Ա����Ϣ
        {
            string str1 = "delete from tb_check where PID='" + id + "'";//����SQl�ַ���
            string str2 = "delete from tb_pay where YID='" + id + "'";//����SQL�ַ���
            string str3 = "delete from tb_prize where UserID='" + id + "'";//����SQL�ַ���
            string str4 = "delete from tb_redeploy where UID='" + id + "'";//����SQL�ַ���
            OperateData(str1);//ɾ��Ա����Ϣ
            OperateData(str2);//ɾ��Ա����Ϣ
            OperateData(str3);//ɾ��Ա����Ϣ
            OperateData(str4);//ɾ��Ա����Ϣ
        }
    }
}
