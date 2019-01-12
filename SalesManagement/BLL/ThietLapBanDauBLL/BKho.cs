using SalesManagement.DAL.ThietLapBanDauDAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SalesManagement.BLL.ThietLapBanDauBLL
{
    public class BKho
    {
        /// <summary>
        /// Hiển thị danh sách kho
        /// </summary>
        public static DataTable GetAll()
        {
            return KhoDAO.GetAll();
        }
        /// <summary>
        ///thêm mới kho
        /// </summary>
        public static void Insert(string Kho)
        {
            KhoDAO.Insert(Kho);
        }
        /// <summary>
        ///xóa kho
        /// </summary>
        public static void Delete(int maKho)
        {
            KhoDAO.Delete(maKho);
        }
    }
}
