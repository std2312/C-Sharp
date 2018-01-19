using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using SALE.DAL;

namespace SALE.BLL.SaleManage
{
    class RetailUntreadBaseBill
    {
        private static SqlDataAdapter sda = null;

        public DataTable GetDataTable(string strTableName, string strWhere)
        {
            DataLogic dal = new DataLogic();
            string strSql = "Select * From " + strTableName + " " + strWhere;
            try
            {
                sda = new SqlDataAdapter(strSql, dal.Conn);
                new SqlCommandBuilder(sda);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;
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

        public bool IsExistUntreadBillNo(string strUntreadBillNo)
        {
            DataLogic dal = new DataLogic();
            try
            {
                //创建SqlParameter对象，并赋值
                SqlParameter param = new SqlParameter("@UntreadBillNo", SqlDbType.VarChar);
                param.Value = strUntreadBillNo;
                //创建泛型
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(param);
                //把泛型中的元素复制到数组中
                SqlParameter[] inputParameters = parameters.ToArray();
                DataTable dt = dal.GetDataTable("P_IsExistUntreadBillNo", inputParameters);
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

        public DataGridViewRow AddDataGridViewRow(DataGridView dgv, BindingSource bs)
        {
            DataTable dt = bs.DataSource as DataTable;
            DataRow dr = dt.NewRow();
            try
            {
                dt.Rows.Add(dr);
                bs.DataSource = dt;
                dgv.DataSource = bs;
                int intRowIndex = dgv.RowCount - 1;
                return dgv.Rows[intRowIndex];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "软件提示");
                throw ex;
            }
        }

        public bool Insert(BindingSource bs)  //与方法AddDataGridViewRow公用一个dt内存表
        {
            bs.EndEdit();
            DataTable dt = bs.DataSource as DataTable; //因DataGridView控件无外部编辑动作，所以无需使用dgv.EndEdit()方法
            try
            {
                if (sda.Update(dt.Select(null,null,DataViewRowState.Added)) > 0)
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

        public bool Update(BindingSource bs)
        {
            //dgv.EndEdit(); //若在程序的外部编辑时，则需要结束dgv的编辑，否则可以不需要
            bs.EndEdit(); //将“程序的内部或外部更改”应用于基础数据源 ——> 即DataTable。
            DataTable dt = bs.DataSource as DataTable;
            try
            {
                if (sda.Update(dt) > 0)
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

        public bool Delete(BindingSource bs)
        {
            bs.EndEdit();
            DataTable dt = bs.DataSource as DataTable;
            try
            {
                if (sda.Update(dt) > 0)
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
                return dal.ExecDataBySqls(strSqls);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "软件提示");
                throw ex;
            }
        }

         private string m_UntreadBaseBillSql ="Select UntreadBaseBill.UntreadBillNo,UntreadBaseBill.UntreadBillDate,Customer.CustomerName,Customer.CustomerType,Customer.Address,Customer.PhoneNumber,"
             + "SaleOrderBill.IsNeedInvoice,SaleOrderBill.CertificateNumber,SaleOrderBill.BillDate,SaleOrderBill.WriteOffType,SaleOrderBill.WriteOffName,UntreadBaseBill.GoodsTypeCode,UntreadBaseBill.GoodsSeriesCode,"
             + "UntreadBaseBill.UnitPrice,UntreadBaseBill.Quantity,UntreadBaseBill.AccountNumber,UntreadBaseBill.EmployeeCode1,UntreadBaseBill.SignDate1,UntreadBaseBill.Remark1,"
             + "UntreadBaseBill.OperatorCode,UntreadBaseBill.BankCode, UntreadBaseBill.OpenAccBankName,UntreadBaseBill.AppendDate, UntreadBaseBill.SaleBillNo  From UntreadBaseBill,"
             + "SaleOrderBill,Customer Where UntreadBaseBill.SaleBillNo = SaleOrderBill.SaleBillNo and SaleOrderBill.CustomerId = Customer.CustomerId and (CustomerType = '2' or CustomerType = '3')";//现在只读取零售用户的订单记录
         public string UntreadBaseBillSql
         {
             get
             {
                 return m_UntreadBaseBillSql;
             }
         }

         private string m_UntreadBaseBill_CDNo_Sql = "Select UntreadBaseBill.UntreadBillNo,UntreadBaseBill.UntreadBillDate,Customer.CustomerName,Customer.CustomerType,Customer.Address,Customer.PhoneNumber,"
             + "SaleOrderBill.IsNeedInvoice,SaleOrderBill.CertificateNumber,SaleOrderBill.BillDate,SaleOrderBill.WriteOffType,SaleOrderBill.WriteOffName,UntreadBaseBill.GoodsTypeCode,UntreadBaseBill.GoodsSeriesCode,"
             + "UntreadBaseBill.UnitPrice,UntreadBaseBill.Quantity,UntreadBaseBill.AccountNumber,UntreadBaseBill.EmployeeCode1,UntreadBaseBill.SignDate1,UntreadBaseBill.Remark1,"
             + "UntreadBaseBill.OperatorCode,UntreadBaseBill.BankCode, UntreadBaseBill.OpenAccBankName,UntreadBaseBill.AppendDate, UntreadBaseBill.SaleBillNo  From UntreadCDRecord,UntreadBaseBill,"
             + "SaleOrderBill,Customer Where UntreadCDRecord.UntreadBillNo = UntreadBaseBill.UntreadBillNo and UntreadBaseBill.SaleBillNo = SaleOrderBill.SaleBillNo and SaleOrderBill.CustomerId = Customer.CustomerId and (CustomerType = '2' or CustomerType = '3')";//现在只读取零售用户的订单记录
         public string UntreadBaseBill_CDNo_Sql
         {
             get
             {
                 return m_UntreadBaseBill_CDNo_Sql;
             }
         }
    }
}
