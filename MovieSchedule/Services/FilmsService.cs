using System;
using ProgectFilm;

namespace MovieSchedule.Services
{
    public interface IFilmsService
    {
        public List<Film>? films { get; }
        public List<Film>? SearchFilms(string chapter, string query);
        public void EditFilm(Film film);
        public void NewFilm(Film film);
        public void DeleteFilm(string id);
        public int SearchIndex(string id, List<Film> films);
    }

    public class FilmsService(IDbService db) : IFilmsService
    {
        List<Film>? IFilmsService.films 
        { 
            get => db.GetFilmList();
        }

        public void NewFilm(Film film)
        {
            List<Film> films = db.GetFilmList()!;
            films.Add(film);
            db.SetFilmList(films);
        }

        public void DeleteFilm(string id)
        {
            List<Film> films = db.GetFilmList()!;
            int index = SearchIndex(id, films);

            if (index != -1)
            {
                films.RemoveAt(index);
                db.SetFilmList(films);
            }
        }

        public void EditFilm(Film film)
        {
            List<Film> films = db.GetFilmList()!;
            int index = SearchIndex(film.id!, films);

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

        public int SearchIndex(string id, List<Film> films)
        {
            int index = -1;
            for (int i = 0; i < films!.Count; i++)
            {
                if (films[i].id == id)
                {
                    index = i;
                    break;
                }
            }
            return index;
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
