using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcZodiac.Areas.EasyUI_Areas.Controllers
{
    public class DateController : Controller
    {
        //
        // GET: /Date/

        public ActionResult Basic()
        {
            return View();
        }
        public ActionResult DateFormat()
        {
            return View();
        }

        public ActionResult ValidateDateBox()
        {
            return View();
        }

        public ActionResult DateBoxEvents()
        {
            return View();
        }

    }
}
