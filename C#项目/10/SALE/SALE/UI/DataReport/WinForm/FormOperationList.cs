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
using CrystalDecisions.ReportAppServer;
using SALE.UI.DataReport.CryReprot;
using SALE.Common;

namespace SALE.UI.DataReport.WinForm
{
    public partial class FormOperationList : Form
    {
        public FormOperationList()
        {
            InitializeComponent();
        }

        private void FormOperationList_Load(object sender, EventArgs e)
        {
            dtpStartDate.Value = GlobalProperty.DBTime.Date;
            dtpEndDate.Value = GlobalProperty.DBTime.Date;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string strCondition = null;
            string strWhere = null;
            string strReportFileName = null;
            string strTableName = null;
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
            //销售
            if (rbSale.Checked)
            {
                strCondition = "Select SaleOrderBill.* From SaleOrderBill,Customer "+strWhere+" and SaleOrderBill.CustomerId = Customer.CustomerId and SaleOrderBill.SaleBillNo in (Select SaleTradeBill.SaleBillNo From SaleTradeBill) ";
                if (dtpStartDate.Checked)
                {
                    strCondition += " and SaleOrderBill.BillDate >= '" + dtpStartDate.Value.ToString("yyyy-MM-dd") + "' ";
                }
                if (dtpStartDate.Checked)
                {
                    strCondition += " and SaleOrderBill.BillDate <= '" + dtpEndDate.Value.ToString("yyyy-MM-dd") + "' ";
                }
                strReportFileName = "CrySaleList.rpt";
                strTableName = "SaleOrderBill";
            }
            //退货
            if (rbUntread.Checked)
            {
                strCondition = "Select UntreadBaseBill.* From UntreadBaseBill,Customer " + strWhere + " and UntreadBaseBill.CustomerId = Customer.CustomerId ";
                if (dtpStartDate.Checked)
                {
                    strCondition += " and UntreadBaseBill.UntreadBillDate >= '" + dtpStartDate.Value.ToString("yyyy-MM-dd") + "' ";
                }
                if (dtpStartDate.Checked)
                {
                    strCondition += " and UntreadBaseBill.UntreadBillDate <= '" + dtpEndDate.Value.ToString("yyyy-MM-dd") + "' ";
                }
                strReportFileName = "CryUntreadList.rpt";
                strTableName = "UntreadBaseBill";
            }
            //调货
            if (rbBarter.Checked)
            {
                strCondition = "Select BarterBaseBill.* From BarterBaseBill,Customer " + strWhere + " and BarterBaseBill.CustomerId = Customer.CustomerId ";
                if (dtpStartDate.Checked)
                {
                    strCondition += " and BarterBaseBill.BarterBillDate >= '" + dtpStartDate.Value.ToString("yyyy-MM-dd") + "' ";
                }
                if (dtpStartDate.Checked)
                {
                    strCondition += " and BarterBaseBill.BarterBillDate <= '" + dtpEndDate.Value.ToString("yyyy-MM-dd") + "' ";
                }
                strReportFileName = "CryBarterList.rpt";
                strTableName = "BarterBaseBill";
            }
            
           
            ReportDocument rd = cbds.CrystalReports(@"\UI\DataReport\CryReprot\"+strReportFileName, strCondition, strTableName);
            crvList.ReportSource = rd;  //显示数据
            TextObject toDateRange = rd.ReportDefinition.ReportObjects["itoDateRange"] as TextObject;
            TextObject toPrintDate = rd.ReportDefinition.ReportObjects["itoPrintDate"] as TextObject;
            toDateRange.Text = "( "+dtpStartDate.Value.Year.ToString() + "-" + dtpStartDate.Value.Month.ToString() + "-" + dtpStartDate.Value.Day.ToString()+" 至 "
                +dtpEndDate.Value.Year.ToString() + "-" + dtpEndDate.Value.Month.ToString() + "-" + dtpEndDate.Value.Day.ToString()+" )";
            toPrintDate.Text = GlobalProperty.DBTime.Date.ToString("yyy-MM-dd");
        }
        //退出
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
