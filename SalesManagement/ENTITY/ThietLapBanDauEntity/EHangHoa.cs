using SalesManagement.ENTITY.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesManagement.ENTITY.ThietLapBanDauEntity
{
    public class EHangHoa
    {
        public string MaHang { get; set; }
        public string MaVach { get; set; }
        public string TenHang { get; set; }
        public int MaKho { get; set; }
        public int MaNhomHangHoa { get; set; }
        public int MaNCC { get; set; }
        public int MaDVT { get; set; }
        public double GiaBan { get; set; }
        public string CreateID { get; set; }
        public int CreateDate { get; set; }
        public DateTime CreateDateGMT { get { return UnixTime.GetTimeUnix(CreateDate); } }
        public string EditID { get; set; }
        public int EditDate { get; set; }
        public DateTime EditDateGMT { get { return UnixTime.GetTimeUnix(EditDate); } }
        public double GiaNhap { get; set; }
        public EHangHoa()
        {

        }

        public EHangHoa(string MaHang, string MaVach, string TenHang, int MaKho,double GiaNhap, int MaNhomHangHoa, int MaNCC, int MaDVT, double GiaBan, string CreateID, int CreateDate, string EditID, int EditDate)
        {
            this.MaHang = MaHang;
            this.MaVach = MaVach;
            this.TenHang = TenHang;
            this.MaKho = MaKho;
            this.MaNhomHangHoa = MaNhomHangHoa;
            this.MaNCC = MaNCC;
            this.MaDVT = MaDVT;
            this.GiaBan = GiaBan;
            this.CreateID = CreateID;
            this.CreateDate = CreateDate;
            this.EditID = EditID;
            this.EditDate = EditDate;
            this.GiaNhap = GiaNhap;
        }
    }
}
