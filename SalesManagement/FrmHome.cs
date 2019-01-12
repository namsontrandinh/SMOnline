using DevComponents.DotNetBar;

using SalesManagement.FORM.HeThong;
using SalesManagement.FORM.QuanLyBanHang;
using SalesManagement.FORM.QuanLyBanHang.BanHang;
using SalesManagement.FORM.ThieLapBanDau;
using SalesManagement.FORM.ThietLapBanDau;
using System;
using System.Windows.Forms;
using SalesManagement.FORM.BaoCaoThongKe;

namespace SalesManagement
{
    public partial class FrmHome : Form
    {
        #region ===================== Khởi tạo =====================
        private FrmLogIn frmLogIn = null;

        public FrmHome()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            
            // Hiển thị controls
            //EnableControl(false);

            // Hiển thị form đăng nhập
            //OpenFormUserLogin();
        }

        /// <summary>
        /// Hiển thị các chức năng
        /// </summary>
        private void EnableControl(bool state)
        {
            if (state == true)
            {
                DangXuatToolStripMenuItem.Visible = true;
                QuanLyBanHangToolStripMenuItem.Visible = true;
                BaoCaoThongKeToolStripMenuItem.Visible = true;
                ThietLapBanDauToolStripMenuItem.Visible = true;
                DoiMatKhauToolStripMenuItem.Visible = true;
                QLNguoiDungToolStripMenuItem.Visible = true;
                PhanQuyenToolStripMenuItem.Visible = true;
                SaoLuuDuLieuToolStripMenuItem.Visible = true;
                PhucHoiDuLieuToolStripMenuItem.Visible = true;
                DoiMatKhauToolStripMenuItem.Visible = true;
                DangNhapToolStripMenuItem.Visible = false;
            }
            else
            {
                DangNhapToolStripMenuItem.Visible = true;
                DangXuatToolStripMenuItem.Visible = false;
                QuanLyBanHangToolStripMenuItem.Visible = false;
                BaoCaoThongKeToolStripMenuItem.Visible = false;
                ThietLapBanDauToolStripMenuItem.Visible = false;
                QLNguoiDungToolStripMenuItem.Visible = false;
                PhanQuyenToolStripMenuItem.Visible = false;
                SaoLuuDuLieuToolStripMenuItem.Visible = false;
                PhucHoiDuLieuToolStripMenuItem.Visible = false;
                DoiMatKhauToolStripMenuItem.Visible = false;
            }
        }
        #endregion

