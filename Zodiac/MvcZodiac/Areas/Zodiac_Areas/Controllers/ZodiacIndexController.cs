using Common;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcZodiac.Areas.Zodiac_Areas.Controllers
{
    public class ZodiacIndexController : Controller
    {

        #region UI层与Service之间操作的上下文
        OperContext oc = OperContext.CurrentContext;
        #endregion

        #region 首页

        #region 打开首页
        /// <summary>
        /// 打开首页
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {

            return View();
        }
        #endregion

        #region 得到所有的权限菜单
        public ActionResult GetAllPers()
        {
            string strJson = string.Empty;
            List<Sys_Permission> listPers = oc.BllSession.ISys_PermissionBLL.GetListBy(
                p => p.pIsShow == true && p.pIsDel == false).OrderBy(p => p.pOrder).ToList();
            if (listPers.Count > 0)
            {
                List<TreeNode> listTreeNodes = Sys_Permission.ConvertTreeNodes(listPers);
                strJson = DataHelper.ObjToJson(listTreeNodes);
            }

            return Content(strJson);
        }
        #endregion

        #region 显示tab首页
        public ActionResult TabIndex()
        {
            return View();
        }
        #endregion
        #endregion



        #region 显示十二生肖
        /// <summary>
        /// 显示十二生肖的页面
        /// </summary>
        /// <returns></returns>
        public ActionResult ShowZodiac()
        {
            return View();
        }

        public ActionResult ShowZodiacGrid()
        {
            // page=2&rows=10&sort=Code&order=asc

            //输出每个用户捅有的角色数量
            ///第一种方式
            //List<Sys_UserInfo> users = oc.BllSession.ISys_UserInfoBLL.Entities.ToList();
            //foreach (var user in users)
            //{
            //    Console.WriteLine(user.Sys_UserRole.Count);
            //}
            ///第二种方式
            //List<Sys_UserInfo> users = oc.BllSession.ISys_UserInfoBLL.Entities.Include(u => u.Sys_UserRole).ToList();

            //foreach (var usr in users)
            //{
            //    Console.WriteLine(usr.Sys_UserRole.Count);
            //}
            ///第三种方式(匿名对象)
            //var users = oc.BllSession.ISys_UserInfoBLL.Entities.Select(u =>
            //    new { 

            //        RolesCount = u.Sys_UserRole.Count
            //    }
            //).ToList();
            //foreach (var usr in users)
            //{
            //    Console.WriteLine(usr.RolesCount);

            //}



            string xsName = string.Empty;
            if (Request.Form["xsName"] != null)
            {
                xsName = Request.Form["xsName"].ToString();
            }
            int page = 1;
            if (Request.Form["page"] != null)
            {
                page = int.Parse(Request.Form["page"].ToString());
            }
            int rows = 10;
            if (Request.Form["rows"] != null)
            {
                rows = int.Parse(Request.Form["rows"].ToString());
            }
            string sort = string.Empty;
            if (Request.Form["sort"] != null)
            {
                sort = Request.Form["sort"].ToString();
            }

            string order = string.Empty;
            if (Request.Form["order"] != null)
            {
                order = Request.Form["order"].ToString();
            }

            bool isASC = order.Equals("asc");
            //ListSortDirection listSortDirection = order.Equals("asc")? ListSortDirection.Ascending: ListSortDirection.Descending;
            int rowsCount = 0;

            //PropertySortCondition sortCondition =  new  PropertySortCondition(sort,listSortDirection);

            //var zodiac1 = oc.BllSession.IBn_ZodiacBLL.Entities.Where(z =>

            //       string.IsNullOrEmpty(xsName) ? true : z.Name.IndexOf(xsName) > -1

            //       , page, rows, out rowsCount, sortCondition).Select(z => z.Name);

            //List<string> strs = zodiac1.ToList();

            List<Bn_Zodiac> zodiac = oc.BllSession.IBn_ZodiacBLL.GetPageList(page, rows, ref rowsCount, z =>

                    string.IsNullOrEmpty(xsName) ? true : z.Name.IndexOf(xsName) > -1

                    , z => sort, isASC).Select(z => z.ToPOCO()).ToList();

            DataGrid dgModel = new DataGrid
            {
                total = rowsCount,
                rows = zodiac,
                footer = null
            };
            return Json(dgModel, JsonRequestBehavior.AllowGet);
        }
        #endregion

    }


}
