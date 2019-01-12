using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SalesManagement.BLL.ThietLapBanDauBLL;
using SalesManagement.ENTITY.ThietLapBanDauEntity;
using SalesManagement.ENTITY.Utility;
using SalesManagement.FORM.ThietLapBanDau;
using SalesManagement.PUBLICCODE;

namespace SalesManagement.FORM.QuanLyBanHang.BanHang
{
    public partial class UCBanHang : UserControl
    {
        #region =================== Khởi tạo ==========================
        DataTable data = new DataTable();
        DataTable dtReport = new DataTable();
        DataTable dtView = new DataTable();
        DataTable dtChiTietPhieuBan = new DataTable();
        DataTable dtHH = new DataTable();
        EThongTinHoaDon eThongTinHoaDon = new EThongTinHoaDon();
        double TongLoiNhuan = 0;
        int rowIndex = 0;
        string maPhieu = string.Empty;
        public UCBanHang()
        {
            InitializeComponent();
            
            DesignTable();
            this.maPhieu= GetMaPhieu(DateTime.Now.ToString("ddMMyy"));
           
        }
        private void DesignTable()
       {
           dtView.Columns.Add("MaHang");
           dtView.Columns.Add("TenHang");
           dtView.Columns.Add("DonViTinh");
           dtView.Columns.Add("DonGia",typeof(double));
           dtView.Columns.Add("SoLuong",typeof(int));
           dtView.Columns.Add("ThanhTien",typeof(double));
           dtView.Columns.Add("MaDVT");
           dtView.Columns.Add("GiaNhap", typeof(double));
           dtView.Columns.Add("ChietKhau", typeof(double));
           dtView.Columns.Add("HDVAT", typeof(double));
           dtView.Columns.Add("HDTrucTiep", typeof(double));

           dtChiTietPhieuBan.Columns.Add("MaPhieu");
           dtChiTietPhieuBan.Columns.Add("MaHang");
           dtChiTietPhieuBan.Columns.Add("SoLuong",typeof(int) );
           dtChiTietPhieuBan.Columns.Add("MaDVT");
           dtChiTietPhieuBan.Columns.Add("GiaBan");
           dtChiTietPhieuBan.Columns.Add("TrangThai");
           dtChiTietPhieuBan.Columns.Add("ChietKhau", typeof(double));
           dtChiTietPhieuBan.Columns.Add("HDVAT", typeof(double));
           dtChiTietPhieuBan.Columns.Add("HDTrucTiep", typeof(double));

           dtReport.Columns.Add("MaPhieu");
            dtReport.Columns.Add("NhanVien");
            dtReport.Columns.Add("TongTien");
            dtReport.Columns.Add("KhachTra");
            dtReport.Columns.Add("TraLaiKhach");
            dtReport.Columns.Add("MaHang");
            dtReport.Columns.Add("TenHang");
            dtReport.Columns.Add("DonViTinh");
            dtReport.Columns.Add("SoLuong");
            dtReport.Columns.Add("DonGia");
            dtReport.Columns.Add("ThanhTien");

            dtHH.Columns.Add("DonViTinh");
            dtHH.Columns.Add("DonGia");
            dtHH.Columns.Add("MaDVT");
        
        }
        #endregion

        #region ==================== Chức năng ========================
        private void Reset()
        {
            crystalReportViewer1.Visible = false;
            txtThanhToan.Text = "";
            txtTongHoaDon.Text = "";
            txtTienNhan.Text = "";
            txtTienTraLai.Text = "";
            txtMaVach.Text = string.Empty;
            txtMaVach.Focus();
            dtView.Clear();
            dtgvBanHang.DataSource = dtView;
            dtReport.Clear();
            dtChiTietPhieuBan.Clear();
            eThongTinHoaDon.KhachTra = 0;
            eThongTinHoaDon.MaPhieu = "";
            eThongTinHoaDon.NhanVien = "";
            eThongTinHoaDon.TongTien = 0;
            eThongTinHoaDon.TraLaiKhach = 0;
            this.maPhieu= GetMaPhieu(DateTime.Now.ToString("ddMMyy"));
            TongLoiNhuan = 0;
        }

