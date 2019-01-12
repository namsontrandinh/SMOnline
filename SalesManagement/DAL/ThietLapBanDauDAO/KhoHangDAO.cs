using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace SalesManagement.DAL.ThietLapBanDauDAO
{
   public class KhoHangDAO
    {
        /// <summary>
        /// Hiển thị danh sách hàng trong kho hàng
        /// </summary>
        public static DataTable GetAll()
        {
            return DataAccess.executeDataTable("KhoHang_GetAll", CommandType.StoredProcedure, null);
        }
        /// <summary>
        /// Hiển thị danh sách hàng trong kho theo mã kho
        /// </summary>
        public static DataTable GetByMaKho(string maKho)
        {
            try
            {
                SqlParameter[] para = { new SqlParameter("@MaKho", maKho) };
                return DataAccess.executeDataTable("KhoHang_GetByMaKho", CommandType.StoredProcedure, para);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Hiển thị danh sách hàng trong kho theo mã hàng
        /// </summary>
        public static DataTable GetByMaHang(string maHang)
        {
            try
            {
                SqlParameter[] para = { new SqlParameter("@MaHang", maHang) };
                return DataAccess.executeDataTable("KhoHang_GetByMaHang", CommandType.StoredProcedure, para);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
