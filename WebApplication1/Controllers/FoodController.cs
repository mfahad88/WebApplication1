﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    [RoutePrefix("api/Food")]
    public class FoodController : ApiController
    {
        // GET: api/Food
        [Route("")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Food/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Food
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Food/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Food/5
        public void Delete(int id)
        {
        }
    }
}
