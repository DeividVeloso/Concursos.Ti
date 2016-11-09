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
            //Minutos e divide por 60 transforma em horas
            decimal totalHoras = (this.Minutes * 1) / 60;
            //Pega o minutos da hora transformada
            decimal restoMinutes = totalHoras - Math.Truncate(totalHoras);

            //Multiplica os minutos em hora 
            decimal MinutosEmHoras = (restoMinutes * 60) / 100;

            return string.Format("{0}:{1}", Math.Truncate(totalHoras), MinutosEmHoras.ToString().Replace("0,", "").PadRight(2, '0'));
        }

        public decimal HoursToMinutes()
        {


            DateTime time;
            string timeStr = string.Concat(this.Hour,":",this.Minutes);

            if (DateTime.TryParse(timeStr, out time))
            {
                //Transfroma hora em minutos
                decimal horaEmMinutos = (this.Hour * 60);

                //Minutos e transfrma em horas ex 15minutos é igual a 0.25 horas base 100// 0.25 * 60 é igual a 15 minutos
                //decimal minutosReais = (this.Minutes / 60) * 60;

                decimal totalMinutos = horaEmMinutos + this.Minutes;

                return totalMinutos;
            }

            return 0;
        }
    }
}