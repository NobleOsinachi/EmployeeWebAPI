using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Results;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace WebAPIDemo.Controllers
{
    public sealed class Noble
    {
        public static readonly Noble Optional;

        public int Id { get; set; }
        public string Name{ get; set; }
    }
    //[Authorize]
    //[EnableCors("*", "*", "*")]
    public class ValuesController : ApiController
    {
        // GET api/values
        public string Get()
        {
            var n = new Noble()
            {
                Id = 1,
                Name = "Osinachi", 
            };
            
            return JsonConvert.SerializeObject(n, Formatting.Indented);


            //return new string[] { "value1", "value2", new DateTime(1998, 03, 25).ToLongDateString() };
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
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
