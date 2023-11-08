using AutoMapper;
using IntroEF.Auth;
using IntroEF.DTOs;
using IntroEF.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroEF.Controllers
{
    [Logged]
    public class StudentController : Controller
    {
        // GET: Student
        
        public ActionResult Index()
        {
            
            var db = new DemoFall23_BEntities();
            var data = db.Students.ToList();
            #region
            var cofig = new MapperConfiguration(cfg => {
                cfg.CreateMap<Student,StudentDTO>();
            });
            var mapper = new Mapper(cofig);
            var data3 = mapper.Map<List<StudentDTO>>(data);

            #endregion
            var list = Convert(data);
            return View(list);
        }
        [HttpGet]
        public ActionResult Create() {
            var db = new DemoFall23_BEntities();
            ViewBag.Depts = db.Departments.ToList();

            return View();
        }
        [HttpPost]
        public ActionResult Create(StudentDTO student) {
            if (ModelState.IsValid)
            {
                var db = new DemoFall23_BEntities();

                var cofig = new MapperConfiguration(cfg => {
                    cfg.CreateMap<StudentDTO, Student>();
                });
                var mapper = new Mapper(cofig);
                var data3 = mapper.Map<Student>(student);


                db.Students.Add(Convert(student));
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student);
            
        }
        StudentDTO Convert(Student s) {
            return new StudentDTO() { 
                Id = s.Id,
                Name = s.Name,
                DeptId = s.DeptId,
                Cgpa = s.Cgpa
            
            };
        }
        Student Convert(StudentDTO s)
        {
            return new Student()
            {
                Id = s.Id,
                Name = s.Name,
                DeptId = s.DeptId,
                Cgpa = s.Cgpa

            };
        }
        List<StudentDTO> Convert(List<Student> students) { 
            var ss = new List<StudentDTO>();
            foreach (var student in students) { 
                ss.Add(Convert(student));
            }
            return ss;
        }


    }

}