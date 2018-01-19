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
    public partial class FormRetailUntreadGatherBillInput : Form
    {
        Useful useful = new Useful();
        RetailUntreadGatherBill rugb = new RetailUntreadGatherBill();
        FormRetailUntreadGatherBill formRetailUntreadGatherBill = null;
        DataLogic dal = new DataLogic();

        public FormRetailUntreadGatherBillInput()
        {
            InitializeComponent();
        }

        private void RetrieveUntreadBaseBillInfo(string strUntreadBillNo)
        {
            string strSql = null;
            DataTable dt = null;
            RetailUntreadBaseBill rubb = new RetailUntreadBaseBill();
            strSql = "Select UntreadBaseBill.*,SaleOrderBill.*,Customer.*    From UntreadBaseBill,SaleOrderBill,Customer ";
            strSql += "Where UntreadBaseBill.SaleBillNo = SaleOrderBill.SaleBillNo and UntreadBaseBill.CustomerId = Customer.CustomerId and UntreadBaseBill.UntreadBillNo = '" + strUntreadBillNo + "'";
            dt = rubb.GetDataTable(strSql);
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
                dtpSaleOrderBillDate.Value = Convert.ToDateTime(dr["BillDate"]);  //订单日期，来自SaleOrderBill
                dtpUntreadBillDate.Value = Convert.ToDateTime(dr["UntreadBillDate"]);  //退货日期，来自UntreadBaseBill
                cbxGoodsTypeCode.SelectedValue = dr["GoodsTypeCode"];  //取自UntreadBaseBill
                cbxGoodsSeriesCode.SelectedValue = dr["GoodsSeriesCode"];  //取自UntreadBaseBill
                //设置退货单价
                txtUnitPrice.Text = dr["UnitPrice"].ToString();  //取自UntreadBaseBill，不取自SaleOrderBill
                //设置退货数量
                txtQuantity.Text = dr["Quantity"].ToString();  //取自UntreadBaseBill，不取自SaleOrderBill
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
            string strSql = null;
            DataTable dt = null;
            strSql = "Select UntreadGatherBill.* From UntreadGatherBill Where UntreadBillNo = '" + strUntreadBillNo + "'";
            dt = rugb.GetDataTable(strSql);
            if (dt.Rows.Count > 0)
            {
                if (this.Tag.ToString() == "Add")
                {
                    useful.SetControlsState(groupBox3, false);
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
            else
            {
                useful.SetControlsState(groupBox3, true);
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

        private void SetParametersValue()
        {
            dal.Cmd.Parameters.Clear();
            dal.Cmd.Parameters.AddWithValue("@UntreadBillNo", txtUntreadBillNo.Text.Trim());
            if (rbIsComplete0.Checked)
            {
                dal.Cmd.Parameters.AddWithValue("@IsComplete","0");
            }
            else
            {
                dal.Cmd.Parameters.AddWithValue("@IsComplete", "1");
            }
            if (rbIsReturnInvoice0.Checked)
            {
                dal.Cmd.Parameters.AddWithValue("@IsReturnInvoice", "0");
            }
            else
            {
                dal.Cmd.Parameters.AddWithValue("@IsReturnInvoice", "1");
            }
            if (rbIsShatter0.Checked)
            {
                dal.Cmd.Parameters.AddWithValue("@IsShatter", "0");
            }
            else
            {
                dal.Cmd.Parameters.AddWithValue("@IsShatter", "1");
            }
            dal.Cmd.Parameters.AddWithValue("@EmployeeCode2", cbxEmployeeCode2.SelectedValue);
            dal.Cmd.Parameters.AddWithValue("@SignDate2", dtpSignDate2.Value.Date);
            dal.Cmd.Parameters.AddWithValue("@Remark2", txtRemark2.Text.Trim());
            dal.Cmd.Parameters.AddWithValue("@OperatorCode", GlobalProperty.OperatorCode);
            dal.Cmd.Parameters.AddWithValue("@AppendDate", GlobalProperty.DBTime.Date);
        }

        private void FormRetailUntreadGatherBillInput_Load(object sender, EventArgs e)
        {
            formRetailUntreadGatherBill = (FormRetailUntreadGatherBill)this.Owner;
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
                txtUntreadBillNo.Text = formRetailUntreadGatherBill.dgvUntreadGatherBill.CurrentRow.Cells["UntreadBillNo"].Value.ToString();
                RetrieveUntreadBaseBillInfo(txtUntreadBillNo.Text.Trim());
                GetUntreadGatherBillInfo(txtUntreadBillNo.Text.Trim());
            } 
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
            if (cbxEmployeeCode2.SelectedValue == null)
            {
                MessageBox.Show("收货人不许为空", "软件提示");
                txtUntreadBillNo.Focus();
                return;
            }
            //用于检索与收货单相关的记录信息
            string strSqlGatherBill = "Select UntreadGatherBill.UntreadBillNo,Customer.CustomerName,Customer.Address,UntreadBaseBill.GoodsTypeCode,";
            strSqlGatherBill += "UntreadBaseBill.GoodsSeriesCode,UntreadBaseBill.Quantity,UntreadBaseBill.Remark1,UntreadGatherBill.IsComplete,UntreadGatherBill.IsReturnInvoice,";
            strSqlGatherBill += "UntreadGatherBill.IsShatter,UntreadGatherBill.EmployeeCode2,UntreadGatherBill.SignDate2,UntreadGatherBill.OperatorCode,UntreadGatherBill.AppendDate,UntreadGatherBill.Id ";
            strSqlGatherBill += "From UntreadBaseBill,UntreadGatherBill,Customer Where UntreadGatherBill.UntreadBillNo = UntreadBaseBill.UntreadBillNo and UntreadBaseBill.CustomerId = Customer.CustomerId ";
            if (this.Tag.ToString() == "Add")
            {
                SetParametersValue();
                strSql = "INSERT INTO UntreadGatherBill(UntreadBillNo,IsComplete,IsReturnInvoice,IsShatter,EmployeeCode2,SignDate2,Remark2,OperatorCode,AppendDate) ";
                strSql += "VALUES(@UntreadBillNo,@IsComplete,@IsReturnInvoice,@IsShatter,@EmployeeCode2,@SignDate2,@Remark2,@OperatorCode,@AppendDate)";
                if (rugb.Insert(dal, strSql))
                {
                    MessageBox.Show("保存成功！","软件提示");
                    useful.InitFormContros(this,null);
                    rbIsComplete1.Checked = true;
                    rbIsReturnInvoice1.Checked = true;
                    rbIsShatter0.Checked = true;
                    txtUntreadBillNo.Focus();
                    //检索本人当日录入的记录
                    strSqlGatherBill += " and UntreadGatherBill.OperatorCode = '" + GlobalProperty.OperatorCode + "'" + " and UntreadGatherBill.AppendDate = '" + GlobalProperty.DBTime.Date + "'";
                    formRetailUntreadGatherBill.dgvUntreadGatherBill.DataSource = rugb.GetDataTable(strSqlGatherBill);
                }
                else
                {
                    MessageBox.Show("保存失败！", "软件提示");
                }
            }
            if (this.Tag.ToString() == "Edit")
            {
                int intId = Convert.ToInt32(formRetailUntreadGatherBill.dgvUntreadGatherBill.CurrentRow.Cells["Id"].Value);
                SetParametersValue();
                strSql = "Update UntreadGatherBill Set IsComplete = @IsComplete,IsReturnInvoice = @IsReturnInvoice,IsShatter = @IsShatter,";
                strSql += "EmployeeCode2 = @EmployeeCode2,SignDate2 = @SignDate2,Remark2 = @Remark2 ";
                strSql += "Where Id = " + intId; 
                if (rugb.Update(dal, strSql))
                {
                    MessageBox.Show("保存成功！", "软件提示");
                    //修改成功之后，刷新被修改行
                    strSqlGatherBill += "and UntreadGatherBill.Id = " + intId;
                    formRetailUntreadGatherBill.dgvUntreadGatherBill.DataSource = rugb.GetDataTable(strSqlGatherBill);
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

        private void txtUntreadBillNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RetrieveUntreadBaseBillInfo(txtUntreadBillNo.Text.Trim());
                GetUntreadGatherBillInfo(txtUntreadBillNo.Text.Trim());
            }
        }

        private void txtUntreadBillNo_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtCustomerName.Text.Trim()))
            {
                useful.InitFormContros(groupBox1, null);
                useful.InitFormContros(groupBox3, null);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FormBrowseRetailUntreadBaseBillOther formBrowseRetailUntreadBaseBillOther = new FormBrowseRetailUntreadBaseBillOther();
            formBrowseRetailUntreadBaseBillOther.Owner = this;
            formBrowseRetailUntreadBaseBillOther.ShowDialog();
        }
    }
}
