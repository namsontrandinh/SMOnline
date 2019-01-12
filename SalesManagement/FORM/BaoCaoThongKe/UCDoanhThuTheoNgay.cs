using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SalesManagement.ENTITY.Utility;
using SalesManagement.BLL.ThietLapBanDauBLL;

namespace SalesManagement.FORM.BaoCaoThongKe
{
    public partial class UCDoanhThuTheoNgay : UserControl
    {
        #region==================khởi tạo=================

        public UCDoanhThuTheoNgay()
        {
            InitializeComponent();
        }
        DataTable data = new DataTable();
        int SoHoaDon = 0;
        int TongDoanhThu = 0;
        #endregion =======================================

        #region ================== chức năng==================

        private void dtgvHoaDon_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dtgvHoaDon["STT", e.RowIndex].Value = (e.RowIndex < 9 ? "0" : "") + (e.RowIndex + 1);
        }

        #endregion ===========================================

        #region ======================== sự kiện =====================

        private void dtpNgayBan_TextChanged(object sender, EventArgs e)
        {
            string ngayBan = dtpNgayBan.Text;
            DateTime time = UnixTime.GetTimeUnix(1538835973);
            //1539993600 1540079999
            int fromTime= UnixTime.GetUnixTime(Convert.ToDateTime(ngayBan+" 00:00:00 AM"));
            int toTime =UnixTime.GetUnixTime(Convert.ToDateTime(ngayBan+" 23:59:59 PM"));
      

            data = BPhieuBanHang.GetSumDay(fromTime, toTime);
            dtgvHoaDon.DataSource = data;
            SoHoaDon = data.Rows.Count;
            for (int i = 0; i < SoHoaDon; i++)
            {
                TongDoanhThu = TongDoanhThu + int.Parse(data.Rows[i]["TongTien"].ToString());
            }
            txtTongDoanhThu.Text = TongDoanhThu.ToString();
            txtSoHoaDon.Text = SoHoaDon.ToString();
        }
        #endregion ===================================================

       
        

    }
}
