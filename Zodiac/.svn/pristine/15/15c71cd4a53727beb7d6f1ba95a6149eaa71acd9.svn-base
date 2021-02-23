using Common;
using Common.Attributes;
using MvcZodiac.Areas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using MvcZodiac.Controllers;
namespace MvcZodiac.Areas.Admin_Areas.Controllers
{
    public class Sys_UserRoleController : BaseController
    {
        //
        // GET: /Admin_Areas/Sys_UserRole/
        #region 用户角色管理
        [Skip]
        [HttpGet]
        [Description("用户角色管理")]
        public ActionResult UserRoleIndex()
        {
            return View();
        }        
        #endregion

        #region 用户角色设置页面
        [AjaxRequest]
        [HttpGet]
        [Description("用户角色设置页面")]
        public ActionResult ShowUserRoleSetView()
        {
            return View();
        }
        #endregion

        #region 根据用户编号得到角色信息
        [AjaxRequest]
        [HttpPost]
        [Description("根据用户编号得到角色信息")]
        public ActionResult GetUserRolesByUserId()
        {
            int usrid = 0;
            if (Request.QueryString["userId"] != null && Request.QueryString["userId"].Trim() != "")
            {
                usrid = int.Parse(Request.QueryString["userId"]);            
            }

            dynamic dgRoleInfo = Model_Sys_UserRole.GetUserRoles(usrid);
            return Content(DataHelper.ObjToJson(dgRoleInfo));
          
        }
        #endregion

        #region 配置用户角色
        [AjaxRequest]
        [HttpPost]
        [Description("配置用户角色")]
        public ActionResult SetUserRoles()
        {
            string roleIds = string.Empty;
            if (Request.Form["roleIds"] != null)
            {
                roleIds = Request.Form["roleIds"];            
            }
            int uId = 0;
            if (Request.Form["uId"] != null)
            {
                uId = int.Parse(Request.Form["uId"]);
            }
            List<Sys_UserRole> usrRoles = new List<Sys_UserRole>();           
            if (roleIds.Trim() != "")
            {
                string[] rIds = roleIds.Split(',');
                foreach (string r in rIds)
                {
                    Sys_UserRole usrRole = new Sys_UserRole
                    {
                        urUId = uId,
                        urAddtime = DateTime.Now,
                        urIsDel = false,
                        urRId = int.Parse(r)
                    };

                    usrRoles.Add(usrRole);
                }
            }
            AjaxMsgModel amm = Model_Sys_UserRole.SetUserRoles(usrRoles,uId);
            return PackagingAjaxmsg(amm);
        }
        #endregion
    }
}
