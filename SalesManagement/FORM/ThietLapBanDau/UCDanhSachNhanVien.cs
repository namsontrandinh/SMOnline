using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SalesManagement.BLL.ThietLapBanDau;
using SalesManagement.ENTITY.ThietLapBanDau;

namespace SalesManagement.FORM.ThietLapBanDau
{
    public partial class UCDanhSachNhanVien : UserControl
    {
        #region ===================== Khởi tạo ===================== 
        private DataTable dtAllNhanVien = new DataTable();
        private ENhanVien eNhanVien = new ENhanVien();

        public UCDanhSachNhanVien()
        {
            InitializeComponent();
        }

        private void UCDanhSachNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        #endregion

        #region ===================== Chức năng =====================
        private void LoadData()
        {
            try
            {
                dtAllNhanVien = BNhanVien.GetAll();
                dtgvNhanVien.DataSource = dtAllNhanVien;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.ToString());
            }
        }
        #endregion

        #region ===================== Sự kiện =====================
        private void btnThem_Click(object sender, EventArgs e)
        {
            string maNhanVien = BNhanVien.GetMaNhanVien();
            FrmThemNhanVien frm = new FrmThemNhanVien(null,maNhanVien);
            frm.ShowDialog();
            LoadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            FrmThemNhanVien frm = new FrmThemNhanVien(eNhanVien,null);
            frm.ShowDialog();
            LoadData();
        }

        private void dtgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0)
                return;

            DataGridViewRow row = dtgvNhanVien.Rows[rowIndex];
            eNhanVien.MaNhanVien = row.Cells["MaNhanVien"].Value.ToString();
            eNhanVien.TenNhanVien = row.Cells["TenNhanVien"].Value.ToString();
            eNhanVien.NgaySinh = DateTime.Parse(row.Cells["NgaySinh"].Value.ToString());
            eNhanVien.GioiTinh = byte.Parse(row.Cells["GioiTinh"].Value.ToString());
            eNhanVien.SoDienThoai = row.Cells["SoDienThoai"].Value.ToString();
            eNhanVien.ThongTinThem = row.Cells["ThongTinThem"].Value.ToString();
        }

        private void dtgvNhanVien_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dtgvNhanVien["STT", e.RowIndex].Value = (e.RowIndex < 9 ? "0" : "") + (e.RowIndex + 1);
        }
        #endregion

        
    }
}
