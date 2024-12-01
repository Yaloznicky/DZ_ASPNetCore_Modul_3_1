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

        public string GetDateToString()
        {
            string tmp = "";
            foreach (var item in date)
            {
                tmp += item.ToString() + " ";
            }
            return tmp;
        }
    }
}
