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
    public partial class FormBarterBaseCDRecord : Form
    {
        Useful useful = new Useful();
        FormRetailBarterBaseBillInput formRetailBarterBaseBillInput = null;
        BarterBaseCDRecord bbcdr = new BarterBaseCDRecord();
        private string strBarterBillNo = null;  //声明调货单号字段

        public FormBarterBaseCDRecord()
        {
            InitializeComponent();
        }

        private void FormBarterBaseCDRecord_Load(object sender, EventArgs e)
        {
            formRetailBarterBaseBillInput = (FormRetailBarterBaseBillInput)this.Owner;
            strBarterBillNo = formRetailBarterBaseBillInput.BarterBillNo;
            //给数据管理组件bsUntreadCDRecord加载表结构
            bsBarterBaseCDRecord.DataSource = bbcdr.GetDataTable("BarterBaseCDRecord", " Where BarterBillNo = '" + strBarterBillNo + "'");
            dgvBarterBaseCDRecord.DataSource = bsBarterBaseCDRecord;
            if (this.Tag.ToString() == "Add")
            {
                string strSaleBillNo = formRetailBarterBaseBillInput.txtSaleBillNo.Text.Trim();
                DataTable dt = bbcdr.GetSaleCDNoBySaleBillNo(strSaleBillNo);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        DataGridViewRow dgvr = bbcdr.AddDataGridViewRow(dgvBarterBaseCDRecord, bsBarterBaseCDRecord);
                        dgvr.Cells["CDNo"].Value = dr["CDNo"];
                        dgvr.Cells["BarterBillNo"].Value = strBarterBillNo;
                    }
                    if (bbcdr.Commit(bsBarterBaseCDRecord, dgvBarterBaseCDRecord))  //正常
                    {
                        bsBarterBaseCDRecord.DataSource = bbcdr.GetDataTable("BarterBaseCDRecord", " Where BarterBillNo = '" + strBarterBillNo + "'");
                        dgvBarterBaseCDRecord.DataSource = bsBarterBaseCDRecord;
                    }
                    else  //异常
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
            if (dgvBarterBaseCDRecord.RowCount == 0)
            {
                return;
            }
            foreach (DataGridViewRow dgvr in dgvBarterBaseCDRecord.Rows)
            {
                if (String.IsNullOrEmpty(dgvr.Cells["CDNo"].Value.ToString()))
                {
                    MessageBox.Show("第" + (dgvr.Index + 1).ToString() + "行光盘号不许为空!", "软件提示");
                    return;
                }
            }
            if (bbcdr.Commit(bsBarterBaseCDRecord, dgvBarterBaseCDRecord))
            {
                MessageBox.Show("保存成功！", "软件提示");
                bsBarterBaseCDRecord.DataSource = bbcdr.GetDataTable("BarterBaseCDRecord", " Where BarterBillNo = '" + strBarterBillNo + "'");
                dgvBarterBaseCDRecord.DataSource = bsBarterBaseCDRecord;
            }
            else
            {
                //等价于异常
                MessageBox.Show("保存失败！", "软件提示");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void contextAdd_Click(object sender, EventArgs e)
        {
            DataGridViewRow dgvr = bbcdr.AddDataGridViewRow(dgvBarterBaseCDRecord, bsBarterBaseCDRecord);
            dgvr.Cells["BarterBillNo"].Value = strBarterBillNo;
        }

        private void contextDelete_Click(object sender, EventArgs e)
        {
            if (dgvBarterBaseCDRecord.RowCount > 0)
            {
                if (MessageBox.Show("确定要删除吗？", "软件提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    DataGridViewRow dgvr = dgvBarterBaseCDRecord.CurrentRow;
                    if (dgvr.Cells["id"].Value == DBNull.Value)
                    {
                        try
                        {
                            dgvBarterBaseCDRecord.Rows.Remove(dgvr);
                            MessageBox.Show("删除成功", "软件提示");
                        }
                        catch
                        {
                            MessageBox.Show("删除失败", "软件提示");
                        }
                    }
                    else
                    {
                        dgvBarterBaseCDRecord.Rows.Remove(dgvr);
                        if (bbcdr.Delete(bsBarterBaseCDRecord, dgvBarterBaseCDRecord))
                        {
                            MessageBox.Show("删除成功", "软件提示");
                            //bsServiceCDRecord.DataSource = scdr.GetDataTable("ServiceCDRecord", " Where ServiceBillNo = '" + strServiceBillNo + "'");
                            //dgvServiceCDRecord.DataSource = bsServiceCDRecord;
                        }
                        else
                        {
                            //等价于异常
                            MessageBox.Show("删除失败", "软件提示");
                        }
                    }
                }
            }
        }
    }
}
