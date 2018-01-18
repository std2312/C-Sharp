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
    public partial class FormGoodsType : Form
    {
        GoodsType gt = new GoodsType();
        DataLogic dal = new DataLogic();
        Useful useful = new Useful();
        public FormGoodsType()
        {
            InitializeComponent();
        }
        private void FormGoodsType_Load(object sender, EventArgs e)
        {
           dgvGoodsType.DataSource = gt.GetDataTable("GoodsType", "");
        }

        private void toolExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolAdd_Click(object sender, EventArgs e)
        {
            FormGoodsTypeInput formGoodsTypeInput = new FormGoodsTypeInput();
            formGoodsTypeInput.Tag = "Add";
            formGoodsTypeInput.Owner = this;
            formGoodsTypeInput.ShowDialog();
        }

        private void toolAmend_Click(object sender, EventArgs e)
        {
            if (dgvGoodsType.Rows.Count > 0)
            {
                FormGoodsTypeInput formGoodsTypeInput = new FormGoodsTypeInput();
                formGoodsTypeInput.Tag = "Edit";
                formGoodsTypeInput.Owner = this;
                formGoodsTypeInput.ShowDialog();
            }
        }

        private void toolDelete_Click(object sender, EventArgs e)
        {
            if (dgvGoodsType.Rows.Count == 0)
            {
                return;
            }
            if (MessageBox.Show("确定要删除吗？", "软件提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                string strGoodsTypeCode = dgvGoodsType.CurrentRow.Cells["GoodsTypeCode"].Value.ToString();
                if (useful.IsExistConstraint("GoodsType", strGoodsTypeCode))
                {
                    MessageBox.Show("已发生业务关系，无法删除", "软件提示");
                    return;
                }
                string strSql = "Delete From GoodsType Where GoodsTypeCode = '" + strGoodsTypeCode + "'";
                try
                {
                    if (gt.Delete(dal, strSql) == true)
                    {
                        dgvGoodsType.DataSource = gt.GetDataTable("GoodsType", "");
                        MessageBox.Show("删除成功！", "软件提示");
                    }
                    else
                    {
                        MessageBox.Show("删除失败！", "软件提示");
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        private void dgvGoodsType_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvGoodsType.Rows.Count > 0)
            {
                toolAmend_Click(sender, e);
            }
        }
    }
}
