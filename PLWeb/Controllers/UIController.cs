using LR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UserInterface;
using BLL.Entities;

namespace PLWeb.Controllers
{
    public class UIController : ApiController
    {
        // GET: api/UI
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/UI/5
        public ChildZone Get(int id)
        {
            UI_API api = new UI_API();
            try
            {
                return api.FindZone(id);
            }
            catch
            {
                return null;
            }
        }

        // POST: api/UI
        public void Post([FromBody]ChildZone value)
        {
            UI_API api = new UI_API();
            api.CreateNewChildZone(value);
        }

        // PUT: api/UI/5
        public void Put(int id, [FromBody]ChildZone value)
        {
            UI_API api = new UI_API();
            api.PutChildZone(id, value);
        }

        // DELETE: api/UI/5
        public void Delete(int id)
        {
            UI_API api = new UI_API();
            api.DeleteChildZone(id);
        }
    }
}
