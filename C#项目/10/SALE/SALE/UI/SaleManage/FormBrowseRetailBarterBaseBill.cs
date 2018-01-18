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
    public partial class FormBrowseRetailBarterBaseBill : Form
    {
        FormRetailBarterBaseBill formRetailBarterBaseBill = null;
        Useful useful = new Useful();

        public FormBrowseRetailBarterBaseBill()
        {
            InitializeComponent();
        }

        private void FormBrowseRetailBarterBaseBill_Load(object sender, EventArgs e)
        {
            formRetailBarterBaseBill = (FormRetailBarterBaseBill)this.Owner;
            ControlBindDataSource cbds = new ControlBindDataSource();
            cbds.BindDataSource(this);
            useful.InitFormContros(this, null);
            dtpAppendDate.Checked = false;
            dtpBarterBillDate.Checked = false; 
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            RetailBarterBaseBill rbbb = new RetailBarterBaseBill();
            string strSql = null;
            if (!chbIsCDNo.Checked) //没有选中光盘号查询
            {
                strSql = rbbb.BarterBaseBillSql;
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
                    strSql += " and BarterBaseBill.BarterBillNo like '%" + txtBarterBillNo.Text.Trim() + "%'";
                }
                if (!(cbxBarterType.SelectedValue == null))
                {
                    strSql += " and BarterBaseBill.BarterType = '" + cbxBarterType.SelectedValue.ToString() + "'";
                }
                if (!(cbxEmployeeCode1.SelectedValue == null))
                {
                    strSql += " and BarterBaseBill.EmployeeCode1 = '" + cbxEmployeeCode1.SelectedValue.ToString() + "'";
                }
                if (dtpBarterBillDate.Checked)
                {
                    strSql += " and BarterBaseBill.BarterBillDate = '" + dtpBarterBillDate.Value.Date + "'";
                }
                if (dtpAppendDate.Checked)
                {
                    strSql += " and BarterBaseBill.AppendDate = '" + dtpAppendDate.Value.Date + "'";
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
                strSql = rbbb.BarterBaseBill_CDNo_Sql + " and BarterBaseCDRecord.CDNo = '" + txtCDNo.Text.Trim() + "'";
            }
            formRetailBarterBaseBill.dgvBarterBaseBill.DataSource = rbbb.GetDataTable(strSql);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            useful.InitFormContros(this, null);
            dtpAppendDate.Checked = false;
            dtpBarterBillDate.Checked = false;
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
