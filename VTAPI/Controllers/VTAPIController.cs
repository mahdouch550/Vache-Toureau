using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using VT_PCLs;

namespace VTAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VTAPIController : ControllerBase
    {
        // GET: api/VTAPI
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/VTAPI/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/VTAPI
        [HttpPost]
        public ActionResult<String> Post()
        {
            var stream = Request.Body;
            String jsonString;
            Session session;
            using(var ms = new MemoryStream())
            {
                stream.CopyTo(ms);
                jsonString = Encoding.UTF8.GetString(ms.ToArray());
                session = JsonConvert.DeserializeObject(jsonString) as Session;
                return new OkObjectResult(session.ID);
            }
        }

        // PUT: api/VTAPI/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
