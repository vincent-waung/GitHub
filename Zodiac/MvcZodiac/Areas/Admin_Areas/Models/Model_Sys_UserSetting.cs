
using Common;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace MvcZodiac.Areas.Models
{
    public partial class Model_Sys_UserSetting
    {
        #region 修改用户配置
        public static AjaxMsgModel EditUserSetting(Sys_UserSetting UserSetting)
        {
            Expression<Func<Sys_UserSetting, object>>[] modifyProperties =
                new Expression<Func<Sys_UserSetting, object>>[]{
                    p=>p.SettingValue
                };
            int iret = oc.BllSession.ISys_UserSettingBLL.ModifyBy(UserSetting, s => s.UserCode == UserSetting.UserCode && s.SettingCode == UserSetting.SettingCode
                , modifyProperties);
            if (iret > 0)
            {
                return new AjaxMsgModel
                {
                    Statu = AjaxStatu.ok,
                    Msg = "用户配置修改成功!",
                    Data = null,
                    BackUrl = null
                };
            }
            else {
                return new AjaxMsgModel
                {
                    Statu = AjaxStatu.err,
                    Msg = "用户配置修改失改!",
                    Data = null,
                    BackUrl = null
                };
            }

        }
        #endregion

        #region 根据条件查询用户的一个配置信息
        public static dynamic GetOneUserSetting(Sys_UserSetting UserSetting)
        {
            var us = oc.BllSession.ISys_UserSettingBLL.Entities.Where(s => s.UserCode == UserSetting.UserCode && s.SettingCode == UserSetting.SettingCode).FirstOrDefault();
            return us;
        }
        #endregion
    }
}