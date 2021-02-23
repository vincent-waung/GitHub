using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Common;
using Models;
using System.Linq.Expressions;
using Models.PocoModel;
namespace MvcZodiac.Areas.Models
{
    public partial class Model_Sys_Role
    {
        #region 根据筛选条件查询角色信息
        public static dynamic GetRoleInfoByCondition(int page, int rows,
            DateTime operDateStart, DateTime operDateEnd, string roleName = "", string sort = null, string order = null)
        {
            int total =0;
             var roles = GetRoleInfoForIQueryable(out total, page, rows, operDateStart, operDateEnd, 
                roleName, sort, order);

             var roleList = roles.Select(r => new
                {
                    r.rId,
                    r.Sys_Department.depId,
                    r.Sys_Department.depName,
                    r.rDepId,
                    r.rName,
                    r.rRemark,
                    r.rIsDel,
                    r.rIsShow,
                    r.rAddTime
                }).ToList();

            return new DataGrid
            {
                total = total,
                rows = roleList,
                footer = null
            };
        }
        #endregion

        #region 根据筛选条件查询角色信息+IQueryable<Sys_Role>
        private static IQueryable<Sys_Role> GetRoleInfoForIQueryable(out int total, int page, int rows,
            DateTime operDateStart, DateTime operDateEnd, string roleName = "", string sort = null, string order = null)
        {
            total =0;
            PropertySortCondition<Sys_Role> psc = null;
            if (sort == null)
            {
                psc = new PropertySortCondition<Sys_Role>(r => r.rId);
            }
            else
            {
                psc = new PropertySortCondition<Sys_Role>(sort, order.Equals("asc") ? ListSortDirection.Ascending : ListSortDirection.Descending);
            }

            var roles = oc.BllSession.ISys_RoleBLL.Entities.Where(r => r.rName.Contains(roleName) &&
                r.rAddTime >= operDateStart && r.rAddTime <= operDateEnd, page, rows, out total, psc);

            return roles ;
        }
        #endregion

        #region 根据筛选条件查询角色信息并关联权限信息
        /// <summary>
        /// 根据筛选条件查询角色信息并关联权限信息
        /// </summary>
        /// <param name="page">页码</param>
        /// <param name="rows">每页条数</param>
        /// <param name="operDateStart">起始日期</param>
        /// <param name="operDateEnd">截止日期</param>
        /// <param name="depId">所属部门</param>
        /// <param name="uLoginName">登录名</param>
        /// <param name="sort">排序字段</param>
        /// <param name="order">排序方向</param>
        /// <returns>根据指定条件返回用户信息</returns>
        public static dynamic GetRoleInfoByConditionJoinPerIds(int page, int rows,
            DateTime operDateStart, DateTime operDateEnd, string roleName = "", string sort = null, string order = null)
        {
            int total = 0;
            var roles = GetRoleInfoForIQueryable(out total, page, rows, operDateStart, operDateEnd,
              roleName, sort, order);
            var roleList = roles.Select(r => new
            {
                r.rId,
                r.Sys_Department.depId,
                r.Sys_Department.depName,
                r.rDepId,
                r.rName,
                r.rRemark,
                r.rIsDel,
                r.rIsShow,
                r.rAddTime
            }).ToList();


            List<POCO_Sys_Role> pocoRoles = new List<POCO_Sys_Role>();

            foreach (var role in roleList)
            {
                List<int> listPers = oc.BllSession.ISys_RolePermissionBLL.Entities.Where(rp => rp.rpRId == role.rId
                    && rp.rpIsDel == false).Select(rp => rp.rpPId).ToList();

                string pIds = string.Empty;
                if (listPers.Count > 0)
                {
                    listPers.ForEach(p =>
                    {
                        pIds += p.ToString() + ",";
                    });
                    pIds = pIds.Substring(0, pIds.Length - 1);
                }

                POCO_Sys_Role psu = new POCO_Sys_Role
                {
                    rId = role.rId,
                    depName = role.depName,
                    rDepId = role.rDepId,
                    rName = role.rName,
                    rRemark = role.rRemark,
                    rIsDel = role.rIsDel,
                    rIsShow = role.rIsShow,
                    rAddTime = role.rAddTime,
                    perIds = pIds
                };
                pocoRoles.Add(psu);
            }

            return new DataGrid
            {
                total = total,
                rows = pocoRoles,
                footer = null
            };
        }
        #endregion

