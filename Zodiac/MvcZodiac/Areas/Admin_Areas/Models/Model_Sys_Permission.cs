using Common;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace MvcZodiac.Areas.Models
{
    public partial class Model_Sys_Permission
    {
        #region 得到用户的权限菜单
        /// <summary>
        /// 得到用户的权限菜单
        /// </summary>
        /// <returns>用户的权限菜单json字符串</returns>
        public static string GetUserPers()
        {
            string strJson = string.Empty;
            List<Sys_Permission> listPers = oc.UserPermission.Where(p => p.pIsShow == true && p.pIsDel == false)
                .OrderBy(p => p.pOrder).ToList();
            if (listPers.Count > 0)
            {
                List<TreeNode> listTreeNodes = Sys_Permission.ConvertTreeNodes(listPers);
                strJson = DataHelper.ObjToJson(listTreeNodes);
            }
            return strJson;
        }

        #endregion

        #region 得到所有的权限菜单的树型结构
        /// <summary>
        /// 得到所有的权限菜单
        /// </summary>
        /// <returns></returns>
        public static string GetAllPersForTree(bool isMemu=false)
        {
            string strJson = string.Empty;
            Expression<Func<Sys_Permission, bool>> whereLambda = null;
            if (isMemu)
            {
                whereLambda = p => p.pIsShow == true;
            }
            else
            {
                whereLambda = p => p.pIsShow == false || p.pIsShow == true;
            }

            List<Sys_Permission> listPers = oc.BllSession.ISys_PermissionBLL.GetListBy(
                whereLambda).OrderBy(p => p.pOrder).ToList();
            if (listPers.Count > 0)
            {
                List<TreeNode> listTreeNodes = Sys_Permission.ConvertTreeNodes(listPers);
                strJson = DataHelper.ObjToJson(listTreeNodes);
            }

            return strJson;
        }
        #endregion

        #region 得到所有的权限菜单ForTreeGrid
        /// <summary>
        /// 得到所有的权限菜单
        /// </summary>
        /// <returns></returns>
        public static dynamic GetAllPersForTreeGrid(bool isMemu = false)
        {

            Expression<Func<Sys_Permission, bool>> whereLambda = null;
            if (isMemu)
            {
                whereLambda = p => p.pIsShow == true;
            }
            else
            {
                whereLambda = p => p.pIsShow == false || p.pIsShow == true;
            }

            var listPers = oc.BllSession.ISys_PermissionBLL.GetListBy(
                 whereLambda).OrderBy(p => p.pOrder)

                 .Select(
                 p => new
                 {
                     p.pParent,
                     p.pid,
                     p.pName,
                     p.pAreaName,
                     p.pControllerName,
                     p.pActionName,
                     p.pFormMethod,
                     p.pIco,
                     p.pOrder,
                     p.pRemark,
                     p.pOperTime,
                     p.pIsDel,
                     p.pIsShow
                 }
                 ).ToList();
            List<EITreeGrid_Permission> listTgPers = new List<EITreeGrid_Permission>();

            foreach (var per in listPers)
            {
                string pPname = string.Empty;
                var pp = listPers.Where(p => p.pid == per.pParent).SingleOrDefault();
                pPname = pp == null ? string.Empty : pp.pName;

                string state = listPers.Count(p => p.pParent == per.pid) == 0 ? "open" : (per.pParent == 0 || per.pParent == 1) ? "open" : "closed";

                EITreeGrid_Permission tp = new EITreeGrid_Permission
                {
                    _parentId = (int)per.pParent,
                    state = state,
                    Checked = false,
                    iconCls = per.pIco,
                    pid = per.pid,
                    pName = per.pName,
                    pAreaName = per.pAreaName,
                    pControllerName = per.pControllerName,
                    pActionName = per.pActionName,
                    pFormMethod = per.pFormMethod,
                    pIco = per.pIco,
                    pOrder = per.pOrder,
                    pRemark = per.pRemark,
                    pOperTime = per.pOperTime,
                    pPerName = pPname,
                    pIsDel = per.pIsDel,
                    pIsShow = per.pIsShow

                };
                listTgPers.Add(tp);
            }

            return new DataGrid
            {
                total = listTgPers.Count(),
                rows = listTgPers,
                footer = null
            };
        }
        #endregion

        #region 根据用户编号得到对应的权限信息
        /// <summary>
        /// 根据用户编号得到对应的权限信息
        /// </summary>
        /// <param name="usrId">用户编号</param>
        /// <returns>权限集合</returns>
        public static List<Sys_Permission> GetUserPermission(int usrId)
        {
            //--根据用户编号得到权限菜单编号(集合)
            List<int> listRoleId = oc.BllSession.ISys_UserRoleBLL.Entities.Where(u => u.urUId == usrId)
                .Select(u => u.urRId).ToList();
            //根据权限菜单编号得到权限编号(集合)
            List<int> listPerIds = oc.BllSession.ISys_RolePermissionBLL.Entities.Where(rp => listRoleId.Contains(rp.rpRId))
                .Select(rp => rp.rpPId).ToList();
            //根据用户编号查询特权编号(集合)
            List<int> listVipPerIds = oc.BllSession.ISys_UserVipPermissionBLL.Entities.Where(vp => vp.vipUserId == usrId)
                .Select(vp => vp.vipPermission).ToList();
            //把两个权限集合整到了一起
            listPerIds.ForEach(p => {
                listVipPerIds.Add(p);
            });
            //根据权限编号得到权限的具体信息
            List<Sys_Permission> listPers = oc.BllSession.ISys_PermissionBLL.Entities
                .Where(p => listVipPerIds.Contains(p.pid)).ToList();

            return listPers.OrderBy(u => u.pOrder).ToList();
        }

        #endregion

        #region 判断当前用户是否有访问当前请求的权限
        /// <summary>
        /// 判断当前用户是否有访问当前请求的权限
        /// </summary>
        /// <param name="areaName">区域名</param>
        /// <param name="controllerName">控制制名</param>
        /// <param name="actionName">action方法名</param>
        /// <param name="httpmethod">http请求的方式</param>
        /// <returns>true：有权限 false无权限</returns>
        public static bool HasPermission(string areaName, string controllerName
            , string actionName, HttpMethod httpmethod)
        {
            var listP = from per in oc.UserPermission
                        where
                        string.Equals(per.pAreaName, areaName, StringComparison.CurrentCultureIgnoreCase)
                    && string.Equals(per.pControllerName, controllerName, StringComparison.CurrentCultureIgnoreCase)
                    && string.Equals(per.pActionName, actionName, StringComparison.CurrentCultureIgnoreCase)
                    && per.pFormMethod == (int)httpmethod
                        select per;

            return listP.Count() > 0;

        }
        #endregion

        #region 新增权限菜单
        /// <summary>
        /// 新增权限菜单
        /// </summary>
        /// <param name="Permission">权限菜单</param>
        /// <returns>AjaxMsgModel实体对象</returns>
        public static AjaxMsgModel AddPermission(Sys_Permission Permission)
        {
            int iret = oc.BllSession.ISys_PermissionBLL.Add(Permission);

            if (iret > 0)
            {
                return new AjaxMsgModel
                {
                    Statu = AjaxStatu.ok,
                    Msg = "权限菜单新增成功！",
                    Data = null,
                    BackUrl = null
                };
            }
            else
            {
                return new AjaxMsgModel
                {
                    Statu = AjaxStatu.err,
                    Msg = "权限菜单新增失败！",
                    Data = null,
                    BackUrl = null
                };
            }
        }
        #endregion

        #region 修改权限菜单
        /// <summary>
        /// 修改权限菜单
        /// </summary>
        /// <param name="Permission">权限菜单</param>
        /// <returns>AjaxMsgModel实体对象</returns>
        public static AjaxMsgModel EditPermission(Sys_Permission Permission)
        {
            Expression<Func<Sys_Permission, object>>[] ignoreProperties =
                new Expression<Func<Sys_Permission, object>>[] { p => p.Sys_RolePermission, p => p.Sys_UserVipPermission };

            int iret = oc.BllSession.ISys_PermissionBLL.Modify(Permission, ignoreProperties);

            if (iret > 0)
            {
                return new AjaxMsgModel
                {
                    Statu = AjaxStatu.ok,
                    Msg = "权限菜单修改成功！",
                    Data = null,
                    BackUrl = null
                };
            }
            else
            {
                return new AjaxMsgModel
                {
                    Statu = AjaxStatu.err,
                    Msg = "权限菜单修改失败！",
                    Data = null,
                    BackUrl = null
                };
            }
        }
        #endregion

        #region 删除权限菜单
        /// <summary>
        /// 删除权限菜单
        /// </summary>
        /// <param name="pId">要删除的权限菜单编号</param>
        /// <returns>AjaxMsgModel实体对象</returns>
        public static AjaxMsgModel DelPermission(int pId)
        {
            int pCount = oc.BllSession.ISys_PermissionBLL.Entities.Count(u => u.pParent == pId);
            if (pCount > 0)
            {
                return new AjaxMsgModel
                {
                    Statu = AjaxStatu.err,
                    Msg = "此权限菜单有子菜单，不允许直接删除！",
                    Data = null,
                    BackUrl = null
                };
            }


            int uCount = oc.BllSession.ISys_RolePermissionBLL.Entities.Count(u => u.rpPId == pId);
            if (uCount > 0)
            {
                return new AjaxMsgModel
                {
                    Statu = AjaxStatu.err,
                    Msg = "此权限菜单已被角色使用，不允许直接删除！",
                    Data = null,
                    BackUrl = null
                };
            }

            int rCount = oc.BllSession.ISys_UserVipPermissionBLL.Entities.Count(u => u.vipPermission == pId);
            if (rCount > 0)
            {
                return new AjaxMsgModel
                {
                    Statu = AjaxStatu.err,
                    Msg = "此权限菜单已关联用户，不允许直接删除！",
                    Data = null,
                    BackUrl = null
                };
            }

            int iret = oc.BllSession.ISys_PermissionBLL.DelBy(p => p.pid == pId);
            if (iret > 0)
            {
                return new AjaxMsgModel
                {
                    Statu = AjaxStatu.ok,
                    Msg = "权限菜单删除成功！",
                    Data = null,
                    BackUrl = null
                };
            }
            else
            {
                return new AjaxMsgModel
                {
                    Statu = AjaxStatu.err,
                    Msg = "权限菜单删除失败！",
                    Data = null,
                    BackUrl = null
                };
            }

        }
        #endregion
    }
}