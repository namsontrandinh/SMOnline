using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SalesManagement.BLL.ThietLapBanDauBLL;
using SalesManagement.ENTITY.BaoCaoThongKe;

namespace SalesManagement.FORM.BaoCaoThongKe
{
    
    public partial class UCDoanhThuTheoThang : UserControl
    {
        #region ================ Khởi tạo ================
        EDoanhThuTheoThang eDoanhThu = new EDoanhThuTheoThang();
        public UCDoanhThuTheoThang()
        {
            InitializeComponent();
            LoadCombobox();
            LayNamMacDinh();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }
        #endregion

        #region =============== Chức năng ==================
        private void LoadCombobox()
        {
            cbbSanPham.DataSource = BHangHoa.GetAll();
            cbbSanPham.ValueMember = "MaHang";
            cbbSanPham.DisplayMember = "TenHang";
        }

        private bool KiemTraDuLieu()
        {
            string strLoi = "";
            if (txtTuThang.Text.Equals(""))
                strLoi = "Giá trị từ tháng không được để trống\n";
            if (txtDenThang.Text.Equals(""))
                strLoi += "Giá trị đến tháng không được để trống";
            if(strLoi.Equals("") == false)
            {
                MessageBox.Show(strLoi);
                return false;
            }
            return true;
        }

        private void NhapLai()
        {
            txtTuThang.Text = "";
            txtDenThang.Text = "";
        }

        private void LoadDuLieu()
        {
            if (KiemTraDuLieu() == false)
                return;
            eDoanhThu.TuThang = Convert.ToInt32(txtTuThang.Text.Trim());
            eDoanhThu.TuNam = Convert.ToInt32(txtTuNam.Text.Trim());
            eDoanhThu.DenThang = Convert.ToInt32(txtDenThang.Text.Trim());
            eDoanhThu.DenNam = Convert.ToInt32(txtDenNam.Text.Trim());
            if (ckChonTatCa.Checked)
            {
                eDoanhThu.MaHang = "";
            }
            else
            {
                eDoanhThu.MaHang = cbbSanPham.SelectedValue.ToString();
            }
            dtgvDoanhThuTheoThang.DataSource = BDoanhThuTheoThang.LayDoanhThuTheoID(eDoanhThu);
        }

        private void LayNamMacDinh()
        {
            txtTuNam.ReadOnly = true;
            txtDenNam.ReadOnly = true;
            txtDenNam.Text = (DateTime.Now.Year.ToString());
            txtTuNam.Text = (DateTime.Now.Year.ToString());
        }
        #endregion

        #region ================ Sự kiện ==================
        private void dtgvDoanhThuTheoThang_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dtgvDoanhThuTheoThang["STT", e.RowIndex].Value = (e.RowIndex < 9 ? "0" : "") + (e.RowIndex + 1);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadDuLieu();
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            NhapLai();
        }
        #endregion
    }
}
