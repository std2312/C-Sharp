using System;
using System.ComponentModel;
using System.Net;

namespace QQClass
{
	/// <summary>
	/// ClassUserInfo 的摘要说明。
	/// </summary>
	[Serializable] 
	public class ClassUserInfo
	{
        /// <summary>
        /// 用户编号
        /// </summary>
        private string userID;

        public string UserID
        {
            get { return userID; }
            set { userID = value; }
        }
        /// <summary>
        /// 用户正在登录的主机IP
        /// </summary>
        private string userIP;

        public string UserIP
        {
            get { return userIP; }
            set { userIP = value; }
        }
        /// <summary>
        /// 用户正在登录的主机端口号
        /// </summary>
        private string userPort;

        public string UserPort
        {
            get { return userPort; }
            set { userPort = value; }
        }
        /// <summary>
        /// 用户名
        /// </summary>
        private string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        /// <summary>
        /// 当前用户状态
        /// </summary>
        private String state;

        public String State
        {
            get { return state; }
            set { state = value; }
        }
		
	}
}
