using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SALE.BLL.AgentManage;
using SALE.Common;

namespace SALE.UI.AgentManage
{
    public partial class FormDepRegister : Form
    {
        DepRegister dr = new DepRegister();
        ControlBindDataSource cbds = new ControlBindDataSource();

        public FormDepRegister()
        {
            InitializeComponent();
        }

        private void FormDepRegister_Load(object sender, EventArgs e)
        {
            cbds.BuildTree(tvAgentRecord, imageList1, "代理商", "Customer", "Where CustomerType = '1'", "CustomerId", "CustomerName");
        }

        private void toolAdd_Click(object sender, EventArgs e)
        {
            if (tvAgentRecord.SelectedNode != null)
            {
                if (tvAgentRecord.SelectedNode.Tag != null)
                {
                    FormDepRegisterInput formDepRegisterInput = new FormDepRegisterInput();
                    formDepRegisterInput.Tag = "Add";
                    formDepRegisterInput.Owner = this;
                    formDepRegisterInput.ShowDialog();
                }
            }
        }
        private void toolAmend_Click(object sender, EventArgs e)
        {
            if (dgvDepRegister.RowCount > 0)
            {
                FormDepRegisterInput formDepRegisterInput = new FormDepRegisterInput();
                formDepRegisterInput.Tag = "Edit";
                formDepRegisterInput.Owner = this;
                formDepRegisterInput.ShowDialog();
            }
        }

        private void toolDelete_Click(object sender, EventArgs e)
        {
            if (dgvDepRegister.RowCount == 0)
            {
                return;
            }
            if (MessageBox.Show("确定要删除吗？", "软件提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                string strBeginDate = Convert.ToDateTime(dgvDepRegister.CurrentRow.Cells["BeginDate"].Value).ToString("yyyy-MM-dd");
                string strSql = "Delete From DepRegister Where CustomerId = '" + tvAgentRecord.SelectedNode.Tag.ToString() + "' and SUBSTRING(CONVERT(VARCHAR(20),BeginDate,20),1,10) = '" + strBeginDate + "'";
                if (dr.Delete(strSql))
                {
                    bsDepRegister.DataSource = dr.GetDataTable(tvAgentRecord.SelectedNode.Tag.ToString());
                    dgvDepRegister.DataSource = bsDepRegister;
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

        private void tvAgentRecord_AfterSelect(object sender, TreeViewEventArgs e)
        {
            new Useful().DataGridViewReset(dgvDepRegister);
            if (tvAgentRecord.SelectedNode != null)
            {
                if (tvAgentRecord.SelectedNode.Tag != null)
                {
                    bsDepRegister.DataSource = dr.GetDataTable(tvAgentRecord.SelectedNode.Tag.ToString());
                    dgvDepRegister.DataSource = bsDepRegister;
                }
            }
        }

        private void dgvDepRegister_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDepRegister.RowCount > 0)
            {
                toolAmend_Click(sender, e);
            }
        }
    }
}
