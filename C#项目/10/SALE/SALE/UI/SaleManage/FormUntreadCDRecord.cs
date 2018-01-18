using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SALE.Common;
using SALE.BLL.SaleManage;

namespace SALE.UI.SaleManage
{
    public partial class FormUntreadCDRecord : Form
    {
        Useful useful = new Useful();
        FormRetailUntreadBaseBillInput formRetailUntreadBaseBillInput = null;
        UntreadCDRecord ucdr = new UntreadCDRecord();
        string strUntreadBillNo = null;

        public FormUntreadCDRecord()
        {
            InitializeComponent();
        }

        private void FormUntreadCDRecord_Load(object sender, EventArgs e)
        {
            formRetailUntreadBaseBillInput = (FormRetailUntreadBaseBillInput)this.Owner;
            strUntreadBillNo = formRetailUntreadBaseBillInput.UntreadBillNo;
            //给数据管理组件bsUntreadCDRecord加载表结构
            bsUntreadCDRecord.DataSource = ucdr.GetDataTable("UntreadCDRecord", " Where UntreadBillNo = '" + strUntreadBillNo + "'");
            dgvUntreadCDRecord.DataSource = bsUntreadCDRecord;
            if (this.Tag.ToString() == "Add")
            {
                string strSaleBillNo = formRetailUntreadBaseBillInput.txtSaleBillNo.Text.Trim();
                DataTable dt = ucdr.GetSaleCDNoBySaleBillNo(strSaleBillNo);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        DataGridViewRow dgvr = ucdr.AddDataGridViewRow(dgvUntreadCDRecord, bsUntreadCDRecord);
                        dgvr.Cells["CDNo"].Value = dr["CDNo"];
                        dgvr.Cells["UntreadBillNo"].Value = strUntreadBillNo;
                    }

                    if (ucdr.Commit(bsUntreadCDRecord, dgvUntreadCDRecord))
                    {
                        bsUntreadCDRecord.DataSource = ucdr.GetDataTable("UntreadCDRecord", " Where UntreadBillNo = '" + strUntreadBillNo + "'");
                        dgvUntreadCDRecord.DataSource = bsUntreadCDRecord;
                    }
                    else
                    {
                        //等价于异常
                        MessageBox.Show("自动初始化光盘号失败！", "软件提示");
                    }
                }
                else
                {
                    MessageBox.Show("销售单中无光盘号，不能够自动初始化光盘号！", "软件提示");
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvUntreadCDRecord.RowCount == 0)
            {
                return;
            }
            foreach (DataGridViewRow dgvr in dgvUntreadCDRecord.Rows)
            {
                if (String.IsNullOrEmpty(dgvr.Cells["CDNo"].Value.ToString()))
                {
                    MessageBox.Show("第" + (dgvr.Index + 1).ToString() + "行光盘号不许为空!", "软件提示");
                    return;
                }
            }
            if (ucdr.Commit(bsUntreadCDRecord, dgvUntreadCDRecord))
            {
                MessageBox.Show("保存成功！", "软件提示");
                bsUntreadCDRecord.DataSource = ucdr.GetDataTable("UntreadCDRecord", " Where UntreadBillNo = '" + strUntreadBillNo + "'");
                dgvUntreadCDRecord.DataSource = bsUntreadCDRecord;
            }
            else
            {
                MessageBox.Show("保存失败！", "软件提示");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void contextAdd_Click(object sender, EventArgs e)
        {
            DataGridViewRow dgvr = ucdr.AddDataGridViewRow(dgvUntreadCDRecord, bsUntreadCDRecord);
            dgvr.Cells["UntreadBillNo"].Value = strUntreadBillNo;
        }

        private void contextDelete_Click(object sender, EventArgs e)
        {
            if (dgvUntreadCDRecord.RowCount > 0)
            {
                if (MessageBox.Show("确定要删除吗？", "软件提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    DataGridViewRow dgvr = dgvUntreadCDRecord.CurrentRow;
                    if (dgvr.Cells["id"].Value == DBNull.Value)
                    {
                        try
                        {
                            dgvUntreadCDRecord.Rows.Remove(dgvr);
                            MessageBox.Show("删除成功", "软件提示");
                        }
                        catch
                        {
                            MessageBox.Show("删除失败", "软件提示");
                        }
                    }
                    else
                    {
                        dgvUntreadCDRecord.Rows.Remove(dgvr);
                        if (ucdr.Delete(bsUntreadCDRecord, dgvUntreadCDRecord))
                        {
                            MessageBox.Show("删除成功", "软件提示");
                            //bsUntreadCDRecord.DataSource = ucdr.GetDataTable("UntreadCDRecord", " Where UntreadBillNo = '" + strUntreadBillNo + "'");
                            //dgvUntreadCDRecord.DataSource = bsUntreadCDRecord;
                        }
                        else
                        {
                            MessageBox.Show("删除失败", "软件提示");
                        }
                    }
                }
            }
        }
    }
}
