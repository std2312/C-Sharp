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
using SALE.BLL.AgentManage;

namespace SALE.UI.AgentManage
{
    public partial class FormDepRegisterInput : Form
    {
        FormDepRegister formDepRegister = null;
        DataLogic dal = new DataLogic();
        DepRegister dr = new DepRegister();

        public FormDepRegisterInput()
        {
            InitializeComponent();
        }

        private void SetParametersValue()
        {
            dal.Cmd.Parameters.Clear();
            dal.Cmd.Parameters.AddWithValue("@CustomerId", Convert.ToInt32(formDepRegister.tvAgentRecord.SelectedNode.Tag));
            dal.Cmd.Parameters.AddWithValue("@AgentLevelCode", cbxAgentLevelCode.SelectedValue.ToString());
            dal.Cmd.Parameters.AddWithValue("@Years",Convert.ToInt32(txtYears.Text));
            dal.Cmd.Parameters.AddWithValue("@BeginDate", dtpBeginDate.Value);
            dal.Cmd.Parameters.AddWithValue("@EndDate", dtpEndDate.Value);

            if (String.IsNullOrEmpty(txtRemark.Text))
            {
                dal.Cmd.Parameters.AddWithValue("@Remark", DBNull.Value);
            }
            else
            {
                dal.Cmd.Parameters.AddWithValue("@Remark", txtRemark.Text.Trim());
            }
        }

        private void FormDepRegisterInput_Load(object sender, EventArgs e)
        {
            ControlBindDataSource cbds = new ControlBindDataSource();
            cbds.ComboBoxBindDataSource(cbxAgentLevelCode, "AgentLevelCode", "AgentLevelName", "Select * from AgentLevel", "AgentLevel");
            formDepRegister = (FormDepRegister)this.Owner;
            if (this.Tag.ToString() == "Add")
            {
                txtCustomerName.Text = formDepRegister.tvAgentRecord.SelectedNode.Text;
                cbxAgentLevelCode.SelectedIndex = -1;
                txtYears.Text = "1";
                dtpBeginDate.Value = DateTime.Today;
                dtpEndDate.Value = dtpBeginDate.Value.AddYears(Convert.ToInt32(txtYears.Text));
            }
            if (this.Tag.ToString() == "Edit")
            {
                txtCustomerName.Text = formDepRegister.tvAgentRecord.SelectedNode.Text;
                cbxAgentLevelCode.SelectedValue = formDepRegister.dgvDepRegister.CurrentRow.Cells["AgentLevelCode"].Value.ToString();
                txtLeastMoney.Text = formDepRegister.dgvDepRegister.CurrentRow.Cells["LeastMoney"].Value.ToString();
                txtDiscount.Text = formDepRegister.dgvDepRegister.CurrentRow.Cells["Discount"].Value.ToString();
                txtYears.Text = formDepRegister.dgvDepRegister.CurrentRow.Cells["Years"].Value.ToString();
                dtpBeginDate.Value = Convert.ToDateTime(formDepRegister.dgvDepRegister.CurrentRow.Cells["BeginDate"].Value);
                dtpEndDate.Value = Convert.ToDateTime(formDepRegister.dgvDepRegister.CurrentRow.Cells["EndDate"].Value);
                txtRemark.Text = formDepRegister.dgvDepRegister.CurrentRow.Cells["Remark"].Value.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string strSql = null;
            if (cbxAgentLevelCode.SelectedValue == null)
            {
                MessageBox.Show("代理级别不许为空！","软件提示");
                cbxAgentLevelCode.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtYears.Text))
            {
                MessageBox.Show("代理年限不许为空！", "软件提示");
                txtYears.Focus();
                return;
            }
            else
            {
                if (txtYears.Text == "0")
                {
                    MessageBox.Show("代理年限不许为零！", "软件提示");
                    txtYears.Focus();
                    return;
                }
            }
            foreach (DataGridViewRow dgvr in formDepRegister.dgvDepRegister.Rows)
            {
                if (!dgvr.Equals(formDepRegister.dgvDepRegister.CurrentRow) || this.Tag.ToString() == "Add")
                {
                    if (dtpBeginDate.Value.Date >= Convert.ToDateTime(dgvr.Cells["BeginDate"].Value).Date)
                    {
                        if (dtpBeginDate.Value.Date <= Convert.ToDateTime(dgvr.Cells["EndDate"].Value).Date)
                        {
                            MessageBox.Show("与该代理商的以往代理登记存在日期上的重叠，程序无法设置！", "软件提示");
                            return;
                        }
                    }
                    if (dtpEndDate.Value.Date >= Convert.ToDateTime(dgvr.Cells["BeginDate"].Value).Date)
                    {
                        if (dtpEndDate.Value.Date <= Convert.ToDateTime(dgvr.Cells["EndDate"].Value).Date)
                        {
                            MessageBox.Show("与该代理商的以往代理登记存在日期上的重叠，程序无法设置！", "软件提示");
                            return;
                        }
                    }
                }
            }
            SetParametersValue();
            if (this.Tag.ToString() == "Add")
            {
                strSql = "INSERT INTO DepRegister(CustomerId,AgentLevelCode,Years,BeginDate,EndDate,Remark) ";
                strSql += "VALUES(@CustomerId,@AgentLevelCode,@Years,@BeginDate,@EndDate,@Remark)";
                if (dr.Insert(dal,strSql))
                {
                    formDepRegister.bsDepRegister.DataSource = dr.GetDataTable(formDepRegister.tvAgentRecord.SelectedNode.Tag.ToString());
                    formDepRegister.dgvDepRegister.DataSource = formDepRegister.bsDepRegister;
                    MessageBox.Show("保存成功！","软件提示");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("保存失败！", "软件提示");
                }
            }
            if (this.Tag.ToString() == "Edit")
            {
                DateTime dtOldBeginDate = Convert.ToDateTime(formDepRegister.dgvDepRegister.CurrentRow.Cells["BeginDate"].Value);
                strSql = "Update DepRegister Set AgentLevelCode = @AgentLevelCode,Years= @Years,BeginDate = @BeginDate,EndDate = @EndDate,Remark = @Remark ";
                strSql += "Where  CustomerId = @CustomerId and BeginDate = '" + dtOldBeginDate + "'";
                if (dr.Update(dal, strSql))
                {
                    formDepRegister.bsDepRegister.DataSource = dr.GetDataTable(formDepRegister.tvAgentRecord.SelectedNode.Tag.ToString());
                    formDepRegister.dgvDepRegister.DataSource = formDepRegister.bsDepRegister;
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

        private void cbxAgentLevelCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxAgentLevelCode.SelectedIndex != -1)
            {
                DataTable dt = dr.GetDataTable(cbxAgentLevelCode.SelectedValue.ToString(), "AgentLevel");
                if (dt.Rows.Count > 0)
                {
                    txtLeastMoney.Text = dt.Rows[0]["LeastMoney"].ToString();
                    txtDiscount.Text = dt.Rows[0]["Discount"].ToString();
                }
            }
        }

        private void dtpBeginDate_ValueChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtYears.Text))
            {
                dtpEndDate.Value = dtpBeginDate.Value.AddYears(Convert.ToInt32(txtYears.Text));
            }
        }

        private void txtYears_KeyPress(object sender, KeyPressEventArgs e)
        {
            new Useful().InputInteger(e);
        }
    }
}
