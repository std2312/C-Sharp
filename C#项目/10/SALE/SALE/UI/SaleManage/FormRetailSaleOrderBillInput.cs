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
using SALE.DAL;

namespace SALE.UI.SaleManage
{
    public partial class FormRetailSaleOrderBillInput : Form
    {
        FormRetailSaleOrderBill formRetailSaleOrderBill = new FormRetailSaleOrderBill();
        RetailSaleOrderBill rsob = new RetailSaleOrderBill();
        Useful useful = new Useful();
        DataLogic dal = new DataLogic();

        public FormRetailSaleOrderBillInput()
        {
            InitializeComponent();
        }

        private void FormRetailSaleOrderBillInput_Load(object sender, EventArgs e)
        {
            ControlBindDataSource cbds = new ControlBindDataSource();
            cbds.ComboBoxBindDataSource(cbxGoodsTypeCode, "GoodsTypeCode", "GoodsTypeName", "Select * From GoodsType", "GoodsType");
            cbds.ComboBoxBindDataSource(cbxGoodsSeriesCode, "GoodsSeriesCode", "GoodsSeriesName", "Select * From GoodsSeries", "GoodsSeries");
            cbds.ComboBoxBindDataSource(cbxEmployeeCode, "EmployeeCode", "EmployeeName", "Select * From Employee", "Employee");
            formRetailSaleOrderBill = (FormRetailSaleOrderBill)this.Owner;
            if (formRetailSaleOrderBill.chbIsAgent.Checked)
            {
                txtCustomerName.Text = formRetailSaleOrderBill.cbxCustomerId.Text;
            }
            else
            {
                txtCustomerName.Text = formRetailSaleOrderBill.txtCustomerName.Text;
            }
            txtPhoneNumber.Text = formRetailSaleOrderBill.txtPhoneNumber.Text;
            txtPostalCode.Text = formRetailSaleOrderBill.txtPostalCode.Text;
            txtAddress.Text = formRetailSaleOrderBill.txtAddress.Text;
            if (this.Tag.ToString() == "Add")
            {
                dtpBillDate.Value = GlobalProperty.DBTime;
                dtpSignDate.Value = GlobalProperty.DBTime;
                cbxGoodsTypeCode.SelectedIndex = -1;
                cbxGoodsSeriesCode.SelectedIndex = -1;
                cbxEmployeeCode.SelectedIndex = -1;
                txtDiscount.Text = "1";  //若是代理商的话，默认值为代理的折扣系数。
                txtSaleBillNo.Text = useful.BuildCode("SaleOrderBill", "Where OperatorCode = '" + GlobalProperty.OperatorCode + "'", "SaleBillNo", "XS" + GlobalProperty.DBTime.Year.ToString(), 7);
            }
            if (this.Tag.ToString() == "Edit")
            {
                if (GlobalProperty.OperatorCode != formRetailSaleOrderBill.dgvSaleOrderBill.CurrentRow.Cells["OperatorCode"].Value.ToString())
                {
                    btnSave.Enabled = false; //非本人录入的记录，不允许修改。
                }
                //chbIsAmendBillNo.Enabled = false;
                txtSaleBillNo.Text = formRetailSaleOrderBill.dgvSaleOrderBill.CurrentRow.Cells["SaleBillNo"].Value.ToString();
                dtpBillDate.Value = Convert.ToDateTime(formRetailSaleOrderBill.dgvSaleOrderBill.CurrentRow.Cells["BillDate"].Value);
                cbxGoodsTypeCode.SelectedValue = formRetailSaleOrderBill.dgvSaleOrderBill.CurrentRow.Cells["GoodsTypeCode"].Value;
                cbxGoodsSeriesCode.SelectedValue = formRetailSaleOrderBill.dgvSaleOrderBill.CurrentRow.Cells["GoodsSeriesCode"].Value;
                txtUnitPrice.Text = formRetailSaleOrderBill.dgvSaleOrderBill.CurrentRow.Cells["UnitPrice"].Value.ToString();
                txtDiscount.Text = formRetailSaleOrderBill.dgvSaleOrderBill.CurrentRow.Cells["Discount"].Value.ToString();
                txtQuantity.Text = formRetailSaleOrderBill.dgvSaleOrderBill.CurrentRow.Cells["Quantity"].Value.ToString();
                if (formRetailSaleOrderBill.dgvSaleOrderBill.CurrentRow.Cells["IsNeedInvoice"].Value.ToString() == "1")  //需要发票
                {
                    rbIsNeedInvoice1.Checked = true;
                    if (formRetailSaleOrderBill.dgvSaleOrderBill.CurrentRow.Cells["WriteOffType"].Value.ToString() == "1")  //个人
                    {
                        chbWriteOffType1.Checked = true;
                        txtWriteOffName1.Text = formRetailSaleOrderBill.dgvSaleOrderBill.CurrentRow.Cells["WriteOffName"].Value.ToString();
                        txtCertificateNumber1.Text = formRetailSaleOrderBill.dgvSaleOrderBill.CurrentRow.Cells["CertificateNumber"].Value.ToString();
                    }
                    else  //单位
                    {
                        chbWriteOffType2.Checked = true;
                        txtWriteOffName2.Text = formRetailSaleOrderBill.dgvSaleOrderBill.CurrentRow.Cells["WriteOffName"].Value.ToString();
                        txtCertificateNumber2.Text = formRetailSaleOrderBill.dgvSaleOrderBill.CurrentRow.Cells["CertificateNumber"].Value.ToString();
                    }
                }
                else  //不需要发票
                {
                    rbIsNeedInvoice0.Checked = true;
                }
                cbxEmployeeCode.SelectedValue = formRetailSaleOrderBill.dgvSaleOrderBill.CurrentRow.Cells["EmployeeCode"].Value;

                if (formRetailSaleOrderBill.dgvSaleOrderBill.CurrentRow.Cells["SignDate"].Value == DBNull.Value)
                {
                    dtpSignDate.Checked = false;
                }
                else
                {
                    dtpSignDate.Value = Convert.ToDateTime(formRetailSaleOrderBill.dgvSaleOrderBill.CurrentRow.Cells["SignDate"].Value);
                }
                txtRemark.Text = formRetailSaleOrderBill.dgvSaleOrderBill.CurrentRow.Cells["Remark"].Value.ToString();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtSaleBillNo.Text.Trim().Length != 13)
            {
                MessageBox.Show("单号不正确！", "软件提示");
                txtSaleBillNo.Focus();
                return;
            }
            if (cbxGoodsTypeCode.SelectedValue == null)
            {
                MessageBox.Show("订购种类不许为空！", "软件提示");
                cbxGoodsTypeCode.Focus();
                return;
            }
            if (cbxGoodsSeriesCode.SelectedValue == null)
            {
                MessageBox.Show("订购版本不许为空！", "软件提示");
                cbxGoodsSeriesCode.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtDiscount.Text.Trim()))
            {
                MessageBox.Show("折扣不许为空！", "软件提示");
                txtDiscount.Focus();
                return;
            }
            else
            {
                if (Convert.ToDecimal(txtDiscount.Text.Trim()) > 1)
                {
                    MessageBox.Show("折扣不许大于1", "软件提示");
                    txtDiscount.Focus();
                    return;
                }
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
            //选择是
            if (rbIsNeedInvoice1.Checked)
            {
                if (chbWriteOffType1.Checked == false && chbWriteOffType2.Checked == false)
                {
                    MessageBox.Show("若需要发票，请输入相关的报销信息！", "软件提示");
                    return;
                }
                //选择个人1
                if (chbWriteOffType1.Checked)
                {
                    if (String.IsNullOrEmpty(txtWriteOffName1.Text.Trim()))
                    {
                        MessageBox.Show("姓名不许为空！", "软件提示");
                        txtWriteOffName1.Focus();
                        return;
                    }
                    if (String.IsNullOrEmpty(txtCertificateNumber1.Text.Trim()))
                    {
                        MessageBox.Show("身份证号不许为空！", "软件提示");
                        txtCertificateNumber1.Focus();
                        return;
                    }
                }
                //选择单位2
                if (chbWriteOffType2.Checked)
                {
                    if (String.IsNullOrEmpty(txtWriteOffName2.Text.Trim()))
                    {
                        MessageBox.Show("单位名称不许为空！", "软件提示");
                        txtWriteOffName2.Focus();
                        return;
                    }
                    if (String.IsNullOrEmpty(txtCertificateNumber2.Text.Trim()))
                    {
                        MessageBox.Show("税号不许为空！", "软件提示");
                        txtCertificateNumber2.Focus();
                        return;
                    }
                }
            }
            if (cbxEmployeeCode.SelectedValue == null)
            {
                MessageBox.Show("下单人不许为空！", "软件提示");
                cbxEmployeeCode.Focus();
                return;
            }
            if (this.Tag.ToString() == "Add")
            {
                if (rsob.IsExistSaleBillNo(txtSaleBillNo.Text.Trim()))  //若单据编号重复
                {
                    MessageBox.Show("该单号已存在,请重新输入单号！", "软件提示");
                    txtSaleBillNo.Focus();
                    return;
                }
                DataGridViewRow dgvr = rsob.AddDataGridViewRow(formRetailSaleOrderBill.dgvSaleOrderBill, formRetailSaleOrderBill.bsSaleOrderBill);
                dgvr.Cells["SaleBillNo"].Value = txtSaleBillNo.Text.Trim();
                dgvr.Cells["BillDate"].Value = dtpBillDate.Value.Date;
                dgvr.Cells["CustomerId"].Value = formRetailSaleOrderBill.CustomerNo;
                dgvr.Cells["GoodsTypeCode"].Value = cbxGoodsTypeCode.SelectedValue;
                dgvr.Cells["GoodsSeriesCode"].Value = cbxGoodsSeriesCode.SelectedValue;
                dgvr.Cells["UnitPrice"].Value = Convert.ToDecimal(txtUnitPrice.Text);
                dgvr.Cells["Discount"].Value = Convert.ToDecimal(txtDiscount.Text);
                dgvr.Cells["Quantity"].Value = Convert.ToInt32(txtQuantity.Text);
                if (rbIsNeedInvoice0.Checked)
                {
                    dgvr.Cells["IsNeedInvoice"].Value = "0"; //不要发票
                }
                if (rbIsNeedInvoice1.Checked)
                {
                    dgvr.Cells["IsNeedInvoice"].Value = "1";  //要发票
                }
                if (chbWriteOffType1.Checked)
                {
                    dgvr.Cells["WriteOffType"].Value = "1"; //个人索要发票
                    dgvr.Cells["WriteOffName"].Value = txtWriteOffName1.Text.Trim();
                    dgvr.Cells["CertificateNumber"].Value = txtCertificateNumber1.Text.Trim();

                }
                if (chbWriteOffType2.Checked)
                {
                    dgvr.Cells["WriteOffType"].Value = "2"; //单位索要发票
                    dgvr.Cells["WriteOffName"].Value = txtWriteOffName2.Text.Trim();
                    dgvr.Cells["CertificateNumber"].Value = txtCertificateNumber2.Text.Trim();
                }
                dgvr.Cells["EmployeeCode"].Value = cbxEmployeeCode.SelectedValue;
                if (dtpSignDate.Checked)
                {
                    dgvr.Cells["SignDate"].Value = dtpSignDate.Value.Date;
                }
                else
                {
                    dgvr.Cells["SignDate"].Value = DBNull.Value;
                }
                dgvr.Cells["Remark"].Value = txtRemark.Text.Trim();
                dgvr.Cells["OperatorCode"].Value = GlobalProperty.OperatorCode;
                dgvr.Cells["AppendDate"].Value = GlobalProperty.DBTime.Date;
                if (rsob.Insert(formRetailSaleOrderBill.bsSaleOrderBill))
                {
                    MessageBox.Show("保存成功！", "软件提示");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("保存失败！", "软件提示");
                }
            }
            if (this.Tag.ToString()=="Edit")
            {
                string strOldSaleBillNo = formRetailSaleOrderBill.dgvSaleOrderBill.CurrentRow.Cells["SaleBillNo"].Value.ToString();
                if (txtSaleBillNo.Text.Trim() != strOldSaleBillNo)  //说明单据编号(即主键)发生了改变
                {
                    if (rsob.IsExistSaleBillNo(txtSaleBillNo.Text.Trim()))  //若单据编号重复
                    {
                        MessageBox.Show("该单号已存在,请重新输入单号！", "软件提示");
                        txtSaleBillNo.Focus();
                        return;
                    }
                    if (useful.IsExistConstraint("SaleOrderBill", strOldSaleBillNo))  //该主键表对应的外键表存在外键记录
                    {
                        MessageBox.Show("已发生业务关系，不许修改单据号！", "软件提示");
                        txtSaleBillNo.Focus();
                        return;
                    }
                }
                DataGridViewRow dgvr = formRetailSaleOrderBill.dgvSaleOrderBill.CurrentRow;
                dgvr.Cells["SaleBillNo"].Value = txtSaleBillNo.Text.Trim();
                dgvr.Cells["BillDate"].Value = dtpBillDate.Value.Date;
                dgvr.Cells["CustomerId"].Value = formRetailSaleOrderBill.CustomerNo;
                dgvr.Cells["GoodsTypeCode"].Value = cbxGoodsTypeCode.SelectedValue;
                dgvr.Cells["GoodsSeriesCode"].Value = cbxGoodsSeriesCode.SelectedValue;
                dgvr.Cells["UnitPrice"].Value = Convert.ToDecimal(txtUnitPrice.Text);
                dgvr.Cells["Discount"].Value = Convert.ToDecimal(txtDiscount.Text);
                dgvr.Cells["Quantity"].Value = Convert.ToInt32(txtQuantity.Text);
                if (rbIsNeedInvoice0.Checked)
                {
                    dgvr.Cells["IsNeedInvoice"].Value = "0"; //不要发票
                }
                if (rbIsNeedInvoice1.Checked)
                {
                    dgvr.Cells["IsNeedInvoice"].Value = "1";  //要发票
                }
                if (chbWriteOffType1.Checked)
                {
                    dgvr.Cells["WriteOffType"].Value = "1"; //个人索要发票
                    dgvr.Cells["WriteOffName"].Value = txtWriteOffName1.Text.Trim();
                    dgvr.Cells["CertificateNumber"].Value = txtCertificateNumber1.Text.Trim();

                }
                if (chbWriteOffType2.Checked)
                {
                    dgvr.Cells["WriteOffType"].Value = "2"; //单位索要发票
                    dgvr.Cells["WriteOffName"].Value = txtWriteOffName2.Text.Trim();
                    dgvr.Cells["CertificateNumber"].Value = txtCertificateNumber2.Text.Trim();
                }
                dgvr.Cells["EmployeeCode"].Value = cbxEmployeeCode.SelectedValue;
                if (dtpSignDate.Checked)
                {
                    dgvr.Cells["SignDate"].Value = dtpSignDate.Value.Date;
                }
                else
                {
                    dgvr.Cells["SignDate"].Value = DBNull.Value;
                }
                dgvr.Cells["Remark"].Value = txtRemark.Text.Trim();
                //dgvr.Cells["OperatorCode"].Value = GlobalProperty.OperatorCode;
                if (rsob.Update(formRetailSaleOrderBill.bsSaleOrderBill))
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

        private void cbxGoodsSeriesCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxGoodsSeriesCode.SelectedValue != null)
            {
                string strSql = "Select UnitPrice From GoodsSeries Where GoodsSeriesCode = '" + cbxGoodsSeriesCode.SelectedValue.ToString() + "'";
                DataTable dt = rsob.GetDataTable(strSql);
                if (dt.Rows.Count > 0)
                {
                    txtUnitPrice.Text = dt.Rows[0]["UnitPrice"].ToString();
                }
            }
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            txtSaleMoney.Text = GetSaleMoneyString();
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            txtSaleMoney.Text = GetSaleMoneyString();
        }

