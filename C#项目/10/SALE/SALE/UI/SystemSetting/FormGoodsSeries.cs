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
    public partial class FormGoodsSeries : Form
    {
        GoodsSeries gs = new GoodsSeries();

        public FormGoodsSeries()
        {
            InitializeComponent();
        }

        private void FormGoodsSeries_Load(object sender, EventArgs e)
        {
            dgvGoodsSeries.DataSource = gs.GetDataTable("GoodsSeries", "");
        }

        private void toolAdd_Click(object sender, EventArgs e)
        {
            FormGoodsSeriesInput formGoodsSeriesInput = new FormGoodsSeriesInput();
            formGoodsSeriesInput.Tag = "Add";
            formGoodsSeriesInput.Owner = this;
            formGoodsSeriesInput.ShowDialog();
        }

        private void toolAmend_Click(object sender, EventArgs e)
        {
            if (dgvGoodsSeries.Rows.Count > 0)
            {
                FormGoodsSeriesInput formGoodsSeriesInput = new FormGoodsSeriesInput();
                formGoodsSeriesInput.Tag = "Edit";
                formGoodsSeriesInput.Owner = this;
                formGoodsSeriesInput.ShowDialog();
            }
        }

        private void toolDelete_Click(object sender, EventArgs e)
        {
            if (dgvGoodsSeries.Rows.Count == 0)
            {
                return;
            }

            if (MessageBox.Show("确定要删除吗？", "软件提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                string strGoodsSeriesCode = dgvGoodsSeries.CurrentRow.Cells["GoodsSeriesCode"].Value.ToString();
                if (new Useful().IsExistConstraint("GoodsSeries", strGoodsSeriesCode))
                {
                    MessageBox.Show("已发生业务关系，无法删除", "软件提示");
                    return;
                }
                string strSql = "Delete From GoodsSeries Where GoodsSeriesCode = '" + strGoodsSeriesCode + "'";
                DataLogic dal = new DataLogic();
                if (gs.Delete(dal, strSql) == true)
                {
                    dgvGoodsSeries.DataSource = gs.GetDataTable("GoodsSeries", "");
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

        private void dgvGoodsSeries_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvGoodsSeries.Rows.Count > 0)
            {
                toolAmend_Click(sender, e);
            }
        }
    }
}
