using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.CName = "Adv. Programming with .Net";
            ViewData["Count"] = 40;
            return View();
        }
        public ActionResult Index2() {
            return View();
        }

        public ActionResult About()
        {
            string[] names = new string[] {"Shanto","Saida","Bishal","Mohammad","Nafis" };
            ViewBag.Names = names;

            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}