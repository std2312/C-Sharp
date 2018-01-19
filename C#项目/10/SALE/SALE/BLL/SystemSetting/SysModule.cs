using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SALE.BLL.SystemSetting
{
    class SysModule
    {
        private string m_MenuItemTag;
        public string MenuItemTag
        {
            get
            {
                return m_MenuItemTag;
            }
            set
            {
                m_MenuItemTag = value;
            }
        }

        private string m_ModuleName;
        public string ModuleName
        {
            get
            {
                return m_ModuleName;
            }
            set
            {
                m_ModuleName = value;
            }
        }
    }
}
