using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Models;
using Common;
using System.Linq.Expressions;
namespace MvcZodiac.Areas.Models
{
    public partial class Model_Sys_Department
    {
        #region 得到所有的组织机构信息
        /// <summary>
        /// 得到所有的组织机构信息
        /// </summary>
        /// <returns></returns>
        public static dynamic GetAllDeptInfo()
        {
            /*通过EF得到所有的组织结构信息*/
            var allDepts = oc.BllSession.ISys_DepartmentBLL.Entities.Select(d => new
            {
                d.depId,
                d.depPid,
                d.depName,
                d.depIconCls,
                d.depRemark,
                d.depAddTime,
                d.depOrder,
                d.depIsDel

            });
            /*把已有的组织结构信息格式化成对应JSON格式*/
            List<EITreeGrid_Department> listDepts = new List<EITreeGrid_Department>();
            foreach (var dep in allDepts)
            {
                string pdName = string.Empty;
                var sdep = allDepts.Where(p => p.depId == dep.depPid).FirstOrDefault();

                pdName = sdep != null ? sdep.depName : string.Empty;

                EITreeGrid_Department eiTD = new EITreeGrid_Department
                {
                    _parentId = dep.depPid,
                    state = "open",
                    Checked = false,
                    iconCls = dep.depIconCls,
                    depId = dep.depId,
                    depPid = dep.depPid,
                    depName = dep.depName,
                    depIconCls = dep.depIconCls,
                    depRemark = dep.depRemark,
                    depAddTime = dep.depAddTime,
                    depOrder = dep.depOrder,
                    pDepName = pdName,
                    depIsDel = dep.depIsDel
                };
                listDepts.Add(eiTD);
            }
            /*格式化数据*/
            return new DataGrid
            {
                footer = null,
                rows = listDepts,
                total = listDepts.Count()
            };
        }
        #endregion

        #region 得到所有的树型结构的组织机构信息
        /// <summary>
        /// 得到所有的树型结构的组织机构信息
        /// </summary>
        /// <returns></returns>
        public static dynamic GetAllDeptForTree()
        {
            string str = string.Empty;
            List<Sys_Department> depts = oc.BllSession.ISys_DepartmentBLL.Entities.OrderBy(d => d.depOrder).ToList();

            List<EITree_Department> treeDepts = Sys_Department.ToEayUITreeNodes(depts);

            return treeDepts;
        }
        #endregion

        #region 新增组织机构
        /// <summary>
        /// 新增组织机构
        /// </summary>
        /// <param name="dept">组织机构</param>
        /// <returns>AjaxMsgModel实体对象</returns>
        public static AjaxMsgModel AddDept(Sys_Department dept)
        {
            int iret = oc.BllSession.ISys_DepartmentBLL.Add(dept);

            if (iret > 0)
            {
                return new AjaxMsgModel
                {
                    Statu = AjaxStatu.ok,
                    Msg = "部门新增成功！",
                    Data = null,
                    BackUrl = null
                };
            }
            else
            {
                return new AjaxMsgModel
                {
                    Statu = AjaxStatu.err,
                    Msg = "部门新增失败！",
                    Data = null,
                    BackUrl = null
                };
            }
        }
        #endregion

        #region 修改组织机构
        /// <summary>
        /// 修改组织机构
        /// </summary>
        /// <param name="dept">组织机构</param>
        /// <returns>AjaxMsgModel实体对象</returns>
        public static AjaxMsgModel EditDept(Sys_Department dept)
        {
            Expression<Func<Sys_Department, object>>[] ignoreProperties =
                new Expression<Func<Sys_Department, object>>[] { p => p.Sys_Role, p => p.Sys_UserInfo };

            int iret = oc.BllSession.ISys_DepartmentBLL.Modify(dept, ignoreProperties);

            if (iret > 0)
            {
                return new AjaxMsgModel
                {
                    Statu = AjaxStatu.ok,
                    Msg = "部门修改成功！",
                    Data = null,
                    BackUrl = null
                };
            }
            else
            {
                return new AjaxMsgModel
                {
                    Statu = AjaxStatu.err,
                    Msg = "部门修改失败！",
                    Data = null,
                    BackUrl = null
                };
            }
        }
        #endregion

        #region 删除组织机构
        /// <summary>
        /// 删除组织机构
        /// </summary>
        /// <param name="depId">要删除的部门编号</param>
        /// <returns>AjaxMsgModel实体对象</returns>
        public static AjaxMsgModel DelDept(int depId)
        {
           int uCount = oc.BllSession.ISys_UserInfoBLL.Entities.Count(u => u.uDepId == depId);
           if (uCount > 0)
           {
               return new AjaxMsgModel
               {
                   Statu = AjaxStatu.err,
                   Msg = "此部门已被用户使用，不允许直接删除！",
                   Data = null,
                   BackUrl = null
               };
           }

           int rCount = oc.BllSession.ISys_RoleBLL.Entities.Count(u => u.rDepId == depId);
           if (rCount > 0)
           {
               return new AjaxMsgModel
               {
                   Statu = AjaxStatu.err,
                   Msg = "此部门已被角色使用，不允许直接删除！",
                   Data = null,
                   BackUrl = null
               };
           }

           int pCount = oc.BllSession.ISys_DepartmentBLL.Entities.Count(u => u.depPid == depId);
           if (pCount > 0)
           {
               return new AjaxMsgModel
               {
                   Statu = AjaxStatu.err,
                   Msg = "此部门有下级部门信息，不允许直接删除！",
                   Data = null,
                   BackUrl = null
               };
           }

           int iret = oc.BllSession.ISys_DepartmentBLL.DelBy(p => p.depId == depId);
           if (iret > 0)
           {
               return new AjaxMsgModel
               {
                   Statu = AjaxStatu.ok,
                   Msg = "组织机构删除成功！",
                   Data = null,
                   BackUrl = null
               };
           }
           else
           {
               return new AjaxMsgModel
               {
                   Statu = AjaxStatu.err,
                   Msg = "组织机构删除失败！",
                   Data = null,
                   BackUrl = null
               };
           }

        }
        #endregion
    }
}