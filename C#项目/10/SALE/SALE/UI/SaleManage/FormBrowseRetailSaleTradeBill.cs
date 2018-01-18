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
    public partial class FormBrowseRetailSaleTradeBill : Form
    {
        FormRetailSaleTradeBill formRetailSaleTradeBill = null;
        Useful useful = new Useful();

        public FormBrowseRetailSaleTradeBill()
        {
            InitializeComponent();
        }

        private void FormBrowseRetailSaleTradeBill_Load(object sender, EventArgs e)
        {
            formRetailSaleTradeBill = (FormRetailSaleTradeBill)this.Owner;
            ControlBindDataSource cbds = new ControlBindDataSource();
            cbds.ComboBoxBindDataSource(cbxProvinceCode, "ProvinceCode", "ProvinceName", "Select * From Province", "Province");
            cbds.ComboBoxBindDataSource(cbxPayTypeCode, "PayTypeCode", "PayTypeName", "Select * From PayType", "PayType");
            cbds.ComboBoxBindDataSource(cbxBankCode, "BankCode", "BankName", "Select * From Bank", "Bank");
            cbxBankCode.SelectedIndex = -1;
            cbxPayTypeCode.SelectedIndex = -1;
            cbxProvinceCode.SelectedIndex = -1;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            RetailSaleTradeBill rstb = new RetailSaleTradeBill();
            string strSql = null;
            if (!chbIsCDNo.Checked) //没有选中光盘号查询
            {
                strSql = "Select SaleTradeBill.* From SaleTradeBill,Customer,SaleOrderBill "
                    + "Where SaleTradeBill.SaleBillNo = SaleOrderBill.SaleBillNo and SaleOrderBill.CustomerId = Customer.CustomerId ";
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
                if (dtpSaleDate.Checked)
                {
                    strSql += " and SaleDate = '" + dtpSaleDate.Value.Date + "'";
                }
                if (!String.IsNullOrEmpty(txtSaleBillNo.Text.Trim()))
                {
                    strSql += " and SaleOrderBill.SaleBillNo like '%" + txtSaleBillNo.Text.Trim() + "'";
                }
                if (!(cbxBankCode.SelectedValue == null))
                {
                    strSql += " and SaleTradeBill.BankCode = '" + cbxBankCode.SelectedValue.ToString() + "'";
                }
                if (!(cbxPayTypeCode.SelectedValue == null))
                {
                    strSql += " and SaleTradeBill.PayTypeCode = '" + cbxPayTypeCode.SelectedValue.ToString() + "'";
                }
                if (!String.IsNullOrEmpty(txtTradeBillNo.Text.Trim()))
                {
                    strSql += " and SaleTradeBill.TradeBillNo like '%" + txtTradeBillNo.Text.Trim() + "'";
                }
            }
            if (chbIsCDNo.Checked) //选中光盘号查询
            {
                if (String.IsNullOrEmpty(txtCDNo.Text.Trim()))
                {
                    MessageBox.Show("请输入光盘号！", "软件提示");
                    txtCDNo.Focus();
                    return;
                }
                strSql = "Select SaleTradeBill.* From SaleCDRecord,SaleConsignBill,SaleTradeBill "
                   + "Where SaleCDRecord.SaleConsignBillId = SaleConsignBill.Id and SaleConsignBill.SaleBillNo = SaleTradeBill.SaleBillNo and SaleCDRecord.CDNo = '"+txtCDNo.Text.Trim()+"'";
            }
            formRetailSaleTradeBill.bsSaleTradeBill.DataSource = rstb.GetDataTable(strSql);
            formRetailSaleTradeBill.dgvSaleTradeBill.DataSource = formRetailSaleTradeBill.bsSaleTradeBill;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            useful.InitFormContros(groupBox1, null);
            dtpSaleDate.Checked = false;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chbIsCDNo_CheckedChanged(object sender, EventArgs e)
        {
            if (chbIsCDNo.Checked)
            {
                useful.SetControlsState(groupBox1, false);
                txtCDNo.Enabled = true;
                chbIsCDNo.Enabled = true;
                btnQuery.Enabled = true;
                btnCancel.Enabled = true;
                btnReturn.Enabled = true;
                txtCDNo.Focus();
            }
            else
            {
                useful.SetControlsState(groupBox1, true);
                txtCDNo.Enabled = false;
                txtCustomerName.Focus();
            }
        }
    }
}
