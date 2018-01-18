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
    public partial class FormRetailBarterConsignBill : Form
    {
        public FormRetailBarterConsignBill()
        {
            InitializeComponent();
        }

        private void FormRetailBarterConsignBill_Load(object sender, EventArgs e)
        {
            ControlBindDataSource cbds = new ControlBindDataSource();
            cbds.DataGridViewComboBoxColumnBindDataSource(GoodsTypeCode, "GoodsTypeCode", "GoodsTypeName", "Select * From GoodsType", "GoodsType");
            cbds.DataGridViewComboBoxColumnBindDataSource(GoodsSeriesCode, "GoodsSeriesCode", "GoodsSeriesName", "Select * From GoodsSeries", "GoodsSeries");
            cbds.DataGridViewComboBoxColumnBindDataSource(EmployeeCode3, "EmployeeCode", "EmployeeName", "Select * From Employee", "Employee");
            cbds.DataGridViewComboBoxColumnBindDataSource(OperatorCode, "OperatorCode", "OperatorName", "Select * From Operator", "Operator");
            cbds.DataGridViewComboBoxColumnBindDataSource(ConsignCorpCode, "ConsignCorpCode", "ConsignCorpName", "Select * From ConsignCorp", "ConsignCorp");
        }

        private void toolAdd_Click(object sender, EventArgs e)
        {
            FormRetailBarterConsignBillInput formRetailBarterConsignBillInput = new FormRetailBarterConsignBillInput();
            formRetailBarterConsignBillInput.Tag = "Add";
            formRetailBarterConsignBillInput.Owner = this;
            formRetailBarterConsignBillInput.ShowDialog();
        }

        private void toolAmend_Click(object sender, EventArgs e)
        {
            if (dgvBarterConsignBill.RowCount > 0)
            {
                if (GlobalProperty.OperatorCode != dgvBarterConsignBill.CurrentRow.Cells["OperatorCode"].Value.ToString())
                {
                    MessageBox.Show("非本记录的录入人员，不许允许修改！", "软件提示");
                    return;
                }
                FormRetailBarterConsignBillInput formRetailBarterConsignBillInput = new FormRetailBarterConsignBillInput();
                formRetailBarterConsignBillInput.Tag = "Edit";
                formRetailBarterConsignBillInput.Owner = this;
                formRetailBarterConsignBillInput.ShowDialog();
            }
        }

        private void toolBrowse_Click(object sender, EventArgs e)
        {
            FormBrowseRetailBarterConsignBill formBrowseRetailBarterConsignBill = new FormBrowseRetailBarterConsignBill();
            formBrowseRetailBarterConsignBill.Owner = this;
            formBrowseRetailBarterConsignBill.ShowDialog();
        }

        private void toolDelete_Click(object sender, EventArgs e)
        {
            if (dgvBarterConsignBill.RowCount == 0)
            {
                return;
            }
            if (GlobalProperty.OperatorCode != dgvBarterConsignBill.CurrentRow.Cells["OperatorCode"].Value.ToString())
            {
                MessageBox.Show("非本记录的录入人员，不许允许删除！", "软件提示");
                return;
            }
            if (MessageBox.Show("确定要删除吗？", "软件提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                RetailBarterConsignBill rbcb = new RetailBarterConsignBill();
                DataGridViewRow dgvr = dgvBarterConsignBill.CurrentRow;
                int intId = Convert.ToInt32(dgvr.Cells["Id"].Value);
                if (new Useful().IsExistConstraint("BarterConsignBill", intId.ToString()))
                {
                    MessageBox.Show("已发生业务关系，无法删除", "软件提示");
                    return;
                }
                String strSql = "Delete From BarterConsignBill Where BarterConsignBill.Id = " + intId;
                if (rbcb.Delete(strSql))
                {
                    dgvBarterConsignBill.Rows.Remove(dgvr);
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

        private void dgvBarterConsignBill_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            toolAmend_Click(sender, e);
        }
    }
}
