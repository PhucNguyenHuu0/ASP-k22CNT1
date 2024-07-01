using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NHPLS11.Controllers
{
    public class NhpHomeController : Controller
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