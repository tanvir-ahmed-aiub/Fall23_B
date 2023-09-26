using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LayoutIntroandForm.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            
            return View();
        }
        public ActionResult About() {
            return View();
        }
        public ActionResult Login() {
            return View();
        }
        public ActionResult LoginSubmit() {
            //validation
            //authentication
            TempData["msg"] = "Login Successfull";
            //return Redirect("https://www.aiub.edu");
            return RedirectToAction("Index","Dashboard");
            
        }
    }
}