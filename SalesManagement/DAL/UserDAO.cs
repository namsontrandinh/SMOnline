using SalesManagement.ENTITY.User;
using SalesManagement.PUBLICCODE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SalesManagement.DAL
{
    public class UserDAO
    {
        /// <summary>
        /// Hiển thị tất cả người dùng
        /// </summary>
        public static List<EUser> GetAll()
        {
            DataTable dt = DataAccess.excuteDataTableList("[User_GetAll]", CommandType.StoredProcedure);

            List<EUser> userlst = new List<EUser>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                EUser user = new EUser();
                user.MaNhanVien = dt.Rows[i]["MaNhanVien"].ToString();
                user.UserName = dt.Rows[i]["UserName"].ToString();
                user.Password = dt.Rows[i]["Password"].ToString();
                userlst.Add(user);
            }
            return userlst;
        }

        /// <summary>
        /// Truy vấn thông tin tài khoản
        /// </summary>
        public static bool IsExistsUser(EUser user)
        {
            try
            {
                SqlDataReader reader = SQLHelper.ExecuteReader(Session.strCon, "[User_CheckLogin]", user.UserName, user.Password);
                if (reader.Read())
                {
                    user.MaNhanVien = reader["MaNhanVien"].ToString();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return false;
        }

        /// <summary>
        /// Thêm mới người dùng
        /// </summary>
        public static void Insert(EUser user, ref byte errorUser)
        {
            try
            {
                SqlParameter prErrorUser = new SqlParameter("@ErrorUser", errorUser);
                prErrorUser.Direction = ParameterDirection.Output;

                SqlParameter[] para =
                {
                    new SqlParameter("@MaNhanVien", user.MaNhanVien),
                    new SqlParameter("@UserName", user.UserName),
                    new SqlParameter("@Password", user.Password),
                    prErrorUser
                };
                DataAccess.excuteNonQuery("[User_Add]", CommandType.StoredProcedure, para);

                errorUser = Convert.ToByte(prErrorUser.Value);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Cập nhật người dùng
        /// </summary>
        public static void Update(EUser user)
        {
            SqlParameter[] para =
            {
                new SqlParameter("@MaNhanVien", user.MaNhanVien),
                new SqlParameter("@Password", user.Password)
            };
            DataAccess.excuteNonQuery("[User_Update]", CommandType.StoredProcedure, para);
        }

        /// <summary>
        /// Xoá người dùng
        /// </summary>
        public static void Delete(EUser user)
        {
            SqlParameter[] para= {
                new SqlParameter("@MaNhanVien", user.MaNhanVien)
            };
            DataAccess.excuteNonQuery("[User_Delete]", CommandType.StoredProcedure, para);
        }
    }
}
