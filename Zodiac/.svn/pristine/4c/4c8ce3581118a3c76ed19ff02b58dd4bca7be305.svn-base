using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Common.Attributes;
using System.ComponentModel;
using MvcZodiac.Areas.Models;
using Common;
using Models;
using MvcZodiac.Controllers;
namespace MvcZodiac.Areas.Admin_Areas.Controllers
{
    public class Sys_DepartmentController : BaseController
    {
        //
        // GET: /Admin_Areas/Sys_Department/
        #region 组织机构管理
        [Skip]
        [HttpGet]
        [Description("组织机构管理")]
        public ActionResult DeptIndex()
        {
            return View();
        } 
        #endregion

        #region 查询所有组织结构
        [AjaxRequest]
        [HttpPost]
        [Description("查询所有组织结构")]
        public ActionResult GetDeptInfoByCondition()
        {
            dynamic allDepts = Model_Sys_Department.GetAllDeptInfo();
            return Content(DataHelper.ObjToJson(allDepts));
        } 
        #endregion

        #region 查询所有树型结构的组织信息
        [AjaxRequest]
        [HttpPost]
        [Skip]
        [Description("查询所有树型结构的组织信息")]
        public ActionResult GetTreeDepInfo()
        {
            dynamic allTreeDepts = Model_Sys_Department.GetAllDeptForTree();
            return Content(DataHelper.ObjToJson(allTreeDepts));
        }
        #endregion

        #region 组织机构编辑页面
        [AjaxRequest]
        [HttpGet]
        [Description("组织机构编辑页面")]
        public ActionResult ShowDeptEditView()
        {
            return View();
        } 
        #endregion

        #region 新增部门
        [AjaxRequest]
        [HttpPost]
        [Description("新增部门")]
        public ActionResult AddDept()
        {
            string depName = string.Empty;
            if (Request.Form["depName"] != null)
            {
                depName = Request.Form["depName"];
            }
            int depOrder = 0;
            if (Request.Form["depOrder"] != null)
            {
                depOrder =int.Parse(Request.Form["depOrder"]);
            }
            int depPid = 0;
            if (Request.Form["depPid"] != null)
            {
                depPid = int.Parse(Request.Form["depPid"]);
            }
            string depIconCls = string.Empty;
            if (Request.Form["depIconCls"] != null)
            {
                depIconCls = Request.Form["depIconCls"];
            }

            string depRemark = string.Empty;
            if (Request.Form["depRemark"] != null)
            {
                depRemark = Request.Form["depRemark"];
            }

            bool depIsDel = false;
            if (Request.Form["depIsDel"] != null && !Request.Form["depIsDel"].Equals(""))
            {
                depIsDel = bool.Parse(Request.Form["depIsDel"]);
            }

            Sys_Department dept = new Sys_Department
            {
                depIconCls = depIconCls,
                depOrder = depOrder,
                depAddTime = DateTime.Now,
                depIsDel = depIsDel,
                depName = depName,
                depPid = depPid,
                depRemark = depRemark

            };
            AjaxMsgModel amm = Model_Sys_Department.AddDept(dept);
            return PackagingAjaxmsg(amm);
        } 
        #endregion

        #region 修改部门
        [AjaxRequest]
        [HttpPost]
        [Description("修改部门")]
        public ActionResult EditDept()
        {
            int depId = 0;
            if (Request.Form["depId"] != null)
            {
                depId = int.Parse(Request.Form["depId"]);
            }

            string depName = string.Empty;
            if (Request.Form["depName"] != null)
            {
                depName = Request.Form["depName"];
            }
            int depOrder = 0;
            if (Request.Form["depOrder"] != null)
            {
                depOrder = int.Parse(Request.Form["depOrder"]);
            }
            int depPid = 0;
            if (Request.Form["depPid"] != null)
            {
                depPid = int.Parse(Request.Form["depPid"]);
            }
            string depIconCls = string.Empty;
            if (Request.Form["depIconCls"] != null)
            {
                depIconCls = Request.Form["depIconCls"];
            }

            string depRemark = string.Empty;
            if (Request.Form["depRemark"] != null)
            {
                depRemark = Request.Form["depRemark"];
            }

            bool depIsDel = false;
            if (Request.Form["depIsDel"] != null)
            {
                depIsDel = bool.Parse(Request.Form["depIsDel"]);
            }

            Sys_Department dept = new Sys_Department
            {
                depIconCls = depIconCls,
                depOrder = depOrder,
                depAddTime = DateTime.Now,
                depIsDel = depIsDel,
                depName = depName,
                depPid = depPid,
                depRemark = depRemark,
                depId = depId

            };
            AjaxMsgModel amm = Model_Sys_Department.EditDept(dept);
            return PackagingAjaxmsg(amm);
        }
        #endregion        

        #region 删除部门
        [AjaxRequest]
        [HttpPost]
        [Description("删除部门")]
        public ActionResult DelDept()
        {
            int depId = 0;
            if (Request.Form["depId"]!=null)
            {
                depId = int.Parse(Request.Form["depId"]);
            }
            AjaxMsgModel amm = Model_Sys_Department.DelDept(depId);
            return PackagingAjaxmsg(amm);
        }
        #endregion
    }
}
