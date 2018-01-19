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
    public partial class FormRetailSaleTradeBill : Form
    {
        RetailSaleTradeBill rstb = new RetailSaleTradeBill();

        public FormRetailSaleTradeBill()
        {
            InitializeComponent();
        }

        private void FormRetailSaleTradeBill_Load(object sender, EventArgs e)
        {
            ControlBindDataSource cbds = new ControlBindDataSource();
            //销售订单
            cbds.DataGridViewComboBoxColumnBindDataSource(PayTypeCode, "PayTypeCode", "PayTypeName", "Select * From PayType", "PayType");
            cbds.DataGridViewComboBoxColumnBindDataSource(BankCode, "BankCode", "BankName", "Select * From Bank", "Bank");
            cbds.DataGridViewComboBoxColumnBindDataSource(EmployeeCode1, "EmployeeCode", "EmployeeName", "Select * From Employee", "Employee");
            cbds.DataGridViewComboBoxColumnBindDataSource(EmployeeCode2, "EmployeeCode", "EmployeeName", "Select * From Employee", "Employee");
            cbds.DataGridViewComboBoxColumnBindDataSource(EmployeeCode3, "EmployeeCode", "EmployeeName", "Select * From Employee", "Employee");
            cbds.DataGridViewComboBoxColumnBindDataSource(OperatorCode, "OperatorCode", "OperatorName", "Select * From Operator", "Operator");
            //空绑定
            bsSaleTradeBill.DataSource = rstb.GetDataTable("SaleTradeBill", "Where SaleBillNo is null");
            dgvSaleTradeBill.DataSource = bsSaleTradeBill;
            toolStrip1.Tag = "";
        }

        private void toolAdd_Click(object sender, EventArgs e)
        {
            FormRetailSaleTradeBillInput formRetailSaleTradeBillInput = new FormRetailSaleTradeBillInput();
            formRetailSaleTradeBillInput.Tag = "Add";
            formRetailSaleTradeBillInput.Owner = this;
            formRetailSaleTradeBillInput.ShowDialog();
        }

        private void toolAmend_Click(object sender, EventArgs e)
        {
            if (dgvSaleTradeBill.RowCount > 0)
            {
                if (GlobalProperty.OperatorCode != dgvSaleTradeBill.CurrentRow.Cells["OperatorCode"].Value.ToString())
                {
                    MessageBox.Show("非本记录的录入人员，不许允许修改！", "软件提示");
                    return;
                }
                FormRetailSaleTradeBillInput formRetailSaleTradeBillInput = new FormRetailSaleTradeBillInput();
                formRetailSaleTradeBillInput.Tag = "Edit";
                formRetailSaleTradeBillInput.Owner = this;
                formRetailSaleTradeBillInput.ShowDialog();
            }
        }

        private void toolBrowse_Click(object sender, EventArgs e)
        {
            FormBrowseRetailSaleTradeBill formBrowseRetailSaleTradeBill = new FormBrowseRetailSaleTradeBill();
            formBrowseRetailSaleTradeBill.Owner = this;
            formBrowseRetailSaleTradeBill.ShowDialog();
        }

        private void toolDelete_Click(object sender, EventArgs e)
        {
            if (dgvSaleTradeBill.RowCount == 0)
            {
                return;
            }
            if (GlobalProperty.OperatorCode != dgvSaleTradeBill.CurrentRow.Cells["OperatorCode"].Value.ToString())
            {
                MessageBox.Show("非本记录的录入人员，不许允许删除！", "软件提示");
                return;
            }
            if (MessageBox.Show("确定要删除吗？", "软件提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                DataGridViewRow dgvr = dgvSaleTradeBill.CurrentRow;
                dgvSaleTradeBill.Rows.Remove(dgvr);
                if (rstb.Delete(bsSaleTradeBill))
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

        private void contextAdd_Click(object sender, EventArgs e)
        {
            toolAdd_Click(sender, e);
        }

        private void contextAmend_Click(object sender, EventArgs e)
        {
            toolAmend_Click(sender, e);
        }

        private void contextDelete_Click(object sender, EventArgs e)
        {
            toolDelete_Click(sender, e);
        }

        private void contextQuery_Click(object sender, EventArgs e)
        {
            toolBrowse_Click(sender, e);
        }

        private void dgvSaleTradeBill_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            toolAmend_Click(sender, e);
        }
    }
}
