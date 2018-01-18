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
    public partial class FormBrowseRetailSaleOrderBill : Form
    {
        public delegate void TriggerEvent();
        public TriggerEvent te;
        string strJoinTag = null;

        FormRetailSaleOrderBill formRetailSaleOrderBill = null;
        FormRetailSaleTradeBillInput formRetailSaleTradeBillInput = null;
        FormRetailSaleConsignBillInput formRetailSaleConsignBillInput = null;
        FormRetailUntreadBaseBillInput formRetailUntreadBaseBillInput = null;
        FormRetailBarterBaseBillInput formRetailBarterBaseBillInput = null;
        RetailSaleOrderBill rsob = new RetailSaleOrderBill();

        public FormBrowseRetailSaleOrderBill()
        {
            InitializeComponent();
        }

        private void ControlStatus()
        {
            //窗体控件状态切换
            txtCustomerName.ReadOnly = !txtCustomerName.ReadOnly;
            txtAddress.ReadOnly = !txtAddress.ReadOnly;
            txtPhoneNumber.ReadOnly = !txtPhoneNumber.ReadOnly;
            txtSaleBillNo.ReadOnly = !txtSaleBillNo.ReadOnly;
            dtpBillDate.Enabled = !dtpBillDate.Enabled;
            cbxProvinceCode.Enabled = !cbxProvinceCode.Enabled;
            chbIsTrade.Enabled = !chbIsTrade.Enabled;
            chbConsign.Enabled = !chbConsign.Enabled;
            txtCDNo.ReadOnly = !txtCDNo.ReadOnly;
        }

        private void FormBrowseRetailSaleOrderBill_Load(object sender, EventArgs e)
        {
            if (this.Owner.GetType() == typeof(FormRetailSaleTradeBillInput))
            {
                formRetailSaleTradeBillInput = (FormRetailSaleTradeBillInput)this.Owner;
                chbIsTrade.Visible = true;
                strJoinTag = "Inner";
            }
            if (this.Owner.GetType() == typeof(FormRetailSaleOrderBill))
            {
                lbSaleBillNo.Visible = true;
                txtSaleBillNo.Visible = true;
                formRetailSaleOrderBill = (FormRetailSaleOrderBill)this.Owner;
                strJoinTag = "Left";
                this.Text = "用户和订单信息";
            }
            if (this.Owner.GetType() == typeof(FormRetailSaleConsignBillInput))
            {
                chbConsign.Visible = true;
                formRetailSaleConsignBillInput = (FormRetailSaleConsignBillInput)this.Owner;
                strJoinTag = "Inner";
            }
            if (this.Owner.GetType() == typeof(FormRetailUntreadBaseBillInput))
            {
                txtSaleBillNo.Visible = true;
                lbSaleBillNo.Visible = true;
                formRetailUntreadBaseBillInput = (FormRetailUntreadBaseBillInput)this.Owner;
                strJoinTag = "Inner";
            }
            if (this.Owner.GetType() == typeof(FormRetailBarterBaseBillInput))
            {
                formRetailBarterBaseBillInput = (FormRetailBarterBaseBillInput)this.Owner;
                strJoinTag = "Left";
                this.Text = "用户和订单信息";
            }
            
            
            ControlBindDataSource cbds = new ControlBindDataSource();
            cbds.ComboBoxBindDataSource(cbxProvinceCode, "ProvinceCode", "ProvinceName", "Select * From Province", "Province");
            cbds.DataGridViewComboBoxColumnBindDataSource(GoodsTypeCode, "GoodsTypeCode", "GoodsTypeName", "Select * From GoodsType", "GoodsType");
            cbds.DataGridViewComboBoxColumnBindDataSource(GoodsSeriesCode, "GoodsSeriesCode", "GoodsSeriesName", "Select * From GoodsSeries", "GoodsSeries");
            cbds.DataGridViewComboBoxColumnBindDataSource(EmployeeCode, "EmployeeCode", "EmployeeName", "Select * From Employee", "Employee");
            cbxProvinceCode.SelectedIndex = -1;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string strSql = null;
            if (!chbIsCDNo.Checked) //没有选中光盘号查询
            {
                if (strJoinTag == "Left")
                {
                    strSql = "Select Customer.CustomerId,CustomerName,ProvinceCode,PhoneNumber,Address,PostalCode,URL,CustomerType ,SaleOrderBill.* From Customer Left JOIN SaleOrderBill "
                        + "On Customer.CustomerId = SaleOrderBill.CustomerId  Where (CustomerType = '2' or CustomerType = '3' or CustomerType = '1') ";//现在只读取零售用户的订单记录（左连接）
                }
                else
                {
                    strSql = "Select SaleOrderBill.*,Customer.CustomerId,CustomerName,ProvinceCode,PhoneNumber,Address,PostalCode,URL,CustomerType From SaleOrderBill,Customer "
                       + "Where SaleOrderBill.CustomerId = Customer.CustomerId and (CustomerType = '2' or CustomerType = '3' or CustomerType = '1') ";//现在只读取零售用户的订单记录(内连接)
                }
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
                if (dtpBillDate.Checked)
                {
                    strSql += " and BillDate = '" + dtpBillDate.Value.Date + "'";
                }
                if (!String.IsNullOrEmpty(txtSaleBillNo.Text.Trim()))
                {
                    strSql += " and SaleBillNo like '%" + txtSaleBillNo.Text.Trim() + "%'";
                }
                if (chbIsTrade.Visible)  //可视，则是交易单打开该窗体
                {
                    if (chbIsTrade.Checked)
                    {
                        strSql += " and SaleOrderBill.SaleBillNo not in(Select SaleTradeBill.SaleBillNo From SaleTradeBill) "; //是否可以改进
                    }
                }
                if (chbConsign.Visible)
                {
                    if (chbConsign.Checked)
                    {
                        strSql += " and SaleOrderBill.SaleBillNo in(Select SaleTradeBill.SaleBillNo From SaleTradeBill) "; //是否可以改进
                        strSql += " and SaleOrderBill.SaleBillNo not in(Select SaleConsignBill.SaleBillNo From SaleConsignBill) "; //是否可以改进
                    }
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
                strSql = "Select SaleOrderBill.*,Customer.CustomerId,CustomerName,ProvinceCode,PhoneNumber,Address,PostalCode,URL,CustomerType From SaleOrderBill,Customer,SaleCDRecord,SaleConsignBill "
                       + " Where SaleCDRecord.SaleConsignBillId = SaleConsignBill.Id and  SaleConsignBill.SaleBillNo =  SaleOrderBill.SaleBillNo and  SaleOrderBill.CustomerId = Customer.CustomerId and (Customer.CustomerType = '2' or Customer.CustomerType = '3' or Customer.CustomerType = '1')  and SaleCDRecord.CDNo = '"+txtCDNo.Text.Trim()+"'";//现在只读取零售用户的订单记录(内连接)
            }
            //DataGridView控件绑定到数据源
            dgvRetailSaleOrderBill.DataSource = rsob.GetDataTable(strSql);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtCustomerName.Text = "";
            txtPhoneNumber.Text = "";
            txtSaleBillNo.Text = "";
            dtpBillDate.Checked = false;
            txtCDNo.Text = "";
            txtAddress.Text = "";
            chbIsTrade.Checked = true;
            chbConsign.Checked = true;
            cbxProvinceCode.SelectedIndex = -1;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void dgvRetailSaleOrderBill_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (formRetailSaleOrderBill != null)
            {
                //公共的false
                formRetailSaleOrderBill.toolSave.Enabled = false;
                formRetailSaleOrderBill.toolCancel.Enabled = false;
                formRetailSaleOrderBill.chbIsAgent.Enabled = false;
                //公共的true
                formRetailSaleOrderBill.toolAdd.Enabled = true;
                formRetailSaleOrderBill.toolBrowse.Enabled = true;
                //判断是否代理商
                if (dgvRetailSaleOrderBill.CurrentRow.Cells["CustomerType"].Value.ToString() == "1")  //代理商
                {
                    //代理商在这里不可以修改和删除
                    formRetailSaleOrderBill.toolAmend.Enabled = false;
                    formRetailSaleOrderBill.toolDelete.Enabled = false;
                    //打上代理商标记
                    formRetailSaleOrderBill.chbIsAgent.Checked = true;
                    formRetailSaleOrderBill.cbxCustomerId.SelectedValue = dgvRetailSaleOrderBill.CurrentRow.Cells["CustomerId"].Value;
                }
                else
                {
                    //非代理商可以修改和删除
                    formRetailSaleOrderBill.toolAmend.Enabled = true;
                    formRetailSaleOrderBill.toolDelete.Enabled = true;
                    //打上非代理商标记
                    formRetailSaleOrderBill.chbIsAgent.Checked = false;
                    formRetailSaleOrderBill.txtCustomerName.Text = dgvRetailSaleOrderBill.CurrentRow.Cells["CustomerName"].Value.ToString();
                    if (dgvRetailSaleOrderBill.CurrentRow.Cells["CustomerType"].Value.ToString() == "2")  //个人零售
                    {
                        formRetailSaleOrderBill.rbCustomerType2.Checked = true;
                    }
                    else  //单位零售
                    {
                        formRetailSaleOrderBill.rbCustomerType3.Checked = true;
                    }
                }
                formRetailSaleOrderBill.cbxProvinceCode.SelectedValue = dgvRetailSaleOrderBill.CurrentRow.Cells["ProvinceCode"].Value;
                formRetailSaleOrderBill.txtAddress.Text = dgvRetailSaleOrderBill.CurrentRow.Cells["Address"].Value.ToString();
                formRetailSaleOrderBill.txtPostalCode.Text = dgvRetailSaleOrderBill.CurrentRow.Cells["PostalCode"].Value.ToString();
                formRetailSaleOrderBill.txtPhoneNumber.Text = dgvRetailSaleOrderBill.CurrentRow.Cells["PhoneNumber"].Value.ToString();
                formRetailSaleOrderBill.txtURL.Text = dgvRetailSaleOrderBill.CurrentRow.Cells["URL"].Value.ToString();
                formRetailSaleOrderBill.txtRemark.Text = dgvRetailSaleOrderBill.CurrentRow.Cells["Remark"].Value.ToString();
                //CustomerNo属性
                formRetailSaleOrderBill.CustomerNo = Convert.ToInt32(dgvRetailSaleOrderBill.CurrentRow.Cells["CustomerId"].Value);
                //显示销售订单记录
                formRetailSaleOrderBill.bsSaleOrderBill.DataSource = rsob.GetDataTable("SaleOrderBill", "Where CustomerId = '" + dgvRetailSaleOrderBill.CurrentRow.Cells["CustomerId"].Value.ToString() + "'");
                formRetailSaleOrderBill.dgvSaleOrderBill.DataSource = formRetailSaleOrderBill.bsSaleOrderBill;
            }
            if (formRetailSaleTradeBillInput != null)
            {
                formRetailSaleTradeBillInput.txtSaleBillNo.Text = dgvRetailSaleOrderBill.CurrentRow.Cells["SaleBillNo"].Value.ToString();
                te();
            }
            if (formRetailSaleConsignBillInput != null)
            {
                formRetailSaleConsignBillInput.txtSaleBillNo.Text = dgvRetailSaleOrderBill.CurrentRow.Cells["SaleBillNo"].Value.ToString();
                DataTable dt = dgvRetailSaleOrderBill.DataSource as DataTable;
                DataRow dr = dt.AsEnumerable().FirstOrDefault(itm => itm.Field<string>("SaleBillNo") == dgvRetailSaleOrderBill.CurrentRow.Cells["SaleBillNo"].Value.ToString());
                //使用SetOrderBillInfo方法给界面上的订货单信息赋值
                formRetailSaleConsignBillInput.SetOrderBillInfo(dr);
                //使用RetrieveTradeBillInfo方法检索交易单信息，并给界面上的交易单信息赋值
                formRetailSaleConsignBillInput.RetrieveTradeBillInfo(dgvRetailSaleOrderBill.CurrentRow.Cells["SaleBillNo"].Value.ToString());
                //使用RetrieveConsignBillInfo方法检索发货单信息,并给界面上的发货单信息赋值
                formRetailSaleConsignBillInput.RetrieveConsignBillInfo(dgvRetailSaleOrderBill.CurrentRow.Cells["SaleBillNo"].Value.ToString());
            }
            if (formRetailUntreadBaseBillInput != null)
            {
                formRetailUntreadBaseBillInput.txtSaleBillNo.Text = dgvRetailSaleOrderBill.CurrentRow.Cells["SaleBillNo"].Value.ToString();
                DataTable dt = dgvRetailSaleOrderBill.DataSource as DataTable;
                DataRow dr = dt.AsEnumerable().FirstOrDefault(itm => itm.Field<string>("SaleBillNo") == dgvRetailSaleOrderBill.CurrentRow.Cells["SaleBillNo"].Value.ToString());
                //使用SetOrderBillInfo方法给界面上的订货单信息赋值
                formRetailUntreadBaseBillInput.SetOrderBillInfo(dr);
                //使用GetUntreadBillInfo方法检索退货信息，并给界面上的退货信息赋值
                formRetailUntreadBaseBillInput.GetUntreadBillInfo(dgvRetailSaleOrderBill.CurrentRow.Cells["SaleBillNo"].Value.ToString());
            }
            if (formRetailBarterBaseBillInput != null)
            {
                if (Convert.IsDBNull(dgvRetailSaleOrderBill.CurrentRow.Cells["SaleBillNo"].Value))
                {
                    formRetailBarterBaseBillInput.txtSaleBillNo.Text = "";
                    formRetailBarterBaseBillInput.txtCustomerName.Text = dgvRetailSaleOrderBill.CurrentRow.Cells["CustomerName"].Value.ToString();
                    formRetailBarterBaseBillInput.txtPhoneNumber.Text = dgvRetailSaleOrderBill.CurrentRow.Cells["PhoneNumber"].Value.ToString();
                    formRetailBarterBaseBillInput.txtAddress.Text = dgvRetailSaleOrderBill.CurrentRow.Cells["Address"].Value.ToString();
                }
                else
                {
                    formRetailBarterBaseBillInput.txtSaleBillNo.Text = dgvRetailSaleOrderBill.CurrentRow.Cells["SaleBillNo"].Value.ToString();
                    DataTable dt = dgvRetailSaleOrderBill.DataSource as DataTable;
                    DataRow dr = dt.AsEnumerable().FirstOrDefault(itm => itm.Field<string>("SaleBillNo") == dgvRetailSaleOrderBill.CurrentRow.Cells["SaleBillNo"].Value.ToString());
                    //使用SetOrderBillInfo方法给界面上的订货单信息赋值
                    formRetailBarterBaseBillInput.SetSaleBillInfo(dr);
                }
                
            }
           
           
            this.Close();
        }
    }
}
