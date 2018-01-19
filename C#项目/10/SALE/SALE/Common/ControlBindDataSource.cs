using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using CrystalDecisions.Shared; //TableLogOnInfo
using CrystalDecisions.CrystalReports.Engine; //ReportDocument
using SALE.DAL;

namespace SALE.Common
{
    class ControlBindDataSource
    {
        DataLogic dal = new DataLogic();

        /// <summary>
        /// ComboBox控件绑定到数据源
        /// </summary>
        /// <param name="cbx">ComboBox控件</param>
        /// <param name="strValueColumn">代码列的名称</param>
        /// <param name="strDisplayColumn">名称列的名称</param>
        /// <param name="strSql">查询代码表的SQL语句</param>
        /// <param name="strTableName">代码表名称</param>
        public void ComboBoxBindDataSource(ComboBox cbx, string strValueColumn, string strDisplayColumn, string strSql, string strTableName)
        {
            try
            {
                //cbx.rese
                cbx.BeginUpdate();
                cbx.DataSource = dal.GetDataTable(strSql, strTableName);
                cbx.DisplayMember = strDisplayColumn;
                cbx.ValueMember = strValueColumn;
                cbx.EndUpdate();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "软件提示");
                throw e;
            }
        }

        public void DataGridViewComboBoxColumnBindDataSource(DataGridViewComboBoxColumn dgvcbx, string strValueColumn, string strDisplayColumn, string strSql, string strTableName)
        {
            try
            {
                dgvcbx.DataSource = dal.GetDataTable(strSql, strTableName);
                dgvcbx.DisplayMember = strDisplayColumn;
                dgvcbx.ValueMember = strValueColumn;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "软件提示");
                throw e;
            }
        }

        public void BindDataSource(Control control)
        {
            ComboBox cbx = null;
            foreach (Control con in control.Controls)
            {
                if (con.GetType() == typeof(ComboBox))
                {
                    cbx = con as ComboBox;
                    if (cbx.Tag != null)
                    {
                        switch (cbx.Tag.ToString())
                        {
                            case "BankCode":
                                this.ComboBoxBindDataSource(cbx, "BankCode", "BankName", "Select * From Bank", "Bank");
                                break;
                            case "EmployeeCode":
                                this.ComboBoxBindDataSource(cbx, "EmployeeCode", "EmployeeName", "Select * From Employee", "Employee");
                                break;
                            case "GoodsSeriesCode":
                                this.ComboBoxBindDataSource(cbx, "GoodsSeriesCode", "GoodsSeriesName", "Select * From GoodsSeries", "GoodsSeries");
                                break;
                            case "GoodsTypeCode":
                                this.ComboBoxBindDataSource(cbx, "GoodsTypeCode", "GoodsTypeName", "Select * From GoodsType", "GoodsType");
                                break;
                            case "PayTypeCode":
                                this.ComboBoxBindDataSource(cbx, "PayTypeCode", "PayTypeName", "Select * From PayType", "PayType");
                                break;
                            case "ConsignCorpCode":
                                this.ComboBoxBindDataSource(cbx, "ConsignCorpCode", "ConsignCorpName", "Select * From ConsignCorp", "ConsignCorp");
                                break;
                            case "ProvinceCode":
                                this.ComboBoxBindDataSource(cbx, "ProvinceCode", "ProvinceName", "Select * From Province", "Province");
                                break;
                            case "BarterType":
                                this.ComboBoxBindDataSource(cbx, "BarterType", "Remark", "Select * From SysBarterType", "SysBarterType");
                                break;
                            default:
                                break;
                        }
                    }
                }
                if (con.GetType() == typeof(GroupBox))
                {
                    BindDataSource(con);
                }
            }
        }

        /// <summary>
        /// DataGridViewComboBoxColumn自动绑定到数据源
        /// </summary>
        /// <param name="dgv"></param>
        public void BindDataSource(DataGridView dgv)
        {
            foreach (DataGridViewColumn dgvc in dgv.Columns)
            {
                if (dgvc.GetType() == typeof(DataGridViewComboBoxColumn))  //如果该列的实际类型是“DataGridViewComboBoxColumn”，而不是DataGridViewTextBoxColumn、DataGridViewCheckBoxColumn等等
                {
                    DataGridViewComboBoxColumn dgvcbx = dgvc as DataGridViewComboBoxColumn;  // DataGridViewComboBoxColumn继承自DataGridViewColumn
                    switch (dgvcbx.DataPropertyName)
                    {
                        case "BankCode":
                            this.DataGridViewComboBoxColumnBindDataSource(dgvcbx, "BankCode", "BankName", "Select * From Bank", "Bank");
                            break;
                        case "EmployeeCode":
                            this.DataGridViewComboBoxColumnBindDataSource(dgvcbx, "EmployeeCode", "EmployeeName", "Select * From Employee", "Employee");
                            break;
                        case "GoodsSeriesCode":
                            this.DataGridViewComboBoxColumnBindDataSource(dgvcbx, "GoodsSeriesCode", "GoodsSeriesName", "Select * From GoodsSeries", "GoodsSeries");
                            break;
                        case "GoodsTypeCode":
                            this.DataGridViewComboBoxColumnBindDataSource(dgvcbx, "GoodsTypeCode", "GoodsTypeName", "Select * From GoodsType", "GoodsType");
                            break;
                        case "PayTypeCode":
                            this.DataGridViewComboBoxColumnBindDataSource(dgvcbx, "PayTypeCode", "PayTypeName", "Select * From PayType", "PayType");
                            break;
                        case "ConsignCorpCode":
                            this.DataGridViewComboBoxColumnBindDataSource(dgvcbx, "ConsignCorpCode", "ConsignCorpName", "Select * From ConsignCorp", "ConsignCorp");
                            break;
                        case "ProvinceCode":
                            this.DataGridViewComboBoxColumnBindDataSource(dgvcbx, "ProvinceCode", "ProvinceName", "Select * From Province", "Province");
                            break;
                        case "BarterType":
                            this.DataGridViewComboBoxColumnBindDataSource(dgvcbx, "BarterType", "Remark", "Select * From SysBarterType", "SysBarterType");
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// TreeView控件绑定到数据源
        /// </summary>
        /// <param name="tv">TreeView控件</param>
        /// <param name="imgList">ImageList控件</param>
        /// <param name="rootName">根节点的文本属性值</param>
        /// <param name="strTableName">要绑定的数据表</param>
        /// <param name="strWhere">查询条件字符串</param>
        /// <param name="strCode">数据表的代码列</param>
        /// <param name="strName">数据表的名称列</param>
        public void BuildTree(TreeView tv, ImageList imgList, string rootName, string strTableName,string strWhere, string strCode, string strName)
        {
            string strSql = null;
            TreeNode rootNode = null;
            TreeNode childNode = null;
            strSql = "select " + strCode + " , " + strName + " from " + strTableName + " " + strWhere;
            tv.Nodes.Clear();
            tv.ImageList = imgList;
            //创建根节点
            rootNode = new TreeNode();
            rootNode.Tag = null;
            rootNode.Text = rootName;
            rootNode.ImageIndex = 1;
            rootNode.SelectedImageIndex = 0;
            try
            {
                DataTable dt = dal.GetDataTable(strSql, strTableName);
                foreach (DataRow row in dt.Rows)
                {
                    //创建子节点
                    childNode = new TreeNode();
                    childNode.Tag = row[strCode];
                    childNode.Text = row[strName].ToString();
                    childNode.ImageIndex = 1;
                    childNode.SelectedImageIndex = 0;
                    rootNode.Nodes.Add(childNode);
                }
                tv.Nodes.Add(rootNode);
                tv.ExpandAll();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "软件提示");
                throw e;
            }
        }

        /// <summary>
        /// CheckedListBox控件绑定到数据源
        /// </summary>
        /// <param name="chlb">CheckedListBox控件</param>
        /// <param name="strValueColumn">代码列的名称</param>
        /// <param name="strDisplayColumn">名称列的名称</param>
        /// <param name="strSql">查询代码表的SQL语句</param>
        /// <param name="strTableName">代码表的名称</param>
        public void CheckedListBoxBindDataSource(CheckedListBox chlb, string strValueColumn, string strDisplayColumn, string strSql, string strTableName)
        {
            try
            {
                chlb.BeginUpdate();
                chlb.DataSource = dal.GetDataTable(strSql, strTableName);
                chlb.DisplayMember = strDisplayColumn;
                chlb.ValueMember = strValueColumn;
                chlb.EndUpdate();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "软件提示");
                throw e;
            }
        }

        /// <summary>
        /// 实例化ReportDocument
        /// </summary>
        /// <param name="strReportFileName">报表文件的名称</param>
        /// <param name="strSql">查询SQL语句</param>
        /// <param name="strTable">数据表</param>
        /// <returns>ReportDocument对象的引用</returns>
        public ReportDocument CrystalReports(string strReportFileName, string strSql, string strTable)
        {
            //获取报表路径
            string strReportPath = Application.StartupPath.Substring(0, Application.StartupPath.Substring(0,
                Application.StartupPath.LastIndexOf("\\")).LastIndexOf("\\"));
            strReportPath += strReportFileName;
            //得到dt数据源
            DataTable dt = dal.GetDataTable(strSql, strTable);
            //ReportDocument对象加载rpt文件并绑定到数据源dt
            ReportDocument reportDoc = new ReportDocument();
            reportDoc.Load(strReportPath);
            reportDoc.SetDataSource(dt.DefaultView); //DataView是接口IEnumerable的实现子类,此处使用了“接口”的多态特性

            //水晶报表动态链接数据库
            TableLogOnInfo logOnInfo = new TableLogOnInfo();
            logOnInfo.ConnectionInfo.ServerName = OperFile.GetIniFileString("DataBase", "Server", "", Application.StartupPath + "\\SALE.ini");
            logOnInfo.ConnectionInfo.DatabaseName = "SALE";
            logOnInfo.ConnectionInfo.UserID = OperFile.GetIniFileString("DataBase", "UserID", "", Application.StartupPath + "\\SALE.ini");
            logOnInfo.ConnectionInfo.Password = OperFile.GetIniFileString("DataBase", "Pwd", "", Application.StartupPath + "\\SALE.ini");

            // 对报表中的每个表依次循环(把连接信息存入每一个Table中)
            foreach (Table tb in reportDoc.Database.Tables)
            {
                tb.ApplyLogOnInfo(logOnInfo);
            }

            //返回ReportDocument对象 
            return reportDoc;
        }

        /// <summary>
        /// 处理空白水晶报表
        /// </summary>
        /// <param name="strReportFileName"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public ReportDocument CrystalReports(string strReportFileName, DataTable dt)
        {
            //获取报表路径
            string strReportPath = Application.StartupPath.Substring(0, Application.StartupPath.Substring(0,
                Application.StartupPath.LastIndexOf("\\")).LastIndexOf("\\"));
            strReportPath += strReportFileName;
            //ReportDocument对象加载rpt文件并绑定到数据源dt
            ReportDocument reportDoc = new ReportDocument();
            reportDoc.Load(strReportPath);
            reportDoc.SetDataSource(dt.DefaultView);
            return reportDoc;
        }
    }
}
