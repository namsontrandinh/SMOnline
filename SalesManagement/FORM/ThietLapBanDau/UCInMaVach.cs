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
    public partial class UCInMaVach : UserControl
    {
        #region ======================== Khởi tạo ======================== 
        DataTable data = new DataTable();

        public UCInMaVach()
        {
            InitializeComponent();
            DesignTable();
        }
        public UCInMaVach(string MaHang)
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
            rp.SetDataSource( data);
            crystalReportViewer1.ReportSource = rp;
            crystalReportViewer1.Refresh();
            crystalReportViewer1.Zoom(100);
        }
        #endregion

        private void txtMaHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                string maHang = txtMaHang.Text;
                LoadReport(maHang);
            }
        }

        
        #region ======================== Sự kiện ========================
       
        #endregion

    }
}
