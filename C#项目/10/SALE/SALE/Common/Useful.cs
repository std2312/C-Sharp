using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using SALE.DAL;

namespace SALE.Common
{
    class Useful
    {
        /// <summary>
        /// 生成各种数据表的代码字段的值
        /// </summary>
        /// <param name="strTableName">数据表名</param>
        /// <param name="strHeader">各种代码头</param>
        /// <param name="intLength">代码可变动部分的长度</param>
        /// <returns></returns>
        public string BuildCode(string strTableName,string strWhere,string strCodeColumn,string strHeader, int intLength)
        {
            DataLogic dal = new DataLogic();
            string strSql = "Select Max(" + strCodeColumn + ") From " + strTableName + " " + strWhere;
            try
            {
                string strMaxCode = dal.GetSingleObject(strSql) as string;
                if (String.IsNullOrEmpty(strMaxCode))
                {
                    strMaxCode = strHeader + FormatString(intLength);
                }
                string strMaxSeqNum = strMaxCode.Substring(strHeader.Length);
                return strHeader + (Convert.ToInt32(strMaxSeqNum) + 1).ToString(FormatString(intLength));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"软件提示");
                throw ex;
            }
        }

        /// <summary>
        /// 格式化具有流水性质的编号
        /// </summary>
        /// <param name="intLength"></param>
        /// <returns></returns>
        public string FormatString(int intLength)
        {
            string strFormat = String.Empty;
            for (int i = 0; i < intLength; i++)
            {
                strFormat = strFormat + "0";
            }
            return strFormat;
        }

        /// <summary>
        /// 获取数据库系统的时间
        /// </summary>
        /// <returns>数据库系统时间</returns>
        public DateTime GetDBTime()
        {
            DateTime dtDBTime;
            DataLogic dal = new DataLogic();
            try
            {
                dtDBTime = Convert.ToDateTime(dal.GetSingleObject("SELECT GETDATE()"));
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "软件提示");
                throw e;
            }

