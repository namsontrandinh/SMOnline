using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace SalesManagement.FORM.QuanLyBanHang
{
    public partial class UCPhieuNhapHang : UserControl
    {
        #region ================ Khởi tạo ======================
        public UCPhieuNhapHang()
        {
            InitializeComponent();
        }
        #endregion

        #region ================ Chức năng ======================
        private void TinhTongTien()
        {
            double money = 0;
            for (int i = 0; i < dtgvPhieuNhapHang.Rows.Count; i++)
            {
                money += Convert.ToDouble(dtgvPhieuNhapHang["ThanhTien", i].Value);
            }
            txtTongHoaDon.Text = money.ToString("#,##");
        }
        private void TinhThanhTien()
        {

        }
        #endregion

        #region ================= Sự kiện =====================
        #endregion
    }
}
