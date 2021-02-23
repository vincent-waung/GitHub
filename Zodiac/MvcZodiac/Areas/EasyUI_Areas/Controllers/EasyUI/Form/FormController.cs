using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcZodiac.Areas.EasyUI_Areas.Controllers
{
    public class FormController : Controller
    {
        //
        // GET: /Form/

        public ActionResult Basic()
        {
            return View();
        }
        public ActionResult LoadFormData()
        {
            return View();
        }
        public ActionResult AjaxForm()
        {
            return View();
        }

    }
}
