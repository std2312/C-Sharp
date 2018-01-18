using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using SALE.DAL;

namespace SALE.BLL.SaleManage
{
    /// <summary>
    /// 零售——用户档案的业务逻辑
    /// </summary>
    class RetailCustomer
    {
        public DataTable GetDataTable(string strTableName, string strWhere)
        {
            DataLogic dal = new DataLogic();
            string strSql = "Select * From "+ strTableName + " " + strWhere;
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

        public DataTable GetDataTable(string strSql)
        {
            DataLogic dal = new DataLogic();
            try
            {
                return dal.GetDataTable(strSql,"");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "软件提示");
                throw ex;
            }
        }

        public int GetMaxIdOfCurrentOperator(string strOperatorCode)
        {
            DataLogic dal = new DataLogic();
            string strSql = "Select Max(CustomerId) From Customer Where OperatorCode = '" + strOperatorCode + "'";
            try
            {
                Nullable<int> maxCustomerId = dal.GetSingleObject(strSql) as Nullable<int>;
                if (maxCustomerId.HasValue)
                {
                    return maxCustomerId.Value;
                }
                else
                {
                    return 0;
                }
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

        public bool Update(DataLogic dal, string strSql)
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
