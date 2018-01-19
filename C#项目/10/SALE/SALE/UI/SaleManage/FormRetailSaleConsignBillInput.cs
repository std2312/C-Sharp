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
    public partial class FormRetailSaleConsignBillInput : Form
    {
        FormRetailSaleConsignBill formRetailSaleConsignBill = null;
        Useful useful = new Useful();

        public FormRetailSaleConsignBillInput()
        {
            InitializeComponent();
        }

        private int m_SaleConsignBillId;
        public int SaleConsignBillId
        {
            get 
            { 
                return m_SaleConsignBillId;
            }
        }

        //-------订单
        private void RetrieveOrderBillInfo(string strSaleBillNo)
        {
            string strSql = null;
            DataTable dt = null;
            RetailSaleOrderBill rsob = new RetailSaleOrderBill();
            strSql = "Select SaleOrderBill.*,Customer.* From SaleOrderBill,Customer Where SaleOrderBill.CustomerId = Customer.CustomerId and SaleBillNo = '" + strSaleBillNo + "'";
            dt = rsob.GetDataTable(strSql);
            if (dt.Rows.Count > 0)
            {
                SetOrderBillInfo(dt.Rows[0]);
            }
            else
            {
                MessageBox.Show("该销售单号不存在！", "软件提示");
                txtSaleBillNo.Focus();
                return;
            }
        }

        public void SetOrderBillInfo(DataRow dr)
        {
            if (dr != null)
            {
                //零售用户的基本档案信息
                txtCustomerName.Text = dr["CustomerName"].ToString();
                txtPhoneNumber.Text = dr["PhoneNumber"].ToString();
                txtPostalCode.Text = dr["PostalCode"].ToString();
                txtAddress.Text = dr["Address"].ToString();
                //销售订单表的信息
                dtpBillDate.Value = Convert.ToDateTime(dr["BillDate"]);
                cbxGoodsTypeCode.SelectedValue = dr["GoodsTypeCode"];
                cbxGoodsTypeCode1.SelectedValue = dr["GoodsTypeCode"];
                cbxGoodsSeriesCode.SelectedValue = dr["GoodsSeriesCode"];
                cbxGoodsSeriesCode1.SelectedValue = dr["GoodsSeriesCode"];
                txtUnitPrice.Text = dr["UnitPrice"].ToString();
                txtDiscount.Text = dr["Discount"].ToString();
                txtQuantity.Text = dr["Quantity"].ToString();
                txtSaleMoney.Text = GetSaleMoneyString();
                if (dr["IsNeedInvoice"].ToString() == "1")  //需要发票
                {
                    rbIsNeedInvoice1.Checked = true;
                    if (dr["WriteOffType"].ToString() == "1")  //个人
                    {
                        chbWriteOffType1.Checked = true;
                        txtWriteOffName1.Text = dr["WriteOffName"].ToString();
                        txtCertificateNumber1.Text = dr["CertificateNumber"].ToString();
                    }
                    else  //单位
                    {
                        chbWriteOffType2.Checked = true;
                        txtWriteOffName2.Text = dr["WriteOffName"].ToString();
                        txtCertificateNumber2.Text = dr["CertificateNumber"].ToString();
                    }
                }
                else  //不需要发票
                {
                    rbIsNeedInvoice0.Checked = true;
                    chbWriteOffType1.Checked = false;
                    chbWriteOffType2.Checked = false;
                }
                cbxEmployeeCode.SelectedValue = dr["EmployeeCode"];
                if (dr["SignDate"] == DBNull.Value)
                {
                    dtpSignDate.Checked = false;
                }
                else
                {
                    dtpSignDate.Value = Convert.ToDateTime(dr["SignDate"]);
                }
                txtRemark.Text = dr["Remark"].ToString();
            }
            else
            {
                MessageBox.Show("该销售单号不存在！", "软件提示");
                txtSaleBillNo.Focus();
                return;
            }
        }
        //-------订单

        //-------交易
        public void RetrieveTradeBillInfo(string strSaleBillNo)
        {
            string strSql = null;
            DataTable dt = null;
            RetailSaleTradeBill tstb = new RetailSaleTradeBill();
            strSql = "Select * From  SaleTradeBill Where SaleBillNo = '" + strSaleBillNo + "'";
            dt = tstb.GetDataTable(strSql);
            if (dt.Rows.Count > 0)
            {
                SetTradeBillInfo(dt.Rows[0]);
            }
            else
            {
                MessageBox.Show("该订单未录入交易单！", "软件提示");
                txtSaleBillNo.Focus();
                return;
            }
        }

        private void SetTradeBillInfo(DataRow dr)
        {
            if (dr != null)
            {
                //赋值
                txtReceiptMoney.Text = dr["ReceiptMoney"].ToString();
                txtTradeBillNo.Text = dr["TradeBillNo"].ToString();
                if (dr["SignDate1"] == DBNull.Value)
                {
                    dtpSignDate1.Checked = false;
                }
                else
                {
                    dtpSignDate1.Value = Convert.ToDateTime(dr["SignDate1"]);
                }
                if (dr["SignDate2"] == DBNull.Value)
                {
                    dtpSignDate2.Checked = false;
                }
                else
                {
                    dtpSignDate2.Value = Convert.ToDateTime(dr["SignDate2"]);
                }
                if (dr["SignDate3"] == DBNull.Value)
                {
                    dtpSignDate3.Checked = false;
                }
                else
                {
                    dtpSignDate3.Value = Convert.ToDateTime(dr["SignDate3"]);
                }
                dtpSaleDate.Value = Convert.ToDateTime(dr["SaleDate"]);
                cbxBankCode.SelectedValue = dr["BankCode"];
                cbxPayTypeCode.SelectedValue = dr["PayTypeCode"];
                cbxEmployeeCode1.SelectedValue = dr["EmployeeCode1"];
                cbxEmployeeCode2.SelectedValue = dr["EmployeeCode2"];
                cbxEmployeeCode3.SelectedValue = dr["EmployeeCode3"];
            }
        }
        //-------交易

        //-------发货
        public void RetrieveConsignBillInfo(string strSaleBillNo)
        {
            string strSql = null;
            DataTable dt = null;
            RetailSaleConsignBill rscb = new RetailSaleConsignBill();
            strSql = "Select * From  SaleConsignBill Where SaleBillNo = '" + strSaleBillNo + "'";
            dt = rscb.GetDataTable(strSql);
            if (dt.Rows.Count > 0)
            {
                useful.SetControlsState(gbConsign, false);
                SetConsignBillInfo(dt.Rows[0]);
                //赋值
            }
            else
            {
                useful.SetControlsState(gbConsign, true);
            }
        }

        private void SetConsignBillInfo(DataRow dr)
        {
            if (dr != null)
            {
                if (dr["IsComplete"].ToString() == "1")
                {
                    rbIsComplete1.Checked = true;
                }
                else
                {
                    rbIsComplete0.Checked = true;
                }
                cbxGoodsTypeCode1.SelectedValue = dr["GoodsTypeCode1"].ToString();
                cbxGoodsSeriesCode1.SelectedValue = dr["GoodsSeriesCode1"].ToString();
                dtpConsignDate.Value = Convert.ToDateTime(dr["ConsignDate"]);
                txtExpressBillNo.Text = dr["ExpressBillNo"].ToString();
                cbxConsignCorpCode.SelectedValue = dr["ConsignCorpCode"];
                cbxEmployeeCode4.SelectedValue = dr["EmployeeCode4"];
                dtpConsignDate.Value = Convert.ToDateTime(dr["ConsignDate"]);
                txtRemark1.Text = dr["Remark2"].ToString();
            }
        }
        //-------发货

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

        private void FormRetailSaleConsignBillInput_Load(object sender, EventArgs e)
        {
            formRetailSaleConsignBill = (FormRetailSaleConsignBill)this.Owner;
            ControlBindDataSource cbds = new ControlBindDataSource();
            //cbds.BindDataSource(gbOrder);
            //cbds.BindDataSource(gbTrade);
            //cbds.BindDataSource(gbConsign);
            cbds.BindDataSource(this);
            useful.InitFormContros(this,null);
            //useful.InitFormContros(gbOrder);
            //useful.InitFormContros(gbTrade);
            //useful.InitFormContros(gbConsign);
            if (this.Tag.ToString() == "Add")
            {
                this.Text = "添加单据";
                btnCD.Enabled = false;
            }
            if (this.Tag.ToString() == "Edit")
            {
                this.Text = "修改单据";
                m_SaleConsignBillId = Convert.ToInt32(formRetailSaleConsignBill.dgvSaleConsignBill.CurrentRow.Cells["Id"].Value);
                btnCD.Enabled = true;
                txtSaleBillNo.Text = formRetailSaleConsignBill.dgvSaleConsignBill.CurrentRow.Cells["SaleBillNo"].Value.ToString();
                txtSaleBillNo.ReadOnly = true;
                btnBrowse.Enabled = false;
                //检索并设置订货单信息
                RetrieveOrderBillInfo(txtSaleBillNo.Text.Trim());
                //检索并设置交易单信息
                RetrieveTradeBillInfo(txtSaleBillNo.Text.Trim());
                //设置发货单信息
                DataTable dt = formRetailSaleConsignBill.bsSaleConsignBill.DataSource as DataTable;
                Int32 intId =  Convert.ToInt32(formRetailSaleConsignBill.dgvSaleConsignBill.CurrentRow.Cells["Id"].Value);
                DataRow dr = dt.AsEnumerable().FirstOrDefault(itm => itm.Field<int>("Id") == intId);
                SetConsignBillInfo(dr);
            }
        }

        private void txtSaleBillNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                useful.InitFormContros(gbOrder,null);
                useful.InitFormContros(gbTrade,null);
                useful.InitFormContros(gbConsign,null);
                //useful.InitFormContros(this);
                RetrieveOrderBillInfo(txtSaleBillNo.Text.Trim());
                RetrieveTradeBillInfo(txtSaleBillNo.Text.Trim());
                RetrieveConsignBillInfo(txtSaleBillNo.Text.Trim());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            RetailSaleConsignBill rscb = new RetailSaleConsignBill();

            if (String.IsNullOrEmpty(txtCustomerName.Text.Trim()))
            {
                MessageBox.Show("销售订单信息不许为空！", "软件提示");
                txtSaleBillNo.Focus();
                return;
            }
            if (cbxPayTypeCode.SelectedValue == null)
            {
                MessageBox.Show("交易信息不许为空！", "软件提示");
                cbxPayTypeCode.Focus();
                return;
            }
            if (cbxGoodsTypeCode1.SelectedValue == null)
            {
                MessageBox.Show("实发种类不许为空！", "软件提示");
                cbxGoodsTypeCode1.Focus();
                return;
            }
            else
            {
                if (cbxGoodsTypeCode1.SelectedValue.ToString() != cbxGoodsTypeCode.SelectedValue.ToString())
                {
                    if (MessageBox.Show("实发种类不等于订购种类，是否继续", "软件提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                    {
                        cbxGoodsTypeCode1.Focus();
                        return;
                    }
                }
            }
            if (cbxGoodsSeriesCode1.SelectedValue == null)
            {
                MessageBox.Show("实发版本不许为空！", "软件提示");
                cbxGoodsSeriesCode1.Focus();
                return;
            }
            else
            {
                if (cbxGoodsSeriesCode1.SelectedValue.ToString() != cbxGoodsSeriesCode.SelectedValue.ToString())
                {
                    if (MessageBox.Show("实发版本不等于订购版本，是否继续", "软件提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                    {
                        cbxGoodsSeriesCode1.Focus();
                        return;
                    }
                }
            }
            if (String.IsNullOrEmpty(txtExpressBillNo.Text.Trim()))
            {
                MessageBox.Show("快递单号不许为空！", "软件提示");
                txtExpressBillNo.Focus();
                return;
            }
            if (cbxConsignCorpCode.SelectedValue == null)
            {
                MessageBox.Show("发货公司不许为空！", "软件提示");
                cbxConsignCorpCode.Focus();
                return;
            }
            if (cbxEmployeeCode4.SelectedValue == null)
            {
                MessageBox.Show("发货人不许为空！", "软件提示");
                cbxEmployeeCode4.Focus();
                return;
            }
            if (this.Tag.ToString() == "Add")
            {
                DataGridViewRow dgvr = rscb.AddDataGridViewRow(formRetailSaleConsignBill.dgvSaleConsignBill, formRetailSaleConsignBill.bsSaleConsignBill);
                dgvr.Cells["SaleBillNo"].Value = txtSaleBillNo.Text.Trim();
                if (rbIsComplete0.Checked)
                {
                    dgvr.Cells["IsComplete"].Value = "0";
                }
                else
                {
                    dgvr.Cells["IsComplete"].Value = "1";
                }
                dgvr.Cells["GoodsTypeCode1"].Value = cbxGoodsTypeCode1.SelectedValue;
                dgvr.Cells["GoodsSeriesCode1"].Value = cbxGoodsSeriesCode1.SelectedValue;
                dgvr.Cells["ConsignDate"].Value = dtpConsignDate.Value.Date;
                dgvr.Cells["ExpressBillNo"].Value = txtExpressBillNo.Text.Trim();
                dgvr.Cells["ConsignCorpCode"].Value = cbxConsignCorpCode.SelectedValue;
                dgvr.Cells["EmployeeCode4"].Value = cbxEmployeeCode4.SelectedValue;
                if (dtpSignDate4.Checked)
                {
                    dgvr.Cells["SignDate4"].Value = DBNull.Value;
                }
                else
                {
                    dgvr.Cells["SignDate4"].Value = dtpSignDate4.Value.Date;
                }
                dgvr.Cells["Remark2"].Value = txtRemark2.Text.Trim();
                dgvr.Cells["OperatorCode"].Value = GlobalProperty.OperatorCode;
                dgvr.Cells["AppendDate"].Value = GlobalProperty.DBTime.Date;
                if (rscb.Insert(formRetailSaleConsignBill.bsSaleConsignBill))
                {
                    if (MessageBox.Show("保存成功，是否录入光盘号？", "软件提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        m_SaleConsignBillId = rscb.GetMaxIdOfCurrentOperator(GlobalProperty.OperatorCode);
                        btnCD_Click(sender, e);
                    }
                    formRetailSaleConsignBill.bsSaleConsignBill.DataSource = rscb.GetDataTable("SaleConsignBill", "Where OperatorCode = '" + GlobalProperty.OperatorCode + "' and AppendDate = '" + GlobalProperty.DBTime.Date + "'");
                    formRetailSaleConsignBill.dgvSaleConsignBill.DataSource = formRetailSaleConsignBill.bsSaleConsignBill;
                    useful.InitFormContros(gbOrder,null);
                    useful.InitFormContros(gbConsign,null);
                    useful.InitFormContros(gbTrade,null);
                    txtSaleBillNo.Text = "";
                    txtSaleBillNo.Focus();
                }
                else
                {
                    MessageBox.Show("保存失败！", "软件提示");
                }
            }
            if (this.Tag.ToString() == "Edit")
            {
                DataGridViewRow dgvr = formRetailSaleConsignBill.dgvSaleConsignBill.CurrentRow;
                if (rbIsComplete0.Checked)
                {
                    dgvr.Cells["IsComplete"].Value = "0";
                }
                else
                {
                    dgvr.Cells["IsComplete"].Value = "1";
                }
                dgvr.Cells["GoodsTypeCode1"].Value = cbxGoodsTypeCode1.SelectedValue;
                dgvr.Cells["GoodsSeriesCode1"].Value = cbxGoodsSeriesCode1.SelectedValue;
                dgvr.Cells["ConsignDate"].Value = dtpConsignDate.Value.Date;
                dgvr.Cells["ExpressBillNo"].Value = txtExpressBillNo.Text.Trim();
                dgvr.Cells["ConsignCorpCode"].Value = cbxConsignCorpCode.SelectedValue;
                dgvr.Cells["EmployeeCode4"].Value = cbxEmployeeCode4.SelectedValue;
                if (dtpSignDate4.Checked)
                {
                    dgvr.Cells["SignDate4"].Value = DBNull.Value;
                }
                else
                {
                    dgvr.Cells["SignDate4"].Value = dtpSignDate4.Value.Date;
                }
                dgvr.Cells["Remark2"].Value = txtRemark2.Text.Trim();
                if (rscb.Update(formRetailSaleConsignBill.bsSaleConsignBill))
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

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FormBrowseRetailSaleOrderBill formBrowseRetailSaleOrderBill = new FormBrowseRetailSaleOrderBill();
            formBrowseRetailSaleOrderBill.Owner = this;
            formBrowseRetailSaleOrderBill.ShowDialog();
        }

        private void txtSaleBillNo_TextChanged(object sender, EventArgs e)
        {
            useful.InitFormContros(gbOrder,null);
            useful.InitFormContros(gbTrade,null);
            useful.InitFormContros(gbConsign,null);
            //useful.InitFormContros(this);
        }

        private void btnCD_Click(object sender, EventArgs e)
        {
            useful.ShowDialogForm(typeof(FormSaleCDRecord), "", this);
        }
    }
}
