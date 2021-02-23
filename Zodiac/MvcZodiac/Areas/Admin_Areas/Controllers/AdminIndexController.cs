using Common.Attributes;
using MvcZodiac.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcZodiac.Areas.Admin_Areas.Controllers
{
    /// <summary>
    /// 管理端后台首页控件器
    /// </summary>
    public class AdminIndexController : BaseController
    {
        //
        // GET: /Admin/AdminIndex/
        #region 管理端首页
        [Skip]
        [HttpGet]
        public ActionResult Index()
        {

            ViewData["cUser"] = oc.CurrentUser;
            if (oc.CurrentUser != null)
            {
                ViewBag.uLoginName = oc.CurrentUser.uLoginName;
                ViewBag.uId = oc.CurrentUser.uId;
            }
            return View();
        } 
        #endregion

        #region 显示时钟信息
        /// <summary>
        /// 显示时钟信息
        /// </summary>
        /// <returns></returns>
        [Skip]
        public ActionResult ShowClock()
        {
            return View();
        } 
        #endregion

        #region 显示企业视频
        /// <summary>
        /// 显示企业视频
        /// </summary>
        /// <returns></returns>
        [Skip]
        public ActionResult ShowCompany()
        {
            return View();
        }
        #endregion


        #region 显示报表信息
        /// <summary>
        /// 显示报表信息
        /// </summary>
        /// <returns></returns>
        [Skip]
        public ActionResult ShowReports()
        {
            return View();
        }
        #endregion


        #region 修改密码
        /// <summary>
        /// 显示修改密码窗体
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [AjaxRequest]
        [Description("显示修改密码窗体")]    
        public ActionResult View_ModifyPwd()
        {
          
            return View();
        }

        #endregion

    }
}
