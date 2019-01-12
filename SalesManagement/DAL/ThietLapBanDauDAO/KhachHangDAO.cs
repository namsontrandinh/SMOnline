using SalesManagement.ENTITY.ThietLapBanDau;
using SalesManagement.ENTITY.ThietLapBanDauEntity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace SalesManagement.DAL.ThietLapBanDauDAO
{
   public class KhachHangDAO
    {
        /// <summary>
        /// Hiển thị tất cả danh sách khách hàng
        /// </summary>
        public static DataTable GetAll()
        {
            return DataAccess.executeDataTable("KhachHang_GetAll", CommandType.StoredProcedure, null);
        }
        /// <summary>
        /// Thêm mới khách hàng
        /// </summary>
        public static void InsertAll(EKhachHang eKhachHang)
        {
            try
            {
                SqlParameter[] para =
                {
                    new SqlParameter("@ChiNhanh", eKhachHang.ChiNhanh),
                    new SqlParameter("@CMT", eKhachHang.CMT),
                    new SqlParameter("@CreateDate", eKhachHang.CreateDate),
                    new SqlParameter("@CreateID", eKhachHang.CreateID),
                    new SqlParameter("@DiaChi", eKhachHang.DiaChi),
                    new SqlParameter("@EditDate", eKhachHang.EditDate),
                    new SqlParameter("@EditID", eKhachHang.EditID),
                    new SqlParameter("@Email", eKhachHang.Email),
                    new SqlParameter("@Fax", eKhachHang.Fax),
                    new SqlParameter("@MaKhachHang", eKhachHang.MaKhachHang),
                    new SqlParameter("@MaSoThe", eKhachHang.MaSoThe),
                    new SqlParameter("@MaSoThue", eKhachHang.MaSoThue),
                    new SqlParameter("@NganHang", eKhachHang.NganHang),
                    new SqlParameter("@NgayCap", eKhachHang.NgayCap),
                    new SqlParameter("@NgaySinh", eKhachHang.NgaySinh),
                    new SqlParameter("@NhomKhachHang", eKhachHang.NhomKhachHang),
                    new SqlParameter("@NoiCap", eKhachHang.NoiCap),
                    new SqlParameter("@SDT", eKhachHang.SDT),
                    new SqlParameter("@SoTaiKhoan", eKhachHang.SoTaiKhoan),
                    new SqlParameter("@TenKhachHang", eKhachHang.TenKhachHang),
                    new SqlParameter("@ThongTinThem", eKhachHang.ThongTinThem),
                    new SqlParameter("@TichDiem", eKhachHang.TichDiem),
                    new SqlParameter("@TongTienHang", eKhachHang.TongTienHang)

                };
                DataAccess.excuteNonQuery("KhachHang_Add", CommandType.StoredProcedure, para);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Thêm mới khách hàng
        /// </summary>
        public static void Insert_V1(EKhachHang eKhachHang)
        {
            try
            {
                SqlParameter[] para =
                {
                    new SqlParameter("@CMT", eKhachHang.CMT),
                    new SqlParameter("@DiaChi", eKhachHang.DiaChi),
                    new SqlParameter("@CreateDate", eKhachHang.CreateDate),
                    new SqlParameter("@CreateID", eKhachHang.CreateID),
                    new SqlParameter("@MaKhachHang", eKhachHang.MaKhachHang),
                    new SqlParameter("@NgaySinh", eKhachHang.NgaySinh),
                    new SqlParameter("@SDT", eKhachHang.SDT),
                    new SqlParameter("@TenKhachHang", eKhachHang.TenKhachHang),
                    new SqlParameter("@ThongTinThem", eKhachHang.ThongTinThem)

                };
                DataAccess.excuteNonQuery("KhachHang_Add", CommandType.StoredProcedure, para);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Sửa khách hàng
        /// </summary>
        public static void Update(EKhachHang eKhachHang)
        {
            try
            {
                SqlParameter[] para =
                {
                    new SqlParameter("@ChiNhanh", eKhachHang.ChiNhanh),
                    new SqlParameter("@CMT", eKhachHang.CMT),
                    new SqlParameter("@CreateDate", eKhachHang.CreateDate),
                    new SqlParameter("@CreateID", eKhachHang.CreateID),
                    new SqlParameter("@DiaChi", eKhachHang.DiaChi),
                    new SqlParameter("@EditDate", eKhachHang.EditDate),
                    new SqlParameter("@EditID", eKhachHang.EditID),
                    new SqlParameter("@Email", eKhachHang.Email),
                    new SqlParameter("@Fax", eKhachHang.Fax),
                    new SqlParameter("@MaKhachHang", eKhachHang.MaKhachHang),
                    new SqlParameter("@MaSoThe", eKhachHang.MaSoThe),
                    new SqlParameter("@MaSoThue", eKhachHang.MaSoThue),
                    new SqlParameter("@NganHang", eKhachHang.NganHang),
                    new SqlParameter("@NgayCap", eKhachHang.NgayCap),
                    new SqlParameter("@NgaySinh", eKhachHang.NgaySinh),
                    new SqlParameter("@NhomKhachHang", eKhachHang.NhomKhachHang),
                    new SqlParameter("@NoiCap", eKhachHang.NoiCap),
                    new SqlParameter("@SDT", eKhachHang.SDT),
                    new SqlParameter("@SoTaiKhoan", eKhachHang.SoTaiKhoan),
                    new SqlParameter("@TenKhachHang", eKhachHang.TenKhachHang),
                    new SqlParameter("@ThongTinThem", eKhachHang.ThongTinThem),
                    new SqlParameter("@TichDiem", eKhachHang.TichDiem),
                    new SqlParameter("@TongTienHang", eKhachHang.TongTienHang)

                };
                DataAccess.excuteNonQuery("KhachHang_Update", CommandType.StoredProcedure, para);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// xóa khách hàng
        /// </summary>
        public static void Delete(string MaKhachHang)
        {
            SqlParameter[] para = {new SqlParameter("@MaKhachHang", MaKhachHang) };
            DataAccess.excuteNonQuery("KhachHang_Delete", CommandType.StoredProcedure, null);
        }
    }
}
