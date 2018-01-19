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
    public partial class FormEmployee : Form
    {
        Employee emp = new Employee();

        public FormEmployee()
        {
            InitializeComponent();
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            bsEmployee.DataSource = emp.GetDataTable("Employee", "");
            dgvEmployee.DataSource = bsEmployee;
        }

        private void toolAdd_Click(object sender, EventArgs e)
        {
            FormEmployeeInput formEmployeeInput = new FormEmployeeInput();
            formEmployeeInput.Tag = "Add";
            formEmployeeInput.Owner = this;
            formEmployeeInput.ShowDialog();
        }

        private void toolAmend_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.RowCount > 0)
            {
                FormEmployeeInput formEmployeeInput = new FormEmployeeInput();
                formEmployeeInput.Tag = "Edit";
                formEmployeeInput.Owner = this;
                formEmployeeInput.ShowDialog();
            }
        }

        private void toolDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.RowCount == 0)
            {
                return;
            }
            if (MessageBox.Show("确定要删除吗？", "软件提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                DataGridViewRow dgvr = dgvEmployee.CurrentRow;
                if (new Useful().IsExistConstraint("Employee", dgvr.Cells["EmployeeCode"].Value.ToString()))
                {
                    MessageBox.Show("已发生业务关系，无法删除", "软件提示");
                    return;
                }
                dgvEmployee.Rows.Remove(dgvr);
                if (emp.Delete(bsEmployee))
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

        private void dgvEmployee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEmployee.RowCount > 0)
            {
                toolAmend_Click(sender, e);
            }
        }
    }
}
