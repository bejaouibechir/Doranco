using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProductServiceREST.Controllers
{
    public class ValuesController : ApiController
    {
        List<string> _values;
        public ValuesController()
        {
            _values = new List<string>
                (new string[] { "value1", "value2","value3","value4","value5","value6" });
        }
        
        // GET api/values
        public IEnumerable<string> Get()
        {
            return _values;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return _values[id];
        }

       
        // POST api/values
        public void Post([FromBody] string value)
        {
            _values.Add(value);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string newvalue)
        {
            string current = _values[id];
            _values[id] = newvalue;
        }

        // DELETE api/values/5
        public void Delete(int id)
        {

            _values.RemoveAt(id);
        }
    }
}
