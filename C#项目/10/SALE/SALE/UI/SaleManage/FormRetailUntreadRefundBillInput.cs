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
using SALE.DAL;

namespace SALE.UI.SaleManage
{
    public partial class FormRetailUntreadRefundBillInput : Form
    {
        Useful useful = new Useful();
        RetailUntreadRefundBill rurb = new RetailUntreadRefundBill();
        FormRetailUntreadRefundBill formRetailUntreadRefundBill = null;
        DataLogic dal = new DataLogic();

        public FormRetailUntreadRefundBillInput()
        {
            InitializeComponent();
        }

        private void SetParametersValue()
        {
            dal.Cmd.Parameters.Clear();
            dal.Cmd.Parameters.AddWithValue("@UntreadBillNo", txtUntreadBillNo.Text.Trim());
            dal.Cmd.Parameters.AddWithValue("@PayTypeCode", cbxPayTypeCode.SelectedValue);
            if (cbxTradeBankCode.SelectedValue==null)
            {
                dal.Cmd.Parameters.AddWithValue("@BankCode", DBNull.Value);
            }
            else
            {
                dal.Cmd.Parameters.AddWithValue("@BankCode", cbxTradeBankCode.SelectedValue);
            }
            dal.Cmd.Parameters.AddWithValue("@UntreadMoneyDate", dtpUntreadMoneyDate.Value.Date);
            dal.Cmd.Parameters.AddWithValue("@TradeBillNo", txtTradeBillNo.Text.Trim());
            dal.Cmd.Parameters.AddWithValue("@FactUntreadMoney", Convert.ToDecimal(txtFactUntreadMoney.Text.Trim()));            
            dal.Cmd.Parameters.AddWithValue("@EmployeeCode3", cbxEmployeeCode3.SelectedValue);
            if (dtpSignDate3.Checked)
            {
                dal.Cmd.Parameters.AddWithValue("@SignDate3", dtpSignDate3.Value.Date);
            }
            else
            {
                dal.Cmd.Parameters.AddWithValue("@SignDate3", DBNull.Value);
            }
            dal.Cmd.Parameters.AddWithValue("@Remark3", txtRemark3.Text.Trim());
            dal.Cmd.Parameters.AddWithValue("@OperatorCode", GlobalProperty.OperatorCode);
            dal.Cmd.Parameters.AddWithValue("@AppendDate", GlobalProperty.DBTime.Date);
        }

        private void RetrieveUntreadBaseBillInfo(string strUntreadBillNo)
        {
            RetailUntreadBaseBill rurb = new RetailUntreadBaseBill();
            String strSql = "Select UntreadBaseBill.*,SaleOrderBill.*,Customer.*    From UntreadBaseBill,SaleOrderBill,Customer ";
            strSql += "Where UntreadBaseBill.SaleBillNo = SaleOrderBill.SaleBillNo and UntreadBaseBill.CustomerId = Customer.CustomerId and UntreadBaseBill.UntreadBillNo = '" + strUntreadBillNo + "'";
            DataTable dt = rurb.GetDataTable(strSql);
            if (dt.Rows.Count > 0)
            {
                SetUntreadBaseBillInfo(dt.Rows[0]);
            }
            else
            {
                MessageBox.Show("该退货单不存在！", "软件提示");
                txtUntreadBillNo.Focus();
                return;
            }
        }

