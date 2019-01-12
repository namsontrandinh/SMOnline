using SalesManagement.DAL.ThietLapBanDauDAO;
using SalesManagement.ENTITY.ThietLapBanDau;
using SalesManagement.ENTITY.ThietLapBanDauEntity;

using System.Collections.Generic;
using System.Data;

namespace SalesManagement.BLL.ThietLapBanDau
{
    public class BNhanVien
    {
        /// <summary>
        /// Hiển thị tất cả thông tin sinh viên
        /// </summary>
        public static DataTable GetAll()
        {
            return NhanVienDAO.GetAll();
        }

        /// <summary>
        ///lấy mã nhân viên
        /// </summary>
        public static string GetMaNhanVien()
        {
            return NhanVienDAO.GetMaNhanVien();
        }

        /// <summary>
        /// Hiển thị giới tính lên combobox
        /// </summary>
        public static List<EGioiTinh> LoadComboboxGender()
        {
            return NhanVienDAO.LoadComboboxGender();
        }

        /// <summary>
        /// Thêm mới nhân viên
        /// </summary>
        public static void Insert(ENhanVien eNhanVien)
        {
            NhanVienDAO.Insert(eNhanVien);
        }

        /// <summary>
        /// Cập nhật thông tin nhân viên
        /// </summary>
        public static void Update(ENhanVien eNhanVien)
        {
            NhanVienDAO.Update(eNhanVien);
        }

        /// <summary>
        /// Xóa nhân viên
        /// </summary>
        public static void Delete(ENhanVien eNhanVien)
        {
            NhanVienDAO.Delete(eNhanVien);
        }
    }
}
