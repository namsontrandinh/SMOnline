using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using SalesManagement.ENTITY.ThietLapBanDauEntity;

namespace SalesManagement.FORM.QuanLyBanHang.BanHang
{
    public partial class frmHoaDonBanHang : Form
    {
        public frmHoaDonBanHang(DataTable dtHangHoa,EThongTinHoaDon ehoadon)
        {
            InitializeComponent();
            Design();
            LoadReport(dtHangHoa, ehoadon);
        }
        DataTable data = new DataTable();
        private void Design()
        {
            data.Columns.Add("MaPhieu");
            data.Columns.Add("NhanVien");
            data.Columns.Add("TongTien");
            data.Columns.Add("KhachTra");
            data.Columns.Add("TraLaiKhach");
            data.Columns.Add("MaHang");
            data.Columns.Add("TenHang");
            data.Columns.Add("DonViTinh");
            data.Columns.Add("SoLuong");
            data.Columns.Add("DonGia");
            data.Columns.Add("ThanhTien");
        }
        private void LoadReport(DataTable dtHangHoa, EThongTinHoaDon ehoadon)
        {
            foreach (DataRow item in dtHangHoa.Rows)
            {
                DataRow row = data.NewRow();
                row["MaHang"] = item["MaHang"];
                row["TenHang"] = item["TenHang"];
                row["DonViTinh"] = item["DonViTinh"];
                row["SoLuong"] = item["SoLuong"];
                row["DonGia"] = item["DonGia"];
                row["ThanhTien"] = item["ThanhTien"];
                row["MaPhieu"] = ehoadon.MaPhieu.ToString();
                row["NhanVien"] = ehoadon.NhanVien.ToString();
                row["TongTien"] = ehoadon.TongTien;
                row["KhachTra"] = ehoadon.KhachTra;
                row["TraLaiKhach"] = ehoadon.TraLaiKhach;
                data.Rows.Add(row);
            }
            rpHoaDon rp = new rpHoaDon();
            rp.SetDataSource(data);
            crystalReportViewer1.ReportSource = rp;
            crystalReportViewer1.Refresh();
            crystalReportViewer1.Zoom(100);
        }

    }
}
