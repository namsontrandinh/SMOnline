using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using SalesManagement.DAL.ThietLapBanDauDAO;
using SalesManagement.ENTITY.ThietLapBanDauEntity;


namespace SalesManagement.BLL.ThietLapBanDauBLL
{
   public class BPhieuBanHang
    {
        /// <summary>
        /// Hiển thị danh sách phiếu bán hàng
        /// </summary>
        public static DataTable GetAll()
        {
            return PhieuBanHangDAO.GetAll();
        }
        /// <summary>
        /// Hiển thị danh sách phiếu bán hàng
        /// </summary>
        public static string GetMaPhieu(string date)
        {
            return PhieuBanHangDAO.GetMaPhieu(date);
        }
        /// <summary>
        /// Hiển thị tổng doanh thu theo ngày
        /// </summary>
        public static DataTable GetSumDay(int fromTime,int toTime)
        {
            
            return PhieuBanHangDAO.GetSumDay(fromTime,toTime);
        }
        /// <summary>
        ///thêm mới phiếu bán hàng không có mã khách
        /// </summary>
        public static void Insert_WithoutMaKhach(EPhieuBanHang ePhieuBanHang)
        {
            PhieuBanHangDAO.Insert_WithoutMaKhach(ePhieuBanHang);
        }
        /// <summary>
        ///thêm mới phiếu bán hàng có mã khách
        /// </summary>
        public static void Insert(EPhieuBanHang ePhieuBanHang)
        {
            PhieuBanHangDAO.Insert(ePhieuBanHang);
        }
    }
}
