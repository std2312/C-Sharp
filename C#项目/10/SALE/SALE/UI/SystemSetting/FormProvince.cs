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
    public partial class FormProvince : Form
    {
        Province p = new Province();

        public FormProvince()
        {
            InitializeComponent();
        }

        private void FormProvince_Load(object sender, EventArgs e)
        {
            bsProvince.DataSource = p.GetDataTable("Province", "");
            dgvProvince.DataSource = bsProvince;
        }

        private void toolAdd_Click(object sender, EventArgs e)
        {
            FormProvinceInput formProvinceInput = new FormProvinceInput();
            formProvinceInput.Tag = "Add";
            formProvinceInput.Owner = this;
            formProvinceInput.ShowDialog();
        }

        private void toolAmend_Click(object sender, EventArgs e)
        {
            if (dgvProvince.RowCount > 0)
            {
                FormProvinceInput formProvinceInput = new FormProvinceInput();
                formProvinceInput.Tag = "Edit";
                formProvinceInput.Owner = this;
                formProvinceInput.ShowDialog();
            }
        }
        private void toolDelete_Click(object sender, EventArgs e)
        {
            if (dgvProvince.RowCount < 0)
            {
                return;
            }
            if (MessageBox.Show("确定要删除吗？", "软件提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                DataGridViewRow dgvr = dgvProvince.CurrentRow;
                if (new Useful().IsExistConstraint("Province", dgvr.Cells["ProvinceCode"].Value.ToString()))
                {
                    MessageBox.Show("已发生业务关系，无法删除", "软件提示");
                    return;
                }
                dgvProvince.Rows.Remove(dgvr);
                if (p.Delete(bsProvince))
                {
                    MessageBox.Show("删除成功！", "软件提示");
                }
                else
                {
                    MessageBox.Show("删除成功！", "软件提示");
                }
            }
        }

        private void toolExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvProvince_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProvince.RowCount > 0)
            {
                toolAmend_Click(sender, e);
            }
        }
    }
}
