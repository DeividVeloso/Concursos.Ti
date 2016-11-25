using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Veloso.CalculaHorasEstudos.Domain;

namespace Api.SumHoursAndMinutes.Controllers
{
    public class MinutesToHoursController : ApiController
    {
        //

        // POST: api/MinutesToHours
        [HttpPost]
        [EnableCors(origins: "http://www.negociodireto.com", headers: "*", methods: "*")]
        public string MinutesToHours(Time request)
        {
            Time objTime = new Time(request.Hour, request.Minutes);

            return objTime.MinutesToHours();
        }
    }
}
