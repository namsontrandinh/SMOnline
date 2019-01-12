using SalesManagement.ENTITY.ThietLapBanDauEntity;
using System;
using System.Data;
using System.Data.SqlClient;

namespace SalesManagement.DAL.ThietLapBanDauDAO
{
    public class NhaCungCapDAO
    {
        /// <summary>
        /// Hiển thị tất cả danh sách nhà cung cấp
        /// </summary>
        public static DataTable GetAll()
        {
            return DataAccess.executeDataTable("NhaCungCap_GetAll", CommandType.StoredProcedure, null);
        }
        /// <summary>
        /// Thêm mới nhà cung cấp
        /// </summary>
        public static void Insert(ENhaCungCap eNhaCungCap)
        {
            try
            {
                SqlParameter[] para =
                {
                    new SqlParameter("@CreateDate", eNhaCungCap.CreateDate),
                    new SqlParameter("@CreateID", eNhaCungCap.CreateID),
                    new SqlParameter("@DiaChi", eNhaCungCap.DiaChi),
                    new SqlParameter("@Email", eNhaCungCap.Email),
                    new SqlParameter("@NgayHopTac", eNhaCungCap.NgayHopTac),
                    new SqlParameter("@NguoiLienHe", eNhaCungCap.NguoiLienHe),
                    new SqlParameter("@NhaCungCap", eNhaCungCap.NhaCungCap),
                    new SqlParameter("@SoDienThoai", eNhaCungCap.SDT),
                    new SqlParameter("@ThongTinThem", eNhaCungCap.GhiChu)
                };
                DataAccess.excuteNonQuery("NhaCungCap_Add", CommandType.StoredProcedure, para);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// cập nhật nhà cung cấp
        /// </summary>
        public static void Update(ENhaCungCap eNhaCungCap)
        {
            try
            {
                SqlParameter[] para =
                {
                    new SqlParameter("@ChiNhanh",eNhaCungCap.ChiNhanh),
                    new SqlParameter("@CreateDate", eNhaCungCap.CreateDate),
                    new SqlParameter("@CreateID", eNhaCungCap.CreateID),
                    new SqlParameter("@DiaChi", eNhaCungCap.DiaChi),
                    new SqlParameter("@EditDate", eNhaCungCap.EditDate),
                    new SqlParameter("@EditID", eNhaCungCap.EditID),
                    new SqlParameter("@Email", eNhaCungCap.Email),
                    new SqlParameter("@Fax", eNhaCungCap.Fax),
                    new SqlParameter("@GhiChu", eNhaCungCap.GhiChu),
                    new SqlParameter("@MaSoThue", eNhaCungCap.MaSoThue),
                    new SqlParameter("@NganHang", eNhaCungCap.NganHang),
                    new SqlParameter("@NgayHopTac", eNhaCungCap.NgayHopTac),
                    new SqlParameter("@NguoiLienHe", eNhaCungCap.NguoiLienHe),
                    new SqlParameter("@NhaCungCap", eNhaCungCap.NhaCungCap),
                    new SqlParameter("@SoDienThoai", eNhaCungCap.SDT),
                    new SqlParameter("@SoTaiKhoan", eNhaCungCap.SoTaiKhoan),
                    new SqlParameter("@MaNCC", eNhaCungCap.MaNCC)
                };
                DataAccess.excuteNonQuery("NhaCungCap_Update", CommandType.StoredProcedure, para);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// xóa nhà cung cấp
        /// </summary>
        public static void Delete(string MaNCC)
        {
            try
            {
                SqlParameter[] para = { new SqlParameter("@MaNCC", MaNCC) };
                DataAccess.excuteNonQuery("NhaCungCap_Delete", CommandType.StoredProcedure, para);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// CHỌN DANH SÁCH HÀNG HÓA CỦA NHÀ CC THEO MÃ NCC
        /// </summary>
        public static DataTable GetByMaNCC(string MaNCC)
        {
            try
            {
                SqlParameter[] para = { new SqlParameter("@MaNCC", MaNCC) };
                return DataAccess.executeDataTable("NhaCungCap_GetMaHang", CommandType.StoredProcedure, para);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// lấy TÊN nhà cung cấp cho combo box
        /// </summary>
        public static DataTable GetToCombobox()
        {
            try
            {
                return DataAccess.executeDataTable("NhaCungCap_GetToCombobox", CommandType.StoredProcedure, null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
