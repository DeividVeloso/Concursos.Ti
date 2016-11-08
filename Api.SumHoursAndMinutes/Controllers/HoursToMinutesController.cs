using Api.SumHoursAndMinutes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api.SumHoursAndMinutes.Controllers
{
    public class HoursToMinutesController : ApiController
    {
        // POST: api/MinutesToHours
        [HttpPost]
        public decimal HoursToMinutes(Time request)
        {
            Time objTime = new Time(request.Hour, request.Minutes);

            return objTime.HoursToMinutes();
        }
    }
}
