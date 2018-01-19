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
    public partial class FormAgentLevelInput : Form
    {
        FormAgentLevel formAgentLevel = null;
        Useful useful = new Useful();
        DataLogic dal = new DataLogic();

        public FormAgentLevelInput()
        {
            InitializeComponent();
        }

        //private void SetParametersValue()
        //{
        //    dal.Cmd.Parameters.Clear();
        //    dal.Cmd.Parameters.AddWithValue("@AgentLevelCode", txtAgentLevelCode.Text);
        //    dal.Cmd.Parameters.AddWithValue("@AgentLevelName", txtAgentLevelName.Text.Trim());
        //    dal.Cmd.Parameters.AddWithValue("@LeastMoney", Convert.ToDecimal(txtLeastMoney.Text));
        //    dal.Cmd.Parameters.AddWithValue("@Discount", Convert.ToDecimal(txtDiscount.Text));
        //}

        private void FormAgentLevelInput_Load(object sender, EventArgs e)
        {
            formAgentLevel = (FormAgentLevel)this.Owner;
            if (this.Tag.ToString() == "Add")
            {
                txtAgentLevelCode.Text = useful.BuildCode("AgentLevel", "", "AgentLevelCode", "", 2);
            }
            if (this.Tag.ToString() == "Edit")
            {
                txtAgentLevelCode.Text = formAgentLevel.dgvAgentLevel.CurrentRow.Cells["AgentLevelCode"].Value.ToString();
                txtAgentLevelName.Text = formAgentLevel.dgvAgentLevel.CurrentRow.Cells["AgentLevelName"].Value.ToString();
                txtLeastMoney.Text = formAgentLevel.dgvAgentLevel.CurrentRow.Cells["LeastMoney"].Value.ToString();
                txtDiscount.Text = formAgentLevel.dgvAgentLevel.CurrentRow.Cells["Discount"].Value.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AgentLevel al = new AgentLevel();
            if (String.IsNullOrEmpty(txtAgentLevelName.Text.Trim()))
            {
                MessageBox.Show("级别名称不许为空！","软件提示");
                txtAgentLevelName.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtLeastMoney.Text))
            {
                MessageBox.Show("销售任务不许为空！", "软件提示");
                txtLeastMoney.Focus();
                return;
            }
            else
            {
                if (Convert.ToDecimal(txtLeastMoney.Text) == 0)
                {
                    MessageBox.Show("销售任务不许为零！", "软件提示");
                    txtLeastMoney.Focus();
                    return;
                }
            }
            if (String.IsNullOrEmpty(txtDiscount.Text.Trim()))
            {
                MessageBox.Show("代理折扣不许为空！", "软件提示");
                txtDiscount.Focus();
                return;
            }
            else
            {
                if (Convert.ToDecimal(txtDiscount.Text) == 0)
                {
                    MessageBox.Show("代理折扣不许为零！", "软件提示");
                    txtDiscount.Focus();
                    return;
                }
                if (Convert.ToDecimal(txtDiscount.Text) > 1)
                {
                    MessageBox.Show("代理折扣不许大于“1”！", "软件提示");
                    txtDiscount.Focus();
                    return;
                }
            }
            
            if (this.Tag.ToString() == "Add")
            {
                DataGridViewRow dgvr = al.AddDataGridViewRow(formAgentLevel.dgvAgentLevel, formAgentLevel.bsAgentLevel);
                dgvr.Cells["AgentLevelCode"].Value = txtAgentLevelCode.Text;
                dgvr.Cells["AgentLevelName"].Value = txtAgentLevelName.Text.Trim();
                dgvr.Cells["LeastMoney"].Value = Convert.ToDecimal(txtLeastMoney.Text);
                dgvr.Cells["Discount"].Value = Convert.ToDecimal(txtDiscount.Text);
                if (al.Insert(formAgentLevel.bsAgentLevel))
                {
                    if (MessageBox.Show("保存成功，是否继续添加？", "软件提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        txtAgentLevelCode.Text = useful.BuildCode("AgentLevel", "", "AgentLevelCode", "", 2);
                        txtAgentLevelName.Text = "";
                        txtLeastMoney.Text = "";
                        txtDiscount.Text = "";
                        txtAgentLevelName.Focus();
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
                DataGridViewRow dgvr = formAgentLevel.dgvAgentLevel.CurrentRow;
                dgvr.Cells["AgentLevelName"].Value = txtAgentLevelName.Text.Trim();
                dgvr.Cells["LeastMoney"].Value = Convert.ToDecimal(txtLeastMoney.Text);
                dgvr.Cells["Discount"].Value = Convert.ToDecimal(txtDiscount.Text);
                if (al.Update(formAgentLevel.dgvAgentLevel,formAgentLevel.bsAgentLevel))
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

        private void txtLeastMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            useful.InputNumeric(e, txtLeastMoney);
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            useful.InputNumeric(e,txtDiscount);
        }

        private void txtAgentLevelName_KeyDown(object sender, KeyEventArgs e)
        {
            useful.SetFocus(e, txtLeastMoney);
        }

        private void txtLeastMoney_KeyDown(object sender, KeyEventArgs e)
        {
            useful.SetFocus(e, txtDiscount);
        }

        private void txtDiscount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click(sender, e);
            }
        }
    }
}
