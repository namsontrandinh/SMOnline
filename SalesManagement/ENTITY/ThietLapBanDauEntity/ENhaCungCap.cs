using System;

namespace SalesManagement.ENTITY.ThietLapBanDauEntity
{
    public class ENhaCungCap
    {
        public string MaNCC { get; set; }
        public string NhaCungCap { get; set; }
        public string NguoiLienHe { get; set; }
        public string SDT { get; set; }
        public string MaSoThue { get; set; }
        public string Fax { get; set; }
        public string SoTaiKhoan { get; set; }
        public string NganHang { get; set; }
        public string ChiNhanh { get; set; }
        public string Email { get; set; }
        public string GhiChu  { get; set; }
        public string  DiaChi { get; set; }
        public string CreateID { get; set; }
        public int CreateDate { get; set; }
        public string EditID { get; set; }
        public int EditDate { get; set; }
        public DateTime NgayHopTac { get; set; }
        public ENhaCungCap() { }
        public ENhaCungCap(string MaNCC, string NhaCungCap, string NguoiLienHe, string CreateID, int CreateDate, string EditID, int EditDate, string SDT, string MaSoThue, string Fax, string SoTaiKhoan, string NganHang, string ChiNhanh, string Email, string GhiChu,string DiaChi,DateTime NgayHopTac)
        {
            this.ChiNhanh = ChiNhanh;
            this.Email = Email;
            this.Fax = Fax;
            this.GhiChu = GhiChu;
            this.MaNCC = MaNCC;
            this.MaSoThue = MaSoThue;
            this.NganHang = NganHang;
            this.NguoiLienHe = NguoiLienHe;
            this.NhaCungCap = NhaCungCap;
            this.SDT = SDT;
            this.SoTaiKhoan = SoTaiKhoan;
            this.DiaChi = DiaChi;
            this.CreateDate = CreateDate;
            this.CreateID = CreateID;
            this.EditDate = EditDate;
            this.EditID = EditID;
            this.NgayHopTac = NgayHopTac;
        }
    }
}
