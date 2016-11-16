using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult Register()
        {
            ViewBag.Title = "Reg page";

            return View();
        }

        public ActionResult Login()
        {
            ViewBag.Title = "Login page";

            return View();
        }
    }
}
