using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SALE.Common;
using SALE.BLL.AgentManage;

namespace SALE.UI.AgentManage
{
    public partial class FormAgentRecordInput : Form
    {
        FormAgentRecord formAgentRecord = null;
        Useful useful = new Useful();

        public FormAgentRecordInput()
        {
            InitializeComponent();
        }

        private void FormAgentRecordInput_Load(object sender, EventArgs e)
        {
            ControlBindDataSource cbds = new ControlBindDataSource();
            cbds.ComboBoxBindDataSource(cbxProvinceCode, "ProvinceCode", "ProvinceName", "Select * From Province", "Province");
            formAgentRecord = (FormAgentRecord)this.Owner;
            if (this.Tag.ToString() == "Add")
            {
                cbxProvinceCode.SelectedIndex = -1;
                cbIsCancel.Checked = false; //添加是默认未取消
            }
            else
            { 
                txtCustomerName.Text = formAgentRecord.dgvAgentRecord.CurrentRow.Cells["CustomerName"].Value.ToString();
                txtJuridicalPerson.Text = formAgentRecord.dgvAgentRecord.CurrentRow.Cells["JuridicalPerson"].Value.ToString();
                txtPhoneNumber.Text = formAgentRecord.dgvAgentRecord.CurrentRow.Cells["PhoneNumber"].Value.ToString();
                cbxProvinceCode.SelectedValue = formAgentRecord.dgvAgentRecord.CurrentRow.Cells["ProvinceCode"].Value;
                txtAddress.Text = formAgentRecord.dgvAgentRecord.CurrentRow.Cells["Address"].Value.ToString();
                txtPostalCode.Text = formAgentRecord.dgvAgentRecord.CurrentRow.Cells["PostalCode"].Value.ToString();
                txtURL.Text = formAgentRecord.dgvAgentRecord.CurrentRow.Cells["URL"].Value.ToString();
                txtOpenAccBankName.Text = formAgentRecord.dgvAgentRecord.CurrentRow.Cells["OpenAccBankName"].Value.ToString();
                txtAccountNumber.Text = formAgentRecord.dgvAgentRecord.CurrentRow.Cells["AccountNumber"].Value.ToString();
                txtCertificateNumber.Text = formAgentRecord.dgvAgentRecord.CurrentRow.Cells["CertificateNumber"].Value.ToString();
                cbIsCancel.Checked = useful.GetCheckedValue(formAgentRecord.dgvAgentRecord.CurrentRow.Cells["IsCancel"].Value.ToString());
                txtRemark.Text = formAgentRecord.dgvAgentRecord.CurrentRow.Cells["Remark"].Value.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AgentRecord ar = new AgentRecord();
            if (String.IsNullOrEmpty(txtCustomerName.Text.Trim()))
            {
                MessageBox.Show("代理商名称不许为空！", "软件提示");
                txtCustomerName.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtJuridicalPerson.Text.Trim()))
            {
                MessageBox.Show("法人不许为空！", "软件提示");
                txtJuridicalPerson.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtPhoneNumber.Text.Trim()))
            {
                MessageBox.Show("联系电话不许为空！", "软件提示");
                txtPhoneNumber.Focus();
                return;
            }
            if (cbxProvinceCode.SelectedValue==null)
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

