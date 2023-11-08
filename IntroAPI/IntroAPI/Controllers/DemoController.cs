using IntroAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IntroAPI.Controllers
{
    public class DemoController : ApiController
    {
        [HttpGet]
        [Route("api/names")]
        public HttpResponseMessage Get() {
            var names = new string[] { "Tanvir", "Sabbir" };
            return Request.CreateResponse(HttpStatusCode.OK,names);
        }
        [HttpGet]
        [Route("api/name/{st_id}")]
        public HttpResponseMessage GetName(int st_id) {
            string name = st_id == 1 ? "Tanvir" : "not rec";
            return Request.CreateResponse(HttpStatusCode.OK,name);
        }
        [HttpPost]
        [Route("api/test/post")]
        public HttpResponseMessage TestPost(Login u) { 
            return Request.CreateResponse(HttpStatusCode.OK,u.Uname);
        }
        
    }
}
