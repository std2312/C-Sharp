using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SALE.DAL;
using SALE.Common;
using SALE.BLL.SaleManage;

namespace SALE.UI.SaleManage
{
    public partial class FormRetailSaleOrderBill : Form
    {
        private DataLogic dal = new DataLogic();
        private RetailCustomer rc = new RetailCustomer();
        private Useful useful = new Useful();
        private RetailSaleOrderBill rsb = new RetailSaleOrderBill();

        public FormRetailSaleOrderBill()
        {
            InitializeComponent();
        }

        private void FormRetailOperation_Load(object sender, EventArgs e)
        {
            ControlBindDataSource cbds = new ControlBindDataSource();
            //用户的基本信息
            cbds.ComboBoxBindDataSource(cbxProvinceCode, "ProvinceCode", "ProvinceName", "Select * From Province", "Province");
            cbds.ComboBoxBindDataSource(cbxCustomerId, "CustomerId", "CustomerName", "Select * From V_AgentRecord", "V_AgentRecord");
            //销售订单
            cbds.DataGridViewComboBoxColumnBindDataSource(GoodsTypeCode, "GoodsTypeCode", "GoodsTypeName", "Select * From GoodsType", "GoodsType");
            cbds.DataGridViewComboBoxColumnBindDataSource(GoodsSeriesCode, "GoodsSeriesCode", "GoodsSeriesName", "Select * From GoodsSeries", "GoodsSeries");
            cbds.DataGridViewComboBoxColumnBindDataSource(OperatorCode, "OperatorCode", "OperatorName", "Select * From Operator", "Operator");
            //空绑定
            bsSaleOrderBill.DataSource = rsb.GetDataTable("SaleOrderBill", "Where CustomerId = 0");
            dgvSaleOrderBill.DataSource = bsSaleOrderBill;
            toolStrip1.Tag = "";
        }

        private int m_CustomerNo;
        public int CustomerNo
        {
            set
            {
                m_CustomerNo = value;
            }
            get
            {
                return m_CustomerNo;
            }
        }

        private void ControlStatus()
        {
            //窗体控件状态切换
            chbIsAgent.Enabled = !chbIsAgent.Enabled;
            txtCustomerName.ReadOnly = !txtCustomerName.ReadOnly;
            cbxCustomerId.Enabled = !cbxCustomerId.Enabled;
            cbxProvinceCode.Enabled = !cbxProvinceCode.Enabled;
            txtAddress.ReadOnly = !txtAddress.ReadOnly;
            txtPostalCode.ReadOnly = !txtPostalCode.ReadOnly;
            txtPhoneNumber.ReadOnly = !txtPhoneNumber.ReadOnly;
            txtURL.ReadOnly = !txtURL.ReadOnly;
            rbCustomerType2.Enabled = !rbCustomerType2.Enabled;
            rbCustomerType3.Enabled = !rbCustomerType3.Enabled;
            txtRemark.ReadOnly = !txtRemark.ReadOnly;
        }

        private void ClearControls()
        {
            txtCustomerName.Text = "";
            cbxCustomerId.SelectedIndex = -1;
            cbxProvinceCode.SelectedIndex = -1;
            txtAddress.Text = "";
            txtPostalCode.Text = "";
            txtPhoneNumber.Text = "";
            txtURL.Text = "";
            rbCustomerType2.Checked = true;
            rbCustomerType3.Checked = false;
            txtRemark.Text = "";
            chbIsAgent.Checked = false;
        }