        public void SetUntreadBaseBillInfo(DataRow dr)
        {
            if (dr != null)
            {
                //零售用户的基本档案信息
                txtCustomerName.Text = dr["CustomerName"].ToString();  //来自Customer
                //intCustomerId = Convert.ToInt32(dr["CustomerId"]);  //得到用户的Id值
                txtPhoneNumber.Text = dr["PhoneNumber"].ToString();  //来自Customer
                //txtAddress.Text = dr["Address"].ToString();
                txtSaleBillNo.Text = dr["SaleBillNo"].ToString();  //来自退货单
                dtpSaleOrderBillDate.Value = Convert.ToDateTime(dr["BillDate"]);  //来自SaleOrderBill
                dtpUntreadBillDate.Value = Convert.ToDateTime(dr["UntreadBillDate"]); //来自UntreadBaseBill
                cbxGoodsTypeCode.SelectedValue = dr["GoodsTypeCode"];  //取自UntreadBaseBill
                cbxGoodsSeriesCode.SelectedValue = dr["GoodsSeriesCode"];  //取自UntreadBaseBill
                //设置退货单价
                txtUnitPrice.Text = dr["UnitPrice"].ToString();  //取自UntreadBaseBill，不取自SaleOrderBill
                //设置退货数量
                txtQuantity.Text = dr["Quantity"].ToString();  //取自UntreadBaseBill，不取自SaleOrderBill
                txtUntreadMoney.Text = GetUntreadMoneyString();
                txtFactUntreadMoney.Text = txtUntreadMoney.Text;
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
                if (dr["CustomerType"].ToString() == "2")
                {
                    cbxBankCode.Visible = true;
                    txtOpenAccBankName.Visible = false;
                }
                if (dr["CustomerType"].ToString() == "3")
                {
                    cbxBankCode.Visible = false;
                    txtOpenAccBankName.Visible = true;
                }
                //取自UntreadBaseBill
                if (cbxBankCode.Visible)
                {
                    cbxBankCode.SelectedValue = dr["BankCode"];  //个人银行代码
                }
                if (txtOpenAccBankName.Visible)
                {
                    txtOpenAccBankName.Text = dr["OpenAccBankName"].ToString();  //单位使用银行名称
                }
                txtAccountNumber.Text = dr["AccountNumber"].ToString();
                txtRemark1.Text = dr["Remark1"].ToString();
                cbxEmployeeCode1.SelectedValue = dr["EmployeeCode1"];
                if (Convert.IsDBNull(dr["SignDate1"]))
                {
                    dtpSignDate1.Checked = false;
                }
                else
                {
                    dtpSignDate1.Value = Convert.ToDateTime(dr["SignDate1"]);
                }
                //取自UntreadBaseBill
            }
        }

