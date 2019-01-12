using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SalesManagement.ENTITY.ThietLapBanDauEntity;
using SalesManagement.BLL.ThietLapBanDauBLL;

namespace SalesManagement.FORM.ThietLapBanDau
{
    public partial class UCNhaCungCap : UserControl
    {
        #region ======================== Khởi tạo =======================
        ENhaCungCap eNhaCungCap = new ENhaCungCap();
        public UCNhaCungCap()
        {
            InitializeComponent();
            LoadData();
        }
        #endregion ======================================================

        #region =========================== Chức năng ======================
        private void LoadData()
        {
            DataTable data = BNhaCungCap.GetAll();
            dtgvNhaCungCap.DataSource = data;
        }
        #endregion ==========================================================

        #region ============================== Sự kiện =========================
        private void btnThem_Click(object sender, EventArgs e)
        {
            FrmNhaCungCap frm = new FrmNhaCungCap();
            frm.ShowDialog();
            LoadData();
        }
        #endregion =============================================================

       
     

        

        
    }
}
