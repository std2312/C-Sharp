using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using SALE.DAL;

namespace SALE.BLL.AgentManage
{
    class DepRegister
    {
        public DataTable GetDataTable(string strCustomerId)
        {
            DataLogic dal = new DataLogic();
            string strSql = "Select AgentLevel.AgentLevelName,LeastMoney,Discount,Years,BeginDate,";
            strSql += "EndDate,Remark,AgentLevel.AgentLevelCode From DepRegister,AgentLevel ";
            strSql += "Where DepRegister.AgentLevelCode = AgentLevel.AgentLevelCode and DepRegister.CustomerId = '" + strCustomerId + "'";  //表示整数的字符串strCustomerId可以隐式地转换为整数
            try
            {
                return dal.GetDataTable(strSql, "");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "软件提示");
                throw ex;
            }
        }

        public DataTable GetDataTable(string strAgentLevelCode,string strTableName)
        {
            DataLogic dal = new DataLogic();
            string strSql = "Select * From " + strTableName + " Where AgentLevelCode = '" + strAgentLevelCode + "'";
            try
            {
                 return dal.GetDataTable(strSql, strTableName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "软件提示");
                throw ex;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dal">与命令参数为同一个数据连接</param>
        /// <param name="strSql"></param>
        /// <returns></returns>
        public bool Insert(DataLogic dal, string strSql)
        {
            try
            {
                if (dal.ExecDataBySql(strSql) > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "软件提示");
                throw ex;
            }
        }

        public bool Update(DataLogic dal,string strSql)
        {
            try
            {
                if (dal.ExecDataBySql(strSql) > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "软件提示");
                throw ex;
            }
        }

        public bool Delete(string strSql)
        {
            DataLogic dal = new DataLogic();
            try
            {
                if (dal.ExecDataBySql(strSql) > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "软件提示");
                throw ex;
            }
        }
    }
}
