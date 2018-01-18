using System;
using System.Collections.Generic;
using System.Text;

namespace Daila.NewClass
{
 public class tbCustomerClass
    {
        private string khID1;//客户ID
        public string khID
        {
            get { return khID1; }
            set { khID1 = value; }
        }
        private string khName1;//客户名称
        public string khName
        {
            get { return khName1; }
            set { khName1 = value; }
        }
        private string khPi1;//拼音简码
        public string khPi
        {
            get { return khPi1; }
            set { khPi1 = value; }
        }
        private int khType1;//客户类型
        public int khType
        {
            get { return khType1; }
            set { khType1 = value; }
        }
        private  int khHandye1;//行业
        public int khHandye
        {
            get { return khHandye1; }
            set { khHandye1 = value; }
        }
        private  int khState1;//状态
        public int khState
        {
            get { return khState1; }
            set { khState1 = value; }
        }
        private  string kuTel1;//客户电话
        public string kuTel
        {
            get { return kuTel1; }
            set { kuTel1 = value; }
        }
        private  string kuOffice1;//办公电话
        public string kuOffice
        {
            get { return kuOffice1; }
            set { kuOffice1 = value; }
        }
        private  string kuEmail1;//Email
        public string kuEmail
        {
            get { return kuEmail1; }
            set { kuEmail1 = value; }
        }
        private  string kuAddress1;//单位地址
        public string kuAddress
        {
            get { return kuAddress1; }
            set { kuAddress1 = value; }
        }
        private  string kuChangPi1;//使用产品
        public string kuChangPi
        {
            get { return kuChangPi1; }
            set { kuChangPi1 = value; }
        }
        private  int kuSum1;//数量
        public int kuSum
        {
            get { return kuSum1; }
            set { kuSum1 = value; }
        }
        private  DateTime kuDate1;//登记日期
        public DateTime kuDate
        {
            get { return kuDate1; }
            set { kuDate1 = value; }
        }
        private  string kuEmploy1;//经办人
        public string kuEmploy
        {
            get { return kuEmploy1; }
            set { kuEmploy1 = value; }
        }
        private  DateTime kuDateLaste1;//最后修改日期
        public DateTime kuDateLaste
        {
            get { return kuDateLaste1; }
            set { kuDateLaste1 = value; }
        }
     private int kuFalg1 ;//删除标记
     public int kuFalg
      {
          get { return kuFalg1; }
          set { kuFalg1 = value; }

     }


    }
}
