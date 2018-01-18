using System;
using System.Collections.Generic;
using System.Text;

namespace Daila.NewClass
{
   public class tbProductionClass
	{
		 private string ProNo;
		 public string strProNo
			 {
				 get{ return ProNo;}
				 set{ ProNo=value;}
			 }
		 private string ProName;
		 public string strProName
			 {
				 get{ return ProName;}
				 set{ ProName=value;}
			 }
		 private decimal Price;
		 public decimal dePrice
			 {
				 get{ return Price;}
				 set{ Price=value;}
			 }
		 private string ProPath;
		 public string strProPath
			 {
				 get{ return ProPath;}
				 set{ ProPath=value;}
			 }
		 private string ProType;
		 public string strProType
			 {
				 get{ return ProType;}
				 set{ ProType=value;}
			 }
		 private string ProManufacturer;
		 public string strProManufacturer
			 {
				 get{ return ProManufacturer;}
				 set{ ProManufacturer=value;}
			 }
		 private int ProPOV;
		 public int intProPOV
			 {
				 get{ return ProPOV;}
				 set{ ProPOV=value;}
			 }
		 private string ProExplain;
		 public string strProExplain
			 {
				 get{ return ProExplain;}
				 set{ ProExplain=value;}
			 }
		 private byte[]ProPic;
		 public byte[] bytProPic
			 {
				 get{ return ProPic;}
				 set{ ProPic=value;}
			 }
		 private DateTime ProRegDate;
		 public DateTime daProRegDate
			 {
				 get{ return ProRegDate;}
				 set{ ProRegDate=value;}
			 }
		 private string ProOperator;
		 public string strProOperator
			 {
				 get{ return ProOperator;}
				 set{ ProOperator=value;}
			 }

		 private string ProMemo;
		 public string strProMemo
			 {
				 get{ return ProMemo;}
				 set{ ProMemo=value;}
			 }
       private string ProFalg1;
       public string ProFalg
       {
           get { return ProFalg1; }
           set { ProFalg1 = value; }
       }

	} 
}