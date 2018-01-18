using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using SALE.DAL;
using SALE.Common;
using SALE.UI.DataReport.CryReprot;

namespace SALE.UI.DataReport.WinForm
{
    public partial class FormOperationCollect : Form
    {
        DataLogic dal = new DataLogic();

        public FormOperationCollect()
        {
            InitializeComponent();
        }

        private void FormOperationCollect_Load(object sender, EventArgs e)
        {
            dtpStartDate.Value = GlobalProperty.DBTime.Date.AddDays(-GlobalProperty.DBTime.Date.Day + 1);
            dtpEndDate.Value = GlobalProperty.DBTime.Date;
        }

        private DataTable GetBaseSheet()
        {
            return dal.GetDataTable("P_GoodsTypeCrossGoodsSeries");  //表GoodsType与表GoodsSeries交叉的存储过程
        }

        public DataTable GetSumValue(string strTable,string strQuantityColumn ,string strMoneyColumn,string strWhere)
        {
            string strSql = "Select Sum(" + strQuantityColumn + ") as SumQuantity,Sum(" + strMoneyColumn + ") as SumMoney From " + strTable + " " + strWhere;
            try
            {
                DataTable dt = dal.GetDataTable(strSql, strTable);
                if (dt.Rows[0]["SumQuantity"] == DBNull.Value)
                {
                    dt.Rows[0]["SumQuantity"] = 0;
                }
                if (Convert.IsDBNull(dt.Rows[0]["SumMoney"]))
                {
                    dt.Rows[0]["SumMoney"] = 0;
                }
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "软件提示");
                throw ex;
            }
        }

