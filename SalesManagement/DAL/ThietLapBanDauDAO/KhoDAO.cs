using SalesManagement.ENTITY.ThietLapBanDauEntity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace SalesManagement.DAL.ThietLapBanDauDAO
{
    public class KhoDAO
    {
        /// <summary>
        /// Hiển thị danh sách kho
        /// </summary>
        public static DataTable GetAll()
        {
            return DataAccess.executeDataTable("Kho_GetAll", CommandType.StoredProcedure, null);
        }
        /// <summary>
        /// Thêm kho
        /// </summary>
        public static void Insert(string Kho)
        {
            try
            {
                SqlParameter[] para = { new SqlParameter("@Kho", Kho) };
                DataAccess.excuteNonQuery("Kho_Add", CommandType.StoredProcedure, para);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// xóa kho
        /// </summary>
        public static void Delete(int maKho)
        {
            try
            {
                SqlParameter[] para = { new SqlParameter("@MaKho",maKho)};
                DataAccess.excuteNonQuery("Kho_Delete", CommandType.StoredProcedure, para);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
