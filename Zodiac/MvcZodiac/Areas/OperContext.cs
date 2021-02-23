using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IBLL;
using DI;
using System.Runtime.Remoting.Messaging;
using System.Web.Mvc;
using Models;
using Common;
using System.Web.SessionState;
namespace MvcZodiac.Areas
{
    public class OperContext
    {
        #region 名称常量
        /// <summary>
        /// 验证码的Session名称
        /// </summary>
        public  const string Admin_ValidateCode = "ValidateCode";
        /// <summary>
        /// 当前用户信息
        /// </summary>
        public  const string Admin_User = "Admin_User";
        /// <summary>
        /// 保存当前用户信息的CookieID
        /// </summary>
        public const string Admin_Cookie_UserLoginName = "Cookie_Login_Name";
        /// <summary>
        /// cookie所存储的位置
        /// </summary>
        public const string Admin_Cookie_Path = "/admin/";
        /// <summary>
        /// 保存当前用户权限信息
        /// </summary>
        public const string Admin_PermissionKey = "APermission";

        public const string Vendor_Name_Cookie = "CookieVendorName";
        #endregion

        #region 使用线程优化业务层仓储
        public IBLLSession BllSession;

        private OperContext()
        {
            BllSession = SpringHelper.GetObject<IBLLSession>("BLLSession");

        }

        public static OperContext CurrentContext
        {
            get
            {
                OperContext opContext = CallContext.GetData(typeof(OperContext).Name) as OperContext;
                if (opContext == null)
                {
                    opContext = new OperContext();
                    CallContext.SetData(typeof(OperContext).Name,opContext);
                
                }
                return opContext;
            }
        }
        #endregion

        #region 封装HTTP对象
        #region Http上下文
        /// <summary>
        /// Http上下文
        /// </summary>
        HttpContext ContextHttp
        {
            get
            {
                return HttpContext.Current;
            }
        }
        #endregion

        #region Response对象
        public HttpResponse Response
        {
            get
            {
                return ContextHttp.Response;
            }
        }
        #endregion

        #region Request对象
        public HttpRequest Request
        {
            get
            {
                return ContextHttp.Request;
            }
        }
        #endregion


        #region Session对象
        public HttpSessionState Session
        {
            get
            {
                return ContextHttp.Session;
            }
        }

        #endregion
        #endregion

        #region 当前用户验证码
        /// <summary>
        /// 当前用户验证码
        /// </summary>
        public string CurrentUserVcode
        {
            get {

                return Session[Admin_ValidateCode] as string;
            }

            set
            {
                Session[Admin_ValidateCode] = value;
            }
        }
        #endregion

        #region 当前用户
        /// <summary>
        /// 当前用户
        /// </summary>
        public Sys_UserInfo CurrentUser
        {
            get
            {

                return Session[Admin_User] as Sys_UserInfo;
            }

            set
            {
                Session[Admin_User] = value;
            }
        }
        #endregion

        #region 当前用户权限
        /// <summary>
        /// 当前用户权限
        /// </summary>
        public List<Sys_Permission> UserPermission
        {
            get
            {

                return Session[Admin_PermissionKey] as List<Sys_Permission>;
            }

            set
            {
                Session[Admin_PermissionKey] = value;
            }
        }
        #endregion

        #region 保存当前登录用户的用户名       
        HttpCookie cookie;
        /// <summary>
        /// 保存当前登录用户的用户名
        /// </summary>
        public string CurrentLoginName
        {
            set
            {
                value = Common.SecurityHelper.Encrypt(value.ToString());
                cookie = new HttpCookie(Admin_Cookie_UserLoginName, value);
                cookie.Expires = DateTime.Now.AddDays(1);
                cookie.Path = Admin_Cookie_Path;
                Response.Cookies.Add(cookie);
            }
            get
            {
                if (Request.Cookies[Admin_Cookie_UserLoginName] == null)
                {
                    return "";
                }
                else
                {
                    string strLoginName = Request.Cookies[Admin_Cookie_UserLoginName].Value;
                    strLoginName = Common.SecurityHelper.DeEncrypt(strLoginName);
                    return strLoginName;
                }
            }
        } 
        #endregion


        #region 保存登录用户工厂名称
        
     
        HttpCookie VendorNamecookie;
        public string CurrentVendorName
        {
            set
            {
                value = value.ToString();
                VendorNamecookie = new HttpCookie(Vendor_Name_Cookie);
                VendorNamecookie.Values["VendorName"] = value;
                VendorNamecookie.Expires = DateTime.Now.Add(new TimeSpan(168, 0, 0));


                //获取当前客户端cookie 如果存在则修改当前的cookie
                HttpCookie currentCookie = Request.Cookies[Vendor_Name_Cookie];

                if (currentCookie != null)
                {


                    currentCookie.Values["VendorName"] = value;
                    currentCookie.Expires = DateTime.Now.Add(new TimeSpan(168, 0, 0));
                    Response.AppendCookie(currentCookie);
                }
                else { Response.Cookies.Add(VendorNamecookie); }

            }
            get
            {
                if (Request.Cookies[Vendor_Name_Cookie] == null)
                {
                    return "";
                }
                else
                {
                    string strVendorName = Request.Cookies[Vendor_Name_Cookie].Values["VendorName"];

                    return strVendorName;
                }
            }
        }


        #endregion
    }
}