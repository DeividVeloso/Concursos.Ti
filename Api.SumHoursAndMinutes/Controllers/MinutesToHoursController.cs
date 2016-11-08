using Api.SumHoursAndMinutes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api.SumHoursAndMinutes.Controllers
{
    public class MinutesToHoursController : ApiController
    {
        // GET: api/MinutesToHours
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/MinutesToHours/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/MinutesToHours
        public string Post(Time request)
        {
            Time objTime = new Time(request.Hour,request.Minutes);

            return objTime.MinutesToHours();
        }

        // PUT: api/MinutesToHours/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/MinutesToHours/5
        public void Delete(int id)
        {
        }
    }
}
