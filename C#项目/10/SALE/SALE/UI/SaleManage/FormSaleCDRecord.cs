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
    public partial class FormSaleCDRecord : Form
    {
        Useful useful = new Useful();
        FormRetailSaleConsignBillInput formRetailSaleConsignBillInput = null;
        SaleCDRecord scdr = new SaleCDRecord();
        private int intSaleConsignBillId;

        public FormSaleCDRecord()
        {
            InitializeComponent();
        }

        private void FormSaleCDRecord_Load(object sender, EventArgs e)
        {
            formRetailSaleConsignBillInput = (FormRetailSaleConsignBillInput)this.Owner;
            intSaleConsignBillId = formRetailSaleConsignBillInput.SaleConsignBillId;
            bsSaleCDRecord.DataSource = scdr.GetDataTable("SaleCDRecord", " Where SaleConsignBillId = " + intSaleConsignBillId);
            dgvSaleCDRecord.DataSource = bsSaleCDRecord;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvSaleCDRecord.RowCount == 0)
            {
                return;
            }
            foreach (DataGridViewRow dgvr in dgvSaleCDRecord.Rows)
            {
                if (String.IsNullOrEmpty(dgvr.Cells["CDNo"].Value.ToString()))
                {
                    MessageBox.Show("第" + (dgvr.Index+1).ToString() + "行光盘号不许为空!", "软件提示");
                    return;
                }
            }
            if (scdr.Commit(bsSaleCDRecord, dgvSaleCDRecord))
            {
                MessageBox.Show("保存成功！","软件提示");
                //插入和更新的数据，在提交后重新检索
                bsSaleCDRecord.DataSource = scdr.GetDataTable("SaleCDRecord", " Where SaleConsignBillId = " + intSaleConsignBillId);
                dgvSaleCDRecord.DataSource = bsSaleCDRecord;
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
            DataGridViewRow dgvr = scdr.AddDataGridViewRow(dgvSaleCDRecord, bsSaleCDRecord);
            dgvr.Cells["SaleConsignBillId"].Value = intSaleConsignBillId;
        }

        private void contextDelete_Click(object sender, EventArgs e)
        {
            if (dgvSaleCDRecord.RowCount > 0)
            {
                if (MessageBox.Show("确定要删除吗？", "软件提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    DataGridViewRow dgvr = dgvSaleCDRecord.CurrentRow;
                    if (dgvr.Cells["id"].Value == DBNull.Value)
                    {
                        try
                        {
                            dgvSaleCDRecord.Rows.Remove(dgvr);
                            MessageBox.Show("删除成功", "软件提示");
                        }
                        catch
                        {
                            MessageBox.Show("删除失败", "软件提示");
                        }
                    }
                    else
                    {
                        dgvSaleCDRecord.Rows.Remove(dgvr);
                        if (scdr.Delete(bsSaleCDRecord, dgvSaleCDRecord))
                        {
                            MessageBox.Show("删除成功", "软件提示");
                            //bsSaleCDRecord.DataSource = scdr.GetDataTable("SaleCDRecord", " Where SaleConsignBillId = " + intSaleConsignBillId);
                            //dgvSaleCDRecord.DataSource = bsSaleCDRecord;
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
