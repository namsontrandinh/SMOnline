using SalesManagement.BLL.ThietLapBanDau;
using SalesManagement.ENTITY.ThietLapBanDau;
using System.Data;
using System;
using System.Windows.Forms;
using SalesManagement.DAL;
using SalesManagement.BLL.ThietLapBanDauBLL;

namespace SalesManagement.FORM.ThietLapBanDau
{
    public partial class FrmInMaVach : Form
    {
        #region ======================== Khởi tạo ======================== 
        DataTable data = new DataTable();

        public FrmInMaVach()
        {
            InitializeComponent();
            DesignTable();
        }
        public FrmInMaVach(string MaHang)
        {
            InitializeComponent();
            DesignTable();
            LoadReport(MaHang);
        }
       
        #endregion

        #region ======================== Chức năng ========================
        private void DesignTable()
        {
            data.Columns.Add("MaHang");
            data.Columns.Add("TenHang");
            data.Columns.Add("GiaBan");
        }
        private void LoadReport(string MaHang)
        {
            data = BHangHoa.GetToPrintBarcode(MaHang);
            rpInMaVach rp = new rpInMaVach();
            rp.SetDataSource ( data);
            crystalReportViewer1.ReportSource = rp;
            crystalReportViewer1.Refresh();
            crystalReportViewer1.Zoom(100);
        }
        #endregion

        
        #region ======================== Sự kiện ========================
       
        #endregion

        
    }
}
