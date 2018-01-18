using System;
using System.Collections.Generic;
using System.Text;


using System.Web;
using Daila.NewClass;
using System.Data.OleDb;
using System.Data;
namespace Daila.NewMehod
{
    public class tbTelRecordMenthod
    {
        private OleDbCommand oledCmd = null;
        private OleDbConnection oledCon = null;
        private OleDbDataAdapter oledDDa = null;
        private OleDbDataReader oledDr = null;
        private DataSet ds;
        private tbDaiConnection tbDai = null;
        #region //电话记录添加，成功返回1，失败返回0
        public int tbTelRecordAdd(tbTelRecordClass Customer)
        {
            int intFalg = 0;
            try
            {
                tbDai = new tbDaiConnection();
                oledCon = tbDai.OledCon();
                string strAdd = "insert into tb_TelRecord (fldTel,SearchDate,fldChannel,sFile,sType,fldMemo)";
                strAdd += "values('" + Customer.strfldTel + "','" + Customer.daSearchDate + "','" + Customer.shfldChannel + "',";
                strAdd += "'" + Customer.strsFile + "',";
                strAdd += "'" + Customer.strsType + "','" + Customer.strfldMemo + "')";
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
        #region //查询电话记录返回 一个 OleDbDataReade 对象
        public  OleDbDataReader tbTelRecordSecrf(tbTelRecordClass Customer,string strFalg)
        {
            string strSecre = null;
            try
            {
                tbDai = new tbDaiConnection();
                oledCon = tbDai.OledCon();
                if (strFalg == "1")
                {
                    strSecre = "select * from tb_TelRecord where fldTel like '%" + Customer.strfldTel + "%'";
                }
                if (strFalg == "2")
                {
                    strSecre = "select * from tb_TelRecord where sType = '" + Customer.strsType + "'";
                }

             
             
                oledCmd = new OleDbCommand(strSecre, oledCon);
                oledDr = oledCmd.ExecuteReader();
                return oledDr;
            }
            catch (Exception ee)
            {
                return oledDr;;
            }

        }// end fi

        #endregion
        #region //查询电话记录返回 一个 DataSet 对象
        public DataSet tbTelRecordSet(string Customer)
        {
            string strSescf = null;
            try
            {
                tbDai = new tbDaiConnection();
                oledCon = tbDai.OledCon();
                if (Customer!= "")
                {
                    strSescf = "select * from tb_TelRecord where like '" + Customer + "%'";
                }
                else
                {
                    strSescf = "select * from tb_TelRecord";
                }
                oledDDa = new OleDbDataAdapter(strSescf,oledCon);
                ds = new DataSet();
                oledDDa.Fill(ds, "tbTelRecord");
                return ds;
            }
            catch (Exception ee)
            {
                return ds;
            }

        }// end fi

        #endregion
        #region 此方法绑定一个控件，无返回值

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
            

            return ("LV-" + strTime);



        }// end if 
        #endregion


    }
}
