using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SALE.UI;
using SALE.UI.DataReport.WinForm;
using SALE.UI.SystemSetting;
using SALE.UI.SaleManage;

namespace SALE
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
        }
    }
}
