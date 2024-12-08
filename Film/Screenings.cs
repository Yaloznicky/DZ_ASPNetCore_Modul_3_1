using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgectFilm
{
    public class Screenings
    {

        public string[]? date { get; set; }
        public string[]? time { get; set; }

        public Screenings() { }

        //public Screenings(string[]? date, string[]? time)
        //{
        //    this.date = date;
        //    this.time = time;
        //}

        public Screenings(string? date, string? time)
        {
            this.date = ParsToArray(date!);
            this.time = ParsToArray(time!);
        }

        public string GetDateToString()
        {
            string tmp = "";
            foreach (var item in date!)
            {
                if (tmp != "") tmp += ",";
                tmp += item.ToString();
            }
            return tmp;
        }

        public string GetTimeToString()
        {
            string tmp = "";
            foreach (var item in time!)
            {
                if (tmp != "") tmp += ",";
                tmp += item.ToString();
            }
            return tmp;
        }

        private string[] ParsToArray(string value)
        {
            string[] tmp = value.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < tmp.Length; i++)
            {
                tmp[i].Trim(' ');
            }

            return tmp;
            //return value.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
