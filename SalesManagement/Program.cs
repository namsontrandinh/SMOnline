using System;
using System.Collections.Generic;
using System.Windows.Forms;

using SalesManagement.FORM.HeThong;
using SalesManagement.FORM.QuanLyBanHang.BanHang;
using SalesManagement.FORM.QuanLyBanHang.NhapHang;
using SalesManagement.FORM.ThietLapBanDau;

namespace SalesManagement
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmHome());
        }
    }
}
