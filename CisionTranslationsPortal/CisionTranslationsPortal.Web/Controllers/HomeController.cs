using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CisionTranslationsPortal.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to Cision Translations Portal";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
