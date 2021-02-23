using System.Web.Mvc;

namespace MvcZodiac.Areas.Zodiac_Areas
{
    public class Zodiac_AreasAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Zodiac_Areas";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                this.AreaName+"_default",
                this.AreaName+"/{controller}/{action}/{id}",
                new { area = this.AreaName, controller = "ZodiacIndex", action = "Index", id = UrlParameter.Optional },
                new string[] { "MvcZodiac.Areas." + this.AreaName + ".Controllers" }
            );
        }
    }
}