            return dtDBTime;
        }

        /// <summary>
        /// 控制可编辑控件的键盘输入，该方法限定控件只可以接收表示非负十进制数的字符
        /// </summary>
        /// <param name="e">为 KeyPress 事件提供数据</param>
        /// <param name="txt">可编辑文本控件</param>
        public void InputNumeric(KeyPressEventArgs e, TextBox txt)
        {
            //在可编辑控件的Text属性为空的情况下，不允许输入".字符"
            if (String.IsNullOrEmpty(txt.Text) && e.KeyChar.ToString() == ".")
            {
                //把Handled设为true，取消KeyPress事件，防止控件处理按键
                e.Handled = true;
            }

            //可编辑控件不允许输入多个"."字符
            if (txt.Text.Contains(".") && e.KeyChar.ToString() == ".")
            {
                e.Handled = true;
            }

            //在可编辑控件中，只可以输入“数字字符”、".字符" 、"字符"(删除键对应的字符)
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar.ToString() != "." && e.KeyChar.ToString() != "")
            {
                e.Handled = true;
            }

            //con.Text = e.KeyChar.ToString();
        }

        /// <summary>
        /// 控制可编辑控件的键盘输入，该方法限定控件只可以接收表示非负整数的字符
        /// </summary>
        /// <param name="e">为 KeyPress 事件提供数据</param>
        public void InputInteger(KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar.ToString() != "")
            {
                //把Handled设为true，取消KeyPress事件，防止控件处理按键
                e.Handled = true;
            }
        }

        public void SetFocus(KeyEventArgs e, Control con)
        {
            if (e.KeyCode == Keys.Enter)
            {
                con.Focus();
            }
        }

        public bool GetCheckedValue(string strFlag)
        {
            if (strFlag == "1")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string GetFlagValue(CheckBox chb)
        {
            if (chb.Checked)
            {
                return "1";
            }
            else
            {
                return "0";
            }
        }

        public string GetFlagValue(CheckState check)
        {
            if (check == CheckState.Checked)
            {
                return "1";
            }
            else
            {
                return "0";
            }
        }

        //public void PressEnterKey(KeyEventArgs e, Control con)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        con.Focus();
        //    }
        //}

        /// <summary>
        /// 清空DataGridView
        /// </summary>
        /// <param name="dgv">DataGridView控件</param>
        public void DataGridViewReset(DataGridView dgv)
        {
            if (dgv.DataSource != null)
            {
                //若DataGridView绑定的数据源为DataTable
                if (dgv.DataSource.GetType() == typeof(DataTable))
                {
                    DataTable dt = dgv.DataSource as DataTable;
                    dt.Clear();
                }

                //若DataGridView绑定的数据源为BindingSource
                if (dgv.DataSource.GetType() == typeof(BindingSource))
                {
                    BindingSource bs = dgv.DataSource as BindingSource;
                    DataTable dt = bs.DataSource as DataTable;
                    dt.Clear();
                }
            }
        }

        public void SetCheckedListBoxState(CheckedListBox chlb, CheckState check)
        {
            for (int i = 0; i < chlb.Items.Count; i++)
            {
                chlb.SetItemCheckState(i, check);
            }
        }

        /// <summary>
        /// 设置窗体控件的默认值
        /// </summary>
        /// <param name="control">窗体实例的引用</param>
        public void InitFormContros(Control control, List<Control> debarCons)
        {
            foreach (Control con in control.Controls)
            {
                if (con.GetType() == typeof(TextBox))  //若是TextBox控件
                {
                    if (debarCons != null)
                    {
                        if (debarCons.Contains(con))
                        {
                            continue;
                        }
                    }
                    con.Text = "";  
                } 
                if (con.GetType() == typeof(ComboBox))  //若是ComboBox控件
                {
                    ((ComboBox)con).SelectedIndex = -1;  //未选择任何项
                }
                if (con.GetType() == typeof(DateTimePicker))  //若是DateTimePicker控件
                {
                    ((DateTimePicker)con).Value = GlobalProperty.DBTime;  //当前日期
                    if (((DateTimePicker)con).ShowCheckBox)
                    {
                        ((DateTimePicker)con).Checked = true;
                    }
                }
                if (con.GetType() == typeof(GroupBox))  //若是GroupBox控件
                {
                    InitFormContros(con, debarCons);  //递归执行程序
                }
            }
        }

        /// <summary>
        /// 设置窗体中所有控件的启用状态或编辑状态
        /// </summary>
        /// <param name="control">窗体实例的引用</param>
        /// <param name="boolValue">表是状态的bool值</param>
        public void SetControlsState(Control control,bool boolValue)
        {
            foreach (Control con in control.Controls)
            {
                if (con.GetType() == typeof(TextBox))  //若是TextBox
                {
                    //((TextBox)con).ReadOnly = !boolValue;  //设置ReadOnly属性
                    ((TextBox)con).Enabled = boolValue;
                }
                if (con.GetType() == typeof(ComboBox))  //若是ComboBox
                {
                    ((ComboBox)con).Enabled = boolValue;  //设置Enabled属性
                }
                if (con.GetType() == typeof(DateTimePicker))  //若是DateTimePicker
                {
                    ((DateTimePicker)con).Enabled = boolValue; //设置Enabled属性
                }
                if (con.GetType() == typeof(CheckBox))  //若是CheckBox
                {
                    ((CheckBox)con).Enabled = boolValue; //设置Enabled属性
                }
                if (con.GetType() == typeof(RadioButton))  //若是RadioButton
                {
                    ((RadioButton)con).Enabled = boolValue; //设置Enabled属性
                }
                if (con.GetType() == typeof(GroupBox))  //若是GroupBox
                {
                    SetControlsState(con, boolValue);  //递归执行程序
                }
            }
        }

        /// <summary>
        /// 打开一个模式窗体
        /// </summary>
        /// <param name="typeForm">被打开窗体的Type</param>
        /// <param name="strTag"></param>
        /// <param name="formParent">被打开窗体的拥有者</param>
        public void ShowDialogForm(Type typeForm, string strTag,Form formParent)
        {
            Form form = Activator.CreateInstance(typeForm) as Form;
            form.Tag = strTag;
            form.Owner = formParent;
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
        }

        /// <summary>
        /// 判断数据表中记录的主键值是否存在外键约束
        /// </summary>
        /// <param name="strPrimaryTable">主键表</param>
        /// <param name="strPrimaryValue">数据表中某条记录主键的值</param>
        /// <returns></returns>
        public bool IsExistConstraint(string strPrimaryTable, string strPrimaryValue)
        {
            DataLogic dal = new DataLogic();
            bool booIsExist = false;
            string strSql = null;
            string strForeignColumn = null;
            string strForeignTable = null;
            SqlDataReader sdr = null;
            try
            {
                //创建SqlParameter对象，并赋值
                SqlParameter param = new SqlParameter("@PrimaryTable", SqlDbType.VarChar);
                param.Value = strPrimaryTable;
                //创建泛型
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(param);
                //把泛型中的元素复制到数组中
                SqlParameter[] inputParameters = parameters.ToArray();
                //通过存储过程得到外键表的相关数据
                DataTable dt = dal.GetDataTable("P_QueryForeignConstraint", inputParameters);

                //循环这些相关数据
                foreach (DataRow dr in dt.Rows)
                {
                    strForeignTable = dr["ForeignTable"].ToString();
                    strForeignColumn = dr["ForeignColumn"].ToString();
                    strSql = "Select " + strForeignColumn + " From " + strForeignTable + " Where " + strForeignColumn + " = '" + strPrimaryValue + "'";
                    sdr = dal.GetDataReader(strSql);

                    if (sdr.HasRows)
                    {
                        booIsExist = true;
                        sdr.Close();
                        //跳出循环
                        break;
                    }

                    sdr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "软件提示");
                throw ex;
            }
            return booIsExist;
        }
    }
}
