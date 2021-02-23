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
    public class Sys_RoleController : BaseController
    {
        //
        // GET: /Admin_Areas/Sys_Role/
        #region 角色管理首页
        [HttpGet]
        [Skip]
        [Description("角色管理首页")]
        public ActionResult Sys_RoleIndex()
        {
            return View();
        }
        #endregion

        #region 根据条件查询角色信息
        [AjaxRequest]
        [HttpPost]
        [Description("根据条件查询角色信息")]
        public ActionResult GetRoleInfoByCondition()
        {
            int page = 1;
            int rows = 5;
            if (Request.Form["rows"] != null && Request.Form["page"] != null)
            {
                page = int.Parse(Request.Form["page"]);
                rows = int.Parse(Request.Form["rows"]);
            }
            string sort = null;
            string order = null;
            if (Request.Form["sort"] != null && Request.Form["order"] != null)
            {
                sort = Request.Form["sort"];
                order = Request.Form["order"];
            }
            string rName = "";
            if (Request.Form["rName"] != null)
            {
                rName = Request.Form["rName"];
            }
            DateTime operDateStart = DateTime.Now.AddYears(-100);
            if (Request.Form["operDateStart"] != null && !Request.Form["operDateStart"].Equals(""))
            {
                operDateStart = DateTime.Parse(Request.Form["operDateStart"]);

            }
            DateTime operDateEnd = DateTime.Now;
            if (Request.Form["operDateEnd"] != null && !Request.Form["operDateEnd"].Equals(""))
            {
                operDateEnd = DateTime.Parse(Request.Form["operDateEnd"]);

            }
            dynamic dgRoleInfo = Model_Sys_Role.GetRoleInfoByCondition(page, rows, operDateStart
                , operDateEnd, rName, sort, order);
            return Content(DataHelper.ObjToJson(dgRoleInfo));
        } 
        #endregion

        #region 根据筛选条件查询角色信息并关联权限信息
        [AjaxRequest]
        [HttpPost]
        [Skip]
        [Description("根据筛选条件查询角色信息并关联权限信息")]
        public ActionResult GetRoleInfoByConditionJoinPerIds()
        {
            int page = 1;
            int rows = 5;
            if (Request.Form["rows"] != null && Request.Form["page"] != null)
            {
                page = int.Parse(Request.Form["page"]);
                rows = int.Parse(Request.Form["rows"]);
            }
            string sort = null;
            string order = null;
            if (Request.Form["sort"] != null && Request.Form["order"] != null)
            {
                sort = Request.Form["sort"];
                order = Request.Form["order"];
            }
            string rName = "";
            if (Request.Form["rName"] != null)
            {
                rName = Request.Form["rName"];
            }
            DateTime operDateStart = DateTime.Now.AddYears(-100);
            if (Request.Form["operDateStart"] != null && !Request.Form["operDateStart"].Equals(""))
            {
                operDateStart = DateTime.Parse(Request.Form["operDateStart"]);

            }
            DateTime operDateEnd = DateTime.Now;
            if (Request.Form["operDateEnd"] != null && !Request.Form["operDateEnd"].Equals(""))
            {
                operDateEnd = DateTime.Parse(Request.Form["operDateEnd"]);

            }
            dynamic dgRoleInfo = Model_Sys_Role.GetRoleInfoByConditionJoinPerIds(page, rows, operDateStart
                , operDateEnd, rName, sort, order);
            return Content(DataHelper.ObjToJson(dgRoleInfo));
        }
        #endregion

        #region 得到可用的所有角色信息
        [AjaxRequest]
        [HttpPost]
        [Skip]
        [Description("得到可用的所有角色信息")]
        public ActionResult GetAllRoles()
        {
            var roles = Model_Sys_Role.GetAllRoles();
            return Content(DataHelper.ObjToJson(roles));
        }
       #endregion

        #region 新增角色
        [AjaxRequest]
        [HttpPost]
        [Description("新增角色")]
        public ActionResult AddRole()
        {
            string rName = string.Empty;
            if (Request.Form["rName"] != null)
            {
                rName = Request.Form["rName"];
            }
            int rDepId = 0;
            if (Request.Form["rDepId"] != null)
            {
                rDepId = int.Parse(Request.Form["rDepId"]);
            }


            string rRemark = string.Empty;
            if (Request.Form["rRemark"] != null)
            {
                rRemark = Request.Form["rRemark"];
            }

            bool rIsShow = false;
            if (Request.Form["rIsShow"] != null && !Request.Form["rIsShow"].Equals(""))
            {
                rIsShow = bool.Parse(Request.Form["rIsShow"]);
            }
            bool rIsDel = false;
            if (Request.Form["rIsDel"] != null && !Request.Form["rIsDel"].Equals(""))
            {
                rIsDel = bool.Parse(Request.Form["rIsDel"]);
            }

            Sys_Role Role = new Sys_Role
            {
                rAddTime = DateTime.Now,
                rDepId = rDepId,
                rIsDel = rIsDel,
                rIsShow = rIsShow,
                rName = rName,
                rRemark = rRemark

            };
            AjaxMsgModel amm = Model_Sys_Role.AddRole(Role);
            return PackagingAjaxmsg(amm);
        }
        #endregion

        #region 修改角色
        [AjaxRequest]
        [HttpPost]
        [Description("修改角色")]
        public ActionResult EditRole()
        {

            int rId = 0;
            if (Request.Form["rId"] != null)
            {
                rId = int.Parse(Request.Form["rId"]);
            }

            string rName = string.Empty;
            if (Request.Form["rName"] != null)
            {
                rName = Request.Form["rName"];
            }
            int rDepId = 0;
            if (Request.Form["rDepId"] != null)
            {
                rDepId = int.Parse(Request.Form["rDepId"]);
            }
            string rRemark = string.Empty;
            if (Request.Form["rRemark"] != null)
            {
                rRemark = Request.Form["rRemark"];
            }

            bool rIsShow = false;
            if (Request.Form["rIsShow"] != null && !Request.Form["rIsShow"].Equals(""))
            {
                rIsShow = bool.Parse(Request.Form["rIsShow"]);
            }
            bool rIsDel = false;
            if (Request.Form["rIsDel"] != null && !Request.Form["rIsDel"].Equals(""))
            {
                rIsDel = bool.Parse(Request.Form["rIsDel"]);
            }

            Sys_Role Role = new Sys_Role
            {
                rAddTime = DateTime.Now,
                rDepId = rDepId,
                rIsDel = rIsDel,
                rIsShow = rIsShow,
                rName = rName,
                rRemark = rRemark,
                rId = rId

            };
            AjaxMsgModel amm = Model_Sys_Role.EditRole(Role);
            return PackagingAjaxmsg(amm);
        }
        #endregion

        #region 删除角色
        [AjaxRequest]
        [HttpPost]
        [Description("删除角色")]
        public ActionResult DelRole()
        {
            int depId = 0;
            if (Request.Form["rId"] != null)
            {
                depId = int.Parse(Request.Form["rId"]);
            }
            AjaxMsgModel amm = Model_Sys_Role.DelRole(depId);
            return PackagingAjaxmsg(amm);
        }
        #endregion
    }
}
