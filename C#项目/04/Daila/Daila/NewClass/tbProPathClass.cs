using System;
using System.Collections.Generic;
using System.Text;

namespace Daila.NewClass
{
    public class tbProPathClass
    {
        private string ProId1;//编号
        public string ProID　　//定义编号属性
        {
            get { return ProId1; }
            set { ProId1 = value; }
        }
        private string ProName1;//类别名称
        public string ProName//定义类别名称属性
        {
            get { return ProName1; }
            set { ProName1 = value; }
        }
        private string ProPath1;//是否为空
        public string ProPath//定义属性
        {
            get { return ProPath1; }
            set { ProPath1 = value; }
        }
    }
}
