﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using SALE.DAL;

namespace SALE.BLL.SaleManage
{
    /// <summary>
    /// 零售——销售单的业务逻辑
    /// </summary>
    class RetailSaleOrderBill
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

        public bool IsExistSaleBillNo(string strSaleBillNo)
        {
            DataLogic dal = new DataLogic();
            try
            {
                //创建SqlParameter对象，并赋值
                SqlParameter param = new SqlParameter("@SaleBillNo", SqlDbType.VarChar);
                param.Value = strSaleBillNo;
                //创建泛型
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(param);
                //把泛型中的元素复制到数组中
                SqlParameter[] inputParameters = parameters.ToArray();
                DataTable dt = dal.GetDataTable("P_IsExistSaleBillNo", inputParameters);
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
    }
}
