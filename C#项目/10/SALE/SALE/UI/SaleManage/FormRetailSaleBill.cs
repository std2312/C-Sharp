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
    public partial class FormRetailSaleBill : Form
    {
        FormRetailSaleOrderBill formRetailOperation = new FormRetailSaleOrderBill();

        public FormRetailSaleBill()
        {
            InitializeComponent();
        }

        private void FormRetailSaleBill_Load(object sender, EventArgs e)
        {
            ControlBindDataSource cbds = new ControlBindDataSource();
            cbds.ComboBoxBindDataSource(cbxBankCode, "BankCode", "BankName", "Select * From Bank", "Bank");
            cbds.ComboBoxBindDataSource(cbxConsignCorpCode, "ConsignCorpCode", "ConsignCorpName", "Select * From ConsignCorp", "ConsignCorp");
            cbds.ComboBoxBindDataSource(cbxEmployeeCode1, "EmployeeCode", "EmployeeName", "Select * From Employee", "Employee");
            cbds.ComboBoxBindDataSource(cbxEmployeeCode2, "EmployeeCode", "EmployeeName", "Select * From Employee", "Employee");
            cbds.ComboBoxBindDataSource(cbxEmployeeCode3, "EmployeeCode", "EmployeeName", "Select * From Employee", "Employee");
            cbds.ComboBoxBindDataSource(cbxEmployeeCode4, "EmployeeCode", "EmployeeName", "Select * From Employee", "Employee");
            cbds.ComboBoxBindDataSource(cbxEmployeeCode5, "EmployeeCode", "EmployeeName", "Select * From Employee", "Employee");
            cbds.ComboBoxBindDataSource(cbxGoodsSeriesCode, "GoodsSeriesCode", "GoodsSeriesName", "Select * From GoodsSeries", "GoodsSeries");
            cbds.ComboBoxBindDataSource(cbxGoodsSeriesCode1, "GoodsSeriesCode", "GoodsSeriesName", "Select * From GoodsSeries", "GoodsSeries");
            cbds.ComboBoxBindDataSource(cbxGoodsTypeCode, "GoodsTypeCode", "GoodsTypeName", "Select * From GoodsType", "GoodsType");
            cbds.ComboBoxBindDataSource(cbxGoodsTypeCode1, "GoodsTypeCode", "GoodsTypeName", "Select * From GoodsType", "GoodsType");
            cbds.ComboBoxBindDataSource(cbxPayTypeCode, "PayTypeCode", "PayTypeName", "Select * From PayType", "PayType");
            //formRetailOperation = (FormRetailSaleOrderBill)this.Owner;
            //txtCustomerName.Text = formRetailOperation.txtCustomerName.Text;
            //txtPhoneNumber.Text = formRetailOperation.txtPhoneNumber.Text;
            //txtPostalCode.Text = formRetailOperation.txtPostalCode.Text;
            //if (this.Tag.ToString() == "Add")
            //{
            //    cbxGoodsTypeCode.SelectedIndex = -1;
            //    cbxGoodsTypeCode1.SelectedIndex = -1;
            //    cbxGoodsSeriesCode.SelectedIndex = -1;
            //    cbxGoodsSeriesCode1.SelectedIndex = -1;
            //    cbxEmployeeCode1.SelectedIndex = -1;
            //    cbxEmployeeCode2.SelectedIndex = -1;
            //    cbxEmployeeCode3.SelectedIndex = -1;
            //    cbxEmployeeCode4.SelectedIndex = -1;
            //    cbxEmployeeCode5.SelectedIndex = -1;
            //    cbxBankCode.SelectedIndex = -1;
            //    cbxConsignCorpCode.SelectedIndex = -1;
            //    cbxPayTypeCode.SelectedIndex = -1;
            //    txtDiscount.Text = "1";
            //}
            //if (this.Tag.ToString() == "Edit")
            //{

            //}


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            RetailSaleOrderBill rsb = new RetailSaleOrderBill();
            if (cbxGoodsTypeCode.SelectedValue == null)
            {
                MessageBox.Show("订购种类不许为空！","软件提示");
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
            if (cbxPayTypeCode.SelectedValue == null)
            {
                MessageBox.Show("交易方式不许为空！", "软件提示");
                cbxPayTypeCode.Focus();
                return;
            }
            if (cbxBankCode.SelectedValue == null)
            {
                MessageBox.Show("预存银行不许为空！", "软件提示");
                cbxBankCode.Focus();
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
                //若实收金额小于销售总额，则程序给与提示
                if (Convert.ToDecimal(txtReceiptMoney.Text.Trim()) <Convert.ToDecimal(txtSaleMoney.Text.Trim()))
                {
                    MessageBox.Show("实收金额不许小于销售总额！", "软件提示");
                    txtReceiptMoney.Focus();
                    return;
                }
            }
            if (cbxGoodsTypeCode1.SelectedValue == null)
            {
                MessageBox.Show("实发种类不许为空！", "软件提示");
                cbxGoodsTypeCode1.Focus();
                return;
            }
            if (cbxGoodsSeriesCode1.SelectedValue == null)
            {
                MessageBox.Show("实发版本不许为空！", "软件提示");
                cbxGoodsSeriesCode1.Focus();
                return;
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
            if (Convert.ToInt32(txtDiscount.Text.Trim()) == 0)
            {
                if (MessageBox.Show("折扣为零，是否继续？", "软件提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    txtDiscount.Focus();
                    return;
                }
            }

            if (cbxGoodsTypeCode1.SelectedValue != cbxGoodsTypeCode.SelectedValue)
            {
                if (MessageBox.Show("实发种类不等于订购种类，是否继续？", "软件提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    cbxGoodsTypeCode1.Focus();
                    return;
                }
            }
            if (cbxGoodsSeriesCode1.SelectedValue != cbxGoodsSeriesCode.SelectedValue)
            {
                if (MessageBox.Show("实发版本不等于订购版本，是否继续？", "软件提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    cbxGoodsSeriesCode1.Focus();
                    return;
                }
            }
            if (this.Tag.ToString() == "Add")
            {
                DataGridViewRow dgvr = rsb.AddDataGridViewRow(formRetailOperation.dgvSaleOrderBill, formRetailOperation.bsSaleOrderBill);
                dgvr.Cells["SaleBillNo"].Value = txtSaleBillNo.Text.Trim();
                dgvr.Cells["BillDate"].Value = dtpBillDate.Value;
                dgvr.Cells["CustomerId"].Value = formRetailOperation.CustomerNo;
                dgvr.Cells["GoodsTypeCode"].Value = cbxGoodsTypeCode.SelectedValue;
                dgvr.Cells["GoodsSeriesCode"].Value = cbxGoodsSeriesCode.SelectedValue;
                dgvr.Cells["UnitPrice"].Value = Convert.ToDecimal(txtUnitPrice.Text);
                dgvr.Cells["Discount"].Value = Convert.ToDecimal(txtDiscount.Text);
                dgvr.Cells["Quantity"].Value = Convert.ToInt32(txtQuantity.Text);
                if(rbIsNeedInvoice0.Checked)
                {
                     dgvr.Cells["IsNeedInvoice"].Value = "0"; //不要发票
                }
                if(rbIsNeedInvoice1.Checked)
                {
                     dgvr.Cells["IsNeedInvoice"].Value = "1";  //要发票
                }
                if(chbWriteOffType1.Checked)
                {
                    dgvr.Cells["WriteOffType"].Value = "1"; //个人索要发票
                    dgvr.Cells["WriteOffName"].Value = txtWriteOffName1.Text.Trim();
                    dgvr.Cells["CertificateNumber"].Value = txtCertificateNumber1.Text.Trim();
                    
                }
                if(chbWriteOffType2.Checked)
                {
                    dgvr.Cells["WriteOffType"].Value = "2"; //单位索要发票
                    dgvr.Cells["WriteOffName"].Value = txtWriteOffName2.Text.Trim();
                    dgvr.Cells["CertificateNumber"].Value = txtCertificateNumber2.Text.Trim();
                }
                
                dgvr.Cells["PayTypeCode"].Value = cbxPayTypeCode.SelectedValue;
                dgvr.Cells["BankCode"].Value = cbxBankCode.SelectedValue;
                //dgvr.Cells["SaleDate"].Value = 
                //dgvr.Cells["SaleBillNo"].Value = 
                //dgvr.Cells["SaleBillNo"].Value = 
                //dgvr.Cells["SaleBillNo"].Value = 
                //dgvr.Cells["SaleBillNo"].Value = 
                //dgvr.Cells["SaleBillNo"].Value = 
                //dgvr.Cells["SaleBillNo"].Value = 
                //dgvr.Cells["SaleBillNo"].Value = 
                //dgvr.Cells["SaleBillNo"].Value = 
                //dgvr.Cells["SaleBillNo"].Value = 
                //dgvr.Cells["SaleBillNo"].Value = 
                //dgvr.Cells["SaleBillNo"].Value = 
                //dgvr.Cells["SaleBillNo"].Value = 
                //dgvr.Cells["SaleBillNo"].Value = 
                //dgvr.Cells["SaleBillNo"].Value = 
                //dgvr.Cells["SaleBillNo"].Value = 



                //if (dgvr.Insert(formRetailOperation.bsSaleBill))
                //{
                //    if (MessageBox.Show("保存成功，是否继续添加？", "软件提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                //    {
                        
                //    }
                //    else
                //    {
                //        this.Close();
                //    }
                //}
                //else
                //{
                //    MessageBox.Show("保存失败！", "软件提示");
                //}
            }

        }




        private void btnAddCD_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
