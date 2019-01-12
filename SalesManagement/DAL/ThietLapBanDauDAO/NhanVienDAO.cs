using SalesManagement.ENTITY.ThietLapBanDau;
using SalesManagement.ENTITY.ThietLapBanDauEntity;

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SalesManagement.DAL.ThietLapBanDauDAO
{
    public class NhanVienDAO
    {
        /// <summary>
        /// Hiển thị tất cả danh sách nhân viên
        /// </summary>
        public static DataTable GetAll()
        {
            return DataAccess.executeDataTable("NhanVien_GetAll", CommandType.StoredProcedure, null);
        }
        /// <summary>
        /// lấy mã nhân viên
        /// </summary>
        public static string GetMaNhanVien()
        {
            return DataAccess.excuteNonQuery_string("NhanVien_GetMaNhanVien", CommandType.StoredProcedure, null);
        }

        /// <summary>
        /// Hiển thị giới tính lên combobox
        /// </summary>
        /// <returns></returns>
        public static List<EGioiTinh> LoadComboboxGender()
        {
            List<EGioiTinh> gioiTinhlst = new List<EGioiTinh>();
            gioiTinhlst.Add(new EGioiTinh { ID = 1, Gender = "Nam" });
            gioiTinhlst.Add(new EGioiTinh { ID = 0, Gender = "Nữ" });
            return gioiTinhlst;
        }

        /// <summary>
        /// Thêm mới nhân viên
        /// </summary>
        public static void Insert(ENhanVien eNhanVien)
        {
            try
            {
                SqlParameter[] para =
                {
                    new SqlParameter("@MaNhanVien", eNhanVien.MaNhanVien),
                    new SqlParameter("@TenNhanVien", eNhanVien.TenNhanVien),
                    new SqlParameter("@NgaySinh", eNhanVien.NgaySinh),
                    new SqlParameter("@GioiTinh", eNhanVien.GioiTinh),
                    new SqlParameter("@SoDienThoai", eNhanVien.SoDienThoai),
                    new SqlParameter("@ThongTinThem", eNhanVien.ThongTinThem)
                };
                DataAccess.excuteNonQuery("NhanVien_Add", CommandType.StoredProcedure, para);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Cập nhật thông tin nhân viên
        /// </summary>
        public static void Update(ENhanVien eNhanVien)
        {
            try
            {
                SqlParameter[] para =
                {
                    new SqlParameter("@MaNhanVien", eNhanVien.MaNhanVien),
                    new SqlParameter("@TenNhanVien", eNhanVien.TenNhanVien),
                    new SqlParameter("@NgaySinh", eNhanVien.NgaySinh),
                    new SqlParameter("@GioiTinh", eNhanVien.GioiTinh),
                    new SqlParameter("@SoDienThoai", eNhanVien.SoDienThoai),
                    new SqlParameter("@ThongTinThem", eNhanVien.ThongTinThem)
                };
                DataAccess.excuteNonQuery("NhanVien_Update", CommandType.StoredProcedure, para);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Xóa nhân viên
        /// </summary>
        public static void Delete(ENhanVien eNhanVien)
        {
            SqlParameter[] para =
            {
                new SqlParameter("@MaNhanVien", eNhanVien.MaNhanVien)
            };
            DataAccess.excuteNonQuery("NhanVien_Delete", CommandType.StoredProcedure, para);
        }
    }
}
