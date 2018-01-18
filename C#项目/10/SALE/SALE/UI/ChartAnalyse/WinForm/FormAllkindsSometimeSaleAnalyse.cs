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
    public partial class FormAllkindsSometimeSaleAnalyse : Form
    {
        DataLogic dal = new DataLogic();

        public FormAllkindsSometimeSaleAnalyse()
        {
            InitializeComponent();
        }

        private void FormAllkindsSometimeSaleAnalyse_Load(object sender, EventArgs e)
        {
            dtpStartDate.Value = GlobalProperty.DBTime.Date.AddDays(-GlobalProperty.DBTime.Date.Day + 1);
            dtpEndDate.Value = GlobalProperty.DBTime.Date;

            int count = groupBox1.Controls.Count * 2 + 2;
            float[] factor = new float[count];
            int i = 0;
            factor[i++] = Size.Width;
            factor[i++] = Size.Height;
            foreach (Control ctrl in groupBox1.Controls)
            {
                factor[i++] = ctrl.Location.X / (float)Size.Width;
                factor[i++] = ctrl.Location.Y / (float)Size.Height;
                ctrl.Tag = ctrl.Size;
            }
            Tag = factor;
        }

        private DataTable GetGoodsType()
        {
            return dal.GetDataTable("Select * From GoodsType", "GoodsType");
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

        private DataTable GetAllKindsInfo(string strWhere)
        {
            int decSameTypeQuantity;  //同种类的数量
            decimal decSameTypeMoney;  //同种类的金额
            //各种单据的返回
            DataTable dtSale;
            DataTable dtUntread;
            DataTable dtBarterNegative;  //原商品被退掉(-)
            DataTable dtBarterPositive;  //现商品被销售(+)
            //查询条件字符串引用
            string strGoodsTypeCode;
            string strCondition = String.Empty;
            //DataTable的实例
            AllKinds.AllKindsDataTable akdt = new AllKinds.AllKindsDataTable();  //实例化报表CryAllkindsSometimeSaleAnalyse的空白数据源对象
            DataTable dt = GetGoodsType();  //表GoodsType与表GoodsSeries交叉的结果集
            foreach (DataRow dr in dt.Rows)
            {
                decSameTypeQuantity = 0;  //同种类的数量初始化
                decSameTypeMoney = 0;  //同种类的金额初始化
                //确定产品的代码
                strGoodsTypeCode = dr["GoodsTypeCode"].ToString();
                //---销售单
                strCondition = strWhere + GetDateCondition("SaleOrderBill.BillDate")
                    + " and SaleOrderBill.CustomerId = Customer.CustomerId  and  GoodsTypeCode = '" + strGoodsTypeCode + "'";
                dtSale = GetSumValue(" SaleOrderBill,Customer ", " SaleOrderBill.Quantity ", "Round(SaleOrderBill.Quantity * SaleOrderBill.UnitPrice * SaleOrderBill.Discount,2)", strCondition);
                if (dtSale.Rows.Count > 0)
                {
                    decSameTypeQuantity = Convert.ToInt32(dtSale.Rows[0]["SumQuantity"]);
                    decSameTypeMoney = Convert.ToDecimal(dtSale.Rows[0]["SumMoney"]);
                }
                //--退货单
                strCondition = strWhere + GetDateCondition("UntreadBaseBill.UntreadBillDate")
                    + " and UntreadBaseBill.CustomerId = Customer.CustomerId and GoodsTypeCode = '" + strGoodsTypeCode + "'";
                dtUntread = GetSumValue(" UntreadBaseBill,Customer ", " UntreadBaseBill.Quantity ", "Round(UntreadBaseBill.Quantity * UntreadBaseBill.UnitPrice,2)", strCondition);
                if (dtUntread.Rows.Count > 0)
                {
                    decSameTypeQuantity -= Convert.ToInt32(dtUntread.Rows[0]["SumQuantity"]);
                    decSameTypeMoney -= Convert.ToDecimal(dtUntread.Rows[0]["SumMoney"]);
                }
                //--换货单(退掉部分-)
                strCondition = strWhere + GetDateCondition("BarterBaseBill.BarterBillDate")
                    + " and BarterBaseBill.CustomerId = Customer.CustomerId and  GoodsTypeCode = '" + strGoodsTypeCode + "'";
                dtBarterNegative = GetSumValue(" BarterBaseBill,Customer ", " BarterBaseBill.BarterQuantity ", "Round(BarterBaseBill.BarterQuantity * BarterBaseBill.UnitPrice,2)", strCondition);
                if (dtBarterNegative.Rows.Count > 0)
                {
                    decSameTypeQuantity -= Convert.ToInt32(dtBarterNegative.Rows[0]["SumQuantity"]);
                    decSameTypeMoney -= Convert.ToDecimal(dtBarterNegative.Rows[0]["SumMoney"]);
                }
                //--换货单(销售部分+)
                strCondition = strWhere + GetDateCondition("BarterBaseBill.BarterBillDate")
                    + " and BarterBaseBill.CustomerId = Customer.CustomerId and  GoodsTypeCode1 = '" + strGoodsTypeCode + "'";
                dtBarterPositive = GetSumValue(" BarterBaseBill,Customer ", " BarterBaseBill.BarterQuantity ", "Round(BarterBaseBill.BarterQuantity * BarterBaseBill.UnitPrice1,2)", strCondition);
                if (dtBarterPositive.Rows.Count > 0)
                {
                    decSameTypeQuantity += Convert.ToInt32(dtBarterPositive.Rows[0]["SumQuantity"]);
                    decSameTypeMoney += Convert.ToDecimal(dtBarterPositive.Rows[0]["SumMoney"]);
                }
                
                //给报表的DataTable赋值
                DataRow drAllKinds = akdt.NewRow();
                drAllKinds["GoodsTypeCode"] = dr["GoodsTypeCode"];
                drAllKinds["GoodsTypeName"] = dr["GoodsTypeName"];
                if (rbQuantity.Checked)
                {
                    drAllKinds["NumericalValue"] = decSameTypeQuantity;
                }
                else
                {
                    drAllKinds["NumericalValue"] = decSameTypeMoney;
                }
                akdt.Rows.Add(drAllKinds);
            }
            return akdt;
        }


        private string GetDateCondition(string strDateColumn)
        {
            string strDateCondition = String.Empty;
            if (dtpStartDate.Checked)
            {
                strDateCondition = " and " + strDateColumn + " >= '" + dtpStartDate.Value.ToString("yyyy-MM-dd") + "' ";
            }
            if (dtpStartDate.Checked)
            {
                strDateCondition += " and " + strDateColumn + " <= '" + dtpEndDate.Value.ToString("yyyy-MM-dd") + "' ";
            }
            return strDateCondition;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            AllKinds.AllKindsDataTable akdt = null;
            ControlBindDataSource cbds = new ControlBindDataSource();
            //判断日期是否合理
            if (dtpStartDate.Value.Date > dtpEndDate.Value.Date)
            {
                MessageBox.Show("开始日期不许大于结束日期!", "软件提示");
                return;
            }
            string strWhere = " Where 1 = 1 ";
            akdt = this.GetAllKindsInfo(strWhere) as AllKinds.AllKindsDataTable;
            ReportDocument rd = cbds.CrystalReports(@"\UI\ChartAnalyse\CryReprot\CryAllkindsSometimeSaleAnalyse.rpt", akdt);
            crvCollect.ReportSource = rd;
            TextObject txtNumValue = rd.ReportDefinition.ReportObjects["txtNumValue"] as TextObject;
            if(rbQuantity.Checked)
            {
                txtNumValue.Text = "销售数量(套)";
            }
            else
            {
                txtNumValue.Text = "销售金额(元)";
            }
            TextObject toDateRange = rd.ReportDefinition.ReportObjects["itoDateRange"] as TextObject;
            toDateRange.Text = "( " + dtpStartDate.Value.Year.ToString() + "-" + dtpStartDate.Value.Month.ToString() + "-" + dtpStartDate.Value.Day.ToString() + " 至 "
                + dtpEndDate.Value.Year.ToString() + "-" + dtpEndDate.Value.Month.ToString() + "-" + dtpEndDate.Value.Day.ToString() + " )";
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAllkindsSometimeSaleAnalyse_Resize(object sender, EventArgs e)
        {
            float[] scale = (float[])Tag;
            int i = 2;
            foreach (Control ctrl in groupBox1.Controls)
            {
                ctrl.Left = (int)(Size.Width * scale[i++]);
                ctrl.Top = (int)(Size.Height * scale[i++]);
                ctrl.Width = (int)(Size.Width /(float) scale[0]*((Size)ctrl.Tag).Width);
                ctrl.Height = (int)(Size.Height / (float)scale[1] * ((Size)ctrl.Tag).Height);
            }
        }
    }
}
