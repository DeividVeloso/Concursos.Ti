﻿using Api.SumHoursAndMinutes.Models;
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
        //

        // POST: api/MinutesToHours
        [HttpPost]
        public string MinutesToHours(Time request)
        {
            Time objTime = new Time(request.Hour, request.Minutes);

            return objTime.MinutesToHours();
        }
    }
}
