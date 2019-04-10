using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyApi.Controllers
{
    public class ValuesController : ApiController
    {
        private static List<string> myStrings = new List<string>() { "value0", "value1", "value2" };

        // GET api/values
        public IEnumerable<string> Get()
        {
            return myStrings;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return myStrings[id];
        }

        // POST api/values
        public string Post([FromBody]string value)
        {
            myStrings.Add(value);
            return value;
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
            myStrings[id] = value;
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            myStrings.RemoveAt(id);
        }
    }
}
