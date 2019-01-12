using SalesManagement.BLL.ThietLapBanDauBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SalesManagement.FORM.ThietLapBanDau
{
    public partial class FrmDanhSachDVT : Form
    {
        #region ======================= Khởi tạo =======================
        private DataTable dtDataActived = null;

        public FrmDanhSachDVT()
        {
            InitializeComponent();
        }
        #endregion

        #region ======================= Chức năng =======================
        private void LoadData()
        {
            try
            {
                dtgvDonViTinh.AutoGenerateColumns = false;
                dtDataActived = BDonViTinh.GetAll();
                dtgvDonViTinh.DataSource = dtDataActived;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex);
            }
        }
        #endregion

        #region ======================= Sự kiện =======================
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            FrmThemDVT frm = new FrmThemDVT();
            frm.ShowDialog();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string filter = txtTimKiem.Text.Trim();
                string strSelect = string.Format("MaDVT like '%{0}%' Or DonViTinh like '%{1}%'", filter, filter);
                DataRow[] arrRow = dtDataActived.Select(strSelect);
                DataTable dtSearch = dtDataActived.Clone();
                foreach (DataRow row in arrRow)
                {
                    dtSearch.ImportRow(row);
                }
                dtgvDonViTinh.DataSource = dtSearch;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex);
            }
        }
        #endregion
    }
}
