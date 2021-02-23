using System.Web.Mvc;

namespace MvcZodiac.Areas.EasyUI_Areas
{
    public class EasyUI_AreasAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "EasyUI_Areas";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                this.AreaName + "_default",
                this.AreaName + "/{controller}/{action}/{id}",
                new { area = this.AreaName, controller = "AdminIndex", action = "Index", id = UrlParameter.Optional },
                new string[] { "MvcZodiac.Areas." + this.AreaName + ".Controllers" }
            );
        }
    }
}
