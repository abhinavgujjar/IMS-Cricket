﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Howzzzat.Controllers
{
    public class RankingsController : ApiController
    {
        // GET api/rankings
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/rankings/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/rankings
        public void Post([FromBody]string value)
        {
        }

        // PUT api/rankings/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/rankings/5
        public void Delete(int id)
        {
        }
    }
}
