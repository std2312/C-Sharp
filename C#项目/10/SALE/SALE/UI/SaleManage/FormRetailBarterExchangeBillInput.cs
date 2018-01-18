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
    public partial class FormRetailBarterExchangeBillInput : Form
    {
        Useful useful = new Useful();
        RetailBarterExchangeBill rbeb = new RetailBarterExchangeBill();
        FormRetailBarterExchangeBill formRetailBarterExchangeBill = null;
        DataLogic dal = new DataLogic();

        public FormRetailBarterExchangeBillInput()
        {
            InitializeComponent();
        }

        private void SetParametersValue()
        {
            dal.Cmd.Parameters.Clear();
            dal.Cmd.Parameters.AddWithValue("@BarterBillNo",txtBarterBillNo.Text.Trim());
            dal.Cmd.Parameters.AddWithValue("@PayTypeCode",cbxPayTypeCode.SelectedValue);
            dal.Cmd.Parameters.AddWithValue("@TradeMoney",Convert.ToDecimal(txtTradeMoney.Text.Trim()));
            if(cbxBankCode.SelectedValue == null)
            {
                dal.Cmd.Parameters.AddWithValue("@BankCode",DBNull.Value);
            }
            else
            {
                dal.Cmd.Parameters.AddWithValue("@BankCode",cbxBankCode.SelectedValue);
            }
            dal.Cmd.Parameters.AddWithValue("@TradeBillNo",txtTradeBillNo.Text.Trim());
            dal.Cmd.Parameters.AddWithValue("@TradeDate", dtpTradeDate.Value.Date);
            dal.Cmd.Parameters.AddWithValue("@EmployeeCode2", cbxEmployeeCode2.SelectedValue);
            if (dtpSignDate2.Checked)
            {
                dal.Cmd.Parameters.AddWithValue("@SignDate2", dtpSignDate2.Value.Date);
            }
            else
            {
                dal.Cmd.Parameters.AddWithValue("@SignDate2", DBNull.Value);
            }
            dal.Cmd.Parameters.AddWithValue("@OperatorCode", GlobalProperty.OperatorCode);
            dal.Cmd.Parameters.AddWithValue("@AppendDate", GlobalProperty.DBTime.Date);
        }

        private void RetrieveBarterBaseInfo(string strBarterBillNo)
        {
            string strSql = null;
            DataTable dt = null;
            RetailBarterBaseBill rbbb = new RetailBarterBaseBill();
            strSql = "Select BarterBaseBill.*,Customer.* From BarterBaseBill,Customer Where BarterBaseBill.CustomerId = Customer.CustomerId and BarterBillNo = '" + strBarterBillNo + "'";
            dt = rbbb.GetDataTable(strSql);
            if (dt.Rows.Count > 0)
            {
                SetBarterBaseInfo(dt.Rows[0]);
            }
            else
            {
                MessageBox.Show("该调货单号不存在！", "软件提示");
                txtBarterBillNo.Focus();
                return;
            }
        }

        public void SetBarterBaseInfo(DataRow dr)
        {
            if (dr != null)
            {
                txtBarterBillNo.Text = dr["BarterBillNo"].ToString();
                txtSaleBillNo.Text = dr["SaleBillNo"].ToString();
                txtCustomerName.Text = dr["CustomerName"].ToString();
                //this.intCustomerId = Convert.ToInt32(dr["CustomerId"]);
                cbxBarterType.SelectedValue = dr["BarterType"];
                dtpBarterBillDate.Value = Convert.ToDateTime(dr["BarterBillDate"]);
                cbxGoodsTypeCode.SelectedValue = dr["GoodsTypeCode"];
                cbxGoodsSeriesCode.SelectedValue = dr["GoodsSeriesCode"];
                txtUnitPrice.Text = dr["UnitPrice"].ToString();
                cbxGoodsTypeCode1.SelectedValue = dr["GoodsTypeCode1"];
                cbxGoodsSeriesCode1.SelectedValue = dr["GoodsSeriesCode1"];
                txtUnitPrice1.Text = dr["UnitPrice1"].ToString();
                txtBarterQuantity.Text = dr["BarterQuantity"].ToString();
                txtTotalBanlance.Text = GetTotalBanlanceString();
                txtTradeMoney.Text = txtTotalBanlance.Text; //默认情况下交易额等于总差额
                txtPhoneNumber.Text = dr["PhoneNumber"].ToString();
                if (dr["IsNeedInvoice"].ToString() == "0")
                {
                    rbIsNeedInvoice0.Checked = true;
                }
                else
                {
                    rbIsNeedInvoice1.Checked = true;
                }
                txtAddress.Text = dr["Address"].ToString();
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
            }
        }

        private void GetBarterExchangeInfo(string strBarterBillNo)
        {
            string strSql = null;
            DataTable dt = null;
            strSql = "Select BarterExchangeBill.* From BarterExchangeBill Where BarterBillNo = '" + strBarterBillNo + "'";
            dt = rbeb.GetDataTable(strSql);
            if (dt.Rows.Count > 0)
            {
                if (this.Tag.ToString() == "Add")  //每个换货单[号]只允许存在一个调款单[号]
                {
                    useful.SetControlsState(groupBox3, false);
                    btnSave.Enabled = false;
                }
                cbxPayTypeCode.SelectedValue = dt.Rows[0]["PayTypeCode"];
                txtTradeMoney.Text = dt.Rows[0]["TradeMoney"].ToString();
                cbxBankCode.SelectedValue = dt.Rows[0]["BankCode"];
                txtTradeBillNo.Text = dt.Rows[0]["TradeBillNo"].ToString();
                dtpTradeDate.Value = Convert.ToDateTime(dt.Rows[0]["TradeDate"]);  //交易日期不许为空！
                cbxEmployeeCode2.SelectedValue = dt.Rows[0]["EmployeeCode2"];
                if (dt.Rows[0]["SignDate2"] == DBNull.Value)  //签字日期可以为空
                {
                    dtpSignDate2.Checked = false;
                }
                else
                {
                    dtpSignDate2.Value = Convert.ToDateTime(dt.Rows[0]["SignDate2"]);
                }                
            }
            else
            {
                useful.SetControlsState(groupBox3, true);
                btnSave.Enabled = true;
            }
        }

        private String GetTotalBanlanceString()  //返回值为可空（既可以空，也可以不空）
        {
            Nullable<decimal> decTotalBanlanceMoney = null;

            if (!String.IsNullOrEmpty(txtUnitPrice.Text.Trim()))
            {
                if (!String.IsNullOrEmpty(txtUnitPrice1.Text.Trim()))
                {
                    if (!String.IsNullOrEmpty(txtBarterQuantity.Text.Trim()))
                    {
                        decTotalBanlanceMoney = Decimal.Round((Convert.ToDecimal(txtUnitPrice1.Text.Trim()) - Convert.ToDecimal(txtUnitPrice.Text.Trim())) * Convert.ToInt32(txtBarterQuantity.Text.Trim()), 2);
                    }
                }
            }
            if (decTotalBanlanceMoney.HasValue)
            {
                return decTotalBanlanceMoney.Value.ToString();
            }
            else
            {
                return null;
            }
        }

        private void FormRetailBarterExchangeBillInput_Load(object sender, EventArgs e)
        {
            formRetailBarterExchangeBill = (FormRetailBarterExchangeBill)this.Owner;
            ControlBindDataSource cbds = new ControlBindDataSource();
            cbds.BindDataSource(this);
            useful.InitFormContros(this, null);
            if (this.Tag.ToString() == "Add")
            {
                this.Text = "添加单据";
            }
            if (this.Tag.ToString() == "Edit")
            {
                this.Text = "修改单据";
                txtBarterBillNo.Text = formRetailBarterExchangeBill.dgvBarterExchangeBill.CurrentRow.Cells["BarterBillNo"].Value.ToString();
                RetrieveBarterBaseInfo(txtBarterBillNo.Text);
                GetBarterExchangeInfo(txtBarterBillNo.Text);
                txtBarterBillNo.Enabled = false;
                btnBrowse.Enabled = false;
            }
        }

        private void txtBarterBillNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RetrieveBarterBaseInfo(txtBarterBillNo.Text.Trim());
                GetBarterExchangeInfo(txtBarterBillNo.Text.Trim());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string strSql = null;
            string strBarterExchangeBillSql = null;
            if (String.IsNullOrEmpty(txtBarterBillNo.Text.Trim()))
            {
                MessageBox.Show("调货单号不许为空", "软件提示");
                txtBarterBillNo.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtCustomerName.Text.Trim()))
            {
                MessageBox.Show("换货信息不许为空", "软件提示");
                txtCustomerName.Focus();
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
                    if (cbxBankCode.SelectedValue == null)
                    {
                        MessageBox.Show("交易银行不许为空", "软件提示");
                        cbxBankCode.Focus();
                        return;
                    }
                }
            }
            if (String.IsNullOrEmpty(txtTradeMoney.Text.Trim()))
            {
                MessageBox.Show("交易额不许为空！", "软件提示");
                txtTradeMoney.Focus();
                return;
            }
            else
            {
                if (Convert.ToDecimal(txtTradeMoney.Text.Trim()) == 0)
                {
                    MessageBox.Show("交易额不许为零！", "软件提示");
                    txtTradeMoney.Focus();
                    return;
                }
                //如何控制交易金额与总差额的关系？？？
                //如何控制交易金额与总差额的关系？？？
                //如何控制交易金额与总差额的关系？？？
            }
            if (String.IsNullOrEmpty(txtTradeBillNo.Text.Trim()))
            {
                MessageBox.Show("交易单号不许为空！", "软件提示");
                txtTradeBillNo.Focus();
                return;
            }
            if (cbxEmployeeCode2.SelectedValue == null)
            {
                MessageBox.Show("调款人不许为空", "软件提示");
                cbxEmployeeCode2.Focus();
                return;
            }
            if (this.Tag.ToString() == "Add")
            {
                SetParametersValue();
                strSql = "INSERT INTO BarterExchangeBill(BarterBillNo,PayTypeCode,TradeMoney,BankCode,TradeBillNo,TradeDate,EmployeeCode2,SignDate2,OperatorCode,AppendDate) ";
                strSql += "VALUES(@BarterBillNo,@PayTypeCode,@TradeMoney,@BankCode,@TradeBillNo,@TradeDate,@EmployeeCode2,@SignDate2,@OperatorCode,@AppendDate)";
                if (rbeb.Insert(dal, strSql))
                {
                    MessageBox.Show("保存成功！", "软件提示");
                    useful.InitFormContros(this, null);
                    rbIsNeedInvoice0.Checked = true;
                    txtBarterBillNo.Focus();
                    strBarterExchangeBillSql = rbeb.BarterExchangeBillSql + " and BarterExchangeBill.OperatorCode = '" 
                        + GlobalProperty.OperatorCode + "'" + " and BarterExchangeBill.AppendDate = '" + GlobalProperty.DBTime.Date + "'";
                    formRetailBarterExchangeBill.dgvBarterExchangeBill.DataSource = rbeb.GetDataTable(strBarterExchangeBillSql);
                }
                else
                {
                    MessageBox.Show("保存失败！", "软件提示");
                }
            }
            if (this.Tag.ToString() == "Edit")
            {
                int intId;
                intId = Convert.ToInt32(formRetailBarterExchangeBill.dgvBarterExchangeBill.CurrentRow.Cells["Id"].Value);
                SetParametersValue();
                strSql = "Update BarterExchangeBill Set BarterBillNo=@BarterBillNo,PayTypeCode = @PayTypeCode,TradeMoney = @TradeMoney,BankCode = @BankCode,TradeBillNo = @TradeBillNo,"
                    + "TradeDate = @TradeDate,EmployeeCode2 = @EmployeeCode2,SignDate2 = @SignDate2  Where Id = " + intId;
                if (rbeb.Update(dal, strSql))
                {
                    MessageBox.Show("保存成功！", "软件提示");
                    strBarterExchangeBillSql = rbeb.BarterExchangeBillSql + " and Id = " + intId;
                    formRetailBarterExchangeBill.dgvBarterExchangeBill.DataSource = rbeb.GetDataTable(strBarterExchangeBillSql);
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

        private void txtBarterBillNo_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtCustomerName.Text.Trim()))
            {
                useful.InitFormContros(groupBox1, null);
                useful.InitFormContros(groupBox3, null);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FormBrowseRetailBarterBaseBillOther formBrowseRetailBarterBaseBillOther = new FormBrowseRetailBarterBaseBillOther();
            formBrowseRetailBarterBaseBillOther.Owner = this;
            formBrowseRetailBarterBaseBillOther.ShowDialog();
        }

        private void txtTradeMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            useful.InputNumeric(e, txtTradeMoney);
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
    }
}
