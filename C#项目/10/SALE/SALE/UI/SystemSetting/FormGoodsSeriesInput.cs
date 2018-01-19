using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SALE.DAL;
using SALE.Common;
using SALE.BLL.SystemSetting;

namespace SALE.UI.SystemSetting
{
    public partial class FormGoodsSeriesInput : Form
    {
        FormGoodsSeries formGoodsSeries = null;
        DataLogic dal = new DataLogic();
        Useful useful = new Useful();
        string strGoodsSeriesCode = null;

        public FormGoodsSeriesInput()
        {
            InitializeComponent();
        }

        private void SetParametersValue()
        {
            dal.Cmd.Parameters.Clear();
            dal.Cmd.Parameters.AddWithValue("@GoodsSeriesCode", strGoodsSeriesCode);
            dal.Cmd.Parameters.AddWithValue("@GoodsSeriesName", txtGoodsSeriesName.Text.Trim());
            dal.Cmd.Parameters.AddWithValue("@UnitPrice", Convert.ToDecimal(txtUnitPrice.Text.Trim()));
        }

        private void FormGoodsSeriesInput_Load(object sender, EventArgs e)
        {
            formGoodsSeries = (FormGoodsSeries)this.Owner;
            if (this.Tag.ToString() == "Add")
            {
                strGoodsSeriesCode = useful.BuildCode("GoodsSeries", "", "GoodsSeriesCode", "", 2);
                txtGoodsSeriesName.Focus();
            }
            if (this.Tag.ToString() == "Edit")
            {
                strGoodsSeriesCode = formGoodsSeries.dgvGoodsSeries.CurrentRow.Cells["GoodsSeriesCode"].Value.ToString();
                txtGoodsSeriesName.Text = formGoodsSeries.dgvGoodsSeries.CurrentRow.Cells["GoodsSeriesName"].Value.ToString();
                txtUnitPrice.Text = formGoodsSeries.dgvGoodsSeries.CurrentRow.Cells["UnitPrice"].Value.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string strSql = null;
            GoodsSeries gs = new GoodsSeries();

            if (String.IsNullOrEmpty(txtGoodsSeriesName.Text.Trim()))
            {
                MessageBox.Show("系列名称不许为空！","软件提示");
                txtGoodsSeriesName.Focus();
                return;
            }

            if (String.IsNullOrEmpty(txtUnitPrice.Text.Trim()))
            {
                MessageBox.Show("单价不许为空！", "软件提示");
                txtUnitPrice.Focus();
                return;
            }
            else
            {
                if (Convert.ToDecimal(txtUnitPrice.Text.Trim()) == 0)
                {
                    MessageBox.Show("单价不许为零！", "软件提示");
                    txtUnitPrice.Focus();
                    return;
                }
            }

            SetParametersValue();

            if (this.Tag.ToString() == "Add")
            {
                strSql = "INSERT INTO GoodsSeries(GoodsSeriesCode,GoodsSeriesName,UnitPrice) ";
                strSql += "VALUES(@GoodsSeriesCode,@GoodsSeriesName,@UnitPrice)";
                if (gs.Insert(dal, strSql))
                {
                    formGoodsSeries.dgvGoodsSeries.DataSource = gs.GetDataTable("GoodsSeries", "");
                    if (MessageBox.Show("保存成功，是否继续添加？", "软件提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        strGoodsSeriesCode = useful.BuildCode("GoodsSeries", "", "GoodsSeriesCode", "", 2);
                        txtGoodsSeriesName.Text = "";
                        txtUnitPrice.Text = "";
                        txtGoodsSeriesName.Focus();
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
                strSql = "Update GoodsSeries Set GoodsSeriesName = @GoodsSeriesName,UnitPrice = @UnitPrice Where GoodsSeriesCode = @GoodsSeriesCode";
                if (gs.Update(dal, strSql) == true)
                {
                    formGoodsSeries.dgvGoodsSeries.DataSource = gs.GetDataTable("GoodsSeries", "");
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

        private void txtUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            useful.InputNumeric(e, txtUnitPrice);
        }
    }
}
