using Common;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace MvcZodiac.Areas.Models
{
    public partial class Model_Sys_RolePermission
    {
        #region 得到当前角色的权限菜单ForTreeGrid
        /// <summary>
        /// 得到当前角色的权限菜单ForTreeGrid
        /// </summary>
        /// <returns></returns>
        public static dynamic GetRolePersForTreeGrid(int roleId)
        {

            List<int> listPids = oc.BllSession.ISys_RolePermissionBLL.Entities.Where(p => p.rpIsDel == false
                && p.rpRId == roleId).Select(vp => vp.rpPId).ToList();

            Expression<Func<Sys_Permission, bool>> whereLambda = null;          
            whereLambda = p => p.pIsDel == false;
         

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
                bool isPer = listPids.Contains(per.pid);
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
                    pIsShow = per.pIsShow,
                    IsHPer= isPer
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

        #region 设置角色权限
        public static AjaxMsgModel SetRolePers(List<Sys_RolePermission> rps,int rId)
        {
            int iret = oc.BllSession.ISys_RolePermissionBLL.SetRolePers(rps,rId);

            if (iret >= 0)
            {
                return new AjaxMsgModel
                {
                    Statu = AjaxStatu.ok,
                    Msg = "角色权限配置成功！",
                    Data = null,
                    BackUrl = null
                };
            }
            else
            {
                return new AjaxMsgModel
                {
                    Statu = AjaxStatu.err,
                    Msg = "角色权限配置失败！",
                    Data = null,
                    BackUrl = null
                };
            }
        }
        #endregion
    }
}