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
  
    public class AdminLoginController : BaseController
    {

        #region 登录
        /// <summary>
        /// 显示登录视图(学习版)
        /// </summary>
        /// <returns></returns>        
        [HttpGet]
        [Skip]
        public ActionResult LoginStudy()
        {
            return View();
        }
        /// <summary>
        /// 显示登录视图(企业版)
        /// </summary>
        /// <returns></returns>        
        [HttpGet]
        [Skip]
        public ActionResult Login()
        {
            return View();
        }


        [HttpGet]
        [Skip]
        public ActionResult LoginWMS()
        {
            return View();
        }

        [HttpGet]
        [Skip]
        public ActionResult LoginWMS2()
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
                if (Request.Form["cname"] == null || Request.Form["cpwd"] == null || Request.Form["cyzm"] == null)
                {
                    ar = PackagingAjaxmsg(AjaxStatu.err, "登录名|密码|验证码没有传入后台！");
                }
                string cname = Request.Form["cname"];
                string cpwd = Request.Form["cpwd"];
                string cyzm = Request.Form["cyzm"];
                AjaxMsgModel amm = Model_Sys_UserInfo.LoginIn(cname, cpwd, cyzm);
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

            return PackagingAjaxmsg(AjaxStatu.ok, "退出系统成功！", null, "/AdminLogin/Login");
        }
        #endregion

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

        #region 筛选用户信息
        /// <summary>
        /// 得到适合下拉框的用户信息
        /// </summary>
        /// <returns></returns>
        public ActionResult GetUsersForComboBox()
        {

            string q = null;
            if (Request.Form["q"] != null)
            {
                q = Request.Form["q"];
            }

            dynamic dgUserInfo = Model_Sys_UserInfo.GetUsersByLoginName(0, 0, q, null, null, true);

            return Content(DataHelper.ObjToJson(dgUserInfo));
        }
        /// <summary>
        /// 得到适合grid的用户信息
        /// </summary>
        /// <returns></returns>
        public ActionResult GetUsers()
        {
            if (Request.Form["page"] == null || Request.Form["rows"] == null )
            {
                return PackagingAjaxmsg(AjaxStatu.err, "当前页|每页的条数|没有传入后台！");
            }
            int page= int.Parse(Request.Form["page"]);
            int rows=int.Parse(Request.Form["rows"]);
           
            string q = null;
            if(Request.Form["q"] != null)
            {
                q = Request.Form["q"]; 
            }

            string sort = null;
            if (Request.Form["sort"] != null)
            {
                sort = Request.Form["sort"];
            }

            string order = null;
            if (Request.Form["order"] != null)
            {
                order = Request.Form["order"];
            }


            dynamic dgUserInfo = Model_Sys_UserInfo.GetUsersByLoginName(page, rows,q
                ,sort,order);

            return Content(DataHelper.ObjToJson(dgUserInfo));
               
        }
        #endregion

    }
}
