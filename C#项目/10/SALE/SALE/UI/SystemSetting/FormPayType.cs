using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SALE.BLL.SystemSetting;
using SALE.DAL;
using SALE.Common;

namespace SALE.UI.SystemSetting
{
    public partial class FormPayType : Form
    {
        PayType pt = new PayType();

        public FormPayType()
        {
            InitializeComponent();
        }

        private void FormPayType_Load(object sender, EventArgs e)
        {
            dgvPayType.DataSource = pt.GetDataTable("PayType", "");
        }

        private void toolAdd_Click(object sender, EventArgs e)
        {
            FormPayTypeInput formPayTypeInput = new FormPayTypeInput();
            formPayTypeInput.Tag = "Add";
            formPayTypeInput.Owner = this;
            formPayTypeInput.ShowDialog();
        }

        private void toolAmend_Click(object sender, EventArgs e)
        {
            if (dgvPayType.Rows.Count > 0)
            {
                FormPayTypeInput formPayTypeInput = new FormPayTypeInput();
                formPayTypeInput.Tag = "Edit";
                formPayTypeInput.Owner = this;
                formPayTypeInput.ShowDialog();
            }
        }

        private void toolDelete_Click(object sender, EventArgs e)
        {
            if (dgvPayType.Rows.Count == 0)
            {
                return;
            }
            string strPayTypeCode = dgvPayType.CurrentRow.Cells["PayTypeCode"].Value.ToString();
            if (new Useful().IsExistConstraint("PayType", strPayTypeCode))
            {
                MessageBox.Show("已发生业务关系，无法删除", "软件提示");
                return;
            }
            string strSql = "Delete From PayType Where PayTypeCode = '" + strPayTypeCode + "'";
            DataLogic dal = new DataLogic();
            if (MessageBox.Show("确定要删除吗？", "软件提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                if (pt.Delete(dal, strSql))
                {
                    dgvPayType.DataSource = pt.GetDataTable("PayType", "");
                    MessageBox.Show("删除成功", "软件提示");
                }
                else
                {
                    MessageBox.Show("删除失败", "软件提示");
                }
            }
        }

        private void toolExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPayType_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPayType.Rows.Count > 0)
            {
                toolAmend_Click(sender, e);
            }
        }
    }
}
