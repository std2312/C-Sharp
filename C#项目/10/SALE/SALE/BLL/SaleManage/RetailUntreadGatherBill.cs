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
    class RetailUntreadGatherBill
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

        private string m_UntreadGatherBillSql = "Select UntreadGatherBill.UntreadBillNo,Customer.CustomerName,Customer.Address,UntreadBaseBill.GoodsTypeCode,"
            + "UntreadBaseBill.GoodsSeriesCode,UntreadBaseBill.Quantity,UntreadBaseBill.Remark1,UntreadGatherBill.IsComplete,UntreadGatherBill.IsReturnInvoice,"
            + "UntreadGatherBill.IsShatter,UntreadGatherBill.EmployeeCode2,UntreadGatherBill.SignDate2,UntreadGatherBill.OperatorCode,UntreadGatherBill.AppendDate,UntreadGatherBill.Id "
            + "From UntreadBaseBill,UntreadGatherBill,Customer Where UntreadGatherBill.UntreadBillNo = UntreadBaseBill.UntreadBillNo and UntreadBaseBill.CustomerId = Customer.CustomerId ";
        public string UntreadGatherBillSql
        {
            get
            {
                return m_UntreadGatherBillSql;
            }
        }

        private string m_UntreadGatherBill_CDNo_Sql = "Select UntreadGatherBill.UntreadBillNo,Customer.CustomerName,Customer.Address,UntreadBaseBill.GoodsTypeCode,"
           + "UntreadBaseBill.GoodsSeriesCode,UntreadBaseBill.Quantity,UntreadBaseBill.Remark1,UntreadGatherBill.IsComplete,UntreadGatherBill.IsReturnInvoice,"
           + "UntreadGatherBill.IsShatter,UntreadGatherBill.EmployeeCode2,UntreadGatherBill.SignDate2,UntreadGatherBill.OperatorCode,UntreadGatherBill.AppendDate,UntreadGatherBill.Id "
           + "From UntreadCDRecord,UntreadBaseBill,UntreadGatherBill,Customer Where UntreadCDRecord.UntreadBillNo = UntreadGatherBill.UntreadBillNo and UntreadGatherBill.UntreadBillNo = UntreadBaseBill.UntreadBillNo and UntreadBaseBill.CustomerId = Customer.CustomerId ";
        public string UntreadGatherBill_CDNo_Sql
        {
            get
            {
                return m_UntreadGatherBill_CDNo_Sql;
            }
        }
    }
}
