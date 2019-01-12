using System;
using System.Collections.Generic;
using System.Text;

namespace SalesManagement.ENTITY.ThietLapBanDau
{
    public class ENhanVien
    {
        public string MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public DateTime NgaySinh { get; set; }
        public byte GioiTinh { get; set; }
        public string SoDienThoai { get; set; }
        public string ThongTinThem { get; set; }

        public ENhanVien()
        {

        }

        public ENhanVien(string maNhanVien, string tenNhanVien, DateTime ngaySinh, byte gioiTinh, string soDienThoai, string thongTinThem)
        {
            this.MaNhanVien = maNhanVien;
            this.TenNhanVien = tenNhanVien;
            this.NgaySinh = ngaySinh;
            this.GioiTinh = gioiTinh;
            this.SoDienThoai = soDienThoai;
            this.ThongTinThem = thongTinThem;
        }
    }
}
