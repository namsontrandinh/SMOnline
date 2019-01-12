using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace SalesManagement.FORM.ThietLapBanDau
{
    public partial class UCDanhSachNhomKhach : UserControl
    {
        public UCDanhSachNhomKhach()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FrmDanhSachNhomKhachHang frm = new FrmDanhSachNhomKhachHang();
            frm.ShowDialog();
        }
    }
}
