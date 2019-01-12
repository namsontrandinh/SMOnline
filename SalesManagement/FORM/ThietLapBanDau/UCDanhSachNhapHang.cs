using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SalesManagement.BLL.ThietLapBanDauBLL;
using SalesManagement.FORM.ThietLapBanDau;
using SalesManagement.ENTITY.ThietLapBanDauEntity;

namespace SalesManagement.FORM.ThieLapBanDau
{
    public partial class UCDanhSachNhapHang : UserControl
    {
        #region =============== Khởi tạo ====================
        private DataTable dtDataActived = null;
        private EHangHoa eHangHoa = new EHangHoa();

        public UCDanhSachNhapHang()
        {
            InitializeComponent();
        }

        private void UCDanhSachNhapHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        #endregion

        #region =============== Chức năng ====================
        private void LoadData()
        {
            try
            {
                dtgvDSPhieuNhapHang.AutoGenerateColumns = false;
                dtDataActived = BHangHoa.GetAll();
                dtgvDSPhieuNhapHang.DataSource = dtDataActived;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lối:" + ex);
            }
        }
        #endregion

        #region =============== Sự kiện ==================
        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            FrmThongTinHangHoa frm = new FrmThongTinHangHoa(null);
            frm.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            FrmThongTinHangHoa frm = new FrmThongTinHangHoa(eHangHoa);
            frm.ShowDialog();
        }

        private void dtgvDSPhieuNhapHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0)
                return;

            DataGridViewRow row = dtgvDSPhieuNhapHang.Rows[rowIndex];
            eHangHoa.MaHang = row.Cells["MaNhanVien"].Value.ToString();
            eHangHoa.TenHang = row.Cells["MaNhanVien"].Value.ToString();
            eHangHoa.MaVach = row.Cells["MaNhanVien"].Value.ToString();
            eHangHoa.MaDVT = Convert.ToInt32(row.Cells["MaNhanVien"].Value.ToString());
            eHangHoa.MaNhomHangHoa = Convert.ToInt32(row.Cells["MaNhanVien"].Value.ToString());
            eHangHoa.MaKho = Convert.ToInt32(row.Cells["MaNhanVien"].Value.ToString());
            
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string filter = txtTimKiem.Text.Trim();
                string strSelect = string.Format("MaHang like '%{0}%' Or MaVach like '%{1}%'", filter, filter);
                DataRow[] arrRow = dtDataActived.Select(strSelect);
                DataTable dtSearch = dtDataActived.Clone();
                foreach (DataRow row in arrRow)
                {
                    dtSearch.ImportRow(row);
                }
                dtgvDSPhieuNhapHang.DataSource = dtSearch;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex);
            }
        }

        #endregion

        private void dtgvDSPhieuNhapHang_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dtgvDSPhieuNhapHang["STT", e.RowIndex].Value = (e.RowIndex < 9 ? "0" : "") + (e.RowIndex + 1);
        }
    }
}
