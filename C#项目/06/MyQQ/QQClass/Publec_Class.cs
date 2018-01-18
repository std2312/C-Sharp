using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Net;
using System.Windows.Forms;
using System.Runtime.InteropServices;



namespace QQClass
{
    public class Publec_Class
    {
        public static string ServerIP = "";
        public static string ServerPort = "";
        public static string ClientIP = "";
        public static string ClientName = "";
        public static string UserName;
        public static string UserID;

        public string MyHostIP()
        {
            
            // 显示主机名
            string hostname = Dns.GetHostName();
            // 显示每个IP地址
            IPHostEntry hostent = Dns.GetHostEntry(hostname); // 主机信息
            Array addrs = hostent.AddressList;            // IP地址数组
            IEnumerator it = addrs.GetEnumerator();       // 迭代器，添加名命空间using System.Collections;
            while (it.MoveNext())
            {                     // 循环到下一个IP 地址
                IPAddress ip = (IPAddress)it.Current;      //获得IP地址，添加名命空间using System.Net;
                return ip.ToString();
            }
            return "";
        }

        [DllImport("kernel32")]
        public static extern void GetWindowsDirectory(StringBuilder WinDir, int count);

        #region  获取windows路径
        /// <summary>
        /// 获取windows路径.
        /// </summary>
        public string Get_windows()
        {
            const int nChars = 255;
            StringBuilder Buff = new StringBuilder(nChars);
            GetWindowsDirectory(Buff, nChars);
            return Buff.ToString();
        }
        #endregion
    }
}
