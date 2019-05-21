using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationPlatform.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
        public ActionResult Platform()
        {
            return View();
        }

        public ActionResult Homepage()
        {
            return View();
        }
        public ActionResult Abc()
        {
            return View();
        }
    }
}