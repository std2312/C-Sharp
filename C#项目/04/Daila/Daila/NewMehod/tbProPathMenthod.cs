using System;
using System.Collections.Generic;
using System.Text;


using Daila.NewClass;
using System.Data.OleDb;
using System.Data;

namespace Daila.NewMehod
{
   public class tbProPathMenthod
    {
        private OleDbCommand oledCmd = null;
        private OleDbConnection oledCon = null;
        private OleDbDataAdapter oledDDa = null;
        private OleDbDataReader oledDr = null;
       private tbDaiConnection tbDai = null;
        #region //添加商品类别信息 成功返回1，失败返回0
        public int tbProPathMenthodAdd(tbProPathClass Customer)
       {
           int intFalg = 0;
           try
           {
               tbDai = new tbDaiConnection();
               oledCon = tbDai.OledCon();
               string strAdd = "insert into tb_ProPath ";
               strAdd += "values('" + Customer.ProID + "','" + Customer.ProName + "','" + Customer.ProPath + "')";
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
       
       }// end fi
        #endregion 
       #region //商品类别编号 例如：LB-20071118114255
       public string tbProPathID()
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
            

            return ("LB-" + strTime);



       }// end if 
       #endregion
       #region //删除商品类别信息 成功返回1，失败返回0
       public int tbProPathUpdate(tbProPathClass Customer)
       {
           int intFalg = 0;
           try
           {
               tbDai = new tbDaiConnection();
               oledCon = tbDai.OledCon();
               string strAdd = "update tb_ProPath set ";
               strAdd += "ProPath='" + Customer.ProPath + "' where ProID='" + Customer.ProID + "' ";
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

       }// end fi
       #endregion 
       #region //查询商品类别信息 成功返回1，失败返回0
       public OleDbDataReader tbProPathSearch()
       {
           try
           {
               tbDai = new tbDaiConnection();
               oledCon = tbDai.OledCon();
               string strAdd = "select * from tb_ProPath where ProPath='"+0+"'";
               oledCmd = new OleDbCommand(strAdd, oledCon);
               oledDr = oledCmd.ExecuteReader();
               return oledDr;
           }
           catch (Exception ee)
           {
               return oledDr;
           }

       }// end fi
              #endregion 
       #region //填冲商品类别信息 TrreView控件
       public void filltbProPath(object objTreeView,object obimage)
       {
           try
           {
               tbDai = new tbDaiConnection();
               oledCon = tbDai.OledCon();
               string strAdd = "select * from tb_ProPath where ProPath='" + 0 + "'";
               oledCmd = new OleDbCommand(strAdd, oledCon);
               oledDr = oledCmd.ExecuteReader();
               if (objTreeView.GetType().ToString() =="System.Windows.Forms.TreeView")
               {
                   System.Windows.Forms.ImageList imlist = (System.Windows.Forms.ImageList)obimage;

                   System.Windows.Forms.TreeView TV = (System.Windows.Forms.TreeView)objTreeView;
                   TV.Nodes.Clear();
                 
                   TV.ImageList = imlist;
                   System.Windows.Forms.TreeNode TN = new System.Windows.Forms.TreeNode("商品分类",0,1);
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
