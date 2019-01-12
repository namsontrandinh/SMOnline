using SalesManagement.DAL.ThietLapBanDauDAO;
using SalesManagement.ENTITY.ThietLapBanDauEntity;
using System.Data;

namespace SalesManagement.BLL.ThietLapBanDauBLL
{
    public class BNhaCungCap
    {
        /// <summary>
        /// Hiển thị tất cả thông tin nhà cung cấp
        /// </summary>
        public static DataTable GetAll()
        {
            return NhaCungCapDAO.GetAll();
        }
        /// <summary>
        /// thêm mới thông tin nhà cung cấp
        /// </summary>
        public static void Insert(ENhaCungCap eNhaCungCap)
        {
            NhaCungCapDAO.Insert(eNhaCungCap);
        }
        /// <summary>
        /// cập nhật thông tin nhà cung cấp
        /// </summary>
        public static void Update(ENhaCungCap eNhaCungCap)
        {
            NhaCungCapDAO.Update(eNhaCungCap);
        }
        /// <summary>
        /// xoá thông tin nhà cung cấp
        /// </summary>
        public static void Delete(string MaNCC)
        {
            NhaCungCapDAO.Delete(MaNCC);
        }
        /// <summary>
        /// CHỌN DANH SÁCH HÀNG HÓA CỦA NHÀ CC THEO MÃ NCC
        /// </summary>
        public static DataTable GetByMaNCC(string MaNCC)
        {
           return NhaCungCapDAO.GetByMaNCC(MaNCC);
        }
        /// <summary>
        /// lấy TÊN nhà cung cấp cho combo box
        /// </summary>
        public static DataTable GetToCombobox()
        {
            return NhaCungCapDAO.GetToCombobox();
        }
    }
}
