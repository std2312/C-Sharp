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
    public partial class FormRetailSaleTradeBillInput : Form
    {
        FormRetailSaleTradeBill formRetailSaleTradeBill = null;

        public FormRetailSaleTradeBillInput()
        {
            InitializeComponent();
        }

        private void TriggerKeyDown()
        {
            txtSaleBillNo_KeyDown(txtSaleBillNo, new KeyEventArgs(Keys.Enter));
        }

        private void SetTradeBillControlsState(bool boolValue)
        {
            txtRemark1.ReadOnly = !boolValue;
            txtReceiptMoney.ReadOnly = !boolValue;
            txtTradeBillNo.ReadOnly = !boolValue;
            dtpSignDate1.Enabled = boolValue;
            dtpSignDate2.Enabled = boolValue;
            dtpSignDate3.Enabled = boolValue;
            dtpSaleDate.Enabled = boolValue;
            cbxBankCode.Enabled = boolValue;
            cbxPayTypeCode.Enabled = boolValue;
            cbxEmployeeCode1.Enabled = boolValue;
            cbxEmployeeCode2.Enabled = boolValue;
            cbxEmployeeCode3.Enabled = boolValue;
            btnSave.Enabled = boolValue;
        }

        private void InitOrderBillControls()
        {
            //txtSaleBillNo.Text = "";
            txtAddress.Text = "";
            txtCertificateNumber1.Text = "";
            txtCertificateNumber2.Text = "";
            txtCustomerName.Text = "";
            txtDiscount.Text = "";
            txtPhoneNumber.Text = "";
            txtPostalCode.Text = "";
            txtQuantity.Text = "";
            txtRemark.Text = "";
            txtUnitPrice.Text = "";
            txtWriteOffName1.Text = "";
            txtWriteOffName2.Text = "";
            dtpBillDate.Value = GlobalProperty.DBTime;
            dtpSignDate.Value = GlobalProperty.DBTime;
            dtpSignDate3.Checked = true;
            cbxGoodsTypeCode.SelectedIndex = -1;
            cbxGoodsSeriesCode.SelectedIndex = -1;
            cbxEmployeeCode.SelectedIndex = -1;
            rbIsNeedInvoice0.Checked = true;
            chbWriteOffType1.Checked = false;
            chbWriteOffType2.Checked = false;
        }

        private void InitTradeBillControls()
        {
            txtRemark1.Text = "";
            txtSaleMoney.Text = "";
            txtTradeBillNo.Text = "";
            dtpSignDate1.Value = GlobalProperty.DBTime;
            dtpSignDate1.Checked = true;
            dtpSignDate2.Value = GlobalProperty.DBTime;
            dtpSignDate2.Checked = true;
            dtpSignDate3.Value = GlobalProperty.DBTime;
            dtpSignDate3.Checked = true;
            dtpSaleDate.Value = GlobalProperty.DBTime;
            cbxBankCode.SelectedIndex = -1;
            cbxPayTypeCode.SelectedIndex = -1;
            cbxEmployeeCode1.SelectedIndex = -1;
            cbxEmployeeCode2.SelectedIndex = -1;
            cbxEmployeeCode3.SelectedIndex = -1;
        }

        private void SetOrderBillInfo(string strSaleBillNo)
        {
            string strSql = null;
            DataTable dt = null;
            RetailSaleOrderBill rsob = new RetailSaleOrderBill();
            strSql = "Select SaleOrderBill.*,Customer.* From SaleOrderBill,Customer Where SaleOrderBill.CustomerId = Customer.CustomerId and SaleBillNo = '" + strSaleBillNo + "'";
            dt = rsob.GetDataTable(strSql);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("该销售单号不存在！", "软件提示");
                txtSaleBillNo.Focus();
                return;
            }
            //零售用户的基本档案信息
            txtCustomerName.Text = dt.Rows[0]["CustomerName"].ToString();
            txtPhoneNumber.Text = dt.Rows[0]["PhoneNumber"].ToString();
            txtPostalCode.Text = dt.Rows[0]["PostalCode"].ToString();
            txtAddress.Text = dt.Rows[0]["Address"].ToString();
            //销售订单表的信息
            dtpBillDate.Value = Convert.ToDateTime(dt.Rows[0]["BillDate"]);
            cbxGoodsTypeCode.SelectedValue = dt.Rows[0]["GoodsTypeCode"];
            cbxGoodsSeriesCode.SelectedValue = dt.Rows[0]["GoodsSeriesCode"];
            txtUnitPrice.Text = dt.Rows[0]["UnitPrice"].ToString();
            txtDiscount.Text = dt.Rows[0]["Discount"].ToString();
            txtQuantity.Text = dt.Rows[0]["Quantity"].ToString();
            txtSaleMoney.Text = GetSaleMoneyString();
            if (dt.Rows[0]["IsNeedInvoice"].ToString() == "1")  //需要发票
            {
                rbIsNeedInvoice1.Checked = true;
                if (dt.Rows[0]["WriteOffType"].ToString() == "1")  //个人
                {
                    chbWriteOffType1.Checked = true;
                    txtWriteOffName1.Text = dt.Rows[0]["WriteOffName"].ToString();
                    txtCertificateNumber1.Text = dt.Rows[0]["CertificateNumber"].ToString();
                }
                else  //单位
                {
                    chbWriteOffType2.Checked = true;
                    txtWriteOffName2.Text = dt.Rows[0]["WriteOffName"].ToString();
                    txtCertificateNumber2.Text = dt.Rows[0]["CertificateNumber"].ToString();
                }
            }
            else  //不需要发票
            {
                rbIsNeedInvoice0.Checked = true;
            }
            cbxEmployeeCode.SelectedValue = dt.Rows[0]["EmployeeCode"];
            if (dt.Rows[0]["SignDate"] == DBNull.Value)
            {
                dtpSignDate.Checked = false;
            }
            else
            {
                dtpSignDate.Value = Convert.ToDateTime(dt.Rows[0]["SignDate"]);
            }
            txtRemark.Text = dt.Rows[0]["Remark"].ToString();
        }

        private void SetTradeBillInfo(string strSaleBillNo)
        {
            string strSql = null;
            DataTable dt = null;
            RetailSaleTradeBill tstb = new RetailSaleTradeBill();
            strSql = "Select * From  SaleTradeBill Where SaleBillNo = '" + strSaleBillNo + "'";
            dt = tstb.GetDataTable(strSql);
            if (dt.Rows.Count > 0)
            {
                if (this.Tag.ToString() == "Add")
                {
                    SetTradeBillControlsState(false);
                }
                //赋值
                txtReceiptMoney.Text = dt.Rows[0]["ReceiptMoney"].ToString();
                txtTradeBillNo.Text = dt.Rows[0]["TradeBillNo"].ToString();
                if (dt.Rows[0]["SignDate1"] == DBNull.Value)
                {
                    dtpSignDate1.Checked = false;
                }
                else
                {
                    dtpSignDate1.Value = Convert.ToDateTime(dt.Rows[0]["SignDate1"]);
                }
                if (dt.Rows[0]["SignDate2"] == DBNull.Value)
                {
                    dtpSignDate2.Checked = false;
                }
                else
                {
                    dtpSignDate2.Value = Convert.ToDateTime(dt.Rows[0]["SignDate2"]);
                }
                if (dt.Rows[0]["SignDate3"] == DBNull.Value)
                {
                    dtpSignDate3.Checked = false;
                }
                else
                {
                    dtpSignDate3.Value = Convert.ToDateTime(dt.Rows[0]["SignDate3"]);
                }
                dtpSaleDate.Value = Convert.ToDateTime(dt.Rows[0]["SaleDate"]);
                cbxBankCode.SelectedValue = dt.Rows[0]["BankCode"];
                cbxPayTypeCode.SelectedValue = dt.Rows[0]["PayTypeCode"];
                cbxEmployeeCode1.SelectedValue = dt.Rows[0]["EmployeeCode1"];
                cbxEmployeeCode2.SelectedValue = dt.Rows[0]["EmployeeCode2"];
                cbxEmployeeCode3.SelectedValue = dt.Rows[0]["EmployeeCode3"];
                txtRemark1.Text = dt.Rows[0]["Remark1"].ToString();
            }
            else
            {
                SetTradeBillControlsState(true);
            }
        }

        private String GetSaleMoneyString()  //返回值为可空（既可以空，也可以不空）
        {
            Nullable<decimal> decSaleMoney = null;

            if (!String.IsNullOrEmpty(txtUnitPrice.Text.Trim()))
            {
                if (!String.IsNullOrEmpty(txtDiscount.Text.Trim()))
                {
                    if (!String.IsNullOrEmpty(txtQuantity.Text.Trim()))
                    {
                        decSaleMoney = Decimal.Round(Convert.ToDecimal(txtUnitPrice.Text.Trim()) * Convert.ToDecimal(txtDiscount.Text.Trim()) * Convert.ToInt32(txtQuantity.Text.Trim()), 2);
                    }
                }
            }
            if (decSaleMoney.HasValue)
            {
                return decSaleMoney.Value.ToString();
            }
            else
            {
                return null;
            }
        }

        private void FormRetailSaleTradeBillInput_Load(object sender, EventArgs e)
        {
            formRetailSaleTradeBill = (FormRetailSaleTradeBill)this.Owner;
            ControlBindDataSource cbds = new ControlBindDataSource();
            cbds.ComboBoxBindDataSource(cbxBankCode, "BankCode", "BankName", "Select * From Bank", "Bank");
            cbds.ComboBoxBindDataSource(cbxEmployeeCode, "EmployeeCode", "EmployeeName", "Select * From Employee", "Employee");
            cbds.ComboBoxBindDataSource(cbxEmployeeCode1, "EmployeeCode", "EmployeeName", "Select * From Employee", "Employee");
            cbds.ComboBoxBindDataSource(cbxEmployeeCode2, "EmployeeCode", "EmployeeName", "Select * From Employee", "Employee");
            cbds.ComboBoxBindDataSource(cbxEmployeeCode3, "EmployeeCode", "EmployeeName", "Select * From Employee", "Employee");
            cbds.ComboBoxBindDataSource(cbxGoodsSeriesCode, "GoodsSeriesCode", "GoodsSeriesName", "Select * From GoodsSeries", "GoodsSeries");
            cbds.ComboBoxBindDataSource(cbxGoodsTypeCode, "GoodsTypeCode", "GoodsTypeName", "Select * From GoodsType", "GoodsType");
            cbds.ComboBoxBindDataSource(cbxPayTypeCode, "PayTypeCode", "PayTypeName", "Select * From PayType", "PayType");
            InitOrderBillControls();
            InitTradeBillControls();
            if (this.Tag.ToString() == "Add")
            {
                this.Text = "添加单据";
            }
            if (this.Tag.ToString() == "Edit")
            {
                this.Text = "修改单据";
                txtSaleBillNo.Text = formRetailSaleTradeBill.dgvSaleTradeBill.CurrentRow.Cells["SaleBillNo"].Value.ToString();
                txtSaleBillNo.ReadOnly = true;
                btnBrowse.Enabled = false;
                SetOrderBillInfo(txtSaleBillNo.Text.Trim());
                SetTradeBillInfo(txtSaleBillNo.Text.Trim());  //是否可以取消检索交易单，直接赋值来提高速度
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FormBrowseRetailSaleOrderBill formBrowseRetailSaleOrderBill = new FormBrowseRetailSaleOrderBill();
            formBrowseRetailSaleOrderBill.Owner = this;
            formBrowseRetailSaleOrderBill.te += new FormBrowseRetailSaleOrderBill.TriggerEvent(TriggerKeyDown);
            formBrowseRetailSaleOrderBill.ShowDialog();
        }

        private void txtSaleBillNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                InitOrderBillControls();
                InitTradeBillControls();
                SetOrderBillInfo(txtSaleBillNo.Text.Trim());
                SetTradeBillInfo(txtSaleBillNo.Text.Trim());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            RetailSaleTradeBill rstb = new RetailSaleTradeBill();

            if (String.IsNullOrEmpty(txtCustomerName.Text.Trim()))
            {
                MessageBox.Show("销售订单信息不许为空！", "软件提示");
                txtSaleBillNo.Focus();
                return;
            }
            if (cbxPayTypeCode.SelectedValue == null)
            {
                MessageBox.Show("交易方式不许为空！", "软件提示");
                cbxPayTypeCode.Focus();
                return;
            }
            if (cbxPayTypeCode.SelectedValue.ToString() == "02") //银行存款
            {
                if (cbxBankCode.SelectedValue == null)
                {
                    MessageBox.Show("预存银行不许为空！", "软件提示");
                    cbxBankCode.Focus();
                    return;
                }
            }
            if (String.IsNullOrEmpty(txtTradeBillNo.Text.Trim()))
            {
                MessageBox.Show("交易单号不许为空！", "软件提示");
                txtTradeBillNo.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtReceiptMoney.Text.Trim()))
            {
                MessageBox.Show("实收金额不许为空！", "软件提示");
                txtReceiptMoney.Focus();
                return;
            }
            else
            {
                if (Convert.ToDecimal(txtReceiptMoney.Text.Trim()) == 0)
                {
                    MessageBox.Show("实收金额不许为零！", "软件提示");
                    txtReceiptMoney.Focus();
                    return;
                }
            }
            if (cbxEmployeeCode1.SelectedValue == null)
            {
                MessageBox.Show("查款人不许为空！", "软件提示");
                cbxEmployeeCode1.Focus();
                return;
            }
            if (this.Tag.ToString() == "Add")
            {
                DataGridViewRow dgvr = rstb.AddDataGridViewRow(formRetailSaleTradeBill.dgvSaleTradeBill, formRetailSaleTradeBill.bsSaleTradeBill);
                dgvr.Cells["SaleBillNo"].Value = txtSaleBillNo.Text.Trim();
                dgvr.Cells["PayTypeCode"].Value = cbxPayTypeCode.SelectedValue;
                dgvr.Cells["BankCode"].Value = cbxBankCode.SelectedValue;
                dgvr.Cells["SaleDate"].Value = dtpSaleDate.Value.Date;
                dgvr.Cells["TradeBillNo"].Value = txtTradeBillNo.Text.Trim();
                dgvr.Cells["ReceiptMoney"].Value = Convert.ToDecimal(txtReceiptMoney.Text.Trim());
                dgvr.Cells["EmployeeCode1"].Value = cbxEmployeeCode1.SelectedValue;
                if (dtpSignDate1.Checked == false)
                {
                    dgvr.Cells["SignDate1"].Value = DBNull.Value;
                }
                else
                {
                    dgvr.Cells["SignDate1"].Value = dtpSignDate1.Value.Date;
                }
                dgvr.Cells["EmployeeCode2"].Value = cbxEmployeeCode2.SelectedValue;
                if (dtpSignDate2.Checked == false)
                {
                    dgvr.Cells["SignDate2"].Value = DBNull.Value;
                }
                else
                {
                    dgvr.Cells["SignDate2"].Value = dtpSignDate2.Value.Date;
                }
                dgvr.Cells["EmployeeCode3"].Value = cbxEmployeeCode3.SelectedValue;
                if (dtpSignDate3.Checked == false)
                {
                    dgvr.Cells["SignDate3"].Value = DBNull.Value;
                }
                else
                {
                    dgvr.Cells["SignDate3"].Value = dtpSignDate3.Value.Date;
                }
                dgvr.Cells["Remark1"].Value = txtRemark1.Text.Trim();
                dgvr.Cells["OperatorCode"].Value = GlobalProperty.OperatorCode;
                dgvr.Cells["AppendDate"].Value = GlobalProperty.DBTime.Date;
                if (rstb.Insert(formRetailSaleTradeBill.bsSaleTradeBill))
                {
                    MessageBox.Show("保存成功！", "软件提示");
                    formRetailSaleTradeBill.bsSaleTradeBill.DataSource = rstb.GetDataTable("SaleTradeBill", "Where OperatorCode = '" + GlobalProperty.OperatorCode + "' and AppendDate = '" + GlobalProperty.DBTime.Date + "'");
                    formRetailSaleTradeBill.dgvSaleTradeBill.DataSource = formRetailSaleTradeBill.bsSaleTradeBill;
                    InitOrderBillControls();
                    InitTradeBillControls();
                    txtSaleBillNo.Text = "";
                }
                else
                {
                    MessageBox.Show("保存失败！", "软件提示");
                }
                
            }
            if(this.Tag.ToString() == "Edit")
            {
                DataGridViewRow dgvr = formRetailSaleTradeBill.dgvSaleTradeBill.CurrentRow;
                dgvr.Cells["PayTypeCode"].Value = cbxPayTypeCode.SelectedValue;
                dgvr.Cells["BankCode"].Value = cbxBankCode.SelectedValue;
                dgvr.Cells["SaleDate"].Value = dtpSaleDate.Value.Date;
                dgvr.Cells["TradeBillNo"].Value = txtTradeBillNo.Text.Trim();
                dgvr.Cells["ReceiptMoney"].Value = Convert.ToDecimal(txtReceiptMoney.Text.Trim());
                dgvr.Cells["EmployeeCode1"].Value = cbxEmployeeCode1.SelectedValue;
                if (dtpSignDate1.Checked == false)
                {
                    dgvr.Cells["SignDate1"].Value = DBNull.Value;
                }
                else
                {
                    dgvr.Cells["SignDate1"].Value = dtpSignDate1.Value.Date;
                }
                dgvr.Cells["EmployeeCode2"].Value = cbxEmployeeCode2.SelectedValue;
                if (dtpSignDate2.Checked == false)
                {
                    dgvr.Cells["SignDate2"].Value = DBNull.Value;
                }
                else
                {
                    dgvr.Cells["SignDate2"].Value = dtpSignDate2.Value.Date;
                }
                dgvr.Cells["EmployeeCode3"].Value = cbxEmployeeCode3.SelectedValue;
                if (dtpSignDate3.Checked == false)
                {
                    dgvr.Cells["SignDate3"].Value = DBNull.Value;
                }
                else
                {
                    dgvr.Cells["SignDate3"].Value = dtpSignDate3.Value.Date;
                }
                dgvr.Cells["Remark1"].Value = txtRemark1.Text.Trim();
                if (rstb.Update(formRetailSaleTradeBill.bsSaleTradeBill))
                {
                    MessageBox.Show("保存成功！", "软件提示");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("保存失败！", "软件提示");
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxPayTypeCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxPayTypeCode.SelectedValue != null)
            {
                if (cbxPayTypeCode.SelectedValue.ToString() == "02")  //表示银行汇款，固定的
                {
                    cbxBankCode.Enabled = true;
                }
                else
                {
                    cbxBankCode.Enabled = false;
                    cbxBankCode.SelectedIndex = -1;
                }
            }
        }

        private void txtSaleBillNo_TextChanged(object sender, EventArgs e)
        {
            InitOrderBillControls();
        }

        private void txtReceiptMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            new Useful().InputNumeric(e, txtReceiptMoney);
        }
    }
}
