using System.Web;
using System.Web.Mvc;
using MvcZodiac.Areas.Filters;
using MvcZodiac.Filters;
namespace MvcZodiac
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            //注册过滤器
            //filters.Add(new LoginValidateAttribute());

            filters.Add(new CustomErrorProcessAttribute());
        }
    }
}