        #region ===================== Thao tác người dùng =====================
        #region ===================== Form đăng nhập và đăng xuất =====================
        private void DangNhapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormUserLogin();
        }

        private void DangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void OpenFormUserLogin()
        {
            if (frmLogIn != null)
                frmLogIn.Close();

            frmLogIn = new FrmLogIn();
            frmLogIn.eventSuccessLogIn += FrmLogIn_eventSuccessLogIn;
            frmLogIn.eventFormClose += FrmLogIn_eventFormClose;
            frmLogIn.ShowDialog();
        }

        //private void FrmLogIn_eventSuccessLogIn(object obj = null)
        //{
        //    EnableControl(true);
        //}
        //private void FrmLogIn_eventFormClose(object obj = null)
        //{
        //    frmLogIn = null;
        //}
        private void FrmLogIn_eventSuccessLogIn(object obj)
        {
            EnableControl(true);
        }
        private void FrmLogIn_eventFormClose(object obj )
        {
            frmLogIn = null;
        }
        #endregion
        #endregion

        #region ===================== Thêm Tab =====================
        /// <summary>
        /// Hàm đóng tab
        /// </summary>
        private void tabContent_TabItemClose(object sender, DevComponents.DotNetBar.TabStripActionEventArgs e)
        {
            // Lấy ra tab được chọn
            TabItem choseTab = tabContent.SelectedTab;
            string tabName = choseTab.Text;

            // Xóa bỏ tab
            tabContent.Tabs.Remove(choseTab);
        }

        /// <summary>
        /// Hàm thêm tab
        /// </summary>
        private void addNewTab(string strTabName, UserControl ucContent)
        {
            //-----------If exist tabpage then exit---------------
            foreach (TabItem tabPage in tabContent.Tabs)
                if (tabPage.Text == strTabName)
                {
                    tabContent.SelectedTab = tabPage;
                    return;
                }
            //-------------------------Clear Tab Before---------------
            TabControlPanel newTabPanel = new DevComponents.DotNetBar.TabControlPanel();
            TabItem newTabPage = new TabItem(this.components);
            newTabPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            newTabPanel.Location = new System.Drawing.Point(0, 26);
            newTabPanel.Name = "panel" + strTabName;
            newTabPanel.Padding = new System.Windows.Forms.Padding(1);
            newTabPanel.Size = new System.Drawing.Size(1230, 384);
            newTabPanel.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            newTabPanel.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            newTabPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            newTabPanel.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            newTabPanel.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            newTabPanel.Style.GradientAngle = 90;
            newTabPanel.TabIndex = 2;
            newTabPanel.TabItem = newTabPage;
            //-------------New  tab page---------------------
            Random ran = new Random();
            newTabPage.Name = strTabName + ran.Next(100000) + ran.Next(22342);
            newTabPage.AttachedControl = newTabPanel;
            newTabPage.Text = strTabName;
            ucContent.Dock = DockStyle.Fill;
            newTabPanel.Controls.Add(ucContent);

            //------------add Tab page to Tab control-------------
            tabContent.Controls.Add(newTabPanel);
            tabContent.Tabs.Add(newTabPage);
            tabContent.SelectedTab = newTabPage;
        }
        #endregion

        #region ===================== Sự kiện =====================

        #endregion

        private void QLNguoiDungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCQuanLyNguoiDung uc = new UCQuanLyNguoiDung();
            addNewTab("Quản lý người dùng", uc);
        }

        private void HangHoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCDanhSachNhapHang uc = new UCDanhSachNhapHang();
            addNewTab("Danh sách nhập hàng", uc);
        }

        private void BanHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCBanHang uc = new UCBanHang();
            addNewTab("Phiếu bán hàng", uc);
        }

        private void DSKhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCDanhSachKhachHang uc = new UCDanhSachKhachHang();
            addNewTab("Danh sách khách hàng", uc);
        }

        private void NhomKhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCDanhSachNhomKhach uc = new UCDanhSachNhomKhach();
            addNewTab("Danh sách nhóm khách hàng", uc);
        }

        private void DoiMatKhauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDoiMatKhau frm = new FrmDoiMatKhau();
            frm.ShowDialog();
        }

        private void DsNhapHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCDanhSachNhapHang uc = new UCDanhSachNhapHang();
            addNewTab("Danh sách nhập hàng", uc);
        }

        private void PhieuNhapHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCPhieuNhapHang uc = new UCPhieuNhapHang();
            addNewTab("Phiếu nhập hàng", uc);
        }

        private void DanhSachMatHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCDanhSachMatHang uc = new UCDanhSachMatHang();
            addNewTab("Danh sách mặt hàng", uc);
        }

        private void NhaCungCapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCNhaCungCap uc = new UCNhaCungCap();
            addNewTab("Danh sách nhà cung cấp", uc);
        }

        private void NhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCDanhSachNhanVien uc = new UCDanhSachNhanVien();
            addNewTab("Danh sách nhân viên", uc);
        }

        private void inMãVạchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCInMaVach uc = new UCInMaVach();
            addNewTab("In mã vạch", uc);
        }

        private void tổngHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCDoanhThuTheoNgay uc = new UCDoanhThuTheoNgay();
            addNewTab("Doanh thu theo ngày", uc);
        }

        private void BCDThuThangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCDoanhThuTheoThang uc = new UCDoanhThuTheoThang();
            addNewTab("Doanh thu theo tháng", uc);
        }
    }
}
