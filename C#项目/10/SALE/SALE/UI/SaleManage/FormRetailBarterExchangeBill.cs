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
    public partial class FormRetailBarterExchangeBill : Form
    {
        public FormRetailBarterExchangeBill()
        {
            InitializeComponent();
        }

        private void FormRetailBarterExchangeBill_Load(object sender, EventArgs e)
        {
            ControlBindDataSource cbds = new ControlBindDataSource();
            cbds.DataGridViewComboBoxColumnBindDataSource(PayTypeCode, "PayTypeCode", "PayTypeName", "Select * From PayType", "PayType");
            cbds.DataGridViewComboBoxColumnBindDataSource(BankCode, "BankCode", "BankName", "Select * From Bank", "Bank");
            cbds.DataGridViewComboBoxColumnBindDataSource(EmployeeCode2, "EmployeeCode", "EmployeeName", "Select * From Employee", "Employee");
            cbds.DataGridViewComboBoxColumnBindDataSource(OperatorCode, "OperatorCode", "OperatorName", "Select * From Operator", "Operator");
        }

        private void toolAdd_Click(object sender, EventArgs e)
        {
            FormRetailBarterExchangeBillInput formRetailBarterExchangeBillInput = new FormRetailBarterExchangeBillInput();
            formRetailBarterExchangeBillInput.Tag = "Add";
            formRetailBarterExchangeBillInput.Owner = this;
            formRetailBarterExchangeBillInput.ShowDialog();
        }

        private void toolAmend_Click(object sender, EventArgs e)
        {
            if (dgvBarterExchangeBill.RowCount > 0)
            {
                if (GlobalProperty.OperatorCode != dgvBarterExchangeBill.CurrentRow.Cells["OperatorCode"].Value.ToString())
                {
                    MessageBox.Show("非本记录的录入人员，不许允许修改！", "软件提示");
                    return;
                }
                FormRetailBarterExchangeBillInput formRetailBarterExchangeBillInput = new FormRetailBarterExchangeBillInput();
                formRetailBarterExchangeBillInput.Tag = "Edit";
                formRetailBarterExchangeBillInput.Owner = this;
                formRetailBarterExchangeBillInput.ShowDialog();
            }
        }

        private void toolBrowse_Click(object sender, EventArgs e)
        {
            FormBrowseRetailBarterExchangeBill formBrowseRetailBarterExchangeBill = new FormBrowseRetailBarterExchangeBill();
            formBrowseRetailBarterExchangeBill.Owner = this;
            formBrowseRetailBarterExchangeBill.ShowDialog();
        }

        private void toolDelete_Click(object sender, EventArgs e)
        {
            if (dgvBarterExchangeBill.RowCount == 0)
            {
                return;
            }
            if (GlobalProperty.OperatorCode != dgvBarterExchangeBill.CurrentRow.Cells["OperatorCode"].Value.ToString())
            {
                MessageBox.Show("非本记录的录入人员，不许允许删除！", "软件提示");
                return;
            }
            if (MessageBox.Show("确定要删除吗？", "软件提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                RetailBarterExchangeBill rbeb = new RetailBarterExchangeBill();
                DataGridViewRow dgvr = dgvBarterExchangeBill.CurrentRow;
                int intId = Convert.ToInt32(dgvr.Cells["Id"].Value);
                String strSql = "Delete From BarterExchangeBill Where BarterExchangeBill.Id = " + intId;
                if (rbeb.Delete(strSql))
                {
                    dgvBarterExchangeBill.Rows.Remove(dgvr);
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

        private void dgvBarterExchangeBill_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            toolAmend_Click(sender, e);
        }

        private void dgvBarterExchangeBill_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            toolAmend_Click(sender, e);
        }
    }
}
