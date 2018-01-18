using System;
using System.Collections.Generic;
using System.Text;

namespace Daila.NewClass
{
	public class tbTelRecordClass
	{
		 private int ID;
		 public int intID
			 {
				 get{ return ID;}
				 set{ ID=value;}
			 }
		 private string fldTel;
		 public string strfldTel
			 {
				 get{ return fldTel;}
				 set{ fldTel=value;}
			 }
		 private DateTime SearchDate;
		 public DateTime daSearchDate
			 {
				 get{ return SearchDate;}
				 set{ SearchDate=value;}
			 }
		 private int fldChannel;
		 public int shfldChannel
			 {
				 get{ return fldChannel;}
				 set{ fldChannel=value;}
			 }
		 private string PhoneNumber;
		 public string strPhoneNumber
			 {
				 get{ return PhoneNumber;}
				 set{ PhoneNumber=value;}
			 }
		 private byte[] sFile;
		 public byte[]  strsFile
			 {
				 get{ return sFile;}
				 set{ sFile=value;}
			 }
		 private int iTime;
		 public int intiTime
			 {
				 get{ return iTime;}
				 set{ iTime=value;}
			 }
		 private string sType;
		 public string strsType
			 {
				 get{ return sType;}
				 set{ sType=value;}
			 }
		 
		 private string fldMemo;
		 public string strfldMemo
			 {
				 get{ return fldMemo;}
				 set{ fldMemo=value;}
			 }
	} 
}