using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using static System.Net.WebRequestMethods;

namespace WebAPIDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }


        public ActionResult ImageUploader()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }
        public ActionResult Dashboard()
        {
            return View();
        }

    }
}
