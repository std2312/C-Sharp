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
    public partial class FormRetailSaleConsignBill : Form
    {
        RetailSaleConsignBill rscb = new RetailSaleConsignBill();

        public FormRetailSaleConsignBill()
        {
            InitializeComponent();
        }

        private void FormRetailSaleConsignBill_Load(object sender, EventArgs e)
        {
            ControlBindDataSource cbds = new ControlBindDataSource();
            //销售订单
            cbds.DataGridViewComboBoxColumnBindDataSource(GoodsTypeCode1, "GoodsTypeCode", "GoodsTypeName", "Select * From GoodsType", "GoodsType");
            cbds.DataGridViewComboBoxColumnBindDataSource(GoodsSeriesCode1, "GoodsSeriesCode", "GoodsSeriesName", "Select * From GoodsSeries", "GoodsSeries");
            cbds.DataGridViewComboBoxColumnBindDataSource(ConsignCorpCode, "ConsignCorpCode", "ConsignCorpName", "Select * From ConsignCorp", "ConsignCorp");
            cbds.DataGridViewComboBoxColumnBindDataSource(EmployeeCode4, "EmployeeCode", "EmployeeName", "Select * From Employee", "Employee");
            cbds.DataGridViewComboBoxColumnBindDataSource(OperatorCode, "OperatorCode", "OperatorName", "Select * From Operator", "Operator");
            //空绑定
            bsSaleConsignBill.DataSource = rscb.GetDataTable("SaleConsignBill", "Where SaleBillNo is null");
            dgvSaleConsignBill.DataSource = bsSaleConsignBill;
            toolStrip1.Tag = "";
        }

        private void toolAdd_Click(object sender, EventArgs e)
        {
            FormRetailSaleConsignBillInput formRetailSaleConsignBillInput = new FormRetailSaleConsignBillInput();
            formRetailSaleConsignBillInput.Tag = "Add";
            formRetailSaleConsignBillInput.Owner = this;
            formRetailSaleConsignBillInput.ShowDialog();
        }

        private void toolAmend_Click(object sender, EventArgs e)
        {
            if (dgvSaleConsignBill.RowCount > 0)
            {
                if (GlobalProperty.OperatorCode != dgvSaleConsignBill.CurrentRow.Cells["OperatorCode"].Value.ToString())
                {
                    MessageBox.Show("非本记录的录入人员，不许允许修改！", "软件提示");
                    return;
                }
                FormRetailSaleConsignBillInput formRetailSaleConsignBillInput = new FormRetailSaleConsignBillInput();
                formRetailSaleConsignBillInput.Tag = "Edit";
                formRetailSaleConsignBillInput.Owner = this;
                formRetailSaleConsignBillInput.ShowDialog();
            }
        }

        private void toolBrowse_Click(object sender, EventArgs e)
        {
            FormBrowseRetailSaleConsignBill formBrowseRetailSaleConsignBill = new FormBrowseRetailSaleConsignBill();
            formBrowseRetailSaleConsignBill.Owner = this;
            formBrowseRetailSaleConsignBill.ShowDialog();
        }

        private void toolDelete_Click(object sender, EventArgs e)
        {
            //删除时是否考虑光盘表
            if (dgvSaleConsignBill.RowCount == 0)
            {
                return;
            }
            if (GlobalProperty.OperatorCode != dgvSaleConsignBill.CurrentRow.Cells["OperatorCode"].Value.ToString())
            {
                MessageBox.Show("非本记录的录入人员，不许允许删除！", "软件提示");
                return;
            }
            if (MessageBox.Show("确定要删除吗？", "软件提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                List<string> strSqls = new List<string>();
                DataGridViewRow dgvr = dgvSaleConsignBill.CurrentRow;
                if (new Useful().IsExistConstraint("SaleConsignBill", dgvr.Cells["Id"].Value.ToString()))
                {
                    MessageBox.Show("已发生业务关系，无法删除", "软件提示");
                    return;
                }
                //string strSaleCDRecordSql = "Delete  From SaleCDRecord Where SaleConsignBillId = " + Convert.ToInt32(dgvr.Cells["Id"].Value);
                //strSqls.Add(strSaleCDRecordSql);
                string strSaleConsignBillSql = "Delete  From SaleConsignBill Where Id = " + Convert.ToInt32(dgvr.Cells["Id"].Value);
                strSqls.Add(strSaleConsignBillSql);
                if (rscb.Delete(strSqls))
                {
                    dgvSaleConsignBill.Rows.Remove(dgvr);
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

        private void contextQuery_Click(object sender, EventArgs e)
        {
            toolBrowse_Click(sender, e);
        }

        private void contextDelete_Click(object sender, EventArgs e)
        {
            toolDelete_Click(sender, e);
        }

        private void dgvSaleConsignBill_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            toolAmend_Click(sender, e);
        }
    }
}
