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
    public partial class FormRetailUntreadGatherBill : Form
    {
        public FormRetailUntreadGatherBill()
        {
            InitializeComponent();
        }

        private void FormRetailUntreadGatherBill_Load(object sender, EventArgs e)
        {
            ControlBindDataSource cbds = new ControlBindDataSource();
            cbds.DataGridViewComboBoxColumnBindDataSource(GoodsTypeCode, "GoodsTypeCode", "GoodsTypeName", "Select * From GoodsType", "GoodsType");
            cbds.DataGridViewComboBoxColumnBindDataSource(GoodsSeriesCode, "GoodsSeriesCode", "GoodsSeriesName", "Select * From GoodsSeries", "GoodsSeries");
            cbds.DataGridViewComboBoxColumnBindDataSource(EmployeeCode2, "EmployeeCode", "EmployeeName", "Select * From Employee", "Employee");
            cbds.DataGridViewComboBoxColumnBindDataSource(OperatorCode, "OperatorCode", "OperatorName", "Select * From Operator", "Operator");
        }

        private void toolAdd_Click(object sender, EventArgs e)
        {
            FormRetailUntreadGatherBillInput formRetailUntreadGatherBillInput = new FormRetailUntreadGatherBillInput();
            formRetailUntreadGatherBillInput.Tag = "Add";
            formRetailUntreadGatherBillInput.Owner = this;
            formRetailUntreadGatherBillInput.ShowDialog();
        }

        private void toolAmend_Click(object sender, EventArgs e)
        {
            if (dgvUntreadGatherBill.RowCount > 0)
            {
                if (GlobalProperty.OperatorCode != dgvUntreadGatherBill.CurrentRow.Cells["OperatorCode"].Value.ToString())
                {
                    MessageBox.Show("非本记录的录入人员，不许允许修改！", "软件提示");
                    return;
                }
                FormRetailUntreadGatherBillInput formRetailUntreadGatherBillInput = new FormRetailUntreadGatherBillInput();
                formRetailUntreadGatherBillInput.Tag = "Edit";
                formRetailUntreadGatherBillInput.Owner = this;
                formRetailUntreadGatherBillInput.ShowDialog();
            }
        }

        private void toolBrowse_Click(object sender, EventArgs e)
        {
            FormBrowseRetailUntreadGatherBill formBrowseRetailUntreadGatherBill = new FormBrowseRetailUntreadGatherBill();
            formBrowseRetailUntreadGatherBill.Owner = this;
            formBrowseRetailUntreadGatherBill.ShowDialog();
        }

        private void toolDelete_Click(object sender, EventArgs e)
        {
            if (dgvUntreadGatherBill.RowCount == 0)
            {
                return;
            }
            if (GlobalProperty.OperatorCode != dgvUntreadGatherBill.CurrentRow.Cells["OperatorCode"].Value.ToString())
            {
                MessageBox.Show("非本记录的录入人员，不许允许删除！", "软件提示");
                return;
            }
            if (MessageBox.Show("确定要删除吗？", "软件提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                RetailUntreadGatherBill rugb = new RetailUntreadGatherBill();
                DataGridViewRow dgvr = dgvUntreadGatherBill.CurrentRow;
                int intId = Convert.ToInt32(dgvr.Cells["Id"].Value);
                String strSql = "Delete From UntreadGatherBill Where Id = " + intId;
                if (rugb.Delete(strSql))
                {
                    dgvUntreadGatherBill.Rows.Remove(dgvr);
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

        private void dgvUntreadGatherBill_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            toolAmend_Click(sender, e);
        }
    }
}
