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
    public partial class FormRetailBarterBaseBillInput : Form
    {
        FormRetailBarterBaseBill formRetailBarterBaseBill = null;
        int intSaleQuantity;
        int intCustomerId;
        Useful useful = new Useful();
        RetailBarterBaseBill rbbb = new RetailBarterBaseBill();
        DataLogic dal = new DataLogic();

        public FormRetailBarterBaseBillInput()
        {
            InitializeComponent();
        }

        private string strBarterBillNo;
        public string BarterBillNo
        {
            get
            {
               return strBarterBillNo;
            }
        }

        private void SetParametersValue()
        {
            dal.Cmd.Parameters.Clear();
            dal.Cmd.Parameters.AddWithValue("@BarterBillNo", txtBarterBillNo.Text.Trim());
            dal.Cmd.Parameters.AddWithValue("@BarterBillDate",dtpBarterBillDate.Value.Date);
            dal.Cmd.Parameters.AddWithValue("@BarterType", cbxBarterType.SelectedValue);
            dal.Cmd.Parameters.AddWithValue("@SaleBillNo", txtSaleBillNo.Text.Trim());
            dal.Cmd.Parameters.AddWithValue("@CustomerId", intCustomerId);
            dal.Cmd.Parameters.AddWithValue("@GoodsTypeCode", cbxGoodsTypeCode.SelectedValue);
            dal.Cmd.Parameters.AddWithValue("@GoodsSeriesCode", cbxGoodsSeriesCode.SelectedValue);
            dal.Cmd.Parameters.AddWithValue("@UnitPrice", txtUnitPrice.Text);
            dal.Cmd.Parameters.AddWithValue("@GoodsTypeCode1", cbxGoodsTypeCode1.SelectedValue);
            dal.Cmd.Parameters.AddWithValue("@GoodsSeriesCode1", cbxGoodsSeriesCode1.SelectedValue);
            dal.Cmd.Parameters.AddWithValue("@UnitPrice1", txtUnitPrice1.Text);
            dal.Cmd.Parameters.AddWithValue("@BarterQuantity", txtBarterQuantity.Text);
            if (rbIsNeedInvoice0.Checked)
            {
                dal.Cmd.Parameters.AddWithValue("@IsNeedInvoice", "0");
            }
            else
            {
                dal.Cmd.Parameters.AddWithValue("@IsNeedInvoice", "1");
            }
            dal.Cmd.Parameters.AddWithValue("@Remark1", txtRemark1.Text.Trim());
            dal.Cmd.Parameters.AddWithValue("@EmployeeCode1", cbxEmployeeCode1.SelectedValue);
            if(dtpSignDate1.Checked)
            {
                dal.Cmd.Parameters.AddWithValue("@SignDate1", dtpSignDate1.Value.Date);
            }
            else
            {
                dal.Cmd.Parameters.AddWithValue("@SignDate1", DBNull.Value);
            }
            dal.Cmd.Parameters.AddWithValue("@OperatorCode", GlobalProperty.OperatorCode);
            dal.Cmd.Parameters.AddWithValue("@AppendDate", GlobalProperty.DBTime.Date);
        }

        private void RetrieveSaleBillInfo(string strSaleBillNo)
        {
            string strSql = null;
            DataTable dt = null;
            RetailSaleOrderBill rsob = new RetailSaleOrderBill();
            strSql = "Select SaleOrderBill.*,Customer.* From SaleOrderBill,Customer Where SaleOrderBill.CustomerId = Customer.CustomerId and SaleBillNo = '" + strSaleBillNo + "'";
            dt = rsob.GetDataTable(strSql);
            if (dt.Rows.Count > 0)
            {
                SetSaleBillInfo(dt.Rows[0]);
            }
            else
            {
                MessageBox.Show("该销售单号不存在！", "软件提示");
                txtSaleBillNo.Focus();
                return;
            }
        }

        public void SetSaleBillInfo(DataRow dr)
        {
            if (dr != null)
            {
                //零售用户的基本档案信息
                txtCustomerName.Text = dr["CustomerName"].ToString();
                intCustomerId = Convert.ToInt32(dr["CustomerId"]);  //得到用户的Id值
                txtPhoneNumber.Text = dr["PhoneNumber"].ToString();
                txtAddress.Text = dr["Address"].ToString();
                //销售订单表的信息
                cbxGoodsTypeCode.SelectedValue = dr["GoodsTypeCode"];
                cbxGoodsSeriesCode.SelectedValue = dr["GoodsSeriesCode"];
                //设置原产品单价的默认值是“销售价”
                txtUnitPrice.Text = Decimal.Round(Convert.ToDecimal(dr["UnitPrice"]) * Convert.ToDecimal(dr["Discount"]), 2).ToString();
                this.intSaleQuantity = Convert.ToInt32(dr["Quantity"]);  //得到销售量，换货量不许大于销售量
                //在新添加换货单时，根据SaleOrderBill产生的默认设置，操作员可以修改
                if (dr["IsNeedInvoice"].ToString() == "1")  //需要发票
                {
                    rbIsNeedInvoice1.Checked = true;
                }
                else  //不需要发票
                {
                    rbIsNeedInvoice0.Checked = true;
                }
            }
            else
            {
                MessageBox.Show("该销售单号不存在！", "软件提示");
                txtSaleBillNo.Focus();
                return;
            }
        }

        private void GetBarterBaseBillInfo(string strBarterBillNo)
        {
            string strSql = null;
            DataTable dt = null;
            RetailSaleOrderBill rsob = new RetailSaleOrderBill();
            strSql = "Select BarterBaseBill.*,Customer.* From BarterBaseBill,Customer Where BarterBaseBill.CustomerId = Customer.CustomerId and BarterBillNo = '" + strBarterBillNo + "'";
            dt = rbbb.GetDataTable(strSql);
            if (dt.Rows.Count > 0)
            {
                txtBarterBillNo.Text = dt.Rows[0]["BarterBillNo"].ToString();
                txtSaleBillNo.Text = dt.Rows[0]["SaleBillNo"].ToString();
                txtCustomerName.Text = dt.Rows[0]["CustomerName"].ToString();
                this.intCustomerId = Convert.ToInt32(dt.Rows[0]["CustomerId"]);
                cbxBarterType.SelectedValue = dt.Rows[0]["BarterType"];
                dtpBarterBillDate.Value = Convert.ToDateTime(dt.Rows[0]["BarterBillDate"]);
                cbxGoodsTypeCode.SelectedValue = dt.Rows[0]["GoodsTypeCode"];
                cbxGoodsSeriesCode.SelectedValue = dt.Rows[0]["GoodsSeriesCode"];
                txtUnitPrice.Text = dt.Rows[0]["UnitPrice"].ToString();
                cbxGoodsTypeCode1.SelectedValue = dt.Rows[0]["GoodsTypeCode1"];
                cbxGoodsSeriesCode1.SelectedValue = dt.Rows[0]["GoodsSeriesCode1"];
                txtUnitPrice1.Text = dt.Rows[0]["UnitPrice1"].ToString();
                txtBarterQuantity.Text = dt.Rows[0]["BarterQuantity"].ToString();
                txtPhoneNumber.Text = dt.Rows[0]["PhoneNumber"].ToString();
                if (dt.Rows[0]["IsNeedInvoice"].ToString() == "0")
                {
                    rbIsNeedInvoice0.Checked = true;
                }
                else
                {
                    rbIsNeedInvoice1.Checked = true;
                }
                txtAddress.Text = dt.Rows[0]["Address"].ToString();
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
        }

        private String GetUnitPriceStringBySeries(string strGoodsSeriesCode)
        {
            Nullable<decimal> decUnitPrice = null;
            string strSql = "Select UnitPrice From GoodsSeries Where GoodsSeriesCode = '" + strGoodsSeriesCode + "'";
            DataTable dt = rbbb.GetDataTable(strSql);
            if (dt.Rows.Count > 0)
            {
                decUnitPrice = Convert.ToDecimal(dt.Rows[0]["UnitPrice"]);
            }
            if (decUnitPrice.HasValue)
            {
                return decUnitPrice.Value.ToString();
            }
            else
            {
                return null;
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

        private void FormRetailBarterBaseBillInput_Load(object sender, EventArgs e)
        {
            ControlBindDataSource cbds = new ControlBindDataSource();
            cbds.BindDataSource(this);
            useful.InitFormContros(groupBox1, null);
            formRetailBarterBaseBill = (FormRetailBarterBaseBill)this.Owner;
            if (this.Tag.ToString() == "Add")
            {
                this.Text = "添加单据";
                txtBarterBillNo.Text = useful.BuildCode("BarterBaseBill", "Where OperatorCode = '" + GlobalProperty.OperatorCode + "'", "BarterBillNo", "HH" + GlobalProperty.DBTime.Year.ToString(), 7);
                btnCD.Enabled = false;
            }
            else
            {
                this.Text = "修改单据";
                //chbIsAmendBillNo.Enabled = false;
                txtBarterBillNo.Text = formRetailBarterBaseBill.dgvBarterBaseBill.CurrentRow.Cells["BarterBillNo"].Value.ToString();
                GetBarterBaseBillInfo(txtBarterBillNo.Text);
                btnCD.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string strSql = null;
            string strSqlBarterBill = null;
            if (txtBarterBillNo.Text.Trim().Length != 13)
            {
                txtBarterBillNo.Focus();
                MessageBox.Show("换货单号不正确！", "软件提示");
                return;
            }
            if (String.IsNullOrEmpty(txtBarterBillNo.Text.Trim()))
            {
               
            }
            if (String.IsNullOrEmpty(txtCustomerName.Text.Trim()))
            {
                txtCustomerName.Focus();
                MessageBox.Show("用户信息不许为空！", "软件提示");
                return;
            }
            if (cbxBarterType.SelectedValue == null)
            {
                cbxBarterType.Focus();
                MessageBox.Show("调货类型不许为空！", "软件提示");
                return;
            }
            if (cbxGoodsTypeCode.SelectedValue == null)
            {
                cbxGoodsTypeCode.Focus();
                MessageBox.Show("原种类不许为空！", "软件提示");
                return;
            }
            if (cbxGoodsSeriesCode.SelectedValue == null)
            {
                cbxGoodsSeriesCode.Focus();
                MessageBox.Show("原版本不许为空！", "软件提示");
                return;
            }
            if (String.IsNullOrEmpty(txtUnitPrice.Text.Trim()))
            {
                txtUnitPrice.Focus();
                MessageBox.Show("原单价不许为空！", "软件提示");
                return;
            }
            if (cbxGoodsTypeCode1.SelectedValue == null)
            {
                cbxGoodsTypeCode1.Focus();
                MessageBox.Show("现种类不许为空！", "软件提示");
                return;
            }
            if (cbxGoodsSeriesCode1.SelectedValue == null)
            {
                cbxGoodsSeriesCode1.Focus();
                MessageBox.Show("现版本不许为空！", "软件提示");
                return;
            }
            if (String.IsNullOrEmpty(txtUnitPrice1.Text.Trim()))
            {
                txtUnitPrice1.Focus();
                MessageBox.Show("现单价不许为空！", "软件提示");
                return;
            }
            if (String.IsNullOrEmpty(txtBarterQuantity.Text))
            {
                txtBarterQuantity.Focus();
                MessageBox.Show("数量不许为空！", "软件提示");
                return;
            }
            else
            {
                if (Convert.ToInt32(txtBarterQuantity.Text) == 0)
                {
                    txtBarterQuantity.Focus();
                    MessageBox.Show("数量不许为零！", "软件提示");
                    return;
                }
            }
            if (cbxEmployeeCode1.SelectedValue == null)
            {
                cbxEmployeeCode1.Focus();
                MessageBox.Show("下单人不许为空！", "软件提示");
                return;
            }
            if (cbxGoodsSeriesCode.SelectedValue == cbxGoodsSeriesCode1.SelectedValue)
            {
                if (cbxGoodsTypeCode.SelectedValue == cbxGoodsTypeCode1.SelectedValue)
                {
                    if (MessageBox.Show("现产品与原产品完全相同，是否继续？", "软件提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                    {
                        return;
                    }
                }
            }
            if (this.Tag.ToString() == "Add")
            {
                if (rbbb.IsExistBarterBillNo(txtBarterBillNo.Text.Trim()))
                {
                    MessageBox.Show("该单号已存在,请重新输入单号！", "软件提示");
                    txtBarterBillNo.Focus();
                    return;
                }
                SetParametersValue();
                strSql = "INSERT INTO BarterBaseBill(BarterBillNo,BarterBillDate,BarterType,SaleBillNo,CustomerId,GoodsTypeCode,GoodsSeriesCode,UnitPrice,GoodsTypeCode1,GoodsSeriesCode1,UnitPrice1,BarterQuantity,IsNeedInvoice,Remark1,EmployeeCode1,SignDate1,OperatorCode,AppendDate) ";
                strSql += "VALUES(@BarterBillNo,@BarterBillDate,@BarterType,@SaleBillNo,@CustomerId,@GoodsTypeCode,@GoodsSeriesCode,@UnitPrice,@GoodsTypeCode1,@GoodsSeriesCode1,@UnitPrice1,@BarterQuantity,@IsNeedInvoice,@Remark1,@EmployeeCode1,@SignDate1,@OperatorCode,@AppendDate)";
                if (rbbb.Insert(dal, strSql))
                {
                    if (MessageBox.Show("保存成功，是否录入光盘号？", "软件提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        btnCD_Click(sender, e);
                    }
                    useful.InitFormContros(this, null);
                    txtBarterBillNo.Text = useful.BuildCode("BarterBaseBill", "Where OperatorCode = '" + GlobalProperty.OperatorCode + "'", "BarterBillNo", "HH" + GlobalProperty.DBTime.Year.ToString(), 7);
                    txtSaleBillNo.Focus();
                    strSqlBarterBill = rbbb.BarterBaseBillSql + " and BarterBaseBill.OperatorCode = '" + GlobalProperty.OperatorCode + "'" + " and BarterBaseBill.AppendDate = '" + GlobalProperty.DBTime.Date + "'";
                    formRetailBarterBaseBill.dgvBarterBaseBill.DataSource = rbbb.GetDataTable(strSqlBarterBill);
                }
                else
                {
                    MessageBox.Show("保存失败！", "软件提示");
                }
            }
            if (this.Tag.ToString() == "Edit")
            {
                string strOldBarterBillNo = formRetailBarterBaseBill.dgvBarterBaseBill.CurrentRow.Cells["BarterBillNo"].Value.ToString();
                if (txtBarterBillNo.Text.Trim() != strOldBarterBillNo)  //说明单据编号(即主键)发生了改变
                {
                    if (rbbb.IsExistBarterBillNo(txtBarterBillNo.Text.Trim()))  //若单据编号重复
                    {
                        MessageBox.Show("该单号已存在,请重新输入单号！", "软件提示");
                        txtBarterBillNo.Focus();
                        return;
                    }
                    if (useful.IsExistConstraint("BarterBaseBill", strOldBarterBillNo))  //该主键表对应的外键表存在外键记录
                    {
                        MessageBox.Show("已发生业务关系，不许修改单据号！", "软件提示");
                        txtBarterBillNo.Focus();
                        return;
                    }
                }
                SetParametersValue();
                strSql = "Update BarterBaseBill Set BarterBillNo = @BarterBillNo,BarterBillDate = @BarterBillDate,BarterType = @BarterType,SaleBillNo=@SaleBillNo,CustomerId= @CustomerId,GoodsTypeCode=@GoodsTypeCode,GoodsSeriesCode=@GoodsSeriesCode,UnitPrice=@UnitPrice,"
                    + "GoodsTypeCode1=@GoodsTypeCode1,GoodsSeriesCode1=@GoodsSeriesCode1,UnitPrice1=@UnitPrice1,BarterQuantity=@BarterQuantity,IsNeedInvoice=@IsNeedInvoice,Remark1=@Remark1,EmployeeCode1=@EmployeeCode1,SignDate1=@SignDate1 Where BarterBillNo = '" + strOldBarterBillNo + "'";
                if (rbbb.Update(dal, strSql))
                {
                    MessageBox.Show("保存成功！", "软件提示");
                    strSqlBarterBill = rbbb.BarterBaseBillSql + " and BarterBillNo = '" + txtBarterBillNo.Text.Trim() + "'";
                    formRetailBarterBaseBill.dgvBarterBaseBill.DataSource = rbbb.GetDataTable(strSqlBarterBill);
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
                RetrieveSaleBillInfo(txtSaleBillNo.Text.Trim());
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FormBrowseRetailSaleOrderBill formBrowseRetailSaleOrderBill = new FormBrowseRetailSaleOrderBill();
            formBrowseRetailSaleOrderBill.Owner = this;
            formBrowseRetailSaleOrderBill.ShowDialog();
        }

        private void txtSaleBillNo_TextChanged(object sender, EventArgs e)  //当txtSaleBillNo的文本发生改变时触发该事件
        {
            if (!String.IsNullOrEmpty(txtCustomerName.Text.Trim()))
            {
                List<Control> controls = new List<Control>();
                controls.Add(txtSaleBillNo);
                useful.InitFormContros(groupBox1, controls);
            }
        }

        private void cbxGoodsSeriesCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxGoodsSeriesCode.SelectedValue != null)
            {
                if (!(cbxGoodsSeriesCode.SelectedValue == null))
                {
                    txtUnitPrice.Text = GetUnitPriceStringBySeries(cbxGoodsSeriesCode.SelectedValue.ToString());
                }
            }
        }

        private void cbxGoodsSeriesCode1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(cbxGoodsSeriesCode1.SelectedValue == null))
            {
                txtUnitPrice1.Text = GetUnitPriceStringBySeries(cbxGoodsSeriesCode1.SelectedValue.ToString());
            }
        }

        private void txtUnitPrice_TextChanged(object sender, EventArgs e)
        {
            txtTotalBanlance.Text = GetTotalBanlanceString();
        }

        private void txtUnitPrice1_TextChanged(object sender, EventArgs e)
        {
            txtTotalBanlance.Text = GetTotalBanlanceString();
        }

        private void txtBarterQuantity_TextChanged(object sender, EventArgs e)
        {
            txtTotalBanlance.Text = GetTotalBanlanceString();
        }

        private void chbIsAmendBillNo_CheckedChanged(object sender, EventArgs e)
        {
            if (chbIsAmendBillNo.Checked)
            {
                txtBarterBillNo.ReadOnly = false;
            }
            else
            {
                txtBarterBillNo.ReadOnly = true;
            }
        }

        private void txtUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            useful.InputNumeric(e, txtUnitPrice);
        }

        private void txtUnitPrice1_KeyPress(object sender, KeyPressEventArgs e)
        {
            useful.InputNumeric(e, txtUnitPrice1);
        }

        private void txtBarterQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            useful.InputInteger(e);
        }

        private void btnCD_Click(object sender, EventArgs e)
        {
            if (this.Tag.ToString() == "Add")
            {
                strBarterBillNo = txtBarterBillNo.Text.Trim();
            }
            else
            {
                strBarterBillNo = formRetailBarterBaseBill.dgvBarterBaseBill.CurrentRow.Cells["BarterBillNo"].Value.ToString();
            }
            useful.ShowDialogForm(typeof(FormBarterBaseCDRecord), this.Tag.ToString(), this);
        }
    }
}
