﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {

        }

        // PUT api/values/5
        [HttpPut]
        public void Put(int id, [FromBody]string value)
        {

        }

        // DELETE api/values/5
        [CheckModelForNull]
        public void Delete(int id)
        {

        }
       
        //[CheckModelForInt]
        [Route("test-int")]
        public IHttpActionResult CheckInt(ReqTest reqTest)
        {
            if (ModelState.IsValid)
            {
                return Ok("Ok");
            }
            else
            {
                return Ok("Error");
            }
        }
    }
}
