using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProgectFilm
{
    public class Film
    {
        public string? id { get; set; }
        public string? movieTitle { get; set; }
        public string? director { get; set; }
        public string? style { get; set; }
        public string? shortDescription { get; set; }
        public List<Screenings>? listOfScreenings { get; set; }


        public string GetListOfScreeningsToString()
        {
            string tmp = "";
            foreach (var item in listOfScreenings)
            {
                tmp += item.GetDateToString() + " ";
            }
            return tmp;
        }
    }
}
