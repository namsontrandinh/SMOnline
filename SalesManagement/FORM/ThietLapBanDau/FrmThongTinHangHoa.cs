using SalesManagement.BLL.ThietLapBanDauBLL;
using SalesManagement.ENTITY.ThietLapBanDauEntity;
using SalesManagement.ENTITY.Utility;
using SalesManagement.PUBLICCODE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SalesManagement.FORM.ThietLapBanDau
{
    public partial class FrmThongTinHangHoa : Form
    {
        #region ======================= Khởi tạo =======================
        private bool isAddnew = true;

        public FrmThongTinHangHoa(EHangHoa eHangHoa)
        {
            InitializeComponent();
            txtMaHangHoa.Focus();
            FillData(eHangHoa);
            LoadDVT();

        }
        #endregion

        #region ======================= Chức năng =======================
        private void LoadDVT()
        {
            //DataTable dt = BDonViTinh.GetAll();
            cbbDVT.DataSource = BDonViTinh.GetAll();
            cbbDVT.DisplayMember = "DonViTinh";
            cbbDVT.ValueMember = "MaDVT";
            cbbDonViTinh1.DataSource = BDonViTinh.GetAll();
            cbbDonViTinh1.DisplayMember = "DonViTinh";
            cbbDonViTinh1.ValueMember = "MaDVT";
            cbbDonViTinh2.DataSource = BDonViTinh.GetAll();
            cbbDonViTinh2.DisplayMember = "DonViTinh";
            cbbDonViTinh2.ValueMember = "MaDVT";
        }
        private bool CheckValidData()
        {
            string strError = "";
            if (txtMaHangHoa.Text.Equals(""))
                strError = "\n Mã hàng hóa không được để trống";
            if (txtTenHangHoa.Text.Equals(""))
                strError = "\n Tên hàng hóa không được để trống";
            if (txtMaVachNSX.Text.Equals(""))
                strError = "\n Mã vạch không được để trống";
            if (string.IsNullOrEmpty(strError) == false)
            {
                MessageBox.Show("Lỗi:" + strError);
                return false;
            }
            return true;
        }

        private void FillData(EHangHoa eHangHoa)
        {
            if (eHangHoa == null)
            {
                txtMaHangHoa.Text = string.Empty;
                txtTenHangHoa.Text = string.Empty;
                txtMaVachNSX.Text = string.Empty;
                cbbDVT.Text = null;
                cbbKhoQuay.Text = null;
                cbbNhomHang.Text = null;
                txtMaHangHoa.Select();
                txtMaHangHoa.Focus();
            }
            else
            {
                isAddnew = false;

                txtMaHangHoa.Text = eHangHoa.MaHang;
                txtTenHangHoa.Text = eHangHoa.TenHang;
                txtMaVachNSX.Text = eHangHoa.MaVach;
                cbbDVT.Text = eHangHoa.MaDVT.ToString();
                cbbKhoQuay.Text = eHangHoa.MaKho.ToString();
                cbbNhomHang.Text = eHangHoa.MaNhomHangHoa.ToString();
            }
        }
        private void Reset()
        {
            txtGiaNhapHang.Text = "";
            txtGiaBanHang.Text = "";
            txtMaHangHoa.Text = "";
            txtTenHangHoa.Text = "";
            txtMaVachNSX.Text = "";
            rtxtGhiChu.Text = "";
            txtMaHangHoa.Focus();
        }
        #endregion

        #region ======================= Sự kiện =======================
        private void btnThemDonViTinh_Click(object sender, EventArgs e)
        {

        }

        private void btnThemNhaCungCap_Click(object sender, EventArgs e)
        {
            FrmDanhSachDVT frm = new FrmDanhSachDVT();
            frm.ShowDialog();
        }

        private void btnThemDonViTinh2_Click(object sender, EventArgs e)
        {
            FrmDanhSachDVT frm = new FrmDanhSachDVT();
            frm.ShowDialog();
        }
        #endregion

        private void btnLuuThem_Click(object sender, EventArgs e)
        {
            if (CheckValidData() == false)
                return;
            if (isAddnew)
            {
                ThemHangHoa();
                Reset();
            }
            else
                CapNhatHangHoa();
        }

        private void ThemHangHoa()
        {
            EHangHoa eHangHoa = new EHangHoa();
            eHangHoa.MaHang = txtMaHangHoa.Text.Trim();
            eHangHoa.TenHang = txtTenHangHoa.Text.Trim();
            eHangHoa.MaDVT = Convert.ToInt32(cbbDVT.SelectedValue.ToString());
            //eHangHoa.MaNhomHangHoa = Convert.ToInt32(cbbNhomHang.SelectedValue.ToString());
            //eHangHoa.MaKho = Convert.ToInt32(cbbKhoQuay.SelectedValue.ToString());
            eHangHoa.MaKho = 1;
            eHangHoa.MaNhomHangHoa = 1;
            eHangHoa.GiaNhap = Convert.ToDouble(txtGiaNhapHang.Text.Trim());
            eHangHoa.GiaBan = Convert.ToDouble(txtGiaBanHang.Text.Trim());
            eHangHoa.MaVach = txtMaVachNSX.Text.Trim();
            eHangHoa.CreateDate = UnixTime.GetUnixTime(DateTime.Now);// dùng unix time
            eHangHoa.CreateID = Session.MaNhanVien;
            eHangHoa.MaNCC = 1;
            eHangHoa.EditDate = UnixTime.GetUnixTime(DateTime.Now);
            eHangHoa.EditID = Session.MaNhanVien;
            try
            {
                BHangHoa.Insert(eHangHoa);
                MessageBox.Show("Thêm thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex.ToString());
            }
        }
        private void CapNhatHangHoa()
        {
            EHangHoa eHangHoa = new EHangHoa();
            eHangHoa.MaHang = txtMaHangHoa.Text.Trim();
            eHangHoa.TenHang = txtTenHangHoa.Text.Trim();
            eHangHoa.MaDVT = Convert.ToInt32(cbbDVT.SelectedValue.ToString());
            //eHangHoa.MaNhomHangHoa = Convert.ToInt32(cbbNhomHang.SelectedValue.ToString());
            //eHangHoa.MaKho = Convert.ToInt32(cbbKhoQuay.SelectedValue.ToString());
            eHangHoa.MaNhomHangHoa = 1;
            eHangHoa.MaKho = 1;
            eHangHoa.GiaBan = Convert.ToDouble(txtGiaNhap.Text.Trim());
            eHangHoa.MaVach = txtMaVach.Text.Trim();
            try
            {
                BHangHoa.Update(eHangHoa);
                MessageBox.Show("Cập nhật thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex.ToString());
            }
        }

        private void txtMaHangHoa_TextChanged(object sender, EventArgs e)
        {
            txtMaVachNSX.Text = txtMaHangHoa.Text;
        }

        private void txtMaHangHoa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtTenHangHoa.Enabled = true;
                txtTenHangHoa.Focus();
            }
        }

        private void txtTenHangHoa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtGiaNhapHang.Focus();
            }
        }

        private void txtGiaBanHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
            }
        }

        private void FrmThongTinHangHoa_Load(object sender, EventArgs e)
        {
            panelEx11.Enabled = true;
            txtMaHangHoa.Focus();
        }

        private void btnLuuDong_Click(object sender, EventArgs e)
        {
            if (CheckValidData() == false)
                return;
            if (isAddnew)
            {
                ThemHangHoa();
                this.Close();
            }
            else
            {
                CapNhatHangHoa();
                this.Close();
            }
        }

        private void txtGiaNhapHang_TextChanged(object sender, EventArgs e)
        {
            FomatNumber.txtMoney_TextChanged(sender, e);
        }

        private void txtGiaBanHang_TextChanged(object sender, EventArgs e)
        {
            FomatNumber.txtMoney_TextChanged(sender, e);
        }
    }
}
