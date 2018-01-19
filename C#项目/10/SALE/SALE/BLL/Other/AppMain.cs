using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using SALE.DAL;
using SALE.Common;
using SALE.UI.SystemSetting;
using SALE.UI.AgentManage;
using SALE.UI.SaleManage;
using SALE.UI.DataReport.WinForm;
using SALE.UI.ChartAnalyse.WinForm;
using System.Reflection;

namespace SALE.BLL.Other
{
    class AppMain 
    {
        Useful useful = new Useful();
        DataLogic dal = new DataLogic();

        public void GetToolStripMenuItem(ToolStripMenuItem toolStripMenuItem,DataTable dt)
        {
            foreach (ToolStripMenuItem item in toolStripMenuItem.DropDownItems)
            {
                if (item.DropDownItems.Count > 0)
                {
                    GetToolStripMenuItem(item, dt);
                }
                if (item.Tag != null)
                {
                    if (GlobalProperty.IsFlag == "1")
                    {
                        item.Enabled = useful.GetCheckedValue("1");
                        continue;
                    }
                    DataRow dr = dt.AsEnumerable().FirstOrDefault(itm => itm.Field<string>("MenuItemTag") == item.Tag.ToString());
                    if (dr != null)
                    {
                        item.Enabled = useful.GetCheckedValue(dr["IsEnabled"].ToString());
                    }
                }
            }         
        }

        public void SetMenuItemEnabled(MenuStrip menuStrip)
        {
            DataTable dt = dal.GetDataTable("Select * From PurviewAssign Where OperatorCode = '" + GlobalProperty.OperatorCode + "'", "PurviewAssign");
            foreach (ToolStripMenuItem item in menuStrip.Items)
            {
                this.GetToolStripMenuItem(item,dt);
            }
        }

        public void ShowForm(Type typeForm, Form formAppMain)
        {
            Form form = Activator.CreateInstance(typeForm) as Form;
            form.MdiParent = formAppMain;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }

        /// <summary>
        /// 单击菜单项，打开窗体
        /// </summary>
        /// <param name="menuItem">菜单项</param>
        /// <param name="form">应用程序主窗体</param>
        public void ShowForm(ToolStripMenuItem menuItem, Form formAppMain)
        {
            switch (menuItem.Tag.ToString())  //菜单项的tag就是模块标识
            {
                case "111":
                    ShowForm(typeof(FormGoodsType), formAppMain);
                    break;
                case "112":
                    ShowForm(typeof(FormGoodsSeries), formAppMain);
                    break;
                case "113":
                    ShowForm(typeof(FormPayType), formAppMain);
                    break;
                case "114":
                    ShowForm(typeof(FormAgentLevel), formAppMain);
                    break;
                case "116":
                    ShowForm(typeof(FormProvince), formAppMain);
                    break;
                case "117":
                    ShowForm(typeof(FormBank), formAppMain);
                    break;
                case "118":
                    ShowForm(typeof(FormConsignCorp), formAppMain);
                    break;
                case "119":
                    ShowForm(typeof(FormEmployee), formAppMain);
                    break;
                case "11A":
                    break;
                case "121":
                    ShowForm(typeof(FormOperator), formAppMain);
                    break;
                case "122":
                    ShowForm(typeof(FormAmendPassword), formAppMain);
                    break;
                case "130":
                    ShowForm(typeof(FormPurviewAssign), formAppMain);
                    break;
                case "210":
                    ShowForm(typeof(FormAgentRecord), formAppMain);
                    break;
                case "220":
                    ShowForm(typeof(FormDepRegister), formAppMain);
                    break;
                case "311":
                    ShowForm(typeof(FormRetailSaleOrderBill), formAppMain);
                    break;
                case "312":
                    ShowForm(typeof(FormRetailSaleTradeBill), formAppMain);
                    break;
                case "313":
                    ShowForm(typeof(FormRetailSaleConsignBill), formAppMain);
                    break;
                case "321":
                    ShowForm(typeof(FormRetailUntreadBaseBill), formAppMain);
                    break;
                case "322":
                    ShowForm(typeof(FormRetailUntreadGatherBill), formAppMain);
                    break;
                case "323":
                    ShowForm(typeof(FormRetailUntreadRefundBill), formAppMain);
                    break;
                case "331":
                    ShowForm(typeof(FormRetailBarterBaseBill), formAppMain);
                    break;
                case "332":
                    ShowForm(typeof(FormRetailBarterExchangeBill), formAppMain);
                    break;
                case "333":
                    ShowForm(typeof(FormRetailBarterConsignBill), formAppMain);
                    break;
                case "410":
                    ShowForm(typeof(FormOperationList), formAppMain);
                    break;
                case "420":
                    ShowForm(typeof(FormOperationCollect), formAppMain);
                    break;
                case "510":
                    ShowForm(typeof(FormAllkindsSometimeSaleAnalyse), formAppMain);
                    break;
                case "520":
                    ShowForm(typeof(FormDifferentMonthSaleAnalyse), formAppMain);
                    break;
                default:
                    break;
            }
        }
    }
}
