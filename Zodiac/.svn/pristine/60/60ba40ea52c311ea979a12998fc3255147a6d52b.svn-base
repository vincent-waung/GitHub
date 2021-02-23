using Common;
using Models;
using MvcZodiac.Areas;
using MvcZodiac.Areas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Common.Attributes;

namespace MvcZodiac.Controllers
{
    public class LoginController : BaseController
    {
        //
        // GET: /Login/
        [HttpGet]
        [Skip]
        public ActionResult Index()
        {
            return View();
        }

 
        /// <summary>
        /// 登录系统
        /// </summary>
        /// <returns></returns>
        [HttpPost] 
        [Skip]
        public ActionResult LoginIn()
        {
            ActionResult ar = null;

            Action onAction = () =>
            {
                if (Request.Form["cname"] == null || Request.Form["cpwd"] == null  )
                {
                    ar = PackagingAjaxmsg(AjaxStatu.err, "登录名|密码|验证码没有传入后台！");
                }
                string cname = Request.Form["cname"];
                string cpwd = Request.Form["cpwd"];
                //string cyzm = Request.Form["cyzm"];
                AjaxMsgModel amm = Model_Sys_UserInfo.LoginIn(cname, cpwd);
                ar = PackagingAjaxmsg(amm);
            };
            SaveToAction(this, onAction);
            return ar;
        }

        /// <summary>
        /// 退出系统
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [AjaxRequest]
        public ActionResult LoginOut()
        { 
            //清除Sesson
            Session.Abandon();
            //Session.Clear();
            oc.CurrentUser = null;

            return PackagingAjaxmsg(AjaxStatu.ok, "退出系统成功！", null, "/Login/Index");
        }
      

        #region 验证码的实现
        /// <summary>
        /// 验证码的实现
        /// </summary>
        /// <returns>验证码图片</returns>
        public ActionResult CheckCode()
        {           
            //得到验证码的图片
            byte[] bytes = Model_Sys_UserInfo.GenerateValidateCode();
            //最后将验证码返回
            return File(bytes, @"image/jpeg");
        }
        #endregion

    }
}
