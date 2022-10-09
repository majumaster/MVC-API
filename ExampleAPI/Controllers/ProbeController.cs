using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace ExampleAPI.Controllers
{
    public class ProbeController : ApiController
    {
        // GET: Probe
        [Route("~/")]
        public IHttpActionResult Get()
        {
            return Ok("Ok");
        }
    }
}