using System;
using System.ComponentModel;
using System.Net;

namespace QQClass
{
	/// <summary>
	/// ClassUserInfo ��ժҪ˵����
	/// </summary>
	[Serializable] 
	public class ClassUserInfo
	{
        /// <summary>
        /// �û����
        /// </summary>
        private string userID;

        public string UserID
        {
            get { return userID; }
            set { userID = value; }
        }
        /// <summary>
        /// �û����ڵ�¼������IP
        /// </summary>
        private string userIP;

        public string UserIP
        {
            get { return userIP; }
            set { userIP = value; }
        }
        /// <summary>
        /// �û����ڵ�¼�������˿ں�
        /// </summary>
        private string userPort;

        public string UserPort
        {
            get { return userPort; }
            set { userPort = value; }
        }
        /// <summary>
        /// �û���
        /// </summary>
        private string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        /// <summary>
        /// ��ǰ�û�״̬
        /// </summary>
        private String state;

        public String State
        {
            get { return state; }
            set { state = value; }
        }
		
	}
}
