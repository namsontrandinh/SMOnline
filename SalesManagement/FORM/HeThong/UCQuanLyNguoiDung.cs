using SalesManagement.BLL;
using SalesManagement.ENTITY.User;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SalesManagement.FORM.HeThong
{
    public partial class UCQuanLyNguoiDung : UserControl
    {
        #region ======================= Khởi tạo =======================
        public UCQuanLyNguoiDung()
        {
            InitializeComponent();
        }

        private void UCQuanLyNguoiDung_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        #endregion

        #region ======================= Chức năng =======================
        private void LoadData()
        {
            try
            {
                List<EUser> userlst = BUser.GetAll();
                dtgvUser.DataSource = userlst;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex);
            }
        }
        #endregion

        #region ======================= Sự kiện =======================
        private void btnThem_Click(object sender, EventArgs e)
        {
            FrmThemMoiTaiKhoan frm = new FrmThemMoiTaiKhoan();
            frm.ShowDialog();
        }

        #endregion

        private void dtgvUser_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dtgvUser["STT", e.RowIndex].Value = (e.RowIndex < 9 ? "0" : "") + (e.RowIndex + 1);
        }
    }
}
