
using SalesManagement.DAL.ThietLapBanDauDAO;
using SalesManagement.ENTITY.ThietLapBanDauEntity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SalesManagement.BLL.ThietLapBanDauBLL
{
    public class BDonViTinh
    {
        /// <summary>
        /// Hiển thị danh sách đơn vị tính
        /// </summary>
        public static DataTable GetAll()
        {
            return DonViTinhDAO.GetAll();
        }
        
        /// <summary>
        /// Thêm đơn vị tính
        /// </summary>
        public static void Insert(EDonViTinh eDonViTinh, ref byte errorDVT)
        {
            DonViTinhDAO.Insert(eDonViTinh, ref errorDVT);
        }

        /// <summary>
        /// Cập nhật đơn vị tính
        /// </summary>
        public static void Update(EDonViTinh eDonViTinh)
        {
            DonViTinhDAO.Update(eDonViTinh);
        }
    }
}
