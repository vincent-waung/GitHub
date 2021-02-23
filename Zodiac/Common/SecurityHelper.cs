using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
namespace Common
{
    /// <summary>
    /// 加密和解密
    /// </summary>
    public class SecurityHelper
    {
        public static string Md5EncryptToString(string value)
        {
            MD5 md5Hash = MD5.Create();
            string source = value;
            string hash = GetMd5Hash(md5Hash, source);
            return hash;
        }

        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        #region 加密
        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="userInfo">用户信息</param>
        /// <returns>加密字符串</returns>
        public static string Encrypt(string userInfo)
        {
            //第一：将用户数据存入票据对象
            FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1,"十二",DateTime.Now,DateTime.Now.AddMinutes(10),true,userInfo);

            //第二:将票据对象加密成字符串
            string security= FormsAuthentication.Encrypt(ticket);
            return security;
        }
        #endregion

        #region 解密
        /// <summary>
        /// 解密
        /// </summary>
        /// <param name="encryptStr">加密字符串</param>
        /// <returns>用户数据</returns>
        public static string DeEncrypt(string encryptStr)
        {

            //将加密字符串解释成票据对象
            FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(encryptStr);
            return ticket.UserData;
        }
        #endregion
    }
}
