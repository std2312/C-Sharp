﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using SALE.DAL;

namespace SALE.BLL.SaleManage
{
    class BarterBaseCDRecord
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

        /// <summary>
        /// DataGridView提交数据
        /// </summary>
        /// <param name="bs"></param>
        /// <param name="dgv"></param>
        /// <returns></returns>
        public bool Commit(BindingSource bs, DataGridView dgv)
        {
            dgv.EndEdit();
            bs.EndEdit();
            DataTable dt = bs.DataSource as DataTable;
            try
            {
                sda.Update(dt);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 提交DataGridView的删除行数据
        /// </summary>
        /// <param name="bs"></param>
        /// <param name="dgv"></param>
        /// <returns></returns>
        public bool Delete(BindingSource bs, DataGridView dgv)
        {
            dgv.EndEdit();
            bs.EndEdit();
            DataTable dt = bs.DataSource as DataTable;
            try
            {
                sda.Update(dt.Select(null, null, DataViewRowState.Deleted));
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 使用SQL语句删除数据
        /// </summary>
        /// <param name="strSql"></param>
        /// <returns></returns>
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

        private string m_BarterCDRecordSql = "Select * From BarterCDRecord ";
        public string BarterCDRecordSql
        {
            get
            {
                return m_BarterCDRecordSql;
            }
        }

        public DataTable GetSaleCDNoBySaleBillNo(string strSaleBillNo)
        {
            string strSql = " Select SaleCDRecord.CDNo From SaleCDRecord ,SaleConsignBill"
                + " Where SaleCDRecord.SaleConsignBillId = SaleConsignBill.Id and SaleConsignBill.SaleBillNo = '" + strSaleBillNo + "'";
            return this.GetDataTable(strSql);
        }
    }
}
