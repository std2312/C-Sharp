using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SALE.Common;
using SALE.BLL.SaleManage;

namespace SALE.UI.SaleManage
{
    public partial class FormBrowseRetailBarterBaseBillOther : Form
    {
        FormRetailBarterExchangeBillInput formRetailBarterExchangeBillInput = null;
        FormRetailBarterConsignBillInput formRetailBarterConsignBillInput = null;
        Useful useful = new Useful();

        public FormBrowseRetailBarterBaseBillOther()
        {
            InitializeComponent();
        }

        private string GetQueryInfoString()
        {
            string strSql = string.Empty;
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
            if (dtpBarterBillDate.Checked)
            {
                strSql += " and BarterBaseBill.BarterBillDate = '" + dtpBarterBillDate.Value.Date + "'";
            }
            if (!(cbxBarterType.SelectedValue == null))
            {
                strSql += " and BarterBaseBill.BarterType = '" + cbxBarterType.SelectedValue.ToString() + "'";
            }
            if (!(cbxGoodsTypeCode1.SelectedValue == null))
            {
                strSql += " and BarterBaseBill.GoodsTypeCode1 = '" + cbxGoodsTypeCode1.SelectedValue.ToString() + "'";
            }
            if (!(cbxGoodsSeriesCode1.SelectedValue == null))
            {
                strSql += " and BarterBaseBill.GoodsSeriesCode1 = '" + cbxGoodsSeriesCode1.SelectedValue.ToString() + "'";
            }
            if (chbIsExchange.Visible)
            {
                if (chbIsExchange.Checked)
                {
                    strSql += " and BarterBaseBill.BarterBillNo not in(Select BarterExchangeBill.BarterBillNo From BarterExchangeBill) "; //是否可以改进
                }
            }
            if (chbIsConsign.Visible)
            {
                if (chbIsConsign.Checked)
                {
                    strSql += " and BarterBaseBill.BarterBillNo not in(Select BarterConsignBill.BarterBillNo From BarterConsignBill) "; //是否可以改进
                }
            }
            return strSql;
        }

        private void FormBrowseRetailBarterBaseBillOther_Load(object sender, EventArgs e)
        {
            ControlBindDataSource cbds = new ControlBindDataSource();
            cbds.BindDataSource(this);
            cbds.DataGridViewComboBoxColumnBindDataSource(GoodsTypeCode, "GoodsTypeCode", "GoodsTypeName", "Select * From GoodsType", "GoodsType");
            cbds.DataGridViewComboBoxColumnBindDataSource(GoodsSeriesCode, "GoodsSeriesCode", "GoodsSeriesName", "Select * From GoodsSeries", "GoodsSeries");
            cbds.DataGridViewComboBoxColumnBindDataSource(GoodsTypeCode1, "GoodsTypeCode", "GoodsTypeName", "Select * From GoodsType", "GoodsType");
            cbds.DataGridViewComboBoxColumnBindDataSource(GoodsSeriesCode1, "GoodsSeriesCode", "GoodsSeriesName", "Select * From GoodsSeries", "GoodsSeries");
            cbds.DataGridViewComboBoxColumnBindDataSource(EmployeeCode1, "EmployeeCode", "EmployeeName", "Select * From Employee", "Employee");
            cbds.DataGridViewComboBoxColumnBindDataSource(OperatorCode, "OperatorCode", "OperatorName", "Select * From Operator", "Operator");
            useful.InitFormContros(this, null);
            dtpBarterBillDate.Checked = false;
            if (this.Owner.GetType() == typeof(FormRetailBarterExchangeBillInput))  //调款单
            {
                formRetailBarterExchangeBillInput = (FormRetailBarterExchangeBillInput)this.Owner;
                chbIsExchange.Visible = true;
            }
            if (this.Owner.GetType() == typeof(FormRetailBarterConsignBillInput))  //发货单
            {
                formRetailBarterConsignBillInput = (FormRetailBarterConsignBillInput)this.Owner;
                chbIsConsign.Visible = true;
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string strSql = String.Empty;  //声明string变量并初始化
            RetailBarterBaseBill rbbb = new RetailBarterBaseBill();
            if (!chbIsCDNo.Checked)  //没有选中光盘号查询
            {
                strSql = rbbb.BarterBaseBillSql + GetQueryInfoString();  //设置基本的Sql语句
            }
            if (chbIsCDNo.Checked)  //选中光盘号查询
            {
                strSql = rbbb.BarterBaseBill_CDNo_Sql + " and BarterBaseCDRecord.CDNo = '" + txtCDNo.Text.Trim() + "'";
            }
            dgvBarterBaseBill.DataSource = rbbb.GetDataTable(strSql);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            useful.InitFormContros(this, null);
            dtpBarterBillDate.Checked = false;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvBarterBaseBill_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBarterBaseBill.RowCount > 0)
            {
                if (!(formRetailBarterExchangeBillInput == null))
                {
                    formRetailBarterExchangeBillInput.txtBarterBillNo.Text = dgvBarterBaseBill.CurrentRow.Cells["BarterBillNo"].Value.ToString();
                    DataTable dt = dgvBarterBaseBill.DataSource as DataTable;
                    DataRow dr = dt.AsEnumerable().FirstOrDefault(itm => itm.Field<string>("BarterBillNo") == dgvBarterBaseBill.CurrentRow.Cells["BarterBillNo"].Value.ToString());
                    formRetailBarterExchangeBillInput.SetBarterBaseInfo(dr);
                }
                if (!(formRetailBarterConsignBillInput == null))
                {
                    formRetailBarterConsignBillInput.txtBarterBillNo.Text = dgvBarterBaseBill.CurrentRow.Cells["BarterBillNo"].Value.ToString();
                    DataTable dt = dgvBarterBaseBill.DataSource as DataTable;
                    DataRow dr = dt.AsEnumerable().FirstOrDefault(itm => itm.Field<string>("BarterBillNo") == dgvBarterBaseBill.CurrentRow.Cells["BarterBillNo"].Value.ToString());
                    formRetailBarterConsignBillInput.SetBarterBaseInfo(dr);
                    formRetailBarterConsignBillInput.GetBarterExchangeInfo(formRetailBarterConsignBillInput.txtBarterBillNo.Text);
                }
                this.Close();
            }
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
