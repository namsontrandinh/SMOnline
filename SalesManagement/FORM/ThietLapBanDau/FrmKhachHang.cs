using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SalesManagement.BLL.ThietLapBanDauBLL;
using SalesManagement.ENTITY.ThietLapBanDauEntity;
using SalesManagement.ENTITY.Utility;
using SalesManagement.PUBLICCODE;

namespace SalesManagement.FORM.ThietLapBanDau
{
    public partial class FrmKhachHang : Form
    {
        #region ================== Khởi tạo ===========================
        EKhachHang eKhachHang = new EKhachHang();
        public FrmKhachHang()
        {
            InitializeComponent();
            txtMaKhach.Focus();
        }

        #endregion =====================================================

        #region ====================== Chức năng ========================
        private void SaveData()
        {
            eKhachHang.CMT=txtCMND.Text;
            eKhachHang.CreateDate=UnixTime.GetUnixTime(DateTime.Now);
            eKhachHang.CreateID=Session.MaNhanVien;
            eKhachHang.MaKhachHang=txtMaKhach.Text;
            eKhachHang.NgaySinh=UnixTime.GetUnixTime(Convert.ToDateTime( dtpkNgaySinh.Text));
            eKhachHang.TenKhachHang=txtTenKhach.Text;
            eKhachHang.SDT=txtSDT.Text;
            eKhachHang.ThongTinThem = txtGhiChu.Text;
            eKhachHang.DiaChi = txtDiaChi.Text;
            try
            {
                BKhachHang.Insert_V1(eKhachHang);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
            
        }
        private bool CheckValue()
        {
            bool result = true;
            string strError = string.Empty;
            if (txtMaKhach.Text=="")
            {
                strError+="\n Mã khách không được để trống!";
            }
            if (txtCMND.Text=="")
            {
                strError += "\n Số CMT không được để trống!";
            }
            if (txtTenKhach.Text=="")
            {
                strError += "\n Tên khách không được để trống";
            }
            if (txtSDT.Text=="")
            {
                strError += "\n Số điện thoại không được để trống";
            }
            if (dtpkNgaySinh.Text=="")
            {
                strError += "\n Ngày sinh không được để trống";
            }
            if (string.IsNullOrEmpty(strError)==false)
            {
                MessageBox.Show(strError,"Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                result=false;
            }
            return result;
        }
        #endregion ======================================================

        #region ======================= Sự kiện ==========================
        #endregion =======================================================
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckValue()==true)
                {
                    SaveData();
                    MessageBox.Show("Thêm thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.ToString());
            }
        }
    }
}
