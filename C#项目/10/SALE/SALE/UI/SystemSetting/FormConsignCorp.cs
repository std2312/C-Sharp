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
    public partial class FormConsignCorp : Form
    {
        ConsignCorp cc = new ConsignCorp();

        public FormConsignCorp()
        {
            InitializeComponent();
        }

        private void FormConsignCorp_Load(object sender, EventArgs e)
        {
            bsConsignCorp.DataSource = cc.GetDataTable("ConsignCorp", "");
            dgvConsignCorp.DataSource = bsConsignCorp;
        }

        private void toolAdd_Click(object sender, EventArgs e)
        {
            FormConsignCorpInput formConsignCorpInput = new FormConsignCorpInput();
            formConsignCorpInput.Tag = "Add";
            formConsignCorpInput.Owner = this;
            formConsignCorpInput.ShowDialog();
        }

        private void toolAmend_Click(object sender, EventArgs e)
        {
            if (dgvConsignCorp.RowCount > 0)
            {
                FormConsignCorpInput formConsignCorpInput = new FormConsignCorpInput();
                formConsignCorpInput.Tag = "Edit";
                formConsignCorpInput.Owner = this;
                formConsignCorpInput.ShowDialog();
            }
        }

        private void toolDelete_Click(object sender, EventArgs e)
        {
            if (dgvConsignCorp.RowCount < 0)
            {
                return;
            }
            if (MessageBox.Show("确定要删除吗？", "软件提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                DataGridViewRow dgvr = dgvConsignCorp.CurrentRow;
                if (new Useful().IsExistConstraint("ConsignCorp", dgvr.Cells["ConsignCorpCode"].Value.ToString()))
                {
                    MessageBox.Show("已发生业务关系，无法删除", "软件提示");
                    return;
                }
                dgvConsignCorp.Rows.Remove(dgvr);
                if (cc.Delete(bsConsignCorp))
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

        private void dgvConsignCorp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvConsignCorp.RowCount > 0)
            {
                toolAmend_Click(sender, e);
            }
        }
    }
}
