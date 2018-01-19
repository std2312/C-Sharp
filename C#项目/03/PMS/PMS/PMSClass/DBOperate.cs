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
        SqlConnection conn = DBConnection.MyConnection();//得到数据库连接对象

        /// <summary>
        /// 操作数据库，执行各种SQL语句
        /// </summary>
        /// <param name="strSql">SQL语句</param>
        /// <returns>方法返回受影响的行数</returns>
        public int OperateData(string strSql)
        {
            conn.Open();//打开数据库连接
            SqlCommand cmd = new SqlCommand(strSql, conn);//创建命令对象
            int i = (int)cmd.ExecuteNonQuery();//执行SQL命令
            conn.Close();//关闭数据库连接
            return i;//返回数值
        }























        /// <summary>
        /// 方法用于绑定DataGridView控件
        /// </summary>
        /// <param name="dgv">DataGridView控件</param>
        /// <param name="sql">SQL语句</param>
        public void BindDataGridView(DataGridView dgv, string sql)
        {
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);//创建数据适配器对象
            DataSet ds = new DataSet();//创建数据集对象
            sda.Fill(ds);//填充数据集
            dgv.DataSource = ds.Tables[0];//绑定到数据表
            ds.Dispose();//释放资源
        }

        /// <summary>
        /// 查找指定数据表的人数
        /// </summary>
        /// <param name="strsql">SQL语句</param>
        /// <returns>方法返回指定记录的数量</returns>
        public int HumanNum(string strsql)
        {
            conn.Open();//打开数据库连接
            SqlCommand cmd = new SqlCommand(strsql, conn);//创建命令对象
            int i = (int)cmd.ExecuteScalar();//执行SQL命令
            conn.Close();//关闭数据库连接
            return i;//返回数值
        }

        /// <summary>
        /// 显示选择的图片
        /// </summary>
        /// <param name="openF">图像文件的路径</param>
        /// <param name="MyImage">PictureBox控件</param>
        public void Read_Image(OpenFileDialog openF, PictureBox MyImage)
        {
            openF.Filter = "*.jpg|*.jpg|*.bmp|*.bmp";//筛选打开文件的格式
            if (openF.ShowDialog() == DialogResult.OK)//如果打开了图片文件
            {
                try
                {
                    MyImage.Image = System.Drawing.Image.//设置PictureBox控件的Image属性
                        FromFile(openF.FileName);
                }
                catch
                {
                    MessageBox.Show("您选择的图片不能被读取或文件类型不对！",//弹出消息对话框
                        "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        /// <summary>
        /// 将图片以二进制存入数据库中
        /// </summary>
        /// <param name="MID">员工编号</param>
        /// <param name="openF">打开文件对话框对象</param>
        public void SaveImage(string MID, OpenFileDialog openF)
        {
            string P_str = openF.FileName;//得到图片的所在路径
            FileStream fs = new FileStream(//创建文件流对象
                P_str, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);//创建二进制读取器
            byte[] imgBytesIn = br.ReadBytes((int)fs.Length);//将流读入到字节数组中
            conn.Open();//打开数据库连接
            StringBuilder strSql = new StringBuilder();//创建字符串构造器
            strSql.Append(//附加字符串
                "update tb_employee Set employeePhoto=@Photo where employeeID=" + MID);
            SqlCommand cmd = new SqlCommand(strSql.ToString(), conn);//创建命令对象
            cmd.Parameters.Add("@Photo", SqlDbType.Binary).Value = imgBytesIn;//添加参数
            cmd.ExecuteNonQuery();//执行SQL命令
            conn.Close();//关闭数据库连接
        }

        /// <summary>
        /// 将图片从数据库中取出
        /// </summary>
        /// <param name="ygname">员工编号</param>
        /// <param name="pb">PictureBox对象</param>
        public void Get_Image(string ygname, PictureBox pb)
        {
            byte[] imagebytes = null;//声明字节数组变量
            conn.Open();//打开数据库连接
            SqlCommand com = new SqlCommand(//创建命令对象
                "select * from tb_employee where employeeID='" + ygname + "'", conn);
            SqlDataReader dr = com.ExecuteReader();//执行SQl命令
            while (dr.Read())//读取数据库中的数据
            {
                imagebytes = (byte[])dr.GetValue(11);//得到图象的字节数据
            }
            dr.Close();//关闭数据读取器
            conn.Close();//关闭数据库连接
            MemoryStream ms = new MemoryStream(imagebytes);//创建内存流对象
            Bitmap bmpt = new Bitmap(ms);//得到BMP对象
            pb.Image = bmpt;//显示图像信息
        }

        /// <summary>
        /// 使用此方法可以得到数据集
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <returns>方法返回数据集</returns>
        public DataSet GetTable(string sql)
        {
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);//创建数据适配器对象
            DataSet ds = new DataSet();//创建数据集
            sda.Fill(ds);//填充数据集
            ds.Dispose();//释放资源
            return ds;//返回数据集
        }

        /// <summary>
        /// //绑定下拉列表
        /// </summary>
        /// <param name="strTable">数据库表名</param>
        /// <param name="cb">ComboBox对象</param>
        /// <param name="i">指定数据列索引</param>
        public void BindDropdownlist(string strTable, ComboBox cb, int i)
        {
            conn.Open();//打开数据库连接
            SqlCommand cmd = new SqlCommand(//创建命令对象
                "select * from " + strTable, conn);
            SqlDataReader sdr = cmd.ExecuteReader();//得到数据读取器
            while (sdr.Read())
            {
                cb.Items.Add(sdr[i].ToString());//添加信息
            }
            conn.Close();//关闭数据库连接
        }

        /// <summary>
        /// 计算个人所得税
        /// </summary>
        /// <param name="pay">工资</param>
        /// <returns>个人所得税</returns>
        public decimal GYSD(int pay)
        {
            decimal tax = 0;//个人所得税
            int Y = pay - 1600;//计税工资=每月工资-1600
            if (pay <= 1600)//工资小于1600
            {
                tax = 0;//没有个人所得税
            }
            else
            {
                if (Y >= 0 || Y <= 500)
                {
                    tax = (decimal)(Y * 0.05);//计算个人所得税
                }
                else
                {
                    if (Y > 500 || Y <= 2000)
                    {
                        tax = (decimal)(Y * 0.1 - 25);//计算个人所得税
                    }
                    else
                    {
                        if (Y > 2000 || Y <= 5000)
                        {
                            tax = (decimal)(Y * 0.15 - 125);//计算个人所得税
                        }
                        else
                        {
                            if (Y > 5000 || Y <= 20000)
                            {
                                tax = (decimal)(Y * 0.2 - 375);//计算个人所得税
                            }
                            else
                            {
                                if (Y > 20000 || Y <= 40000)
                                {
                                    tax = (decimal)(Y * 0.25 - 1375);//计算个人所得税
                                }
                                else
                                {
                                    if (Y > 40000 || Y <= 60000)
                                    {
                                        tax = (decimal)(Y * 0.3 - 3375);//计算个人所得税
                                    }
                                    else
                                    {
                                        if (Y > 60000 || Y <= 80000)
                                        {
                                            tax = (decimal)(Y * 0.35 - 6375);//计算个人所得税
                                        }
                                        else
                                        {
                                            if (Y > 80000 || Y <= 100000)
                                            {
                                                tax = (decimal)(Y * 0.4 - 10375);//计算个人所得税
                                            }
                                            else
                                            {
                                                if (Y > 100000)
                                                {
                                                    tax = (decimal)(Y * 0.45 - 15375);//计算个人所得税
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
            return tax;//方法返回个人所得税
        }
        public void DeleUserInfo(string id)//删除员工信息
        {
            string str1 = "delete from tb_check where PID='" + id + "'";//创建SQl字符串
            string str2 = "delete from tb_pay where YID='" + id + "'";//创建SQL字符串
            string str3 = "delete from tb_prize where UserID='" + id + "'";//创建SQL字符串
            string str4 = "delete from tb_redeploy where UID='" + id + "'";//创建SQL字符串
            OperateData(str1);//删除员工信息
            OperateData(str2);//删除员工信息
            OperateData(str3);//删除员工信息
            OperateData(str4);//删除员工信息
        }
    }
}
