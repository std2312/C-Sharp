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
using SALE.Common;
using SALE.UI.ChartAnalyse.CryReprot;
using SALE.DAL;

namespace SALE.UI.ChartAnalyse.WinForm
{
    public partial class FormDifferentMonthSaleAnalyse : Form
    {
        DataLogic dal = new DataLogic();

        public FormDifferentMonthSaleAnalyse()
        {
            InitializeComponent();
        }

        private List<string> GetMonthRange()
        {
            List<string> months = new List<string>();
            int intMonthQuantity;
            if (dtpEndMonth.Value.Year == dtpStartMonth.Value.Year)
            {
                intMonthQuantity = dtpEndMonth.Value.Month - dtpStartMonth.Value.Month;
            }
            else
            {
                intMonthQuantity = 12 - dtpStartMonth.Value.Month;
                intMonthQuantity = intMonthQuantity + dtpEndMonth.Value.Month;
            }
            for (int i = 0; i <= intMonthQuantity; i++)
            {
                months.Add(dtpStartMonth.Value.AddMonths(i).Year.ToString() + "-" + dtpStartMonth.Value.AddMonths(i).Month.ToString("00"));
            }
            return months;
        }

        public DataTable GetSumValue(string strTable, string strQuantityColumn, string strMoneyColumn, string strWhere)
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

        private DataTable GetDifferentMonthInfo(string strWhere)
        {
            int decQuantity;  //同种类的数量
            decimal decMoney;  //同种类的金额
            //各种单据的返回
            DataTable dtSale;
            DataTable dtUntread;
            DataTable dtBarterNegative;  //原商品被退掉(-)
            DataTable dtBarterPositive;  //现商品被销售(+)

            //查询条件字符串引用
            string strCondition = String.Empty;
            //DataTable的实例
            DifferentMonth.DifferentMonthDataTable dmdt = new DifferentMonth.DifferentMonthDataTable();  //实例化报表CryDifferentMonthSaleAnalyse的空白数据源对象
            List<string> months = GetMonthRange(); //得到所有的月份点，用来表示横坐标
            foreach (string strMonth in months)
            {
                decQuantity = 0;  //数量初始化
                decMoney = 0;  //金额初始化
                //---销售单
                strCondition = strWhere + GetMonthCondition("SaleOrderBill.BillDate",strMonth)
                    + " and SaleOrderBill.CustomerId = Customer.CustomerId ";
                dtSale = GetSumValue(" SaleOrderBill,Customer ", " SaleOrderBill.Quantity ", "Round(SaleOrderBill.Quantity * SaleOrderBill.UnitPrice * SaleOrderBill.Discount,2)", strCondition);
                if (dtSale.Rows.Count > 0)
                {
                    decQuantity = Convert.ToInt32(dtSale.Rows[0]["SumQuantity"]);
                    decMoney = Convert.ToDecimal(dtSale.Rows[0]["SumMoney"]);
                }
                //--退货单
                strCondition = strWhere + GetMonthCondition("UntreadBaseBill.UntreadBillDate",strMonth)
                    + " and UntreadBaseBill.CustomerId = Customer.CustomerId ";
                dtUntread = GetSumValue(" UntreadBaseBill,Customer ", " UntreadBaseBill.Quantity ", "Round(UntreadBaseBill.Quantity * UntreadBaseBill.UnitPrice,2)", strCondition);
                if (dtUntread.Rows.Count > 0)
                {
                    decQuantity -= Convert.ToInt32(dtUntread.Rows[0]["SumQuantity"]);
                    decMoney -= Convert.ToDecimal(dtUntread.Rows[0]["SumMoney"]);
                }
                //--换货单(退掉部分-)
                strCondition = strWhere + GetMonthCondition("BarterBaseBill.BarterBillDate",strMonth)
                    + " and BarterBaseBill.CustomerId = Customer.CustomerId ";
                dtBarterNegative = GetSumValue(" BarterBaseBill,Customer ", " BarterBaseBill.BarterQuantity ", "Round(BarterBaseBill.BarterQuantity * BarterBaseBill.UnitPrice,2)", strCondition);
                if (dtBarterNegative.Rows.Count > 0)
                {
                    decQuantity -= Convert.ToInt32(dtBarterNegative.Rows[0]["SumQuantity"]);
                    decMoney -= Convert.ToDecimal(dtBarterNegative.Rows[0]["SumMoney"]);
                }
                //--换货单(销售部分+)
                strCondition = strWhere + GetMonthCondition("BarterBaseBill.BarterBillDate",strMonth)
                    + " and BarterBaseBill.CustomerId = Customer.CustomerId ";
                dtBarterPositive = GetSumValue(" BarterBaseBill,Customer ", " BarterBaseBill.BarterQuantity ", "Round(BarterBaseBill.BarterQuantity * BarterBaseBill.UnitPrice1,2)", strCondition);
                if (dtBarterPositive.Rows.Count > 0)
                {
                    decQuantity += Convert.ToInt32(dtBarterPositive.Rows[0]["SumQuantity"]);
                    decMoney += Convert.ToDecimal(dtBarterPositive.Rows[0]["SumMoney"]);
                }
               
               
                //给报表的DataTable赋值
                DataRow drDifferentMonth = dmdt.NewRow();
                drDifferentMonth["Month"] = strMonth;
                if (rbQuantity.Checked)
                {
                    drDifferentMonth["NumericalValue"] = decQuantity;
                }
                else
                {
                    drDifferentMonth["NumericalValue"] = decMoney;
                }
                dmdt.Rows.Add(drDifferentMonth);
            }
            return dmdt;
        }

        private string GetMonthCondition(string strDateColumn,string strMonth)
        {
            return " and SUBSTRING(CONVERT(VARCHAR(20)," + strDateColumn + ",20),1,7) = '" + strMonth + "' ";
        }

        private void FormDifferentMonthSaleAnalyse_Load(object sender, EventArgs e)
        {
            dtpStartMonth.Value = GlobalProperty.DBTime.Date.AddMonths(-GlobalProperty.DBTime.Month + 1);
            dtpEndMonth.Value = GlobalProperty.DBTime.Date.AddMonths(0);
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            DifferentMonth.DifferentMonthDataTable dmdt = null;
            ControlBindDataSource cbds = new ControlBindDataSource();
            //判断月份是否合理
            if (dtpStartMonth.Value >= dtpEndMonth.Value)
            {
                MessageBox.Show("开始月份不许大于或等于结束月份!", "软件提示");
                return;
            }
            string strWhere = " Where 1 = 1 ";
            dmdt = this.GetDifferentMonthInfo(strWhere) as DifferentMonth.DifferentMonthDataTable;
            ReportDocument rd = cbds.CrystalReports(@"\UI\ChartAnalyse\CryReprot\CryDifferentMonthSaleAnalyse.rpt", dmdt);
            crvCollect.ReportSource = rd;
            TextObject txtNumValue = rd.ReportDefinition.ReportObjects["txtNumValue"] as TextObject;
            if (rbQuantity.Checked)
            {
                txtNumValue.Text = "销售数量(套)";
            }
            else
            {
                txtNumValue.Text = "销售金额(元)";
            }
            TextObject toDateRange = rd.ReportDefinition.ReportObjects["itoDateRange"] as TextObject;
            toDateRange.Text = "( " + dtpStartMonth.Value.Year.ToString() + "-" + dtpStartMonth.Value.Month.ToString() + " 至 "
                + dtpEndMonth.Value.Year.ToString() + "-" + dtpEndMonth.Value.Month.ToString()+" )";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

    }
}
