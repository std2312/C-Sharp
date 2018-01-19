using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SALE.Common;
using SALE.DAL;
using SALE.BLL.SystemSetting;

namespace SALE.UI.SystemSetting
{
    public partial class FormPayTypeInput : Form
    {
        FormPayType formPayType = null;
        Useful useful = new Useful();
        DataLogic dal = new DataLogic();

        public FormPayTypeInput()
        {
            InitializeComponent();
        }

        private void SetParametersValue()
        {
            dal.Cmd.Parameters.Clear();
            dal.Cmd.Parameters.AddWithValue("@PayTypeCode", txtPayTypeCode.Text);
            dal.Cmd.Parameters.AddWithValue("@PayTypeName", txtPayTypeName.Text.Trim());
        }

        private void FormPayTypeInput_Load(object sender, EventArgs e)
        {
            formPayType = (FormPayType)this.Owner;
            if (this.Tag.ToString() == "Add")
            {
                txtPayTypeCode.Text = useful.BuildCode("PayType", "", "PayTypeCode", "", 2);
                txtPayTypeName.Focus();
            }
            if (this.Tag.ToString() == "Edit")
            {
                txtPayTypeCode.Text = formPayType.dgvPayType.CurrentRow.Cells["PayTypeCode"].Value.ToString();
                txtPayTypeName.Text = formPayType.dgvPayType.CurrentRow.Cells["PayTypeName"].Value.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string strSql = null;
            PayType pt = new PayType();
            if (String.IsNullOrEmpty(txtPayTypeName.Text.Trim()))
            {
                MessageBox.Show("支付方式不许为空！","软件提示");
                txtPayTypeName.Focus();
                return;
            }
            SetParametersValue();
            if (this.Tag.ToString() == "Add")
            {
                strSql = "INSERT INTO PayType(PayTypeCode,PayTypeName) ";
                strSql += "VALUES(@PayTypeCode,@PayTypeName)";
                if (pt.Insert(dal, strSql))
                {
                    formPayType.dgvPayType.DataSource = pt.GetDataTable("PayType", "");
                    if (MessageBox.Show("保存成功，是否继续添加？", "软件提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        txtPayTypeCode.Text = useful.BuildCode("PayType", "", "PayTypeCode", "", 2);
                        txtPayTypeName.Text = "";
                        txtPayTypeName.Focus();
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
                strSql = "Update PayType Set PayTypeName = @PayTypeName Where PayTypeCode = @PayTypeCode";
                
                if (pt.Update(dal, strSql))
                {
                    formPayType.dgvPayType.DataSource = pt.GetDataTable("PayType", "");
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
