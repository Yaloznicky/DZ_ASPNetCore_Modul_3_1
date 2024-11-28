using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgectFilm
{
    public class Film
    {
        public string? movieTitle { get; set; }
        public string? director { get; set; }
        public string? style { get; set; }
        public string? shortDescription { get; set; }
        public List<Screenings>? listOfScreenings { get; set; }
    }
}
