using Common;
using Common.Attributes;
using Models;
using MvcZodiac.Areas.Models;
using MvcZodiac.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcZodiac.Areas.Admin_Areas.Controllers
{
    public class Sys_UserVipPermissionController : BaseController
    {
        //
        // GET: /Admin_Areas/Sys_UserVipPermission/
        #region 用户特权管理首页
        [Skip]
        [HttpGet]
        [Description("用户特权管理首页")]
        public ActionResult VipIndex()
        {
            return View();
        } 
        #endregion

        #region 根据用户编号得到特权信息
        [AjaxRequest]
        [HttpPost]
        [Description("根据用户编号得到特权信息")]
        public ActionResult GetPermissionInfoByCondition()
        {
            int usrid = 0;
            if (Request.QueryString["userId"] != null && Request.QueryString["userId"].Trim() != "")
            {
                usrid = int.Parse(Request.QueryString["userId"]);
            }
            dynamic dgVipInfo = Model_Sys_UserVipPermission.GetUserVipPermission(usrid);
            return Content(DataHelper.ObjToJson(dgVipInfo));
        } 
        #endregion

        #region 用户特权设置页面
        [AjaxRequest]
        [HttpGet]
        [Description("用户特权设置页面")]
        public ActionResult ShowVipPerSetView()
        {
            return View();
        }
        #endregion

        #region 配置用户特权
        [AjaxRequest]
        [HttpPost]
        [Description("配置用户特权")]
        public ActionResult SetUserVips()
        {
            string vipIds = string.Empty;
            if (Request.Form["vipIds"] != null)
            {
                vipIds = Request.Form["vipIds"];
            }
            int uId = 0;
            if (Request.Form["uId"] != null)
            {
                uId = int.Parse(Request.Form["uId"]);
            }
            List<Sys_UserVipPermission> usrVips = new List<Sys_UserVipPermission>();
            if (vipIds.Trim() != "")
            {
                string[] vIds = vipIds.Split(',');
                foreach (string v in vIds)
                {
                    Sys_UserVipPermission usrVip = new Sys_UserVipPermission
                    {
                        vipUserId = uId,
                        vipAddTime = DateTime.Now,
                        vipIsDel = false,
                        vipPermission = int.Parse(v),
                        vipRemark =string.Empty
                    };

                    usrVips.Add(usrVip);
                }
            }
            AjaxMsgModel amm = Model_Sys_UserVipPermission.SetUserVips(usrVips, uId);
            return PackagingAjaxmsg(amm);
        }
        #endregion

    }
}
