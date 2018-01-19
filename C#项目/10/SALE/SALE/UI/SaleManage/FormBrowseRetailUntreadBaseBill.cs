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
    public partial class FormBrowseRetailUntreadBaseBill : Form
    {
        FormRetailUntreadBaseBill formRetailUntreadBaseBill = null;
        Useful useful = new Useful();

        public FormBrowseRetailUntreadBaseBill()
        {
            InitializeComponent();
        }

        private void FormBrowseRetailUntreadBaseBill_Load(object sender, EventArgs e)
        {
            formRetailUntreadBaseBill = (FormRetailUntreadBaseBill)this.Owner;
            ControlBindDataSource cbds = new ControlBindDataSource();
            cbds.BindDataSource(this);
            useful.InitFormContros(this, null);
            dtpAppendDate.Checked = false;
            dtpUntreadBillDate.Checked = false;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            RetailUntreadBaseBill rubb = new RetailUntreadBaseBill();
            string strSql = null;
            if (!chbIsCDNo.Checked) //没有选中光盘号查询
            {
                strSql = "Select UntreadBaseBill.* From UntreadBaseBill,Customer "
                    + "Where UntreadBaseBill.CustomerId = Customer.CustomerId ";
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
                    strSql += " and UntreadBillNo like '%" + txtUntreadBillNo.Text.Trim() + "%'";
                }
                if (!(cbxGoodsTypeCode.SelectedValue == null))
                {
                    strSql += " and GoodsTypeCode = '" + cbxGoodsTypeCode.SelectedValue.ToString() + "'";
                }
                if (!(cbxGoodsSeriesCode.SelectedValue == null))
                {
                    strSql += " and GoodsSeriesCode = '" + cbxGoodsSeriesCode.SelectedValue.ToString() + "'";
                }
                if (dtpUntreadBillDate.Checked)
                {
                    strSql += " and UntreadBillDate = '" + dtpUntreadBillDate.Value.Date + "'";
                }
                if (dtpAppendDate.Checked)
                {
                    strSql += " and UntreadBaseBill.AppendDate = '" + dtpAppendDate.Value.Date + "'";
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
                strSql = "Select UntreadBaseBill.* From UntreadCDRecord, UntreadBaseBill,Customer "
                    + "Where UntreadCDRecord.UntreadBillNo = UntreadBaseBill.UntreadBillNo and UntreadBaseBill.CustomerId = Customer.CustomerId ";
            }
            formRetailUntreadBaseBill.bsUntreadBaseBill.DataSource = rubb.GetDataTable(strSql);
            formRetailUntreadBaseBill.dgvUntreadBaseBill.DataSource = formRetailUntreadBaseBill.bsUntreadBaseBill;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            useful.InitFormContros(this, null);
            dtpAppendDate.Checked = true;
            dtpUntreadBillDate.Checked = true;
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
