using SalesManagement.ENTITY.ThietLapBanDauEntity;

using System;
using System.Data;
using System.Data.SqlClient;

namespace SalesManagement.DAL.ThietLapBanDauDAO
{
    public class HangHoaDAO
    {
        /// <summary>
        /// Hiển thị tất cả hàng hóa
        /// </summary>
        public static DataTable GetAll()
        {
            return DataAccess.executeDataTable("HangHoa_GetAll", CommandType.StoredProcedure, null);
        }

        /// <summary>
        /// Hiển thị hàng hóa theo tên hàng
        /// </summary>
        public static DataTable GetByTenHang(string tenHang)
        {
            SqlParameter[] para = { new SqlParameter("@TenHang", tenHang) };
            return DataAccess.executeDataTable("HangHoa_GetByTenHang", CommandType.StoredProcedure, para);
        }
        /// <summary>
        /// Hiển thị danh sách thông tin hàng hóa
        /// </summary>
        public static DataTable GetHangHoa()
        {
            return DataAccess.executeDataTable("HangHoa_GetHangHoa", CommandType.StoredProcedure, null);
        }
        /// <summary>
        /// Hiển thị hàng hóa in mã vạch
        /// </summary>
        public static DataTable GetToPrintBarcode(string maHang)
        {
            SqlParameter[] para = { new SqlParameter("@MaHang", maHang) };
            return DataAccess.executeDataTable("HangHoa_InMaVach", CommandType.StoredProcedure, para);
        }
        /// <summary>
        /// Hiển thị hàng hóa theo mã
        /// </summary>
        public static DataTable GetByMaHang(string maHang)
        {
            SqlParameter[] para = { new SqlParameter("@MaHang", maHang) };
            return DataAccess.executeDataTable("HangHoa_GetByMaHang", CommandType.StoredProcedure, para);
        }

        /// <summary>
        /// Thêm mới hàng hóa
        /// </summary>
        public static void Insert(EHangHoa eHangHoa)
        {
            try
            {
                SqlParameter[] para = {
                    new SqlParameter("@MaHang", eHangHoa.MaHang),
                    new SqlParameter("@MaVach", eHangHoa.MaVach),
                    new SqlParameter("@TenHang", eHangHoa.TenHang),
                    new SqlParameter("@MaKho", eHangHoa.MaKho),
                    new SqlParameter("@MaNhomHangHoa", eHangHoa.MaNhomHangHoa),
                    new SqlParameter("@MaNCC", eHangHoa.MaNCC),
                    new SqlParameter("@MaDVT", eHangHoa.MaDVT), 
                    new SqlParameter("@CreateID", eHangHoa.CreateID),
                    new SqlParameter("@CreateDate", eHangHoa.CreateDate),
                    new SqlParameter("@EditID", eHangHoa.EditID),
                    new SqlParameter("@EditDate", eHangHoa.EditDate),
                    new SqlParameter("@GiaBan", eHangHoa.GiaBan),
                    new SqlParameter("@GiaNhap", eHangHoa.GiaNhap)
                };
                DataAccess.excuteNonQuery("HangHoa_Add", CommandType.StoredProcedure, para);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// Cập nhật hàng hóa
        /// </summary>
        public static void Update(EHangHoa eHangHoa)
        {
            try
            {
                SqlParameter[] para = {
                    new SqlParameter("@MaHang", eHangHoa.MaHang),
                    new SqlParameter("@MaVach", eHangHoa.MaVach),
                    new SqlParameter("@TenHang", eHangHoa.TenHang),
                    new SqlParameter("@MaKho", eHangHoa.MaKho),
                    new SqlParameter("@MaNhomHangHoa", eHangHoa.MaNhomHangHoa),
                    new SqlParameter("@MaNCC", eHangHoa.MaNCC),
                    new SqlParameter("@MaDVT", eHangHoa.MaDVT),
                    new SqlParameter("@CreateID", eHangHoa.CreateID),
                    new SqlParameter("@CreateDate", eHangHoa.CreateDate),
                    new SqlParameter("@EditID", eHangHoa.EditID),
                    new SqlParameter("@EditDate", eHangHoa.EditDate),
                };
                DataAccess.excuteNonQuery("HangHoa_Update", CommandType.StoredProcedure, para);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// Ngừng kinh doanh
        /// </summary>
        public static void Delete(EHangHoa eHangHoa)
        {
            try
            {
                SqlParameter[] para =
                {
                    new SqlParameter("@MaHang", eHangHoa.MaHang)
                };
                DataAccess.excuteNonQuery("HangHoa_Delete", CommandType.StoredProcedure, para);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
