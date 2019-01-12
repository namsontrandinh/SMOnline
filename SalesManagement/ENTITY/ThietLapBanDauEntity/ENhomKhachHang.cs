using System;
using System.Collections.Generic;
using System.Text;

namespace SalesManagement.ENTITY.ThietLapBanDauEntity
{
   public class ENhomKhachHang
    {
        public int NhomKhachHang { get; set; }
        public string TenNhomKhach { get; 
            set; }
        public string MoTa { get; set; }
        public int SoDiem { get; set; }
        public float PhamTramChietKhau { get; set; }
        public float TienHang { get; set; }
        public ENhomKhachHang() { }
        public ENhomKhachHang(int NhomKhachHang, string TenNhomKhach, string MoTa, int SoDiem, float PhamTramChietKhau, float TienHang) 
        {
            this.MoTa = MoTa;
            this.NhomKhachHang = NhomKhachHang;
            this.PhamTramChietKhau = PhamTramChietKhau;
            this.SoDiem = SoDiem;
            this.TenNhomKhach = TenNhomKhach;
            this.TienHang = TienHang;
        }
    }
}
