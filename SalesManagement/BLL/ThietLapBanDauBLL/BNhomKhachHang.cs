using SalesManagement.DAL.ThietLapBanDauDAO;
using SalesManagement.ENTITY.ThietLapBanDauEntity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SalesManagement.BLL.ThietLapBanDauBLL
{
   public class BNhomKhachHang
    {
        /// <summary>
        /// Hiển thị danh sách nhóm khách hàng
        /// </summary>
        public static DataTable GetAll()
        {
            return NhomKhachHangDAO.GetAll();
        }
        /// <summary>
        ///thêm mới nhóm khách hàng
        /// </summary>
        public static void Insert(ENhomKhachHang eNhomKhachHang)
        {
            NhomKhachHangDAO.Insert(eNhomKhachHang);
        }
        /// <summary>
        ///cập nhật nhóm khách hàng
        /// </summary>
        public static void Update(ENhomKhachHang eNhomKhachHang)
        {
            NhomKhachHangDAO.Update(eNhomKhachHang);
        }
        /// <summary>
        ///xóa nhóm khách hàng
        /// </summary>
        public static void Delete(string NhomKhachHang)
        {
            NhomKhachHangDAO.Delete(NhomKhachHang);
        }
    }
}
