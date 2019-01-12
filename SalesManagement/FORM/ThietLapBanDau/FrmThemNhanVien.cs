using SalesManagement.BLL.ThietLapBanDau;
using SalesManagement.ENTITY.ThietLapBanDau;

using System;
using System.Windows.Forms;

namespace SalesManagement.FORM.ThietLapBanDau
{
    public partial class FrmThemNhanVien : Form
    {
        #region ======================== Khởi tạo ======================== 
        private bool isAddnew = true;
        
        public FrmThemNhanVien(ENhanVien editENhanVien,string MaNhanVien)
        {
            InitializeComponent();
            FillData(editENhanVien);
            txtMaNhanVien.Text = MaNhanVien;
        }

        private void FrmThemNhanVien_Load(object sender, EventArgs e)
        {
            LoadCombobox();
        }
        #endregion

        #region ======================== Chức năng ========================
        private void LoadCombobox()
        {
            cbbGioiTinh.DataSource = BNhanVien.LoadComboboxGender();
            cbbGioiTinh.ValueMember = "ID";
            cbbGioiTinh.DisplayMember = "Gender";
        }

        private bool CheckValidData()
        {
            string strError = "";
            if (txtTenNhanVien.Text.Equals(""))
                strError = "\n Tên nhân viên không được để trống\n";
            if (dtpkNgaySinh.Text.Equals(""))
                strError += "Ngày sinh không được để trống";
            if (txtDienThoai.Text.Equals(""))
                strError += "Điện thoại không được để trống";
            if (strError.Equals("")==false)
            {
                MessageBox.Show("Lỗi:" + strError);
                return false;
            }
            return true;
        }

        private void FillData(ENhanVien eNhanVienInfo)
        {
            if (eNhanVienInfo == null)
            {
                txtMaNhanVien.Text = string.Empty;
                txtTenNhanVien.Text = string.Empty;
                cbbGioiTinh.Text = null;
                txtDienThoai.Text = string.Empty;
                rtxtThongTinThem.Text = string.Empty;
            }
            else
            {
                isAddnew = false;

                txtMaNhanVien.Text = eNhanVienInfo.MaNhanVien;
                txtTenNhanVien.Text = eNhanVienInfo.TenNhanVien;
                dtpkNgaySinh.Value = eNhanVienInfo.NgaySinh;
                cbbGioiTinh.Text = eNhanVienInfo.GioiTinh.ToString();
                txtDienThoai.Text = eNhanVienInfo.SoDienThoai;
                rtxtThongTinThem.Text = eNhanVienInfo.ThongTinThem; 
            }
        }
        #endregion

        #region ======================== Sự kiện ========================
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (CheckValidData() == false)
                return;
            if (isAddnew)
                ThemNhanVien();
            else
                txtMaNhanVien.ReadOnly = true;
                CapNhatNhanVien();
        }

        private void ThemNhanVien()
        {
            ENhanVien eNhanVien = new ENhanVien();
            eNhanVien.MaNhanVien = txtMaNhanVien.Text.Trim();
            eNhanVien.TenNhanVien = txtTenNhanVien.Text.Trim();
            eNhanVien.NgaySinh = dtpkNgaySinh.Value;
            eNhanVien.GioiTinh = byte.Parse(cbbGioiTinh.SelectedValue.ToString());
            eNhanVien.SoDienThoai = txtDienThoai.Text.Trim();
            eNhanVien.ThongTinThem = rtxtThongTinThem.Text.Trim();
            try
            {
                BNhanVien.Insert(eNhanVien);
                MessageBox.Show("Thêm thành công");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex);
            }
        }

        private void CapNhatNhanVien()
        {
            ENhanVien eNhanVien = new ENhanVien();
            eNhanVien.MaNhanVien = txtMaNhanVien.Text.Trim();
            eNhanVien.TenNhanVien = txtTenNhanVien.Text.Trim();
            eNhanVien.NgaySinh = dtpkNgaySinh.Value;
            eNhanVien.GioiTinh = byte.Parse(cbbGioiTinh.SelectedValue.ToString());
            eNhanVien.SoDienThoai = txtDienThoai.Text.Trim();
            eNhanVien.ThongTinThem = rtxtThongTinThem.Text.Trim();
            try
            {
                BNhanVien.Update(eNhanVien);
                MessageBox.Show("Cập nhật thành công");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex);
            }
        }
        #endregion
    }
}
