using IntroAPI.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IntroAPI.Controllers
{
    public class DepartmentController : ApiController
    {
        [HttpGet]
        [Route("api/departments/all")]
        public HttpResponseMessage AllDept() {
            var db = new DemoFall23_BEntities();
            try
            {
                var depts = db.Departments.ToList();
                return Request.CreateResponse(HttpStatusCode.OK, depts);
            }
            catch (Exception ex) { 
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.InnerException);
            }
        }
        [HttpGet]
        [Route("api/departments/{id}")]
        public HttpResponseMessage GetDept(int id) {
            var db = new DemoFall23_BEntities();
            try {
                var data = db.Departments.Find(id);
                if (data != null)
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                else
                    return Request.CreateResponse(HttpStatusCode.NotFound, new {  Msg="Data not found" });
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.InnerException);
            }
        }
        [HttpPost]
        [Route("api/departments/create")]
        public HttpResponseMessage Create(Department d) {
            var db = new DemoFall23_BEntities();
            try {
                db.Departments.Add(d);
                db.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.Created, new { Msg="Created"});
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.InnerException);
            }
        }

        [HttpPost]
        [Route("api/departments/update")]
        public HttpResponseMessage Update(Department d) {
            var db = new DemoFall23_BEntities();
            try {
                var exd = db.Departments.Find(d.Id);
                db.Entry(exd).CurrentValues.SetValues(d);
                db.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg="Updated",Data= exd});
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.InnerException);
            }
        }
    }
}
