using Common.Attributes;
using MvcZodiac.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using MvcZodiac.Areas.Models;
using Common;
namespace MvcZodiac.Areas.Admin_Areas.Controllers
{
    public class Sys_UserSettingController : BaseController
    {
        //
        // GET: /Admin_Areas/Sys_UserSetting/

        public ActionResult Index()
        {
            return View();
        }

        #region 修改用户配置
        [AjaxRequest]
        [HttpPost]
        [Skip]
        [Description("修改用户配置")]
        public  ActionResult EditUserSetting()
        {
            string SettingCode = string.Empty;
            if (Request.Form["SettingCode"] != null)
            {
                SettingCode = Request.Form["SettingCode"];
            }

            string SettingValue = string.Empty;
            if (Request.Form["SettingValue"] != null)
            {
                SettingValue = Request.Form["SettingValue"];
            }

            Sys_UserSetting userSetting = new Sys_UserSetting
            {
                UserCode = oc.CurrentUser.uLoginName,
                SettingCode = SettingCode,
                SettingValue = SettingValue
            };
            AjaxMsgModel amm = Model_Sys_UserSetting.EditUserSetting(userSetting);
            return PackagingAjaxmsg(amm);
           
        }
        #endregion

        #region 根据条件查询用户的一个配置信息
        [AjaxRequest]
        [HttpPost]
        [Skip]
        [Description("获取用户配置")]
        public ActionResult GetOneUserSetting()
        {
            string SettingCode = string.Empty;
            if (Request.Form["SettingCode"] != null)
            {
                SettingCode = Request.Form["SettingCode"];
            }
            Sys_UserSetting userSetting = new Sys_UserSetting 
            {
               UserCode = oc.CurrentUser.uLoginName,
               SettingCode = SettingCode
            };

            var us = Model_Sys_UserSetting.GetOneUserSetting(userSetting);
            return Content(DataHelper.ObjToJson(us));
        }
        #endregion
    }
}
