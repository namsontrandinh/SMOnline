using SalesManagement.ENTITY.ThietLapBanDauEntity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace SalesManagement.DAL.ThietLapBanDauDAO
{
   public class NhomKhachHangDAO
    {
        /// <summary>
        /// Hiển thị danh sách nhosm khách hàng
        /// </summary>
        public static DataTable GetAll()
        {
            return DataAccess.executeDataTable("NhomKhachHang_GetAll", CommandType.StoredProcedure, null);
        }
       
        /// <summary>
        /// Thêm nhóm khách hàng
        /// </summary>
        public static void Insert(ENhomKhachHang eNhomKhachHang)
        {
            try
            {
                SqlParameter[] para = {
                                        new SqlParameter("@MoTa", eNhomKhachHang.MoTa),
                                        new SqlParameter("@PhanTramChietKhau", eNhomKhachHang.PhamTramChietKhau),
                                        new SqlParameter("@SoDiem", eNhomKhachHang.SoDiem),
                                        new SqlParameter("@TenNhomKhach", eNhomKhachHang.TenNhomKhach),
                                        new SqlParameter("@TienHang", eNhomKhachHang.TienHang)

                                      };
                DataAccess.excuteNonQuery("NhomKhachHang_Add", CommandType.StoredProcedure, para);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// cập nhật nhóm khách hàng
        /// </summary>
        public static void Update(ENhomKhachHang eNhomKhachHang)
        {
            try
            {
                SqlParameter[] para = {
                                        new SqlParameter("@MoTa", eNhomKhachHang.MoTa),
                                        new SqlParameter("@NhomKhachHang", eNhomKhachHang.NhomKhachHang),
                                        new SqlParameter("@PhanTramChietKhau", eNhomKhachHang.PhamTramChietKhau),
                                        new SqlParameter("@SoDiem", eNhomKhachHang.SoDiem),
                                        new SqlParameter("@TenNhomKhach", eNhomKhachHang.TenNhomKhach),
                                        new SqlParameter("@TienHang", eNhomKhachHang.TienHang)

                                      };
                DataAccess.excuteNonQuery("NhomKhachHang_Update", CommandType.StoredProcedure, para);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// xóa nhóm khách hàng
        /// </summary>
        public static void Delete(string NhomKhachHang)
        {
            try
            {
                SqlParameter[] para = { new SqlParameter("@NhomKhachHang", NhomKhachHang)  };
                DataAccess.excuteNonQuery("NhomKhachHang_Delete", CommandType.StoredProcedure, para);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
