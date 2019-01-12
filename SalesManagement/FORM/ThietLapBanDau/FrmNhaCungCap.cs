using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SalesManagement.ENTITY.ThietLapBanDauEntity;
using SalesManagement.ENTITY.Utility;
using SalesManagement.PUBLICCODE;
using SalesManagement.BLL.ThietLapBanDauBLL;

namespace SalesManagement.FORM.ThietLapBanDau
{
    public partial class FrmNhaCungCap : Form
    {
        #region ===================== Khởi tạo ==========================
        ENhaCungCap eNhaCungCap = new ENhaCungCap();
        public FrmNhaCungCap()
        {
            InitializeComponent();
            txtTenNhaCC.Focus();
        }
        #endregion ======================================================
        #region ========================= Chức năng =====================

        private void FrmNhaCungCap_Load(object sender, EventArgs e)
        {

        }
        private  bool CheckValue()
        {
            bool result=true;
            string strError=string.Empty;
           if ( txtTenNhaCC.Text=="")
	        {
        		 strError+="\n Tên nhà cung cấp không được để trống";
	        }
            if (txtNguoiLienHe.Text=="")
	        {
        	    strError+="\n Người liên hệ không được để trống";	 
	        }
            if (txtDiaChi.Text=="")
	        {
        	    strError+="\n Địa chỉ không được để trống";	 
	        }
            if (txtEmail.Text=="")
	        {
        		strError+="\n Email không được để trống"; 
	        }
            if (txtSDT.Text=="")
	        {
        	    strError+="\n Số điện thoại bị trống";	 
	        }
            if (string.IsNullOrEmpty(strError)==false)
	        {
        	   MessageBox.Show(strError,"Lỗi: ",MessageBoxButtons.OK,MessageBoxIcon.Error);
                result=false;
	        }
            return result;
        }
        private void SaveData()
        {
            eNhaCungCap.CreateDate = UnixTime.GetUnixTime(Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy")));
            eNhaCungCap.CreateID = Session.MaNhanVien;
            eNhaCungCap.DiaChi = txtDiaChi.Text;
            eNhaCungCap.Email = txtEmail.Text;
            eNhaCungCap.GhiChu = txtGhiChu.Text;
            eNhaCungCap.NgayHopTac =Convert.ToDateTime( dtpkNgayHopTac.Text);
            eNhaCungCap.NguoiLienHe = txtNguoiLienHe.Text;
            eNhaCungCap.NhaCungCap = txtTenNhaCC.Text;
            eNhaCungCap.SDT = txtSDT.Text;
            try
            {
                BNhaCungCap.Insert(eNhaCungCap);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
            
        }
        #endregion ======================================================
        #region ========================== Sự kiện =======================
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
        #endregion =======================================================
    }
}
