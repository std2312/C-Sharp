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
using SALE.BLL.SystemSetting;

namespace SALE.UI.SystemSetting
{
    public partial class FormPurviewAssign : Form
    {
        DataLogic dal = new DataLogic();
        Useful useful = new Useful();
        ControlBindDataSource cbds = new ControlBindDataSource();

        public FormPurviewAssign()
        {
            InitializeComponent();
        }

        private void FormPurviewAssign_Load(object sender, EventArgs e)
        {
            cbds.BuildTree(tvOperator, imgListOperator, "操作人员", "Operator", "Where IsFlag <> '1'", "OperatorCode", "OperatorName");
            cbds.CheckedListBoxBindDataSource(chlbModule, "MenuItemTag", "ModuleName", "Select * From SysModule", "SysModule");
        }

        private DataTable GetPurviewAssignInfo(string strOperatorCode)
        {
            string strSql = "SELECT * From PurviewAssign Where OperatorCode = '" + strOperatorCode + "'";
            try
            {
                return dal.GetDataTable(strSql,"");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"软件提示");
                throw ex;
            }
        }

        private void tvOperator_AfterSelect(object sender, TreeViewEventArgs e)
        {
            useful.SetCheckedListBoxState(chlbModule, CheckState.Unchecked);
            if (tvOperator.SelectedNode != null)
            {
                if (tvOperator.SelectedNode.Tag != null)
                {
                    string strFlag = String.Empty;
                    DataTable dt = GetPurviewAssignInfo(tvOperator.SelectedNode.Tag.ToString());
                    for (int i = 0; i < chlbModule.Items.Count; i++)
                    {
                        chlbModule.SelectedIndex = i;
                        DataRow dr = dt.AsEnumerable().FirstOrDefault(itm => itm.Field<string>("MenuItemTag") == chlbModule.SelectedValue.ToString());
                        if (dr == null)
                        {
                            strFlag = "0";
                        }
                        else
                        {
                            strFlag = dr["IsEnabled"].ToString();
                        }
                        chlbModule.SetItemChecked(i, useful.GetCheckedValue(strFlag));
                    }
                }
            }
        }

        private void toolSave_Click(object sender, EventArgs e)
        {
            List<string> strSqls = new List<string>();
            string strSql = String.Empty;
            if (tvOperator.SelectedNode.Tag != null)
            {
                DataTable dt = GetPurviewAssignInfo(tvOperator.SelectedNode.Tag.ToString());
                for (int i = 0; i < chlbModule.Items.Count; i++)
                {
                    chlbModule.SelectedIndex = i;
                    DataRow dr = dt.AsEnumerable().FirstOrDefault(itm => itm.Field<string>("MenuItemTag") == chlbModule.SelectedValue.ToString());
                    if (dr == null)
                    {
                        strSql = "INSERT INTO PurviewAssign(OperatorCode,MenuItemTag,IsEnabled) "
                            + "VALUES('" + tvOperator.SelectedNode.Tag.ToString() + "','" + chlbModule.SelectedValue.ToString() + "','" + useful.GetFlagValue(chlbModule.GetItemCheckState(i)) + "')";
                        strSqls.Add(strSql);
                    }
                    else
                    {
                        if (useful.GetFlagValue(chlbModule.GetItemCheckState(i)) != dr["IsEnabled"].ToString())
                        {
                            strSql = "Update PurviewAssign Set IsEnabled = '" + useful.GetFlagValue(chlbModule.GetItemCheckState(i)) + "' Where OperatorCode = '" + tvOperator.SelectedNode.Tag.ToString() + "' and MenuItemTag = '" + chlbModule.SelectedValue.ToString() + "'";
                            strSqls.Add(strSql);
                        }
                    }
                }

                if (dal.ExecDataBySqls(strSqls))
                {
                    MessageBox.Show("保存成功！", "软件提示");
                }
                else
                {
                    MessageBox.Show("保存失败！", "软件提示");
                }
            }
        }

        private void toolExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
