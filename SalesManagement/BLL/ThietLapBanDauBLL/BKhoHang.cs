using SalesManagement.DAL.ThietLapBanDauDAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SalesManagement.BLL.ThietLapBanDauBLL
{
   public class BKhoHang
    {
        /// <summary>
        /// Hiển thị danh sách hàng trong kho hàng
        /// </summary>
        public static DataTable GetAll()
        {
            return KhoHangDAO.GetAll();
        }
        /// <summary>
        /// Hiển thị danh sách hàng trong kho theo mã kho
        /// </summary>
        public static DataTable GetByMaKho(string maKho)
        {
            return KhoHangDAO.GetByMaKho(maKho);
        }
        /// <summary>
        /// Hiển thị danh sách hàng trong kho theo mã hàng
        /// </summary>
        public static DataTable GetByMaHang(string maHang)
        {
            return KhoHangDAO.GetByMaHang(maHang);
        }
    }
}
