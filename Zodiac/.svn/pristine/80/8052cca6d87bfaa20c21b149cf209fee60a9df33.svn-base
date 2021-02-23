using System.Web.Mvc;

namespace MvcZodiac.Areas.TMS_Areas
{
    public class TMS_AreasAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "TMS_Areas";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "TMS_Areas_default",
                "TMS_Areas/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
