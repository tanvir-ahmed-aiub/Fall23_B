using IntroEF.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroEF.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var db = new DemoFall23_BEntities();
            var data = db.Departments.ToList();
            return View(data);

        }
        public ActionResult Details(int id) {

            var db = new DemoFall23_BEntities();
            var data = db.Departments.Find(id);
            //ViewBag.Students = (from s in db.Students
            //                   where s.DeptId == id
            //                   select s).ToList();
            //ViewBag.Courses = (from c in db.Courses
            //                   where c.DeptId == id
            //                   select c).ToList();
            return View(data);
        }
        [HttpGet]
        public ActionResult Create() { 
            return View();
        }
        [HttpPost]
        public ActionResult Create(Department d) {
            var db = new DemoFall23_BEntities();
            db.Departments.Add(d);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id) {
            var db = new DemoFall23_BEntities();
            var data = (from d in db.Departments
                       where d.Id == id
                       select d).SingleOrDefault();
            return View(data);
        }
        [HttpPost]
        public ActionResult Edit(Department d) {
            var db = new DemoFall23_BEntities();
            //var data = (from dp in db.Departments
            //            where dp.Name.Equals(d.Name)
            //            select dp).SingleOrDefault();
            var exdata = db.Departments.Find(d.Id);
            //db.Departments.Remove(exdata);
            exdata.Name = d.Name;
            db.Entry(exdata).CurrentValues.SetValues(d);
            //exdata.F1 = d.F1;
            //exdata.F2 = d.F2;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult Login() {
            //form valiate
            //authentication
            Session["user"] = "Tanvir";
            return RedirectToAction("Index", "Student");
        }
        public ActionResult About()
        {
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