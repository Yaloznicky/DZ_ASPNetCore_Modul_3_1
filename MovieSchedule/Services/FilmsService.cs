using ProgectFilm;

namespace MovieSchedule.Services
{
    public interface IFilmsService
    {
        //public List<Film>? films { set; get; }
        public List<Film>? films { get; }
        public List<Film>? SearchFilms(string chapter, string query);
        public void EditFilm(Film film); 
    }

    public class FilmsService(IDbService db) : IFilmsService
    {
        List<Film>? IFilmsService.films 
        { 
            get => db.GetFilmList();
            //set => db.SetFilmList(value!);
        }

        public void EditFilm(Film film)
        {
            List<Film> films = db.GetFilmList()!;
            int index = -1;
            for (int i=0; i<films!.Count; i++)
            {
                if (films[i].id == film.id)
                {
                    index = i; 
                    break;
                }
            }

            if (index != -1)
            {
                films[index] = film;
                db.SetFilmList(films);
            }

        }

        public List<Film>? SearchFilms(string chapter, string query)
        {
            if(query != null)
                switch (int.Parse(chapter))
                {
                    case 1:
                        return db.GetFilmList()!.FindAll(q => q.movieTitle!.ToLower().Contains(query.ToLower()));
                    case 2:
                        return db.GetFilmList()!.FindAll(q => q.director!.ToLower().Contains(query.ToLower()));
                    case 3:
                        return db.GetFilmList()!.FindAll(q => q.style!.ToLower().Contains(query.ToLower()));
                    case 4:
                        return db.GetFilmList()!.FindAll(q => q.shortDescription!.ToLower().Contains(query.ToLower()));
                    case 5:
                        return db.GetFilmList()!.FindAll(q => q.GetDate().ToLower().Contains(query.ToLower()));
                    default:
                        return null;
                }
            else 
                return null;
        }
    }


    public static class ServiceProviderFilmsExtentions
    {
        public static void AddFilmsService(this IServiceCollection services)
        {
            services.AddScoped<IFilmsService, FilmsService>();
        }
    }

}
