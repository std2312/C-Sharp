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
    public partial class FormOperatorInput : Form
    {
        FormOperator formOperator = null;
        Useful useful = new Useful();
        DataLogic dal = new DataLogic();

        public FormOperatorInput()
        {
            InitializeComponent();
        }

        private void FormOperatorInput_Load(object sender, EventArgs e)
        {

            formOperator = (FormOperator)this.Owner;
            if (this.Tag.ToString() == "Add")
            {
                txtOperatorCode.Text = useful.BuildCode("Operator", "Where OperatorCode <> 'mr'", "OperatorCode", "", 4);
            }
            if (this.Tag.ToString() == "Edit")
            {
                txtOperatorCode.Text = formOperator.dgvOperator.CurrentRow.Cells["OperatorCode"].Value.ToString();
                txtOperatorName.Text = formOperator.dgvOperator.CurrentRow.Cells["OperatorName"].Value.ToString();
                txtPassword.Text = formOperator.dgvOperator.CurrentRow.Cells["Password"].Value.ToString();
                txtAffirmPassword.Text = txtPassword.Text;
                //修改时的相关控制
                txtPassword.ReadOnly = true;
                txtAffirmPassword.ReadOnly = true;
                if (formOperator.dgvOperator.CurrentRow.Cells["IsFlag"].Value.ToString() == "1")
                {
                    txtOperatorName.ReadOnly = true;
                    btnSave.Enabled = false;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Operator oper = new Operator();
            if (String.IsNullOrEmpty(txtOperatorName.Text.Trim()))
            {
                MessageBox.Show("操作名称不许为空！","软件提示");
                txtOperatorName.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("操作密码不许为空！", "软件提示");
                txtPassword.Focus();
                return;
            }
            if (!(txtPassword.Text == txtAffirmPassword.Text))
            {
                MessageBox.Show("确认密码与操作密码不相同！", "软件提示");
                txtAffirmPassword.Focus();
                return;
            }
            if (this.Tag.ToString() == "Add")
            {
                DataGridViewRow dgvr = oper.AddDataGridViewRow(formOperator.dgvOperator, formOperator.bsOperator);
                dgvr.Cells["OperatorCode"].Value = txtOperatorCode.Text;
                dgvr.Cells["OperatorName"].Value = txtOperatorName.Text.Trim();
                dgvr.Cells["Password"].Value = txtPassword.Text;
                dgvr.Cells["IsFlag"].Value = "0";
                if (oper.Insert(formOperator.bsOperator))
                {
                    if (MessageBox.Show("保存成功，是否继续添加？", "软件提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        txtOperatorCode.Text = useful.BuildCode("Operator", "Where OperatorCode <> 'mr'", "OperatorCode", "", 4);
                        txtOperatorName.Text = "";
                        txtPassword.Text = "";
                        txtAffirmPassword.Text = "";
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
                DataGridViewRow dgvr = formOperator.dgvOperator.CurrentRow;
                dgvr.Cells["OperatorName"].Value = txtOperatorName.Text.Trim();
                if (oper.Update(formOperator.bsOperator))
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
