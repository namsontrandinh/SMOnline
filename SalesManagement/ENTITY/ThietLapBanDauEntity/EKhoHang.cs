using System;
using System.Collections.Generic;
using System.Text;

namespace SalesManagement.ENTITY.ThietLapBanDauEntity
{
   public class EKhoHang
    {
        public int MaKho { get; set; }
        public string MaHang { get; set; }
        public int MaDVT { get; set; }
        public int SoLuong { get; set; }
        public EKhoHang() { }
        public EKhoHang(int MaKho, string MaHang, int MaDVT, int SoLuong) 
        {
            this.MaDVT = MaDVT;
            this.MaHang = MaHang;
            this.MaKho = MaKho;
            this.SoLuong = SoLuong;
        }
    }
}
