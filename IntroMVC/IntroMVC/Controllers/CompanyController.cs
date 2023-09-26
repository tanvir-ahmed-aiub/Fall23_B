using IntroMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace IntroMVC.Controllers
{
    public class CompanyController : Controller
    {
        // GET: Company
        public ActionResult Index()
        {
            Company c = new Company();
            c.Id = 1;

            c.Name = "ABC Company";
            c.Address = "Dhaka, Bangladesh";
            c.Email = "abc@xyz.com";
            c.Descr = "Loren Ipsum";
            return View(c);
        }
        public ActionResult Projects() {
            var p1 = new Project() { 
                Title= "P1",
                Client = "C1"
            };
            var p2 = new Project() { 
                Title = "P2",
                Client="C2"
            };
            var projects = new Project[] { p1, p2 };
            return View(projects);
        }
        public ActionResult Team() {
            var names = new string[] { "Rahim", "Karim", "Salam", "Kalam" };

            return View(names);
        }
    }
}