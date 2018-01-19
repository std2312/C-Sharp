using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SALE.Common;
using SALE.BLL.SystemSetting;
using SALE.DAL;

namespace SALE.UI.SystemSetting
{
    public partial class FormGoodsTypeInput : Form
    {
        FormGoodsType formGoodsType = null;
        DataLogic dal = new DataLogic();
        Useful useful = new Useful();

        public FormGoodsTypeInput()
        {
            InitializeComponent();
        }

        private void SetParametersValue()
        {
            dal.Cmd.Parameters.Clear();
            dal.Cmd.Parameters.AddWithValue("@GoodsTypeCode", txtGoodsTypeCode.Text);
            dal.Cmd.Parameters.AddWithValue("@GoodsTypeName", txtGoodsTypeName.Text.Trim());
        }

        private void FormGoodsTypeInput_Load(object sender, EventArgs e)
        {
            formGoodsType = (FormGoodsType)this.Owner;

            if (this.Tag.ToString() == "Add")
            {

                txtGoodsTypeCode.Text = useful.BuildCode("GoodsType", "", "GoodsTypeCode", "", 2);
            }
            else
            {
                txtGoodsTypeCode.Text = formGoodsType.dgvGoodsType["GoodsTypeCode", formGoodsType.dgvGoodsType.CurrentRow.Index].Value.ToString();
                txtGoodsTypeName.Text = formGoodsType.dgvGoodsType["GoodsTypeName", formGoodsType.dgvGoodsType.CurrentRow.Index].Value.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            GoodsType gt = new GoodsType();
            string strSql = null;
            if (String.IsNullOrEmpty(txtGoodsTypeName.Text.Trim()))
            {
                MessageBox.Show("类别名称不许为空！", "软件提示");
                txtGoodsTypeName.Focus();
                return;
            }
            SetParametersValue();
            if (this.Tag.ToString() == "Add")
            {
                strSql = "INSERT INTO GoodsType(GoodsTypeCode,GoodsTypeName) ";
                strSql += "VALUES(@GoodsTypeCode,@GoodsTypeName)";
                if (gt.Insert(dal, strSql) == true)
                {
                    formGoodsType.dgvGoodsType.DataSource = gt.GetDataTable("GoodsType", "");
                    if (MessageBox.Show("保存成功，是否继续添加？", "软件提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        txtGoodsTypeCode.Text = useful.BuildCode("GoodsType", "", "GoodsTypeCode", "", 2);
                        txtGoodsTypeName.Text = "";
                        txtGoodsTypeName.Focus();
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
                strSql = "Update GoodsType Set GoodsTypeName = @GoodsTypeName Where GoodsTypeCode = @GoodsTypeCode";
                if (gt.Update(dal, strSql) == true)
                {
                    formGoodsType.dgvGoodsType.DataSource = gt.GetDataTable("GoodsType", "");
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
