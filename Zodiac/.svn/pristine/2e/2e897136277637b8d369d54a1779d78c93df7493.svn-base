
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using MvcZodiac.Areas;
namespace MvcZodiac.Areas.EasyUI_Areas.Controllers
{
    public class AdminSysController : Controller
    {
        OperContext operateContext = OperContext.CurrentContext;
        //
        // GET: /AdminSys/
        [HttpGet]
        public ActionResult Permission()
        {
            return View();
        }

        #region 1.1 权限列表数据
        [HttpPost]
        /// <summary>
        /// 权限列表 视图
        /// </summary>
        /// <returns></returns>
        public ActionResult GetPermData()
        {
            ////获取页容量
            //int pageSize = 5;
            ////获取请求的页码
            //int pageIndex =1;
            ////获取页容量
            int pageSize = int.Parse(Request.Form["rows"]);
            //获取请求的页码
            int pageIndex = int.Parse(Request.Form["page"]);
            int rowCount = 0;
            // 查询分页数据
            var list = operateContext.BllSession.ISys_PermissionBLL.GetPageList(pageIndex, pageSize, ref rowCount, p => p.pParent == 1 && p.pIsDel == false, p => p.pOrder).Select(p => p.ToPOCO());
            //2 生成规定格式的 json字符串发回 给 异步对象
            DataGrid dgModel = new DataGrid()
            {
                total = rowCount,
                rows = list,
                footer = null
            };
            return Json(dgModel);
        }
        #endregion

        #region 1.2 角色列表数据
        [HttpPost]
        /// <summary>
        /// 角色列表数据
        /// </summary>
        /// <returns></returns>
        public ActionResult GetRoleData()
        {

            // 查询分页数据
            List<Sys_Role> listRole = operateContext.BllSession.ISys_RoleBLL.GetListBy(r => r.rIsDel == false, r => r.rId).ToList();
            List<Sys_Department> listDep = operateContext.BllSession.ISys_DepartmentBLL.GetListBy(d => d.depIsDel == false);
            List<PropertyGridRow> listPg = listRole.Join(listDep, pg => pg.rDepId, d => d.depId, (pg, d) => new PropertyGridRow { name = pg.rName, value = pg.rId.ToString(), group = d.depName, editor = "text" }).ToList();
            //2 生成规定格式的 json字符串发回 给 异步对象
            DataGrid dgModel = new DataGrid()
            {
                total = listPg.Count,
                rows = listPg
            };
            return Json(dgModel);
        }
        #endregion

        #region 1.3 用户列表数据
        public ActionResult GetUserInfo()
        {
            ///所有的没有注销的用户信息
            List<Sys_UserInfo> lsUsers = operateContext.BllSession.ISys_UserInfoBLL.GetListBy(u => u.uIsDel == false).Select(u => u.ToPOCO()).ToList();
            int count = lsUsers.Count;
            int boyCount = lsUsers.Where(u => u.uGender == true).Count();

            Sys_UserInfoFootModel lsFooterUser = new Sys_UserInfoFootModel
            {
               
                uLoginName = "总人数:"+count.ToString(),
                uRemark = "男性人数"+boyCount.ToString()              
             
            };

            List<Sys_UserInfoFootModel> lsFooterUsers = new List<Sys_UserInfoFootModel> { 
               lsFooterUser,
               lsFooterUser
            };
            ///把list转换成datagrid能够接收实体对象
            DataGrid dgModel = new DataGrid
            {
                total = lsUsers.Count,
                rows = lsUsers,
                footer = lsFooterUsers
            };

            //转换成JSON格式
            return Json(dgModel);


        }
        #endregion

        #region 1.4 删除用户列表数据
        public ActionResult DeleteUserInfo()
        {

            int uId = -1;
            uId = int.Parse(Request.Form["uId"].ToString());
            int iret = operateContext.BllSession.ISys_UserInfoBLL.DelBy(u => u.uId == uId);
            if (iret > 0)
            {
                return Content("ok");
            }
            else
            {
                return Content("error");
            }


        }
        #endregion

        #region 1.4 表单列表数据
        public ActionResult GetFormInfo()
        {
            ///所有的没有注销的用户信息

            FormDemo fd = new FormDemo {
                email = "zhangsan@qq.com",
                language = "English",
                message = "张三的内容",
                name = "张三",
                subject = "张三的主题"
            };

            //转换成JSON格式
            return Json(fd,JsonRequestBehavior.AllowGet);


        }
        #endregion

    }
}
