using Common;
using Common.Attributes;
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
    public class Sys_LogController : BaseController
    {
        //
        // GET: /Admin_Areas/Sys_Log/

        #region 日志管理首页
        public ActionResult LogIndex()
        {
            return View();
        } 
        #endregion


        #region 根据条件查询日志信息
        [AjaxRequest]
        [HttpPost]
        [Description("根据条件查询日志信息")]
        public ActionResult GetLogInfoByCondition()
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
            string Logger = "";
            if (Request.Form["Logger"] != null)
            {
                Logger = Request.Form["Logger"];
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

            dynamic dgUserInfo = Model_Sys_Log.GetLogInfoByCondition(page, rows, operDateStart
                , operDateEnd, Logger, sort, order);
            return Content(DataHelper.ObjToJson(dgUserInfo));
        }
        #endregion
    }
}
