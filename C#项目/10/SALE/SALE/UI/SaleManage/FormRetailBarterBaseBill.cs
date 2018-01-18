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
    public partial class FormRetailBarterBaseBill : Form
    {
        public FormRetailBarterBaseBill()
        {
            InitializeComponent();
        }

        private void FormRetailBarterBaseBill_Load(object sender, EventArgs e)
        {
            ControlBindDataSource cbds = new ControlBindDataSource();
            cbds.DataGridViewComboBoxColumnBindDataSource(GoodsTypeCode, "GoodsTypeCode", "GoodsTypeName", "Select * From GoodsType", "GoodsType");
            cbds.DataGridViewComboBoxColumnBindDataSource(GoodsSeriesCode, "GoodsSeriesCode", "GoodsSeriesName", "Select * From GoodsSeries", "GoodsSeries");
            cbds.DataGridViewComboBoxColumnBindDataSource(GoodsTypeCode1, "GoodsTypeCode", "GoodsTypeName", "Select * From GoodsType", "GoodsType");
            cbds.DataGridViewComboBoxColumnBindDataSource(GoodsSeriesCode1, "GoodsSeriesCode", "GoodsSeriesName", "Select * From GoodsSeries", "GoodsSeries");
            cbds.DataGridViewComboBoxColumnBindDataSource(EmployeeCode1, "EmployeeCode", "EmployeeName", "Select * From Employee", "Employee");
            cbds.DataGridViewComboBoxColumnBindDataSource(OperatorCode, "OperatorCode", "OperatorName", "Select * From Operator", "Operator");
        }

        private void toolAdd_Click(object sender, EventArgs e)
        {
            FormRetailBarterBaseBillInput formRetailBarterBaseBillInput = new FormRetailBarterBaseBillInput();
            formRetailBarterBaseBillInput.Tag = "Add";
            formRetailBarterBaseBillInput.Owner = this;
            formRetailBarterBaseBillInput.ShowDialog();
        }

        private void toolAmend_Click(object sender, EventArgs e)
        {
            if (dgvBarterBaseBill.RowCount > 0)
            {
                if (GlobalProperty.OperatorCode != dgvBarterBaseBill.CurrentRow.Cells["OperatorCode"].Value.ToString())
                {
                    MessageBox.Show("非本记录的录入人员，不许允许修改！", "软件提示");
                    return;
                }
                FormRetailBarterBaseBillInput formRetailBarterBaseBillInput = new FormRetailBarterBaseBillInput();
                formRetailBarterBaseBillInput.Tag = "Edit";
                formRetailBarterBaseBillInput.Owner = this;
                formRetailBarterBaseBillInput.ShowDialog();
            }
        }

        private void toolBrowse_Click(object sender, EventArgs e)
        {
            FormBrowseRetailBarterBaseBill formBrowseRetailBarterBaseBill = new FormBrowseRetailBarterBaseBill();
            formBrowseRetailBarterBaseBill.Owner = this;
            formBrowseRetailBarterBaseBill.ShowDialog();
        }

        private void toolDelete_Click(object sender, EventArgs e)
        {
            if (dgvBarterBaseBill.RowCount == 0)
            {
                return;
            }
            if (GlobalProperty.OperatorCode != dgvBarterBaseBill.CurrentRow.Cells["OperatorCode"].Value.ToString())
            {
                MessageBox.Show("非本记录的录入人员，不许允许删除！", "软件提示");
                return;
            }
            if (MessageBox.Show("确定要删除吗？", "软件提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                List<string> strSqls = new List<string>();
                RetailBarterBaseBill rbbb = new RetailBarterBaseBill();
                DataGridViewRow dgvr = dgvBarterBaseBill.CurrentRow;
                if (new Useful().IsExistConstraint("BarterBaseBill", dgvr.Cells["BarterBillNo"].Value.ToString()))
                {
                    MessageBox.Show("已发生业务关系，无法删除", "软件提示");
                    return;
                }
                //string strBarterBaseCDRecordSql = "Delete  From BarterBaseCDRecord Where BarterBillNo = '" + dgvr.Cells["BarterBillNo"].Value.ToString() + "'";
                //strSqls.Add(strBarterBaseCDRecordSql);
                string strBarterBaseBillSql = "Delete  From BarterBaseBill Where BarterBillNo = '" + dgvr.Cells["BarterBillNo"].Value.ToString() + "'";
                strSqls.Add(strBarterBaseBillSql);
                if (rbbb.Delete(strSqls))
                {
                    dgvBarterBaseBill.Rows.Remove(dgvr);
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

        private void dgvBarterBaseBill_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            toolAmend_Click(sender, e);
        }
    }
}
