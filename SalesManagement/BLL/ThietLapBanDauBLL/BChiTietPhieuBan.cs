using System;
using System.Collections.Generic;

using System.Text;
using System.Data;
using SalesManagement.DAL.ThietLapBanDauDAO;

namespace SalesManagement.BLL.ThietLapBanDauBLL
{
    public class BChiTietPhieuBan
    {
        /// <summary>
        /// lưu chi tiết phiếu bán không tính tồn kho
        /// </summary>
        public static void Insert_WithoutMaKho(DataTable data)
        {
            ChiTietPhieuBanDAO.Insert_WithoutMaKho(data);
        }
        /// <summary>
        /// lưu chi tiết phiếu bán tính tồn kho
        /// </summary>
        public static void Insert(DataTable data, int MaKho)
        {
            ChiTietPhieuBanDAO.Insert(data,MaKho);
        }

    }
}
