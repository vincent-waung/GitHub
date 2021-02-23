using MvcZodiac.Areas.Models;
using MvcZodiac.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Common.Attributes;
using System.ComponentModel;
using Common;
using Models;
namespace MvcZodiac.Areas.Admin_Areas.Controllers
{
    [Description("权限表控制器")]
    public class Sys_PermissionController : BaseController
    {
        //
        // GET: /Admin_Areas/Sys_Permission/
        #region 菜单管理首页
        [Skip]
        [HttpGet]
        [Description("菜单管理首页")]
        public ActionResult MenuIndex()
        {
            return View();
        } 
        #endregion

        #region 权限管理首页
        [Skip]
        [HttpGet]
        [Description("权限管理首页")]
        public ActionResult PerIndex()
        {
            return View();
        }
        #endregion


        #region 得到所有的权限菜单
        /// <summary>
        /// 得到所有的权限菜单
        /// </summary>
        /// <returns></returns>
        [AjaxRequest]
        [HttpPost]
        [Description("获取所有的权限菜单")]        
        public ActionResult GetAllPers()
        {
            string strJson = Model_Sys_Permission.GetAllPersForTree();
            return Content(strJson);
        }
        #endregion

        #region 得到所有的菜单的树型模板
        /// <summary>
        /// 得到所有的菜单
        /// </summary>
        /// <returns></returns>
        [AjaxRequest]
        [HttpPost]
        [Description("得到所有的菜单的树型模板")]
        public ActionResult GetAllMenusForTree()
        {
            string strJson = Model_Sys_Permission.GetAllPersForTree(true);
            return Content(strJson);
        }
        #endregion

        #region 得到所有的权限的树型模板
        /// <summary>
        /// 得到所有的菜单
        /// </summary>
        /// <returns></returns>
        [AjaxRequest]
        [HttpPost]
        [Description("得到所有的权限的树型模板")]
        public ActionResult GetAllPersForTree()
        {
            string strJson = Model_Sys_Permission.GetAllPersForTree();
            return Content(strJson);
        }
        #endregion

        #region 得到所有的菜单的TreeGrid模板
        /// <summary>
        /// 得到所有的菜单的TreeGrid模板
        /// </summary>
        /// <returns></returns>
        [AjaxRequest]
        [HttpPost]
        [Skip]
        [Description("获取所有的菜单")]
        public ActionResult GetAllPersForTreeGridMenu()
        {
            dynamic allTreeMenus = Model_Sys_Permission.GetAllPersForTreeGrid(true);
            return Content(DataHelper.ObjToJson(allTreeMenus));
        }
        #endregion

        #region 得到所有的权限的TreeGrid模板
        /// <summary>
        /// 得到所有的菜单的TreeGrid模板
        /// </summary>
        /// <returns></returns>
        [AjaxRequest]
        [HttpPost]
        [Skip]
        [Description("获取所有的权限")]
        public ActionResult GetAllPersForTreeGridPer()
        {
            dynamic allTreeMenus = Model_Sys_Permission.GetAllPersForTreeGrid();
            return Content(DataHelper.ObjToJson(allTreeMenus));
        }
        #endregion

        #region 权限编辑页面
        [AjaxRequest]
        [HttpGet]
        [Description("权限编辑页面")]
        public ActionResult ShowPerEditView()
        {
            return View();
        } 
        #endregion

        #region 得到用户的权限菜单
        /// <summary>
        /// 获取用户的权限菜单
        /// </summary>
        /// <returns></returns>
        [AjaxRequest]
        [HttpPost]
        [Description("获取用户的权限菜单")]
        public ActionResult GetUserPers()
        {
            string strJson = Model_Sys_Permission.GetUserPers();
            return Content(strJson);
        }
        #endregion

