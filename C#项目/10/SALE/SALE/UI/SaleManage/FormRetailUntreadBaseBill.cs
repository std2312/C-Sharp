using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SALE.BLL.SaleManage;
using SALE.Common;

namespace SALE.UI.SaleManage
{
    public partial class FormRetailUntreadBaseBill : Form
    {
        RetailUntreadBaseBill rubb = new RetailUntreadBaseBill();

        public FormRetailUntreadBaseBill()
        {
            InitializeComponent();
        }

        private void FormRetailUntreadBaseBill_Load(object sender, EventArgs e)
        {
            ControlBindDataSource cbds = new ControlBindDataSource();
            cbds.DataGridViewComboBoxColumnBindDataSource(GoodsSeriesCode, "GoodsSeriesCode", "GoodsSeriesName", "Select * From GoodsSeries", "GoodsSeries");
            cbds.DataGridViewComboBoxColumnBindDataSource(GoodsTypeCode, "GoodsTypeCode", "GoodsTypeName", "Select * From GoodsType", "GoodsType");
            cbds.DataGridViewComboBoxColumnBindDataSource(EmployeeCode1, "EmployeeCode", "EmployeeName", "Select * From Employee", "Employee");
            cbds.DataGridViewComboBoxColumnBindDataSource(OperatorCode, "OperatorCode", "OperatorName", "Select * From Operator", "Operator");
            bsUntreadBaseBill.DataSource = rubb.GetDataTable("UntreadBaseBill", "Where UntreadBillNo is null");
            dgvUntreadBaseBill.DataSource = bsUntreadBaseBill;
            toolStrip1.Tag = "";
        }

        private void toolAdd_Click(object sender, EventArgs e)
        {
            FormRetailUntreadBaseBillInput formRetailUntreadBaseBillInput = new FormRetailUntreadBaseBillInput();
            formRetailUntreadBaseBillInput.Tag = "Add";
            formRetailUntreadBaseBillInput.Owner = this;
            formRetailUntreadBaseBillInput.ShowDialog();
        }

        private void toolAmend_Click(object sender, EventArgs e)
        {
            if (dgvUntreadBaseBill.RowCount > 0)
            {
                if (GlobalProperty.OperatorCode != dgvUntreadBaseBill.CurrentRow.Cells["OperatorCode"].Value.ToString())
                {
                    MessageBox.Show("非本记录的录入人员，不许允许修改！", "软件提示");
                    return;
                }
                FormRetailUntreadBaseBillInput formRetailUntreadBaseBillInput = new FormRetailUntreadBaseBillInput();
                formRetailUntreadBaseBillInput.Tag = "Edit";
                formRetailUntreadBaseBillInput.Owner = this;
                formRetailUntreadBaseBillInput.ShowDialog();
            }
        }

        private void toolBrowse_Click(object sender, EventArgs e)
        {
            FormBrowseRetailUntreadBaseBill formBrowseRetailUntreadBaseBill = new FormBrowseRetailUntreadBaseBill();
            formBrowseRetailUntreadBaseBill.Owner = this;
            formBrowseRetailUntreadBaseBill.ShowDialog();
        }

        private void toolDelete_Click(object sender, EventArgs e)
        {
            //删除时是否考虑光盘表？？？？
            if (dgvUntreadBaseBill.RowCount == 0)
            {
                return;
            }
            if (GlobalProperty.OperatorCode != dgvUntreadBaseBill.CurrentRow.Cells["OperatorCode"].Value.ToString())
            {
                MessageBox.Show("非本记录的录入人员，不许允许删除！", "软件提示");
                return;
            }
            if (MessageBox.Show("确定要删除吗？", "软件提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                List<string> strSqls = new List<string>();
                DataGridViewRow dgvr = dgvUntreadBaseBill.CurrentRow;
                if (new Useful().IsExistConstraint("UntreadBaseBill", dgvr.Cells["UntreadBillNo"].Value.ToString()))
                {
                    MessageBox.Show("已发生业务关系，无法删除", "软件提示");
                    return;
                }
                //string strUntreadCDRecordSql = "Delete  From UntreadCDRecord Where UntreadBillNo = '" + dgvr.Cells["UntreadBillNo"].Value.ToString() + "'";
                //strSqls.Add(strUntreadCDRecordSql);
                string strUntreadBaseBillSql = "Delete  From UntreadBaseBill Where UntreadBillNo = '" + dgvr.Cells["UntreadBillNo"].Value.ToString()+"'";
                strSqls.Add(strUntreadBaseBillSql);
                if (rubb.Delete(strSqls))
                {
                    //CurrencyManager cm = (CurrencyManager)BindingContext[dgvUntreadBaseBill.DataSource];
                    //cm.

                    //if (!cm.IsBindingSuspended)
                    //{
                    //    cm.SuspendBinding();
                    //    dgvr.Visible = false;
                    //}

                    dgvUntreadBaseBill.Rows.Remove(dgvr);

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

        private void dgvUntreadBaseBill_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            toolAmend_Click(sender, e);
        }
    }
}