        private DataTable GetCollectInfo(string strWhere )
        {
            int decSameSeriesQuantity;  //同种类同版本的数量
            decimal decSameSeriesMoney;  //同种类同版本的金额
            //各种单据的返回
            DataTable dtSale;
            DataTable dtUntread;
            DataTable dtBarterNegative;  //原商品被退掉(-)
            DataTable dtBarterPositive;  //现商品被销售(+)

            //查询条件字符串引用
            string strGoodsTypeCode;
            string strGoodsSeriesCode;
            string strCondition = String.Empty;
            //DataTable的实例
            OperationCollect.OperationCollectDataTable dtCollect = new OperationCollect.OperationCollectDataTable();  //实例化空白报表CryOperationCollect的数据源
            DataTable dt = GetBaseSheet();  //表GoodsType与表GoodsSeries交叉的结果集
            foreach (DataRow dr in dt.Rows)
            {
                decSameSeriesQuantity = 0;  //同种类同版本的数量初始化
                decSameSeriesMoney = 0;  //同种类同版本的金额初始化
                //确定产品的代码
                strGoodsTypeCode = dr["GoodsTypeCode"].ToString();
                strGoodsSeriesCode = dr["GoodsSeriesCode"].ToString();
                //实际销售汇总
                if (rbSale.Checked)
                {
                    //---销售单
                    strCondition = strWhere + GetDateCondition("SaleOrderBill.BillDate")
                        + " and SaleOrderBill.CustomerId = Customer.CustomerId  and  GoodsTypeCode = '" + strGoodsTypeCode + "' and GoodsSeriesCode = '" + strGoodsSeriesCode + "'";
                    dtSale = GetSumValue(" SaleOrderBill,Customer ", " SaleOrderBill.Quantity ", "Round(SaleOrderBill.Quantity * SaleOrderBill.UnitPrice * SaleOrderBill.Discount,2)", strCondition);
                    if (dtSale.Rows.Count > 0)
                    {
                        decSameSeriesQuantity = Convert.ToInt32(dtSale.Rows[0]["SumQuantity"]);
                        decSameSeriesMoney = Convert.ToDecimal(dtSale.Rows[0]["SumMoney"]);
                    }
                }
                //实际销售汇总或退货汇总
                if (rbSale.Checked || rbUntread.Checked)
                {
                    //--退货单
                    strCondition = strWhere + GetDateCondition("UntreadBaseBill.UntreadBillDate")
                        + " and UntreadBaseBill.CustomerId = Customer.CustomerId and GoodsTypeCode = '" + strGoodsTypeCode + "' and GoodsSeriesCode = '" + strGoodsSeriesCode + "'";
                    dtUntread = GetSumValue(" UntreadBaseBill,Customer ", " UntreadBaseBill.Quantity ", "Round(UntreadBaseBill.Quantity * UntreadBaseBill.UnitPrice,2)", strCondition);
                    if (dtUntread.Rows.Count > 0)
                    {
                        decSameSeriesQuantity -= Convert.ToInt32(dtUntread.Rows[0]["SumQuantity"]);
                        decSameSeriesMoney -= Convert.ToDecimal(dtUntread.Rows[0]["SumMoney"]);
                    }
                }
                //实际销售汇总
                if (rbSale.Checked)
                {
                    //--换货单(退掉部分-)
                    strCondition = strWhere + GetDateCondition("BarterBaseBill.BarterBillDate")
                        + " and BarterBaseBill.CustomerId = Customer.CustomerId and  GoodsTypeCode = '" + strGoodsTypeCode + "' and GoodsSeriesCode = '" + strGoodsSeriesCode + "'";
                    dtBarterNegative = GetSumValue(" BarterBaseBill,Customer ", " BarterBaseBill.BarterQuantity ", "Round(BarterBaseBill.BarterQuantity * BarterBaseBill.UnitPrice,2)", strCondition);
                    if (dtBarterNegative.Rows.Count > 0)
                    {
                        decSameSeriesQuantity -= Convert.ToInt32(dtBarterNegative.Rows[0]["SumQuantity"]);
                        decSameSeriesMoney -= Convert.ToDecimal(dtBarterNegative.Rows[0]["SumMoney"]);
                    }
                }
                //实际销售汇总
                if (rbSale.Checked)
                {
                    //--换货单(销售部分+)
                    strCondition = strWhere + GetDateCondition("BarterBaseBill.BarterBillDate")
                        + " and BarterBaseBill.CustomerId = Customer.CustomerId and  GoodsTypeCode1 = '" + strGoodsTypeCode + "' and GoodsSeriesCode1 = '" + strGoodsSeriesCode + "'";
                    dtBarterPositive = GetSumValue(" BarterBaseBill,Customer ", " BarterBaseBill.BarterQuantity ", "Round(BarterBaseBill.BarterQuantity * BarterBaseBill.UnitPrice1,2)", strCondition);
                    if (dtBarterPositive.Rows.Count > 0)
                    {
                        decSameSeriesQuantity += Convert.ToInt32(dtBarterPositive.Rows[0]["SumQuantity"]);
                        decSameSeriesMoney += Convert.ToDecimal(dtBarterPositive.Rows[0]["SumMoney"]);
                    }
                }
                
                
                //给报表的DataTable赋值
                DataRow drCollect = dtCollect.NewRow();
                drCollect["GoodsTypeName"] = dr["GoodsTypeName"];
                drCollect["GoodsSeriesName"] = dr["GoodsSeriesName"];
                drCollect["SeriesQuantity"] = decSameSeriesQuantity;
                drCollect["SeriesMoney"] = decSameSeriesMoney;
                dtCollect.Rows.Add(drCollect);
            }
            return dtCollect;
        }
        private string GetDateCondition(string strDateColumn)
        {
            string strDateCondition = String.Empty;
            if (dtpStartDate.Checked)
            {
                strDateCondition = " and "+strDateColumn+" >= '" + dtpStartDate.Value.ToString("yyyy-MM-dd") + "' ";
            }
            if (dtpStartDate.Checked)
            {
                strDateCondition += " and " + strDateColumn + " <= '" + dtpEndDate.Value.ToString("yyyy-MM-dd") + "' ";
            }
            return strDateCondition;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string strWhere = String.Empty;
            OperationCollect.OperationCollectDataTable dtCollect = null;
            ControlBindDataSource cbds = new ControlBindDataSource();
            //判断日期是否合理
            if (dtpStartDate.Value.Date > dtpEndDate.Value.Date)
            {
                MessageBox.Show("开始日期不许大于结束日期!", "软件提示");
                return;
            }
            //判断是否选择用户类型
            if (!chbAgent.Checked && !chbNoAgent.Checked)
            {
                MessageBox.Show("请选择一种用户类型!", "软件提示");
                return;
            }
            //只选择代理
            if (chbAgent.Checked && !chbNoAgent.Checked)
            {
                strWhere = " Where Customer.CustomerType = '1' ";
            }
            //只选择普通
            if (!chbAgent.Checked && chbNoAgent.Checked)
            {
                strWhere = " Where (Customer.CustomerType = '2' or Customer.CustomerType = '3') ";
            }
            //同时选中代理和普通
            if (chbAgent.Checked && chbNoAgent.Checked)
            {
                strWhere = " Where (Customer.CustomerType = '1' or Customer.CustomerType = '2' or Customer.CustomerType = '3') ";
            }
            dtCollect = this.GetCollectInfo(strWhere) as OperationCollect.OperationCollectDataTable;
            ReportDocument rd = cbds.CrystalReports(@"\UI\DataReport\CryReprot\CryOperationCollect.rpt", dtCollect);
            crvCollect.ReportSource = rd;
            TextObject toDateRange = rd.ReportDefinition.ReportObjects["itoDateRange"] as TextObject;
            TextObject toPrintDate = rd.ReportDefinition.ReportObjects["itoPrintDate"] as TextObject;
            TextObject toTile = rd.ReportDefinition.ReportObjects["itoTitle"] as TextObject;
            toDateRange.Text = "( " + dtpStartDate.Value.Year.ToString() + "-" + dtpStartDate.Value.Month.ToString() + "-" + dtpStartDate.Value.Day.ToString() + " 至 "
                + dtpEndDate.Value.Year.ToString() + "-" + dtpEndDate.Value.Month.ToString() + "-" + dtpEndDate.Value.Day.ToString() + " )";
            toPrintDate.Text = GlobalProperty.DBTime.Date.ToString("yyy-MM-dd");
            foreach (Control con in gbCollectType.Controls)
            {
                if (con.GetType() == typeof(RadioButton))
                {
                    if (((RadioButton)con).Checked)
                    {
                        toTile.Text = "编程词典" + ((RadioButton)con).Text + "表";
                    }
                }
            }  
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
