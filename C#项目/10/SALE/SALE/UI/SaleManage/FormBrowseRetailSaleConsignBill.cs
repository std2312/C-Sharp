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
    public partial class FormBrowseRetailSaleConsignBill : Form
    {
        FormRetailSaleConsignBill formRetailSaleConsignBill = new FormRetailSaleConsignBill();
        Useful useful = new Useful();

        public FormBrowseRetailSaleConsignBill()
        {
            InitializeComponent();
        }

        private void FormBrowseRetailSaleConsignBill_Load(object sender, EventArgs e)
        {
            formRetailSaleConsignBill = (FormRetailSaleConsignBill)this.Owner;
            ControlBindDataSource cbds = new ControlBindDataSource();
            cbds.ComboBoxBindDataSource(cbxConsignCorpCode, "ConsignCorpCode", "ConsignCorpName", "Select * From ConsignCorp", "ConsignCorp");
            cbds.ComboBoxBindDataSource(cbxEmployeeCode4, "EmployeeCode", "EmployeeName", "Select * From Employee", "Employee");
            cbds.ComboBoxBindDataSource(cbxProvinceCode, "ProvinceCode", "ProvinceName", "Select * From Province", "Province");
            cbxConsignCorpCode.SelectedIndex = -1;
            cbxEmployeeCode4.SelectedIndex = -1;
            cbxProvinceCode.SelectedIndex = -1;
            dtpConsignDate.Value = GlobalProperty.DBTime;
            dtpConsignDate.Checked = false;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            RetailSaleConsignBill rscb = new RetailSaleConsignBill();
            string strSql = null;
            if (!chbIsCDNo.Checked) //没有选中光盘号查询
            {
                strSql = "Select SaleConsignBill.* From SaleConsignBill,Customer,SaleOrderBill "
                    + "Where SaleConsignBill.SaleBillNo = SaleOrderBill.SaleBillNo and SaleOrderBill.CustomerId = Customer.CustomerId ";
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
                if (!String.IsNullOrEmpty(txtSaleBillNo.Text.Trim()))
                {
                    strSql += " and SaleOrderBill.SaleBillNo like '%" + txtSaleBillNo.Text.Trim() + "%'";
                }
                if (!(cbxConsignCorpCode.SelectedValue == null))
                {
                    strSql += " and SaleConsignBill.ConsignCorpCode = '" + cbxConsignCorpCode.SelectedValue.ToString() + "'";
                }
                if (dtpConsignDate.Checked)
                {
                    strSql += " and SaleConsignBill.ConsignDate = '" + dtpConsignDate.Value.Date + "'";
                }
                if (!String.IsNullOrEmpty(txtExpressBillNo.Text.Trim()))
                {
                    strSql += " and SaleConsignBill.ExpressBillNo like '%" + txtExpressBillNo.Text.Trim() + "'";
                }
                if (!(cbxEmployeeCode4.SelectedValue == null))
                {
                    strSql += " and SaleConsignBill.EmployeeCode4 = '" + cbxEmployeeCode4.SelectedValue.ToString() + "'";
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
                strSql = "Select SaleConsignBill.* From SaleConsignBill,Customer,SaleOrderBill,SaleCDRecord "
                   + "Where SaleCDRecord.SaleConsignBillId = SaleConsignBill.Id and  SaleConsignBill.SaleBillNo = SaleOrderBill.SaleBillNo and SaleOrderBill.CustomerId = Customer.CustomerId and SaleCDRecord.CDNo = '" + txtCDNo.Text.Trim() + "'";
            }
            formRetailSaleConsignBill.bsSaleConsignBill.DataSource = rscb.GetDataTable(strSql);
            formRetailSaleConsignBill.dgvSaleConsignBill.DataSource = formRetailSaleConsignBill.bsSaleConsignBill;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            useful.InitFormContros(groupBox1,null);
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
