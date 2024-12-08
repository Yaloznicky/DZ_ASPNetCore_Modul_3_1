using ProgectFilm;
using ProgectListFilms;

namespace MovieSchedule.Services
{
    public interface IDbService
    {
        public List<Film>? GetFilmList();
        public void SetFilmList(List<Film> listFilms);
    }

    public class DbService : IDbService
    {
        public List<Film>? GetFilmList()
        {
            return new ListFilms().GetFilmList();
        }

        public void SetFilmList(List<Film> listFilms)
        {
            new ListFilms().WriteDB(listFilms);
        }
    }

    public static class ServiceProviderDataBaseExtentions
    {
        public static void AddDataBaseService(this IServiceCollection services)
        {
            services.AddScoped<IDbService, DbService>();
        }
    }
}
