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
using SALE.DAL;

namespace SALE.UI.SystemSetting
{
    public partial class FormEmployeeInput : Form
    {
        FormEmployee formEmployee = null;
        Useful useful = new Useful();
        DataLogic dal = new DataLogic();
        string strEmployeeCode = null;

        public FormEmployeeInput()
        {
            InitializeComponent();
        }

        private void FormEmployeeInput_Load(object sender, EventArgs e)
        {
            formEmployee = (FormEmployee)this.Owner;
            if (this.Tag.ToString() == "Add")
            {
                strEmployeeCode = useful.BuildCode("Employee", "", "EmployeeCode", "", 2);
            }
            if (this.Tag.ToString() == "Edit")
            {
                txtEmployeeName.Text = formEmployee.dgvEmployee.CurrentRow.Cells["EmployeeName"].Value.ToString();
                txtRemark.Text = formEmployee.dgvEmployee.CurrentRow.Cells["Remark"].Value.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            if (String.IsNullOrEmpty(txtEmployeeName.Text.Trim()))
            {
                MessageBox.Show("人员名称不许为空！", "软件提示");
                txtEmployeeName.Focus();
                return;
            }
            if (this.Tag.ToString() == "Add")
            {
                DataGridViewRow dgvr = emp.AddDataGridViewRow(formEmployee.dgvEmployee, formEmployee.bsEmployee);
                dgvr.Cells["EmployeeCode"].Value = strEmployeeCode;
                dgvr.Cells["EmployeeName"].Value = txtEmployeeName.Text.Trim();
                dgvr.Cells["Remark"].Value = txtRemark.Text.Trim();
                if (emp.Insert(formEmployee.bsEmployee))
                {
                    if (MessageBox.Show("保存成功，是否继续添加？", "软件提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        strEmployeeCode = useful.BuildCode("Employee", "", "EmployeeCode", "", 2);
                        txtEmployeeName.Text = "";
                        txtRemark.Text = "";
                        txtEmployeeName.Focus();
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
                DataGridViewRow dgvr = formEmployee.dgvEmployee.CurrentRow;
                dgvr.Cells["EmployeeName"].Value = txtEmployeeName.Text.Trim();
                dgvr.Cells["Remark"].Value = txtRemark.Text.Trim();
                if (emp.Update(formEmployee.bsEmployee))
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
