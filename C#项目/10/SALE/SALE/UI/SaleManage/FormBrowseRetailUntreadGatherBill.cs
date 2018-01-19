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
    public partial class FormBrowseRetailUntreadGatherBill : Form
    {
        FormRetailUntreadGatherBill formRetailUntreadGatherBill = null;
        Useful useful = new Useful();

        public FormBrowseRetailUntreadGatherBill()
        {
            InitializeComponent();
        }

        private void FormBrowseRetailUntreadGatherBill_Load(object sender, EventArgs e)
        {
            formRetailUntreadGatherBill = (FormRetailUntreadGatherBill)this.Owner;
            ControlBindDataSource cbds = new ControlBindDataSource();
            cbds.BindDataSource(this);
            useful.InitFormContros(this, null);
            dtpAppendDate.Checked = false;
            dtpSignDate2.Checked = false;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            RetailUntreadGatherBill rugb = new RetailUntreadGatherBill();
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
                    strSql += " and UntreadGatherBill.UntreadBillNo like '%" + txtUntreadBillNo.Text.Trim() + "%'";
                }
                if (!(cbxGoodsTypeCode.SelectedValue == null))
                {
                    strSql += " and GoodsTypeCode = '" + cbxGoodsTypeCode.SelectedValue.ToString() + "'";
                }
                if (!(cbxGoodsSeriesCode.SelectedValue == null))
                {
                    strSql += " and GoodsSeriesCode = '" + cbxGoodsSeriesCode.SelectedValue.ToString() + "'";
                }
                if (dtpSignDate2.Checked)
                {
                    strSql += " and UntreadGatherBill.SignDate2 = '" + dtpSignDate2.Value.Date + "'";
                }
                if (dtpAppendDate.Checked)
                {
                    strSql += " and UntreadGatherBill.AppendDate = '" + dtpAppendDate.Value.Date + "'";
                }
                strSql = rugb.UntreadGatherBillSql + strSql;
            }
            if (chbIsCDNo.Checked) //选中光盘号查询
            {
                if (String.IsNullOrEmpty(txtCDNo.Text.Trim()))
                {
                    MessageBox.Show("请输入光盘号！", "软件提示");
                    txtCDNo.Focus();
                    return;
                }
                strSql = rugb.UntreadGatherBill_CDNo_Sql + " and UntreadCDRecord.CDNo = '" + txtCDNo.Text.Trim() + "'";
            }
            formRetailUntreadGatherBill.bsUntreadGatherBill.DataSource = rugb.GetDataTable(strSql);
            formRetailUntreadGatherBill.dgvUntreadGatherBill.DataSource = formRetailUntreadGatherBill.bsUntreadGatherBill;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            useful.InitFormContros(this, null);
            dtpAppendDate.Checked = false;
            dtpSignDate2.Checked = false;
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
