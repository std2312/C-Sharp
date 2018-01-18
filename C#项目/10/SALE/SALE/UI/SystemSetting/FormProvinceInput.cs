using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SALE.Common;
using SALE.BLL.SystemSetting;

namespace SALE.UI.SystemSetting
{
    public partial class FormProvinceInput : Form
    {
        FormProvince formProvince = null;
        Useful useful = new Useful();

        public FormProvinceInput()
        {
            InitializeComponent();
        }

        private void FormProvinceInput_Load(object sender, EventArgs e)
        {
            formProvince = (FormProvince)this.Owner;
            if (this.Tag.ToString() == "Add")
            {
                txtProvinceCode.Text = useful.BuildCode("Province", "", "ProvinceCode", "", 2);
            }
            if (this.Tag.ToString() == "Edit")
            {
                txtProvinceCode.Text = formProvince.dgvProvince.CurrentRow.Cells["ProvinceCode"].Value.ToString();
                txtProvinceName.Text = formProvince.dgvProvince.CurrentRow.Cells["ProvinceName"].Value.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Province p = new Province();
            if (String.IsNullOrEmpty(txtProvinceName.Text.Trim()))
            {
                MessageBox.Show("省市名称不许为空！","软件提示");
                txtProvinceName.Focus();
                return;
            }
            if (this.Tag.ToString() == "Add")
            {
                DataGridViewRow dgvr = p.AddDataGridViewRow(formProvince.dgvProvince, formProvince.bsProvince);
                dgvr.Cells["ProvinceCode"].Value = txtProvinceCode.Text;
                dgvr.Cells["ProvinceName"].Value = txtProvinceName.Text.Trim();
                if (p.Insert(formProvince.bsProvince))
                {
                    if (MessageBox.Show("保存成功，是否继续添加？", "软件提示", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        txtProvinceCode.Text = useful.BuildCode("Province", "", "ProvinceCode", "", 2);
                        txtProvinceName.Text = "";
                        txtProvinceName.Focus();
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
                DataGridViewRow dgvr = formProvince.dgvProvince.CurrentRow;
                dgvr.Cells["ProvinceName"].Value = txtProvinceName.Text.Trim();
                if (p.Update(formProvince.bsProvince))
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