        public void GetUntreadGatherBillInfo(string strUntreadBillNo)
        {
            string strSql = "Select UntreadGatherBill.* From UntreadGatherBill Where UntreadBillNo = '" + strUntreadBillNo + "'";
            DataTable dt = rurb.GetDataTable(strSql);
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["IsComplete"].ToString() == "0")
                {
                    rbIsComplete0.Checked = true;
                }
                else
                {
                    rbIsComplete1.Checked = true;
                }
                if (dt.Rows[0]["IsReturnInvoice"].ToString() == "0")
                {
                    rbIsReturnInvoice0.Checked = true;
                }
                else
                {
                    rbIsReturnInvoice1.Checked = true;
                }
                if (dt.Rows[0]["IsShatter"].ToString() == "0")
                {
                    rbIsShatter0.Checked = true;
                }
                else
                {
                    rbIsShatter1.Checked = true;
                }
                txtRemark2.Text = dt.Rows[0]["Remark2"].ToString();
                cbxEmployeeCode2.SelectedValue = dt.Rows[0]["EmployeeCode2"];
                dtpSignDate2.Value = Convert.ToDateTime(dt.Rows[0]["SignDate2"]);
            }
        }

        public void GetUntreadRefundBillInfo(string strUntreadBillNo)
        {
            string strSql = "Select UntreadRefundBill.* From UntreadRefundBill Where UntreadBillNo = '" + strUntreadBillNo + "'";
            DataTable dt = rurb.GetDataTable(strSql);
            if (dt.Rows.Count > 0)
            {
                if (this.Tag.ToString() == "Add")
                {
                    useful.SetControlsState(groupBox9, false);
                    btnSave.Enabled = false;
                }
                cbxPayTypeCode.SelectedValue = dt.Rows[0]["PayTypeCode"];
                cbxTradeBankCode.SelectedValue = dt.Rows[0]["BankCode"];
                dtpUntreadMoneyDate.Value = Convert.ToDateTime(dt.Rows[0]["UntreadMoneyDate"]);
                txtTradeBillNo.Text = dt.Rows[0]["TradeBillNo"].ToString();
                txtFactUntreadMoney.Text = dt.Rows[0]["FactUntreadMoney"].ToString();
                cbxEmployeeCode3.SelectedValue = dt.Rows[0]["EmployeeCode3"].ToString();
                if (Convert.IsDBNull(dt.Rows[0]["SignDate3"]))
                {
                    dtpSignDate3.Checked = false;
                }
                else
                {
                    dtpSignDate3.Value = Convert.ToDateTime(dt.Rows[0]["SignDate3"]);
                }
                txtRemark3.Text = dt.Rows[0]["Remark3"].ToString();
            }
            else
            {
                useful.SetControlsState(groupBox9, true);
                btnSave.Enabled = true;
            }
        }

        private String GetUntreadMoneyString()  //返回值为可空（既可以空，也可以不空）
        {
            Nullable<decimal> decUntreadMoney = null;

            if (!String.IsNullOrEmpty(txtUnitPrice.Text.Trim()))
            {
                if (!String.IsNullOrEmpty(txtQuantity.Text.Trim()))
                {
                    decUntreadMoney = Decimal.Round(Convert.ToDecimal(txtUnitPrice.Text.Trim()) * Convert.ToInt32(txtQuantity.Text.Trim()), 2);
                }
            }
            if (decUntreadMoney.HasValue)
            {
                return decUntreadMoney.Value.ToString();
            }
            else
            {
                return null;
            }
        }

        private void FormRetailUntreadRefundBillInput_Load(object sender, EventArgs e)
        {
            formRetailUntreadRefundBill = (FormRetailUntreadRefundBill)this.Owner;
            ControlBindDataSource cbds = new ControlBindDataSource();
            cbds.BindDataSource(this);
            if (this.Tag.ToString() == "Add")
            {
                this.Text = "添加单据";
                useful.InitFormContros(this, null);
            }
            if (this.Tag.ToString() == "Edit")
            {
                this.Text = "修改单据";
                useful.SetControlsState(groupBox1, false);
                txtUntreadBillNo.Enabled = false;
                btnBrowse.Enabled = false;
                txtUntreadBillNo.Text = formRetailUntreadRefundBill.dgvUntreadRefundBill.CurrentRow.Cells["UntreadBillNo"].Value.ToString();
                RetrieveUntreadBaseBillInfo(txtUntreadBillNo.Text.Trim());
                GetUntreadGatherBillInfo(txtUntreadBillNo.Text.Trim());
                GetUntreadRefundBillInfo(txtUntreadBillNo.Text.Trim());
            }
        }

        private void txtUntreadBillNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RetrieveUntreadBaseBillInfo(txtUntreadBillNo.Text.Trim());
                GetUntreadGatherBillInfo(txtUntreadBillNo.Text.Trim());
                GetUntreadRefundBillInfo(txtUntreadBillNo.Text.Trim());
            }
        }

        private void txtUntreadBillNo_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtCustomerName.Text.Trim()))
            {
                useful.InitFormContros(groupBox1, null);
                useful.InitFormContros(groupBox3, null);
                useful.InitFormContros(groupBox9, null);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FormBrowseRetailUntreadBaseBillOther formBrowseRetailUntreadBaseBillOther = new FormBrowseRetailUntreadBaseBillOther();
            formBrowseRetailUntreadBaseBillOther.Owner = this;
            formBrowseRetailUntreadBaseBillOther.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string strSql = null;
            if (String.IsNullOrEmpty(txtUntreadBillNo.Text.Trim()))
            {
                MessageBox.Show("退货单号不许为空", "软件提示");
                txtUntreadBillNo.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtCustomerName.Text.Trim()))
            {
                MessageBox.Show("退货信息不许为空", "软件提示");
                txtUntreadBillNo.Focus();
                return;
            }
            if (cbxPayTypeCode.SelectedValue == null)
            {
                MessageBox.Show("交易方式不许为空", "软件提示");
                cbxPayTypeCode.Focus();
                return;
            }
            else
            {
                if (cbxPayTypeCode.SelectedValue.ToString() == "02")
                {
                    if (cbxTradeBankCode.SelectedValue == null)
                    {
                        MessageBox.Show("交易银行不许为空", "软件提示");
                        cbxTradeBankCode.Focus();
                        return;
                    }
                }
            }
            if (String.IsNullOrEmpty(txtTradeBillNo.Text.Trim()))
            {
                MessageBox.Show("交易单号不许为空！", "软件提示");
                txtTradeBillNo.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtFactUntreadMoney.Text.Trim()))
            {
                MessageBox.Show("实退金额不许为空！", "软件提示");
                txtFactUntreadMoney.Focus();
                return;
            }
            else
            {
                if (Convert.ToDecimal(txtFactUntreadMoney.Text.Trim()) == 0)
                {
                    MessageBox.Show("实退金额不许为零！", "软件提示");
                    txtFactUntreadMoney.Focus();
                    return;
                }
                if (Convert.ToDecimal(txtFactUntreadMoney.Text.Trim())  > Convert.ToDecimal(txtUntreadMoney.Text.Trim()))
                {
                    MessageBox.Show("实退金额不许大于应退金额", "软件提示");
                    txtFactUntreadMoney.Focus();
                    return;
                }
            }
            if (cbxEmployeeCode3.SelectedValue == null)
            {
                MessageBox.Show("退款人不许为空", "软件提示");
                cbxEmployeeCode3.Focus();
                return;
            }
            if (cbxEmployeeCode2.SelectedValue == null)
            {
                if (MessageBox.Show("收货信息为空，是否继续？", "软件提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                {
                    return;
                }
            }
            //用于检索与收货单相关的记录信息
            string strSqlRefoundBill = "Select Customer.CustomerName,Customer.Address,UntreadRefundBill.UntreadBillNo,UntreadBaseBill.GoodsTypeCode,";
            strSqlRefoundBill += "UntreadBaseBill.GoodsSeriesCode,UntreadBaseBill.UnitPrice,UntreadBaseBill.Quantity,UntreadBaseBill.UnitPrice * UntreadBaseBill.Quantity as UntreadMoney,";
            strSqlRefoundBill += "UntreadRefundBill.PayTypeCode,UntreadRefundBill.BankCode,UntreadRefundBill.UntreadMoneyDate,UntreadRefundBill.TradeBillNo,UntreadRefundBill.FactUntreadMoney,";
            strSqlRefoundBill += "UntreadRefundBill.EmployeeCode3,UntreadRefundBill.SignDate3,UntreadRefundBill.OperatorCode,UntreadRefundBill.AppendDate,UntreadRefundBill.Id ";
            strSqlRefoundBill += "From UntreadBaseBill,UntreadRefundBill,Customer Where UntreadRefundBill.UntreadBillNo = UntreadBaseBill.UntreadBillNo and UntreadBaseBill.CustomerId = Customer.CustomerId ";
            if (this.Tag.ToString() == "Add")
            {
                SetParametersValue();
                strSql = "INSERT INTO UntreadRefundBill(UntreadBillNo,PayTypeCode,BankCode,UntreadMoneyDate,TradeBillNo,FactUntreadMoney,EmployeeCode3,SignDate3,Remark3,OperatorCode,AppendDate) ";
                strSql += "VALUES(@UntreadBillNo,@PayTypeCode,@BankCode,@UntreadMoneyDate,@TradeBillNo,@FactUntreadMoney,@EmployeeCode3,@SignDate3,@Remark3,@OperatorCode,@AppendDate)";
                if (rurb.Insert(dal, strSql))
                {
                    MessageBox.Show("保存成功！", "软件提示");
                    useful.InitFormContros(this, null);
                    txtUntreadBillNo.Focus();
                    //检索本人当日录入的记录
                    strSqlRefoundBill += " and UntreadRefundBill.OperatorCode = '" + GlobalProperty.OperatorCode + "'" + " and UntreadRefundBill.AppendDate = '" + GlobalProperty.DBTime.Date + "'";
                    formRetailUntreadRefundBill.dgvUntreadRefundBill.DataSource = rurb.GetDataTable(strSqlRefoundBill);
                }
                else
                {
                    MessageBox.Show("保存失败！", "软件提示");
                }
            }
            if (this.Tag.ToString() == "Edit")
            {
                SetParametersValue();
                int intId = Convert.ToInt32(formRetailUntreadRefundBill.dgvUntreadRefundBill.CurrentRow.Cells["Id"].Value);
                strSql = "Update UntreadRefundBill Set PayTypeCode = @PayTypeCode,BankCode = @BankCode,UntreadMoneyDate = @UntreadMoneyDate,TradeBillNo = @TradeBillNo,FactUntreadMoney = @FactUntreadMoney,";
                strSql += "EmployeeCode3 = @EmployeeCode3,SignDate3 = @SignDate3,Remark3 = @Remark3 Where Id = " + intId;
                if (rurb.Update(dal, strSql))
                {
                    MessageBox.Show("保存成功！", "软件提示");
                    //修改成功之后，刷新被修改行
                    strSqlRefoundBill += "and UntreadRefundBill.Id = " + intId;
                    formRetailUntreadRefundBill.dgvUntreadRefundBill.DataSource = rurb.GetDataTable(strSqlRefoundBill);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("保存失败！", "软件提示");
                }
            }
        }

        private void cbxPayTypeCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxPayTypeCode.SelectedValue != null)
            {
                if (cbxPayTypeCode.SelectedValue.ToString() == "02")  //表示银行汇款，固定的
                {
                    cbxTradeBankCode.Enabled = true;
                }
                else
                {
                    cbxTradeBankCode.Enabled = false;
                    cbxTradeBankCode.SelectedIndex = -1;
                }
            }
        }

        private void txtFactUntreadMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            useful.InputNumeric(e, txtFactUntreadMoney);
        }
    }
}