        /// <summary>
        /// 设置参数值
        /// </summary>
        private void SetParametersValue()
        {
            dal.Cmd.Parameters.Clear();
            dal.Cmd.Parameters.AddWithValue("@CustomerName", txtCustomerName.Text.Trim());
            if (String.IsNullOrEmpty(txtPhoneNumber.Text.Trim()))
            {
                //把null对象化为DBNull
                dal.Cmd.Parameters.AddWithValue("@PhoneNumber", DBNull.Value);
            }
            else
            {
                dal.Cmd.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text.Trim());
            }
            dal.Cmd.Parameters.AddWithValue("@ProvinceCode", cbxProvinceCode.SelectedValue.ToString());
            if (String.IsNullOrEmpty(txtAddress.Text.Trim()))
            {
                //把null对象化为DBNull
                dal.Cmd.Parameters.AddWithValue("@Address", DBNull.Value);
            }
            else
            {
                dal.Cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
            }
            if (String.IsNullOrEmpty(txtPostalCode.Text.Trim()))
            {
                //把null对象化为DBNull
                dal.Cmd.Parameters.AddWithValue("@PostalCode", DBNull.Value);
            }
            else
            {
                dal.Cmd.Parameters.AddWithValue("@PostalCode", txtPostalCode.Text.Trim());
            }
            if (String.IsNullOrEmpty(txtURL.Text.Trim()))
            {
                //把null对象化为DBNull
                dal.Cmd.Parameters.AddWithValue("@URL", DBNull.Value);
            }
            else
            {
                dal.Cmd.Parameters.AddWithValue("@URL", txtURL.Text.Trim());
            }
            //----------------------------------------
            if(rbCustomerType2.Checked)
            {
                dal.Cmd.Parameters.AddWithValue("@CustomerType", "2");
            }
            if (rbCustomerType3.Checked)
            {
                dal.Cmd.Parameters.AddWithValue("@CustomerType", "3");
            }
            if (String.IsNullOrEmpty(txtRemark.Text.Trim()))
            {
                //把null对象化为DBNull
                dal.Cmd.Parameters.AddWithValue("@Remark", DBNull.Value);
            }
            else
            {
                dal.Cmd.Parameters.AddWithValue("@Remark", txtRemark.Text.Trim());
            }
            dal.Cmd.Parameters.AddWithValue("@OperatorCode", GlobalProperty.OperatorCode);
        }

        private void toolAdd_Click(object sender, EventArgs e)
        {
            ControlStatus();
            ClearControls();
            toolSave.Enabled = true;
            toolCancel.Enabled = true;
            //
            toolAdd.Enabled = false;
            toolAmend.Enabled = false;
            toolBrowse.Enabled = false;
            toolDelete.Enabled = false;
            toolStrip1.Tag = "Add";
            this.CustomerNo = 0;
            useful.DataGridViewReset(dgvSaleOrderBill);
        }

        private void toolAmend_Click(object sender, EventArgs e)
        {
            ControlStatus();
            toolSave.Enabled = true;
            toolCancel.Enabled = true;

            toolAdd.Enabled = false;
            toolBrowse.Enabled = false;
            toolDelete.Enabled = false;
            toolAmend.Enabled = false;
            chbIsAgent.Enabled = false;

            toolStrip1.Tag = "Edit";
        }

        private void toolCancel_Click(object sender, EventArgs e)
        {

            ControlStatus();

            if (toolStrip1.Tag.ToString() == "Add")  //添加状态 取消
            {
                ClearControls();

                toolDelete.Enabled = false;
                toolAmend.Enabled = false;
                toolSave.Enabled = false;
                toolCancel.Enabled = false;

                toolAdd.Enabled = true;
                toolBrowse.Enabled = true;
                this.CustomerNo = 0;//等于零
                if (chbIsAgent.Checked)
                {
                    cbxProvinceCode.Enabled = false;
                }
            }
            if (toolStrip1.Tag.ToString() == "Edit")  //修改状态 取消
            {
                toolAdd.Enabled = true;
                toolBrowse.Enabled = true;
                toolDelete.Enabled = true;
                toolAmend.Enabled = true;

                toolSave.Enabled = false;
                toolCancel.Enabled = false;
            }
        }

