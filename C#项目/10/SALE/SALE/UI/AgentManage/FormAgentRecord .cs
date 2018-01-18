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
    public partial class FormAgentRecord : Form
    {
        AgentRecord ar = new AgentRecord();

        public FormAgentRecord()
        {
            InitializeComponent();
        }

        private void FormAgentRecord_Load(object sender, EventArgs e)
        {
            ControlBindDataSource cbds = new ControlBindDataSource();
            cbds.DataGridViewComboBoxColumnBindDataSource(ProvinceCode, "ProvinceCode", "ProvinceName", "Select * From Province", "Province");
            bsAgentRecord.DataSource = ar.GetDataTable("Customer", "Where CustomerType = '1' ");
            dgvAgentRecord.DataSource = bsAgentRecord;
        }

        private void toolAdd_Click(object sender, EventArgs e)
        {
            FormAgentRecordInput formAgentRecordInput = new FormAgentRecordInput();
            formAgentRecordInput.Tag = "Add";
            formAgentRecordInput.Owner = this;
            formAgentRecordInput.ShowDialog();
        }

        private void toolAmend_Click(object sender, EventArgs e)
        {
            if (dgvAgentRecord.RowCount > 0)
            {
                FormAgentRecordInput formAgentRecordInput = new FormAgentRecordInput();
                formAgentRecordInput.Tag = "Edit";
                formAgentRecordInput.Owner = this;
                formAgentRecordInput.ShowDialog();
            }
        }

        private void toolDelete_Click(object sender, EventArgs e)
        {
            if (dgvAgentRecord.RowCount == 0)
            {
                return;
            }
            if (MessageBox.Show("确定要删除吗？", "软件提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                DataGridViewRow dgvr = dgvAgentRecord.CurrentRow;
                if (new Useful().IsExistConstraint("Customer", dgvr.Cells["CustomerId"].Value.ToString()))
                {
                    MessageBox.Show("已发生业务关系，无法删除", "软件提示");
                    return;
                }
                dgvAgentRecord.Rows.Remove(dgvr);
                if (ar.Delete(bsAgentRecord))
                {
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

        private void dgvAgentRecord_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAgentRecord.RowCount > 0)
            {
                toolAmend_Click(sender, e);
            }
        }
    }
}
