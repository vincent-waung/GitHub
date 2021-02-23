using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Common.Log;
namespace MvcZodiac.Filters
{
    /**
     * 通过过滤器抓捕项目对应的异常信息，并通过log4net记录到数据库中
     * */
    public class CustomErrorProcessAttribute : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            var ex = filterContext.Exception;
            LogHelper.Error("全局抓捕异常,未知错误！", ex);
        }
    }
}