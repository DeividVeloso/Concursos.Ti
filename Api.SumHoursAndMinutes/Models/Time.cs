using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.SumHoursAndMinutes.Models
{
    public class Time
    {

        public Time(int hour, decimal minutes)
        {
            this.Hour = hour;
            this.Minutes = minutes;
        }

        public int Hour { get; set; }
        public decimal Minutes { get; set; }

        public string MinutesToHours()
        {
            decimal totalHoras = (this.Minutes * 1) / 60;
            decimal restoMinutes = totalHoras - Math.Truncate(totalHoras);

            decimal MinutosEmHoras = (restoMinutes * 60) / 100;

            return string.Format("{0}:{1}", Math.Truncate(totalHoras), MinutosEmHoras.ToString().Replace("0,", "").PadRight(2, '0'));
        }
    }
}