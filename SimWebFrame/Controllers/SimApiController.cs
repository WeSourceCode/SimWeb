using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SimWebFrame.Controllers
{
    public class SimApiController : ApiController
    {
        // GET: api/SimApi
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/SimApi/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/SimApi
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/SimApi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SimApi/5
        public void Delete(int id)
        {
        }
    }
}
