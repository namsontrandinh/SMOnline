using SalesManagement.DAL;
using SalesManagement.ENTITY.User;

using System.Collections.Generic;

namespace SalesManagement.BLL
{
    public class BUser
    {
        /// <summary>
        /// Hiển thị tất cả người dùng
        /// </summary>
        public static List<EUser> GetAll()
        {
            return UserDAO.GetAll();
        }

        /// <summary>
        /// Truy vấn thông tin tài khoản
        /// </summary>
        public static bool IsExistsUser(EUser user)
        {
            return UserDAO.IsExistsUser(user);
        }

        /// <summary>
        /// Thêm mới người dùng
        /// </summary>
        public static void Insert(EUser user, ref byte errorUser)
        {
            UserDAO.Insert(user, ref errorUser);
        }

        /// <summary>
        /// Cập nhật người dùng
        /// </summary>
        public static void Update(EUser user)
        {
            UserDAO.Update(user);
        }

        /// <summary>
        /// Xóa người dùng
        /// </summary>
        public static void Delete(EUser user)
        {
            UserDAO.Delete(user);
        }
    }
}
