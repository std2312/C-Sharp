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
    class RetailBarterBaseBill
    {
        public DataTable GetDataTable(string strTableName, string strWhere)
        {
            DataLogic dal = new DataLogic();
            string strSql = "Select * From " + strTableName + " " + strWhere;
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
                return dal.GetDataTable(strSql, "");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "软件提示");
                throw ex;
            }
        }

        public bool IsExistBarterBillNo(string strBarterBillNo)
        {
            DataLogic dal = new DataLogic();
            try
            {
                //创建SqlParameter对象，并赋值
                SqlParameter param = new SqlParameter("@BarterBillNo", SqlDbType.VarChar);
                param.Value = strBarterBillNo;
                //创建泛型
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(param);
                //把泛型中的元素复制到数组中
                SqlParameter[] inputParameters = parameters.ToArray();
                DataTable dt = dal.GetDataTable("P_IsExistBarterBillNo", inputParameters);
                if (Convert.ToInt32(dt.Rows[0][0]) > 0)
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

        public bool Delete(List<string> strSqls)
        {
            DataLogic dal = new DataLogic();
            try
            {
                if (dal.ExecDataBySqls(strSqls))
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

        //private string m_BarterBaseBillSql = "Select BarterBaseBill.BarterBillNo,BarterBaseBill.BarterType,Customer.CustomerName,Customer.Address,BarterBaseBill.GoodsTypeCode,"
        //  + "BarterBaseBill.GoodsSeriesCode,BarterBaseBill.GoodsTypeCode1,BarterBaseBill.GoodsSeriesCode1,BarterBaseBill.BarterQuantity,BarterBaseBill.EmployeeCode1,BarterBaseBill.SignDate1,"
        //  + "BarterBaseBill.OperatorCode,BarterBaseBill.AppendDate From Customer,BarterBaseBill Where Customer.CustomerId = BarterBaseBill.CustomerId ";
        //public string BarterBaseBillSql
        //{
        //    get
        //    {
        //        return m_BarterBaseBillSql;
        //    }
        //}

        private string m_BarterBaseBillSql = "Select BarterBaseBill.*,Customer.CustomerName,Customer.Address,Customer.PhoneNumber From Customer,BarterBaseBill Where Customer.CustomerId = BarterBaseBill.CustomerId ";
        public string BarterBaseBillSql
        {
            get
            {
                return m_BarterBaseBillSql;
            }
        }

        private string m_BarterBaseBill_CDNo_Sql = "Select BarterBaseBill.*,Customer.CustomerName,Customer.Address,Customer.PhoneNumber From Customer,BarterBaseBill,BarterBaseCDRecord Where  BarterBaseCDRecord.BarterBillNo = BarterBaseBill.BarterBillNo  and BarterBaseBill.CustomerId = Customer.CustomerId ";
        public string BarterBaseBill_CDNo_Sql
        {
            get
            {
                return m_BarterBaseBill_CDNo_Sql;
            }
        }
    }
}
