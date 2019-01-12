using System;
using System.Collections.Generic;
using System.Text;
using SalesManagement.ENTITY.BaoCaoThongKe;
using SalesManagement.DAL.BaoCaoThongKe;
using System.Data;

namespace SalesManagement.BLL.ThietLapBanDauBLL
{
    public class BDoanhThuTheoThang
    {
        public static DataTable LayDoanhThuTheoID(EDoanhThuTheoThang eDoanhThu)
        {
            return DoanhThuTheoThangDAO.LayDoanhThuTheoID(eDoanhThu);
        }
    }
}
