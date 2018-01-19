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

namespace SALE.UI.SystemSetting
{
    public partial class FormAgentLevel : Form
    {
        AgentLevel al = new AgentLevel();

        public FormAgentLevel()
        {
            InitializeComponent();
        }

        private void FormAgentLevel_Load(object sender, EventArgs e)
        {
            bsAgentLevel.DataSource = al.GetDataTable("AgentLevel", "");
            dgvAgentLevel.DataSource = bsAgentLevel;
        }

        private void toolAdd_Click(object sender, EventArgs e)
        {
            FormAgentLevelInput formAgentLevelInput = new FormAgentLevelInput();
            formAgentLevelInput.Tag = "Add";
            formAgentLevelInput.Owner = this;
            formAgentLevelInput.ShowDialog();
        }

        private void toolAmend_Click(object sender, EventArgs e)
        {
            if (dgvAgentLevel.RowCount > 0)
            {
                FormAgentLevelInput formAgentLevelInput = new FormAgentLevelInput();
                formAgentLevelInput.Tag = "Edit";
                formAgentLevelInput.Owner = this;
                formAgentLevelInput.ShowDialog();
            }
        }

        private void toolDelete_Click(object sender, EventArgs e)
        {
            if (dgvAgentLevel.RowCount < 0)
            {
                return;
            }
            if (MessageBox.Show("确定要删除吗？", "软件提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                DataGridViewRow dgvr = dgvAgentLevel.CurrentRow;
                if (new Useful().IsExistConstraint("AgentLevel", dgvr.Cells["AgentLevelCode"].Value.ToString()))
                {
                    MessageBox.Show("已发生业务关系，无法删除", "软件提示");
                    return;
                }
                dgvAgentLevel.Rows.Remove(dgvr);
                if (al.Delete(bsAgentLevel))
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

        private void dgvAgentLevel_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAgentLevel.RowCount > 0)
            {
                toolAmend_Click(sender, e);
            }
        }
    }
}
