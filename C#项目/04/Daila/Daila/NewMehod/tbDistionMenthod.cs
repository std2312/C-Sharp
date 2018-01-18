using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace Daila.NewMehod
{
    //此类功能，一些字典表填冲控件
    public class tbDistionMenthod
    {
      
        private OleDbConnection oledCon = null;
        private OleDbDataAdapter oledDDa = null;
        private OleDbDataReader oledDr = null;
        private DataSet ds;
        private tbDaiConnection tbDai = null;
        #region tb_CodEB学历表，填冲CombOX控件
        public void filltb_CodEB(object comb)
        {
            tbDai = new tbDaiConnection();
            oledCon = tbDai.OledCon();
            oledDDa = new OleDbDataAdapter("select EBCaption from tb_CodEB",oledCon);
            ds = new DataSet();
            oledDDa.Fill(ds);
            if (comb.GetType().ToString() == "System.Windows.Forms.ComboBox")
            {
                System.Windows.Forms.ComboBox cmb = (System.Windows.Forms.ComboBox)comb;
                cmb.DataSource = ds.Tables[0].DefaultView;
                cmb.DisplayMember = "EBCaption";
            }
            oledCon.Close();
        
        }//
        #endregion
        #region tb_EmpSex 性别表，填冲CombOX控件
        public void filltb_EmpSex(object comb)
        {
            tbDai = new tbDaiConnection();
            oledCon = tbDai.OledCon();
            oledDDa = new OleDbDataAdapter("select Caption from tb_EmpSex ", oledCon);
            ds = new DataSet();
            oledDDa.Fill(ds);
            if (comb.GetType().ToString() == "System.Windows.Forms.ComboBox")
            {
                System.Windows.Forms.ComboBox cmb = (System.Windows.Forms.ComboBox)comb;
                cmb.DataSource = ds.Tables[0].DefaultView;
                cmb.DisplayMember = "Caption";
            }
            oledCon.Close();
        
        }//
        #endregion
        #region tb_Importance 客户重要性
        public void filltb_Importance(object comb)
        {
            tbDai = new tbDaiConnection();
            oledCon = tbDai.OledCon();
            oledDDa = new OleDbDataAdapter("select Caption from tb_Importance ", oledCon);
            ds = new DataSet();
            oledDDa.Fill(ds);
            if (comb.GetType().ToString() == "System.Windows.Forms.ComboBox")
            {
                System.Windows.Forms.ComboBox cmb = (System.Windows.Forms.ComboBox)comb;
                cmb.DataSource = ds.Tables[0].DefaultView;
                cmb.DisplayMember = "Caption";
            }
            oledCon.Close();

        }//
        #endregion
        #region tb_Industry行业字典表填冲CombOX控件
        public void filltb_Industry(object comb)
        {
            tbDai = new tbDaiConnection();
            oledCon = tbDai.OledCon();
            oledDDa = new OleDbDataAdapter("select Caption from tb_Industry ", oledCon);
            ds = new DataSet();
            oledDDa.Fill(ds);
            if (comb.GetType().ToString() == "System.Windows.Forms.ComboBox")
            {
                System.Windows.Forms.ComboBox cmb = (System.Windows.Forms.ComboBox)comb;
                cmb.DataSource = ds.Tables[0].DefaultView;
                cmb.DisplayMember = "Caption";
            }
            oledCon.Close();
        }
        #endregion
        #region tb_Marital婚姻状态
        public void filltb_Marital(object comb)
        {
            tbDai = new tbDaiConnection();
            oledCon = tbDai.OledCon();
            oledDDa = new OleDbDataAdapter("select LCaption from tb_Marital ", oledCon);
            ds = new DataSet();
            oledDDa.Fill(ds);
            if (comb.GetType().ToString() == "System.Windows.Forms.ComboBox")
            {
                System.Windows.Forms.ComboBox cmb = (System.Windows.Forms.ComboBox)comb;
                cmb.DataSource = ds.Tables[0].DefaultView;
                cmb.DisplayMember = "LCaption";
            }
            oledCon.Close();
        }
        #endregion

        #region tb_Nation民族表
        public void filltb_Nation(object comb)
        {
            tbDai = new tbDaiConnection();
            oledCon = tbDai.OledCon();
            oledDDa = new OleDbDataAdapter("select LCaption from tb_Nation ", oledCon);
            ds = new DataSet();
            oledDDa.Fill(ds);
            if (comb.GetType().ToString() == "System.Windows.Forms.ComboBox")
            {
                System.Windows.Forms.ComboBox cmb = (System.Windows.Forms.ComboBox)comb;
                cmb.DataSource = ds.Tables[0].DefaultView;
                cmb.DisplayMember = "LCaption";
            }
            oledCon.Close();
        }
        #endregion
        #region  tb_Type客户状态
        public void filltb_Type(object comb)
        {
            tbDai = new tbDaiConnection();
            oledCon = tbDai.OledCon();
            oledDDa = new OleDbDataAdapter("select LCaption from tb_Type", oledCon);
            ds = new DataSet();
            oledDDa.Fill(ds);
            if (comb.GetType().ToString() == "System.Windows.Forms.ComboBox")
            {
                System.Windows.Forms.ComboBox cmb = (System.Windows.Forms.ComboBox)comb;
                cmb.DataSource = ds.Tables[0].DefaultView;
                cmb.DisplayMember = "LCaption";
            }
            oledCon.Close();
        }
        #endregion
        #region tb_Production 产品名称
        public void filltb_Production(object comb)
        {
            tbDai = new tbDaiConnection();
            oledCon = tbDai.OledCon();
            oledDDa = new OleDbDataAdapter("select ProName from tb_Production", oledCon);
            ds = new DataSet();
            oledDDa.Fill(ds);
            if (comb.GetType().ToString() == "System.Windows.Forms.ComboBox")
            {
                System.Windows.Forms.ComboBox cmb = (System.Windows.Forms.ComboBox)comb;
                cmb.DataSource = ds.Tables[0].DefaultView;
                cmb.DisplayMember = "ProName";
            }
            oledCon.Close();
        }
        #endregion
    }
}
