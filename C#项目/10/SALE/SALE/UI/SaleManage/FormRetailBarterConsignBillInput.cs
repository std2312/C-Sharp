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
    public partial class FormRetailBarterConsignBillInput : Form
    {
        Useful useful = new Useful();
        RetailBarterConsignBill rbcb = new RetailBarterConsignBill();
        FormRetailBarterConsignBill formRetailBarterConsignBill = null;
        DataLogic dal = new DataLogic();

        public FormRetailBarterConsignBillInput()
        {
            InitializeComponent();
        }

        private int m_BaterConsignBillId;
        public int BaterConsignBillId
        {
            get
            {
                return m_BaterConsignBillId;
            }
        }

        private void SetParametersValue()
        {
            dal.Cmd.Parameters.Clear();
            dal.Cmd.Parameters.AddWithValue("@BarterBillNo", txtBarterBillNo.Text.Trim());
            if (rbIsComplete0.Checked)
            {
                dal.Cmd.Parameters.AddWithValue("@IsComplete", "0");
            }
            else
            {
                dal.Cmd.Parameters.AddWithValue("@IsComplete", "1");
            }
            dal.Cmd.Parameters.AddWithValue("@GoodsTypeCode", cbxGoodsTypeCode2.SelectedValue);
            dal.Cmd.Parameters.AddWithValue("@GoodsSeriesCode", cbxGoodsSeriesCode2.SelectedValue);
            dal.Cmd.Parameters.AddWithValue("@ConsignDate", dtpConsignDate.Value.Date);
            dal.Cmd.Parameters.AddWithValue("@ExpressBillNo", txtExpressBillNo.Text.Trim());
            dal.Cmd.Parameters.AddWithValue("@ConsignCorpCode", cbxConsignCorpCode.SelectedValue);
            dal.Cmd.Parameters.AddWithValue("@Remark3", txtRemark3.Text.Trim());
            dal.Cmd.Parameters.AddWithValue("@EmployeeCode3", cbxEmployeeCode3.SelectedValue);
            if (dtpSignDate3.Checked)
            {
                dal.Cmd.Parameters.AddWithValue("@SignDate3", dtpSignDate3.Value.Date);
            }
            else
            {
                dal.Cmd.Parameters.AddWithValue("@SignDate3", DBNull.Value);
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
                txtTradeMoney.Text = txtTotalBanlance.Text;  //默认情况下交易额等于总差额
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

        public void GetBarterExchangeInfo(string strBarterBillNo)
        {
            string strSql = null;
            DataTable dt = null;
            strSql = "Select BarterExchangeBill.* From BarterExchangeBill Where BarterBillNo = '" + strBarterBillNo + "'";
            dt = rbcb.GetDataTable(strSql);
            if (dt.Rows.Count > 0)
            {
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
        }

        private void GetBarterConsignInfo(string strBarterBillNo)
        {
            string strSql = null;
            DataTable dt = null;
            strSql = "Select BarterConsignBill.* From BarterConsignBill Where BarterBillNo = '" + strBarterBillNo + "'";
            dt = rbcb.GetDataTable(strSql);
            if (dt.Rows.Count > 0)
            {
                if (this.Tag.ToString() == "Add")
                {
                    useful.SetControlsState(groupBox9, false);
                    btnSave.Enabled = false;
                }
                if (dt.Rows[0]["IsComplete"].ToString() == "0")
                {
                    rbIsComplete0.Checked = true;
                }
                else
                {
                    rbIsComplete1.Checked = true;
                }
                cbxGoodsTypeCode2.SelectedValue = dt.Rows[0]["GoodsTypeCode"]; //实发种类
                cbxGoodsSeriesCode2.SelectedValue = dt.Rows[0]["GoodsSeriesCode"]; //实发版本
                dtpConsignDate.Value = Convert.ToDateTime(dt.Rows[0]["ConsignDate"]);  //发货日期
                txtExpressBillNo.Text = dt.Rows[0]["ExpressBillNo"].ToString();  //快递单号
                cbxConsignCorpCode.SelectedValue = dt.Rows[0]["ConsignCorpCode"]; //发货公司
                cbxEmployeeCode3.SelectedValue = dt.Rows[0]["EmployeeCode3"]; //签发人
                if (dt.Rows[0]["SignDate3"] == DBNull.Value)  //签字日期可以为空
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

        private void FormRetailBarterConsignBill_Load(object sender, EventArgs e)
        {
            formRetailBarterConsignBill = (FormRetailBarterConsignBill)this.Owner;
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
                m_BaterConsignBillId = Convert.ToInt32(formRetailBarterConsignBill.dgvBarterConsignBill.CurrentRow.Cells["Id"].Value);
                txtBarterBillNo.Text = formRetailBarterConsignBill.dgvBarterConsignBill.CurrentRow.Cells["BarterBillNo"].Value.ToString();
                RetrieveBarterBaseInfo(txtBarterBillNo.Text);
                GetBarterExchangeInfo(txtBarterBillNo.Text);
                GetBarterConsignInfo(txtBarterBillNo.Text);
                txtBarterBillNo.Enabled = false;
                btnBrowse.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string strSql = null;
            string strBarterConsignBillSql = null;
            if (String.IsNullOrEmpty(txtCustomerName.Text.Trim()))
            {
                MessageBox.Show("换货信息不许为空！", "软件提示");
                txtBarterBillNo.Focus();
                return;
            }
            if (cbxGoodsTypeCode2.SelectedValue == null)  //实发种类
            {
                MessageBox.Show("发货种类不许为空！", "软件提示");
                cbxGoodsTypeCode2.Focus();
                return;
            }
            if (cbxGoodsSeriesCode2.SelectedValue == null)  //实发版本
            {
                MessageBox.Show("发货版本不许为空！", "软件提示");
                cbxGoodsSeriesCode2.Focus();
                return;
            }
            if (cbxConsignCorpCode.SelectedValue == null)
            {
                MessageBox.Show("发货公司不许为空！", "软件提示");
                cbxConsignCorpCode.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtExpressBillNo.Text.Trim()))
            {
                MessageBox.Show("快递单号不许为空！", "软件提示");
                txtExpressBillNo.Focus();
                return;
            }
            if (cbxEmployeeCode3.SelectedValue == null)
            {
                MessageBox.Show("发货人不许为空！", "软件提示");
                cbxEmployeeCode3.Focus();
                return;
            }
            if (cbxPayTypeCode.SelectedValue == null)
            {
                if (MessageBox.Show("调款信息为空，是否继续？", "软件提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                {
                    txtBarterBillNo.Focus();
                    return;
                }
            }
            if (this.Tag.ToString() == "Add")
            {
                SetParametersValue();
                strSql = "INSERT INTO BarterConsignBill(BarterBillNo,IsComplete,GoodsTypeCode,GoodsSeriesCode,ConsignDate,ExpressBillNo,ConsignCorpCode,EmployeeCode3,SignDate3,Remark3,OperatorCode,AppendDate) ";
                strSql += "VALUES(@BarterBillNo,@IsComplete,@GoodsTypeCode,@GoodsSeriesCode,@ConsignDate,@ExpressBillNo,@ConsignCorpCode,@EmployeeCode3,@SignDate3,@Remark3,@OperatorCode,@AppendDate)";
                if (rbcb.Insert(dal, strSql))
                {
                    if (MessageBox.Show("保存成功，是否录入光盘号？", "软件提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        m_BaterConsignBillId = rbcb.GetMaxIdOfCurrentOperator(GlobalProperty.OperatorCode);
                        btnCD_Click(sender, e);
                    }
                    useful.InitFormContros(this, null);
                    rbIsComplete1.Checked = true;
                    txtBarterBillNo.Focus();
                    strBarterConsignBillSql = rbcb.BarterConsignBillSql + " and BarterConsignBill.OperatorCode = '"
                        + GlobalProperty.OperatorCode + "'" + " and BarterConsignBill.AppendDate = '" + GlobalProperty.DBTime.Date + "'";
                    formRetailBarterConsignBill.dgvBarterConsignBill.DataSource = rbcb.GetDataTable(strBarterConsignBillSql);
                }
                else
                {
                    MessageBox.Show("保存失败！", "软件提示");
                }
            }
            if (this.Tag.ToString() == "Edit")
            {
                int intId = Convert.ToInt32(formRetailBarterConsignBill.dgvBarterConsignBill.CurrentRow.Cells["id"].Value);
                SetParametersValue();
                strSql = "Update BarterConsignBill Set BarterBillNo=@BarterBillNo,IsComplete=@IsComplete,GoodsTypeCode=@GoodsTypeCode,GoodsSeriesCode=@GoodsSeriesCode,ConsignDate=@ConsignDate,ExpressBillNo=@ExpressBillNo,"
                    + "ConsignCorpCode=@ConsignCorpCode,Remark3=@Remark3,EmployeeCode3=@EmployeeCode3,SignDate3=@SignDate3,OperatorCode=@OperatorCode,AppendDate=@AppendDate Where Id = " + intId;
                if (rbcb.Update(dal, strSql))
                {
                    MessageBox.Show("保存成功！", "软件提示");
                    strBarterConsignBillSql = rbcb.BarterConsignBillSql + " and  Id = " + intId;
                    formRetailBarterConsignBill.dgvBarterConsignBill.DataSource = rbcb.GetDataTable(strBarterConsignBillSql);
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

        private void txtBarterBillNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RetrieveBarterBaseInfo(txtBarterBillNo.Text.Trim());
                GetBarterExchangeInfo(txtBarterBillNo.Text.Trim());
                GetBarterConsignInfo(txtBarterBillNo.Text.Trim());
            }
        }

        private void txtBarterBillNo_TextChanged(object sender, EventArgs e)
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
            FormBrowseRetailBarterBaseBillOther formBrowseRetailBarterBaseBillOther = new FormBrowseRetailBarterBaseBillOther();
            formBrowseRetailBarterBaseBillOther.Owner = this;
            formBrowseRetailBarterBaseBillOther.ShowDialog();
        }

        private void btnCD_Click(object sender, EventArgs e)
        {
            useful.ShowDialogForm(typeof(FormBarterConsignCDRecord), this.Tag.ToString(), this);
        }
    }
}
