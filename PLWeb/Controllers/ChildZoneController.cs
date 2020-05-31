using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UserInterface;

namespace PLWeb.Controllers
{
    public class ChildZoneController : ApiController
    {
        // GET: api/ChildZone
        /*public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        } */

        // GET: api/ChildZone/5
        public string Get(int id)
        {
            //Program Main = new Program();
            //Main.Main();
            return "You chosed first UI element";
        }

        // POST: api/ChildZone
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/ChildZone/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ChildZone/5
        public void Delete(int id)
        {
        }
    }
}
