using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NHP_OnTapls12.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult NhpIndex()
        {
            return View();
        }

        public ActionResult NhpAbout()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult NhpContact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}