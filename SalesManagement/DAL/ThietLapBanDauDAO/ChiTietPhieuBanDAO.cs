using System;
using System.Collections.Generic;

using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SalesManagement.DAL.ThietLapBanDauDAO
{
    public class ChiTietPhieuBanDAO
    {
        /// <summary>
        /// lưu chi tiết phiếu
        /// </summary>
        public static void Insert_WithoutMaKho(DataTable data)
        {
            SqlParameter[] para = { new SqlParameter("@data", data) };
            DataAccess.excuteNonQuery("ChiTietPhieuBan_Add_WithoutMaKho", CommandType.StoredProcedure, para);
        }
        /// <summary>
        /// lưu chi tiết phiếu tính tồn kho
        /// </summary>
        public static void Insert(DataTable data,int MaKho)
        {
            SqlParameter[] para = { new SqlParameter("@data", data),
                                  new SqlParameter("@MaKho", MaKho)};
            DataAccess.excuteNonQuery("ChiTietPhieuBan_Add", CommandType.StoredProcedure, para);
        }
    }
}
