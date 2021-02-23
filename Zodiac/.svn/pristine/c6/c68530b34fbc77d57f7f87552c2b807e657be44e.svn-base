using Common;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcZodiac.Areas.Models
{
    public partial class Model_Sys_UserVipPermission
    {
        #region 根据用户编号得到特权信息
        /// <summary>
        /// 根据用户编号得到特权信息
        /// </summary>
        /// <param name="userId">用户编号</param>
        /// <returns>特权信息</returns>
        public static dynamic GetUserVipPermission(int userId)
        {
            List<int> listVipPerIds = oc.BllSession.ISys_UserVipPermissionBLL.Entities
                .Where(vp => vp.vipUserId == userId)
                .Select(vp => vp.vipPermission).ToList();
            var listPers = oc.BllSession.ISys_PermissionBLL.Entities
                .Where(p => listVipPerIds.Contains(p.pid)).OrderBy(p => p.pOrder)
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
                       p.pIsShow,
                       p.pIsDel
                   }
                ).ToList();
            return new DataGrid
            {
                total = listPers.Count(),
                rows = listPers,
                footer = null
            };
        } 
        #endregion        

        #region 设置用户特权
        public static AjaxMsgModel SetUserVips(List<Sys_UserVipPermission> uvs, int uId = 0)
        {
            int iret = oc.BllSession.ISys_UserVipPermissionBLL.SetUserVips(uvs, uId);

            if (iret >= 0)
            {
                return new AjaxMsgModel
                {
                    Statu = AjaxStatu.ok,
                    Msg = "用户特权配置成功！",
                    Data = null,
                    BackUrl = null
                };
            }
            else
            {
                return new AjaxMsgModel
                {
                    Statu = AjaxStatu.err,
                    Msg = "用户特权配置失败！",
                    Data = null,
                    BackUrl = null
                };
            }
        }
        #endregion
    }
}