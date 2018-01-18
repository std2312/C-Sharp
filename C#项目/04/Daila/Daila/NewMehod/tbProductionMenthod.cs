using System;
using System.Collections.Generic;
using System.Text;

using Daila.NewClass;
using System.Data.OleDb;
using System.Data;

namespace Daila.NewMehod
{

   public class tbProductionMenthod
    {
        private OleDbCommand oledCmd = null;
        private OleDbConnection oledCon = null;
        private OleDbDataAdapter oledDDa = null;
        private OleDbDataReader oledDr = null;
        private DataSet ds;
        private tbDaiConnection tbDai = null;
        #region//添加产品信息，返回值，　１表示成功，0表示失败
       public int tbProductionAdd(tbProductionClass Customer)
        {
            int intFalg = 0;
            try
            {
                tbDai = new tbDaiConnection();
                oledCon = tbDai.OledCon();
                string strAdd = "insert into tb_Production ";
                strAdd += "values('"+ Customer.strProNo + "','" + Customer.strProName + "','" + Customer.dePrice + "','"+ Customer.strProPath+"',";
                strAdd += "'" + Customer.strProManufacturer + "','" + Customer.intProPOV + "','" + Customer.strProExplain + "',";
                strAdd += "'" + Customer.daProRegDate + "','" + Customer.strProOperator + "',";
                strAdd += "'" + Customer.strProMemo + "','"+ Customer.ProFalg +"')";
                oledCmd = new OleDbCommand(strAdd, oledCon);
                if (oledCmd.ExecuteNonQuery() != 0)
                {
                    intFalg = 1;//添加成功
                }
                return intFalg;
            }
            catch (Exception ee)
            {
                return intFalg;
            }
        }// end if 
        #endregion
        #region//修改产品信息，返回值，　１表示成功，0表示失败
        public int tbProductionUpdate(tbProductionClass Customer)
        {
            int intFalg = 0;
            try
            {
                tbDai = new tbDaiConnection();
                oledCon = tbDai.OledCon();
                string strAdd = "update tb_Production set ";
                strAdd += "ProName='" + Customer.strProName + "',SellPrice='" + Customer.dePrice + "',ProPath='" + Customer.strProPath + "',";
                strAdd += "ProManufacturer='" + Customer.strProManufacturer + "',ProPOV='" + Customer.intProPOV + "',ProExplain ='" + Customer.strProExplain + "',";
                strAdd += "ProRegDate='" + Customer.daProRegDate + "',ProOperator='" + Customer.strProOperator + "',";
                strAdd += "ProMemo='" + Customer.strProMemo + "',ProFalg='" + Customer.ProFalg + "' where ProNo='" + Customer.strProNo + "'";
              
                oledCmd = new OleDbCommand(strAdd, oledCon);
                if (oledCmd.ExecuteNonQuery() != 0)
                {
                    intFalg = 1;//添加成功
                }
                return intFalg;
            }
            catch (Exception ee)
            {
                return intFalg;
            }
        }// end if 
        #endregion
        #region//删除产品信息，返回值，　１表示成功，0表示失败
        public int tbProductionDelete(tbProductionClass Customer)
        {
            int intFalg = 0;
            try
            {
                tbDai = new tbDaiConnection();
                oledCon = tbDai.OledCon();
                string strAdd = "update tb_Production set ";
             
                strAdd += "ProFalg='" + Customer.ProFalg + "' where ProNo='" + Customer.strProNo + "'";

                oledCmd = new OleDbCommand(strAdd, oledCon);
                if (oledCmd.ExecuteNonQuery() != 0)
                {
                    intFalg = 1;//添加成功
                }
                return intFalg;
            }
            catch (Exception ee)
            {
                return intFalg;
            }
        }// end if 
        #endregion
        #region//查询产品信息，返回，OleDbDataReader对象
       public OleDbDataReader tbProductionSecarf(tbProductionClass Customer)
        {
            string strSecarf = null;
            try
            {
                tbDai = new tbDaiConnection();
                oledCon = tbDai.OledCon();
                strSecarf = "select * from tb_Production where ProNo='" + Customer.strProNo + "'";
                oledCmd = new OleDbCommand(strSecarf, oledCon);
                oledDr = oledCmd.ExecuteReader();//
                return oledDr;
            }
            catch (Exception ee)
            {
                return oledDr;
            }
        }// end if 
         #endregion
        #region //生成产品编号 例如：CP-20071118114255
       public string tbProductionID()
        {
           int intYear= DateTime.Now.Day;
            int intMonth=DateTime.Now.Month;
            int intDate=DateTime.Now.Year;
            int intHour=DateTime.Now.Hour;
            int intSecond=DateTime.Now.Second;
           int intMinute=DateTime.Now.Minute;
           string strTime = null;
           strTime = intYear.ToString();
           if (intMonth < 10)
           {
               strTime += "0" + intMonth.ToString();
           }
           else
           {
               strTime += intMonth.ToString();
           }
           if (intDate < 10)
           {
               strTime += "0" + intDate.ToString();
           }
           else
           {
               strTime += intDate.ToString();
           }
           if (intHour < 10)
           {
               strTime += "0" + intHour.ToString();
           }
           else
           {
               strTime += intHour.ToString();
           }
           if (intMinute < 10)
           {

               strTime += "0" + intMinute.ToString();
           }
           else
           {
               strTime += intMinute.ToString();
           }
           if (intSecond < 10)
           {

               strTime += "0" + intSecond.ToString();
           }
           else
           {
               strTime += intSecond.ToString();
           }
            

            return ("CP-" + strTime);



        }// end if 
   #endregion
        #region //填冲商品类别信息 TrreView控件
        public void filltProd(object objTreeView, object obimage)
        {
            try
            {
                tbDai = new tbDaiConnection();
                oledCon = tbDai.OledCon();
                string strAdd = "select * from tb_Production where ProFalg='" + 0 + "'";
                oledCmd = new OleDbCommand(strAdd, oledCon);
                oledDr = oledCmd.ExecuteReader();
                if (objTreeView.GetType().ToString() == "System.Windows.Forms.TreeView")
                {
                    System.Windows.Forms.ImageList imlist = (System.Windows.Forms.ImageList)obimage;

                    System.Windows.Forms.TreeView TV = (System.Windows.Forms.TreeView)objTreeView;
                    TV.Nodes.Clear();

                    TV.ImageList = imlist;
                    System.Windows.Forms.TreeNode TN = new System.Windows.Forms.TreeNode("商品名称", 0, 1);
                    while (oledDr.Read())
                    {
                        TN.Nodes.Add("", oledDr[1].ToString(), 0, 1);

                    }
                    TV.Nodes.Add(TN);
                    oledDr.Close();
                    TV.ExpandAll();
                }
            }//
            catch (Exception ee)
            {

            }

        }// end fi
        #endregion 


    }
}
