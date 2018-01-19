using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SALE.Common
{
    public class GlobalProperty
    {
        private static string m_OperatorCode;
        /// <summary>
        /// 操作员代码
        /// </summary>
        public static string OperatorCode
        {
            get
            {
                return m_OperatorCode;
            }
            set
            {
                m_OperatorCode = value;
            }
        }

        private static string m_OperatorName;
        /// <summary>
        /// 操作员名称
        /// </summary>
        public static string OperatorName
        {
            get
            {
                return m_OperatorName;
            }
            set
            {
                m_OperatorName = value;
            }
        }

        private static string m_Password;
        /// <summary>
        /// 操作员密码
        /// </summary>
        public static string Password
        {
            get
            {
                return m_Password;
            }
            set
            {
                m_Password = value;
            }
        }

        private static string m_IsFlag;
        /// <summary>
        /// 是否系统管理员标记
        /// </summary>
        public static string IsFlag
        {
            get
            {
                return m_IsFlag;
            }
            set
            {
                m_IsFlag = value;
            }
        }

        private static DateTime m_DBTime = new Useful().GetDBTime();
        public static DateTime DBTime
        {
            get
            {
                return m_DBTime;
            }
        }
    }
}
