using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SalesManagement.ENTITY.ThietLapBanDauEntity;
using SalesManagement.BLL.ThietLapBanDauBLL;
using SalesManagement.PUBLICCODE;

namespace SalesManagement.FORM.ThietLapBanDau
{
    public partial class UCDanhSachMatHang : UserControl
    {
        #region ================== Khởi tạo ================== 
        private DataTable dtAllHangHoa = new DataTable();
        private EHangHoa eHangHoa = new EHangHoa();

        public UCDanhSachMatHang()
        {
            InitializeComponent();
            
        }

        private void UCDanhSachMatHang_Load(object sender, EventArgs e)
        {
            LoadData();
            //Loadcombobox();
        }
        #endregion

        #region ================== Chức năng ==================
        private void LoadData()
        {
            try
            {
                dtAllHangHoa = BHangHoa.GetHangHoa();
                dtgvDanhSachHangHoa.DataSource = dtAllHangHoa;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.ToString());
            }
        }

        //private void Loadcombobox()
        //{
        //    CreateDate.DataSource = BHangHoa.GetAll();
        //    CreateDate.ValueMember = "CreateDate";
        //    CreateDate.DisplayMember = "CreateDateGMT";
        //}
        #endregion

        #region ================== Sự kiện ==================
        private void btnThem_Click(object sender, EventArgs e)
        {
            FrmThongTinHangHoa frm = new FrmThongTinHangHoa(null);
            frm.ShowDialog();
            LoadData();
        }
        #endregion

        private void dtgvDanhSachHangHoa_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dtgvDanhSachHangHoa["STT", e.RowIndex].Value = (e.RowIndex < 9 ? "0" : "") + (e.RowIndex + 1);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            EHangHoa eHangHoa = new EHangHoa();
            eHangHoa.EditID = Session.MaNhanVien;
            
        }

        private void dtgvDanhSachHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow= e.RowIndex;
            if (indexRow>-1)
            {
                DataRow row = dtAllHangHoa.Rows[indexRow];
                eHangHoa.MaVach = row["MaVach"].ToString();
                eHangHoa.TenHang = row["TenHang"].ToString();
                eHangHoa.MaHang = row["MaHang"].ToString();
                eHangHoa.MaDVT = int.Parse(row["MaDVT"].ToString());
                eHangHoa.MaKho = 1;
                eHangHoa.MaNhomHangHoa = int.Parse(row["MaNhomHangHoa"].ToString());
            }
            
        }
    }
}
