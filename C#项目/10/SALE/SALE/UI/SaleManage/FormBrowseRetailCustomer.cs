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
    public partial class FormBrowseRetailCustomer : Form
    {
        FormRetailSaleOrderBill formRetailOperation = new FormRetailSaleOrderBill();
        
        public FormBrowseRetailCustomer()
        {
            InitializeComponent();
        }

        private void ControlStatus()
        {
            //窗体控件状态切换
            txtCustomerName.ReadOnly = !txtCustomerName.ReadOnly;
            txtAddress.ReadOnly = !txtAddress.ReadOnly;
            txtPhoneNumber.ReadOnly = !txtPhoneNumber.ReadOnly;
            txtURL.ReadOnly = !txtURL.ReadOnly;
            cbxProvinceCode.Enabled = !cbxProvinceCode.Enabled;
            txtCDNo.ReadOnly = !txtCDNo.ReadOnly;
        }

        private void FormBrowseRetailCustomer_Load(object sender, EventArgs e)
        {
            formRetailOperation = (FormRetailSaleOrderBill)this.Owner;
            ControlBindDataSource cbds = new ControlBindDataSource();
            cbds.ComboBoxBindDataSource(cbxProvinceCode, "ProvinceCode", "ProvinceName", "Select * From Province", "Province");
            cbds.DataGridViewComboBoxColumnBindDataSource(ProvinceCode, "ProvinceCode", "ProvinceName", "Select * From Province", "Province");
            cbds.DataGridViewComboBoxColumnBindDataSource(CustomerType, "CustomerType", "Remark", "Select * From SysCustomerType", "SysCustomerType");
            cbxProvinceCode.SelectedIndex = -1;
        }

        private void chbIsCDNo_CheckedChanged(object sender, EventArgs e)
        {
            if (chbIsCDNo.Checked)
            {
                ControlStatus();
                txtCDNo.Focus();
            }
            else
            {
                ControlStatus();
                txtCustomerName.Focus();
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            RetailCustomer ro = new RetailCustomer();
            if (!chbIsCDNo.Checked) //没有选中光盘号查询
            {
                string strWhere = "Where (CustomerType = '2' or CustomerType = '3')";
                if (!String.IsNullOrEmpty(txtCustomerName.Text.Trim()))
                {
                    strWhere += " and CustomerName like '%" + txtCustomerName.Text.Trim() + "%'";
                }
                if (!(cbxProvinceCode.SelectedValue == null))
                {
                    strWhere += " and ProvinceCode = '" + cbxProvinceCode.SelectedValue.ToString() + "'";
                }
                if (!String.IsNullOrEmpty(txtAddress.Text.Trim()))
                {
                    strWhere += " and Address like '%" + txtAddress.Text.Trim() + "%'";
                }
                if (!String.IsNullOrEmpty(txtPhoneNumber.Text.Trim()))
                {
                    strWhere += " and PhoneNumber like '%" + txtPhoneNumber.Text.Trim() + "%'";
                }
                if (!String.IsNullOrEmpty(txtURL.Text.Trim()))
                {
                    strWhere += " and URL like '%" + txtURL.Text.Trim() + "%'";
                }
                dgvRetailCustomer.DataSource = ro.GetDataTable("Customer", strWhere);
            }
            if (chbIsCDNo.Checked) //选中光盘号查询
            {
                if (String.IsNullOrEmpty(txtCDNo.Text.Trim()))
                {
                    MessageBox.Show("请输入光盘号！", "软件提示");
                    txtCDNo.Focus();
                    return;
                }
                string strSql = "Select Customer.* From Customer,SaleOrderBill,SaleCDRecord,SaleConsignBill Where SaleCDRecord.SaleConsignBillId = SaleConsignBill.Id and SaleConsignBill.SaleBillNo = SaleOrderBill.SaleBillNo and SaleOrderBill.CustomerId = Customer.CustomerId";
                dgvRetailCustomer.DataSource = ro.GetDataTable(strSql);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtCustomerName.Text = "";
            txtPhoneNumber.Text = "";
            txtURL.Text = "";
            txtCDNo.Text = "";
            txtAddress.Text = "";
            cbxProvinceCode.SelectedIndex = -1;
        }

        private void dgvRetailCustomer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            RetailSaleOrderBill rsb = new RetailSaleOrderBill();
            formRetailOperation.CustomerNo = Convert.ToInt32(dgvRetailCustomer.CurrentRow.Cells["CustomerId"].Value);
            formRetailOperation.txtCustomerName.Text = dgvRetailCustomer.CurrentRow.Cells["CustomerName"].Value.ToString();
            formRetailOperation.cbxProvinceCode.SelectedValue = dgvRetailCustomer.CurrentRow.Cells["ProvinceCode"].Value;
            formRetailOperation.txtAddress.Text = dgvRetailCustomer.CurrentRow.Cells["Address"].Value.ToString();
            formRetailOperation.txtPostalCode.Text = dgvRetailCustomer.CurrentRow.Cells["PostalCode"].Value.ToString();
            formRetailOperation.txtPhoneNumber.Text = dgvRetailCustomer.CurrentRow.Cells["PhoneNumber"].Value.ToString();
            formRetailOperation.txtURL.Text = dgvRetailCustomer.CurrentRow.Cells["URL"].Value.ToString();
            if (dgvRetailCustomer.CurrentRow.Cells["CustomerType"].Value.ToString() == "2")  //个人
            {
                formRetailOperation.rbCustomerType2.Checked = true;
            }
            else  //单位
            {
                formRetailOperation.rbCustomerType3.Checked = true;
            }
            formRetailOperation.txtRemark.Text = dgvRetailCustomer.CurrentRow.Cells["Remark"].Value.ToString();
            //显示销售单记录
            formRetailOperation.bsSaleOrderBill.DataSource = rsb.GetDataTable("SaleBill", "Where CustomerId = '" + dgvRetailCustomer.CurrentRow.Cells["CustomerId"].Value.ToString() + "'");
            formRetailOperation.dgvSaleOrderBill.DataSource = formRetailOperation.bsSaleOrderBill;
            //
            formRetailOperation.toolSave.Enabled = false;
            formRetailOperation.toolCancel.Enabled = false;
            //
            formRetailOperation.toolAdd.Enabled = true;
            formRetailOperation.toolAmend.Enabled = true;
            formRetailOperation.toolDelete.Enabled = true;
            formRetailOperation.toolBrowse.Enabled = true;
            //
            this.Close();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }      
    }
}
