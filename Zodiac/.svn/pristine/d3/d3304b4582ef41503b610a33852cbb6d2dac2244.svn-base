using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using Common.Attributes;
using MvcZodiac.Areas;
namespace MvcZodiac.Areas.EasyUI_Areas.Controllers
{
    public class AdminIndexController : Controller
    {
        OperContext operateContext = OperContext.CurrentContext;
        //
        // GET: /AdminIndex/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShowIndexImg()
        {
            return View();
        }

      

        #region 得到所有的EasyUI菜单
        /// <summary>
        /// 得到所有的EasyUI菜单
        /// </summary>
        /// <param name="usrId"></param>
        public ActionResult GetAllEasyUI()
        {
            string str = string.Empty;

            List<Sys_EasyUI> easyUis = operateContext.BllSession.ISys_EasyUIBLL.GetListBy(e => e.pIsShow == true).OrderBy(e => e.pOrder).ToList();
            List<TreeNode> listTree = Sys_EasyUI.ToTreeNodes(easyUis);
            if (easyUis.Count > 0)
            {
                str = Common.DataHelper.ObjToJson(listTree);
            }

            return Content(str);
        }
        #endregion

        #region 得到所有的部门菜单
        /// <summary>
        /// 得到所有的部门菜单
        /// </summary>
        /// <param name="usrId"></param>
        public ActionResult GetAllDepts()
        {
            string str = string.Empty;

            List<Sys_Department> easyDepts = operateContext.BllSession.ISys_DepartmentBLL.GetListBy(e => e.depIsDel == false).OrderBy(e => e.depId).ToList();

            List<Sys_DepartmentTreeNode> listTree = Sys_Department.ToTreeNodes(easyDepts);
            if (easyDepts.Count > 0)
            {
                str = Common.DataHelper.ObjToJson(listTree);
            }
            return Content(str);
        }
        #endregion

        #region 得到所有的部门菜单
        /// <summary>
        /// 得到所有的部门菜单
        /// </summary>
        /// <param name="usrId"></param>
        public ActionResult GetAllDeptsTwo()
        {
            string str = string.Empty;

            List<Sys_Department> easyDepts = operateContext.BllSession.ISys_DepartmentBLL.GetListBy(e => e.depIsDel == false).OrderBy(e => e.depId).ToList();
            List<Sys_DepartmentTreeNodeTwo> listTree = Sys_Department.ToTreeGird(easyDepts);

            int count = listTree.Count;
            Sys_DepartmentTreeNodeFootTwo sdtnft = new Sys_DepartmentTreeNodeFootTwo
            {
                depRemark = "部门数量:" + count.ToString()
            };

            List<Sys_DepartmentTreeNodeFootTwo> sdtnfts = new List<Sys_DepartmentTreeNodeFootTwo> 
            { 
            
                sdtnft
            };
            

            DataGrid dgm = new DataGrid
            {
                total = listTree.Count,
                rows = listTree,
                footer = sdtnfts
            };
            if (easyDepts.Count > 0)
            {
                str = Common.DataHelper.ObjToJson(dgm);
            }

            return Content(str);
        }
        #endregion

        #region 得到所有的部门菜单
        /// <summary>
        /// 得到所有的部门菜单
        /// </summary>
        /// <param name="usrId"></param>
        public ActionResult GetAllDeptsFirst()
        {
            string str = string.Empty;

            List<Sys_Department> easyDepts = operateContext.BllSession.ISys_DepartmentBLL.GetListBy(e => e.depIsDel == false).OrderBy(e => e.depId).ToList();
            List<Sys_DepartmentTreeNodeTwo> listTree = Sys_Department.ToTreeGird(easyDepts);


         
            if (easyDepts.Count > 0)
            {
                str = Common.DataHelper.ObjToJson(listTree);
            }

            return Content(str);
        }
        #endregion

    }
}
