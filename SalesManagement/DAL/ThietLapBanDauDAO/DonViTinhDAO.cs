using SalesManagement.ENTITY.ThietLapBanDauEntity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace SalesManagement.DAL.ThietLapBanDauDAO
{
    public class DonViTinhDAO
    {
        /// <summary>
        /// Hiển thị danh sách đơn vị tính
        /// </summary>
        public static DataTable GetAll()
        {
            return DataAccess.executeDataTable("DonViTinh_GetALL", CommandType.StoredProcedure, null);
        }
        
        /// <summary>
        /// Thêm đơn vị tính
        /// </summary>
        public static void Insert(EDonViTinh eDonViTinh, ref byte errorDVT)
        {
            try
            {
                SqlParameter prErrorDVT = new SqlParameter("@ErrorDVT", errorDVT);
                prErrorDVT.Direction = ParameterDirection.Output;

                SqlParameter[] para = {
                                        new SqlParameter("@MaDVT", eDonViTinh.MaDVT),
                                        new SqlParameter("@DonViTinh", eDonViTinh.DonViTinh),
                                        prErrorDVT
                                      };
                DataAccess.excuteNonQuery("DonViTinh_Add", CommandType.StoredProcedure, para);

                errorDVT = Convert.ToByte(prErrorDVT.Value);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Cập nhật đơn vị tính
        /// </summary>
        public static void Update(EDonViTinh eDonViTinh)
        {
            try
            {
                SqlParameter[] para = {
                                      new SqlParameter("@MaDVT", eDonViTinh.MaDVT),
                                      new SqlParameter("@DonViTinh", eDonViTinh.DonViTinh) 
                                      };
                DataAccess.excuteNonQuery("DonViTinh_Update", CommandType.StoredProcedure, para);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
    }
}
