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
    public partial class FormOperator : Form
    {
        Useful useful = new Useful();
        Operator oper = new Operator();

        public FormOperator()
        {
            InitializeComponent();
        }

        private void FormOperator_Load(object sender, EventArgs e)
        {
            bsOperator.DataSource = oper.GetDataTable("Operator","");
            dgvOperator.DataSource = bsOperator;
        }

        private void toolAdd_Click(object sender, EventArgs e)
        {
            useful.ShowDialogForm(typeof(FormOperatorInput), "Add", this);
        }

        private void toolAmend_Click(object sender, EventArgs e)
        {
            if (dgvOperator.RowCount > 0)
            {
                useful.ShowDialogForm(typeof(FormOperatorInput), "Edit", this);
            }
        }

        private void toolDelete_Click(object sender, EventArgs e)
        {
            if (dgvOperator.RowCount == 0 || dgvOperator.CurrentRow.Cells["IsFlag"].Value.ToString() == "1")
            {
                return;
            }
            if (MessageBox.Show("确定要删除吗？", "软件提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                DataGridViewRow dgvr = dgvOperator.CurrentRow;
                if (new Useful().IsExistConstraint("Operator", dgvr.Cells["OperatorCode"].Value.ToString()))
                {
                    MessageBox.Show("已发生业务关系，无法删除", "软件提示");
                    return;
                }
                dgvOperator.Rows.Remove(dgvr);
                if (oper.Delete(bsOperator))
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

        private void dgvOperator_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            toolAmend_Click(sender, e);
        }


    }
}
