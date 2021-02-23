using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Models;
using Common;
namespace MvcZodiac.Areas.Models
{
    public partial class Model_Sys_UserRole
    {
        #region 根据用户编号得到角色信息
        public static dynamic GetUserRoles(int usrId)
        {
            List<int> listRoles = oc.BllSession.ISys_UserRoleBLL.Entities.Where(ur => ur.urUId == usrId
                && ur.urIsDel == false).Select(ur=>ur.urRId).ToList();
            var roles = oc.BllSession.ISys_RoleBLL.Entities.Where(r=>r.rIsDel == false &&
                listRoles.Contains(r.rId))
               .Select(r => new
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

            return new DataGrid { 
               total = roles.Count(),
               rows = roles,
               footer = null
            };
        }
        #endregion

        #region 设置用户角色
        public static AjaxMsgModel SetUserRoles(List<Sys_UserRole> urs, int uId = 0)
        {
            int iret = oc.BllSession.ISys_UserRoleBLL.SetUserRoles(urs,uId);

            if (iret >= 0)
            {
                return new AjaxMsgModel
                {
                    Statu = AjaxStatu.ok,
                    Msg = "用户角色配置成功！",
                    Data = null,
                    BackUrl = null
                };
            }
            else
            {
                return new AjaxMsgModel
                {
                    Statu = AjaxStatu.err,
                    Msg = "用户角色配置失败！",
                    Data = null,
                    BackUrl = null
                };
            }
        }
        #endregion
    }
}