using SalesManagement.ENTITY.User;
using SalesManagement.ENTITY.Utility;
using SalesManagement.ENTITY.DelegateEvent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SalesManagement.BLL;
using SalesManagement.PUBLICCODE;
using DevComponents.DotNetBar;

namespace SalesManagement.FORM.HeThong
{
    public partial class FrmLogIn : Form
    {
        #region ================= Khởi tạo =================
        public event SuccessLogIn eventSuccessLogIn;
        public event FormClose eventFormClose;

        public FrmLogIn()
        {
            InitializeComponent();
            txtTaiKhoan.Text = "thao";
            txtMatKhau.Text = "thao";
        }

        protected override void OnClosed(EventArgs e)
        {
            if (eventFormClose != null)
                eventFormClose(null);

            base.OnClosed(e);
        }
        #endregion

        #region ================= Chức năng =================
        private void CheckLogin()
        {
            EUser user = new EUser();
            user.UserName = txtTaiKhoan.Text.Trim();

            string strPassword = txtMatKhau.Text.Trim();
            //user.Password = SecurityPassword.GetSHA1Password(strPassword);
            user.Password = strPassword;
            if (user.UserName == "")
            {
                MessageBox.Show("Tài khoản không được để trống");
                return;
            }
            if (user.Password == "")
            {
                MessageBox.Show("Mật khẩu không được để trống");
                return;
            }
            try
            {
                if (BUser.IsExistsUser(user))
                {
                    Session.UserName = user.UserName;
                    Session.MaNhanVien = user.MaNhanVien;
                    if (eventSuccessLogIn != null)
                        eventSuccessLogIn(null);
                    this.Close();
                }
                else
                    //MessageBox.Show("Tên đăng nhập hoặc tài khoản không chính xác");
                    MessageBoxEx.Show("Tên đăng nhập hoặc tài khoản không chính xác");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối đến Server:" + ex.ToString());
            }
        }
        #endregion

        #region ================= Sự kiện =================
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            CheckLogin();
        }
        #endregion
    }
}