        private string GetMaPhieu(string date)
        {
            return BPhieuBanHang.GetMaPhieu(date);
        }

        private void TinhTongHoaDon()
        {
            double money = 0;
            for (int i = 0; i < dtgvBanHang.Rows.Count; i++)
            {
                money += Convert.ToDouble(dtgvBanHang["ThanhTien", i].Value);
                //TongLoiNhuan += Convert.ToDouble(dtgvBanHang["ThanhTien", i].Value) - Convert.ToDouble(dtgvBanHang["GiaNhap", i].Value);
            }
            txtTongHoaDon.Text = money.ToString("#,##");
        }

        private int KiemTraTonTai(string maHangHoa,string maDVT)
        {
            for (int i = 0; i < dtgvBanHang.RowCount; i++)
            {
                string rMH = dtgvBanHang["MaHang", i].Value.ToString();
                string rDVT = dtgvBanHang["MaDVT", i].Value.ToString();
                if (rMH == maHangHoa&& rDVT==maDVT)
                    return i;
            }
            return -1;
        }

        private void TinhTienThanhToan()
        {
            double tongHoaDon = 0;
            double thue = 0;
            double chietKhau = 0;
            double.TryParse(txtTongHoaDon.Text, out tongHoaDon);
            double.TryParse(txtPhanTramVAT.Text, out thue);
            double.TryParse(txtPhanTramChietKhau.Text, out chietKhau);
            double tienThanhToan = tongHoaDon + (tongHoaDon * (thue / 100)) - (tongHoaDon * (chietKhau / 100));
            txtThanhToan.Text = tienThanhToan.ToString("#,##");
        }

        private void TinhTienTraLai()
        {
            double tienThanhToan = 0;
            double tienNhan = 0;
            double tienTraLai = 0;
            double.TryParse(txtThanhToan.Text, out tienThanhToan);
            double.TryParse(txtTienNhan.Text, out tienNhan);
            tienTraLai = tienNhan - tienThanhToan;
            txtTienTraLai.Text = tienTraLai.ToString("#,##");
        }

        private void LuuPhieuBanHang_WithoutMaKhach(EPhieuBanHang ehanghoa)
        {
            try
            {
                foreach (DataRow item in dtView.Rows)
                {
                    DataRow row = dtChiTietPhieuBan.NewRow();
                    row["MaHang"] = item["MaHang"];
                    row["SoLuong"] = item["SoLuong"];
                    row["MaDVT"] = item["MaDVT"];
                    row["GiaBan"] = item["DonGia"];
                    row["MaPhieu"] = maPhieu;
                    row["TrangThai"] = 1;
                    row["ChietKhau"] = item["ChietKhau"];
                    row["HDTrucTiep"] = item["HDTrucTiep"];
                    row["HDVAT"] = item["HDVAT"];
                    dtChiTietPhieuBan.Rows.Add(row);
                }
                // lưu tblPhieuBan
                BPhieuBanHang.Insert_WithoutMaKhach(ehanghoa);
                // lưu tblChiTietPhieuBan
                //@MaPhieu,@MaHang,@SoLuong,@MaDVT,@GiaBan,@TrangThai
               
                BChiTietPhieuBan.Insert_WithoutMaKho(dtChiTietPhieuBan);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.ToString());
            }
            
        }

        private bool CheckTienNhan()
        {
            bool check = true;
            if (Convert.ToDouble(txtTienNhan.Text)<Convert.ToDouble(txtThanhToan.Text))
            {
                check = false;
            }
            return check;
        }

