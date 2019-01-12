using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using SalesManagement.ENTITY.BaoCaoThongKe;
using System.Data.SqlClient;

namespace SalesManagement.DAL.BaoCaoThongKe
{
    public class DoanhThuTheoThangDAO
    {
        public static DataTable LayDoanhThuTheoID(EDoanhThuTheoThang eDoanhThu)
        { 
            SqlParameter[] para = { new SqlParameter("@TuThang", eDoanhThu.TuThang),
                                    new SqlParameter("@DenThang", eDoanhThu.DenThang),
                                    new SqlParameter("@TuNam", eDoanhThu.TuNam),
                                    new SqlParameter("@DenNam", eDoanhThu.DenNam),
                                    new SqlParameter("@MaHang", eDoanhThu.MaHang)
                                  };
            return DataAccess.executeDataTable("DoanhThuTheoThang_LayTheoMaHang", CommandType.StoredProcedure, para);
        }
    }
}