        #region 添加菜单
        /// <summary>
        /// 添加菜单
        /// </summary>
        /// <returns></returns>
        [AjaxRequest]
        [HttpPost]
        [Description("添加菜单")]
        public ActionResult AddMenu()
        {
            Sys_Permission per = GetRequestPer();
            per.pIsShow = true;
            AjaxMsgModel amm = Model_Sys_Permission.AddPermission(per);
            return PackagingAjaxmsg(amm);
        }
       
        #endregion

        #region 修改菜单
        /// <summary>
        /// 修改菜单
        /// </summary>
        /// <returns></returns>
        [AjaxRequest]
        [HttpPost]
        [Description("修改菜单")]
        public ActionResult EditMenu()
        {
            Sys_Permission per = GetRequestPer(true);
            AjaxMsgModel amm = Model_Sys_Permission.EditPermission(per);
            return PackagingAjaxmsg(amm);
        }

        #endregion

        #region 删除菜单
        /// <summary>
        /// 删除菜单
        /// </summary>
        /// <returns></returns>
        [AjaxRequest]
        [HttpPost]
        [Description("删除菜单")]
        public ActionResult DelMenu()
        {
            int pid = 0;
            if (Request.Form["pid"] != null)
            {
                pid = int.Parse(Request.Form["pid"]);              
            }
            AjaxMsgModel amm = Model_Sys_Permission.DelPermission(pid);
            return PackagingAjaxmsg(amm);
        }

        #endregion

        #region 得到请求的权限菜单实体

        private Sys_Permission GetRequestPer(bool isModity = false)
        {
           

            int _parentId = 0;
            if (Request.Form["_parentId"] != null)
            {
                _parentId = int.Parse(Request.Form["_parentId"]);
            }
            string pName = string.Empty;
            if (Request.Form["pName"] != null)
            {
                pName = Request.Form["pName"];
            }
            string pAreaName = string.Empty;
            if (Request.Form["pAreaName"] != null)
            {
                pAreaName = Request.Form["pAreaName"];
            }
            string pControllerName = string.Empty;
            if (Request.Form["pControllerName"] != null)
            {
                pControllerName = Request.Form["pControllerName"];
            }
            string pActionName = string.Empty;
            if (Request.Form["pActionName"] != null)
            {
                pActionName = Request.Form["pActionName"];
            }
            short pFormMethod = 1;
            if (Request.Form["pFormMethod"] != null && !Request.Form["pFormMethod"].Equals(""))
            {
                pFormMethod = short.Parse(Request.Form["pFormMethod"]);
            }
            bool pIsDel = false;
            if (Request.Form["pIsDel"] != null && !Request.Form["pIsDel"].Equals(""))
            {
                pIsDel = bool.Parse(Request.Form["pIsDel"]);
            }
            bool pIsShow = false;
            if (Request.Form["pIsShow"] != null && !Request.Form["pIsShow"].Equals(""))
            {
                pIsShow = bool.Parse(Request.Form["pIsShow"]);
            }

            int pOrder = 10001;
            if (Request.Form["pOrder"] != null && !Request.Form["pOrder"].Equals(""))
            {
                pOrder = int.Parse(Request.Form["pOrder"]);
            }
            string pIco = string.Empty;
            if (Request.Form["pIco"] != null)
            {
                pIco = Request.Form["pIco"];
            }
            string pRemark = string.Empty;
            if (Request.Form["pRemark"] != null)
            {
                pRemark = Request.Form["pRemark"];
            }
            Sys_Permission per = new Sys_Permission
            {
                pActionName = pActionName,
                pAreaName = pAreaName,
                pControllerName = pControllerName,
                pFormMethod = pFormMethod,
                pIco = pIco,
                pIsDel = pIsDel,
                pIsShow = pIsShow,
                pName = pName,
                pOperTime = DateTime.Now,
                pOrder = pOrder,
                pParent = _parentId,
                pRemark = pRemark
                
            };
           
            if (isModity)
            {
                int pid = 0;
                if (Request.Form["pid"] != null)
                {
                    pid = int.Parse(Request.Form["pid"]);
                    per.pid = pid;
                }
            }
            return per;
        }
        #endregion
    }
}
