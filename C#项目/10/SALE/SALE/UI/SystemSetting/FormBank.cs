using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SALE.BLL.SystemSetting;

namespace SALE.UI.SystemSetting
{
    public partial class FormBank : Form
    {
        Bank bank = new Bank();

        public FormBank()
        {
            InitializeComponent();
        }

        private void FormBank_Load(object sender, EventArgs e)
        {
            bsBank.DataSource = bank.GetDataTable("Bank", "");
            dgvBank.DataSource = bsBank;
        }

        private void toolAdd_Click(object sender, EventArgs e)
        {
            FormBankInput formBankInput = new FormBankInput();
            formBankInput.Tag = "Add";
            formBankInput.Owner = this;
            formBankInput.ShowDialog();
        }

        private void toolAmend_Click(object sender, EventArgs e)
        {
            if (dgvBank.RowCount > 0)
            {
                FormBankInput formBankInput = new FormBankInput();
                formBankInput.Tag = "Edit";
                formBankInput.Owner = this;
                formBankInput.ShowDialog();
            }
        }

        private void toolDelete_Click(object sender, EventArgs e)
        {
            if (dgvBank.RowCount < 0)
            {
                return;
            }
            if (MessageBox.Show("确定要删除吗？", "软件提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                DataGridViewRow dgvr = dgvBank.CurrentRow;
                dgvBank.Rows.Remove(dgvr);
                if (bank.Delete(bsBank))
                {
                    MessageBox.Show("删除成功！", "软件提示");
                }
                else
                {
                    MessageBox.Show("删除失败！", "软件提示");
                }
            }
        }

        private void toolExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvBank_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBank.RowCount > 0)
            {
                toolAmend_Click(sender, e);
            }
        }
    }
}
