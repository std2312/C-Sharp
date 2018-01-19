using System;
using System.Collections.Generic;
using System.Text;

using Daila.NewClass;
using System.Data.OleDb;
using System.Data;
namespace Daila.NewMehod
{
    public class tbEmployeeMenthod
    {
        private OleDbCommand oledCmd = null; 
        private OleDbConnection oledCon = null;
        private OleDbDataAdapter oledDDa = null;
        private OleDbDataReader oledDr = null;
        private tbDaiConnection tbDai = null;
        #region//添加员工信息，返回值，　１表示成功，0表示失败
        public int tbEmployeeAdd(tbEmployeeClass Customer)
        {
            int intFalg = 0;
            try
            {
                tbDai = new tbDaiConnection();　　　//实例一个联接数据库对象
                oledCon = tbDai.OledCon();　　　　　//打开数据库
                string strAdd = "insert into tb_Employee "; //创建添加字符串
                strAdd += "values('" + Customer.strEmployeeID + "','" + Customer.strEmpName + "','"+ Customer.EmpEngish+"','"+ Customer.EmpPasword +"','" + Customer.shEmpNation + "',";
                strAdd += "'" + Customer.shEmpSex + "','" + Customer.strEmpIDcard + "','" + Customer.strEmpSpecialty + "','" + Customer.strEmpOfficeTel + "',";
                strAdd += "'" + Customer.strEmpOICQ + "','" + Customer.strEmpEmail + "','" + Customer.shEmpState + "',";
                strAdd += "'" + Customer.shEmpCity + "','" + Customer.EmpWorkDate + "','" + Customer.EmpDemissionDate + "',";
                strAdd += "'" + Customer.strfldEmpRemark + "','" + Customer.byfldEmpWorkFlag +"','" + Customer.EmpRegDate + "')";
                oledCmd = new OleDbCommand(strAdd, oledCon);　//实例OleDbCommand对象
                if (oledCmd.ExecuteNonQuery() != 0)            //调用方法执行添加操作，不等于0添加成功
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
     
        #region//修改员工信息，返回值，　１表示成功，0表示失败
        public int tbEmployeeUpdate(tbEmployeeClass Customer)
        {
            int intFalg = 0;
            try
            {
                tbDai = new tbDaiConnection();       //实例一个联接数据库对象
                oledCon = tbDai.OledCon();           //打开数据库
                string strUpdate = "update tb_Employee set ";   //创建添加字符串
                strUpdate += "EmpName ='" + Customer.strEmpName + "',EmpNation= '" + Customer.shEmpNation + "',EmpEngish='" + Customer.EmpEngish + "',EmpPasword='" + Customer.EmpPasword + "',";
                strUpdate += "EmpSex='" + Customer.shEmpSex + "',EmpIDcard='" + Customer.strEmpIDcard + "',fldEmpBirthday='" + Customer.strEmpSpecialty + "',EmpOfficeTel='" + Customer.strEmpOfficeTel + "',";
                strUpdate += "EmpOICQ='" + Customer.strEmpOICQ + "',EmpEmail='" + Customer.strEmpEmail + "',EmpState='" + Customer.shEmpState + "',";
                strUpdate += "EmpCity='" + Customer.shEmpCity + "',EmpWorkDate='" + Customer.EmpWorkDate + "',EmpDemissionDate='" + Customer.EmpDemissionDate + "',";
                strUpdate += "fldEmpRemark='" + Customer.strfldEmpRemark + "',fldEmpWorkFlag='" + Customer.byfldEmpWorkFlag + "',EmpRegDate='" + Customer.EmpRegDate + "'";
                strUpdate += " where EmployeeID='" + Customer.strEmployeeID + "'";
                oledCmd = new OleDbCommand(strUpdate, oledCon);                  //实例OleDbCommand对象
                if (oledCmd.ExecuteNonQuery() != 0)                     //调用方法执行添加操作，不等于0添加成功
                {
                    intFalg = 1;                        //修改成功
                }
                return intFalg;
            }
            catch (Exception ee)
            {
                return intFalg;
            }
        }
             #endregion
   
        #region //删除员工信息，此方法，是将员工离职状态修改为Ｆａｓｌｅ１表示成功，0表示失败
        public int tbEmployeeDelete(tbEmployeeClass Customer)
        {
            int intFalg = 0;
            try
            {
                tbDai = new tbDaiConnection();                    //实例一个联接数据库对象
                oledCon = tbDai.OledCon();                        //联接数据库
                string strUpdate = "update tb_Employee set ";     //创建删除字符串
                strUpdate += "fldEmpWorkFlag='" + Customer.byfldEmpWorkFlag + "'";
                strUpdate += " where EmployeeID='" + Customer.strEmployeeID + "'";
                oledCmd = new OleDbCommand(strUpdate, oledCon);
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
        #region//查询员工信息，返回，OleDbDataReader对象
        public OleDbDataReader tbEmpSecarf(tbEmployeeClass Customer)
        {
            string strSecarf = null;
            try
            {
                tbDai = new tbDaiConnection();//实例方法类
                oledCon = tbDai.OledCon();//打开数据库联接
                if (Customer.strEmployeeID != "")
                {
                    strSecarf = "select * from tb_Employee where EmployeeID='" + Customer.strEmployeeID + "'";
                }
                else
                {
                    strSecarf = "select * from tb_Employee where fldEmpWorkFlag = false";
                
                }
                oledCmd = new OleDbCommand(strSecarf, oledCon);//实例OleDbCommand对象
                oledDr = oledCmd.ExecuteReader();//调用方法
                return oledDr;
            }
            catch (Exception ee)
            {
                return oledDr;
            }
        }// end if 
        #endregion
        #region //生成员工编号 例如：YG-20071118114255
        public string EmployeeID()
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
            

            return ("YG-" + strTime);



        }// end if 
        #endregion
        #region //填冲客户编信息 TrreView控件
        public void fillEmployee(object objTreeView, object obimage, OleDbDataReader dr)
        {
            try
            {
                tbDai = new tbDaiConnection();
                oledCon = tbDai.OledCon();
                oledDr = dr;
                if (objTreeView.GetType().ToString() == "System.Windows.Forms.TreeView") //判断参数类型
                {
                    System.Windows.Forms.ImageList imlist = (System.Windows.Forms.ImageList)obimage; //实例参数对象
                    System.Windows.Forms.TreeView TV = (System.Windows.Forms.TreeView)objTreeView;  //实例参数对象
                    TV.Nodes.Clear(); //清除节点数据
                    TV.ImageList = imlist; //调置控件属性
                    System.Windows.Forms.TreeNode TN = new System.Windows.Forms.TreeNode("员工编号", 0, 1);//添加根节点
                    while (oledDr.Read())
                    {
                        TN.Nodes.Add("", oledDr[0].ToString(), 0, 1); //添加子节点

                    }
                    TV.Nodes.Add(TN);
                    oledDr.Close();
                    TV.ExpandAll();//展
                }
            }//
            catch (Exception ee)
            {

            }

        }// end fi
          #endregion 
        #region//登录信息
        public int tbEmpLog(tbEmployeeClass Customer)
        {
            string strSecarf = null;
            int intFalg = 0;
            try
            {
                tbDai = new tbDaiConnection();
                oledCon = tbDai.OledCon();

                strSecarf = "select * from tb_Employee where EmpEngish='" + Customer.EmpEngish + "' and EmpPasword='" + Customer.EmpPasword + "'";
               
                oledCmd = new OleDbCommand(strSecarf, oledCon);
                oledDr = oledCmd.ExecuteReader();//
                oledDr.Read();
                if (oledDr.HasRows)
                {
                    intFalg = 1;
                }
                return intFalg;
            }
            catch (Exception ee)
            {
                return intFalg;
            }
        }// end if 

                #endregion
        public int tbEmpSecarfInfo(tbEmployeeClass Customer)
        {
            string strSecarf = null;
            int intFalg=0;
            try
            {
                tbDai = new tbDaiConnection();//实例方法类
                oledCon = tbDai.OledCon();//打开数据库联接
                strSecarf = "select * from tb_Employee where EmpEngish ='" + Customer.EmpEngish + "'";
         
                oledCmd = new OleDbCommand(strSecarf, oledCon);//实例OleDbCommand对象
                oledDr = oledCmd.ExecuteReader();//调用方法
                oledDr.Read();
                if(oledDr.HasRows)
                {
                    intFalg=1;
                }
                oledDr.Close();
                return intFalg;
            }
            catch (Exception ee)
            {
                  return intFalg;
            }
        }// end if 
    


    }
}