        private void txtUnitPrice_TextChanged(object sender, EventArgs e)
        {
            txtSaleMoney.Text = GetSaleMoneyString();
        }

        private void rbIsNeedInvoice0_CheckedChanged(object sender, EventArgs e)
        {
            chbWriteOffType1.Checked = false;
            chbWriteOffType2.Checked = false;
            chbWriteOffType1.Enabled = false;
            chbWriteOffType2.Enabled = false;
        }

        private void rbIsNeedInvoice1_CheckedChanged(object sender, EventArgs e)
        {
            chbWriteOffType1.Enabled = true;
            chbWriteOffType2.Enabled = true;
        }

        private void chbWriteOffType1_CheckedChanged(object sender, EventArgs e)
        {
            if (chbWriteOffType1.Checked)
            {
                txtWriteOffName1.ReadOnly = false;
                txtCertificateNumber1.ReadOnly = false;
                chbWriteOffType2.Checked = false;
            }
            else
            {
                txtWriteOffName1.Text = "";
                txtCertificateNumber1.Text = "";
                txtWriteOffName1.ReadOnly = true;
                txtCertificateNumber1.ReadOnly = true;
            }
        }

        private void chbWriteOffType2_CheckedChanged(object sender, EventArgs e)
        {
            if (chbWriteOffType2.Checked)
            {
                txtWriteOffName2.ReadOnly = false;
                txtCertificateNumber2.ReadOnly = false;
                chbWriteOffType1.Checked = false;
            }
            else
            {
                txtWriteOffName2.Text = "";
                txtCertificateNumber2.Text = "";
                txtWriteOffName2.ReadOnly = true;
                txtCertificateNumber2.ReadOnly = true;
            }
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            useful.InputNumeric(e, txtDiscount);
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            useful.InputInteger(e);
        }

        private void chbIsAmendBillNoHeader_CheckedChanged(object sender, EventArgs e)
        {
            if (chbIsAmendBillNo.Checked)
            {
                txtSaleBillNo.ReadOnly = false;
            }
            else
            {
                txtSaleBillNo.ReadOnly = true;
            }
        }
    }
}
