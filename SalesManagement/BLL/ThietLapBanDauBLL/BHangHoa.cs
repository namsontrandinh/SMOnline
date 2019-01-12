using SalesManagement.DAL.ThietLapBanDauDAO;
using SalesManagement.ENTITY.ThietLapBanDauEntity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SalesManagement.BLL.ThietLapBanDauBLL
{
    public class BHangHoa
    {
        /// <summary>
        /// Hiển thị tất cả hàng hóa
        /// </summary>
        public static DataTable GetAll()
        {
            return HangHoaDAO.GetAll();
        }
        /// <summary>
        /// Hiển thị hàng hóa theo tên hàng
        /// </summary>
        public static DataTable GetByTenHang(string tenHang)
        {
            return HangHoaDAO.GetByTenHang(tenHang);
        }
        /// <summary>
        /// Hiển thị danh sách thông tin hàng hóa
        /// </summary>
        public static DataTable GetHangHoa()
        {
            return HangHoaDAO.GetHangHoa();
        }
        /// <summary>
        /// Hiển thị hàng hóa in mã vạch
        /// </summary>
        public static DataTable GetToPrintBarcode(string maHang)
        {
            return HangHoaDAO.GetToPrintBarcode(maHang);
        }
        /// <summary>
        /// Hiển thị hàng hóa theo mã
        /// </summary>
        public static DataTable GetByMaHang(string maHang)
        {
            return HangHoaDAO.GetByMaHang(maHang);
        }

        /// <summary>
        /// Thêm mới hàng hóa
        /// </summary>
        public static void Insert(EHangHoa eHangHoa)
        {
            HangHoaDAO.Insert(eHangHoa);
        }

        /// <summary>
        /// Cập nhật hàng hóa
        /// </summary>
        public static void Update(EHangHoa eHangHoa)
        {
            HangHoaDAO.Update(eHangHoa);
        }

        /// <summary>
        /// Ngừng kinh doanh
        /// </summary>
        public static void Delete(EHangHoa eHangHoa)
        {
            HangHoaDAO.Delete(eHangHoa);
        }
    }
}
