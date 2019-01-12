using System;
using System.Collections.Generic;

using System.Text;

namespace SalesManagement.ENTITY.ThietLapBanDauEntity
{
   public class EPhieuBanHang
    {
       public string MaKhach { get; set; }
       public string MaPhieu{ get; set; }
       public int NgayBan { get; set; }
       public string MaNhanVien { get; set; }
       public double TongTien { get; set; }
       public double TongLoiNhuan { get; set; }
    }
}