            if (this.Tag.ToString() == "Add")
            {
                DataGridViewRow dgvr = ar.AddDataGridViewRow(formAgentRecord.dgvAgentRecord,formAgentRecord.bsAgentRecord);
                dgvr.Cells["CustomerName"].Value = txtCustomerName.Text.Trim();
                dgvr.Cells["JuridicalPerson"].Value = txtJuridicalPerson.Text.Trim();
                dgvr.Cells["PhoneNumber"].Value = txtPhoneNumber.Text.Trim();
                dgvr.Cells["ProvinceCode"].Value = cbxProvinceCode.SelectedValue;
                dgvr.Cells["Address"].Value = txtAddress.Text.Trim();
                dgvr.Cells["PostalCode"].Value = txtPostalCode.Text.Trim();
                dgvr.Cells["URL"].Value = txtURL.Text.Trim();
                dgvr.Cells["OpenAccBankName"].Value = txtOpenAccBankName.Text.Trim();
                dgvr.Cells["AccountNumber"].Value = txtAccountNumber.Text.Trim();
                dgvr.Cells["CertificateNumber"].Value = txtCertificateNumber.Text.Trim();
                dgvr.Cells["IsCancel"].Value = useful.GetFlagValue(cbIsCancel);
                dgvr.Cells["CustomerType"].Value = "1";//代理商类型为1，默认值，不许修改的
                dgvr.Cells["Remark"].Value = txtRemark.Text.Trim();
                dgvr.Cells["OperatorCode"].Value = GlobalProperty.OperatorCode;
                if (ar.Insert(formAgentRecord.dgvAgentRecord,formAgentRecord.bsAgentRecord))
                {
                    formAgentRecord.bsAgentRecord.DataSource = ar.GetDataTable("Customer", " Where CustomerType = '1'");
                    formAgentRecord.dgvAgentRecord.DataSource = formAgentRecord.bsAgentRecord;
                    //formAgentRecord.bsAgentRecord.CancelEdit();//取消当前的编辑操作。 
                    if (MessageBox.Show("保存成功，是否继续添加？", "软件提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        txtCustomerName.Text = "";
                        txtJuridicalPerson.Text = "";
                        txtPhoneNumber.Text = "";
                        cbxProvinceCode.SelectedIndex = -1;
                        txtAddress.Text = "";
                        txtPostalCode.Text = "";
                        txtURL.Text = "";
                        txtOpenAccBankName.Text = "";
                        txtAccountNumber.Text = "";
                        txtCertificateNumber.Text = "";
                        cbIsCancel.Checked = false; //表示不取消代理
                        txtRemark.Text = "";
                        txtCustomerName.Focus();
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("保存失败！", "软件提示");
                }
            }
            if (this.Tag.ToString() == "Edit")
            {
                DataGridViewRow dgvr = formAgentRecord.dgvAgentRecord.CurrentRow;
                dgvr.Cells["CustomerName"].Value = txtCustomerName.Text.Trim();
                dgvr.Cells["JuridicalPerson"].Value = txtJuridicalPerson.Text.Trim();
                dgvr.Cells["PhoneNumber"].Value = txtPhoneNumber.Text.Trim();
                dgvr.Cells["ProvinceCode"].Value = cbxProvinceCode.SelectedValue;
                dgvr.Cells["Address"].Value = txtAddress.Text.Trim();
                dgvr.Cells["PostalCode"].Value = txtPostalCode.Text.Trim();
                dgvr.Cells["URL"].Value = txtURL.Text.Trim();
                dgvr.Cells["OpenAccBankName"].Value = txtOpenAccBankName.Text.Trim();
                dgvr.Cells["AccountNumber"].Value = txtAccountNumber.Text.Trim();
                dgvr.Cells["CertificateNumber"].Value = txtCertificateNumber.Text.Trim();
                dgvr.Cells["IsCancel"].Value = useful.GetFlagValue(cbIsCancel);
                //dgvr.Cells["CustomerType"].Value = "1";//代理商类型为1,默认值，不许修改
                dgvr.Cells["Remark"].Value = txtRemark.Text.Trim();
                //dgvr.Cells["OperatorCode"].Value = GlobalProperty.OperatorCode;
                if (ar.Update(formAgentRecord.bsAgentRecord))
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

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPostalCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            useful.InputInteger(e);
        }

        private void txtCustomerName_KeyDown(object sender, KeyEventArgs e)
        {
            useful.SetFocus(e,txtJuridicalPerson);
        }

        private void txtJuridicalPerson_KeyDown(object sender, KeyEventArgs e)
        {
            useful.SetFocus(e, txtPhoneNumber);
        }

        private void txtPhoneNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cbxProvinceCode.Focus();
                cbxProvinceCode.DroppedDown = true;
            }
        }

        private void cbxProvinceCode_KeyDown(object sender, KeyEventArgs e)
        {
            useful.SetFocus(e, txtAddress);
        }

        private void txtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            useful.SetFocus(e, txtPostalCode);
        }

        private void txtPostalCode_KeyDown(object sender, KeyEventArgs e)
        {
            useful.SetFocus(e, txtURL);
        }

        private void txtURL_KeyDown(object sender, KeyEventArgs e)
        {
            useful.SetFocus(e, txtOpenAccBankName);
        }

        private void txtOpenAccBankName_KeyDown(object sender, KeyEventArgs e)
        {
            useful.SetFocus(e, txtAccountNumber);
        }

        private void txtAccountNumber_KeyDown(object sender, KeyEventArgs e)
        {
            useful.SetFocus(e, txtCertificateNumber);
        }

        private void txtCertificateNumber_KeyDown(object sender, KeyEventArgs e)
        {
            useful.SetFocus(e, txtRemark);
        }

        private void txtRemark_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click(sender, e);
            }
        }
    }
}
