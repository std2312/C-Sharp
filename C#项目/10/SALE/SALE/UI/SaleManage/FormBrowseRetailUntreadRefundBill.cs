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
    public partial class FormBrowseRetailUntreadRefundBill : Form
    {
        FormRetailUntreadRefundBill formRetailUntreadRefundBill = null;
        Useful useful = new Useful();

        public FormBrowseRetailUntreadRefundBill()
        {
            InitializeComponent();
        }

        private void FormBrowseRetailUntreadRefundBill_Load(object sender, EventArgs e)
        {
            formRetailUntreadRefundBill = (FormRetailUntreadRefundBill)this.Owner;
            ControlBindDataSource cbds = new ControlBindDataSource();
            cbds.BindDataSource(this);
            useful.InitFormContros(this, null);
            dtpAppendDate.Checked = false;
            dtpUntreadMoneyDate.Checked = false;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            RetailUntreadRefundBill rurb = new RetailUntreadRefundBill();
            string strSql = null;
            if (!chbIsCDNo.Checked) //没有选中光盘号查询
            {
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
                if (!String.IsNullOrEmpty(txtUntreadBillNo.Text.Trim()))
                {
                    strSql += " and UntreadRefundBill.UntreadBillNo like '%" + txtUntreadBillNo.Text.Trim() + "%'";
                }
                if (!(cbxPayTypeCode.SelectedValue == null))
                {
                    strSql += " and UntreadRefundBill.PayTypeCode = '" + cbxPayTypeCode.SelectedValue.ToString() + "'";
                }
                if (!(cbxEmployeeCode3.SelectedValue == null))
                {
                    strSql += " and UntreadRefundBill.EmployeeCode3 = '" + cbxEmployeeCode3.SelectedValue.ToString() + "'";
                }
                if (dtpUntreadMoneyDate.Checked)
                {
                    strSql += " and UntreadRefundBill.UntreadMoneyDate = '" + dtpUntreadMoneyDate.Value.Date + "'";
                }
                if (dtpAppendDate.Checked)
                {
                    strSql += " and UntreadRefundBill.AppendDate = '" + dtpAppendDate.Value.Date + "'";
                }
                strSql = rurb.UntreadRefundBillSql + strSql;
            }
            if (chbIsCDNo.Checked) //选中光盘号查询
            {
                strSql = rurb.UntreadRefundBill_CDNo_Sql + " and UntreadCDRecord.CDNo = '" + txtCDNo.Text.Trim() + "'";
            }
            formRetailUntreadRefundBill.dgvUntreadRefundBill.DataSource = rurb.GetDataTable(strSql);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            useful.InitFormContros(this, null);
            dtpAppendDate.Checked = false;
            dtpUntreadMoneyDate.Checked = false;
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
