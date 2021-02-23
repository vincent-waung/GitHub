using System.Web.Mvc;

namespace MvcZodiac.Areas.OnlineBooking_Areas
{
    public class OnlineBooking_AreasAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "OnlineBooking_Areas";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "OnlineBooking_Areas_default",
                "OnlineBooking_Areas/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
