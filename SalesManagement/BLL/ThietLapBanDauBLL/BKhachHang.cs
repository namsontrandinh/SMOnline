using SalesManagement.DAL.ThietLapBanDauDAO;
using SalesManagement.ENTITY.ThietLapBanDauEntity;
using System.Data;

namespace SalesManagement.BLL.ThietLapBanDauBLL
{
    public  class BKhachHang
    {
        /// <summary>
        /// Hiển thị tất cả thông tin khách hàng
        /// </summary>
        public static DataTable GetAll()
        {
            return KhachHangDAO.GetAll();
        }
        /// <summary>
        /// Thêm thông tin khách hàng
        /// </summary>
        public static void Insert_V1(EKhachHang eKhachHang)
        {
             KhachHangDAO.Insert_V1(eKhachHang);
        }
        /// <summary>
        /// Cập nhật thông tin khách hàng
        /// </summary>
        public static void Update(EKhachHang eKhachHang)
        {
            KhachHangDAO.Update(eKhachHang);
        }
        /// <summary>
        /// xóa thông tin khách hàng
        /// </summary>
        public static void Delete(string MaKhachHang)
        {
            KhachHangDAO.Delete(MaKhachHang);
        }
    }
}
