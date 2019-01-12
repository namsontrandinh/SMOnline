using System.Security.Cryptography;
using System.Text;

namespace SalesManagement.ENTITY.Utility
{
    public class SecurityPassword
    {
        public static string GetSHA1Password(string strInput)
        {
            string strResult = string.Empty;
            using (SHA1 sha1Hash = SHA1.Create())
            {
                strResult = GetSha1Hash(sha1Hash, strInput);
            }
            return strResult;
        }

        public static string GetSha1Hash(SHA1 sha1Hash, string input)
        {
            byte[] data = sha1Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
    }
}
