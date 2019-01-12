using System;
using System.Collections.Generic;

using System.Text;
using System.Data;
using System.Data.SqlClient;
using SalesManagement.ENTITY.ThietLapBanDauEntity;

namespace SalesManagement.DAL.ThietLapBanDauDAO
{
   public class PhieuBanHangDAO
    {
        /// <summary>
        /// Hiển thị tất cả phiếu bán hàng
        /// </summary>
        public static DataTable GetAll()
        {
            return DataAccess.executeDataTable("PhieuBanHang_GetAll_OrderByDate_Decrease", CommandType.StoredProcedure, null);
        }
        /// <summary>
        /// Hiển thị tổng thu nhập theo ngày
        /// </summary>
        public static DataTable GetSumDay(int fromTime,int toTime)
        {
            SqlParameter[] para = { new SqlParameter("@FromTime", fromTime),
                                new SqlParameter("@ToTime",toTime)};
            return DataAccess.executeDataTable("PhieuHangHoa_SumDay", CommandType.StoredProcedure, para);
        }

        /// <summary>
        /// Hiển thị theo mã phiếu
        /// </summary>
        public static DataTable GetByMaHang(string maPhieu)
        {
            SqlParameter[] para = { new SqlParameter("@MaPhieu", maPhieu) };
            return DataAccess.executeDataTable("HangHoa_GetByMaHang", CommandType.StoredProcedure, para);
        }
        /// <summary>
        /// Lấy mã phiếu 
        /// </summary>
        public static string GetMaPhieu(string date)
        {
            SqlParameter[] para = { new SqlParameter("@date", date) };
            return DataAccess.excuteNonQuery_string("PhieuBanHang_GetMaPhieu", CommandType.StoredProcedure, para);
        }
        /// <summary>
        /// Thêm mới phiếu bán hàng không có mã khách
        /// </summary>
        public static void Insert_WithoutMaKhach(EPhieuBanHang ePhieuBanHang)
        {
            try
            {
                SqlParameter[] para = {
                    new SqlParameter("@MaPhieu", ePhieuBanHang.MaPhieu),
                    new SqlParameter("@NgayBan", ePhieuBanHang.NgayBan),
                    new SqlParameter("@MaNhanVien", ePhieuBanHang.MaNhanVien),
                    new SqlParameter("@TongTien",ePhieuBanHang.TongTien),
                    new SqlParameter("@TongLoiNhuan",ePhieuBanHang.TongLoiNhuan)
                   
                };
                DataAccess.excuteNonQuery("PhieuBanHang_Add_WithoutMaKhach", CommandType.StoredProcedure, para);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        /// <summary>
        /// Thêm mới phiếu bán hàng  có mã khách
        /// </summary>
        public static void Insert(EPhieuBanHang ePhieuBanHang)
        {
            try
            {
                SqlParameter[] para = {
                    new SqlParameter("@MaPhieu", ePhieuBanHang.MaPhieu),
                    new SqlParameter("@NgayBan", ePhieuBanHang.NgayBan),
                    new SqlParameter("@MaNhanVien", ePhieuBanHang.MaNhanVien),
                    new SqlParameter("@TongTien",ePhieuBanHang.TongTien),
                    new SqlParameter("@MaKhachHang",ePhieuBanHang.MaKhach)
                   
                };
                DataAccess.excuteNonQuery("PhieuBanHang_Add", CommandType.StoredProcedure, para);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
