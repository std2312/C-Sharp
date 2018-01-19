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
    class RetailUntreadRefundBill
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

        private string m_UntreadRefundBillSql = "Select Customer.CustomerName,Customer.Address,UntreadRefundBill.UntreadBillNo,UntreadBaseBill.GoodsTypeCode,"
            + "UntreadBaseBill.GoodsSeriesCode,UntreadBaseBill.UnitPrice,UntreadBaseBill.Quantity,UntreadBaseBill.UnitPrice * UntreadBaseBill.Quantity as UntreadMoney,"
            + "UntreadRefundBill.PayTypeCode,UntreadRefundBill.BankCode,UntreadRefundBill.UntreadMoneyDate,UntreadRefundBill.TradeBillNo,UntreadRefundBill.FactUntreadMoney,"
            + "UntreadRefundBill.EmployeeCode3,UntreadRefundBill.SignDate3,UntreadRefundBill.OperatorCode,UntreadRefundBill.AppendDate,UntreadRefundBill.Id "
            + "From UntreadBaseBill,UntreadRefundBill,Customer Where UntreadRefundBill.UntreadBillNo = UntreadBaseBill.UntreadBillNo and UntreadBaseBill.CustomerId = Customer.CustomerId ";
        public string UntreadRefundBillSql
        {
            get
            {
                return m_UntreadRefundBillSql;
            }
        }


        private string m_UntreadRefundBill_CDNo_Sql = "Select Customer.CustomerName,Customer.Address,UntreadRefundBill.UntreadBillNo,UntreadBaseBill.GoodsTypeCode,"
           + "UntreadBaseBill.GoodsSeriesCode,UntreadBaseBill.UnitPrice,UntreadBaseBill.Quantity,UntreadBaseBill.UnitPrice * UntreadBaseBill.Quantity as UntreadMoney,"
           + "UntreadRefundBill.PayTypeCode,UntreadRefundBill.BankCode,UntreadRefundBill.UntreadMoneyDate,UntreadRefundBill.TradeBillNo,UntreadRefundBill.FactUntreadMoney,"
           + "UntreadRefundBill.EmployeeCode3,UntreadRefundBill.SignDate3,UntreadRefundBill.OperatorCode,UntreadRefundBill.AppendDate,UntreadRefundBill.Id "
           + "From UntreadCDRecord,UntreadBaseBill,UntreadRefundBill,Customer Where UntreadCDRecord.UntreadBillNo = UntreadRefundBill.UntreadBillNo and UntreadRefundBill.UntreadBillNo = UntreadBaseBill.UntreadBillNo and UntreadBaseBill.CustomerId = Customer.CustomerId ";
        public string UntreadRefundBill_CDNo_Sql
        {
            get
            {
                return m_UntreadRefundBill_CDNo_Sql;
            }
        }
    }
}
