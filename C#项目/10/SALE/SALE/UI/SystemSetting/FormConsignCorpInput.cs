using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SALE.BLL.SystemSetting;
using SALE.Common;
using SALE.DAL;

namespace SALE.UI.SystemSetting
{
    public partial class FormConsignCorpInput : Form
    {
        FormConsignCorp formConsignCorp = null;
        Useful useful = new Useful();
        DataLogic dal = new DataLogic();

        public FormConsignCorpInput()
        {
            InitializeComponent();
        }

        private void FormConsignCorpInput_Load(object sender, EventArgs e)
        {
            formConsignCorp = (FormConsignCorp)this.Owner;
            if (this.Tag.ToString() == "Add")
            {
                txtConsignCorpCode.Text = useful.BuildCode("ConsignCorp", "", "ConsignCorpCode", "", 2);
            }
            if (this.Tag.ToString() == "Edit")
            {
                txtConsignCorpCode.Text = formConsignCorp.dgvConsignCorp.CurrentRow.Cells["ConsignCorpCode"].Value.ToString();
                txtConsignCorpName.Text = formConsignCorp.dgvConsignCorp.CurrentRow.Cells["ConsignCorpName"].Value.ToString();
                txtLinkman.Text = formConsignCorp.dgvConsignCorp.CurrentRow.Cells["Linkman"].Value.ToString();
                txtPhoneNumber.Text = formConsignCorp.dgvConsignCorp.CurrentRow.Cells["PhoneNumber"].Value.ToString();
                txtAddress.Text = formConsignCorp.dgvConsignCorp.CurrentRow.Cells["Address"].Value.ToString();
                txtRemark.Text = formConsignCorp.dgvConsignCorp.CurrentRow.Cells["Remark"].Value.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ConsignCorp cc = new ConsignCorp();
            if (String.IsNullOrEmpty(txtConsignCorpName.Text.Trim()))
            {
                MessageBox.Show("公司名称不许为空！", "软件提示");
                txtConsignCorpName.Focus();
                return;
            }
            if (this.Tag.ToString() == "Add")
            {
                DataGridViewRow dgvr = cc.AddDataGridViewRow(formConsignCorp.dgvConsignCorp, formConsignCorp.bsConsignCorp);
                dgvr.Cells["ConsignCorpCode"].Value = txtConsignCorpCode.Text; 
                dgvr.Cells["ConsignCorpName"].Value = txtConsignCorpName.Text.Trim();
                dgvr.Cells["Linkman"].Value = txtLinkman.Text.Trim();
                dgvr.Cells["PhoneNumber"].Value = txtPhoneNumber.Text.Trim();
                dgvr.Cells["Address"].Value = txtAddress.Text.Trim();
                dgvr.Cells["Remark"].Value = txtRemark.Text.Trim();
                if (cc.Insert(formConsignCorp.bsConsignCorp))
                {
                    if (MessageBox.Show("保存成功，是否继续添加？", "软件提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        txtConsignCorpCode.Text = useful.BuildCode("ConsignCorp", "", "ConsignCorpCode", "", 2);
                        txtConsignCorpName.Text = "";
                        txtLinkman.Text = "";
                        txtPhoneNumber.Text = "";
                        txtAddress.Text = "";
                        txtRemark.Text = "";
                        txtConsignCorpName.Focus();
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
                DataGridViewRow dgvr = formConsignCorp.dgvConsignCorp.CurrentRow;
                dgvr.Cells["ConsignCorpName"].Value = txtConsignCorpName.Text.Trim();
                dgvr.Cells["Linkman"].Value = txtLinkman.Text.Trim();
                dgvr.Cells["PhoneNumber"].Value = txtPhoneNumber.Text.Trim();
                dgvr.Cells["Address"].Value = txtAddress.Text.Trim();
                dgvr.Cells["Remark"].Value = txtRemark.Text.Trim();
                if (cc.Update(formConsignCorp.bsConsignCorp))
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

        private void txtConsignCorpName_KeyDown(object sender, KeyEventArgs e)
        {
            useful.SetFocus(e, txtLinkman);
        }

        private void txtLinkman_KeyDown(object sender, KeyEventArgs e)
        {
            useful.SetFocus(e, txtPhoneNumber);
        }

        private void txtPhoneNumber_KeyDown(object sender, KeyEventArgs e)
        {
            useful.SetFocus(e, txtAddress);
        }

        private void txtAddress_KeyDown(object sender, KeyEventArgs e)
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
