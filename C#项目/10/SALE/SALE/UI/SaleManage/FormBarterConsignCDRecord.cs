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
    public partial class FormBarterConsignCDRecord : Form
    {
        Useful useful = new Useful();
        FormRetailBarterConsignBillInput formRetailBarterConsignBillInput = null;
        BarterConsignCDRecord bccdr = new BarterConsignCDRecord();
        private int intBarterConsignBillId;

        public FormBarterConsignCDRecord()
        {
            InitializeComponent();
        }

        private void FormBarterConsignCDRecord_Load(object sender, EventArgs e)
        {
            formRetailBarterConsignBillInput = (FormRetailBarterConsignBillInput)this.Owner;
            intBarterConsignBillId = formRetailBarterConsignBillInput.BaterConsignBillId;
            bsBarterConsignCDRecord.DataSource = bccdr.GetDataTable("BarterConsignCDRecord", " Where BarterConsignBillId = " + intBarterConsignBillId);
            dgvBarterConsignCDRecord.DataSource = bsBarterConsignCDRecord;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvBarterConsignCDRecord.RowCount == 0)
            {
                return;
            }
            foreach (DataGridViewRow dgvr in dgvBarterConsignCDRecord.Rows)
            {
                if (String.IsNullOrEmpty(dgvr.Cells["CDNo"].Value.ToString()))
                {
                    MessageBox.Show("第" + (dgvr.Index + 1).ToString() + "行光盘号不许为空!", "软件提示");
                    return;
                }
            }
            if (bccdr.Commit(bsBarterConsignCDRecord, dgvBarterConsignCDRecord))
            {
                MessageBox.Show("保存成功！", "软件提示");
                //插入和更新的数据，在提交后重新检索
                bsBarterConsignCDRecord.DataSource = bccdr.GetDataTable("BarterConsignCDRecord", " Where BarterConsignBillId = " + intBarterConsignBillId);
                dgvBarterConsignCDRecord.DataSource = bsBarterConsignCDRecord;
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
            DataGridViewRow dgvr = bccdr.AddDataGridViewRow(dgvBarterConsignCDRecord, bsBarterConsignCDRecord);
            dgvr.Cells["BarterConsignBillId"].Value = intBarterConsignBillId;
        }

        private void contextDelete_Click(object sender, EventArgs e)
        {
            if (dgvBarterConsignCDRecord.RowCount > 0)
            {
                if (MessageBox.Show("确定要删除吗？", "软件提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    DataGridViewRow dgvr = dgvBarterConsignCDRecord.CurrentRow;
                    if (dgvr.Cells["id"].Value == DBNull.Value)
                    {
                        try
                        {
                            dgvBarterConsignCDRecord.Rows.Remove(dgvr);
                            MessageBox.Show("删除成功", "软件提示");
                        }
                        catch
                        {
                            MessageBox.Show("删除失败", "软件提示");
                        }
                    }
                    else
                    {
                        dgvBarterConsignCDRecord.Rows.Remove(dgvr);
                        if (bccdr.Delete(bsBarterConsignCDRecord, dgvBarterConsignCDRecord))
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
