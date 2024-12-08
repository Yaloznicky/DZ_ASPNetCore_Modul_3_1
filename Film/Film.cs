namespace ProgectFilm
{
    public class Film
    {
        public string? id { get; set; }
        public string? movieTitle { get; set; }
        public string? director { get; set; }
        public string? style { get; set; }
        public string? shortDescription { get; set; }
        public Screenings? listOfScreenings { get; set; }

        public Film(){}

        public Film(string? id, string? movieTitle, string? director, string? style, string? shortDescription, Screenings? listOfScreenings)
        {
            this.id = id;
            this.movieTitle = movieTitle;
            this.director = director;
            this.style = style;
            this.shortDescription = shortDescription;
            this.listOfScreenings = listOfScreenings;
        }

        public string GetDate()
        {
            return listOfScreenings!.GetDateToString(); 
        }

        public string GetTime()
        {
            return listOfScreenings!.GetTimeToString();
        }
    }
}