        private void toolSave_Click(object sender, EventArgs e)
        {
            string strSql = null;
            if (String.IsNullOrEmpty(txtCustomerName.Text.Trim()))
            {
                MessageBox.Show("用户名称不许为空！","软件提示");
                txtCustomerName.Focus();
                return;
            }
            if (cbxProvinceCode.SelectedValue == null)
            {
                MessageBox.Show("所在省市不许为空！", "软件提示");
                cbxProvinceCode.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtAddress.Text.Trim()))
            {
                MessageBox.Show("地址不许为空！", "软件提示");
                txtAddress.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtPhoneNumber.Text.Trim()))
            {
                MessageBox.Show("联系电话不许为空！", "软件提示");
                txtPhoneNumber.Focus();
                return;
            }
            SetParametersValue();
            if (toolStrip1.Tag.ToString() == "Add")
            {
                strSql = "INSERT INTO Customer(CustomerName,PhoneNumber,ProvinceCode,Address,PostalCode,URL,CustomerType,Remark,OperatorCode) ";
                strSql += "VALUES(@CustomerName,@PhoneNumber,@ProvinceCode,@Address,@PostalCode,@URL,@CustomerType,@Remark,@OperatorCode)";
                if (rc.Insert(dal, strSql))
                {
                    //设置客户的ID号
                    this.CustomerNo = rc.GetMaxIdOfCurrentOperator(GlobalProperty.OperatorCode);
                    MessageBox.Show("保存成功！", "软件提示");

                    ControlStatus();
                    toolSave.Enabled = false;
                    toolCancel.Enabled = false;

                    toolAdd.Enabled = true;
                    toolAmend.Enabled = true;
                    toolDelete.Enabled = true;
                    toolBrowse.Enabled = true;
                }
                else
                {
                    MessageBox.Show("保存失败！", "软件提示");
                }
            }
            if (toolStrip1.Tag.ToString() == "Edit")
            {
                strSql = "Update Customer Set CustomerName = @CustomerName,PhoneNumber=@PhoneNumber,ProvinceCode=@ProvinceCode,Address=@Address,PostalCode = @PostalCode,URL=@URL,";
                strSql += "CustomerType=@CustomerType,Remark=@Remark,OperatorCode=@OperatorCode ";
                strSql += "Where CustomerId = '" + this.CustomerNo + "'";
                if (rc.Update(dal, strSql))
                {
                    MessageBox.Show("保存成功！", "软件提示");

                    ControlStatus();
                    toolSave.Enabled = false;
                    toolCancel.Enabled = false;

                    toolAdd.Enabled = true;
                    toolAmend.Enabled = true;
                    toolDelete.Enabled = true;
                    toolBrowse.Enabled = true;
                }
                else
                {
                    MessageBox.Show("保存失败！", "软件提示");
                }
            }
        }

        private void toolBrowse_Click(object sender, EventArgs e)
        {
            toolStrip1.Tag = "Browse";
            FormBrowseRetailSaleOrderBill formBrowseRetailSaleOrderBill = new FormBrowseRetailSaleOrderBill();
            formBrowseRetailSaleOrderBill.Owner = this;
            formBrowseRetailSaleOrderBill.ShowDialog();
        }

        private void toolDelete_Click(object sender, EventArgs e)
        {
            string strSql = " Delete From Customer Where CustomerId = '" + this.CustomerNo + "'";
            if (MessageBox.Show("确定要删除吗？", "软件提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                if (new Useful().IsExistConstraint("Customer", this.CustomerNo.ToString()))
                {
                    MessageBox.Show("已发生业务关系，无法删除", "软件提示");
                    return;
                }
                if (rc.Delete(strSql))
                {
                    MessageBox.Show("保存成功！", "软件提示");

                    ClearControls();
                    toolDelete.Enabled = false;
                    toolAmend.Enabled = false;
                    toolSave.Enabled = false;
                    toolCancel.Enabled = false;

                    toolAdd.Enabled = true;
                    toolBrowse.Enabled = true;
                    this.CustomerNo = 0;
                }
                else
                {
                    MessageBox.Show("保存失败！", "软件提示");
                }
            }
        }

        private void toolExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPostalCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            useful.InputInteger(e);
        }

        private void txtCustomerName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cbxProvinceCode.Focus();
                cbxProvinceCode.DroppedDown = true;
            }
        }

        private void cbxProvinceCode_KeyDown(object sender, KeyEventArgs e)
        {
            useful.SetFocus(e, txtAddress);  //子类的实例传递给基类的引用
        }

        private void txtPostalCode_KeyDown(object sender, KeyEventArgs e)
        {
            useful.SetFocus(e,txtPhoneNumber);
        }

        private void txtPhoneNumber_KeyDown(object sender, KeyEventArgs e)
        {
            useful.SetFocus(e, txtURL);
        }

        private void txtURL_KeyDown(object sender, KeyEventArgs e)
        {
            useful.SetFocus(e, txtRemark);
        }

        private void txtRemark_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                toolSave_Click(sender, e);
            }
        }

        private void txtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            useful.SetFocus(e, txtPostalCode);
        }

        private void contextAdd_Click(object sender, EventArgs e)
        {
            if (this.CustomerNo != 0)
            {
                FormRetailSaleOrderBillInput formRetailSaleOrderBillInput = new FormRetailSaleOrderBillInput();
                formRetailSaleOrderBillInput.Tag = "Add";
                formRetailSaleOrderBillInput.Owner = this;
                formRetailSaleOrderBillInput.ShowDialog();
            }
        }

        private void contextAmend_Click(object sender, EventArgs e)
        {
            if (this.CustomerNo != 0)
            {
                if (dgvSaleOrderBill.RowCount > 0)
                {
                    if (GlobalProperty.OperatorCode != dgvSaleOrderBill.CurrentRow.Cells["OperatorCode"].Value.ToString())
                    {
                        MessageBox.Show("非本记录的录入人员，不许允许修改！", "软件提示");
                        return;
                    }
                    FormRetailSaleOrderBillInput formRetailSaleOrderBillInput = new FormRetailSaleOrderBillInput();
                    formRetailSaleOrderBillInput.Tag = "Edit";
                    formRetailSaleOrderBillInput.Owner = this;
                    formRetailSaleOrderBillInput.ShowDialog();
                }
            }
        }

        private void contextDelete_Click(object sender, EventArgs e)
        {
            if (dgvSaleOrderBill.RowCount == 0)
            {
                return;
            }
            if (GlobalProperty.OperatorCode != dgvSaleOrderBill.CurrentRow.Cells["OperatorCode"].Value.ToString())
            {
                MessageBox.Show("非本记录的录入人员，不许允许删除！", "软件提示");
                return;
            }
            if (MessageBox.Show("确定要删除吗？", "软件提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                DataGridViewRow dgvr = dgvSaleOrderBill.CurrentRow;
                if (new Useful().IsExistConstraint("SaleOrderBill", dgvr.Cells["SaleBillNo"].Value.ToString()))
                {
                    MessageBox.Show("已发生业务关系，无法删除", "软件提示");
                    return;
                }
                dgvSaleOrderBill.Rows.Remove(dgvr);
                if (rsb.Delete(bsSaleOrderBill))
                {
                    MessageBox.Show("删除成功！", "软件提示");
                }
                else
                {
                    MessageBox.Show("删除失败！", "软件提示");
                }
            }
        }

        private void dgvSaleOrderBill_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            contextAmend_Click(sender, e);
        }

        private void chbIsAgent_CheckedChanged(object sender, EventArgs e)
        {
            if (chbIsAgent.Checked)
            {
                //显示用户名称为代理商
                cbxCustomerId.Visible = true;
                txtCustomerName.Visible = false;
                //相关控件禁用
                toolSave.Enabled = false;
                toolAmend.Enabled = false;
                toolDelete.Enabled = false;
                gbCustomerType.Visible = false;
                lbCustomerType.Visible = false;
                //
                useful.SetControlsState(groupBox1, false);
                //
                if (toolStrip1.Tag.ToString() == "Add")
                {
                    cbxCustomerId.Enabled = true;
                }              
            }
            else
            {
                //显示用户名为零售用户
                txtCustomerName.Visible = true;
                cbxCustomerId.Visible = false;
                //非代理商，在添加或修改操作状态下，相关控件是可用的。
                if (toolStrip1.Tag.ToString() == "Add" || toolStrip1.Tag.ToString() == "Edit")
                {
                    toolSave.Enabled = true;
                }
                gbCustomerType.Visible = true;
                lbCustomerType.Visible = true;
                useful.SetControlsState(groupBox1, true);
            }
        }

        private void cbxCustomerId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCustomerId.SelectedValue != null)
            {
                if (cbxCustomerId.SelectedValue.GetType() == typeof(int))
                {
                    m_CustomerNo = Convert.ToInt32(cbxCustomerId.SelectedValue);
                    DataTable dt = rc.GetDataTable("V_AgentRecord", " Where CustomerId = " + m_CustomerNo);
                    cbxProvinceCode.SelectedValue = dt.Rows[0]["ProvinceCode"];
                    txtAddress.Text = dt.Rows[0]["Address"].ToString();
                    txtPostalCode.Text = dt.Rows[0]["PostalCode"].ToString();
                    txtPhoneNumber.Text = dt.Rows[0]["PhoneNumber"].ToString();
                    txtURL.Text = dt.Rows[0]["URL"].ToString();
                    txtRemark.Text = dt.Rows[0]["Remark"].ToString();
                }
            }
        }
    }
}