        #region 得到可用的所有角色信息
        /// <summary>
        /// 得到可用的所有角色信息
        /// </summary>
        /// <returns></returns>
        public static dynamic GetAllRoles()
        {
            var roles = oc.BllSession.ISys_RoleBLL.Entities.Where(r => r.rIsDel == false)
                .Select(r => new { 
                  r.rId,
                  r.rName,
                  r.rRemark
                });

            return roles;
        }
        #endregion

        #region 新增角色
        /// <summary>
        /// 新增角色
        /// </summary>
        /// <param name="Role">角色</param>
        /// <returns>AjaxMsgModel实体对象</returns>
        public static AjaxMsgModel AddRole(Sys_Role Role)
        {
            int iret = oc.BllSession.ISys_RoleBLL.Add(Role);

            if (iret > 0)
            {
                return new AjaxMsgModel
                {
                    Statu = AjaxStatu.ok,
                    Msg = "角色新增成功！",
                    Data = null,
                    BackUrl = null
                };
            }
            else
            {
                return new AjaxMsgModel
                {
                    Statu = AjaxStatu.err,
                    Msg = "角色新增失败！",
                    Data = null,
                    BackUrl = null
                };
            }
        }
        #endregion

        #region 修改角色
        /// <summary>
        /// 修改角色
        /// </summary>
        /// <param name="Role">角色</param>
        /// <returns>AjaxMsgModel实体对象</returns>
        public static AjaxMsgModel EditRole(Sys_Role Role)
        {
            Expression<Func<Sys_Role, object>>[] ignoreProperties =
                new Expression<Func<Sys_Role, object>>[] { p => p.Sys_Department, p => p.Sys_UserRole, p => p.Sys_RolePermission };

            int iret = oc.BllSession.ISys_RoleBLL.Modify(Role, ignoreProperties);

            if (iret > 0)
            {
                return new AjaxMsgModel
                {
                    Statu = AjaxStatu.ok,
                    Msg = "角色修改成功！",
                    Data = null,
                    BackUrl = null
                };
            }
            else
            {
                return new AjaxMsgModel
                {
                    Statu = AjaxStatu.err,
                    Msg = "角色修改失败！",
                    Data = null,
                    BackUrl = null
                };
            }
        }
        #endregion

        #region 删除角色
        /// <summary>
        /// 删除角色
        /// </summary>
        /// <param name="rId">要删除的角色编号</param>
        /// <returns>AjaxMsgModel实体对象</returns>
        public static AjaxMsgModel DelRole(int rId)
        {
            int uCount = oc.BllSession.ISys_UserRoleBLL.Entities.Count(u => u.urRId == rId);
            if (uCount > 0)
            {
                return new AjaxMsgModel
                {
                    Statu = AjaxStatu.err,
                    Msg = "此角色已被用户使用，不允许直接删除！",
                    Data = null,
                    BackUrl = null
                };
            }

            int rCount = oc.BllSession.ISys_RolePermissionBLL.Entities.Count(u => u.rpRId == rId);
            if (rCount > 0)
            {
                return new AjaxMsgModel
                {
                    Statu = AjaxStatu.err,
                    Msg = "此角色已关联权限，不允许直接删除！",
                    Data = null,
                    BackUrl = null
                };
            }

            int iret = oc.BllSession.ISys_RoleBLL.DelBy(p => p.rId == rId);
            if (iret > 0)
            {
                return new AjaxMsgModel
                {
                    Statu = AjaxStatu.ok,
                    Msg = "角色删除成功！",
                    Data = null,
                    BackUrl = null
                };
            }
            else
            {
                return new AjaxMsgModel
                {
                    Statu = AjaxStatu.err,
                    Msg = "角色删除失败！",
                    Data = null,
                    BackUrl = null
                };
            }

        }
        #endregion
    }
}