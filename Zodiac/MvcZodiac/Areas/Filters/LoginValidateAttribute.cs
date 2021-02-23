using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcZodiac.Areas.Models;
using MvcZodiac.Controllers;
using Common;
namespace MvcZodiac.Areas.Filters
{
    public class LoginValidateAttribute:AuthorizeAttribute
    {
        #region  在过程请求授权时调用
        //
        // 摘要: 
        //     在过程请求授权时调用。
        //
        // 参数: 
        //   filterContext:
        //     筛选器上下文，它封装有关使用 System.Web.Mvc.AuthorizeAttribute 的信息。
        //
        // 异常: 
        //   System.ArgumentNullException:
        //     filterContext 参数为 null。
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            /**
             * 如果请求的区域包含area并且area的名称等于Admin_Areas
             * 那么就进行权限验证 
             * */
            if(filterContext.RouteData.DataTokens.Keys.Contains("area")
                && filterContext.RouteData.DataTokens["area"].ToString().ToLower() == "admin_areas" && filterContext.RouteData.DataTokens["area"].ToString().ToLower() == "tms_areas")
            {
                /**
                   * 验证用户是否登录
                   * */
                if (!Model_Sys_UserInfo.IsLogin())
                { ///如果没有登录那么就跳转到登录页面
                    filterContext.Result = new BaseController().Redirect("/AdminLogin/Login?msg=noLogin", filterContext.ActionDescriptor, AjaxStatu.nologin
                    );
                }
                else
                {
                    /**
                     * Action方法本身及它所属控制器都没有定义Skip特性
                     * 那么就可以进行权限验证
                     * */
                    //!filterContext.ActionDescriptor.IsDefined(typeof(Common.Attributes.SkipAttribute),false
                    if (!filterContext.ActionDescriptor.AttributeExists<Common.Attributes.SkipAttribute>(false)
                        && !filterContext.ActionDescriptor.ControllerDescriptor.IsDefined(typeof(Common.Attributes.SkipAttribute), false))
                    {
                        //验证该登录用户是否有访问该页面的权限
                        string strAreaName = filterContext.RouteData.DataTokens["area"].ToString().ToLower();
                        string strControllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName.ToLower();
                        string strActionName = filterContext.ActionDescriptor.ActionName.ToLower();
                        string strHttpMethod = filterContext.HttpContext.Request.HttpMethod;
                        HttpMethod httpMethod = strHttpMethod.ToLower().Equals("get") ? HttpMethod.Get
                            : strHttpMethod.ToLower().Equals("post") ? HttpMethod.Post : HttpMethod.HEAD;

                        if (!Model_Sys_Permission.HasPermission(strAreaName, strControllerName, strActionName, httpMethod))
                        {
                            filterContext.Result = new BaseController().Redirect("/AdminLogin/Login?msg=noPermission", filterContext.ActionDescriptor, AjaxStatu.noperm);
                        }
                    }
                }
            }

        } 
        #endregion
    }
}