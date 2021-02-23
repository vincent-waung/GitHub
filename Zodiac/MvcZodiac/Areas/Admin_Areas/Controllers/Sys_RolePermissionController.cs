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
    public class Sys_RolePermissionController : BaseController
    {
        //
        // GET: /Admin_Areas/Sys_RolePermission/
        #region 角色权限管理
        [Skip]
        [HttpGet]
        [Description("角色权限管理")]
        public ActionResult RolePerIndex()
        {
            return View();
        } 
        #endregion

        #region 角色权限设置页面
        [AjaxRequest]
        [HttpGet]
        [Description("角色权限设置页面")]
        public ActionResult ShowRolePerSetView()
        {
            return View();
        }
        #endregion

        #region 根据角色查询权限
        [AjaxRequest]
        [HttpPost]
        [Description("根据角色查询权限")]
        public ActionResult GePermissionInfoByCondition()
        {
            int roleId = 0;
            if (Request.QueryString["roleId"] != null)
            {
                roleId = int.Parse(Request.QueryString["roleId"]);
            }
            dynamic dgPerInfo = Model_Sys_RolePermission.GetRolePersForTreeGrid(roleId);

            return Content(DataHelper.ObjToJson(dgPerInfo));
        } 
        #endregion

        #region 配置角色权限
        [AjaxRequest]
        [HttpPost]
        [Description("配置角色权限")]
        public ActionResult SetRolePers()
        {
            string perIds = string.Empty;
            if (Request.Form["perIds"] != null)
            {
                perIds = Request.Form["perIds"];
            }
            int rId = 0;
            if (Request.Form["rId"] != null)
            {
                rId = int.Parse(Request.Form["rId"]);
            }          
            List<Sys_RolePermission> rolePers = new List<Sys_RolePermission>();
            if (perIds.Trim() != "")
            {
                string[] pIds = perIds.Split(',');
                foreach (string p in pIds)
                {
                    Sys_RolePermission rolePer = new Sys_RolePermission
                    {
                        rpRId = rId,
                        rpAddTime = DateTime.Now,
                        rpIsDel = false,
                        rpPId = int.Parse(p)
                    };

                    rolePers.Add(rolePer);
                }
            }
            AjaxMsgModel amm = Model_Sys_RolePermission.SetRolePers(rolePers,rId);
            return PackagingAjaxmsg(amm);
        }
        #endregion

    }
}
