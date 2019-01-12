using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SalesManagement.BLL.ThietLapBanDauBLL;

namespace SalesManagement.FORM.ThietLapBanDau
{
    public partial class UCDanhSachKhachHang : UserControl
    {
        #region =================== Khởi tạo ======================
        public UCDanhSachKhachHang()
        {
            InitializeComponent();
            LoadData();
        }

        #endregion ================================================
        #region ========================== Chức năng =====================

        private void LoadData()
        {
            DataTable data = BKhachHang.GetAll();
            dtgvKhachHang.DataSource = data;
        }
        #endregion =======================================================

        #region ======================== Sự kiện ==========================
        private void btnThem_Click(object sender, EventArgs e)
        {
            FrmKhachHang frm = new FrmKhachHang();
            frm.ShowDialog();
            LoadData();
        }
        #endregion ========================================================
        
    }
}
