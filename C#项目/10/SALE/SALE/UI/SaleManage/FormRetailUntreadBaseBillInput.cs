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
    public partial class FormRetailUntreadBaseBillInput : Form
    {
        FormRetailUntreadBaseBill formRetailUntreadBaseBill = null;
        int intSaleQuantity;
        int intCustomerId;
        Useful useful = new Useful();
        RetailUntreadBaseBill ubb = new RetailUntreadBaseBill();

        public FormRetailUntreadBaseBillInput()
        {
            InitializeComponent();
        }

        private string strUntreadBillNo;
        public string UntreadBillNo
        {
            get
            {
                return strUntreadBillNo; 
            }
        }

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
                intCustomerId = Convert.ToInt32(dr["CustomerId"]);  //得到用户的Id值
                txtPhoneNumber.Text = dr["PhoneNumber"].ToString();
                //txtAddress.Text = dr["Address"].ToString();
                //销售订单表的信息
                dtpSaleOrderBillDate.Value = Convert.ToDateTime(dr["BillDate"]);
                cbxGoodsTypeCode.SelectedValue = dr["GoodsTypeCode"];
                cbxGoodsSeriesCode.SelectedValue = dr["GoodsSeriesCode"];
                //设置退货单价的默认值
                txtUnitPrice.Text = Decimal.Round(Convert.ToDecimal(dr["UnitPrice"]) * Convert.ToDecimal(dr["Discount"]),2).ToString();
                //设置退货的数量
                txtQuantity.Text = dr["Quantity"].ToString();
                //得到销售量，退货量不许大于销售量
                this.intSaleQuantity = Convert.ToInt32(txtQuantity.Text);
                txtUntreadMoney.Text = GetUntreadMoneyString();
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
            }
            else
            {
                MessageBox.Show("该销售单号不存在！", "软件提示");
                txtSaleBillNo.Focus();
                return;
            }
        }

        public void GetUntreadBillInfo(string strSaleBillNo)
        {
            string strSql = null;
            DataTable dt = null;
            strSql = "Select UntreadBaseBill.* From UntreadBaseBill Where SaleBillNo = '" + strSaleBillNo + "'";
            dt = ubb.GetDataTable(strSql);
            if (dt.Rows.Count > 0)
            {
                if (this.Tag.ToString() == "Add")
                {
                    useful.SetControlsState(groupBox1, false);
                    txtSaleBillNo.ReadOnly = false;
                    txtSaleBillNo.Enabled = true;
                    btnSave.Enabled = false;
                }

                txtUnitPrice.Text = dt.Rows[0]["UnitPrice"].ToString();
                txtQuantity.Text = dt.Rows[0]["Quantity"].ToString();
                if (cbxBankCode.Visible)
                {
                    cbxBankCode.SelectedValue = dt.Rows[0]["BankCode"];  //个人银行代码
                }
                if (txtOpenAccBankName.Visible)
                {
                    txtOpenAccBankName.Text = dt.Rows[0]["OpenAccBankName"].ToString();  //单位使用银行名称
                }
                txtAccountNumber.Text = dt.Rows[0]["AccountNumber"].ToString();
                txtRemark1.Text = dt.Rows[0]["Remark1"].ToString();
                cbxEmployeeCode1.SelectedValue = dt.Rows[0]["EmployeeCode1"];
                if (Convert.IsDBNull(dt.Rows[0]["SignDate1"]))
                {
                    dtpSignDate1.Checked = false;
                }
                else
                {
                    dtpSignDate1.Value = Convert.ToDateTime(dt.Rows[0]["SignDate1"]);
                }

            }
            else
            {
                txtUnitPrice.ReadOnly = false;
                txtUnitPrice.Enabled = true;
                //
                txtQuantity.ReadOnly = false;
                txtQuantity.Enabled = true;
                //
                txtOpenAccBankName.ReadOnly = false;
                txtOpenAccBankName.Enabled = true;
                //
                txtAccountNumber.ReadOnly = false;
                txtAccountNumber.Enabled = true;
                //
                cbxEmployeeCode1.Enabled = true;
                dtpSignDate1.Enabled = true;
                dtpUntreadBillDate.Enabled = true;
                cbxBankCode.Enabled = true;
                //
                txtRemark1.ReadOnly = false;
                txtRemark1.Enabled = true;
                //
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

        private void FormRetailUntreadBaseBillInput_Load(object sender, EventArgs e)
        {
            ControlBindDataSource cbds = new ControlBindDataSource();
            cbds.BindDataSource(this);
            useful.InitFormContros(groupBox1,null);
            formRetailUntreadBaseBill = (FormRetailUntreadBaseBill)this.Owner;
            if (this.Tag.ToString() == "Add")
            {
                this.Text = "添加单据";
                btnCD.Enabled = false;
                txtUntreadBillNo.Text = useful.BuildCode("UntreadBaseBill", "Where OperatorCode = '" + GlobalProperty.OperatorCode + "'", "UntreadBillNo", "TH" + GlobalProperty.DBTime.Year.ToString(), 7);
            }
            if (this.Tag.ToString() == "Edit")
            {
                this.Text = "修改单据";
                btnCD.Enabled = true;
                //chbIsAmendBillNo.Enabled = false;
                txtSaleBillNo.Text = formRetailUntreadBaseBill.dgvUntreadBaseBill.CurrentRow.Cells["SaleBillNo"].Value.ToString();
                txtUntreadBillNo.Text = formRetailUntreadBaseBill.dgvUntreadBaseBill.CurrentRow.Cells["UntreadBillNo"].Value.ToString();
                RetrieveOrderBillInfo(txtSaleBillNo.Text.Trim());
                GetUntreadBillInfo(txtSaleBillNo.Text.Trim());
                txtSaleBillNo.ReadOnly = true;
                txtSaleBillNo.Enabled = false;
                btnBrowse.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtUntreadBillNo.Text.Trim().Length != 13)
            {
                MessageBox.Show("退货单号不正确！", "软件提示");
                txtUntreadBillNo.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtCustomerName.Text.Trim()))
            {
                MessageBox.Show("订单信息不许为空！", "软件提示");
                txtCustomerName.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtUnitPrice.Text.Trim()))
            {
                MessageBox.Show("单价不许为空！", "软件提示");
                txtUnitPrice.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtQuantity.Text.Trim()))
            {
                MessageBox.Show("数量不许为空！", "软件提示");
                txtQuantity.Focus();
                return;
            }
            else
            {
                if (Convert.ToInt32(txtQuantity.Text.Trim()) == 0)
                {
                    MessageBox.Show("数量不许为零！", "软件提示");
                    txtQuantity.Focus();
                    return;
                }
            }
            if (cbxEmployeeCode1.SelectedValue == null)
            {
                MessageBox.Show("下单人不许为空！", "软件提示");
                cbxEmployeeCode1.Focus();
                return;
            }

            //退货量不许大于销售量
            if (Convert.ToInt32(txtQuantity.Text.Trim()) > intSaleQuantity)
            {
                MessageBox.Show("退货量不许大于销售量！", "软件提示");
                txtQuantity.Focus();
                return;
            }
            if (this.Tag.ToString() == "Add")
            {
                if (ubb.IsExistUntreadBillNo(txtUntreadBillNo.Text.Trim()))  //若单据编号重复
                {
                    MessageBox.Show("该单号已存在,请重新输入单号！", "软件提示");
                    txtUntreadBillNo.Focus();
                    return;
                }
                DataGridViewRow dgvr = ubb.AddDataGridViewRow(formRetailUntreadBaseBill.dgvUntreadBaseBill, formRetailUntreadBaseBill.bsUntreadBaseBill);
                dgvr.Cells["UntreadBillNo"].Value = txtUntreadBillNo.Text.Trim();
                dgvr.Cells["UntreadBillDate"].Value = dtpUntreadBillDate.Value.Date;
                dgvr.Cells["SaleBillNo"].Value = txtSaleBillNo.Text.Trim();
                dgvr.Cells["CustomerId"].Value = this.intCustomerId;
                dgvr.Cells["GoodsTypeCode"].Value = cbxGoodsTypeCode.SelectedValue;
                dgvr.Cells["GoodsSeriesCode"].Value = cbxGoodsSeriesCode.SelectedValue;
                dgvr.Cells["UnitPrice"].Value = txtUnitPrice.Text.Trim();
                dgvr.Cells["Quantity"].Value = txtQuantity.Text.Trim();
                dgvr.Cells["BankCode"].Value = cbxBankCode.SelectedValue;
                dgvr.Cells["OpenAccBankName"].Value = txtOpenAccBankName.Text.Trim();
                dgvr.Cells["AccountNumber"].Value = txtAccountNumber.Text.Trim();
                dgvr.Cells["EmployeeCode1"].Value = cbxEmployeeCode1.SelectedValue;
                if (dtpSignDate1.Checked)
                {
                    dgvr.Cells["SignDate1"].Value = dtpSignDate1.Value.Date;
                }
                else
                {
                    dgvr.Cells["SignDate1"].Value = DBNull.Value;
                }
                dgvr.Cells["Remark1"].Value = txtRemark1.Text.Trim();
                dgvr.Cells["OperatorCode"].Value = GlobalProperty.OperatorCode;
                dgvr.Cells["AppendDate"].Value = GlobalProperty.DBTime.Date;
                if (ubb.Insert(formRetailUntreadBaseBill.bsUntreadBaseBill))
                {
                    if (MessageBox.Show("保存成功，是否录入光盘号？", "软件提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        btnCD_Click(sender, e);
                    }
                    useful.InitFormContros(groupBox1, null);
                    txtUntreadBillNo.Text = useful.BuildCode("UntreadBaseBill", "Where OperatorCode = '" + GlobalProperty.OperatorCode + "'", "UntreadBillNo", "TH" + GlobalProperty.DBTime.Year.ToString(), 7);
                }
                else
                {
                    MessageBox.Show("保存失败！", "软件提示");
                }
            }
            if (this.Tag.ToString() == "Edit")
            {
                string strOldUntreadBillNo = formRetailUntreadBaseBill.dgvUntreadBaseBill.CurrentRow.Cells["UntreadBillNo"].Value.ToString();
                if (txtUntreadBillNo.Text.Trim() != strOldUntreadBillNo)  //说明单据编号(即主键)发生了改变
                {
                    if (ubb.IsExistUntreadBillNo(txtUntreadBillNo.Text.Trim()))  //若单据编号重复
                    {
                        MessageBox.Show("该单号已存在,请重新输入单号！", "软件提示");
                        txtUntreadBillNo.Focus();
                        return;
                    }
                    if (useful.IsExistConstraint("UntreadBaseBill", strOldUntreadBillNo))  //该主键表对应的外键表存在外键记录
                    {
                        MessageBox.Show("已发生业务关系，不许修改单据号！", "软件提示");
                        txtUntreadBillNo.Focus();
                        return;
                    }
                }
                DataGridViewRow dgvr = formRetailUntreadBaseBill.dgvUntreadBaseBill.CurrentRow;
                dgvr.Cells["UntreadBillNo"].Value = txtUntreadBillNo.Text.Trim();
                dgvr.Cells["UntreadBillDate"].Value = dtpUntreadBillDate.Value.Date;
                //dgvr.Cells["SaleBillNo"].Value = txtSaleBillNo.Text.Trim();
                //dgvr.Cells["CustomerId"].Value = this.intCustomerId;
                //dgvr.Cells["GoodsTypeCode"].Value = cbxGoodsTypeCode.SelectedValue;
                //dgvr.Cells["GoodsSeriesCode"].Value = cbxGoodsSeriesCode.SelectedValue;
                dgvr.Cells["UnitPrice"].Value = txtUnitPrice.Text.Trim();
                dgvr.Cells["Quantity"].Value = txtQuantity.Text.Trim();
                dgvr.Cells["BankCode"].Value = cbxBankCode.SelectedValue;
                dgvr.Cells["OpenAccBankName"].Value = txtOpenAccBankName.Text.Trim();
                dgvr.Cells["AccountNumber"].Value = txtAccountNumber.Text.Trim();
                dgvr.Cells["EmployeeCode1"].Value = cbxEmployeeCode1.SelectedValue;
                if (dtpSignDate1.Checked)
                {
                    dgvr.Cells["SignDate1"].Value = dtpSignDate1.Value.Date;
                }
                else
                {
                    dgvr.Cells["SignDate1"].Value = DBNull.Value;
                }
                dgvr.Cells["Remark1"].Value = txtRemark1.Text.Trim();
                //dgvr.Cells["OperatorCode"].Value = GlobalProperty.OperatorCode;
                //dgvr.Cells["AppendDate"].Value = GlobalProperty.DBTime.Date;
                if (ubb.Update(formRetailUntreadBaseBill.bsUntreadBaseBill))
                {
                    MessageBox.Show("保存成功", "软件提示");
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

        private void txtSaleBillNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RetrieveOrderBillInfo(txtSaleBillNo.Text.Trim());
                GetUntreadBillInfo(txtSaleBillNo.Text.Trim());
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FormBrowseRetailSaleOrderBill formBrowseRetailSaleOrderBill = new FormBrowseRetailSaleOrderBill();
            formBrowseRetailSaleOrderBill.Owner = this;
            formBrowseRetailSaleOrderBill.ShowDialog();
        }

        private void txtUnitPrice_TextChanged(object sender, EventArgs e)
        {
            txtUntreadMoney.Text = GetUntreadMoneyString();
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            txtUntreadMoney.Text = GetUntreadMoneyString();
        }

        private void txtSaleBillNo_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtCustomerName.Text.Trim()))
            {
                List<Control> cons = new List<Control>();
                cons.Add(txtSaleBillNo);
                useful.InitFormContros(groupBox1, cons);
            }
        }

        private void chbIsAmendBillNoHeader_CheckedChanged(object sender, EventArgs e)
        {
            if (chbIsAmendBillNo.Checked)
            {
                txtUntreadBillNo.ReadOnly = false;
            }
            else
            {
                txtUntreadBillNo.ReadOnly = true;
            }
        }

        private void txtUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            useful.InputNumeric(e, txtUnitPrice);
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            useful.InputInteger(e);
        }

        private void btnCD_Click(object sender, EventArgs e)
        {
            if (this.Tag.ToString() == "Add")
            {
                strUntreadBillNo = txtUntreadBillNo.Text.Trim();
            }
            else
            {
                strUntreadBillNo = formRetailUntreadBaseBill.dgvUntreadBaseBill.CurrentRow.Cells["UntreadBillNo"].Value.ToString();
            }
            useful.ShowDialogForm(typeof(FormUntreadCDRecord), this.Tag.ToString(),this);
        }
    }
}