        private void LoadReport(DataTable dtHangHoa, EThongTinHoaDon ehoadon)
        {
            foreach (DataRow item in dtHangHoa.Rows)
            {
                DataRow row = dtReport.NewRow();
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
                dtReport.Rows.Add(row);
            }
            rpHoaDon rp = new rpHoaDon();
            rp.SetDataSource(dtReport);
            //rp.PrintToPrinter(1, true, 1, 1);
            crystalReportViewer1.ReportSource = rp;
            crystalReportViewer1.PrintReport();
            crystalReportViewer1.Refresh();
            crystalReportViewer1.Zoom(100);
        }
        private void dtgvBanHang_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dtgvBanHang["STT", e.RowIndex].Value = (e.RowIndex < 9 ? "0" : "") + (e.RowIndex + 1);
        }
        //private void KiemTraDuLieu()
        //{
        //    double donGia = 0, soLuong = 0;
        //    double.TryParse(, out donGia);
        //    double.TryParse(txtSoLuong.Text, out soLuong);
        //    string strError = "";
        //    if (donGia <= 0)
        //        strError = "Don gia phai >0";
        //    if (soLuong <= 0)
        //        strError += "So luong phai >0";
        //    if (strError != "")
        //    {
        //        MessageBox.Show("Loi:" + strError);
        //        return false;
        //    }
        //    return true;
        //}
        #endregion

        #region ====================== Sự kiện ===========================
        private void btnThemHang_Click(object sender, EventArgs e)
        {
            FrmThongTinHangHoa frm = new FrmThongTinHangHoa(null);
            frm.ShowDialog();
        }
        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            txtSoLuong.Focus();
        }

        private void txtMaVach_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int maHang = 0;
                string hangHoa = txtMaVach.Text.Trim();
                if (int.TryParse(hangHoa, out maHang) == false)
                {
                    data = BHangHoa.GetByTenHang(hangHoa);
                    if (data.Rows.Count == 0)
                    {
                        MessageBox.Show("Không có hàng có mã này!");
                    }

                }
                else
                {
                    //string maHang = txtMaVach.Text.Trim();
                    txtMaVach.SelectAll();
                    data = BHangHoa.GetByMaHang(hangHoa);
                    if (data.Rows.Count == 0)
                    {
                        MessageBox.Show("Không có hàng có mã này!");
                    }

                }
               
                
                if (data.Rows.Count>1)
                {
                    foreach (DataRow item in data.Rows)
                    {
                        DataRow row = dtHH.NewRow();
                        row["DonViTinh"] = item[2].ToString();
                        row["MaDVT"] = item[4].ToString();
                        row["DonGia"] =Convert.ToDouble( item[3].ToString());
                        dtHH.Rows.Add(row);
                    }
                    cbbDVT.DataSource = dtHH;
                    cbbDVT.DisplayMember = "DonViTinh";
                    cbbDVT.ValueMember = "MaDVT";
                    cbbDVT.Focus();
                }
                if (data.Rows.Count != 0)
                {
                    DataRow row = data.Rows[0];
                    string TenHang = row[1].ToString();
                    string MaHang = row[0].ToString();
                    string DonViTinh = row[2].ToString();
                    double DonGia= Convert.ToDouble( row[3].ToString());
                    string MaDVT = row[4].ToString();
                    double GiaNhap = Convert.ToDouble(row[5].ToString());
                    int SoLuong = 1;
                    double ChietKhau = 0;
                    double HDTrucTiep = 0;
                    double HDVAT = 0;
                    double.TryParse(txtChietKhauHang.Text, out ChietKhau);
                    double.TryParse(txtHDVAT.Text, out HDVAT);
                    double.TryParse(txtHĐTrucTiep.Text, out HDTrucTiep);
                    int testExist = KiemTraTonTai(MaHang, MaDVT);
                    // kiểm tra số lượng
                    if (txtSoLuong.Text != "")
                    {
                        if (testExist != -1)
                        {
                            SoLuong = int.Parse(txtSoLuong.Text) + int.Parse(dtView.Rows[testExist]["SoLuong"].ToString());
                            dtView.Rows[testExist]["SoLuong"] = SoLuong;
                            dtView.Rows[testExist]["ThanhTien"] = DonGia * (SoLuong)-ChietKhau+HDTrucTiep+HDVAT;
                            dtView.Rows[testExist]["GiaNhap"] = GiaNhap * (SoLuong);
                            dtView.Rows[testExist]["ChietKhau"] = ChietKhau;
                            dtView.Rows[testExist]["HDTrucTiep"] = HDTrucTiep;
                            dtView.Rows[testExist]["HDVAT"] = HDVAT;

                        }
                        else
                        {
                            SoLuong = int.Parse(txtSoLuong.Text);
                            DataRow dtrow = dtView.NewRow();
                            dtrow["MaHang"] = MaHang;
                            dtrow["TenHang"] = TenHang;
                            dtrow["DonViTinh"] = DonViTinh;
                            dtrow["DonGia"] = DonGia;
                            dtrow["SoLuong"] = SoLuong;
                            dtrow["ThanhTien"] = DonGia * SoLuong - ChietKhau + HDTrucTiep + HDVAT;
                            dtrow["GiaNhap"] = GiaNhap * SoLuong;
                            dtrow["MaDVT"] = MaDVT;
                            dtrow["ChietKhau"] = ChietKhau;
                            dtrow["HDTrucTiep"] = HDTrucTiep;
                            dtrow["HDVAT"] = HDVAT;
                            dtView.Rows.Add(dtrow);
                        }
                    }
                    else
                    {
                        if (testExist == -1)
                        {
                            DataRow dtrow = dtView.NewRow();
                            dtrow["MaHang"] = MaHang;
                            dtrow["TenHang"] = TenHang;
                            dtrow["DonViTinh"] = DonViTinh;
                            dtrow["DonGia"] = DonGia;
                            dtrow["SoLuong"] = SoLuong;
                            dtrow["ThanhTien"] = DonGia * SoLuong - ChietKhau + HDTrucTiep + HDVAT;
                            dtrow["GiaNhap"] = GiaNhap * SoLuong;
                            dtrow["MaDVT"] = MaDVT;
                            dtrow["ChietKhau"] = ChietKhau;
                            dtrow["HDTrucTiep"] = HDTrucTiep;
                            dtrow["HDVAT"] = HDVAT;
                            dtView.Rows.Add(dtrow);
                        }
                        else
                        {
                            int soLuongNew = int.Parse(dtView.Rows[testExist]["SoLuong"].ToString());
                            dtView.Rows[testExist]["SoLuong"] = soLuongNew + 1;
                            dtView.Rows[testExist]["ThanhTien"] = DonGia * (soLuongNew + 1) - ChietKhau + HDTrucTiep + HDVAT;
                            dtView.Rows[testExist]["GiaNhap"] = GiaNhap * (soLuongNew + 1);
                            dtView.Rows[testExist]["ChietKhau"] = ChietKhau;
                            dtView.Rows[testExist]["HDTrucTiep"] = HDTrucTiep;
                            dtView.Rows[testExist]["HDVAT"] = HDVAT;
                        }

                    }
                
                    
                    // them vao dtView
                   
                    dtgvBanHang.DataSource = dtView;
                    ResetHang();
                }
                TinhTongHoaDon();
            }
        }
        private void ResetHang()
        {
            txtSoLuong.Text = "";
            txtHĐTrucTiep.Text = "";
            txtHDVAT.Text = "";
            txtChietKhauHang.Text = "";
        }
        private void txtTongHoaDon_TextChanged(object sender, EventArgs e)
        {
            TinhTienThanhToan();
        }

        private void txtPhanTramChietKhau_TextChanged(object sender, EventArgs e)
        {
            TinhTienThanhToan();
        }

        private void txtPhanTramVAT_TextChanged(object sender, EventArgs e)
        {
            TinhTienThanhToan();
        }

        private void txtThanhToan_TextChanged(object sender, EventArgs e)
        {
            TinhTienTraLai();
        }

        private void txtTienNhan_TextChanged(object sender, EventArgs e)
        {
            FomatNumber.txtMoney_TextChanged(sender, e);
           TinhTienTraLai();
        }
        private double TingTongLoiNhuan()
        {
            double loinhuan = 0;
            double gianhap = 0;
            for (int i = 0; i < dtView.Rows.Count; i++)
            {
                gianhap += double.Parse(dtView.Rows[i]["GiaNhap"].ToString());
            }
            return loinhuan = double.Parse(txtThanhToan.Text) - gianhap;
        }
        private void btnLuuVaIn_Click(object sender, EventArgs e)
        {
            //Check tiền nhận
            if (txtTienNhan.Text=="")
            {
                MessageBox.Show("Bạn chưa nhập tiền nhân");
                return;
            }
            if (CheckTienNhan()==false)
            {
                MessageBox.Show("Tiền nhận nhỏ hơn tổng tiền");
                return;
            }
            eThongTinHoaDon.MaPhieu = maPhieu;
            eThongTinHoaDon.NhanVien = "Thao";
            eThongTinHoaDon.TongTien = double.Parse(txtThanhToan.Text);
            eThongTinHoaDon.KhachTra = double.Parse(txtTienNhan.Text);
            if (txtTienTraLai.Text=="")
            {
                eThongTinHoaDon.TraLaiKhach = 0;
            }
            else
            {
                eThongTinHoaDon.TraLaiKhach = double.Parse(txtTienTraLai.Text);
            }
            EPhieuBanHang ePhieuBanHang = new EPhieuBanHang();
            ePhieuBanHang.MaNhanVien = Session.MaNhanVien;
            ePhieuBanHang.MaPhieu = maPhieu;
            DateTime date = DateTime.Now;          
            ePhieuBanHang.NgayBan = UnixTime.GetUnixTime((date));
            ePhieuBanHang.TongTien =Convert.ToDouble( txtThanhToan.Text);
            ePhieuBanHang.TongLoiNhuan = TingTongLoiNhuan();
            // Lưu phiếu
            LuuPhieuBanHang_WithoutMaKhach(ePhieuBanHang);
            // In hóa đơn
            crystalReportViewer1.Visible = true;
            LoadReport(dtView, eThongTinHoaDon);
       
        }
        private void txtSoLuong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int soLuong = 0;
                if (int.TryParse(txtSoLuong.Text,out soLuong)==false)
                {
                    MessageBox.Show("Nhập lại số lượng");
                    txtSoLuong.SelectAll();
                }
                txtMaVach.Focus();
            }
        }
        private void UCBanHang_Load(object sender, EventArgs e)
        {
            txtMaVach.Select();
            txtMaVach.Focus();
            btnTraHang.Enabled = false;
        }

        private void btnTraHang_Click(object sender, EventArgs e)
        {
            dtView.Rows[rowIndex].Delete();
            dtgvBanHang.DataSource = dtView;
            TinhTongHoaDon();
        }

        private void dtgvBanHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnTraHang.Enabled = true;
            rowIndex = e.RowIndex;

        }
        private void cbbDVT_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbbDVT.DataSource!=null)
            {
                string maDVT = cbbDVT.SelectedValue.ToString();
                int donGia = 0;
                foreach (DataRow item in dtHH.Rows)
                {
                    if (item["MaDVT"] == maDVT)
                    {
                        donGia = int.Parse(item["DonGia"].ToString());
                    }
                }
                txtDonGia.Text = donGia.ToString();
            }
            
        }
        private void cbbDVT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
               DataRow row = data.Rows[0];
                    string TenHang = row[1].ToString();
                    string MaHang = row[0].ToString();
                    string DonViTinh = row[2].ToString();
                    double DonGia= Convert.ToDouble( row[3].ToString());
                    string MaDVT = row[4].ToString();
                    double GiaNhap = Convert.ToDouble(row[5].ToString());
                    int SoLuong = 1;
                    double ChietKhau = 0;
                    double HDTrucTiep = 0;
                    double HDVAT = 0;
                    double.TryParse(txtChietKhauHang.Text, out ChietKhau);
                    double.TryParse(txtHDVAT.Text, out HDVAT);
                    double.TryParse(txtHĐTrucTiep.Text, out HDTrucTiep);
                    int testExist = KiemTraTonTai(MaHang, MaDVT);
                    // kiểm tra số lượng
                    if (txtSoLuong.Text != "")
                    {
                        if (testExist != -1)
                        {
                            SoLuong = int.Parse(txtSoLuong.Text) + int.Parse(dtView.Rows[testExist]["SoLuong"].ToString());
                            dtView.Rows[testExist]["SoLuong"] = SoLuong;
                            dtView.Rows[testExist]["ThanhTien"] = DonGia * (SoLuong)-ChietKhau+HDTrucTiep+HDVAT;
                            dtView.Rows[testExist]["GiaNhap"] = GiaNhap * (SoLuong);
                            dtView.Rows[testExist]["ChietKhau"] = ChietKhau;
                            dtView.Rows[testExist]["HDTrucTiep"] = HDTrucTiep;
                            dtView.Rows[testExist]["HDVAT"] = HDVAT;

                        }
                        else
                        {
                            SoLuong = int.Parse(txtSoLuong.Text);
                            DataRow dtrow = dtView.NewRow();
                            dtrow["MaHang"] = MaHang;
                            dtrow["TenHang"] = TenHang;
                            dtrow["DonViTinh"] = DonViTinh;
                            dtrow["DonGia"] = DonGia;
                            dtrow["SoLuong"] = SoLuong;
                            dtrow["ThanhTien"] = DonGia * SoLuong - ChietKhau + HDTrucTiep + HDVAT;
                            dtrow["GiaNhap"] = GiaNhap * SoLuong;
                            dtrow["MaDVT"] = MaDVT;
                            dtrow["ChietKhau"] = ChietKhau;
                            dtrow["HDTrucTiep"] = HDTrucTiep;
                            dtrow["HDVAT"] = HDVAT;
                            dtView.Rows.Add(dtrow);
                        }
                    }
                    else
                    {
                        if (testExist == -1)
                        {
                            DataRow dtrow = dtView.NewRow();
                            dtrow["MaHang"] = MaHang;
                            dtrow["TenHang"] = TenHang;
                            dtrow["DonViTinh"] = DonViTinh;
                            dtrow["DonGia"] = DonGia;
                            dtrow["SoLuong"] = SoLuong;
                            dtrow["ThanhTien"] = DonGia * SoLuong - ChietKhau + HDTrucTiep + HDVAT;
                            dtrow["GiaNhap"] = GiaNhap * SoLuong;
                            dtrow["MaDVT"] = MaDVT;
                            dtrow["ChietKhau"] = ChietKhau;
                            dtrow["HDTrucTiep"] = HDTrucTiep;
                            dtrow["HDVAT"] = HDVAT;
                            dtView.Rows.Add(dtrow);
                        }
                        else
                        {
                            int soLuongNew = int.Parse(dtView.Rows[testExist]["SoLuong"].ToString());
                            dtView.Rows[testExist]["SoLuong"] = soLuongNew + 1;
                            dtView.Rows[testExist]["ThanhTien"] = DonGia * (soLuongNew + 1) - ChietKhau + HDTrucTiep + HDVAT;
                            dtView.Rows[testExist]["GiaNhap"] = GiaNhap * (soLuongNew + 1);
                            dtView.Rows[testExist]["ChietKhau"] = ChietKhau;
                            dtView.Rows[testExist]["HDTrucTiep"] = HDTrucTiep;
                            dtView.Rows[testExist]["HDVAT"] = HDVAT;
                        }

                    }
                
                    
                    // them vao dtView
                   
                    dtgvBanHang.DataSource = dtView;
                    ResetHang();
                
                TinhTongHoaDon();

                cbbDVT.DataSource = null;
                txtDonGia.Text = "";
                txtMaVach.SelectAll();
                txtMaVach.Focus();
            }
        }
     

        private void txtChietKhauHang_TextChanged(object sender, EventArgs e)
        {
            FomatNumber.txtMoney_TextChanged(sender, e);
        }

        private void txtHĐTrucTiep_TextChanged(object sender, EventArgs e)
        {
            FomatNumber.txtMoney_TextChanged(sender, e);
        }

        private void txtHDVAT_TextChanged(object sender, EventArgs e)
        {

        }
  
        private void txtMaVach_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string text = txtMaVach.Text.Trim();
                //txtMaVach.AutoCompleteMode = AutoCompleteMode.Suggest;
                //txtMaVach.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                DataTable dt = BHangHoa.GetByTenHang(text);
                foreach (DataRow item in dt.Rows)
                {
                    col.Add(item["TenHang"].ToString());
                }
                txtMaVach.AutoCompleteCustomSource = col;

            }
            catch
            {
            }
        }

        #endregion














    }
}
