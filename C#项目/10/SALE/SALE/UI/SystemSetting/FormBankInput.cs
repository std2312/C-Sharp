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

namespace SALE.UI.SystemSetting
{
    public partial class FormBankInput : Form
    {
        Useful useful = new Useful();
        FormBank formBank = new FormBank();

        public FormBankInput()
        {
            InitializeComponent();
        }

        private void FormBankInput_Load(object sender, EventArgs e)
        {
            formBank = (FormBank)this.Owner;
            if (this.Tag.ToString() == "Add")
            {
                txtBankCode.Text = useful.BuildCode("Bank", "", "BankCode", "", 2);
            }
            if (this.Tag.ToString() == "Edit")
            {
                txtBankCode.Text = formBank.dgvBank.CurrentRow.Cells["BankCode"].Value.ToString();
                txtBankName.Text = formBank.dgvBank.CurrentRow.Cells["BankName"].Value.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Bank bank = new Bank();
            if (String.IsNullOrEmpty(txtBankName.Text.Trim()))
            {
                MessageBox.Show("银行名称不许为空！", "软件提示");
                txtBankName.Focus();
                return;
            }
            if (this.Tag.ToString() == "Add")
            {
                DataGridViewRow dgvr = bank.AddDataGridViewRow(formBank.dgvBank, formBank.bsBank);
                dgvr.Cells["BankCode"].Value = txtBankCode.Text;
                dgvr.Cells["BankName"].Value = txtBankName.Text.Trim();
                if (bank.Insert(formBank.bsBank))
                {
                    if (MessageBox.Show("保存成功，是否继续添加？", "软件提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        txtBankCode.Text = useful.BuildCode("Bank", "", "BankCode", "", 2);
                        txtBankName.Text = "";
                        txtBankName.Focus();
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
                DataGridViewRow dgvr = formBank.dgvBank.CurrentRow;
                dgvr.Cells["BankName"].Value = txtBankName.Text.Trim();
                if (bank.Update(formBank.bsBank))
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
    }
}
