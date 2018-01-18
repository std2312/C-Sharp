using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using SALE.DAL;

namespace SALE.BLL.SystemSetting
{
    class PayType
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

        public bool Delete(DataLogic dal, string strSql)
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
    }
}
