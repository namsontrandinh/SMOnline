using System;
using System.Collections.Generic;
using System.Text;

namespace SalesManagement.ENTITY.ThietLapBanDauEntity
{
    public class EKhachHang
    {
        public string MaKhachHang { get; set; }
        public string CMT { get; set; }
        public string  TenKhachHang { get; set; }
        public string DiaChi { get; set; }
        public string  SDT { get; set; }
        public string Email { get; set; }
        public int TichDiem { get; set; }
        public int NhomKhachHang { get; set; }
        public string ThongTinThem { get; set; }
        public string CreateID { get; set; }
        public int CreateDate { get; set; }
        public string EditID { get; set; }
        public int EditDate { get; set; }
        public int NgaySinh { get; set; }
        public string Fax { get; set; }
        public string MaSoThue { get; set; }
        public int NgayCap { get; set; }
        public string NoiCap { get; set; }
        public string SoTaiKhoan { get; set; }
        public string NganHang { get; set; }
        public string ChiNhanh { get; set; }
        public string MaSoThe { get; set; }
        public float TongTienHang { get; set; }
        
        public EKhachHang() { }
        public EKhachHang(string MaKhachHang, string CMT, string TenKhachHang, string DiaChi, string SDT, string Email, int TichDiem, int NhomKhachHang, string ThongTinThem, string CreateID, int CreateDate, string EditID, int EditDate, int NgaySinh, string Fax, string MaSoThue, int NgayCap, string NoiCap, string SoTaiKhoan, string NganHang, string ChiNhanh, string MaSoThe, float TongTienHang)
        {
            this.ChiNhanh = ChiNhanh;
            this.CMT = CMT;
            this.CreateDate = CreateDate;
            this.CreateID = CreateID;
            this.DiaChi = DiaChi;
            this.EditDate = EditDate;
            this.EditID = EditID;
            this.Email = Email;
            this.Fax = Fax;
            this.MaKhachHang = MaKhachHang;
            this.MaSoThe = MaSoThe;
            this.MaSoThue = MaSoThue;
            this.NganHang = NganHang;
            this.NgayCap = NgayCap;
            this.NgaySinh = NgaySinh;
            this.NhomKhachHang = NhomKhachHang;
            this.NoiCap = NoiCap;
            this.SDT = SDT;
            this.SoTaiKhoan = SoTaiKhoan;
            this.TenKhachHang = TenKhachHang;
            this.ThongTinThem = ThongTinThem;
            this.TichDiem = TichDiem;
            this.TongTienHang = TongTienHang;
            
        }
    }
}