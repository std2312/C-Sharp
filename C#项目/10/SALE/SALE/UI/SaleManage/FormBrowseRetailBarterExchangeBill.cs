using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SALE.BLL.SaleManage;
using SALE.Common;

namespace SALE.UI.SaleManage
{
    public partial class FormBrowseRetailBarterExchangeBill : Form
    {

        FormRetailBarterExchangeBill formRetailBarterExchangeBill = null;
        Useful useful = new Useful();

        public FormBrowseRetailBarterExchangeBill()
        {
            InitializeComponent();
        }

        private string GetQueryInfoString()
        {
            string strSql = String.Empty;

            if (!String.IsNullOrEmpty(txtCustomerName.Text.Trim()))
            {
                strSql += " and CustomerName like '%" + txtCustomerName.Text.Trim() + "%'";
            }
            if (!(cbxProvinceCode.SelectedValue == null))
            {
                strSql += " and ProvinceCode = '" + cbxProvinceCode.SelectedValue.ToString() + "'";
            }
            if (!String.IsNullOrEmpty(txtAddress.Text.Trim()))
            {
                strSql += " and Address like '%" + txtAddress.Text.Trim() + "%'";
            }
            if (!String.IsNullOrEmpty(txtPhoneNumber.Text.Trim()))
            {
                strSql += " and PhoneNumber like '%" + txtPhoneNumber.Text.Trim() + "%'";
            }
            if (!String.IsNullOrEmpty(txtBarterBillNo.Text.Trim()))
            {
                strSql += " and BarterExchangeBill.BarterBillNo like '%" + txtBarterBillNo.Text.Trim() + "%'";
            }
            if (!(cbxPayTypeCode.SelectedValue == null))
            {
                strSql += " and BarterExchangeBill.PayTypeCode = '" + cbxPayTypeCode.SelectedValue.ToString() + "'";
            }
            if (!String.IsNullOrEmpty(txtTradeBillNo.Text.Trim()))
            {
                strSql += " and BarterExchangeBill.TradeBillNo = '" + txtTradeBillNo.Text.Trim() + "'";
            }
            if (dtpTradeDate.Checked)
            {
                strSql += " and BarterExchangeBill.TradeDate = '" + dtpTradeDate.Value.Date + "'";
            }
            if (dtpAppendDate.Checked)
            {
                strSql += " and BarterExchangeBill.AppendDate = '" + dtpAppendDate.Value.Date + "'";
            }
            return strSql;
        }

        private void FormBrowseRetailBarterExchangeBill_Load(object sender, EventArgs e)
        {
            formRetailBarterExchangeBill = (FormRetailBarterExchangeBill)this.Owner;
            ControlBindDataSource cbds = new ControlBindDataSource();
            cbds.BindDataSource(this);
            useful.InitFormContros(this, null);
            dtpAppendDate.Checked = false;
            dtpTradeDate.Checked = false;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string strSql = String.Empty;  //声明string变量并初始化
            RetailBarterExchangeBill rbeb = new RetailBarterExchangeBill();
            if (!chbIsCDNo.Checked)  //没有选中光盘号查询
            {
                strSql = rbeb.BarterExchangeBillSql + GetQueryInfoString();  //设置基本的Sql语句
            }
            if (chbIsCDNo.Checked)  //选中光盘号查询
            {
                if (String.IsNullOrEmpty(txtCDNo.Text.Trim()))
                {
                    MessageBox.Show("请输入光盘号！", "软件提示");
                    txtCDNo.Focus();
                    return;
                }
            }
            formRetailBarterExchangeBill.dgvBarterExchangeBill.DataSource = rbeb.GetDataTable(strSql);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            useful.InitFormContros(this, null);
            dtpAppendDate.Checked = false;
            dtpTradeDate.Checked = false;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chbIsCDNo_CheckedChanged(object sender, EventArgs e)
        {
            if (chbIsCDNo.Checked)
            {
                useful.SetControlsState(this, false);
                txtCDNo.Enabled = true;
                chbIsCDNo.Enabled = true;
                btnQuery.Enabled = true;
                btnCancel.Enabled = true;
                btnReturn.Enabled = true;
                txtCDNo.Focus();
            }
            else
            {
                useful.SetControlsState(this, true);
                txtCDNo.Enabled = false;
                txtCustomerName.Focus();
            }
        }
    }
}
