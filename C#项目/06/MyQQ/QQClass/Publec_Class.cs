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
            
            // ��ʾ������
            string hostname = Dns.GetHostName();
            // ��ʾÿ��IP��ַ
            IPHostEntry hostent = Dns.GetHostEntry(hostname); // ������Ϣ
            Array addrs = hostent.AddressList;            // IP��ַ����
            IEnumerator it = addrs.GetEnumerator();       // ����������������ռ�using System.Collections;
            while (it.MoveNext())
            {                     // ѭ������һ��IP ��ַ
                IPAddress ip = (IPAddress)it.Current;      //���IP��ַ����������ռ�using System.Net;
                return ip.ToString();
            }
            return "";
        }

        [DllImport("kernel32")]
        public static extern void GetWindowsDirectory(StringBuilder WinDir, int count);

        #region  ��ȡwindows·��
        /// <summary>
        /// ��ȡwindows·��.
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
