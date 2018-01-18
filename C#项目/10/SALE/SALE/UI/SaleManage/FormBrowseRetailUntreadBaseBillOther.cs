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
    public partial class FormBrowseRetailUntreadBaseBillOther : Form
    {
        FormRetailUntreadGatherBillInput formRetailUntreadGatherBillInput = null;
        FormRetailUntreadRefundBillInput formRetailUntreadRefundBillInput = null;
        Useful useful = new Useful();

        public FormBrowseRetailUntreadBaseBillOther()
        {
            InitializeComponent();
        }

        private void ControlStatus()
        {
            //窗体控件状态切换
            txtCustomerName.ReadOnly = !txtCustomerName.ReadOnly;
            txtAddress.ReadOnly = !txtAddress.ReadOnly;
            txtPhoneNumber.ReadOnly = !txtPhoneNumber.ReadOnly;
            txtCDNo.ReadOnly = !txtCDNo.ReadOnly;
            cbxGoodsSeriesCode.Enabled = !cbxGoodsSeriesCode.Enabled;
            cbxGoodsTypeCode.Enabled = !cbxGoodsTypeCode.Enabled;
            cbxProvinceCode.Enabled = !cbxProvinceCode.Enabled;
            dtpUntreadBillDate.Enabled = !dtpUntreadBillDate.Enabled;
            chbIsGather.Enabled = !chbIsGather.Enabled;
        }

        private void FormBrowseRetailUntreadBaseBillOther_Load(object sender, EventArgs e)
        {
            if (this.Owner.GetType() == typeof(FormRetailUntreadGatherBillInput))
            {
                formRetailUntreadGatherBillInput = (FormRetailUntreadGatherBillInput)this.Owner;
                chbIsGather.Visible = true;
            }
            if (this.Owner.GetType() == typeof(FormRetailUntreadRefundBillInput))
            {
                formRetailUntreadRefundBillInput = (FormRetailUntreadRefundBillInput)this.Owner;
                chbIsRefund.Visible = true;
            }
            ControlBindDataSource cbds = new ControlBindDataSource();
            cbds.BindDataSource(this);
            cbds.DataGridViewComboBoxColumnBindDataSource(GoodsTypeCode, "GoodsTypeCode", "GoodsTypeName", "Select * From GoodsType", "GoodsType");
            cbds.DataGridViewComboBoxColumnBindDataSource(GoodsSeriesCode, "GoodsSeriesCode", "GoodsSeriesName", "Select * From GoodsSeries", "GoodsSeries");
            cbds.DataGridViewComboBoxColumnBindDataSource(EmployeeCode1, "EmployeeCode", "EmployeeName", "Select * From Employee", "Employee");
            cbds.DataGridViewComboBoxColumnBindDataSource(OperatorCode, "OperatorCode", "OperatorName", "Select * From Operator", "Operator");
            useful.InitFormContros(this, null);
            dtpUntreadBillDate.Checked = false;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            RetailUntreadBaseBill rubb = new RetailUntreadBaseBill();
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

                if (!(cbxGoodsTypeCode.SelectedValue == null))
                {
                    strSql += " and UntreadBaseBill.GoodsTypeCode = '" + cbxGoodsTypeCode.SelectedValue.ToString() + "'";
                }
                if (!(cbxGoodsSeriesCode.SelectedValue == null))
                {
                    strSql += " and UntreadBaseBill.GoodsSeriesCode = '" + cbxGoodsSeriesCode.SelectedValue.ToString() + "'";
                }
                if (dtpUntreadBillDate.Checked)
                {
                    strSql += " and UntreadBillDate = '" + dtpUntreadBillDate.Value.Date + "'";
                }
                if (chbIsGather.Visible)
                {
                    if (chbIsGather.Checked)
                    {
                        strSql += " and UntreadBaseBill.UntreadBillNo not in(Select UntreadGatherBill.UntreadBillNo From UntreadGatherBill) "; //是否可以改进
                    }
                }
                if (chbIsRefund.Visible)
                {
                    if (chbIsRefund.Checked)
                    {
                        strSql += " and UntreadBaseBill.UntreadBillNo not in(Select UntreadRefundBill.UntreadBillNo From UntreadRefundBill) "; //是否可以改进
                    }
                }
                strSql = rubb.UntreadBaseBillSql + strSql; 
            }
            if (chbIsCDNo.Checked) //选中光盘号查询
            {
                if (String.IsNullOrEmpty(txtCDNo.Text.Trim()))
                {
                    MessageBox.Show("请输入光盘号！","软件提示");
                    txtCDNo.Focus();
                    return;
                }
                strSql = rubb.UntreadBaseBill_CDNo_Sql + " and UntreadCDRecord.CDNo = '" + txtCDNo.Text.Trim() + "'";
            }
            //设置DataTable主键，并为dgvRetailSaleOrderBill设置数据源
            DataTable dt = rubb.GetDataTable(strSql);
            dt.PrimaryKey = new DataColumn[] { dt.Columns["UntreadBillNo"] };
            dgvUntreadBaseBill.DataSource = dt;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            useful.InitFormContros(this, null);
            dtpUntreadBillDate.Checked = false;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvUntreadBaseBill_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (formRetailUntreadGatherBillInput != null)
            {
                formRetailUntreadGatherBillInput.txtUntreadBillNo.Text = dgvUntreadBaseBill.CurrentRow.Cells["UntreadBillNo"].Value.ToString();
                DataTable dt = dgvUntreadBaseBill.DataSource as DataTable;
                DataRow dr = dt.Rows.Find(dgvUntreadBaseBill.CurrentRow.Cells["UntreadBillNo"].Value);
                //使用SetOrderBillInfo方法给界面上的订货单信息赋值
                formRetailUntreadGatherBillInput.SetUntreadBaseBillInfo(dr);
            }
            if (formRetailUntreadRefundBillInput != null)
            {
                formRetailUntreadRefundBillInput.txtUntreadBillNo.Text = dgvUntreadBaseBill.CurrentRow.Cells["UntreadBillNo"].Value.ToString();
                DataTable dt = dgvUntreadBaseBill.DataSource as DataTable;
                DataRow dr = dt.Rows.Find(dgvUntreadBaseBill.CurrentRow.Cells["UntreadBillNo"].Value);
                //使用SetOrderBillInfo方法给界面上的订货单信息赋值
                formRetailUntreadRefundBillInput.SetUntreadBaseBillInfo(dr);
                formRetailUntreadRefundBillInput.GetUntreadGatherBillInfo(formRetailUntreadRefundBillInput.txtUntreadBillNo.Text);
                formRetailUntreadRefundBillInput.GetUntreadRefundBillInfo(formRetailUntreadRefundBillInput.txtUntreadBillNo.Text);
            }
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
