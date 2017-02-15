using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SicIdev.API.Controllers
{
    //[Authorize]
    public class ValuesController : ApiController
    {
        public List<String> OurList = new List<string>()
        {
            "Valeur 1",
            "Valeur 2",
            "Valeur 3",
            "Valeur 4",
            "Valeur 5"
        };
        // GET api/values
        public IEnumerable<string> Get()
        {
            return OurList;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return OurList[id];
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
            OurList.Add(value);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
            OurList.Insert(id,value);
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            OurList.RemoveAt(id);
        }
    }
}
