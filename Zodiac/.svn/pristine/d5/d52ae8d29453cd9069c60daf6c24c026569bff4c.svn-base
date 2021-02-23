using System.Web.Mvc;

namespace MvcZodiac.Areas.Admin_Areas
{
    public class AdminAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Admin_Areas";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                this.AreaName+"_default",
                this.AreaName+"/{controller}/{action}/{id}",
                new { area= this.AreaName, controller ="AdminIndex", action = "Index", id = UrlParameter.Optional },
                new string[] { "MvcZodiac.Areas." + this.AreaName + ".Controllers" }
            );
        }
    }
}
